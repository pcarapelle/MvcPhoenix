using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

// add
using System.Web.Mvc;
using System.ComponentModel.DataAnnotations;

//Create 3 class versions:    OrderViewModelLarge, OrderViewModelMedium, OrderViewModelSmall


namespace MvcPhoenix.Models
{
    public class OrderViewModelLarge
    {
        // pc

    // Public Property OrderItems As IEnumerable(Of SelectListItem)
    public IEnumerable<SelectListItem> ClientList { get; set; }
    public IEnumerable<SelectListItem> ListOrderIDs { get; set; }
    public IEnumerable<SelectListItem> ListDivision { get; set; }
    public IEnumerable<SelectListItem> ListOrderType { get; set; }
    public IEnumerable<SelectListItem> ListState { get; set; }
    public IEnumerable<SelectListItem> ListCountry { get; set; }
    public IEnumerable<SelectListItem> ListRequestor { get; set; }
    public IEnumerable<SelectListItem> ListShipVia { get; set; }
    public IEnumerable<SelectListItem> ListSalesRep { get; set; }
    public IEnumerable<SelectListItem> ListEndUse { get; set; }
    public IEnumerable<SelectListItem> ListOrderSource { get; set; }
        
    [Display(Name="Order ID")]
    public int orderid { get; set; }

    [Display(Name="CMC Order No.")]
    public int cmcorder { get; set; }

    [Display(Name="Order ClientID")]
    public int clientid { get; set; }

    [Display(Name="Division ID")]
    public int divisionid { get; set; }

    [Display(Name="Cust Order Number")]
    public string custordnum { get; set; }

    [Display(Name="Web Order ID")]
    public int weborderid { get; set; }

    [Display(Name="Ref Number")]
    public string refnum { get; set; }

    [Display(Name="Division")]
    public string division { get; set; }

    [Display(Name="Order Type")]
    public string ordertype { get; set; }

    //[Display(Name="Order Date")]
    //public date orderdate { get; set; }

    [Display(Name="CustomerName")]
    public string customer { get; set; }

    [Display(Name="Address 1")]
    public string address1 { get; set; }

    [Display(Name="Address 2")]
    public string address2 { get; set; }

    [Display(Name="Address 3")]
    public string address3 { get; set; }

    [Display(Name="City")]
    public string city { get; set; }

    [Display(Name="State")]
    public string state { get; set; }

    [Display(Name="Postal Code")]
    public string postalcode { get; set; }

    [Display(Name="Country")]
    public string country { get; set; }

    [Display(Name="Attention")]
    public string attention { get; set; }

    [Display(Name="Email")]
    public string email { get; set; }

    [Display(Name="Sales Rep")]
    public string salesrep { get; set; }

    [Display(Name="Sales Rep Email")]
    public string salesrepemail { get; set; }

    [Display(Name="Sales Dept")]
    public string salesdept { get; set; }

    [Display(Name="Sales Territory")]
    public string salesterritory { get; set; }

    [Display(Name="Sales Phone")]
    public string salesphone { get; set; }

    [Display(Name="Sales Fax")]
    public string salesfax { get; set; }

    [Display(Name="CSR")]
    public string csr { get; set; }

    [Display(Name="CSR Email")]
    public string csremail { get; set; }

    [Display(Name="Marketing")]
    public string marketing { get; set; }

    [Display(Name="Distrubutor")]
    public string distributor { get; set; }

    [Display(Name="Requestor")]
    public string requestor { get; set; }

    [Display(Name="Req Phone")]
    public string reqphone { get; set; }

    [Display(Name="Req Fax")]
    public string reqfax { get; set; }

    [Display(Name="Req Email")]
    public string reqemail { get; set; }

    [Display(Name="End Use")]
    public string enduse { get; set; }

    [Display(Name="Ship Via")]
    public string shipvia { get; set; }

    [Display(Name="Ship Account")]
    public string shipaccount { get; set; }

    [Display(Name="Ship Phone")]
    public string shipphone { get; set; }

    [Display(Name="Order Source")]
    public string ordersource { get; set; }

    [Display(Name="Order Fax")]
    public string orderfax { get; set; }

    [Display(Name="Tracking")]
    public string tracking { get; set; }

    [Display(Name="Special Instr")]
    public string specialinstructions { get; set; }

    [Display(Name="Special Int")]
    public string specialinternal { get; set; }

    [Display(Name="Literature")]
    public bool literature { get; set; }

