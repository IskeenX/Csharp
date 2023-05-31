using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwDD2_MT1_FeedbackProcessor
{
    delegate void ProcessFeedbackEventHandler(Feedback source, ProcessFeedbackEventArgs e);

    class FeedbackProcessor
    {
        public event ProcessFeedbackEventHandler ProcessFeedbackEvent;

        Feedback[] feedbacks;
        int idx;

        public FeedbackProcessor(int limit)
        {
            feedbacks = new Feedback[limit];
            idx = 0;
        }

        int CountReporter(Feedback feedback)
        {
            int count = 0;
            for (int i = 0; i < idx; i++)
            {
                if (feedbacks[i].Reporter == feedback.Reporter)
                {
                    count++;
                }
            }
            return count;
        }

        int CountFeatureRequests(Feedback feedback)
        {
            int count = 0;
            for (int i = 0; i < idx; i++)
            {
                if (feedbacks[i] is FeatureRequest && feedbacks[i].ProductName == feedback.ProductName)
                {
                    count++;
                }
            }
            return count;
        }

        Feedback[] CollectNonEmptyFeedbacks()
        {   
            Feedback[] collected = new Feedback[idx];
            for (int i = 0; i < idx; i++)
            {
                collected[i] = feedbacks[i];
            }
            return collected;
        }

        public void RegisterFeedback(Feedback feedback)
        {
            if (CountReporter(feedback) == 2)
            {
                throw new FeedbackSpammingException(feedback.Reporter, "There are more than two feedbacks from this user.");
            }
            else if (feedback is FeatureRequest && CountFeatureRequests(feedback) == 5)
            {
                throw new TooManyFeatureRequestsException();
            }
            else
            {
                feedbacks[idx] = feedback;
                idx++;

                if (idx == 10)
                {   
                    Feedback[] temp = CollectNonEmptyFeedbacks();
                    Array.Sort(temp);
                    for (int i = 0; i < idx; i++)
                    {
                        ProcessFeedbackEvent?.Invoke(temp[i], new ProcessFeedbackEventArgs() { Timestamp = DateTime.Now });
                        feedbacks[i] = null;
                    }
                    idx = 0;
                }
            }
        }
    }
}
