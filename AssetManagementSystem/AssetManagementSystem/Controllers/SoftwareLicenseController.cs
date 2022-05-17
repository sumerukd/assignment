using AssetManagementSystem.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace AssetManagementSystem.Controllers
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
                if (SoftwareLicenseAsset.softwareList.Count == 0)
                {
                    return View("EmptyList");
                }
                else
                {
                    SoftwareLicenseAsset software = SoftwareLicenseAsset.softwareList.Where(x => x.SerialNo == SerialNo).FirstOrDefault();
                    if (software == null)
                    {
                        return View("NoFound");
                    }
                    else
                    {
                        SoftwareLicenseAsset softwareAsset = new SoftwareLicenseAsset();
                        softwareAsset.SerialNo = software.SerialNo;
                        softwareAsset.SoftwareLicenseName = software.SoftwareLicenseName;
                        softwareAsset.PublisherName = software.PublisherName;
                        softwareAsset.DateOfPublish = software.DateOfPublish;
                        ViewBag.softwareAsset = softwareAsset;
                        return View("DisplaySoftware");

                    }

                }
            }
            return View();
        }
        [HttpPost]
        public ViewResult DeleteSoftwareLicense(SoftwareLicenseAsset software)
        {

            if (ModelState.IsValid)
            {
                SoftwareLicenseAsset softwareAsset = SoftwareLicenseAsset.softwareList.Where(x => x.SerialNo == software.SerialNo).FirstOrDefault();
                SoftwareLicenseAsset.softwareList.Remove(softwareAsset);
                return View("Index");
            }
            return View();
        }
        [HttpPost]
        public ViewResult UpdateSoftwareLicense(SoftwareLicenseAsset software)
        {
            if (ModelState.IsValid)
            {
                SoftwareLicenseAsset softwareAsset = SoftwareLicenseAsset.softwareList.Where(x => x.SerialNo == software.SerialNo).FirstOrDefault();
                softwareAsset.SoftwareLicenseName = software.SoftwareLicenseName;
                softwareAsset.PublisherName = software.PublisherName;
                softwareAsset.DateOfPublish = software.DateOfPublish;
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
