using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Management;

namespace RegistryProgram
{
    class Processor
    {
        private IWshRuntimeLibrary.WshShell WSH = new IWshRuntimeLibrary.WshShell();

        public string getPass()
        {
            return WSH.RegRead(Constants.PATH_TO_PASS);
        }

        public void showTemp()
        {
            WSH.Run(Constants.DD);
        }
        
        public void register()
        {
            ManagementObjectSearcher objectSerarcher = new ManagementObjectSearcher(Constants.ROOT_CIMV2,
                            Constants.BASEBOARD_QUERY);
            foreach (ManagementObject o in objectSerarcher.Get())
            {
                WSH.RegWrite(Constants.PATH_TO_PASS, Convert.ToString(o[Constants.SERIAL_NUMBER]));
            }
        }

        public void getSerial()
        {
            WSH.Run(Constants.HDD);
        }

        public void getInfo()
        {
            WSH.Run(Constants.YD);
        }
    }
}
