using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Management;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Messaging;
using System.Windows.Media.Imaging;

namespace Tech_Quick.InfoClasses.Hardware_Category
{
    internal class HardwareBuilder
    {
        private BitmapImage defaultImage = new BitmapImage(new Uri("/Images/CogPlaceHolder.png", UriKind.Relative));


        public HardwareBuilder() 
        {

        }

        public InfoCPU createInfoCPU(ManagementObject managementObject)
        {
            String header = "";
            String primaryInfo = "";
            try
            {
                header += managementObject["Name"];
                primaryInfo += managementObject["NumberOfCores"] + " Cores, ";
                primaryInfo += managementObject["ThreadCount"] + " Threads";

            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e.Message);
            }
            return new InfoCPU(header, primaryInfo, this.defaultImage);
        }

        
    }
}

