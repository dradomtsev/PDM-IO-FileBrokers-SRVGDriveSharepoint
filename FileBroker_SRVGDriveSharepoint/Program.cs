using System;

namespace FileBroker_SRVGDriveSharepoint
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Init");
            FileBroker_SRVGDriveSharepoint.InitProcess.Init();

            FileBroker_SRVGDriveSharepoint.GroundWatch.WatchSyncoveryLogs();
        }
    }
}
