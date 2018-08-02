using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consensus.Security
{
    /// <summary>
    ///     Enumerates the different software modules.
    /// </summary>
    public enum LicenseModules
    {
        [Description("Core"), EnumerationGuid("18b44bf8-6c7f-4285-9847-c5e3fc0bfa39")]
        Core,

        [Description("Accommodation"), EnumerationGuid("8fc9efd8-dc33-44f2-83a3-bc5276742e64")]
        Accommodation,

        [Description("Administration"), EnumerationGuid("5efe3a9d-6daf-4557-99c2-b9451f5ffd51")]
        Administration,

        [Description("API"), EnumerationGuid("dc2589f9-5658-4e07-bfd6-a8b095987ec8")]
        API,

        [Description("Appointments"), EnumerationGuid("b4254f80-f67a-415e-9b18-e70870d67462")]
        Appointments,

        [Description("Care / Integra NG Integration"), EnumerationGuid("5cd3495e-3b19-4e6d-91c9-f224a32f3bd7")]
        CareIntegraIntegration,

        [Description("City and Guilds"), EnumerationGuid("365c1b2e-2565-4116-82be-41f8f4c73b27")]
        CityandGuilds,

        [Description("Commerce"), EnumerationGuid("fa490d4e-5926-47a7-8817-38127975b5fc")]
        Commerce,

        [Description("Communications"), EnumerationGuid("9c03da9c-1086-4a38-8685-e52b684deeef")]
        Communications,

        [Description("Communigator Integration"), EnumerationGuid("f8901529-55e6-46e8-b71b-1ffaa5f89f86")]
        CommunigatorIntegration,

        [Description("Competency Management"), EnumerationGuid("83513f31-a482-4525-899e-f420964aa383")]
        CompetencyManagement,

        [Description("Contact Management"), EnumerationGuid("18c0136b-8849-4c53-b203-ec129e6b0c06")]
        ContactManagement,

        [Description("CRM"), EnumerationGuid("4131b6d5-cd93-4231-bd2f-0fb978680443")]
        CRM,

        [Description("Data Import and Export"), EnumerationGuid("d6e870a5-b21c-4a84-b4af-63858201855d")]
        DataImportandExport,

        [Description("Direct Debits"), EnumerationGuid("328f1740-8820-447a-951f-bcff05a18a42")]
        DirectDebits,

        [Description("eLearning"), EnumerationGuid("68f73228-5753-440e-b689-689799b95341")]
        eLearning,

        [Description("Events"), EnumerationGuid("134fee76-40cc-4faf-b15b-b0d8453bcf61")]
        Events,

        [Description("Examinations"), EnumerationGuid("f88e9a72-b35b-4137-8d47-303b17895b7c")]
        Examinations,

        [Description("Exchange Integration"), EnumerationGuid("93353968-8d59-4fd2-bc0a-542a9c00f784")]
        ExchangeIntegration,

        [Description("Exchequer Integration"), EnumerationGuid("71d26142-1753-49c4-b554-649770502f00")]
        ExchequerIntegration,

        [Description("Fundraising"), EnumerationGuid("e30dce1c-6a42-4b74-94c3-4e8e1f4d2e9f")]
        Fundraising,

        [Description("Gift Aid"), EnumerationGuid("31bc0bac-107b-4bdb-8946-1981a69ac1d9")]
        GiftAid,

        [Description("Licenced Events"), EnumerationGuid("caad310a-4cd4-4009-a747-2db6cfb02eb8")]
        LicencedEvents,

        [Description("Location Management"), EnumerationGuid("1803f003-710a-487a-9ebf-34d77d2a7516")]
        LocationManagement,

        [Description("Marketing"), EnumerationGuid("d5c9259a-1a15-4b34-be79-c0a6cc9fa34a")]
        Marketing,

        [Description("Membership"), EnumerationGuid("0b4da778-9ffd-4c64-8730-f01f816727ae")]
        Membership,

        [Description("Membership Structures"), EnumerationGuid("5f920bd8-8057-4898-98d1-b95f14a8bc92")]
        MembershipStructures,

        [Description("OpenHR Integration"), EnumerationGuid("90514159-58c8-4db3-8d42-e66e66a0e2ea")]
        OpenHRIntegration,

        [Description("Opportunities"), EnumerationGuid("8ad643c8-2255-486c-b3cc-7626cff570a6")]
        Opportunities,

        [Description("Portal"), EnumerationGuid("4e17597d-cdd8-43b4-a125-103292de2df0")]
        Portal,

        [Description("Portal - Commerce"), EnumerationGuid("e53f7901-0c91-4d28-b57e-6103fefb653c")]
        PortalCommerce,

        [Description("Portal - Fundraising"), EnumerationGuid("0e66db0e-0323-4a35-ae77-923456268506")]
        PortalFundraising,

        [Description("Portal - LMS"), EnumerationGuid("078a3191-f00e-470f-b76d-9f9724eb370a")]
        PortalLMS,

        [Description("Portal - Membership"), EnumerationGuid("8dadd639-aadc-4394-8d05-243480ee1411")]
        PortalMembership,

        [Description("Portal - Room Booking"), EnumerationGuid("20314ebd-620e-4eb0-893d-acd07942dfdb")]
        PortalRoomBooking,

        [Description("Portal - Self Check In"), EnumerationGuid("759397ce-dfb4-4c61-ad70-aaaaf12d326e")]
        PortalSelfCheckIn,

        [Description("Portal - Surveys"), EnumerationGuid("90c6f77b-6612-428b-9beb-a967d50294ca")]
        PortalSurveys,

        [Description("Product Sales"), EnumerationGuid("310fbbcd-8045-4472-a08e-8e5e75109744")]
        ProductSales,

        [Description("Projects"), EnumerationGuid("bd50f207-6271-4efd-be3e-ce6245b9acfd")]
        Projects,

        [Description("Qualifications"), EnumerationGuid("a50b5a90-bb8e-4618-aba8-ba8837ed4336")]
        Qualifications,

        [Description("Regular Giving and Subscriptions"), EnumerationGuid("1a440017-94c2-4cb0-8620-7289f9b0f295")]
        RegularGivingandSubscriptions,

        [Description("Reporting"), EnumerationGuid("e396de9e-9bea-4392-8460-67d549e51b81")]
        Reporting,

        [Description("Reporting - Legacy"), EnumerationGuid("74bab04f-55db-4cad-9bcc-b37192df8446")]
        ReportingLegacy,

        [Description("Sales"), EnumerationGuid("02d349bd-6de3-46c7-96a1-dfc29ac1756e")]
        Sales,

        [Description("Sales Ledger Accountsg"), EnumerationGuid("f7f07422-40f6-4605-ae44-a97edec27da1")]
        SalesLedgerAccounts,

        [Description("Scheduling"), EnumerationGuid("d3f842ac-7464-40b2-9f01-656b04697df9")]
        Scheduling,

        [Description("SMS"), EnumerationGuid("95f98101-9307-4af6-aaee-b5d745705ffb")]
        SMS,

        [Description("Standard Automations"), EnumerationGuid("292988c2-35b2-474d-9250-84cb8b60fdda")]
        StandardAutomations,

        [Description("Surveys"), EnumerationGuid("80199a56-098a-447e-9d15-af5ad3fb578a")]
        Surveys,

        [Description("Training"), EnumerationGuid("4df0273b-89ae-4bef-92e3-3b7c71e8d99e")]
        Training,

        [Description("User Tables"), EnumerationGuid("090f3103-c230-4c13-8f0e-524d8240a6e6")]
        UserTables,

        [Description("Workflows"), EnumerationGuid("b43f9d4a-d430-439e-9366-fc782eedd3ee")]
        Workflows,

        [Description("Worldpay Integration"), EnumerationGuid("db1fcee1-82e6-4ee4-a13c-c751e1b6f135")]
        WorldpayIntegration

    }
}



