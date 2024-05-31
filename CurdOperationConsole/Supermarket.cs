using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CurdOperationConsole;
using CurdOperationConsoles;

namespace CurdOperationConsoles
{
    public class Supermarket
    {
        Supermarketpresendation obj = new Supermarketpresendation();
        

        public void SingupData()
        {
            try
            {
                Marketings objj = new Marketings();
                Console.WriteLine("Enter the ShopId");
                objj.ShopId = Console.ReadLine();
                Console.WriteLine("Enter the Name");

                objj.Name = Console.ReadLine();
                Console.WriteLine("Enter the OwnerName");
                objj.OwnerName = Console.ReadLine();
                Console.WriteLine("Enter the NumberOfProdouct");
                objj.NumberOfProduct = Console.ReadLine();

                Console.WriteLine("Enter the ContactNumber");
                objj.ContactNumber = Console.ReadLine();
                Console.WriteLine("Enter the Emailid");
                objj.Emailid = Console.ReadLine();
                Console.WriteLine("Enter the Location");
                objj.Location = Console.ReadLine();


                obj.SignUp(objj);


            }
            catch (Exception ex)
            {
                throw;

            }
        }
    }
}













