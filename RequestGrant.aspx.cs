using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class RequestGrant : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void SubmitButton_Click(object sender, EventArgs e)
    {
        if (Session["userKey"] == null)
        {
            Response.Redirect("default.aspx");
        }
        //float amount = AmountTextBox.Text;

        decimal amount = Convert.ToDecimal(AmountTextBox.Text);
        string explantion = GrantExplanationBox.Text;
        int type = Convert.ToInt16(TypeKeyTextBox.Text);
        int userKey = (int)Session["userKey"];

        ServiceReference1.ServiceClient sc =
            new ServiceReference1.ServiceClient();

        ServiceReference1.GrantRequest grant = new ServiceReference1.GrantRequest();

        grant.GrantRequestAmount = amount;
        grant.GrantRequestExplanation = explantion;
        grant.GrantRequestDate = DateTime.Now;
        grant.GrantTypeKey = type;
        grant.PersonKey = userKey;

        bool result = sc.RequestGrant(grant);
        if (result)
        {
            Response.Redirect("GetGrant.aspx");
        }
        else
        {
            ErrorLabel.Text = "Invalid Login";
        }

    }
}