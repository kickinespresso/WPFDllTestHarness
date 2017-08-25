using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFDllTestHarness.Models
{

    public enum State
    {
        Loading,
        Ready,
        Running,
        ShuttingDown,
        Stopped
    }

    public enum ThreadType
    {
        SimpleThread,
        ComplexThread,
        MultiThread
    }

    enum ScannerMode
    {
        Dialog,
        Notification,
        Disabled

    };


    enum ServiceMode
    {
        Enabled,
        Disabled

    };


    public enum ServiceState
    {
        Loading,
        Waiting,
        Ready,
        Running,
        Stopped

    };
}
