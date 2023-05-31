using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CallbacksDelegatesAndEvents
{
    internal class Feedback  : IComparable
    {
        static Random rnd = new Random();
        private string reporter;
        private string productName;
        private string text;
        int priority = rnd.Next(1, 10);

        public Feedback(string reporter, string productName, string text, int priority)
        {
            this.reporter = reporter;
            this.productName = productName;
            this.text = text;
            this.priority = priority;
        }

        public virtual void React(string result)
        {

        }
    }
}