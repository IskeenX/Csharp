using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrowserHistory
{
    public class SimpleWebsite : IWebPage
    {
        public string URL { get; private set; }

        public SimpleWebsite(string url)
        {
            URL = url;
        }

        public void Load()
        {
            Console.WriteLine($"This is {URL}, an ordinary webpage");
        }
    }
}