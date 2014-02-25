using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

/// <summary>
/// Summary description for ManagePerson
/// </summary>
public class ManagePerson
{

    private Donation d;
    private Customer c;
    private SqlConnection connect;


	public ManagePerson(Donation don, Customer cust)
	{
        d = don;
        c = cust;
        connect = new SqlConnection(ConfigurationManager.ConnectionStrings["CommunityAssistConnectionString"].ConnectionString);
	}

    //public void WritePerson()
    //{
    //    string sql = "Insert into Person() Values ()";
    //    SqlCommand cmd = new SqlCommand(sql, connect);
        

    //    connect.Open();
    //    cmd.ExecuteNonQuery();
    //    connect.Close();

    //}

    public void WriteRegisteredCustomer()
    {
        string sql = "Insert into Person(PersonLastName, PersonFirstName, PersonUsername, PersonPlainPassword, Personpasskey, PersonUserPassword, PersonEntryDate ) Values (@Last,@First, @Email,@Password, @Passcode, @hash, GetDate())";

        PassCodeGenerator psg = new PassCodeGenerator();
        int passcode = psg.GetPasscode();
        PasswordHash ph = new PasswordHash();

        SqlCommand cmd = new SqlCommand(sql, connect);
        cmd.Parameters.AddWithValue("@Last", c.LastName);
        cmd.Parameters.AddWithValue("@First", c.FirstName);
        cmd.Parameters.AddWithValue("@Email", c.Email);
        cmd.Parameters.AddWithValue("@Password", c.Password);
        cmd.Parameters.AddWithValue("@PassCode", passcode);
        cmd.Parameters.AddWithValue("@hash", ph.HashIt(c.Password, passcode.ToString()));

        connect.Open();
        cmd.ExecuteNonQuery();
        connect.Close();

    }

    public void WriteDonation()
    {
        string sql = "Insert into Donation(DonationAmount, DonationDate, PersonKey) Values (@Amount, GetDate(), Ident_Current('Person'))";
        SqlCommand cmd = new SqlCommand(sql, connect);
        cmd.Parameters.AddWithValue("@Amount", d.Amount);
        

        connect.Open();
        cmd.ExecuteNonQuery();
        connect.Close();
    }
   
}