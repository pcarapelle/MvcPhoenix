using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Data.SqlClient;


namespace MvcPhoenix.Models
{
    public class DBADO
    {
    // private string connstring1= System.Configuration.ConfigurationManager.AppSettings.Get("LIVESQL");
    private static string connstring="Data Source=192.168.0.27;Initial Catalog=CMCSQL03;Persist Security Info=True;User ID=sa;Password=panicbutton";
    // private string connstring3="Data Source=SX;Initial Catalog=CMCSQL03;Integrated Security=True";

    public DBADO() {
    // constructor
    }

    public SqlDataReader ReturnReader(string sqltext){
        SqlConnection conn=new SqlConnection();
        conn.ConnectionString=connstring;
        conn.Open();
        SqlCommand cmd= new SqlCommand();
        cmd.CommandType = System.Data.CommandType.Text;
        cmd.CommandText=sqltext;
        SqlDataReader reader = cmd.ExecuteReader();
        conn.Close();
        return reader;
    }

        //static in C# is shared in VB
    public static void ExStatement(string sqltext)
    {
        SqlConnection conn = new SqlConnection();
        conn.ConnectionString = connstring;
        conn.Open();
        SqlCommand cmd = new SqlCommand();
        cmd.CommandType = System.Data.CommandType.Text;
        cmd.CommandText = sqltext;
        cmd.ExecuteNonQuery();
        conn.Close();
    }

    //public string ReturnScalarAsString(string sqltext)
    //{
    //    // not sure if the obj return type will work....
    //    // usually CAST in calling code
    //    //SqlConnection conn = new SqlConnection();
    //    //conn.ConnectionString = connstring;
    //    //conn.Open();
    //    //SqlCommand cmd = new SqlCommand();
    //    //cmd.CommandType = System.Data.CommandType.Text;
    //    //cmd.CommandText = sqltext;
    //    //string temp;
    //    //temp = cmd.ExecuteScalar();
    //    //conn.Close();
    //    //return temp;
    //}
    



    }


}