using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AssetManagementSysteM.Models
{
    public class HardwareAsset
    {
        public static List<HardwareAsset> hardwareList = new List<HardwareAsset>();
        [Required(ErrorMessage = "Serial No is required")]
        [Range(1, 1000, ErrorMessage = "Enter number greater than 0")]
        public int SerialNo { get; set; }

        [Required(ErrorMessage = "Hardware Name is required")]
        public string HardwareName { get; set; }

        [Required(ErrorMessage = "ManufacturerName is required")]
        public string ManufacturerName { get; set; }

        [Required(ErrorMessage = "Date OF Manufacture is required")]
        public DateTime DateOfManufacture { get; set; }
    }
}
