//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MvcPhoenix.DataLayer
{
    using System;
    using System.Collections.Generic;
    
    public partial class tblOrderMaster
    {
        public int ORDERID { get; set; }
        public Nullable<int> ClientID { get; set; }
        public string Customer { get; set; }
        public Nullable<int> CMCORDER { get; set; }
        public Nullable<int> WebOrderID { get; set; }
        public string CMCLEGACYNUM { get; set; }
        public string CUSTORDNUM { get; set; }
        public string CUSTSAPNUM { get; set; }
        public string CUSTREFNUM { get; set; }
        public string ShipRef { get; set; }
        public string ORDERTYPE { get; set; }
        public Nullable<System.DateTime> ORDERDATE { get; set; }
        public string COMPANY { get; set; }
        public string STREET { get; set; }
        public string STREET2 { get; set; }
        public string STREET3 { get; set; }
        public string CITY { get; set; }
        public string STATE { get; set; }
        public string ZIP { get; set; }
        public string country { get; set; }
        public string ATTENTION { get; set; }
        public string EMAIL { get; set; }
        public string SALESREP { get; set; }
        public string SALES_Email { get; set; }
        public string REQ { get; set; }
        public string REQ_PHONE { get; set; }
        public string REQ_fax { get; set; }
        public string REQ_email { get; set; }
        public string EndUse { get; set; }
        public string Ship_Via { get; set; }
        public string Ship_Acct { get; set; }
        public string Phone { get; set; }
        public string Source { get; set; }
        public string Fax { get; set; }
        public string Tracking { get; set; }
        public string Special { get; set; }
        public string SpecialInternal { get; set; }
        public Nullable<bool> Lit { get; set; }
        public string Region { get; set; }
        public Nullable<bool> COA { get; set; }
        public Nullable<bool> TDS { get; set; }
        public string CID { get; set; }
        public string CustACCT { get; set; }
        public string ACode { get; set; }
        public string ImportFile { get; set; }
        public Nullable<System.DateTime> Importdateline { get; set; }
        public string Timing { get; set; }
        public string Volume { get; set; }
        public Nullable<bool> SampleRack { get; set; }
        public string CMCUser { get; set; }
        public string CustomerReference { get; set; }
        public string DIVISION { get; set; }
        public string BusARea { get; set; }
        public Nullable<int> TotalOrderWeight { get; set; }
        public string SPSTaxID { get; set; }
        public string SPSCurrency { get; set; }
        public string SPSShippedWt { get; set; }
        public string SPSFreightCost { get; set; }
        public string InvoiceCompany { get; set; }
        public string InvoiceTitle { get; set; }
        public string InvoiceFirstName { get; set; }
        public string InvoiceLastName { get; set; }
        public string InvoiceAddress1 { get; set; }
        public string InvoiceAddress2 { get; set; }
        public string InvoiceAddress3 { get; set; }
        public string InvoiceCity { get; set; }
        public string InvoiceStateProv { get; set; }
        public string InvoicePostalCode { get; set; }
        public string InvoiceCountry { get; set; }
        public string InvoicePhone { get; set; }
        public string CustOrderType { get; set; }
        public Nullable<System.DateTime> CustRequestDate { get; set; }
        public Nullable<System.DateTime> ApprovalDate { get; set; }
        public Nullable<System.DateTime> RequestedDeliveryDate { get; set; }
        public Nullable<int> CustTotalItems { get; set; }
        public string CustRequestedCarrier { get; set; }
        public Nullable<int> LegacyID { get; set; }
    }
}
