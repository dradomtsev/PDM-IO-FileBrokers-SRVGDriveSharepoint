using System;
using System.Collections.Generic;
using System.Text;
using System.Reflection;
using System.IO;

namespace FileBroker_SRVGDriveSharepoint
{
    class DataTransform
    {
        public static void ReadJSON<T>(ref T rtObj_In, ref string sPath )
        {
            System.Resources.ResourceManager rm = new System.Resources.ResourceManager("FileBroker_SRVGDriveSharepoint.Properties.Resources", Assembly.GetExecutingAssembly());
            using (StreamReader srReader = new StreamReader(sPath))
            {
                string sJSON = srReader.ReadToEnd();
                rtObj_In = Newtonsoft.Json.JsonConvert.DeserializeObject<T>(sJSON);
            }
        }
    }
}
