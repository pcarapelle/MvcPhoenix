using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


using System.Data.SqlClient;
using System.Web.Mvc;
using MvcPhoenix.DataLayer;

// **************************************************
// This namespace contains public static methods
// **************************************************

namespace CMC01
{

    public class CmCLocations
    {
        public string Location { get; set; }
    }


    public class misc
    {

        public static List<SelectListItem> CMCLocationList()
        {
            List<SelectListItem> mylist = new List<SelectListItem>();
            mylist.Add(new SelectListItem { Value = "", Text = "" });
            mylist.Add(new SelectListItem { Value = "CT", Text = "CT" });
            mylist.Add(new SelectListItem { Value = "CO", Text = "CO" });
            mylist.Add(new SelectListItem { Value = "EU", Text = "EU" });
            mylist.Add(new SelectListItem { Value = "AP", Text = "AP" });
            return mylist;
        }

        public static IEnumerable<CmCLocations> DDLocations = new List<CmCLocations>{
            new CmCLocations{Location="CT"},
            new CmCLocations{Location="CO"},
            new CmCLocations{Location="EU"},
            new CmCLocations{Location="AP"}
        };


        public static List<SelectListItem> MiscFillClientList(int ClientID)
        // Fill a List for use with dropdown .. I prefer older ADO method .. much simpler .. EF is using same provider
        {
            List<SelectListItem> mylist = new List<SelectListItem>();
            using (CMCSQL03Entities2 dbcontext = new CMCSQL03Entities2())
            {
                mylist = (from d in dbcontext.tblClients
                          orderby d.ClientName
                          select new SelectListItem { Value = d.ClientID.ToString(), Text = d.ClientName }).ToList();
            }
            //  mylist.Add(new SelectListItem { Value = "V1", Text = "Hello" });
            mylist.Insert(0, new SelectListItem { Value = "0", Text = "Please Select a Client" });
            return mylist;
        }


        public static List<SelectListItem> FillDivisionList(int ClientID)
        {
            // Return a client specific List for use with DDs
            List<SelectListItem> mylist = new List<SelectListItem>();
            using (CMCSQL03Entities2 dbcontext = new CMCSQL03Entities2())
            {
                mylist = (from d in dbcontext.tblDivisions
                          where d.ClientID == ClientID
                          orderby d.Division
                          select new SelectListItem { Value = d.Division, Text = d.Division }).ToList();
            }
            mylist.Insert(0, new SelectListItem { Value = "0", Text = "Divisions" });
            return mylist;
        }




        public static List<SelectListItem> FillStateList(int ClientID)
        {
            // Return a client  specific List for use with DDs
            List<SelectListItem> mylist = new List<SelectListItem>();
            using (CMCSQL03Entities2 dbcontext = new CMCSQL03Entities2())
            {
                mylist = (from d in dbcontext.tblStates
                          orderby d.StateAbbr
                          select new SelectListItem { Value = d.StateAbbr, Text = d.StateName }).ToList();
            }
            mylist.Insert(0, new SelectListItem { Value = "0", Text = "Please Select a State" });
            return mylist;
        }


        public static List<SelectListItem> tbd_FillClientListFromSearch(string search)
        {
            List<SelectListItem> mylist = new List<SelectListItem>();
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = CMC01.dbsql.connstring();
            string s = "Select ClientID,ClientName from tblClient where charindex('" + search + "',ClientName)>0";
            //string s = "Select ClientID,ClientName from tblClient where charindex('Dow',ClientName)>0";

            SqlCommand cmd = new SqlCommand(s, conn);
            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                mylist.Add(new SelectListItem { Value = reader["ClientID"].ToString(), Text = reader["ClientName"].ToString() });

            }
            mylist.Insert(0, new SelectListItem { Value = "0", Text = "Please Select a Client" });
            reader.Close();
            conn.Close();
            return mylist;

        }

    }





    public class dbsql
    {
        public static string connstring()
        {
            // return "Data Source=192.168.0.27;Initial Catalog=CMCSQL03;Persist Security Info=True;User ID=sa;Password=panicbutton";
            //return "Data Source=SX;Initial Catalog=CMCSQL03;Integrated Security=True";

            return System.Configuration.ConfigurationManager.ConnectionStrings["SQLADO"].ConnectionString;

        }

        private SqlDataReader ReturnReader(string sqltext)
        {
            // string connstring = "Data Source=SX;Initial Catalog=CMCSQL03;Integrated Security=True";
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = connstring();
            conn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = sqltext;
            SqlDataReader reader = cmd.ExecuteReader();
            conn.Close();
            return reader;
        }

        private void fnSaveClient(Client c)
        {

            // DO NOT USE THIS APPROACH ... OK if always binding to all columns
            //If not set, the EF will set=Null .. Bad thing !!

            // Create a work object and fill it with values from the passed object
            tblClient DBclient = new tblClient();
            DBclient.ClientID = c.ClientID;
            // do not change R/O properties    DBclient.LegacyID = c.LegacyID;
            DBclient.GlobalClientID = c.GlobalClientID;
            DBclient.ClientName = c.ClientName;
            DBclient.CustomerReference = c.CustomerReference;
            DBclient.ClientCode = c.ClientCode;
            DBclient.CMCLocation = c.CMCLocation;
            DBclient.CMCLongCustomer = c.CMCLongCustomer;
            //DBclient.MSDS = c.MSDS;
            // ... more fields here

            using (CMCSQL03Entities2 dbcontext = new CMCSQL03Entities2())
            {
                // Danger Will Robinson - This attach assumes a FULLY populated EF object is being submitted
                // THIS WILL NOT WORK in a production environment because we dont always have all the fields !
                dbcontext.tblClients.Attach(DBclient);
                dbcontext.Entry(DBclient).State = System.Data.Entity.EntityState.Modified;
                dbcontext.SaveChanges();
            }
        }

        public static int ReturnScalarInteger(string sqltext)
        {
            int recs = 0;
            // string connstring = "Data Source=SX;Initial Catalog=CMCSQL03;Integrated Security=True";
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = connstring();
            SqlCommand cmd = new SqlCommand(sqltext, conn);
            conn.Open();
            // cmd.CommandType = System.Data.CommandType.Text;
            // cmd.CommandText = sqltext;
            recs = Convert.ToInt32(cmd.ExecuteScalar());
            conn.Close();
            return recs;
        }



        public static  void ExecuteSQL(string sqltext)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = connstring();
            conn.Open();
            SqlCommand cmd = new SqlCommand(sqltext, conn);
            //cmd.CommandType = System.Data.CommandType.Text;
            //cmd.CommandText = sqltext;
            cmd.ExecuteNonQuery();
            conn.Close();
        }

       





        



        // *******************************************************************
        private List<SelectListItem> ManualSelectListTemplate()
        {
            List<SelectListItem> mylist = new List<SelectListItem>();
            mylist.Add(new SelectListItem { Value = "V1", Text = "Hello" });
            mylist.Add(new SelectListItem { Value = "V2", Text = "Good bye" });
            mylist.Add(new SelectListItem { Value = "V3", Text = "Hey You" });
            mylist.Add(new SelectListItem { Value = "V4", Text = "Go Home" });
            return mylist;
        }

        // *******************************************************************
        private List<string> ManualListTemplateSingleColumn()
        {
            List<string> mylist = new List<string>();
            mylist.Add("Item 1");
            mylist.Add("Item 2");
            return mylist;
        }



    }

    public class dbmdb
    {
    }


}