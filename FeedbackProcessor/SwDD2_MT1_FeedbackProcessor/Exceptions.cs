using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwDD2_MT1_FeedbackProcessor
{
    class FeedbackSpammingException : Exception
    {
        string reporter;

        public string Reporter { get { return reporter; } }

        public FeedbackSpammingException(string reporter, string message) : base(message)
        {
            this.reporter = reporter;
        }
    }

    class TooManyFeatureRequestsException : Exception
    {
    }
}
