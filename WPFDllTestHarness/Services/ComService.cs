using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPFDllTestHarness.Models;

namespace WPFDllTestHarness.Services
{
    class ComService
    {

        private State _currentState;

        private static ComService _instance = null;
        public static ComService Instance()
        {
            return _instance ?? (_instance = new ComService());
        }

        public ComService()
        {
            _currentState = State.Loading;
        }

        public void StartService()
        {

        }

        public void StopService()
        {

        }

        private void DllFun()
        {

        }

        private bool CanStartService()
        {
            return true;
        }

        private bool IsDllInjected()
        {
            return false;
        }

        private void TransactionCompletedEvent()
        {
            Console.WriteLine("Transaction Completed Event");
        }

        private void TransactionCanceledEvent()
        {
            Console.WriteLine("Transaction Cancelled Event");

        }
    }
}
