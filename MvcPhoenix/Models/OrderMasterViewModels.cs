using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

// add
using System.Web.Mvc;
using System.ComponentModel.DataAnnotations;

namespace MvcPhoenix.Models
{
    
    public class OrderMaster
    {

    // 5/8/2015 pc skinny down to just EU CS Multi2 fields

    // Add lists as we need them
    // Public Property OrderItems As IEnumerable(Of SelectListItem)
    //public IEnumerable<SelectListItem> ClientList { get; set; }
    //public IEnumerable<SelectListItem> ListOrderIDs { get; set; }
    //public IEnumerable<SelectListItem> ListDivision { get; set; }
    //public IEnumerable<SelectListItem> ListOrderType { get; set; }
    //public IEnumerable<SelectListItem> ListState { get; set; }
    //public IEnumerable<SelectListItem> ListCountry { get; set; }
    //public IEnumerable<SelectListItem> ListRequestor { get; set; }
    //public IEnumerable<SelectListItem> ListShipVia { get; set; }
    //public IEnumerable<SelectListItem> ListSalesRep { get; set; }
    //public IEnumerable<SelectListItem> ListEndUse { get; set; }
    //public IEnumerable<SelectListItem> ListOrderSource { get; set; }
        
    [Display(Name="Order ID")]
    public int orderid { get; set; }

    [Display(Name = "Order ClientID")]
    public int clientid { get; set; }

    [Display(Name = "Customer")]
    public string customer { get; set; }
       
    [Display(Name="CMC Order No.")]
    public int cmcorder { get; set; }

    [Display(Name = "Web Order ID")]
    public int weborderid { get; set; }

    [Display(Name = "CMC Legacy Number")]
    public string cmclegacynumber { get; set; }

    [Display(Name = "Cust Order Number")]
    public string custordnum { get; set; }

    [Display(Name = "Cust SAP Number")]
    public string custsapnum { get; set; }

    [Display(Name = "Ref Number")]
    public string custrefnum { get; set; }

    [Display(Name = "Ship Ref")]
    public int shipref { get; set; }

    [Display(Name = "Order Type")]
    public string ordertype { get; set; }

    [Display(Name = "Order Date")]
    public DateTime orderdate { get; set; }

    [Display(Name = "Company")]
    public string company { get; set; }

    [Display(Name = "Street")]
    public string street { get; set; }

    [Display(Name = "Street2")]
    public string street2 { get; set; }

    [Display(Name = "Street3")]
    public string street3 { get; set; }

    [Display(Name = "City")]
    public string city { get; set; }

    [Display(Name = "State")]
    public string state { get; set; }

    [Display(Name = "Zip")]
    public string Zip { get; set; }

    [Display(Name = "Country")]
    public string country { get; set; }

    [Display(Name = "Attention")]
    public string attention { get; set; }

    [Display(Name = "Email")]
    public string email { get; set; }

    [Display(Name = "Sales Rep")]
    public string salesrep { get; set; }

    [Display(Name = "Sales Email")]
    public string sales_email { get; set; }

    [Display(Name = "Requestor")]
    public string req { get; set; }

    [Display(Name = "Req Phone")]
    public string req_phone { get; set; }

    [Display(Name = "Req Fax")]
    public string req_fax { get; set; }

    [Display(Name = "Req Email")]
    public string req_email { get; set; }

    [Display(Name = "End Use")]
    public string enduse { get; set; }

    [Display(Name = "Ship Via")]
    public string ship_via { get; set; }

    [Display(Name = "Ship Account")]
    public string ship_acct { get; set; }

    [Display(Name = "Phone")]
    public string phone { get; set; }

    [Display(Name = "Source")]
    public string source { get; set; }

    [Display(Name = "Fax")]
    public string fax { get; set; }

    [Display(Name = "Tracking")]
    public string tracking { get; set; }

    [Display(Name = "Special Instr")]
    public string special { get; set; }

    [Display(Name = "Special Int")]
    public string specialinternal { get; set; }

    [Display(Name = "Literature")]
    public bool lit { get; set; }

    [Display(Name = "Region")]
    public string region { get; set; }

    [Display(Name = "COA")]
    public bool coa { get; set; }

    [Display(Name = "TDS")]
    public bool tds { get; set; }

    [Display(Name = "CID")]
    public string cid { get; set; }
        
    [Display(Name="Customer Account")]
    public string custacct { get; set; }

    [Display(Name="ACode")]
    public string acode { get; set; }

    [Display(Name="Import File Name")]
    public string importfile { get; set; }

    [Display(Name="Import Date Line")]
    public string importdateline { get; set; }

    [Display(Name="Timing")]
    public string timing { get; set; }

    [Display(Name="Volume")]
    public string volume { get; set; }

    [Display(Name = "Sample Rack")]
    public bool samplerack { get; set; }
        
    [Display(Name="CMC User")]
    public string CMCUser { get; set; }

    [Display(Name = "Customer Ref")]
    public string customerreference { get; set; }
        
    [Display(Name="Division")]
    public string division { get; set; }

    [Display(Name="Bus Area")]
    public string busarea { get; set; }

    [Display(Name="Total Order Weight")]
    public decimal TotalOrderWeight { get; set; }

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
    public string invoiceCity { get; set; }

    [Display(Name="Invoice State")]
    public string invoiceStateProv { get; set; }

    [Display(Name="Invoice Postal Code")]
    public string invoicePostalCode { get; set; }

    [Display(Name="Invoice Country")]
    public string invoicecountry { get; set; }

    [Display(Name="Invoice Phone")]
    public string invoicephone { get; set; }
    
    [Display(Name="Cust Order Type")]
    public string custordertype { get; set; }

    [Display(Name="Cust Req Date")]
    public DateTime custrequestdate { get; set; }

    [Display(Name="Approval Date")]
    public DateTime approvaldate { get; set; }
        
    [Display(Name="Requested Delivery Date")]
    public DateTime requesteddeliverydate { get; set; }

    [Display(Name="Cust Total Items")]
    public int CustTotalItems { get; set; }

    [Display(Name="Cust Requested Carrier")]
    public string custrequestedcarrier { get; set; }
        
    [Display(Name="Legacy ID")]
    public int legacyid { get; set; }


    // constructor ********************************* 
    public OrderMaster()
    {
        lit = false;
        coa = false;
        tds = false;
        samplerack = false;
    }





    }


    }