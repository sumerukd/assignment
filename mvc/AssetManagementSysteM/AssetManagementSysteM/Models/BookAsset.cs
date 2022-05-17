using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace AssetManagementSysteM.Models
{
    public class BookAsset
    {
        public static List<BookAsset> bookList = new List<BookAsset>();
        [Required(ErrorMessage = "Serial No is required")]
        [Range(1, 1000, ErrorMessage = "Enter number greater than 0")]
        public int SerialNo { get; set; }

        [Required(ErrorMessage = "Book Name is required")]
        public string BookName { get; set; }

        [Required(ErrorMessage = "AuthorName is required")]
        public string AuthorName { get; set; }

        [Required(ErrorMessage = "Date OF Publish name is required")]
        public DateTime DateOfPublish { get; set; }     
    }
}
