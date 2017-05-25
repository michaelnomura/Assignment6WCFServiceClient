using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class GetGrant : System.Web.UI.Page
{

    ServiceReference1.ServiceClient sc = new ServiceReference1.ServiceClient();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["userKey"] == null)
        {
            Response.Redirect("default.aspx");
        }
        //if (!IsPostBack)
        //    FillGrantList;
        int key = (int)Session["userKey"];
        ServiceReference1.GrantRequest[] grants = sc.GetGrant(key);
        GridView.DataSource = grants;
        GridView.DataBind();
    }

    protected void DropDownList_SelectedIndexChanged(object sender, EventArgs e)
    {
    //    //ServiceReference1
    }

    //protected void FillGrantList()
    //{
    //    string[] grants = sc.GetGrant();
    //    DropDownList.DataSource = grants;
    //    DropDownList.DataBind();
    //    ListItem item = new ListItem("key");
    //    DropDownList.Items.Insert(0, item);
    //}
}