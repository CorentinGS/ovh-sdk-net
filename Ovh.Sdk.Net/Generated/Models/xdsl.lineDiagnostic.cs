//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace _xdsl_lineDiagnostic {
    
    
    // Id: Answers Namespace: xdsl.lineDiagnostic
    public class Answers {
        
        // Key: bandwidthTestUnit Type: xdsl.lineDiagnostic.BandwidthTestUnitEnum FullType: xdsl.lineDiagnostic.BandwidthTestUnitEnum
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("bandwidthTestUnit")]
        public _xdsl_lineDiagnostic.BandwidthTestUnitEnum? BandwidthTestUnit { get; set; }//;
        
        // Key: comment Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("comment")]
        public System.String? Comment { get; set; }//;
        
        // Key: conditionsAccepted Type: boolean FullType: boolean
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("conditionsAccepted")]
        public System.Boolean? ConditionsAccepted { get; set; }//;
        
        // Key: contactPhone Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("contactPhone")]
        public System.String? ContactPhone { get; set; }//;
        
        // Key: datetimeOfAppearance Type: datetime FullType: datetime
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("datetimeOfAppearance")]
        public System.DateTime? DatetimeOfAppearance { get; set; }//;
        
        // Key: downloadBandwidthTest Type: long FullType: long
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("downloadBandwidthTest")]
        public System.Int64? DownloadBandwidthTest { get; set; }//;
        
        // Key: endAfternoonHours Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("endAfternoonHours")]
        public System.String? EndAfternoonHours { get; set; }//;
        
        // Key: endMorningHours Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("endMorningHours")]
        public System.String? EndMorningHours { get; set; }//;
        
        // Key: followBySms Type: boolean FullType: boolean
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("followBySms")]
        public System.Boolean? FollowBySms { get; set; }//;
        
        // Key: hasModemKeptSynchronization Type: boolean FullType: boolean
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("hasModemKeptSynchronization")]
        public System.Boolean? HasModemKeptSynchronization { get; set; }//;
        
        // Key: idAppointment Type: long FullType: long
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("idAppointment")]
        public System.Int64? IdAppointment { get; set; }//;
        
        // Key: individualSite Type: boolean FullType: boolean
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("individualSite")]
        public System.Boolean? IndividualSite { get; set; }//;
        
        // Key: modemIsSynchronized Type: boolean FullType: boolean
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("modemIsSynchronized")]
        public System.Boolean? ModemIsSynchronized { get; set; }//;
        
        // Key: modemMac Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("modemMac")]
        public System.String? ModemMac { get; set; }//;
        
        // Key: modemStillSynchronized Type: boolean FullType: boolean
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("modemStillSynchronized")]
        public System.Boolean? ModemStillSynchronized { get; set; }//;
        
        // Key: modemType Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("modemType")]
        public System.String? ModemType { get; set; }//;
        
        // Key: ovhTicket Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("ovhTicket")]
        public System.String? OvhTicket { get; set; }//;
        
        // Key: problemType Type: xdsl.lineDiagnostic.ProblemTypeEnum FullType: xdsl.lineDiagnostic.ProblemTypeEnum
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("problemType")]
        public _xdsl_lineDiagnostic.ProblemTypeEnum? ProblemType { get; set; }//;
        
        // Key: resolvedAfterTests Type: boolean FullType: boolean
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("resolvedAfterTests")]
        public System.Boolean? ResolvedAfterTests { get; set; }//;
        
        // Key: secureSite Type: boolean FullType: boolean
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("secureSite")]
        public System.Boolean? SecureSite { get; set; }//;
        
        // Key: severalInternetConnections Type: boolean FullType: boolean
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("severalInternetConnections")]
        public System.Boolean? SeveralInternetConnections { get; set; }//;
        
        // Key: siteClosedDays Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("siteClosedDays")]
        public System.String? SiteClosedDays { get; set; }//;
        
        // Key: siteDigicode Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("siteDigicode")]
        public System.String? SiteDigicode { get; set; }//;
        
        // Key: siteOpening Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("siteOpening")]
        public System.String? SiteOpening { get; set; }//;
        
        // Key: startAfternoonHours Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("startAfternoonHours")]
        public System.String? StartAfternoonHours { get; set; }//;
        
        // Key: startMorningHours Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("startMorningHours")]
        public System.String? StartMorningHours { get; set; }//;
        
        // Key: uploadBandwidthTest Type: long FullType: long
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("uploadBandwidthTest")]
        public System.Int64? UploadBandwidthTest { get; set; }//;
    }
    
    // Id: BandwidthTestUnitEnum Namespace: xdsl.lineDiagnostic
    public enum BandwidthTestUnitEnum {
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("Kbps")]
        Kbps,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("Mbps")]
        Mbps,
    }
    
    // Id: ConnectionInformations Namespace: xdsl.lineDiagnostic
    public class ConnectionInformations {
        
        // Key: crcError Type: long FullType: long
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("crcError")]
        public System.Int64? CrcError { get; set; }//;
        
        // Key: downstreamAttenuation Type: double FullType: double
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("downstreamAttenuation")]
        public System.Double? DownstreamAttenuation { get; set; }//;
        
        // Key: downstreamMargin Type: double FullType: double
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("downstreamMargin")]
        public System.Double? DownstreamMargin { get; set; }//;
        
        // Key: downstreamSync Type: double FullType: double
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("downstreamSync")]
        public System.Double? DownstreamSync { get; set; }//;
        
        // Key: ifName Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("ifName")]
        public System.String? IfName { get; set; }//;
        
        // Key: profile Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("profile")]
        public System.String? Profile { get; set; }//;
        
        // Key: upstreamAttenuation Type: double FullType: double
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("upstreamAttenuation")]
        public System.Double? UpstreamAttenuation { get; set; }//;
        
        // Key: upstreamMargin Type: double FullType: double
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("upstreamMargin")]
        public System.Double? UpstreamMargin { get; set; }//;
        
        // Key: upstreamSync Type: double FullType: double
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("upstreamSync")]
        public System.Double? UpstreamSync { get; set; }//;
    }
    
    // Id: CustomerActionToDo Namespace: xdsl.lineDiagnostic
    public class CustomerActionToDo {
        
        // Key: description Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("description")]
        public string Description { get; set; }//;
        
        // Key: name Type: xdsl.lineDiagnostic.CustomerActionsEnum FullType: xdsl.lineDiagnostic.CustomerActionsEnum
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("name")]
        public _xdsl_lineDiagnostic.CustomerActionsEnum Name { get; set; }//;
    }
    
    // Id: CustomerActionsEnum Namespace: xdsl.lineDiagnostic
    public enum CustomerActionsEnum {
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("bePreparedToCheckModemSynchronization")]
        bePreparedToCheckModemSynchronization,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("changeDslFilterAndPlugInDti")]
        changeDslFilterAndPlugInDti,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("changeExtensionCable")]
        changeExtensionCable,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("changeProfile")]
        changeProfile,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("checkConnectionCable")]
        checkConnectionCable,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("checkConnectionLoginAndParameters")]
        checkConnectionLoginAndParameters,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("checkFilter")]
        checkFilter,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("connectModemToOtherPlugs")]
        connectModemToOtherPlugs,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("neutralTest")]
        neutralTest,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("rebootModem")]
        rebootModem,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("resetModem")]
        resetModem,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("unplugEveryModems")]
        unplugEveryModems,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("unplugModem")]
        unplugModem,
    }
    
    // Id: Diagnostic Namespace: xdsl.lineDiagnostic
    public class Diagnostic {
        
        // Key: data Type: xdsl.lineDiagnostic.DiagnosticData FullType: xdsl.lineDiagnostic.DiagnosticData
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("data")]
        public _xdsl_lineDiagnostic.DiagnosticData Data { get; set; }//;
        
        // Key: faultType Type: xdsl.lineDiagnostic.FaultTypeEnum FullType: xdsl.lineDiagnostic.FaultTypeEnum
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("faultType")]
        public _xdsl_lineDiagnostic.FaultTypeEnum FaultType { get; set; }//;
        
        // Key: id Type: long FullType: long
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("id")]
        public long Id { get; set; }//;
        
        // Key: status Type: xdsl.lineDiagnostic.DiagnosticStatusEnum FullType: xdsl.lineDiagnostic.DiagnosticStatusEnum
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("status")]
        public _xdsl_lineDiagnostic.DiagnosticStatusEnum Status { get; set; }//;
    }
    
    // Id: DiagnosticData Namespace: xdsl.lineDiagnostic
    public class DiagnosticData {
        
        // Key: actionsDone Type: xdsl.lineDiagnostic.CustomerActionsEnum[] FullType: xdsl.lineDiagnostic.CustomerActionsEnum[]
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("actionsDone")]
        public _xdsl_lineDiagnostic.CustomerActionsEnum[] ActionsDone { get; set; }//;
        
        // Key: actionsToDo Type: xdsl.lineDiagnostic.CustomerActionToDo[] FullType: xdsl.lineDiagnostic.CustomerActionToDo[]
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("actionsToDo")]
        public _xdsl_lineDiagnostic.CustomerActionToDo[] ActionsToDo { get; set; }//;
        
        // Key: answers Type: xdsl.lineDiagnostic.Answers FullType: xdsl.lineDiagnostic.Answers
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("answers")]
        public _xdsl_lineDiagnostic.Answers Answers { get; set; }//;
        
        // Key: comment Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("comment")]
        public System.String? Comment { get; set; }//;
        
        // Key: creationDate Type: datetime FullType: datetime
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("creationDate")]
        public System.DateTime CreationDate { get; set; }//;
        
        // Key: diagnosticDoneDate Type: datetime FullType: datetime
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("diagnosticDoneDate")]
        public System.DateTime? DiagnosticDoneDate { get; set; }//;
        
        // Key: error Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("error")]
        public string Error { get; set; }//;
        
        // Key: lastUpdate Type: datetime FullType: datetime
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("lastUpdate")]
        public System.DateTime LastUpdate { get; set; }//;
        
        // Key: lineDetails Type: xdsl.lineDiagnostic.LineDetails FullType: xdsl.lineDiagnostic.LineDetails
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("lineDetails")]
        public _xdsl_lineDiagnostic.LineDetails LineDetails { get; set; }//;
        
        // Key: robotAction Type: xdsl.lineDiagnostic.RobotActionsEnum FullType: xdsl.lineDiagnostic.RobotActionsEnum
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("robotAction")]
        public _xdsl_lineDiagnostic.RobotActionsEnum? RobotAction { get; set; }//;
        
        // Key: seltTest Type: xdsl.lineDiagnostic.SeltResult FullType: xdsl.lineDiagnostic.SeltResult
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("seltTest")]
        public _xdsl_lineDiagnostic.SeltResult SeltTest { get; set; }//;
        
        // Key: timeout Type: long FullType: long
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("timeout")]
        public long Timeout { get; set; }//;
        
        // Key: toAnswer Type: xdsl.lineDiagnostic.Question[] FullType: xdsl.lineDiagnostic.Question[]
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("toAnswer")]
        public _xdsl_lineDiagnostic.Question[] ToAnswer { get; set; }//;
    }
    
    // Id: DiagnosticStatusEnum Namespace: xdsl.lineDiagnostic
    public enum DiagnosticStatusEnum {
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("cancelled")]
        cancelled,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("connectionProblem")]
        connectionProblem,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("genericIncidentPending")]
        genericIncidentPending,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("haveToConnectModemOnTheRightPlug")]
        haveToConnectModemOnTheRightPlug,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("init")]
        init,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("interventionRequested")]
        interventionRequested,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("noBandwidthFault")]
        noBandwidthFault,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("noProblemAnymore")]
        noProblemAnymore,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("noSyncFaultDiagnosticRequired")]
        noSyncFaultDiagnosticRequired,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("problem")]
        problem,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("resolvedAfterTests")]
        resolvedAfterTests,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("sleeping")]
        sleeping,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("validationRefused")]
        validationRefused,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("waitingHuman")]
        waitingHuman,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("waitingRobot")]
        waitingRobot,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("waitingValidation")]
        waitingValidation,
    }
    
    // Id: FaultTypeEnum Namespace: xdsl.lineDiagnostic
    public enum FaultTypeEnum {
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("alignment")]
        alignment,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("noSync")]
        noSync,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("syncLossOrLowBandwidth")]
        syncLossOrLowBandwidth,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("unknown")]
        unknown,
    }
    
    // Id: LineCapabilities Namespace: xdsl.lineDiagnostic
    public class LineCapabilities {
        
        // Key: down Type: double FullType: double
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("down")]
        public System.Double? Down { get; set; }//;
        
        // Key: mitigation Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("mitigation")]
        public System.String? Mitigation { get; set; }//;
        
        // Key: ping Type: double FullType: double
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("ping")]
        public System.Double? Ping { get; set; }//;
        
        // Key: up Type: double FullType: double
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("up")]
        public System.Double? Up { get; set; }//;
    }
    
    // Id: LineDetails Namespace: xdsl.lineDiagnostic
    public class LineDetails {
        
        // Key: accessName Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("accessName")]
        public string AccessName { get; set; }//;
        
        // Key: accessPing Type: boolean FullType: boolean
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("accessPing")]
        public System.Boolean? AccessPing { get; set; }//;
        
        // Key: address Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("address")]
        public System.String? Address { get; set; }//;
        
        // Key: connectionInfo Type: xdsl.lineDiagnostic.ConnectionInformations FullType: xdsl.lineDiagnostic.ConnectionInformations
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("connectionInfo")]
        public _xdsl_lineDiagnostic.ConnectionInformations? ConnectionInfo { get; set; }//;
        
        // Key: contactPhone Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("contactPhone")]
        public System.String? ContactPhone { get; set; }//;
        
        // Key: description Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("description")]
        public System.String? Description { get; set; }//;
        
        // Key: dslamIsSynchronized Type: boolean FullType: boolean
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("dslamIsSynchronized")]
        public System.Boolean? DslamIsSynchronized { get; set; }//;
        
        // Key: gtr Type: boolean FullType: boolean
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("gtr")]
        public bool Gtr { get; set; }//;
        
        // Key: length Type: long FullType: long
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("length")]
        public long Length { get; set; }//;
        
        // Key: lineCapabilities Type: xdsl.lineDiagnostic.LineCapabilities FullType: xdsl.lineDiagnostic.LineCapabilities
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("lineCapabilities")]
        public _xdsl_lineDiagnostic.LineCapabilities? LineCapabilities { get; set; }//;
        
        // Key: lineType Type: xdsl.DslTypeEnum FullType: xdsl.DslTypeEnum
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("lineType")]
        public _xdsl.DslTypeEnum LineType { get; set; }//;
        
        // Key: nra Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("nra")]
        public System.String? Nra { get; set; }//;
        
        // Key: number Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("number")]
        public string Number { get; set; }//;
        
        // Key: operator Type: xdsl.ProviderEnum FullType: xdsl.ProviderEnum
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("operator")]
        public _xdsl.ProviderEnum @operator { get; set; }//;
        
        // Key: sections Type: xdsl.lineDiagnostic.Section[] FullType: xdsl.lineDiagnostic.Section[]
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("sections")]
        public _xdsl_lineDiagnostic.Section[]? Sections { get; set; }//;
    }
    
    // Id: PossibleValue Namespace: xdsl.lineDiagnostic
    public class PossibleValue {
        
        // Key: id Type: long FullType: long
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("id")]
        public System.Int64? Id { get; set; }//;
        
        // Key: label Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("label")]
        public System.String? Label { get; set; }//;
        
        // Key: value Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("value")]
        public System.String? Value { get; set; }//;
    }
    
    // Id: ProblemTypeEnum Namespace: xdsl.lineDiagnostic
    public enum ProblemTypeEnum {
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("lowBandwidth")]
        lowBandwidth,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("syncLoss")]
        syncLoss,
    }
    
    // Id: Question Namespace: xdsl.lineDiagnostic
    public class Question {
        
        // Key: defaultValue Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("defaultValue")]
        public System.String? DefaultValue { get; set; }//;
        
        // Key: description Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("description")]
        public string Description { get; set; }//;
        
        // Key: enumValues Type: string[] FullType: string[]
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("enumValues")]
        public System.String[]? EnumValues { get; set; }//;
        
        // Key: name Type: xdsl.lineDiagnostic.QuestionsEnum FullType: xdsl.lineDiagnostic.QuestionsEnum
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("name")]
        public _xdsl_lineDiagnostic.QuestionsEnum Name { get; set; }//;
        
        // Key: possibleValues Type: xdsl.lineDiagnostic.PossibleValue[] FullType: xdsl.lineDiagnostic.PossibleValue[]
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("possibleValues")]
        public _xdsl_lineDiagnostic.PossibleValue[]? PossibleValues { get; set; }//;
        
        // Key: required Type: boolean FullType: boolean
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("required")]
        public System.Boolean? Required { get; set; }//;
        
        // Key: type Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("type")]
        public string Type { get; set; }//;
    }
    
    // Id: QuestionsEnum Namespace: xdsl.lineDiagnostic
    public enum QuestionsEnum {
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("bandwidthTestUnit")]
        bandwidthTestUnit,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("comment")]
        comment,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("conditionsAccepted")]
        conditionsAccepted,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("contactPhone")]
        contactPhone,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("datetimeOfAppearance")]
        datetimeOfAppearance,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("downloadBandwidthTest")]
        downloadBandwidthTest,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("endAfternoonHours")]
        endAfternoonHours,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("endMorningHours")]
        endMorningHours,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("followBySms")]
        followBySms,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("hasModemKeptSynchronization")]
        hasModemKeptSynchronization,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("idAppointment")]
        idAppointment,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("individualSite")]
        individualSite,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("modemIsSynchronized")]
        modemIsSynchronized,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("modemMac")]
        modemMac,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("modemStillSynchronized")]
        modemStillSynchronized,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("modemType")]
        modemType,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("ovhTicket")]
        ovhTicket,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("problemType")]
        problemType,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("resolvedAfterTests")]
        resolvedAfterTests,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("secureSite")]
        secureSite,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("severalInternetConnections")]
        severalInternetConnections,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("siteClosedDays")]
        siteClosedDays,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("siteDigicode")]
        siteDigicode,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("siteOpening")]
        siteOpening,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("startAfternoonHours")]
        startAfternoonHours,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("startMorningHours")]
        startMorningHours,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("uploadBandwidthTest")]
        uploadBandwidthTest,
    }
    
    // Id: RobotActionsEnum Namespace: xdsl.lineDiagnostic
    public enum RobotActionsEnum {
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("alignmentLockTest")]
        alignmentLockTest,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("alignmentResetTest")]
        alignmentResetTest,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("alignmentTestResult")]
        alignmentTestResult,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("checkCustomerTicket")]
        checkCustomerTicket,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("checkIfAccessPing")]
        checkIfAccessPing,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("checkIfResolvedAfterConnectionTests")]
        checkIfResolvedAfterConnectionTests,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("checkIfResolvedAfterInstallationCheck")]
        checkIfResolvedAfterInstallationCheck,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("checkIfResolvedAfterTests")]
        checkIfResolvedAfterTests,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("checkIfSeveralConnections")]
        checkIfSeveralConnections,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("checkInstallation")]
        checkInstallation,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("checkProblem")]
        checkProblem,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("checkSynchronizationWithoutOtherModems")]
        checkSynchronizationWithoutOtherModems,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("customerPrelocChecks")]
        customerPrelocChecks,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("findProblem")]
        findProblem,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("installationCheck")]
        installationCheck,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("lockUnlock")]
        lockUnlock,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("needToRequestMonitoring")]
        needToRequestMonitoring,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("needToRequestOperatorIntervention")]
        needToRequestOperatorIntervention,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("needToRequestOvhIntervention")]
        needToRequestOvhIntervention,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("requestMonitoring")]
        requestMonitoring,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("requestOperatorIntervention")]
        requestOperatorIntervention,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("requestOvhIntervention")]
        requestOvhIntervention,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("seltTest")]
        seltTest,
    }
    
    // Id: Section Namespace: xdsl.lineDiagnostic
    public class Section {
        
        // Key: length Type: long FullType: long
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("length")]
        public long Length { get; set; }//;
        
        // Key: section Type: long FullType: long
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("section")]
        public long _Section { get; set; }//;
    }
    
    // Id: SeltPrelocEnum Namespace: xdsl.lineDiagnostic
    public enum SeltPrelocEnum {
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("CUST")]
        CUST,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("DSLAM")]
        DSLAM,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("LINE")]
        LINE,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("RE")]
        RE,
    }
    
    // Id: SeltResult Namespace: xdsl.lineDiagnostic
    public class SeltResult {
        
        // Key: date Type: datetime FullType: datetime
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("date")]
        public System.DateTime? Date { get; set; }//;
        
        // Key: distance Type: long FullType: long
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("distance")]
        public System.Int64? Distance { get; set; }//;
        
        // Key: preloc Type: xdsl.lineDiagnostic.SeltPrelocEnum FullType: xdsl.lineDiagnostic.SeltPrelocEnum
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("preloc")]
        public _xdsl_lineDiagnostic.SeltPrelocEnum? Preloc { get; set; }//;
        
        // Key: state Type: xdsl.lineDiagnostic.SeltStateEnum FullType: xdsl.lineDiagnostic.SeltStateEnum
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("state")]
        public _xdsl_lineDiagnostic.SeltStateEnum? State { get; set; }//;
        
        // Key: status Type: xdsl.lineDiagnostic.SeltStatusEnum FullType: xdsl.lineDiagnostic.SeltStatusEnum
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("status")]
        public _xdsl_lineDiagnostic.SeltStatusEnum? Status { get; set; }//;
    }
    
    // Id: SeltStateEnum Namespace: xdsl.lineDiagnostic
    public enum SeltStateEnum {
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("open")]
        open,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("short")]
        @short,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("synced")]
        synced,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("unknown")]
        unknown,
    }
    
    // Id: SeltStatusEnum Namespace: xdsl.lineDiagnostic
    public enum SeltStatusEnum {
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("failed")]
        failed,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("notAvailable")]
        notAvailable,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("ok")]
        ok,
    }
}
