using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContractLoader
{
    class Program
    {
        static void Main(string[] args)
        {
            string dataFilepath, schemaFilepath;

            Console.WriteLine("ContractImporter");

            ProcessArguments(args, out dataFilepath, out schemaFilepath);

            ContractLoader ci = new ContractLoader(dataFilepath, schemaFilepath);

            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }

        static void ProcessArguments(string[] args, out string dataFilepath, out string schemaFilepath)
        {
            dataFilepath = "";
            schemaFilepath = "";

            for (int i = 0; i < args.Length; i++)
            {
                switch (args[i])
                {
                    case "-d":
                        if (args.Length > i)
                        {
                            dataFilepath = args[i + 1];
                            // Console.WriteLine($"Used data file [{dataFilepath}]");
                            i += 1;
                        }
                        else
                        {
                            ShowHelp($"Parameter [-d] without value");
                        }
                        break;
                    case "-s":
                        if (args.Length > i)
                        {
                            schemaFilepath = args[i + 1];
                            // Console.WriteLine($"Used schema file [{schemaFilepath}]");
                            i += 1;
                        }
                        else
                        {
                            ShowHelp($"Parameter [-s] without value");
                        }
                        break;
                    default:
                        ShowHelp($"Undefined parameter [{args[i]}]");
                        break;
                }
            }

            if (dataFilepath.Length == 0 || schemaFilepath.Length == 0)
            {
                ShowHelp($"Data file or schema not defined");
            }
        }

        static void ShowHelp(string msg)
        {
            Console.WriteLine("Usage: ContractImporter.exe -d <xml data file path> [-s <scheme file path>]");
            Console.WriteLine($"Error: {msg}");
            Environment.Exit(1);
        }
    }
}
