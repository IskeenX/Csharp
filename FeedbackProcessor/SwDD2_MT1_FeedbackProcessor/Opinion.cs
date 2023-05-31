using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwDD2_MT1_FeedbackProcessor
{
    sealed class Opinion : Feedback
    {
        int rating;

        public Opinion(string reporter, string productName, string message, int rating) : base(reporter, productName, message, 0)
        {
            this.rating = rating;
        }
    }
}
