using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Security.Permissions;

namespace FileBroker_SRVGDriveSharepoint
{
    class GroundWatch
    {
        public static FileBroker_SRVGDriveSharepoint.Models.GoogleDrive rtObj_InGDrive;

        public static void WatchSyncoveryLogs()
        {
            using (FileSystemWatcher watcher = new FileSystemWatcher())
            {
                watcher.Path = FileBroker_SRVGDriveSharepoint.InitProcess.rtObj_In.Ground.ReportFiles;
                watcher.NotifyFilter = NotifyFilters.LastAccess | NotifyFilters.LastWrite;
                watcher.Filter = "*.json";

                watcher.Created += OnChanged;
                watcher.Changed += OnChanged;
                
                watcher.EnableRaisingEvents = true;
            }
        }

        private static void OnChanged(object source, FileSystemEventArgs e)
        {
            string sPath = e.FullPath;
            FileBroker_SRVGDriveSharepoint.DataTransform.ReadJSON(ref rtObj_InGDrive, ref sPath);
            foreach (FileBroker_SRVGDriveSharepoint.Models.Change fGDrive in rtObj_InGDrive.changes)
            {
                Console.WriteLine($"File: {fGDrive.file.name} {fGDrive.fileId}");
            }
            
        }        
        
    }
}
