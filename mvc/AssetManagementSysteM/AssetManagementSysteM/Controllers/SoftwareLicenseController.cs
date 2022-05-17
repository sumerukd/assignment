using AssetManagementSysteM.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace AssetManagementSysteM.Controllers
{
    public class SoftwareLicenseController : Controller
    {
        [HttpGet]
        public ViewResult AddSoftwareLicense()
        {
            return View();
        }
        public ViewResult SearchSoftwareLicense()
        {
            return View();
        }
        [HttpGet]
        public ViewResult DeleteSoftwareLicense(int SerialNo)
        {
            SoftwareLicenseAsset software = SoftwareLicenseAsset.softwareList.Where(x => x.SerialNo == SerialNo).FirstOrDefault();
            return View(software);
        }
        public ViewResult UpdateSoftwareLicense(int SerialNo)
        {
            SoftwareLicenseAsset software = SoftwareLicenseAsset.softwareList.Where(x => x.SerialNo == SerialNo).FirstOrDefault();
            return View(software);
        }

        [HttpPost]
        public ViewResult AddSoftwareLicense(SoftwareLicenseAsset software)
        {
            if (ModelState.IsValid)
            {
                SoftwareLicenseAsset.softwareList.Add(software);
            }
            else
            {
                return View();
            }

            return View("Index");
        }
        [HttpPost]
        public ViewResult SearchSoftwareLicense(int SerialNo)
        {

            if (ModelState.IsValid)
            {
                foreach (SoftwareLicenseAsset software in SoftwareLicenseAsset.softwareList)
                {
                    if (software.SerialNo == SerialNo)
                    {
                        SoftwareLicenseAsset softwares = new SoftwareLicenseAsset();
                        softwares.SerialNo = software.SerialNo;
                        softwares.SoftwareLicenseName = software.SoftwareLicenseName;
                        softwares.PublisherName = software.PublisherName;
                        softwares.DateOfPublish = software.DateOfPublish;

                        ViewBag.softwares = softwares;
                        return View("DisplaySoftware");
                    }
                }
                return View("NoFound");
            }
            return View("SearchSoftwareLicense");
        }
        [HttpPost]
        public ViewResult DeleteSoftwareLicense(SoftwareLicenseAsset software)
        {

            if (ModelState.IsValid)
            {
                foreach (SoftwareLicenseAsset softwares in SoftwareLicenseAsset.softwareList)
                {
                    if (softwares.SerialNo == software.SerialNo)
                    {
                        SoftwareLicenseAsset.softwareList.Remove(softwares);
                        return View("Index");
                    }
                }
            }
            return View();
        }
        [HttpPost]
        public ViewResult UpdateSoftwareLicense(SoftwareLicenseAsset software)
        {
            if (ModelState.IsValid)
            {
                foreach (SoftwareLicenseAsset softwares in SoftwareLicenseAsset.softwareList)
                {
                    if (softwares.SerialNo == software.SerialNo)
                    {
                        SoftwareLicenseAsset.softwareList.Remove(softwares);
                        SoftwareLicenseAsset.softwareList.Add(software);
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
