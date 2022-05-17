using AssetManagementSysteM.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;


namespace AssetManagementSysteM.Controllers
{
    public class BookController : Controller
    {
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
            BookAsset book = BookAsset.bookList.Where(x => x.SerialNo == SerialNo).FirstOrDefault();
            return View(book);
        }
        public ViewResult UpdateBook(int SerialNo)
        {
            BookAsset book = BookAsset.bookList.Where(x => x.SerialNo == SerialNo).FirstOrDefault();
            return View(book);
        }

        [HttpPost]
        public ViewResult AddBook(BookAsset book)
        {
            if (ModelState.IsValid)
            {
                BookAsset.bookList.Add(book);
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
                foreach (BookAsset book in BookAsset.bookList)
                {
                    if (book.SerialNo == SerialNo)
                    {
                        BookAsset books = new BookAsset();
                        books.SerialNo = book.SerialNo;
                        books.BookName = book.BookName;
                        books.AuthorName = book.AuthorName;
                        books.DateOfPublish = book.DateOfPublish;

                        ViewBag.books = books;
                        return View("DisplayBook");
                    }                    
                }return View("NoFound");
            }
            return View("SearchBook");
        }
        [HttpPost]
        public ViewResult DeleteBook(BookAsset book)
        {

            if (ModelState.IsValid)
            {
                foreach (BookAsset books in BookAsset.bookList)
                {
                    if (books.SerialNo == book.SerialNo)
                    {
                        BookAsset.bookList.Remove(books);
                        return View("Index");
                    }
                }
            }
            return View();
        }
        [HttpPost]
        public ViewResult UpdateBook(BookAsset book)
        {
            if(ModelState.IsValid)
            {
                foreach (BookAsset books in BookAsset.bookList) 
                {
                    if(books.SerialNo ==book.SerialNo)
                    {
                        BookAsset.bookList.Remove(books);
                        BookAsset.bookList.Add(book);
                        return View("Index");
                    }
                }              
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
