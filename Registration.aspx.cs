using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Registration : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
       
    }
    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        PassCodeGenerator pg = new PassCodeGenerator();
        int passcode = pg.GetPasscode();

        Customer c = new Customer();
        Donation d = new Donation();
        PasswordHash ph = new PasswordHash();

        c.LastName = txtLastName.Text;
        c.FirstName = txtFirstName.Text;
        c.Email = txtEmail.Text;
        c.Password = txtPassword.Text;
        //c.passcode = passcode;
        //c.PasswordHash = ph.HashIt(txtPassword.Text, passcode.ToString());

       
        try
        {
        ManagePerson mp = new ManagePerson(d, c);
      
        mp.WriteRegisteredCustomer();
        mp.WriteDonation();
        lblResult.Text = "Thank you for registering!";
        LinkButton1.Visible = true;
        }
        catch (Exception ex)
        {
            lblResult.Text = ex.ToString();
        }
    }
}