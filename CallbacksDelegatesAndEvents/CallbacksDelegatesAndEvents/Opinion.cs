using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CallbacksDelegatesAndEvents
{
    internal sealed class Opinion : Feedback
    {
        
        private int Rating;
        int priority = 0;
        public Opinion(string reporter, string productName, string text, int priority, int Rating) : base(reporter, productName, text, priority)
        {
            this.priority = priority;
            this.Rating = Rating;
        }
    }
}