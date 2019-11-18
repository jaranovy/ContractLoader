﻿using ContractLoader.DbModel;
using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace ContractLoader
{
    public class ContractLoader
    {
        private const string DEFAULT_SCHEMA = "http://creditinfo.com/schemas/Sample/Data";

        private static ContractDbContext db = new ContractDbContext();

        public ContractLoader(string dataFilepath, string schemaFilepath)
        {
            Console.WriteLine($"Used data file [{dataFilepath}]");
            Console.WriteLine($"Used schema file [{schemaFilepath}]");

            /* Clean DB for debug purpose */
            db.individuals.RemoveRange(db.individuals);
            db.subjectRoles.RemoveRange(db.subjectRoles);
            db.contracts.RemoveRange(db.contracts);
            db.SaveChanges();

            ReadDataFile(dataFilepath, schemaFilepath);
        }

        private void ReadDataFile(string dataFilepath, string schemaFilepath)
        {
            XmlSerializer contractSerializer = new XmlSerializer(typeof(Batch));

            /* Define XML Reader Settings */
            XmlReaderSettings xmlReaderSettings = new XmlReaderSettings();
            xmlReaderSettings.ConformanceLevel = ConformanceLevel.Document;
            xmlReaderSettings.ValidationType = ValidationType.Schema;
            xmlReaderSettings.Schemas.Add(DEFAULT_SCHEMA, schemaFilepath);

            using (XmlReader xmlReader = XmlReader.Create(dataFilepath, xmlReaderSettings))
            {
                xmlReader.MoveToContent();

                while (xmlReader.ReadToFollowing("Contract"))
                {
                    BatchContract batchCobtract = (BatchContract)contractSerializer.Deserialize(xmlReader.ReadSubtree());

                    Console.WriteLine($"Contract {batchCobtract.ContractCode} loaded");

                    Contract contract = ConvertBatchContractToContract(batchCobtract);

                    Console.WriteLine($"Contract {batchCobtract.ContractCode} mapped to object");

                    PrintContract(contract);

                    SaveContractToDb(contract);

                    Console.WriteLine($"Contract {batchCobtract.ContractCode} saved into DB");
                }
            }
        }

        private Contract ConvertBatchContractToContract(BatchContract batchContract)
        {
            /* Map BatchContract to Contract */
            Contract contract = new Contract()
            {
                contractCode = batchContract.ContractCode,

                /* Map BatchContractContractData to Contract */
                phaseOfContract = batchContract.ContractData.PhaseOfContract == ContractPhaseOfContract.Open ? "Open" : "Close",
                originalAmount = new Amount() { value = batchContract.ContractData.OriginalAmount.Value, currency = batchContract.ContractData.OriginalAmount.Currency.ToString() },
                installmentAmount = new Amount() { value = batchContract.ContractData.InstallmentAmount.Value, currency = batchContract.ContractData.InstallmentAmount.Currency.ToString() },
                currentBalance = new Amount() { value = batchContract.ContractData.CurrentBalance.Value, currency = batchContract.ContractData.CurrentBalance.Currency.ToString() },
                overdueBalance = new Amount() { value = batchContract.ContractData.OverdueBalance.Value, currency = batchContract.ContractData.OverdueBalance.Currency.ToString() },
                dateOfLastPayment = batchContract.ContractData.DateOfLastPayment,
                nextPaymentDate = batchContract.ContractData.NextPaymentDate,
                dateAccountOpened = batchContract.ContractData.DateAccountOpened,
                realEndDate = batchContract.ContractData.RealEndDate
            };

            /* Map BatchContractIndividuals to Individuals and add them into Contract */
            contract.individuals = new List<Individual>();
            foreach (BatchContractIndividual batchIndividual in batchContract.Individual)
            {
                Individual individual = new Individual()
                {
                    CustomerCode = batchIndividual.CustomerCode,
                    contractCode = contract.contractCode,
                    FirstName = batchIndividual.FirstName,
                    LastName = batchIndividual.LastName,

                    Gender = batchIndividual.Gender.ToString(),
                    DateOfBirth = batchIndividual.DateOfBirth,
                };

                IdentificationNumber identNo = new IdentificationNumber() { nationalID = batchIndividual.IdentificationNumbers.NationalID, individual = individual };
                individual.identificationNumbers = new List<IdentificationNumber>();
                individual.identificationNumbers.Add(identNo);

                contract.individuals.Add(individual);
            }

            /* Map BatchContractSubjectRoles to SubjectRoles and add them into Contract */
            contract.subjectRoles = new List<SubjectRole>();
            foreach (BatchContractSubjectRole batchSubjectRole in batchContract.SubjectRole)
            {
                SubjectRole subjectRole = new SubjectRole()
                {
                    contractCode = contract.contractCode,
                    customerCode = batchSubjectRole.CustomerCode,
                    roleOfCustomer = batchSubjectRole.RoleOfCustomer.ToString()
                };

                if (batchSubjectRole.GuaranteeAmount != null)
                {
                    subjectRole.guaranteeAmount = new Amount(amount: batchSubjectRole.GuaranteeAmount.Value, currency: batchSubjectRole.GuaranteeAmount.Currency.ToString());
                }
                else
                {
                    subjectRole.guaranteeAmount = new Amount() { value = 0, currency = "" };
                }

                contract.subjectRoles.Add(subjectRole);
            }

            return contract;
        }


        public void PrintContract(Contract contract)
        {
            Console.WriteLine($"Contract [{contract.contractCode}]");
            Console.WriteLine($"   phaseOfContract: [{contract.phaseOfContract}]");
            Console.WriteLine($"   originalAmount: [{contract.originalAmount}]");
            Console.WriteLine($"   installmentAmount: [{contract.installmentAmount}]");
            Console.WriteLine($"   currentBalance: [{contract.currentBalance}]");
            Console.WriteLine($"   overdueBalance: [{contract.overdueBalance}]");
            Console.WriteLine($"   dateOfLastPayment: [{contract.dateOfLastPayment}]");
            Console.WriteLine($"   nextPaymentDate: [{contract.nextPaymentDate}]");
            Console.WriteLine($"   dateAccountOpened: [{contract.dateAccountOpened}]");
            Console.WriteLine($"   realEndDate: [{contract.realEndDate}]");

            Console.WriteLine($"   Individuals:");
            foreach (Individual individual in contract.individuals)
            {
                Console.WriteLine($"      CustomerCode: [{individual.CustomerCode}]");
                Console.WriteLine($"      FirstName: [{individual.FirstName}]");
                Console.WriteLine($"      LastName: [{individual.LastName}]");
                Console.WriteLine($"      Gender: [{individual.Gender}]");
                Console.WriteLine($"      DateOfBirth: [{individual.DateOfBirth}]");
                Console.WriteLine($"      IdentificationNumbers:");
                foreach (IdentificationNumber identNo in individual.identificationNumbers)
                {
                    Console.WriteLine($"         nationalID: [{identNo.nationalID}]");
                }
            }

            Console.WriteLine($"   SubjectRole:");
            foreach (SubjectRole sRole in contract.subjectRoles)
            {
                Console.WriteLine($"      customerCode: [{sRole.customerCode}]");
                Console.WriteLine($"      roleOfCustomer: [{sRole.roleOfCustomer}]");
                if (sRole.guaranteeAmount.currency.Length > 0)
                {
                    Console.WriteLine($"      guaranteeAmount: [{sRole.guaranteeAmount}]");
                }
            }
            Console.WriteLine($"-----------------------------------------------------");
        }

        private void SaveContractToDb(Contract contract)
        {
            db.contracts.Add(contract);
            db.SaveChanges();
        }
    }
}
