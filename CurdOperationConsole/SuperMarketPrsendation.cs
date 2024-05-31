using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using System.Data.SqlClient;
using CurdOperationConsole;


namespace CurdOperationConsoles
{

    public class Supermarketpresendation
    {

        string connectionstring;
        public void Marketings()
        {
            connectionstring = "Data source = DESKTOP-BLBGEHJ\\SQLEXPRESS; Initial catalog = Batch-8;user id =sa;password=Anaiyaan@123;";
            
        }
        public void SignUp(Marketing objj)
        {

            try
            {
                var insertsql = $" Insert into SuperMarketShope values('{objj.Name}','{objj.OwnerName}','{objj.NumberOfProduct}','{objj.ContactNumber}','{objj.Emailid}','{objj.Location}')";
                // var connectionstring = "Data source = DESKTOP-BLBGEHJ\\SQLEXPRESS; Initial catalog = Batch-8;user id =sa;password=Anaiyaan@123;";
                SqlConnection connection = new SqlConnection(connectionstring);
                connection.Open();
                connection.Execute(insertsql);
                connection.Close();



            }

            catch (SqlException ex)
            {
                throw;
            }
            catch (Exception)
            {
                throw;
            }

        }

        public void update(string a, string p)
        {

            try
            {





                var insertsql = $"Update SuperMarketShope set Location='{p}' where Name='{a}';";
                //var connectionstring = "Data source = DESKTOP-BLBGEHJ\\SQLEXPRESS; Initial catalog = Batch-8;user id =sa;password=Anaiyaan@123;";
                SqlConnection connection = new SqlConnection(connectionstring);
                connection.Open();
                connection.Execute(insertsql);
                connection.Close();




            }
            catch (SqlException ex)
            {
                throw;
            }
            catch (Exception)
            {
                throw;
            }

        }



        public void delete(int ShopId)
        {

            try
            {


                var deletesql = $"delete From SuperMarketShope where ShopId = '{ShopId}'";
                // var connectionstring = "Data source = DESKTOP-BLBGEHJ\\SQLEXPRESS; Initial catalog = Batch-8;user id =sa;password=Anaiyaan@123;";
                SqlConnection connection = new SqlConnection(connectionstring);
                connection.Open();
                connection.Execute(deletesql);
                connection.Close();

            }
            catch (SqlException ex)
            {
                throw;
            }
            catch (Exception)
            {
                throw;
            }



        }


        public IEnumerable<Marketing> Select()
        {
            try
            {
                var SelectsQuery = $"Select * From SuperMarketShope";
                //var connectionstring = "Data source = DESKTOP-BLBGEHJ\\SQLEXPRESS; Initial catalog = Batch-8;user id =sa;password=Anaiyaan@123;";
                SqlConnection connection = new SqlConnection(connectionstring);
                connection.Open();
                var result = connection.Query<Marketing>(SelectsQuery);
                connection.Close();
                return result;
            }
            catch (SqlException ex)
            {
                throw;
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}  
