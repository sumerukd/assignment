using System;

namespace AssetManagementSystem
{  
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("\t\t\t\t\t\tAsset Management System");
            Console.WriteLine("1.Books. \n2.Software License.\n3.Hardware.");
            Console.WriteLine("\nEnter your Choice");
            int choice = Convert.ToInt16(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    BookOperations.BookMethod();
                    break;

                case 2:
                    SoftwareOperations.SoftwareMethod();
                    break;

                case 3:
                    HardwareOperations.HardwareMethod();
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("Entered the wrong choice");
                    Program.Main();
                    break;
            }
            Console.ReadLine();
        }
    }
}
