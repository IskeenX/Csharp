using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrowserHistory
{
    public class UntrustedWebsite : SimpleWebsite
    {
        public UntrustedWebsite(string url) : base(url) { }

        public new void Load()
        {
            Console.WriteLine($"Warning! {URL} is untrusted!");
        }
    }
}