using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class frmLogin : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Login1_Authenticate(object sender, AuthenticateEventArgs e)
    {
        // Add your comments here
        dsUser dsUserLogin;
        // Add your comments here
        string SecurityLevel;
        // Add your comments here
        dsUserLogin = clsDataLayer.VerifyUser(Server.MapPath("PayrollSystem_DB.mdb"),
                         Login1.UserName, Login1.Password);
        // Add your comments here
        if (dsUserLogin.tblUserLogin.Count < 1)
        {
            e.Authenticated = false;
            return;
        }
        // Add your comments here
        SecurityLevel = dsUserLogin.tblUserLogin[0].SecurityLevel.ToString();
        // Add your comments here
        switch (SecurityLevel)
        {
            case "A":
                // Add your comments here
                e.Authenticated = true;
                Session["SecurityLevel"] = "A";
                break;
            case "U":
                // Add your comments here
                e.Authenticated = true;
                Session["SecurityLevel"] = "U";



                break;
           default:             
                e.Authenticated = false;
                break;
        }
        if (e.Authenticated)
            Response.Redirect("frmMain.aspx");
        

        }
    }

    

