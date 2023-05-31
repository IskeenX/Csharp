namespace BrowserHistory
{
    public class Program
    {
        private static WebBrowsingHistory<IWebPage> browsingHistory;

        public static void Main(string[] args)
        {
            browsingHistory = new WebBrowsingHistory<IWebPage>();
            browsingHistory.HistoryChanged += HistoryChangedEventHandler;

            Console.WriteLine("Type commands: VISIT <address>, SAFE_VISIT <address>, BACKWARD <n>, FORWARD <n>, SHOW_FULL_HISTORY, EXIT");

            while (true)
            {
                var input = Console.ReadLine();
                var command = input.Split(' ');

                if (command[0] == "VISIT")
                {
                    var url = command[1];
                    var website = new SimpleWebsite(url);
                    browsingHistory.VisitNewWebsite(website);
                }
                else if (command[0] == "SAFE_VISIT")
                {
                    var url = command[1];
                    var website = new UntrustedWebsite(url);
                    browsingHistory.VisitNewWebsite(website);
                }
                else if (command[0] == "BACKWARD")
                {
                    var steps = int.Parse(command[1]);
                    try
                    {
                        browsingHistory.GoBackward(steps);
                    }
                    catch (InvalidOperationException e)
                    {
                        Console.WriteLine(e.Message);
                    }
                }
                else if (command[0] == "FORWARD")
                {
                    var steps = int.Parse(command[1]);
                    try
                    {
                        browsingHistory.GoForward(steps);
                    }
                    catch (InvalidOperationException e)
                    {
                        Console.WriteLine(e.Message);
                    }
                }
                else if (command[0] == "SHOW_FULL_HISTORY")
                {
                    Console.WriteLine(browsingHistory.GetAllURLs());
                }
                else if (command[0] == "EXIT")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid command.");
                }
            }
        }

        private static void HistoryChangedEventHandler(object sender, BrowserHistoryEventArgs e)
        {
            Console.WriteLine(e.Message);
        }
    }
}