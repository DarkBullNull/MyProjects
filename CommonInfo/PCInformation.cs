using System;
using System.Management;

namespace CommonInfo
{
    class PCInformation
    {
        public PCInformation()
        {
            WorkWithOperatingSystem();
            WorkWithProcessor();
        }
        public string totalRAMGlobal { get; private set; }
        public string useRAMGlobal { get; private set; }
        public string totalVirtualMemoryGlobal { get; private set; }
        public string selectedVirtualMemoryGlobal { get; private set; }
        public string percentUseRAMGlobal { get; private set; }
        public string percentUseVirtualMemoryGlobal { get; private set; }
        public string OSArchitectureGlobal { get; private set; }
        public string versionGlobal { get; private set; }
        public string captionGlobal { get; private set; }
        public string processorNameGlobal { get; private set; }
        public string numberOfCoresGlobal { get; private set; }
        public string serialNumberGlobal { get; private set; }
        public string nameUserGlobal { get; private set; }
        public string nameComputerGlobal { get; private set; }

        private void WorkWithOperatingSystem()
        {
            ManagementObjectSearcher Win32_OperatingSystem = //запрос к WMI для получения коллекций (Win32_OperatingSystem)
                new ManagementObjectSearcher("SELECT TotalVisibleMemorySize,FreePhysicalMemory, OSArchitecture, " +
                "Version, Caption, TotalVirtualMemorySize, FreeVirtualMemory, CSName, RegisteredUser, SerialNumber  FROM Win32_OperatingSystem");
            foreach (ManagementObject obj in Win32_OperatingSystem.Get())
            {
                /*-----Virtual-Memory----*/
                ulong totalVirtualMemory = Convert.ToUInt64(obj["TotalVirtualMemorySize"]); 
                ulong busyVirtualMemory = totalVirtualMemory - Convert.ToUInt64(obj["FreeVirtualMemory"]);
                totalVirtualMemoryGlobal = (totalVirtualMemory / 1024).ToString();
                selectedVirtualMemoryGlobal = (busyVirtualMemory / 1024).ToString();
                percentUseVirtualMemoryGlobal = ((busyVirtualMemory * 100) / totalVirtualMemory).ToString();
                /*----------RAM----------*/
                ulong totalRam = Convert.ToUInt64(obj["TotalVisibleMemorySize"]);       //общая память ОЗУ
                ulong busyRam = totalRam - Convert.ToUInt64(obj["FreePhysicalMemory"]); //занятная память = (total-free)
                totalRAMGlobal = (totalRam / 1024).ToString();
                useRAMGlobal = (busyRam / 1024).ToString();
                percentUseRAMGlobal = ((busyRam * 100) / totalRam).ToString();               //вычисляем проценты занятой памяти
                /*----------OS-----------*/
                OSArchitectureGlobal = (obj["OSArchitecture"]).ToString(); // получаю разрядность системы(~64-разрядная)
                versionGlobal = (obj["Version"]).ToString(); // сборка ОС(~"10.0.17763")
                captionGlobal = (obj["Caption"]).ToString(); // ~"Майкрософт Windows 10 Корпоративная LTSC"
                nameComputerGlobal = (obj["CSName"]).ToString(); // Name PC
                nameUserGlobal = (obj["RegisteredUser"]).ToString(); // Name User
                serialNumberGlobal = (obj["SerialNumber"]).ToString(); // product key
                /*----------MORE---------*/
            }
        }

        private void WorkWithProcessor()
        {
            ManagementObjectSearcher Win32_Processor =    //запрос к WMI для получения коллекций (Win32_Processor)
                new ManagementObjectSearcher("SELECT Name, NumberOfCores, MaxClockSpeed FROM Win32_Processor");
            foreach (ManagementObject obj in Win32_Processor.Get())
            {
                processorNameGlobal = (obj["Name"]).ToString();
                numberOfCoresGlobal = (obj["NumberOfCores"]).ToString();
            }
        }
    }
}



