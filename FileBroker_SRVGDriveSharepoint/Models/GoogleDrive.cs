using System;
using System.Collections.Generic;
using System.Text;

namespace FileBroker_SRVGDriveSharepoint.Models
{
    public class GoogleDrive
    {
        public string kind { get; set; }
        public string newStartPageToken { get; set; }
        public Change[] changes { get; set; }
    }

    public class Change
    {
        public bool removed { get; set; }
        public string fileId { get; set; }
        public File file { get; set; }
    }

    public class File
    {
        public string name { get; set; }
        public string mimeType { get; set; }
        public bool trashed { get; set; }
        public string[] parents { get; set; }
        public DateTime createdTime { get; set; }
        public DateTime modifiedTime { get; set; }
        public string originalFilename { get; set; }
        public string md5Checksum { get; set; }
        public string size { get; set; }
    }
}