using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace MvcPhoenix.Models
{
    public class ServiceViewModels
    {
        public int ClientID { get; set; }
                
        [Display(Name = "Name")]
        public string ClientName { get; set; }

        public IEnumerable<SelectListItem> ClientNameList { get; set; }

        [Display(Name = "Market Segment")]
        public string ClientMktSeg { get; set; }

        public IEnumerable<SelectListItem> ClientMktSegList { get; set; }

        [Display(Name = "Order Reference")]
        public string ClientOrderRef { get; set; }

        [Display(Name = "Order Type")]
        public string OrderType { get; set; }

        public IEnumerable<SelectListItem> OrderTypeList { get; set; }

        [Display(Name = "Order Source")]
        public string OrderSrc { get; set; }

        public IEnumerable<SelectListItem> OrderSrcList { get; set; }

        [Display(Name = "Name")]
        public string RecipientName { get; set; }

        [Display(Name = "Attention")]
        public string RecipientAttention { get; set; }
        
        [Display(Name = "Address")]
        public string RecipientAddress { get; set; }
        
        [Display(Name = "City")]
        public string RecipientCity { get; set; }
        
        [Display(Name = "State")]
        public string RecipientState { get; set; }
        
        [Display(Name = "Zip")]
        public int RecipientZip { get; set; }
        
        [Display(Name = "Country")]
        public string RecipientCountry { get; set; }

        public IEnumerable<SelectListItem> RecipientCountryList { get; set; }

        [Display(Name = "Phone")]
        public string RecipientPhone { get; set; }
        
        [Display(Name = "Fax")]
        public string RecipientFax { get; set; }
        
        [Display(Name = "Email")]
        public string RecipientEmail { get; set; }
        
        [Display(Name = "Name")]
        public string RequestorName { get; set; }
        
        [Display(Name = "Email")]
        public string RequestorEmail { get; set; }
        
        [Display(Name = "Phone")]
        public string RequestorPhone { get; set; }
        
        [Display(Name = "Fax")]
        public string RequestorFax { get; set; }
        
        [Display(Name = "Sales Rep's Name")]
        public string SalesRepName { get; set; }
        
        [Display(Name = "Sales Rep's Email")]
        public string SalesRepEmail { get; set; }
        
        [Display(Name = "Sales Rep's Phone")]
        public string SalesRepPhone { get; set; }

        [Display(Name = "Sales Rep's Territory")]
        public string SalesRepTerritory { get; set; }

        [Display(Name = "Marketing Rep's Name")]
        public string MarketingRepName { get; set; }

        [Display(Name = "Marketing Rep's Email")]
        public string MarketingRepEmail { get; set; }

        [Display(Name = "Approval Needed?")]
        public bool ApprovalNeeded  { get; set; }
        
        [Display(Name = "Approver")]
        public string ApproverName { get; set; }
        
        [Display(Name = "Approval Date")]
        public DateTime ApprovalDate  { get; set; }
        
        [Display(Name = "Product Name")]
        public string ProductName { get; set; }

        [Display(Name = "Business Unit")]
        public string ClientBusUnit { get; set; }

        public IEnumerable<SelectListItem> ClientBusUnitList { get; set; }

        [Display(Name = "Division")]
        public string ClientDivision { get; set; }

        public IEnumerable<SelectListItem> ClientDivisionList { get; set; }
        
        [Display(Name = "Product Code")]
        public string ProductCode { get; set; }
        
        [Display(Name = "Cross Reference Code")]
        public string ProductXRefCode { get; set; }
        
        [Display(Name = "Lot Number")]
        public string ProductLotNumber { get; set; }
        
        [Display(Name = "Quantity")]
        public int ProductQty { get; set; }
        
        [Display(Name = "Size")]
        public decimal ProductSize { get; set; }
        
        [Display(Name = "Product Type")]
        public string ProductType { get; set; }
        
        [Display(Name = "Special Request Size")]
        public string ProductSpecialReqSize { get; set; }
        
        [Display(Name = "Delay Reason")]
        public string ProductDelayReason { get; set; }

        public IEnumerable<SelectListItem> ProductDelayReasonList { get; set; }

        [Display(Name = "Charge Code")]
        public string OrderChargeCode { get; set; }

        public IEnumerable<SelectListItem> OrderChargeCodeList { get; set; }
        
        [Display(Name = "Charge Description")]
        public string OrderChargeDesc { get; set; }
        
        [Display(Name = "Charge Type")]
        public string OrderChargeType { get; set; }
        
        [Display(Name = "Linked Object")]
        public string OrderChargeLinkObj { get; set; }

        public IEnumerable<SelectListItem> OrderChargeLinkObjList { get; set; }

        [Display(Name = "Preferred Carrier")]
        public string ShipCarrierPref { get; set; }

        public IEnumerable<SelectListItem> ShipCarrierPrefList { get; set; }
        
        [Display(Name = "Collect Account")]
        public string ShipCarrierCollectAcct { get; set; }
                
        [Display(Name = "Distributor")]
        public string Distributor { get; set; }
        
        [Display(Name = "Special Instructions")]
        public string SpecialInstruct { get; set; }
        
        public IEnumerable<SelectListItem> LogCannedNoteList { get; set; }

        [Display(Name = "Canned Note")]
        public string LogCannedNote { get; set; }
        
        [Display(Name = "Additional Notes")]
        public string LogAddNotes { get; set; }

        [Display(Name = "URL Upload")]
        public string UrlUploadPath { get; set; }

        [Display(Name = "Tier")]
        public string PricingTier { get; set; }

        [Display(Name = "Include Pricing")]
        public bool IncludePricing { get; set; }

    }
}