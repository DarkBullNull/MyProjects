using System;
using System.Management;

namespace CommonInfo
{
    class PCInformation
    {
        public PCInformation()
        {
            WorkWithOperatingSystem();
        }
        public string totalRAM { get; private set; }
        public string busyRAM { get; private set; }
        public string percentBusyRAM { get; private set; }

        private void WorkWithOperatingSystem()
        {
            ManagementObjectSearcher RAM =                                              //запрос к WMI для получения памяти ПК
                new ManagementObjectSearcher("SELECT TotalVisibleMemorySize,FreePhysicalMemory, OSArchitecture, Version, Caption FROM Win32_OperatingSystem");
            foreach (ManagementObject obj in RAM.Get())
            {
                /*----------RAM-----------*/
                ulong totalRam = Convert.ToUInt64(obj["TotalVisibleMemorySize"]);       //общая память ОЗУ
                ulong busyRam = totalRam - Convert.ToUInt64(obj["FreePhysicalMemory"]); //занятная память = (total-free)
                totalRAM = (totalRam / 1024).ToString();
                busyRAM = (busyRam / 1024).ToString();
                percentBusyRAM = ((busyRam * 100) / totalRam).ToString();               //вычисляем проценты занятой памяти
                /*----------OS-----------*/
                string OSArchitecture = (obj["OSArchitecture"]).ToString(); // получаю разрядность системы(~64-разрядная)
                string Version = (obj["Version"]).ToString(); // сборка ОС(~"10.0.17763")
                string Caption = (obj["Caption"]).ToString(); // ~"Майкрософт Windows 10 Корпоративная LTSC"
            }
        }
    }
}



