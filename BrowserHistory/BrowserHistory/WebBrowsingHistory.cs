using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrowserHistory
{
    public class WebBrowsingHistory<TContent> where TContent : IWebPage
    {
        public event EventHandler<BrowserHistoryEventArgs> HistoryChanged;

        private class BrowsingHistoryElement
        {
            public TContent Content { get; set; }
            public BrowsingHistoryElement Backward { get; set; }
            public BrowsingHistoryElement Forward { get; set; }
        }

        private BrowsingHistoryElement firstElement;
        private BrowsingHistoryElement currentElement;

        public void VisitNewWebsite(TContent content)
        {
            var newElement = new BrowsingHistoryElement { Content = content };

            if (firstElement == null)
            {
                firstElement = newElement;
                currentElement = newElement;
            }
            else
            {
                newElement.Backward = currentElement;
                currentElement.Forward = newElement;
                currentElement = newElement;
            }

            OnHistoryChanged("New website reached");
            content.Load();
        }

        public void GoBackward(int steps)
        {
            for (int i = 0; i < steps; i++)
            {
                if (currentElement.Backward == null)
                {
                    throw new InvalidOperationException("No more backward steps are possible, you reached the first element.");
                }

                currentElement = currentElement.Backward;
                currentElement.Content.Load();
            }
        }

        public void GoForward(int steps)
        {
            for (int i = 0; i < steps; i++)
            {
                if (currentElement.Forward == null)
                {
                    throw new InvalidOperationException("No more forward steps are possible.");
                }

                currentElement = currentElement.Forward;
                currentElement.Content.Load();
            }
        }

        public string GetAllURLs()
        {
            var urls = "";
            var element = firstElement;

            while (element != null)
            {
                urls += element.Content.URL + Environment.NewLine;
                element = element.Forward;
            }

            return urls;
        }

        protected virtual void OnHistoryChanged(string message)
        {
            HistoryChanged?.Invoke(this, new BrowserHistoryEventArgs(message));
        }
    }

}