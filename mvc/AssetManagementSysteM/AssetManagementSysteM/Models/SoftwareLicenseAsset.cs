using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace AssetManagementSysteM.Models
{
    public class SoftwareLicenseAsset
    {
        public static List<SoftwareLicenseAsset> softwareList = new List<SoftwareLicenseAsset>();
        [Required(ErrorMessage = "Serial No is required")]
        [Range(1, 1000, ErrorMessage = "Enter number greater than 0")]
        public int SerialNo { get; set; }

        [Required(ErrorMessage = "SoftwareLicenseName Name is required")]
        public string SoftwareLicenseName { get; set; }

        [Required(ErrorMessage = "PublisherName is required")]
        public string PublisherName { get; set; }

        [Required(ErrorMessage = "Date OF Publish name is required")]
        public DateTime DateOfPublish { get; set; }
    }
}
