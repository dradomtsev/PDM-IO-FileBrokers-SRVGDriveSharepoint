using System;
using System.Collections.Generic;
using System.Text;


namespace FileBroker_SRVGDriveSharepoint
{
    class InitProcess
    {
        public static FileBroker_SRVGDriveSharepoint.Models.ConfigFile rtObj_In;
        public IConfiguration Configuration { get; set; }
        public IHostingEnvironment Environment { get; set; }

        public Startup(IConfiguration configuration, IHostingEnvironment environment)
        {
            Environment = environment;
            Configuration = new ConfigurationBuilder()
                     .AddJsonFile("appsettings.json")
                     .AddJsonFile($"appsettings.{Environment.EnvironmentName}.json")
                     .Build();
        }

        public static void Init()
        {
            string sPath = FileBroker_SRVGDriveSharepoint.Properties.Resources.Json_Path_Input;
            FileBroker_SRVGDriveSharepoint.DataTransform.ReadJSON(ref rtObj_In, ref sPath);
        }
    }
}
