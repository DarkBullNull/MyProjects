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
        public string busyRAMGlobal { get; private set; }
        public string totalVirtualMemoryGlobal { get; private set; }
        public string selectedVirtualMemoryGlobal { get; private set; }
        public string percentBusyRAMGlobal { get; private set; }
        public string percentBusyVirtualMemoryGlobal { get; private set; }
        public string OSArchitectureGlobal { get; private set; }
        public string VersionGlobal { get; private set; }
        public string CaptionGlobal { get; private set; }
        public string processorName { get; private set; }

        private void WorkWithOperatingSystem()
        {
            ManagementObjectSearcher Win32_OperatingSystem = //запрос к WMI для получения коллекций (Win32_OperatingSystem)
                new ManagementObjectSearcher("SELECT TotalVisibleMemorySize,FreePhysicalMemory, OSArchitecture, " +
                "Version, Caption, TotalVirtualMemorySize, FreeVirtualMemory FROM Win32_OperatingSystem");
            foreach (ManagementObject obj in Win32_OperatingSystem.Get())
            {
                /*-----Virtual-Memory----*/
                ulong totalVirtualMemory = Convert.ToUInt64(obj["TotalVirtualMemorySize"]); 
                ulong busyVirtualMemory = totalVirtualMemory - Convert.ToUInt64(obj["FreeVirtualMemory"]);
                totalVirtualMemoryGlobal = (totalVirtualMemory / 1024).ToString();
                selectedVirtualMemoryGlobal = (busyVirtualMemory / 1024).ToString();
                percentBusyVirtualMemoryGlobal = ((busyVirtualMemory * 100) / totalVirtualMemory).ToString();
                /*----------RAM----------*/
                ulong totalRam = Convert.ToUInt64(obj["TotalVisibleMemorySize"]);       //общая память ОЗУ
                ulong busyRam = totalRam - Convert.ToUInt64(obj["FreePhysicalMemory"]); //занятная память = (total-free)
                totalRAMGlobal = (totalRam / 1024).ToString();
                busyRAMGlobal = (busyRam / 1024).ToString();
                percentBusyRAMGlobal = ((busyRam * 100) / totalRam).ToString();               //вычисляем проценты занятой памяти
                /*----------OS-----------*/
                OSArchitectureGlobal = (obj["OSArchitecture"]).ToString(); // получаю разрядность системы(~64-разрядная)
                VersionGlobal = (obj["Version"]).ToString(); // сборка ОС(~"10.0.17763")
                CaptionGlobal = (obj["Caption"]).ToString(); // ~"Майкрософт Windows 10 Корпоративная LTSC"
                /*----------MORE---------*/
            }
        }

        private void WorkWithProcessor()
        {
            ManagementObjectSearcher Win32_Processor =    //запрос к WMI для получения коллекций (Win32_Processor)
                new ManagementObjectSearcher("SELECT Name FROM Win32_Processor");
            foreach (ManagementObject obj in Win32_Processor.Get())
            {
                processorName = (obj["Name"]).ToString();
            }
        }
    }
}



