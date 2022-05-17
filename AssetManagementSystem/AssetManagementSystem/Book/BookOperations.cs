using System;
using System.Collections.Generic;

namespace AssetManagementSystem
{
    public class BookOperations:Asset
    {      
        static List<BookAsset> bookList = new List<BookAsset>();
        public static void  BookMethod()
        {
            Console.WriteLine("1.Add Books\n2.Search For a Book\n3.Update a Book\n4.Delete a Book\n5.List of all available Books.\n6.Exit\n");
            int choice = Convert.ToInt16(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    BookOperations.AddAsset();                   
                    break;
                case 2:
                    BookOperations.SearchAnAsset();
                    break;
                case 3:
                    BookOperations.UpdateAnAsset();
                    break;
                case 4:
                    BookOperations.DeleteAnAsset();
                    break;
                case 5:
                    BookOperations.ListOfAlAvailablAssets();
                    break;
                case 6:
                    BookOperations.Exit();
                    break;

                default:
                    Console.Clear();
                    Console.WriteLine("Entered the wrong choice RE-Enter your choice");
                    BookOperations.BookMethod();
                    break;
            }
        }      
        public static void AddAsset()
        {           
            Console.WriteLine("Enter the NO Of Books You Want To Enter");
            int no = Convert.ToInt16(Console.ReadLine());
            for(int i=1 ;i<no+1 ;i++)
            {
                BookAsset Parameters = new BookAsset();
                Console.WriteLine("Enter the Details Of Book " + i);
                Console.WriteLine("Enter the SerialNumber Of The Book");
                Parameters.serialNo = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the Name Of The Book");
                Parameters.bookName = Console.ReadLine();
                Console.WriteLine("Enter the Author Of The Book");
                Parameters.authorName = Console.ReadLine();
                Console.WriteLine("Enter the Date Of Publish Of The Book");
                Parameters.dateOfPublish = Convert.ToDateTime(Console.ReadLine());
                bookList.Add(Parameters);
            }           
            BookOperations.BookMethod();
        }
        public static void SearchAnAsset()
        {
            
            if (bookList.Count != 0)
            {
                Console.WriteLine("Enter the Book Name To Searched");
                string bookName = Console.ReadLine();
                int verify = 0;
                for (int i = 0; i < bookList.Count; i++)
                {
                    
                    if (bookList[i].bookName==bookName)
                    {
                        Console.WriteLine($"serialNo\t\tName\t\tAuther\t\tdateOfPublish\n{bookList[i].serialNo}\t\t\t{bookList[i].bookName}\t\t{bookList[i].authorName}\t\t{bookList[i].dateOfPublish}");
                        verify = 1;
                    }
                }
                if(verify==1)
                {
                    Console.WriteLine("Book Searched Successfully");
                }
                else
                {
                    Console.WriteLine("Book is Not Available");
                }
            }
            else
            {
                Console.WriteLine("bookList Is Empty");
            }
            Console.WriteLine("Do you Want To Continue? (1/0)");
            BookOperations.Choice();
        }
        public static void UpdateAnAsset()
        {
            if (bookList.Count == 0)
            {
                Console.WriteLine("No Books Available Please add the Book");
                BookOperations.BookMethod();
            }
            else
            {
                Console.WriteLine("Enter Serial Number To Be Updated");
                int srNo = Convert.ToInt32(Console.ReadLine());
                int verify = 0;
                
                for (int i = 0; i < bookList.Count; i++)
                {
                    if (bookList[i].serialNo == srNo)
                    {
                        Console.WriteLine("1.Update Book Name\t2.Update Author\t3.Update Date\t4.You Have Made The Wrong Choice");
                        int choice = Convert.ToInt32(Console.ReadLine());
                        switch (choice)
                        {
                            case 1:
                                Console.WriteLine("Enter The Updated Name");
                                bookList[i].bookName = Console.ReadLine();
                                break;

                            case 2:
                                Console.WriteLine("Enter The Updated Author Name");
                                bookList[i].authorName = Console.ReadLine();
                                break;

                            case 3:
                                Console.WriteLine("Enter The Updated Date");
                                bookList[i].dateOfPublish = Convert.ToDateTime(Console.ReadLine());
                                break;
                            default:

                                Console.Clear();
                                Console.WriteLine("Entered the wrong choice");
                                BookOperations.UpdateAnAsset();
                                break;
                        }
                                             
                        verify = 1;
                    }
                }
                if (verify == 1)
                {
                    Console.WriteLine("The Book Is Updated");
                }
                else
                {
                    Console.WriteLine("You Have entered the wrong sereial no");
                }

            }
            BookOperations.ListOfAlAvailablAssets();
            Console.WriteLine("Do you Want To Continue? (1/0)");
            BookOperations.Choice();
        }
        public static void DeleteAnAsset()
        {
            if (bookList.Count == 0)
            {
                Console.WriteLine("No Books Available Please add the Book");
                BookOperations.BookMethod();
            }
            else
            {
                int cheak1 = 0;
                Console.WriteLine("Enter The Book Name To Be Deleted");
                string bookName = Console.ReadLine();
                for (int i = 0; i < bookList.Count; i++)
                {
                    if (bookList[i].bookName == bookName)
                    {
                        bookList.RemoveAt(i);
                        cheak1 = 1;
                    }
                }
                if (cheak1 == 1)
                {
                    Console.WriteLine("Book Is Deleted");
                }
                else 
                {
                    Console.WriteLine("the book is not found");
                }
            }
            
            BookOperations.ListOfAlAvailablAssets();
            Console.WriteLine("Do you Want To Continue? (1/0)");
            BookOperations.Choice();
        }
        public static void ListOfAlAvailablAssets()           
        {
            if (bookList.Count == 0) 
            {
                Console.WriteLine("No Books Available Please add the Book");
                BookOperations.BookMethod();
            }
            else
            {
                Console.WriteLine("serialNo\t\tName\t\tAuther\t\tdateOfPublish");
                foreach (BookAsset i in bookList)
                {
                    Console.WriteLine($"{i.serialNo}\t\t\t{i.bookName}\t\t{i.authorName}\t\t{i.dateOfPublish.ToString("dd/MM/yyyy")}");
                }
                BookOperations.BookMethod();
            }
        }           
        public static void Exit()
        {
            Console.Clear();
            Program.Main();
        }
    }
}
