using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwDD2_MT1_FeedbackProcessor
{
    class FeatureRequest : Feedback
    {
        public FeatureRequest(string reporter, string productName, string message, int priority) : base(reporter, productName, message, priority)
        {
        }

        public FeatureRequest(string reporter, string productName, string message) : base(reporter, productName, message, 1)
        {
        }
    }
}
