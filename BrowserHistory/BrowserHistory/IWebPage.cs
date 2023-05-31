using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrowserHistory
{
    public interface IWebPage
    {
        string URL { get; }
        void Load();
    }
}