    [Display(Name="Region")]
    public string region { get; set; }

    [Display(Name="COA")]
    public bool coa { get; set; }

    [Display(Name="CID")]
    public string cid { get; set; }

    [Display(Name="Customer Account")]
    public string customeraccount { get; set; }

    [Display(Name="ACode")]
    public string acode { get; set; }

    [Display(Name="Import File Name")]
    public string importfilename { get; set; }

    [Display(Name="Import Date Line")]
    public string importdateline { get; set; }

    [Display(Name="Timing")]
    public string timing { get; set; }

    [Display(Name="Volume")]
    public string volume { get; set; }

    [Display(Name="PO Number")]
    public string ponumber { get; set; }

    [Display(Name="FollowUp")]
    public string followup { get; set; }

    [Display(Name="Cust Order Type")]
    public string customerordertype { get; set; }

    //[Display(Name="EMN Date")]
    //public datetime emndate { get; set; }

    [Display(Name="EMN Total Items")]
    public int emntotalitems { get; set; }

    [Display(Name="EMN Req Name")]
    public string emnreqname { get; set; }

    [Display(Name="Pick Zone")]
    public string pickzone { get; set; }

    [Display(Name="Bill To Company")]
    public string billtocompany { get; set; }

    [Display(Name="Bill To Address 1")]
    public string billtoaddress1 { get; set; }

    [Display(Name="Bill Address 2")]
    public string billtoaddress2 { get; set; }

    [Display(Name="Bill to Address 3")]
    public string billtoaddress3 { get; set; }

    [Display(Name="Bill To City")]
    public string billtocity { get; set; }

    [Display(Name="Bill To State")]
    public string billtostate { get; set; }

    [Display(Name="Bill to Postal Code")]
    public string billtopostalcode { get; set; }

    [Display(Name="Bill To Country")]
    public string billtocountry { get; set; }

    [Display(Name="Bill To Attention")]
    public string billtoattention { get; set; }

    [Display(Name="Misc 1")]
    public string misc1 { get; set; }

    [Display(Name="Misc 2")]
    public string misc2 { get; set; }

    [Display(Name="SAP Number")]
    public string sapnumber { get; set; }

    [Display(Name="CMC Legacy Number")]
    public string cmclegacynumber { get; set; }

    [Display(Name="CMC Legacy Int")]
    public int cmclegacynumberint { get; set; }

    [Display(Name="Approval Needed")]
    public bool approvalneeded { get; set; }

    [Display(Name="Approved By")]
    public string approvedby { get; set; }

    [Display(Name="Approved Date")]
    public bool approveddate { get; set; }

    [Display(Name="Misc 1")]
    public string misc1bak { get; set; }

    [Display(Name="Misc 2")]
    public string misc2bak;

    //[Display(Name="Import Time Stamp")]
    //public datetime importtimestamp { get; set; }

    [Display(Name="CMC Location")]
    public string cmclocation { get; set; }

    [Display(Name="Customer Old")]
    public string customerold { get; set; }

    [Display(Name="Lotus Notes Ref")]
    public string lotusnotesref { get; set; }

    [Display(Name="Restricted")]
    public bool restricted { get; set; }

    [Display(Name="Approver")]
    public string approver { get; set; }

    [Display(Name="External ID")]
    public int externalid { get; set; }

    [Display(Name="BlackList")]
    public string blacklist { get; set; }

    //[Display(Name="Is POrderDate")]
    //public datetime isporderdate { get; set; }

    [Display(Name="ISPBU")]
    public string ispbu { get; set; }

    [Display(Name="Marketing Manager")]
    public string marketingmanager { get; set; }

    [Display(Name="Salesman")]
    public string salesman { get; set; }

    [Display(Name="Department")]
    public string department { get; set; }

    [Display(Name="Export File")]
    public string exportfilename { get; set; }

    //[Display(Name="Export File Date")]
    //public datetime exportfiledate { get; set; }

    [Display(Name="Div")]
    public string div { get; set; }

    [Display(Name="TechData")]
    public bool techdata { get; set; }

    [Display(Name="SPS Tax ID")]
    public string spstaxid { get; set; }

    [Display(Name="SPS Currency")]
    public string spscurrency { get; set; }

    [Display(Name="SPS Shipped Wt")]
    public string spsshippedwt { get; set; }

    [Display(Name="SPS Freight Cost")]
    public string spsfreightcost { get; set; }

