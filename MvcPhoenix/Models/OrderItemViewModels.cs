﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcPhoenix.Models
{
    public class OrderItem
    {
        // 5/8/2015 pc Needs to be decorated...

        public int ItemID { get; set; }
        public Nullable<int> OrderID { get; set; }
        public Nullable<int> CMCOrder { get; set; }
        public string LegacyCMCOrder { get; set; }
        public string CustOrdNum { get; set; }
        public string BusArea { get; set; }
        public string ImportItemID { get; set; }
        public string ProductCode { get; set; }
        public string ProductName { get; set; }
        public string MNEMONIC { get; set; }
        public string LotNumber { get; set; }
        public Nullable<int> Qty { get; set; }
        public string Size { get; set; }
        public string SRSize { get; set; }
        public Nullable<System.DateTime> ShipDate { get; set; }
        public Nullable<bool> NonCMCDelay { get; set; }
        public string DelayReason { get; set; }
        public string Via { get; set; }
        public Nullable<decimal> FRT { get; set; }
        public Nullable<decimal> FrtSurcharge { get; set; }
        public Nullable<decimal> DH { get; set; }
        public Nullable<decimal> Other { get; set; }
        public Nullable<decimal> TotalSurcharge { get; set; }
        public string SpecialRequest { get; set; }
        public string AirHazard { get; set; }
        public string GroundHazard { get; set; }
        public Nullable<bool> BackOrdered { get; set; }
        public string ProfitArea { get; set; }
        public string Status { get; set; }
        public string AllocateStatus { get; set; }
        public Nullable<bool> CSAllocate { get; set; }
        public string Location { get; set; }
        public Nullable<System.DateTime> ExpDate { get; set; }
        public string CustProdCode { get; set; }
        public string CustProdName { get; set; }
        public string CustSize { get; set; }
        public string Currency { get; set; }
        public string UnitPrice { get; set; }
        public Nullable<bool> EmailSent { get; set; }
        public Nullable<bool> BackorderEmailSent { get; set; }
        public string CustCode { get; set; }
        public string Weight { get; set; }
        public string CMCLocation { get; set; }
        public Nullable<int> LineItem { get; set; }
        public Nullable<bool> SAPClosed { get; set; }
        public Nullable<int> PackID { get; set; }
        public Nullable<decimal> ShipWt { get; set; }
        public Nullable<decimal> ShipDimWt { get; set; }
        public string SPSCost { get; set; }
        public Nullable<bool> CarrierInvoiceRcvd { get; set; }
        public Nullable<decimal> WasteOrderTotalWeight { get; set; }
        public string CustStatus { get; set; }
        public Nullable<int> LegacyID { get; set; }
    
    
    
    
    
    
    }
}