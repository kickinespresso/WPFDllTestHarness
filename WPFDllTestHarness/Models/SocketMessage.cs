using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFDllTestHarness.Models
{
    class SocketMessage
    {

        public string Version { get; set; }
        public string MessageType { get; set; }
        public string Total { get; set; }
        public string SubTotal { get; set; }
        public string CheckNumber { get; set; }

        SocketMessage(string version, string messageType, string total, string subTotal, string checkNumber)
        {
            Version = version;
            MessageType = messageType;
            Total = total;
            SubTotal = subTotal;
            CheckNumber = checkNumber;
        }
    }
}
