using AssetManagementSystem.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;


namespace AssetManagementSystem.Controllers
{
    public class BookController : Controller
    {
        public static List<BookAsset> bookList = new List<BookAsset>();
        [HttpGet]
        public ViewResult AddBook()
        {
           
            return View();
        }
        public ViewResult SearchBook()
        {
            return View();
        }
        [HttpGet]
        public ViewResult DeleteBook(int SerialNo)
        {
            BookAsset book = bookList.Where(x => x.SerialNo == SerialNo).FirstOrDefault();
            return View(book);
        }
        public ViewResult UpdateBook(int SerialNo)
        {
            BookAsset book = bookList.Where(x => x.SerialNo == SerialNo).FirstOrDefault();
            return View(book);
        }

        [HttpPost]
        public ViewResult AddBook(BookAsset book)
        {
            if (ModelState.IsValid)
            {
                bookList.Add(book);
            }
            else
            {
                return View();
            }
            
            return View("Index");
        }
        [HttpPost]
        public ViewResult SearchBook(int SerialNo)
        {

            if (ModelState.IsValid)
            {
                if (bookList.Count == 0)
                {
                    return View("EmptyList");
                }
                else
                {
                    BookAsset book =bookList.Where(x => x.SerialNo == SerialNo).FirstOrDefault();
                    if(book==null)
                    {
                        return View("NoFound");
                    }
                    else
                    {
                        BookAsset bookAsset = new BookAsset();
                        bookAsset.SerialNo = book.SerialNo;
                        bookAsset.BookName = book.BookName;
                        bookAsset.AuthorName = book.AuthorName;
                        bookAsset.DateOfPublish = book.DateOfPublish;
                        

                        ViewBag.bookAsset = bookAsset;
                        return View("DisplayBook");
                       
                    }                    
                }
            }
            return View();
        }
        [HttpPost]
        public ViewResult DeleteBook(BookAsset book)
        {

            if (ModelState.IsValid)
            {
                BookAsset bookAsset = bookList.Where(x => x.SerialNo ==book.SerialNo).FirstOrDefault();
                bookList.Remove(bookAsset);
                return View("Index");
                
            }
            return View();
        }
        [HttpPost]
        public ViewResult UpdateBook(BookAsset book)
        {
            if(ModelState.IsValid)
            {
                BookAsset bookAsset = bookList.Where(x => x.SerialNo == book.SerialNo).FirstOrDefault();
                bookAsset.BookName = book.BookName;
                bookAsset.AuthorName = book.AuthorName;
                bookAsset.DateOfPublish = book.DateOfPublish;
                return View("Index");                       
            }
            return View();
            
        }
        public ViewResult Index()
        {           
            return View();
        }

        public ViewResult NoFound()
        {
            return View();
        }

        public ViewResult EmptyList()
        {
            return View();
        }
    }
}