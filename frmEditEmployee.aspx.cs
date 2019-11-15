using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class frmEditEmployee : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

		if (!IsPostBack)
		{
			BindGridview();
		}
	}

	public void BindGridview()
	{



		SqlDataSource data = new SqlDataSource();
		data.ID = "dataPersonnel";
		this.Page.Controls.Add(data);
		data.ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings["PayrollSystem_DBConnectionString"].ConnectionString;
		data.ProviderName = "System.Data.OleDb";
		data.SelectCommand = "SELECT [ID], [FirstName], [LastName], [PayRate], [StartDate], [EndDate] FROM [tblPersonnel]";

		//gvPersonal.DataSource = data;
		gvPersonal.DataBind();
	}
}