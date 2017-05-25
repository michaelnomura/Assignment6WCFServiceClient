using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Register : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void SubmitButton_Click(object sender, EventArgs e)
    {
        string last = LastNameTextBox.Text;        
        string first = FirstNameTextBox.Text;       
        string email = EmailTextBox.Text;
        string password = ConfirmTextBox.Text;
        string apartment = ApartmentTextBox.Text;
        string street = StreetTextBox.Text;
        string city = CityTextBox.Text;
        string state = StateTextBox.Text;
        string zip = ZipTextBox.Text;
        string workPhone = WorkPhoneTextBox.Text;
        string homePhone = HomeTextBox.Text;


        ServiceReference1.ServiceClient sc =
            new ServiceReference1.ServiceClient();
        ServiceReference1.PersonInfo person = new ServiceReference1.PersonInfo();
        
        person.lastName = last;
        person.firstName = first;
        person.email = email;
        person.password = password;
        person.apartment = apartment;
        person.street = street;
        person.city = city;
        person.state = state;
        person.zip = zip;
        person.workPhone = workPhone;
        person.homePhone = homePhone;

        bool result = sc.Register(person);
        if(result)
        {
            Response.Redirect("default.aspx");
        }
        else
        {
            ErrorLabel.Text = "Invalid";
        }

    }
}