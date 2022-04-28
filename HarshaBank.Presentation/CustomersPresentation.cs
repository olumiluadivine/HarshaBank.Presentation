using HarshaBank.Entities;
using HarshaBank.Exceptions;
using HarshaBank.BuisnessLogicLayer.BALContracts;
using HarshaBank.BuisnessLogicLayer;

namespace HarshaBank.Presentation
{
    static class CustomersPresentation
    {
        internal static void AddCustomer()
        {
            try
            {
                //create an object of Customer
                Customer customer = new Customer();

                //read all details from user
                Console.WriteLine("\n*******ADD CUSTOMER********");
                Console.Write("Name: ");
                customer.CustomerName = Console.ReadLine();
                Console.Write("Address: ");
                customer.Address = Console.ReadLine();
                Console.Write("Landmark: ");
                customer.Landmark = Console.ReadLine();
                Console.Write("City: ");
                customer.City = Console.ReadLine();
                Console.Write("Country: ");
                customer.Country = Console.ReadLine();
                Console.Write("Mobile: ");
                customer.Mobile = Console.ReadLine();

                //create BIL object
                ICustomersBuisnessLogicLayer customersBuisnessLogicLayer = new CustomersBuisnessLogicLayer();
                Guid newGuid = customersBuisnessLogicLayer.AddCustomer(customer);

                List<Customer> matchingCustomers = customersBuisnessLogicLayer.GetCustomersByCondition
                    (item => item.CustomerID == newGuid);
                if (matchingCustomers.Count >= 1)
                {
                    Console.WriteLine("New Customer Code: "+matchingCustomers[0].CustomerCode);
                    Console.WriteLine("Customer Added.\n");
                }
                else
                {
                    Console.WriteLine("Customer not added");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                Console.WriteLine(ex.GetType());
            }
        }


        internal static void ViewCustomers()
        {
            try
            {
                //create BL object
                ICustomersBuisnessLogicLayer customersBuisnessLogicLayer = new CustomersBuisnessLogicLayer();

                List<Customer> allCustomers = customersBuisnessLogicLayer.GetCustomers();
                Console.WriteLine("\n*********ALL CUSTOMERS***********");
                //read all customers
                foreach (var item in allCustomers)
                {
                    Console.WriteLine("Customer Code " + item.CustomerCode);
                    Console.WriteLine("Customer Name " + item.CustomerName);
                    Console.WriteLine("Customer Address" + item.Address);
                    Console.WriteLine("Customer Landmark" + item.Landmark);
                    Console.WriteLine("Customer City" + item.City);
                    Console.WriteLine("Customer Country" + item.Country);
                    Console.WriteLine("Customer Mobile" + item.Mobile);
                    Console.WriteLine();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
