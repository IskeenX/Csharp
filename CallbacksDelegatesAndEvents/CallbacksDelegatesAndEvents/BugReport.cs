using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallbacksDelegatesAndEvents
{
    internal sealed class BugReport : FeatureRequest
    {
        int priority = 10;

        public BugReport(string reporter, string productName, string text, int priority) : base(reporter, productName, text, priority)
        {
            this.priority = priority;
        }
    }
}