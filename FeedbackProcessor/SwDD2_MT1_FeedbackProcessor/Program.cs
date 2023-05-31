using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwDD2_MT1_FeedbackProcessor
{
    class Program
    {
        static Random RNG = new Random();

        static void Main(string[] args)
        {
            FeedbackProcessor processor = new FeedbackProcessor(15);

            processor.ProcessFeedbackEvent += React;

            try
            {
                processor.RegisterFeedback(new Opinion("Alice", "SoftwareProduct1", "Its fine.", 10));
                processor.RegisterFeedback(new Opinion("Bob", "SoftwareProduct2", "Its cool.", 8));
                processor.RegisterFeedback(new FeatureRequest("Charles", "MYSoft", "Add new features, please."));
                processor.RegisterFeedback(new FeatureRequest("Bob", "MYSoft", "Make more features, please."));
                processor.RegisterFeedback(new FeatureRequest("Alice", "MYSoft", "Something, please."));
                processor.RegisterFeedback(new FeatureRequest("Dave", "MYSoft", "Anything could work."));
                processor.RegisterFeedback(new FeatureRequest("Eddie", "MYSoft", "More features needed."));
                processor.RegisterFeedback(new FeatureRequest("Frankie", "MYSoft2", "Other features required."));
                processor.RegisterFeedback(new Bugreport("Hugo", "Soft1", "There is a bug."));
                processor.RegisterFeedback(new Bugreport("Jane", "Soft1", "There is a bug."));
            }
            catch (TooManyFeatureRequestsException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (FeedbackSpammingException e)
            {
                Console.WriteLine(e.Message);
            }
        }

        private static void React(Feedback source, ProcessFeedbackEventArgs e)
        {
            if (source is Opinion)
            {
                Console.WriteLine("Thank you for your opinion!Your opinion matters! It really does, trust us!");
            }            
            else if (source is Bugreport)
            {
                System.Threading.Thread.Sleep(RNG.Next(2000, 4000));
                int val = RNG.Next(3);
                if (val == 0)
                {
                    Console.WriteLine("Thank you for your report!We could not reproduce this bug!");
                }
                else if (val == 1)
                {
                    Console.WriteLine("Thank you for your report! This will be fixed in our next release!");
                }
                else
                {
                    Console.WriteLine("Thank you for your report! This is not a bug, it is a feature!");
                }
            }
            else if (source is FeatureRequest)
            {
                System.Threading.Thread.Sleep(RNG.Next(1000, 2000));
                if (RNG.Next(2) == 0)
                {
                    Console.WriteLine("Thank you for your request!We will surely not implement that!");
                }
                else
                {
                    Console.WriteLine("Thank you for your request!This feature will be implemented in the next version!");
                }
            }
        }
    }
}
