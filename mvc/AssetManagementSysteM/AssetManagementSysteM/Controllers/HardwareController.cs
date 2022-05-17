using AssetManagementSysteM.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace AssetManagementSysteM.Controllers
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
                foreach (HardwareAsset hardware in HardwareAsset.hardwareList)
                {
                    if (hardware.SerialNo == SerialNo)
                    {
                        HardwareAsset hardwares = new HardwareAsset();
                        hardwares.SerialNo = hardware.SerialNo;
                        hardwares.HardwareName = hardware.HardwareName;
                        hardwares.ManufacturerName = hardware.ManufacturerName;
                        hardwares.DateOfManufacture = hardware.DateOfManufacture;

                        ViewBag.hardwares = hardwares;
                        return View("Displayhardware");
                    }
                }
                return View("NoFound");
            }
            return View("SearchHardware");
        }
        [HttpPost]
        public ViewResult DeleteHardware(HardwareAsset hardware)
        {

            if (ModelState.IsValid)
            {
                foreach (HardwareAsset hardwares in HardwareAsset.hardwareList)
                {
                    if (hardwares.SerialNo == hardware.SerialNo)
                    {
                        HardwareAsset.hardwareList.Remove(hardwares);
                        return View("Index");
                    }
                }
            }
            return View();
        }
        [HttpPost]
        public ViewResult UpdateHardware(HardwareAsset hardware)
        {
            if (ModelState.IsValid)
            {
                foreach (HardwareAsset hardwares in HardwareAsset.hardwareList)
                {
                    if (hardwares.SerialNo == hardware.SerialNo)
                    {
                        HardwareAsset.hardwareList.Remove(hardwares);
                        HardwareAsset.hardwareList.Add(hardware);
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
