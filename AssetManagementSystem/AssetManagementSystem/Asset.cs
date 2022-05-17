using System;

namespace AssetManagementSystem
{
    public class Asset
    {
        public int serialNo;
        public static void Choice()
        {
            int choice = Convert.ToInt32(Console.ReadLine());
            if (choice == 1)
            {
                HardwareOperations.HardwareMethod();
            }
            else
            {
                Program.Main();
            }
        }

    }

}
