using System;

namespace AssetManagementSystem
{
    public class HardwareAsset : Asset
    {
        private string hardwareNamePrivate;
        private string manufacturerNamePrivate;
        private DateTime dateOfManufacturePrivate;
        public string hardwareName
        {
            set
            {
                hardwareNamePrivate = value;
            }
            get
            {
                return hardwareNamePrivate;
            }

        }
        public string manufacturerName
        {
            set
            {
                manufacturerNamePrivate = value;

            }
            get
            {
                return manufacturerNamePrivate;
            }
        }
        public DateTime dateOfManufacture
        {
            set
            {
                dateOfManufacturePrivate = value;
            }
            get
            {
                return dateOfManufacturePrivate;
            }
        }
    }
}