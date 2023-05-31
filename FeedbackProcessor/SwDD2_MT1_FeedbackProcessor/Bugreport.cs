using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwDD2_MT1_FeedbackProcessor
{
    sealed class Bugreport : FeatureRequest
    {
        public int Priority { get { return base.priority; } set { base.priority = value; } }

        public Bugreport(string reporter, string productName, string message, int priority) : base(reporter, productName, message, priority)
        {
        }

        public Bugreport(string reporter, string productName, string message) : base(reporter, productName, message, 10)
        {
        }
    }
}
