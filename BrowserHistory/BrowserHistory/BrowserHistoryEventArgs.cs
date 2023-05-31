using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrowserHistory
{
    public class BrowserHistoryEventArgs : EventArgs
    {
        public string Message { get; set; }

        public BrowserHistoryEventArgs(string message)
        {
            Message = message;
        }
    }
}