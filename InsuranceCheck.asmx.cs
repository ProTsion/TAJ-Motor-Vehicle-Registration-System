using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Globalization;

namespace IdentityFramework
{
    /// <summary>
    /// Summary description for Insurance_Check
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class Insurance_Check : System.Web.Services.WebService
    {

        [WebMethod]
        public int insurance(string lp)
        {
            string connstring = ConfigurationManager.ConnectionStrings["TAJConnectionString"].ConnectionString;

            using (SqlConnection con = new SqlConnection(connstring))
            {

                SqlDataAdapter cmd = new SqlDataAdapter(" SELECT EndDate FROM InsuranceTBL WHERE LicensePlate= '" + lp + "'", con);
                DataSet ds = new DataSet();
                cmd.Fill(ds);

                string SEndDate = ds.Tables[0].Rows[0]["EndDate"].ToString().Split(' ')[0];
                System.Diagnostics.Debug.WriteLine("End Date in String format " +SEndDate);

                DateTime EndDate = DateTime.Parse(SEndDate);


                SqlDataAdapter cmd1 = new SqlDataAdapter(" SELECT StartDate FROM InsuranceTBL WHERE LicensePlate= '" + lp + "'", con);
                DataSet ds1 = new DataSet();
                cmd1.Fill(ds1);

                string SStartDate = ds1.Tables[0].Rows[0]["StartDate"].ToString().Split(' ')[0];
                System.Diagnostics.Debug.WriteLine("SEndata" + SStartDate);

                DateTime StartDate = DateTime.Parse(SStartDate);

                int output = Convert.ToInt32((EndDate - StartDate).TotalDays);

                return output;
            }
        }



        [WebMethod]
        public int fitness(string ch)
        {
            string connstring = ConfigurationManager.ConnectionStrings["TAJConnectionString"].ConnectionString;

            using (SqlConnection con = new SqlConnection(connstring))
            {

                SqlDataAdapter cmd = new SqlDataAdapter(" SELECT EndDate FROM FitnessTbl WHERE Chassis= '" + ch + "'", con);
                DataSet ds = new DataSet();
                cmd.Fill(ds);

                string SEndDate = ds.Tables[0].Rows[0]["EndDate"].ToString().Split(' ')[0];
                System.Diagnostics.Debug.WriteLine("End Date in String format " + SEndDate);

                DateTime EndDate = DateTime.Parse(SEndDate);


                SqlDataAdapter cmd1 = new SqlDataAdapter(" SELECT StartDate FROM FitnessTbl WHERE Chassis= '" + ch + "'", con);
                DataSet ds1 = new DataSet();
                cmd1.Fill(ds1);

                string SStartDate = ds1.Tables[0].Rows[0]["StartDate"].ToString().Split(' ')[0];
                System.Diagnostics.Debug.WriteLine("SEndata" + SStartDate);

                DateTime StartDate = DateTime.Parse(SStartDate);

                int output = Convert.ToInt32((EndDate - StartDate).TotalDays);

                return output;
            }




        }

    }
}
