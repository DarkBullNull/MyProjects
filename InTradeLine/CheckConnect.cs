using System;
using System.Net;
using System.Net.Sockets;
using System.Windows.Forms;

namespace InTradeLine
{
    class CheckConnect
    {
        public static bool CheckSocket()
        {
            if (!System.Net.NetworkInformation.NetworkInterface.GetIsNetworkAvailable())
            {
                MessageBox.Show("Отсутствует или ограниченно физическое подключение к сети\nПроверьте настройки вашего сетевого подключения");
                return false;
            }
            bool isConnected = false;
            using (var tcpClient = new TcpClient())
            {
                tcpClient.Connect("173.194.222.138", 443); // google
                if (isConnected = tcpClient.Connected)
                {
                    return true;
                }
                
            }
            if (!isConnected)
                MessageBox.Show("Нет подключения к интернету\nПроверьте ваш фаервол или настройки сетевого подключения");
            return false;
        }
    }
}

