using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
// Add your comments here
using System.Data.OleDb;
using System.Net;
using System.Data;


/*
 * Source: DeVry University :: Lab 3 Partial Solution :: January 25th, 2012
 * Professor:   Richard Martin :: rmartin@devry.edu
 * Comments: 
 */
public class clsDataLayer
{
    // This function saves the personnel data
    // This function saves the personnel data
    public static bool SavePersonnel(string Database, string FirstName, string LastName,
                                     string PayRate, string StartDate, string EndDate)
    {
        bool recordSaved;
        // ** NEW ** Add your comments here
        OleDbTransaction myTransaction = null;
        try
        {
            // Add your comments here
            OleDbConnection conn = new OleDbConnection("PROVIDER=Microsoft.Jet.OLEDB.4.0;" +
                                                       "Data Source=" + Database);
            conn.Open();
            OleDbCommand command = conn.CreateCommand();
            string strSQL;
            // ** NEW ** Add your comments here
            myTransaction = conn.BeginTransaction();
            command.Transaction = myTransaction;
            // Add your comments here
            strSQL = "Insert into tblPersonnel " +
                     "(FirstName, LastName) values ('" +
                     FirstName + "', '" + LastName + "')";
            // Add your comments here
            command.CommandType = CommandType.Text;
            command.CommandText = strSQL;
            // Add your comments here
            command.ExecuteNonQuery();
            // Add your comments here
            strSQL = "Update tblPersonnel " +
                     "Set PayRate=" + PayRate + ", " +
                     "StartDate='" + StartDate + "', " +
                     "EndDate='" + EndDate + "' " +
                     "Where ID=(Select Max(ID) From tblPersonnel)";
            // Add your comments here
            command.CommandType = CommandType.Text;
            command.CommandText = strSQL;
            // Add your comments here
            command.ExecuteNonQuery();
            // ** NEW ** Add your comments here
            myTransaction.Commit();
            // Add your comments here
            conn.Close();
            recordSaved = true;
        }
        catch (Exception ex)
        {
            // ** NEW ** Add your comments here
            myTransaction.Rollback();

            recordSaved = false;
        }
        return recordSaved;
    }

    //the above is the code that I added.'

        // This function gets the user activity from the tblUserActivity
    public static dsUserActivity GetUserActivity(string Database)
    {
        // Add your comments here
        dsUserActivity DS;
        OleDbConnection sqlConn;
        OleDbDataAdapter sqlDA;

        // Add your comments here
        sqlConn = new OleDbConnection("PROVIDER=Microsoft.Jet.OLEDB.4.0;" +
            "Data Source=" + Database);

        // Add your comments here
        sqlDA = new OleDbDataAdapter("select * from tblUserActivity", sqlConn);

        // Add your comments here
        DS = new dsUserActivity();

        // Add your comments here
        sqlDA.Fill(DS.tblUserActivity);

        // Add your comments here
        return DS;
    }
    public static dsPersonnel GetPersonel(string Database)
    {
        // Add your comments here
        dsPersonnel DS;
        OleDbConnection sqlConn;
        OleDbDataAdapter sqlDA;

        // Add your comments here
        sqlConn = new OleDbConnection("PROVIDER=Microsoft.Jet.OLEDB.4.0;" +
            "Data Source=" + Database);

        // Add your comments here
        sqlDA = new OleDbDataAdapter("select * from tblPersonnel", sqlConn);

        // Add your comments here
        DS = new dsPersonnel();

        // Add your comments here
        sqlDA.Fill(DS.tblPersonnel);

        // Add your comments here
        return DS;
    }


    // This function saves the user activity
    public static void SaveUserActivity(string Database, string FormAccessed)
    {
        // Add your comments here
        OleDbConnection conn = new OleDbConnection("PROVIDER=Microsoft.Jet.OLEDB.4.0;" +
            "Data Source=" + Database);
        conn.Open();
        OleDbCommand command = conn.CreateCommand();
        string strSQL;

        strSQL = "Insert into tblUserActivity (UserIP, FormAccessed) values ('" +
            GetIP4Address() + "', '" + FormAccessed + "')";

        command.CommandType = CommandType.Text;
        command.CommandText = strSQL;
        command.ExecuteNonQuery();
        conn.Close();
    }

    // This function gets the IP Address
    public static string GetIP4Address()
    {
        string IP4Address = string.Empty;

        foreach (IPAddress IPA in
                    Dns.GetHostAddresses(HttpContext.Current.Request.UserHostAddress))
        {
            if (IPA.AddressFamily.ToString() == "InterNetwork")
            {
                IP4Address = IPA.ToString();
                break;
            }
        }

        if (IP4Address != string.Empty)
        {
            return IP4Address;
        }

        foreach (IPAddress IPA in Dns.GetHostAddresses(Dns.GetHostName()))
        {
            if (IPA.AddressFamily.ToString() == "InterNetwork")
            {
                IP4Address = IPA.ToString();
                break;
            }
        }

        return IP4Address;
    }



    public static dsUser VerifyUser(string Database, string UserName, string UserPassword)
{
    // Add your comments here
    dsUser DS;
    OleDbConnection sqlConn;
    OleDbDataAdapter sqlDA;
    // Add your comments here
    sqlConn = new OleDbConnection("PROVIDER=Microsoft.Jet.OLEDB.4.0;" +
                                  "Data Source=" + Database);
    // Add your comments here
    sqlDA = new OleDbDataAdapter("Select SecurityLevel from tblUserLogin " +
                                  "where UserName like '" + UserName + "' " +
                                  "and UserPassword like '" + UserPassword + "'", sqlConn);
    // Add your comments here
    DS = new dsUser();
    // Add your comments here
    sqlDA.Fill(DS.tblUserLogin);
    // Add your comments here
    return DS;
}
}








