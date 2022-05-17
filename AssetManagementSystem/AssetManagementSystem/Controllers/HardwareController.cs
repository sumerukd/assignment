using AssetManagementSystem.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace AssetManagementSystem.Controllers
{
    public class HardwareController : Controller
    {
        [HttpGet]
        public ViewResult AddHardware()
        {
            return View();
        }
        public ViewResult SearchHardware()
        {
            return View();
        }
        [HttpGet]
        public ViewResult DeleteHardware(int SerialNo)
        {
            HardwareAsset hardware = HardwareAsset.hardwareList.Where(x => x.SerialNo == SerialNo).FirstOrDefault();
            return View(hardware);
        }
        public ViewResult Updatehardware(int SerialNo)
        {
            HardwareAsset hardware = HardwareAsset.hardwareList.Where(x => x.SerialNo == SerialNo).FirstOrDefault();
            return View(hardware);
        }

        [HttpPost]
        public ViewResult AddHardware(HardwareAsset hardware)
        {
            if (ModelState.IsValid)
            {
                HardwareAsset.hardwareList.Add(hardware);
            }
            else
            {
                return View();
            }

            return View("Index");
        }
        [HttpPost]
        public ViewResult SearchHardware(int SerialNo)
        {
            if (ModelState.IsValid)
            {
                if (HardwareAsset.hardwareList.Count == 0)
                {
                    return View("EmptyList");
                }
                else
                {
                    HardwareAsset hardware = HardwareAsset.hardwareList.Where(x => x.SerialNo == SerialNo).FirstOrDefault();
                    if (hardware == null)
                    {
                        return View("NoFound");
                    }
                    else
                    {
                        HardwareAsset hardwareAsset = new HardwareAsset();
                        hardwareAsset.SerialNo = hardware.SerialNo;
                        hardwareAsset.HardwareName = hardware.HardwareName;
                        hardwareAsset.ManufacturerName = hardware.ManufacturerName;
                        hardwareAsset.DateOfManufacture = hardware.DateOfManufacture;

                        ViewBag.hardwareAsset = hardwareAsset;
                        return View("Displayhardware");
                    }
                }
            }
            return View();
        }

        [HttpPost]
        public ViewResult DeleteHardware(HardwareAsset hardware)
        {

            if (ModelState.IsValid)
            {
                HardwareAsset hardwareAsset = HardwareAsset.hardwareList.Where(x => x.SerialNo == hardware.SerialNo).FirstOrDefault();
                HardwareAsset.hardwareList.Remove(hardwareAsset);
                return View("Index");
            }
            return View();
        }
        [HttpPost]
        public ViewResult UpdateHardware(HardwareAsset hardware)
        {
            if (ModelState.IsValid)
            {
                HardwareAsset hardwareAsset = HardwareAsset.hardwareList.Where(x => x.SerialNo == hardware.SerialNo).FirstOrDefault();
                hardwareAsset.HardwareName = hardware.HardwareName;
                hardwareAsset.ManufacturerName = hardware.ManufacturerName;
                hardwareAsset.DateOfManufacture = hardwareAsset.DateOfManufacture;
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
