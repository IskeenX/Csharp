using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallbacksDelegatesAndEvents
{
    internal class FeatureRequest : Feedback
    {
        int priority = 1;
        public FeatureRequest(string reporter, string productName, string text, int priority) : base(reporter, productName, text, priority)
        {
            this.priority = priority;
        }
    }
}