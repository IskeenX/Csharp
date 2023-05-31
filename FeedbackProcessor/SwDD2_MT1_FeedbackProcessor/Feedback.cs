using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwDD2_MT1_FeedbackProcessor
{
    abstract class Feedback : IComparable
    {
        protected string reporter;
        protected string productName;
        protected string message;
        protected int priority;

        public string Reporter { get { return reporter; } }
        public string ProductName { get { return productName; } }

        protected Feedback(string reporter, string productName, string message, int priority)
        {
            this.reporter = reporter;
            this.productName = productName;
            this.message = message;
            this.priority = priority;
        }

        public int CompareTo(object obj)
        {
            return - this.priority.CompareTo((obj as Feedback).priority);
        }
    }
}
