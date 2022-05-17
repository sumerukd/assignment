using System;

namespace AssetManagementSystem
{
    public class SoftwareLicenseAsset : Asset
    {
        private string softwareLicenseNamePrivate;
        private string publisherNamePrivate;
        private DateTime dateOfPublishPrivate;
        public string softwareLicenseName
        {
            set
            {
                softwareLicenseNamePrivate = value;
            }
            get
            {
                return softwareLicenseNamePrivate;
            }

        }
        public string publisherName
        {
            set
            {
                publisherNamePrivate = value;

            }
            get
            {
                return publisherNamePrivate;
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