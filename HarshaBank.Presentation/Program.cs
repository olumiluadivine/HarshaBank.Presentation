using HarshaBank.BuisnessLogicLayer;

namespace HarshaBank.Presentation
{
    class Program
    {
        static void Main()
        {
            GC.Collect();
            //display title
            Console.WriteLine("***** Harsha Bank *****");
            Console.WriteLine("::Login Page::");

            //declare variables to store username and password;
            string username = null, password = null;

            //read userName from keyboard
            Console.Write("Username: ");
            username = Console.ReadLine();

            //read password from keyboard only if username is entered
            if (username != "")
            {
                //read password from keyboard
                Console.Write("Password: ");
                password = Console.ReadLine();
            }

            //check username and password
            if (username == "system" && password == "manager")
            {
                // declare variabe to store menu choice
                int mainmenuChoice = -1;
                do
                {
                    //show main menu
                    Console.WriteLine("\n::: Main menu :::");
                    Console.WriteLine("1. Customers");
                    Console.WriteLine("2. Accounts");
                    Console.WriteLine("3. Funds Transfer");
                    Console.WriteLine("4. Funds Transfer Statement");
                    Console.WriteLine("5. Account Statement");
                    Console.WriteLine("0. Exit");

                    //accept menu choice from keyboard
                    Console.WriteLine("Enter Choice: ");
                    mainmenuChoice = int.Parse(Console.ReadLine());

                    //switch-case to check menu choice
                    switch (mainmenuChoice)
                    {
                        case 1: // TO DO: Dispaly customers menu                      
                            CustomersMenu();
                            break;
                        case 2: // TO DO: Display accounts menu
                            AccountsMenu();
                            break;
                        case 3: // TO DO: Display funds transfer menu
                            break;
                        case 4: // TO DO: Display funds transfer menu statement menu
                            break;
                        case 5: // TO DO: Display account statement menu
                            break;
                        default: // TO DO: Default
                            break;
                    }
                }
                while (mainmenuChoice != 0);
            }
            else
            {
                Console.WriteLine("Invalid username or password");
            }

            //about to exit
            Console.WriteLine("Thank you! Visit again");

            Console.ReadLine();
        }

        static void CustomersMenu()
        {
            //variable to store customers menu choice
            int customerMenuChoice = -1;

            //do-while loop starts
            do
            {
                //print customers menu
                Console.WriteLine("\n:::Customers menu:::");
                Console.WriteLine("1. Add Customer");
                Console.WriteLine("2. Delete Customer");
                Console.WriteLine("3. Update Customer");
                Console.WriteLine("4. Search Customer");
                Console.WriteLine("5. View Customer");
                Console.WriteLine("0. Back to Main Menu");

                //accepts customer menu choice
                Console.WriteLine("Enter choice: ");
                customerMenuChoice = int.Parse(Console.ReadLine());

                switch (customerMenuChoice)
                {
                    case 1:
                        CustomersPresentation.AddCustomer();
                        break;
                    case 5:
                        CustomersPresentation.ViewCustomers();
                        break;
                    case 3:

                        break;
                }
            }
            while (customerMenuChoice != 0);
        }

        static void AccountsMenu()
        {
            //variable to store accounts menu choice
            int accountMenuChoice = -1;

            //do-while loop starts
            do
            {
                //print accounts menu
                Console.WriteLine("\n:::Accounts menu:::");
                Console.WriteLine("1. Add Account");
                Console.WriteLine("2. Delete Account");
                Console.WriteLine("3. Update Account");
                Console.WriteLine("4. View Accounts");
                Console.WriteLine("0. Back to Main Menu");

                //accepts account menu choice
                Console.WriteLine("Enter choice: ");
                accountMenuChoice = int.Parse(Console.ReadLine());
            }
            while (accountMenuChoice != 0);
        }
    }
}