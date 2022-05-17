using System;
using System.Collections.Generic;

namespace AssetManagementSystem
{
    public class HardwareOperations:Asset
    {
        static List<HardwareAsset> hardwareList = new List<HardwareAsset>();
        public static void HardwareMethod()
        {

            Console.WriteLine("1.Add a Hardware\n2.Search For a Hardware\n3.Update Hardware\n4.Delete a Hardware\n5.List of all available Hardwares.\n6.Exit\n");
            int choice = Convert.ToInt16(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    HardwareOperations.AddAsset();

                    break;
                case 2:
                    HardwareOperations.SearchAnAsset();
                    break;
                case 3:
                    HardwareOperations.UpdateAnAsset();
                    break;
                case 4:
                    HardwareOperations.DeleteAnAsset();
                    break;
                case 5:
                    HardwareOperations.ListOfAlAvailablAssets();
                    break;
                case 6:
                    HardwareOperations.Exit();
                    break;

                default:
                    Console.Clear();
                    Console.WriteLine("Entered the wrong choice RE-Enter your choice");
                    HardwareOperations.HardwareMethod();
                    break;

            }
        }
        public static void AddAsset()
        {
            Console.WriteLine("Enter the NO Of HardWare You Want To Enter");
            int no = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i < no + 1; i++)
            {
                HardwareAsset Parameters = new HardwareAsset();
                Console.WriteLine("Enter the Details Of Hardware " + i);
                Console.WriteLine("Enter the SerialNumber Of The Hardware");
                Parameters.serialNo = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the Name Of The Hardware");
                Parameters.hardwareName = Console.ReadLine();
                Console.WriteLine("Enter the name of Manufacturer Of The Hardware");
                Parameters.manufacturerName = Console.ReadLine();
                Console.WriteLine("Enter the Date Of Manufacture Of The Hardware");
                Parameters.dateOfManufacture = Convert.ToDateTime(Console.ReadLine());
                hardwareList.Add(Parameters);
            }
            HardwareOperations.HardwareMethod();

        }
        public static void SearchAnAsset()
        {

            if (hardwareList.Count != 0)
            {
                Console.WriteLine("Enter the Hardware Name To Searched");
                string hardwareName = Console.ReadLine();
                int verify = 0;
                for (int i = 0; i < hardwareList.Count; i++)
                {

                    if (hardwareList[i].hardwareName == hardwareName)
                    {
                        Console.WriteLine($"serialNo\t\thardwareName\t\tmanufacturerName\t\tdateOfManufacture\n{hardwareList[i].serialNo}\t\t\t{hardwareList[i].hardwareName}\t\t{hardwareList[i].manufacturerName}\t\t{hardwareList[i].dateOfManufacture}");
                        verify = 1;
                    }            
                }
                if(verify==1)
                {
                    Console.WriteLine("Hardware Searched Successfully");
                }
                else
                {
                    Console.WriteLine("Hardware is not Available");
                }
            }
            else
            {
                Console.WriteLine("hardwareList Is Empty");
            }
            Console.WriteLine("Do you Want To Continue? (1/0)");
            HardwareOperations.Choice();
        }
        public static void UpdateAnAsset()
        {
            if (hardwareList.Count == 0)
            {
                Console.WriteLine("No Hardware is Available Please Add the HardWare");
                HardwareOperations.HardwareMethod();
            }
            else
            {
                Console.WriteLine("Enter Serial Number To Be Updated");
                int srNo = Convert.ToInt32(Console.ReadLine());
                int verify = 0;

                for (int i = 0; i < hardwareList.Count; i++)
                {
                    if (hardwareList[i].serialNo == srNo)
                    {
                        Console.WriteLine("1.Update Hardware Name\t2.Update Manufacturer Name\t3.Update Date of Manufacture\t4.You Have Made The Wrong Choice");
                        int choice = Convert.ToInt16(Console.ReadLine());
                        switch (choice)
                        {
                            case 1:
                                Console.WriteLine("Enter The Updated Hardware Name");
                                hardwareList[i].hardwareName = Console.ReadLine();
                                break;

                            case 2:
                                Console.WriteLine("Enter The Updated Author Name");
                                hardwareList[i].manufacturerName = Console.ReadLine();
                                break;

                            case 3:
                                Console.WriteLine("Enter The Updated Date of Manufacture");
                                hardwareList[i].dateOfManufacture = Convert.ToDateTime(Console.ReadLine());
                                break;
                            default:

                                Console.Clear();
                                Console.WriteLine("Entered the wrong choice");
                                HardwareOperations.UpdateAnAsset();
                                break;
                        }

                        verify = 1;
                    }
                }
                if (verify == 1)
                {
                    Console.WriteLine("The Hardware Is Updated");
                }
                else
                {
                    Console.WriteLine("You Have entered the wrong sereial no");
                }
            }
            HardwareOperations.ListOfAlAvailablAssets();
            Console.WriteLine("Do you Want To Continue? (1/0)");
            HardwareOperations.Choice();
        }
        public static void DeleteAnAsset()
        {
            if (hardwareList.Count == 0)
            {
                Console.WriteLine("No Hardware is Available Please Add The Hardware");
                HardwareOperations.HardwareMethod();
            }
            else
            {
                int cheak1 = 0;
                Console.WriteLine("Enter The Hardware Name To Be Deleted");
                string hardwareName = Console.ReadLine();
                for (int i = 0; i < hardwareList.Count; i++)
                {
                    if (hardwareList[i].hardwareName == hardwareName)
                    {
                        hardwareList.RemoveAt(i);
                        cheak1 = 1;
                    }
                }
                if (cheak1 == 1)
                {
                    Console.WriteLine("Hardware Is Deleted");
                }
                else 
                {
                    Console.WriteLine("the Hardware is not found");
                }

            }
            HardwareOperations.ListOfAlAvailablAssets();
            Console.WriteLine("Do you Want To Continue? (1/0)");
            HardwareOperations.Choice();
        }
        public static void ListOfAlAvailablAssets()

        {
            if (hardwareList.Count == 0)
            {
                Console.WriteLine("No Hardware is Available Please Add The Hardware");
                HardwareOperations.HardwareMethod();
            }
            else
            {
                Console.WriteLine("serialNo\t\thardwareName\t\tmanufacturerName\t\tdateOfManufacture");
                foreach (HardwareAsset i in hardwareList)
                {
                    Console.WriteLine($"{i.serialNo}\t\t\t{i.hardwareName}\t\t\t{i.manufacturerName}\t\t\t{i.dateOfManufacture.ToString("dd/MM/yyyy")}");
                }
                HardwareOperations.HardwareMethod();

            }
        }
        public static void Exit()
        {
            Console.Clear();
            Program.Main();
        }
    }
}
