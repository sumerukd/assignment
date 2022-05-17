using System;
using System.Collections.Generic;

namespace AssetManagementSystem
{
    public class SoftwareOperations:Asset
    {
        static List<SoftwareLicenseAsset> softwareList = new List<SoftwareLicenseAsset>();
        public static void SoftwareMethod()
        {
            Console.WriteLine("1.Add SoftwareLicense\n2.Search For SoftwareLicense\n3.Update SoftwareLicense\n4.Delete SoftwareLicense\n5.List of all available SoftwareLicense.\n6.Exit\n");
            int choice = Convert.ToInt16(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    SoftwareOperations.AddAsset();
                    break;
                case 2:
                    SoftwareOperations.SearchAnAsset();
                    break;
                case 3:
                    SoftwareOperations.UpdateAnAsset();
                    break;
                case 4:
                    SoftwareOperations.DeleteAnAsset();
                    break;
                case 5:
                    SoftwareOperations.ListOfAlAvailablAssets();
                    break;
                case 6:
                    SoftwareOperations.Exit();
                    break;

                default:
                    Console.Clear();
                    Console.WriteLine("Entered the wrong choice RE-Enter your choice");
                    SoftwareOperations.SoftwareMethod();
                    break;
            }
        }
        public static void AddAsset()
        {
            Console.WriteLine("Enter the NO Of SoftwareLicense You Want To Enter");
            int no = Convert.ToInt16(Console.ReadLine());
            for (int i = 1; i < no + 1; i++)
            {
                SoftwareLicenseAsset Parameters = new SoftwareLicenseAsset();
                Console.WriteLine("Enter the Details Of The SoftwareLicense "+i);
                Console.WriteLine("Enter the SerialNumber Of The SoftwareLicense");
                Parameters.serialNo = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the Name Of The SoftwareLicense");
                Parameters.softwareLicenseName = Console.ReadLine();
                Console.WriteLine("Enter the Publisher Of The SoftwareLicense");
                Parameters.publisherName = Console.ReadLine();
                Console.WriteLine("Enter the Date Of Publish Of The SoftwareLicense");
                Parameters.dateOfPublish = Convert.ToDateTime(Console.ReadLine());
                softwareList.Add(Parameters);
            }
            SoftwareOperations.SoftwareMethod();
        }
        public static void SearchAnAsset()
        {

            if (softwareList.Count != 0)
            {
                Console.WriteLine("Enter the SoftwareLicense Name To be Searched");
                string softwareLicenseName = Console.ReadLine();
                int verify = 0;
                for (int i = 0; i < softwareList.Count; i++)
                {

                    if (softwareList[i].softwareLicenseName == softwareLicenseName)
                    {
                        Console.WriteLine($"serialNo\t\tsoftwareLicenseName\t\tpublisherName\t\tdateOfPublish\n{softwareList[i].serialNo}\t\t\t{softwareList[i].softwareLicenseName}\t\t{softwareList[i].publisherName}\t\t{softwareList[i].dateOfPublish}");
                        verify = 1;
                    }
                }
                if (verify == 1)
                {
                    Console.WriteLine("SoftwareLicense Searched Successfully");
                }
                else
                {
                    Console.WriteLine("SoftwareLicense is not Available");
                }
            }
            else
            {
                Console.WriteLine("softwareList Is Empty");
            }
            Console.WriteLine("Do you Want To Continue? (1/0)");
            SoftwareOperations.Choice();
        }
        public static void UpdateAnAsset()
        {
            if (softwareList.Count == 0)
            {
                Console.WriteLine("No Software is available Please add the Software");
                SoftwareOperations.SoftwareMethod();
            }
            else
            {
                Console.WriteLine("Enter Serial Number To Be Updated");
                int srNo = Convert.ToInt32(Console.ReadLine());
                int verify = 0;
                for (int i = 0; i < softwareList.Count; i++)
                {
                    if (softwareList[i].serialNo == srNo)
                    {
                        Console.WriteLine("1.Update SoftwareLicense Name\t2.Update Publisher Name\t3.Update Date of Publish\t4.You Have Made The Wrong Choice");
                        int choice = Convert.ToInt16(Console.ReadLine());
                        switch (choice)
                        {
                            case 1:
                                Console.WriteLine("Enter The Updated SoftwareLicense Name");
                                softwareList[i].softwareLicenseName = Console.ReadLine();
                                break;

                            case 2:
                                Console.WriteLine("Enter The Updated Publisher Name");
                                softwareList[i].publisherName = Console.ReadLine();
                                break;

                            case 3:
                                Console.WriteLine("Enter The Updated Date of Publish");
                                softwareList[i].dateOfPublish = Convert.ToDateTime(Console.ReadLine());
                                break;
                            default:

                                Console.Clear();
                                Console.WriteLine("Entered the wrong choice");
                                SoftwareOperations.UpdateAnAsset();
                                break;
                        }

                        verify = 1;
                    }
                }
                if (verify == 1)
                {
                    Console.WriteLine("The SoftwareLicense Is Updated");
                }
                else
                {
                    Console.WriteLine("You Have entered the wrong sereial no");
                }
            }
            SoftwareOperations.ListOfAlAvailablAssets();
            Console.WriteLine("Do you Want To Continue? (1/0)");
            SoftwareOperations.Choice();
        }
        public static void DeleteAnAsset()
        {
            if (softwareList.Count == 0)
            {
                Console.WriteLine("No Software is available Please add the Software");
                SoftwareOperations.SoftwareMethod();
            }
            else
            {
                int cheak1 = 0;
                Console.WriteLine("Enter The softwareLicenseName To Be Deleted");
                string softwareLicenseName = Console.ReadLine();
                for (int i = 0; i < softwareList.Count; i++)
                {
                    if (softwareList[i].softwareLicenseName == softwareLicenseName)
                    {
                        softwareList.RemoveAt(i);
                        cheak1 = 1;
                    }
                }
                if (cheak1 == 1)
                {
                    Console.WriteLine("softwareLicense Is Deleted");
                }
                else 
                {
                    Console.WriteLine("the softwareLicenseName is not found");
                }
            }

            SoftwareOperations.ListOfAlAvailablAssets();
            Console.WriteLine("Do you Want To Continue? (1/0)");
            SoftwareOperations.Choice();
        }
        public static void ListOfAlAvailablAssets()
        {
            if (softwareList.Count == 0)
            {
                Console.WriteLine("No Software is available Please add the Software");
                SoftwareOperations.SoftwareMethod();
            }
            else
            {
                Console.WriteLine("serialNo\t\tsoftwareLicenseName\t\tPublisher\t\tdateOfPublish");
                foreach (SoftwareLicenseAsset i in softwareList)
                {
                    Console.WriteLine($"{i.serialNo}\t\t\t{i.softwareLicenseName}\t\t{i.publisherName}\t\t{i.dateOfPublish.ToString("dd/MM/yyyy")}");
                }
                SoftwareOperations.SoftwareMethod();
            }
        }
        public static void Exit()
        {
            Console.Clear();
            Program.Main();
        }
    }
}
