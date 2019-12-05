using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

public class MemoryWork
{

    const int PROCESS_WM_READ = 0x0010;

    [DllImport("kernel32.dll")]
    public static extern IntPtr OpenProcess(int dwDesiredAccess, bool bInheritHandle, int dwProcessId);

    [DllImport("kernel32.dll")]
    public static extern bool ReadProcessMemory(int hProcess,
    long lpBaseAddress, byte[] lpBuffer, int dwSize, ref int lpNumberOfBytesRead);

    [DllImport("kernel32.dll", SetLastError = true)]
    static extern bool WriteProcessMemory(int hProcess, long lpBaseAddress,
      byte[] lpBuffer, int dwSize, ref int lpNumberOfBytesWritten);
    public MemoryWork()
    {
        MemoryRead();
        MemoryWrite();
        MemoryRead();
    }
    void MemoryRead()
    {
        Process process = Process.GetProcessesByName("discord")[0];
        IntPtr processHandle = OpenProcess(PROCESS_WM_READ, false, process.Id);

        int bytesRead = 0;
        byte[] buffer = new byte [999]; // 'Hello World!' takes 12 * 2 bytes because of Unicode


        // 0x0046A3B8 is the address where I found the string, replace it with what you found
        ReadProcessMemory((int)processHandle, 0x177EA1B1710, buffer, buffer.Length, ref bytesRead);

        MessageBox.Show(Encoding.Unicode.GetString(buffer) +
        "(" + bytesRead.ToString() + " bytes)");
    }
    void MemoryWrite()
    {
        Process process = Process.GetProcessesByName("discord")[0];
        IntPtr processHandle = OpenProcess(0x1F0FFF, false, process.Id);

        int bytesWritten = 0;
        byte[] buffer = Encoding.Unicode.GetBytes("okayletsgo");
        // '\0' marks the end of string

        // replace 0x0046A3B8 with your address
        WriteProcessMemory((int)processHandle, 0x177EA1B1710, buffer, buffer.Length, ref bytesWritten);

        Console.ReadLine();
    }
}