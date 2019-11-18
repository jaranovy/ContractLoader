﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System.Xml.Serialization;

// 
// This source code was auto-generated by xsd, Version=4.8.3928.0.
// 


/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://creditinfo.com/schemas/Sample/Data")]
[System.Xml.Serialization.XmlRootAttribute(Namespace="http://creditinfo.com/schemas/Sample/Data", IsNullable=false)]
public partial class Batch {
    
    private BatchContract[] contractField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("Contract")]
    public BatchContract[] Contract {
        get {
            return this.contractField;
        }
        set {
            this.contractField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://creditinfo.com/schemas/Sample/Data")]
public partial class BatchContract {
    
    private string contractCodeField;
    
    private BatchContractContractData contractDataField;
    
    private BatchContractIndividual[] individualField;
    
    private BatchContractSubjectRole[] subjectRoleField;
    
    /// <remarks/>
    public string ContractCode {
        get {
            return this.contractCodeField;
        }
        set {
            this.contractCodeField = value;
        }
    }
    
    /// <remarks/>
    public BatchContractContractData ContractData {
        get {
            return this.contractDataField;
        }
        set {
            this.contractDataField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("Individual")]
    public BatchContractIndividual[] Individual {
        get {
            return this.individualField;
        }
        set {
            this.individualField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("SubjectRole")]
    public BatchContractSubjectRole[] SubjectRole {
        get {
            return this.subjectRoleField;
        }
        set {
            this.subjectRoleField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://creditinfo.com/schemas/Sample/Data")]
public partial class BatchContractContractData {
    
    private ContractPhaseOfContract phaseOfContractField;
    
    private BatchContractContractDataOriginalAmount originalAmountField;
    
    private BatchContractContractDataInstallmentAmount installmentAmountField;
    
    private BatchContractContractDataCurrentBalance currentBalanceField;
    
    private BatchContractContractDataOverdueBalance overdueBalanceField;
    
    private System.DateTime dateOfLastPaymentField;
    
    private bool dateOfLastPaymentFieldSpecified;
    
    private System.DateTime nextPaymentDateField;
    
    private bool nextPaymentDateFieldSpecified;
    
    private System.DateTime dateAccountOpenedField;
    
    private bool dateAccountOpenedFieldSpecified;
    
    private System.DateTime realEndDateField;
    
    private bool realEndDateFieldSpecified;
    
    /// <remarks/>
    public ContractPhaseOfContract PhaseOfContract {
        get {
            return this.phaseOfContractField;
        }
        set {
            this.phaseOfContractField = value;
        }
    }
    
    /// <remarks/>
    public BatchContractContractDataOriginalAmount OriginalAmount {
        get {
            return this.originalAmountField;
        }
        set {
            this.originalAmountField = value;
        }
    }
    
    /// <remarks/>
    public BatchContractContractDataInstallmentAmount InstallmentAmount {
        get {
            return this.installmentAmountField;
        }
        set {
            this.installmentAmountField = value;
        }
    }
    
    /// <remarks/>
    public BatchContractContractDataCurrentBalance CurrentBalance {
        get {
            return this.currentBalanceField;
        }
        set {
            this.currentBalanceField = value;
        }
    }
    
    /// <remarks/>
    public BatchContractContractDataOverdueBalance OverdueBalance {
        get {
            return this.overdueBalanceField;
        }
        set {
            this.overdueBalanceField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType="date")]
    public System.DateTime DateOfLastPayment {
        get {
            return this.dateOfLastPaymentField;
        }
        set {
            this.dateOfLastPaymentField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool DateOfLastPaymentSpecified {
        get {
            return this.dateOfLastPaymentFieldSpecified;
        }
        set {
            this.dateOfLastPaymentFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType="date")]
    public System.DateTime NextPaymentDate {
        get {
            return this.nextPaymentDateField;
        }
        set {
            this.nextPaymentDateField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool NextPaymentDateSpecified {
        get {
            return this.nextPaymentDateFieldSpecified;
        }
        set {
            this.nextPaymentDateFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType="date")]
    public System.DateTime DateAccountOpened {
        get {
            return this.dateAccountOpenedField;
        }
        set {
            this.dateAccountOpenedField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool DateAccountOpenedSpecified {
        get {
            return this.dateAccountOpenedFieldSpecified;
        }
        set {
            this.dateAccountOpenedFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType="date")]
    public System.DateTime RealEndDate {
        get {
            return this.realEndDateField;
        }
        set {
            this.realEndDateField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool RealEndDateSpecified {
        get {
            return this.realEndDateFieldSpecified;
        }
        set {
            this.realEndDateFieldSpecified = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(TypeName="Contract.PhaseOfContract", Namespace="http://creditinfo.com/schemas/Sample/Data")]
public enum ContractPhaseOfContract {
    
    /// <remarks/>
    Open,
    
    /// <remarks/>
    Closed,
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://creditinfo.com/schemas/Sample/Data")]
public partial class BatchContractContractDataOriginalAmount {
    
    private decimal valueField;
    
    private CommonCurrency currencyField;
    
    /// <remarks/>
    public decimal Value {
        get {
            return this.valueField;
        }
        set {
            this.valueField = value;
        }
    }
    
    /// <remarks/>
    public CommonCurrency Currency {
        get {
            return this.currencyField;
        }
        set {
            this.currencyField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(TypeName="Common.Currency", Namespace="http://creditinfo.com/schemas/Sample/Data")]
public enum CommonCurrency {
    
    /// <remarks/>
    AED,
    
    /// <remarks/>
    AFN,
    
    /// <remarks/>
    ALL,
    
    /// <remarks/>
    AMD,
    
    /// <remarks/>
    ANG,
    
    /// <remarks/>
    AOA,
    
    /// <remarks/>
    ARS,
    
    /// <remarks/>
    AUD,
    
    /// <remarks/>
    AWG,
    
    /// <remarks/>
    AZN,
    
    /// <remarks/>
    BAM,
    
    /// <remarks/>
    BBD,
    
    /// <remarks/>
    BDT,
    
    /// <remarks/>
    BGN,
    
    /// <remarks/>
    BHD,
    
    /// <remarks/>
    BIF,
    
    /// <remarks/>
    BMD,
    
    /// <remarks/>
    BND,
    
    /// <remarks/>
    BOB,
    
    /// <remarks/>
    BOV,
    
    /// <remarks/>
    BRL,
    
    /// <remarks/>
    BSD,
    
    /// <remarks/>
    BTN,
    
    /// <remarks/>
    BWP,
    
    /// <remarks/>
    BYR,
    
    /// <remarks/>
    BZD,
    
    /// <remarks/>
    CAD,
    
    /// <remarks/>
    CDF,
    
    /// <remarks/>
    CHE,
    
    /// <remarks/>
    CHF,
    
    /// <remarks/>
    CHW,
    
    /// <remarks/>
    CLF,
    
    /// <remarks/>
    CLP,
    
    /// <remarks/>
    CNY,
    
    /// <remarks/>
    COP,
    
    /// <remarks/>
    COU,
    
    /// <remarks/>
    CRC,
    
    /// <remarks/>
    CUC,
    
    /// <remarks/>
    CUP,
    
    /// <remarks/>
    CVE,
    
    /// <remarks/>
    CZK,
    
    /// <remarks/>
    DJF,
    
    /// <remarks/>
    DKK,
    
    /// <remarks/>
    DOP,
    
    /// <remarks/>
    DZD,
    
    /// <remarks/>
    EEK,
    
    /// <remarks/>
    EGP,
    
    /// <remarks/>
    ERN,
    
    /// <remarks/>
    ETB,
    
    /// <remarks/>
    EUR,
    
    /// <remarks/>
    FJD,
    
    /// <remarks/>
    FKP,
    
    /// <remarks/>
    GBP,
    
    /// <remarks/>
    GEL,
    
    /// <remarks/>
    GHS,
    
    /// <remarks/>
    GIP,
    
    /// <remarks/>
    GMD,
    
    /// <remarks/>
    GNF,
    
    /// <remarks/>
    GTQ,
    
    /// <remarks/>
    GYD,
    
    /// <remarks/>
    HKD,
    
    /// <remarks/>
    HNL,
    
    /// <remarks/>
    HRK,
    
    /// <remarks/>
    HTG,
    
    /// <remarks/>
    HUF,
    
    /// <remarks/>
    IDR,
    
    /// <remarks/>
    ILS,
    
    /// <remarks/>
    INR,
    
    /// <remarks/>
    IQD,
    
    /// <remarks/>
    IRR,
    
    /// <remarks/>
    ISK,
    
    /// <remarks/>
    JMD,
    
    /// <remarks/>
    JOD,
    
    /// <remarks/>
    JPY,
    
    /// <remarks/>
    KES,
    
    /// <remarks/>
    KGS,
    
    /// <remarks/>
    KHR,
    
    /// <remarks/>
    KMF,
    
    /// <remarks/>
    KPW,
    
    /// <remarks/>
    KRW,
    
    /// <remarks/>
    KWD,
    
    /// <remarks/>
    KYD,
    
    /// <remarks/>
    KZT,
    
    /// <remarks/>
    LAK,
    
    /// <remarks/>
    LBP,
    
    /// <remarks/>
    LKR,
    
    /// <remarks/>
    LRD,
    
    /// <remarks/>
    LSL,
    
    /// <remarks/>
    LTL,
    
    /// <remarks/>
    LVL,
    
    /// <remarks/>
    LYD,
    
    /// <remarks/>
    MAD,
    
    /// <remarks/>
    MDL,
    
    /// <remarks/>
    MGA,
    
    /// <remarks/>
    MKD,
    
    /// <remarks/>
    MMK,
    
    /// <remarks/>
    MNT,
    
    /// <remarks/>
    MOP,
    
    /// <remarks/>
    MRO,
    
    /// <remarks/>
    MUR,
    
    /// <remarks/>
    MVR,
    
    /// <remarks/>
    MWK,
    
    /// <remarks/>
    MXN,
    
    /// <remarks/>
    MXV,
    
    /// <remarks/>
    MYR,
    
    /// <remarks/>
    MZN,
    
    /// <remarks/>
    NAD,
    
    /// <remarks/>
    NGN,
    
    /// <remarks/>
    NIO,
    
    /// <remarks/>
    NOK,
    
    /// <remarks/>
    NPR,
    
    /// <remarks/>
    NZD,
    
    /// <remarks/>
    OMR,
    
    /// <remarks/>
    PAB,
    
    /// <remarks/>
    PEN,
    
    /// <remarks/>
    PGK,
    
    /// <remarks/>
    PHP,
    
    /// <remarks/>
    PKR,
    
    /// <remarks/>
    PLN,
    
    /// <remarks/>
    PYG,
    
    /// <remarks/>
    QAR,
    
    /// <remarks/>
    RON,
    
    /// <remarks/>
    RSD,
    
    /// <remarks/>
    RUB,
    
    /// <remarks/>
    RWF,
    
    /// <remarks/>
    SAR,
    
    /// <remarks/>
    SBD,
    
    /// <remarks/>
    SCR,
    
    /// <remarks/>
    SDG,
    
    /// <remarks/>
    SEK,
    
    /// <remarks/>
    SGD,
    
    /// <remarks/>
    SHP,
    
    /// <remarks/>
    SLL,
    
    /// <remarks/>
    SOS,
    
    /// <remarks/>
    SRD,
    
    /// <remarks/>
    STD,
    
    /// <remarks/>
    SYP,
    
    /// <remarks/>
    SZL,
    
    /// <remarks/>
    THB,
    
    /// <remarks/>
    TJS,
    
    /// <remarks/>
    TMT,
    
    /// <remarks/>
    TND,
    
    /// <remarks/>
    TOP,
    
    /// <remarks/>
    TRY,
    
    /// <remarks/>
    TTD,
    
    /// <remarks/>
    TWD,
    
    /// <remarks/>
    TZS,
    
    /// <remarks/>
    UAH,
    
    /// <remarks/>
    UGX,
    
    /// <remarks/>
    USD,
    
    /// <remarks/>
    USN,
    
    /// <remarks/>
    USS,
    
    /// <remarks/>
    UYU,
    
    /// <remarks/>
    UZS,
    
    /// <remarks/>
    VEF,
    
    /// <remarks/>
    VND,
    
    /// <remarks/>
    VUV,
    
    /// <remarks/>
    WST,
    
    /// <remarks/>
    XAF,
    
    /// <remarks/>
    XAG,
    
    /// <remarks/>
    XAU,
    
    /// <remarks/>
    XBA,
    
    /// <remarks/>
    XBB,
    
    /// <remarks/>
    XBC,
    
    /// <remarks/>
    XBD,
    
    /// <remarks/>
    XCD,
    
    /// <remarks/>
    XDR,
    
    /// <remarks/>
    XFU,
    
    /// <remarks/>
    XOF,
    
    /// <remarks/>
    XPD,
    
    /// <remarks/>
    XPF,
    
    /// <remarks/>
    XPT,
    
    /// <remarks/>
    XTS,
    
    /// <remarks/>
    XXX,
    
    /// <remarks/>
    YER,
    
    /// <remarks/>
    ZAR,
    
    /// <remarks/>
    ZMK,
    
    /// <remarks/>
    ZWD,
    
    /// <remarks/>
    SSP,
    
    /// <remarks/>
    ADP,
    
    /// <remarks/>
    ATS,
    
    /// <remarks/>
    BEF,
    
    /// <remarks/>
    BEN,
    
    /// <remarks/>
    CDZ,
    
    /// <remarks/>
    CYP,
    
    /// <remarks/>
    DEM,
    
    /// <remarks/>
    ECS,
    
    /// <remarks/>
    ESB,
    
    /// <remarks/>
    ESP,
    
    /// <remarks/>
    ESS,
    
    /// <remarks/>
    FIM,
    
    /// <remarks/>
    FRF,
    
    /// <remarks/>
    GEK,
    
    /// <remarks/>
    GNS,
    
    /// <remarks/>
    GQE,
    
    /// <remarks/>
    GRD,
    
    /// <remarks/>
    GWP,
    
    /// <remarks/>
    HRD,
    
    /// <remarks/>
    IEP,
    
    /// <remarks/>
    ISS,
    
    /// <remarks/>
    ITL,
    
    /// <remarks/>
    KTS,
    
    /// <remarks/>
    KYS,
    
    /// <remarks/>
    LSM,
    
    /// <remarks/>
    LTT,
    
    /// <remarks/>
    LUF,
    
    /// <remarks/>
    LVR,
    
    /// <remarks/>
    MGF,
    
    /// <remarks/>
    MLF,
    
    /// <remarks/>
    MTL,
    
    /// <remarks/>
    MVS,
    
    /// <remarks/>
    N11,
    
    /// <remarks/>
    NIC,
    
    /// <remarks/>
    NLG,
    
    /// <remarks/>
    PEI,
    
    /// <remarks/>
    PLZ,
    
    /// <remarks/>
    PSS,
    
    /// <remarks/>
    PTE,
    
    /// <remarks/>
    SDD,
    
    /// <remarks/>
    SIT,
    
    /// <remarks/>
    SKK,
    
    /// <remarks/>
    SRG,
    
    /// <remarks/>
    SUR,
    
    /// <remarks/>
    SVC,
    
    /// <remarks/>
    TJR,
    
    /// <remarks/>
    UAK,
    
    /// <remarks/>
    UGS,
    
    /// <remarks/>
    USP,
    
    /// <remarks/>
    UYP,
    
    /// <remarks/>
    YUD,
    
    /// <remarks/>
    YUN,
    
    /// <remarks/>
    ZAL,
    
    /// <remarks/>
    XEU,
    
    /// <remarks/>
    MRU,
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://creditinfo.com/schemas/Sample/Data")]
public partial class BatchContractContractDataInstallmentAmount {
    
    private decimal valueField;
    
    private CommonCurrency currencyField;
    
    /// <remarks/>
    public decimal Value {
        get {
            return this.valueField;
        }
        set {
            this.valueField = value;
        }
    }
    
    /// <remarks/>
    public CommonCurrency Currency {
        get {
            return this.currencyField;
        }
        set {
            this.currencyField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://creditinfo.com/schemas/Sample/Data")]
public partial class BatchContractContractDataCurrentBalance {
    
    private decimal valueField;
    
    private CommonCurrency currencyField;
    
    /// <remarks/>
    public decimal Value {
        get {
            return this.valueField;
        }
        set {
            this.valueField = value;
        }
    }
    
    /// <remarks/>
    public CommonCurrency Currency {
        get {
            return this.currencyField;
        }
        set {
            this.currencyField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://creditinfo.com/schemas/Sample/Data")]
public partial class BatchContractContractDataOverdueBalance {
    
    private decimal valueField;
    
    private CommonCurrency currencyField;
    
    /// <remarks/>
    public decimal Value {
        get {
            return this.valueField;
        }
        set {
            this.valueField = value;
        }
    }
    
    /// <remarks/>
    public CommonCurrency Currency {
        get {
            return this.currencyField;
        }
        set {
            this.currencyField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://creditinfo.com/schemas/Sample/Data")]
public partial class BatchContractIndividual {
    
    private string customerCodeField;
    
    private string firstNameField;
    
    private string lastNameField;
    
    private GenderNotSpecified genderField;
    
    private bool genderFieldSpecified;
    
    private System.DateTime dateOfBirthField;
    
    private bool dateOfBirthFieldSpecified;
    
    private BatchContractIndividualIdentificationNumbers identificationNumbersField;
    
    /// <remarks/>
    public string CustomerCode {
        get {
            return this.customerCodeField;
        }
        set {
            this.customerCodeField = value;
        }
    }
    
    /// <remarks/>
    public string FirstName {
        get {
            return this.firstNameField;
        }
        set {
            this.firstNameField = value;
        }
    }
    
    /// <remarks/>
    public string LastName {
        get {
            return this.lastNameField;
        }
        set {
            this.lastNameField = value;
        }
    }
    
    /// <remarks/>
    public GenderNotSpecified Gender {
        get {
            return this.genderField;
        }
        set {
            this.genderField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool GenderSpecified {
        get {
            return this.genderFieldSpecified;
        }
        set {
            this.genderFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType="date")]
    public System.DateTime DateOfBirth {
        get {
            return this.dateOfBirthField;
        }
        set {
            this.dateOfBirthField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool DateOfBirthSpecified {
        get {
            return this.dateOfBirthFieldSpecified;
        }
        set {
            this.dateOfBirthFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    public BatchContractIndividualIdentificationNumbers IdentificationNumbers {
        get {
            return this.identificationNumbersField;
        }
        set {
            this.identificationNumbersField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(TypeName="Gender.NotSpecified", Namespace="http://creditinfo.com/schemas/Sample/Data")]
public enum GenderNotSpecified {
    
    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("")]
    Item,
    
    /// <remarks/>
    NotSpecified,
    
    /// <remarks/>
    Male,
    
    /// <remarks/>
    Female,
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://creditinfo.com/schemas/Sample/Data")]
public partial class BatchContractIndividualIdentificationNumbers {
    
    private string nationalIDField;
    
    /// <remarks/>
    public string NationalID {
        get {
            return this.nationalIDField;
        }
        set {
            this.nationalIDField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://creditinfo.com/schemas/Sample/Data")]
public partial class BatchContractSubjectRole {
    
    private string customerCodeField;
    
    private CommonRoleOfCustomer roleOfCustomerField;
    
    private BatchContractSubjectRoleGuaranteeAmount guaranteeAmountField;
    
    /// <remarks/>
    public string CustomerCode {
        get {
            return this.customerCodeField;
        }
        set {
            this.customerCodeField = value;
        }
    }
    
    /// <remarks/>
    public CommonRoleOfCustomer RoleOfCustomer {
        get {
            return this.roleOfCustomerField;
        }
        set {
            this.roleOfCustomerField = value;
        }
    }
    
    /// <remarks/>
    public BatchContractSubjectRoleGuaranteeAmount GuaranteeAmount {
        get {
            return this.guaranteeAmountField;
        }
        set {
            this.guaranteeAmountField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(TypeName="Common.RoleOfCustomer", Namespace="http://creditinfo.com/schemas/Sample/Data")]
public enum CommonRoleOfCustomer {
    
    /// <remarks/>
    MainDebtor,
    
    /// <remarks/>
    CoDebtor,
    
    /// <remarks/>
    Guarantor,
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://creditinfo.com/schemas/Sample/Data")]
public partial class BatchContractSubjectRoleGuaranteeAmount {
    
    private decimal valueField;
    
    private CommonCurrency currencyField;
    
    /// <remarks/>
    public decimal Value {
        get {
            return this.valueField;
        }
        set {
            this.valueField = value;
        }
    }
    
    /// <remarks/>
    public CommonCurrency Currency {
        get {
            return this.currencyField;
        }
        set {
            this.currencyField = value;
        }
    }
}
