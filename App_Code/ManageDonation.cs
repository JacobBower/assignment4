using System;
using System.Collections.Generic;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

/// <summary>
/// Summary description for ManageVehicle
/// </summary>
public class ManageDonation
{
    SqlConnection connect;


    public ManageDonation()
    {
        connect = new SqlConnection(ConfigurationManager.ConnectionStrings["CommunityAssistConnectionString"].ConnectionString);
    }

    public DataTable GetDonation(int personKey)
    {
        string sql = "Select PersonFirstName, PersonLastName, DonationAmount From Donation inner Join Person on person.PersonKey=Donation.Personkey where Donation.personkey=@personKey";

        SqlCommand cmd = new SqlCommand(sql, connect);
        cmd.Parameters.AddWithValue("@personKey", personKey);
        SqlDataReader reader = null;
        DataTable table = new DataTable();
        reader = cmd.ExecuteReader();
        table.Load(reader);
        reader.Dispose();
        connect.Close();
        return table;
    }

}