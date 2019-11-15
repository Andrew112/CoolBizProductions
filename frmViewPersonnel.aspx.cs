using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
/*
 *Source: DeVry University :: Lab 4 Partial Solution :: February 1st, 2012
 * Professor:   Richard Martin :: rmartin@devry.edu
 * Comments:
 */
public partial class frmViewPersonnel : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
    //    if (!Page.IsPostBack)
    //    {

    //        // Declare the DataSet
    //        dsPersonnel myDataSet = new dsPersonnel();

    //        string strSearch = Request["txtSearch"];

    //        // Fill the dataset with what is returned from the function
    //        myDataSet = clsDataLayer.GetPersonnel(Server.MapPath("PayrollSystem_DB.mdb"), strSearch);

    //        // Set the DataGrid to the DataSource based on the table
    //        grdViewPersonnel.DataSource = myDataSet.Tables["tblPersonnel"];

    //        // Bind the DataGrid
    //        grdViewPersonnel.DataBind();

    //    }
     
if (!Page.IsPostBack) {
// Declare the DataSet
dsPersonnel myDataSet = new dsPersonnel();

    // Fill the dataset with what is returned from the function
    myDataSet = clsDataLayer.GetPersonel(Server.MapPath("PayrollSystem_DB.mdb"));
// Set the DataGrid to the DataSource based on the table
grdViewPersonnel.DataSource = myDataSet.Tables["tblPersonnel"];

// Bind the DataGrid
grdViewPersonnel.DataBind();
}

 


    }
}
