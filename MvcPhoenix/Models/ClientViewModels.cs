using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

//add
using System.Web.Mvc;
using System.ComponentModel.DataAnnotations;

namespace MvcPhoenix.DataLayer
{
    public class foo 
    {
        public string bar { get; set; }
    }

    public class Client
    {

        // pull the ef prop
    
        public tblClient dbclient;
        public tblUser dbuser;
        
        // hello


        public virtual foo barref { get; set; }

        //// these properties are persisted in a SQL table using EF
        //[Display(Name = "Client ID")]
        //public int ClientID { get; set; }
 
        //public Nullable<int> LegacyID;
        //public Nullable<int> GlobalClientID { get; set; }
        
        //// [Display(Name = "Client Code")]
        //// public string ClientCode { get; set; }

        //[Display(Name = "Client Name")]
        //public string ClientName { get; set; }

        //[Display(Name = "CMC Location")]
        //public string CMCLocation { get; set; }

        //[Display(Name = "Cust Ref")]
        //public string CustomerReference { get; set; }

        //[Display(Name = "Long Customer")]
        //public string CMCLongCustomer { get; set; }
        
        //public Nullable<bool> MSDS { get; set; }
        //public Nullable<bool> TDS { get; set; }
        //public Nullable<bool> COA { get; set; }
        //public string DocumentDirectory { get; set; }
        //public string MSDS_Folder { get; set; }
        //public string TDS_Folder { get; set; }
        //public string COA_Folder { get; set; }
        //public string SP_ServiceSummary { get; set; }
        //public string SP_Detail1 { get; set; }
        //public string SP_Detail2 { get; set; }
        //public string SP_Detail3 { get; set; }
        //public string SP_Detail4 { get; set; }
        //public string SP_Detail5 { get; set; }
        //public Nullable<System.DateTime> SP_RevDate { get; set; }
        //public string SP_CommValue { get; set; }
        //public string SP_COARequired { get; set; }
        //public string SP_TDSRequired { get; set; }
        //public string SP_MSDSLanguage { get; set; }
        //public string SP_Freezable { get; set; }
        //public string SP_LabelLanguage { get; set; }
        //public string SP_Expedite { get; set; }
        //public string BOLComment { get; set; }

        //non table properties
        [Display(Name = "Select a Client")]
        public IEnumerable<SelectListItem> ClientListold { get; set; }

        public List<SelectListItem> ClientList { get; set; }

        [Display(Name = "Client Count")]
        public int ClientCount { get; set; }

        // *******************************************************************


        // *******************************************************************
        public Client()
        {
            // new constructor
            ClientList = FillClientList();
            ClientCount = fnClientCount();
           
        }


        // *******************************************************************
        private List<SelectListItem> FillClientList()
        {
            List<SelectListItem> mylist = new List<SelectListItem>();

            using (CMCSQL03Entities2 dbcontext = new CMCSQL03Entities2())
            {
                mylist = (from d in dbcontext.tblClients
                          select new SelectListItem { Value = d.ClientID.ToString(), Text = d.ClientName }).ToList();
            }
            return mylist;
        }
        // *******************************************************************



        // *******************************************************************
        private int fnClientCount()
        {
            //int mycount=MvcPhoenix.Models.DBADO.ReturnScalar("Select Count(*) as myscalar from tblClient");
            //return mycount

            return 99;
        }
        // *******************************************************************



        // *******************************************************************
        private List<SelectListItem> Test_ManualClientListForDD()
        {
            List<SelectListItem> mylist = new List<SelectListItem>();
            mylist.Add(new SelectListItem { Value = "V1", Text = "Hello" });
            mylist.Add(new SelectListItem { Value = "V1", Text = "Hello" });
            mylist.Add(new SelectListItem { Value = "V1", Text = "Hello" });
            mylist.Add(new SelectListItem { Value = "V1", Text = "Hello" });

            return mylist;
        }
        // *******************************************************************