    [Display(Name="Invoice Company")]
    public string invoicecompany { get; set; }

    [Display(Name="Invoice Title")]
    public string invoicetitle { get; set; }

    [Display(Name="Invoice First Name")]
    public string invoicefirstname { get; set; }

    [Display(Name="Invoice Last Name")]
    public string invoicelastname { get; set; }

    [Display(Name="Invoice Address 1")]
    public string invoiceaddress1 { get; set; }

    [Display(Name="Invoice Address 2")]
    public string invoiceaddress2 { get; set; }

    [Display(Name="Invoice Address 3")]
    public string invoiceaddress3 { get; set; }

    [Display(Name="Invoice City")]
    public string InvoiceCity { get; set; }

    [Display(Name="Invoice State")]
    public string InvoiceStateProv { get; set; }

    [Display(Name="Invoice Postal Code")]
    public string InvoicePostalCode { get; set; }

    [Display(Name="Invoice Phone")]
    public string InvoicePhone { get; set; }

    [Display(Name="ISP VC Rating")]
    public string ISPVCPRating { get; set; }

    [Display(Name="Rush")]
    public bool Rush { get; set; }

    [Display(Name="Return_Legacy")]
    public bool Return_legacy { get; set; }

    [Display(Name="Location")]
    public string Location { get; set; }

    [Display(Name="Billing Group")]
    public string BillingGroup { get; set; }

    [Display(Name="Test")]
    public string Test { get; set; }

    [Display(Name="Application")]
    public string Application { get; set; }

    [Display(Name="Kits")]
    public bool Kits { get; set; }

    [Display(Name="Regulatory Hold")]
    public bool RegulatoryHold { get; set; }

    [Display(Name="Ship From Location")]
    public string ShipFromLocation { get; set; }

    [Display(Name="Ship From Location Contact")]
    public string ShipFromLocationContact { get; set; }

    [Display(Name="EMN Order Type")]
    public string EMNOrderType { get; set; }

    [Display(Name="EMN Approved Date")]
    public string EMNApprovedDate { get; set; }

    [Display(Name="EMN Delivery Date")]
    public string EMNDeliveryDate { get; set; }

    [Display(Name="EMN BO")]
    public string EMNBO { get; set; }

    [Display(Name="EMN Charge Code")]
    public string EMNChargeCode { get; set; }

    [Display(Name="EMN Ship From Plant")]
    public string EMNShipFromPlant { get; set; }

    [Display(Name="EMN Cust Rep 1")]
    public string EMNCustRep1 { get; set; }

    [Display(Name="EMN Cust Rep 2")]
    public string EMNCustRep2 { get; set; }

    [Display(Name="EMN Cust Rep 3")]
    public string EMNCustRep3 { get; set; }

    [Display(Name="EMN Req Region")]
    public string EMNReqRegion { get; set; }

    [Display(Name="EMN Req Carrier")]
    public string EMNReqCarrier { get; set; }

    [Display(Name="Cust Delivery Number")]
    public string CustDelivNum { get; set; }

    [Display(Name="Cust SAP Number")]
    public string CustSAPNum { get; set; }

    [Display(Name="CSR Fee")]
    public bool CSRFee { get; set; }

    [Display(Name="BOL Note")]
    public string BOLNote { get; set; }

    [Display(Name="Billing Code")]
    public string BillingCode { get; set; }

    [Display(Name="Sales Code")]
    public string SalesCode { get; set; }

    [Display(Name="Approved")]
    public bool Approved { get; set; }

    [Display(Name="Ship Ref")]
    public string ShipRef { get; set; }

    [Display(Name="CMC User")]
    public string CMCUser { get; set; }

    [Display(Name="Bus Area")]
    public string BusARea { get; set; }

    [Display(Name="Total Order Weight")]
    public decimal TotalOrderWeight { get; set; }

    [Display(Name="Cust Request Date")]
    public string CustRequestDate { get; set; }

    [Display(Name="Approval Date")]
    public string ApprovalDate { get; set; }

    [Display(Name="Requested Delivery Date")]
    public string RequestedDeliveryDate { get; set; }

    [Display(Name="Cust Total Items")]
    public int CustTotalItems { get; set; }

    [Display(Name="Legacy ID")]
    public int LegacyID { get; set; }

    [Display(Name="Location_MDB")]
    public string Location_MDB { get; set; }

    [Display(Name="Company_MDB")]
    public string Company_MDB { get; set; }


    }
}