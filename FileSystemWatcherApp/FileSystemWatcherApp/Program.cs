using System.Data;

namespace FileSystemWatcherApp
{
    internal class Program
    {
        static void Faz(int i) { }
        static void FooBar(object o, FileSystemEventArgs aegs)
        {
            Console.WriteLine("FOOBAR");
        }
        static void CreationalNotification(object o, FileSystemEventArgs aegs)
        {
            Console.WriteLine("File created");
        }
        static void Main(string[] args)
        {
            FileSystemWatcher watcher = new FileSystemWatcher("D:\\Images\\fasf");
            watcher.EnableRaisingEvents = true;

            //watcher.Created += FooBar;
            watcher.Created += CreationalNotification;
            watcher.Deleted += Watcher_Deleted;
            watcher.Deleted += Watcher_Deleted1;
            while (true)
            {
                Console.WriteLine("I;m listening...");
                System.Threading.Thread.Sleep(1000);
            }
        }

        private static void Watcher_Deleted1(object sender, FileSystemEventArgs e)
        {
            Console.Beep(100 * e.Name.Length, 10 * e.FullPath.Length);
        }

        private static void Watcher_Deleted(object sender, FileSystemEventArgs e)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"File was deleted {e.Name}");
            Console.ResetColor();
        }
    }
}