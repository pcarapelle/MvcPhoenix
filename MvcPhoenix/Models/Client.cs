using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

// Manually added these
using System.Web.Mvc;
using System.ComponentModel.DataAnnotations;
using System.Data.SqlClient;


namespace MvcPhoenix.Models
{
    public class ClientViewModel
    {
               
        public ClientModel DBClient;
        public MvcPhoenix.DataLayer.tblUser DBUser;
        
        // **************************************************************
        // Below are non table mapped properties suchs as lists
        // **************************************************************
        [Display(Name = "Select a Client")]
        public IEnumerable<SelectListItem> ClientList { get; set; }

        [Display(Name = "Client Count")]
        public int ClientCount { get; set; }
               

        [Display(Name = "Client ID")]
        public int ClientID { get; set; }
        public Nullable<int> LegacyID;
        public Nullable<int> GlobalClientID { get; set; }
        [Display(Name = "Client Code")]
        public string ClientCode { get; set; }
        [Display(Name = "Client Name")]
        public string ClientName { get; set; }
        [Display(Name = "CMC Location")]
        public string CMCLocation { get; set; }
        [Display(Name = "Cust Ref")]
        public string CustomerReference { get; set; }
        [Display(Name = "Long Customer")]
        public string CMCLongCustomer { get; set; }
        public Nullable<bool> MSDS { get; set; }
        public Nullable<bool> TDS { get; set; }
        public Nullable<bool> COA { get; set; }
        public string DocumentDirectory { get; set; }
        public string MSDS_Folder { get; set; }
        public string TDS_Folder { get; set; }
        public string COA_Folder { get; set; }
        public string SP_ServiceSummary { get; set; }
        public string SP_Detail1 { get; set; }
        public string SP_Detail2 { get; set; }
        public string SP_Detail3 { get; set; }
        public string SP_Detail4 { get; set; }
        public string SP_Detail5 { get; set; }
        public Nullable<System.DateTime> SP_RevDate { get; set; }
        public string SP_CommValue { get; set; }
        public string SP_COARequired { get; set; }
        public string SP_TDSRequired { get; set; }
        public string SP_MSDSLanguage { get; set; }
        public string SP_Freezable { get; set; }
        public string SP_LabelLanguage { get; set; }
        public string SP_Expedite { get; set; }
        public string BOLComment { get; set; }


        



        // **************************************************************
        // Below are all the methods we need to deal with a Client object
        // This will grow to perform many tasks
        // **************************************************************
        //public Client() { 
        // Constructor
            // What values get assigned to all the above properties as part of this 'New' constructor?

           // TestClientName = DBClient.ClientName;
            
            // ClientCount = GetClientCount();
            // ClientList = FillClientList();
         //}

       


        
        
        // Do whatever else is necessary as part of a save
        
        }


        // **********************************************************
        //public void FillClient(int id)
        //{
        //    DBADO mydb = new DBADO();
        //    SqlDataReader dr = new mydb.ReturnReader("dede");
        //    while (dr.read)
        //    {
        //       //fill props
        //       // ClientName = (string)dr["ClientName"];
        //    }
        //}


        // **********************************************************
        // Build the list of clients
        //private List<SelectListItem> FillClientList()
        //{
        //    //wire to sqldatareader
        //    List<SelectListItem> mylist = new List<SelectListItem>();
        //    mylist.Add(new SelectListItem {Text="One",Value="0"});
        //    mylist.Add(new SelectListItem { Text = "Two", Value = "1" });
        //    return mylist;

        //}


        // **********************************************************
        // Count the client records
        //private int GetClientCount()
        //{
        //    string abc = DBClient.CMCLocation;
        //    string def = CMCLocation;


        //    return 99;
        //}
    







    }



