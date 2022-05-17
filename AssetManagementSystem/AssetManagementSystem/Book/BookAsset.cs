using System;

namespace AssetManagementSystem 
{
    public class BookAsset : Asset
    {        
        private string bookNamePrivate;
        private string authorNamePrivate;
        private DateTime dateOfPublishPrivate;
        public string bookName
        {
            set
            {
                bookNamePrivate = value;
            }
            get
            {
                return bookNamePrivate;
            }

        }
        public string authorName
        {
            set
            {
                authorNamePrivate = value;

            }
            get
            {
                return authorNamePrivate;
            }
        }
        public DateTime dateOfPublish
        {
            set
            {
                dateOfPublishPrivate = value;
            }
            get
            {
                return dateOfPublishPrivate;
            }
        }
    }    
    
}