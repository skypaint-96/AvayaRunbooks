namespace AvayaRunbooks.Console
{
    using System;

    internal class Program
    {
        static void Main(string[] args)
        {
            FileSystemWatcher avayaDir = new FileSystemWatcher(@"C:\Users\mason\OneDrive\Documents\test\");
            //avayaDir.Changed += new FileSystemEventHandler(FswEvent);
            //avayaDir.Deleted += new FileSystemEventHandler(FswEvent);
            //avayaDir.Renamed += new RenamedEventHandler(FswEvent);
            //avayaDir.Created += new FileSystemEventHandler(FswEvent);
            avayaDir.EnableRaisingEvents = true;
            WaitForChangedResult result = avayaDir.WaitForChanged(WatcherChangeTypes.All);
            Console.WriteLine(result.Name);
        }

        private static void FswEvent(object sender, FileSystemEventArgs e)
        {
            Console.WriteLine("Ping");
        }
    }
}