        // *******************************************************************
        private List<string> ShipVia()
        {
            List<string> mylist = new List<string>();
            mylist.Add("FEDEX");
            mylist.Add("UPS");
            return mylist;
        }
        // *******************************************************************


        
        // *******************************************************************
        public void ArchiveClient(Client c)
        {
            // Rip the ClientID out of the object
            tblClient dbclient = new tblClient();
            int pk = c.ClientID;

            //MvcPhoenix.Models.DBADO.ExStatement("XXXXXXX");

            System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection();
            string connstring = "Data Source=192.168.0.27;Initial Catalog=CMCSQL03;Persist Security Info=True;User ID=sa;Password=panicbutton";
            conn.ConnectionString = connstring;
            conn.Open();
            System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = "Insert into tblClientArchive select * from tblClient where ClientID=" + c.ClientID;
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        // **************************************************************************


        // **************************************************************************
        public int InsertNewClient(Client c)
        {
            int newpk = 0;

            InsertClient(ref c);
            newpk = c.ClientID;

            return newpk;
        }
        // **************************************************************************

        
        
        // **************************************************************************
        public void InsertClient(ref Client c)
        {
            tblClient dbclient = new tblClient();

            dbclient.ClientName = c.ClientName;

            using (CMCSQL03Entities2 dbcontext = new CMCSQL03Entities2())
            {
                dbcontext.tblClients.Add(dbclient);
                dbcontext.SaveChanges();
            }
            c.ClientID = dbclient.ClientID;
        }
        // **************************************************************************



        // **************************************************************************
        public void UpdateJustCMCLongCustomer(Client c)
        {
            // With Ef, you have to pull the entire record out then set the property value, then push the whole EF obj back
            // Seems very in-efficient vs. Update tblClient set CMCLocation=@para where ClientID=@ID
            tblClient dbclient = new tblClient();

            using (CMCSQL03Entities2 dbcontext = new CMCSQL03Entities2())
            {
                dbclient = (from d in dbcontext.tblClients where d.ClientID == c.ClientID select d).FirstOrDefault();
                dbclient.CMCLocation = c.CMCLocation;
                dbcontext.SaveChanges();
            }
        }
        // **************************************************************************


        
        // **************************************************************************
        public void SaveClient(Client c)
        {
            // this code structure assume that we are updating on a PK
            tblClient DBclient = new tblClient();

            DBclient.ClientID = c.ClientID;
            DBclient.ClientName = c.ClientName;
            DBclient.CMCLongCustomer = "LONG";

            using (CMCSQL03Entities2 dbcontext = new CMCSQL03Entities2())
            {
                dbcontext.tblClients.Attach(DBclient);
                dbcontext.Entry(DBclient).State = System.Data.Entity.EntityState.Modified;
                dbcontext.SaveChanges();
            }
        }


        // **************************************************************************
        public void DeleteClient(int id)
        {
            // Call the ArchiveClient (id)
            // Issue a direct ADO "Delete From" command or access the EF layer to delete a row
        }
        // **************************************************************************



        // **************************************************************************
        public Client FillClientByID(int id)
        {
            // How do I pull from the EF class tblClient to get the DB properties set???
            // ClientList=call another method that returns a selectlistitem
            // ClientCount=call another method that returns a scalar

            Client newclient = new Client();
            // Client newclient;

            tblClient DBclient;

            using (CMCSQL03Entities2 dbcontext = new CMCSQL03Entities2())
            {
                DBclient = (from cc in dbcontext.tblClients where cc.ClientID == id select cc).FirstOrDefault();
                //newclient = (from cc in dbcontext.tblClients
                //            where cc.ClientID == id
                //            select new Client
                //            {
                //                ClientID = cc.ClientID,
                //                ClientName = cc.ClientName 
                //            }).FirstOrDefault();
            }

            newclient.ClientID = DBclient.ClientID;
            newclient.ClientName = DBclient.ClientName;

            return newclient;
        }
        // **************************************************************************
        


        // **************************************************************************
        public bool EmailUpdateToClient(Client c)
        {
            // send an email, return success
            return true;
        }
        // **************************************************************************



    }

}