using Newtonsoft.Json;
using PicturesVideoPlayer.Settings.SettingTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PicturesVideoPlayer.Settings
{
    
    class Setting
    {
        private Setting()
        {
            // set default value
            this.Mode = Modes.Replace;

            this.SourceFramePath = "Video\\frame.jpg";
            this.SourceFrameURI = string.Empty;

            this.FPS = 30;
            this.SizeMode = SizeModes.Zoom;
        }

        /// <summary>
        /// Mode:
        /// - ReadSame: The source generator replace the file in [SourceFolderPath + FrameName], the player read the file by [FPS].
        /// - ReadNew: The source generator add new file [SourceFolderPath], use FileWatcher to watch SourceFolderPath folder, when the new file is created.
        /// - HTTPGet: The source generator share the url, config it in [URI].
        /// </summary>
        public Modes Mode { get; set; }

        // input setting
        public string SourceFramePath { get; set; }
        private string _sourceFrameFullPath = string.Empty;
        [JsonIgnore]
        public string SourceFrameFullPath
        {
            get
            {
                if (!string.IsNullOrEmpty(SourceFramePath))
                {
                    // For Windows
                    if (-1 != SourceFramePath.IndexOf(":"))
                    {
                        _sourceFrameFullPath = SourceFramePath;
                    }
                    else
                    {
                        _sourceFrameFullPath = System.IO.Path.GetFullPath(SourceFramePath);
                    }
                }
                return _sourceFrameFullPath;
            }
        }

        public string SourceFrameURI { get; set; }

        // output setting
        public int FPS { get; set; }
        public SizeModes SizeMode { get; set; }

        public override string ToString()
        {
            string json = JsonConvert.SerializeObject(this, Formatting.Indented);
            return json;
        }

        private static Setting _instance = null;
        public static Setting Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = RestoreFromDisk();
                    if (_instance == null)
                    {
                        _instance = new Setting();
                    }
                }
                return _instance;
            }
        }
        private const string SETTING_FILE_NAME = "setting.user.json";

        public static bool SaveToDisk(Setting setting)
        {
            bool success = false;
            try
            {
                System.IO.File.WriteAllText(System.IO.Path.GetFullPath(SETTING_FILE_NAME), setting.ToString(), Encoding.UTF8);
                success = true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                success = false;
            }
            return success;
        }

        private static Setting RestoreFromDisk()
        {
            Setting result = null;
            try
            {
                string filePath = System.IO.Path.GetFullPath(SETTING_FILE_NAME);
                if (System.IO.File.Exists(filePath))
                {
                    string json = System.IO.File.ReadAllText(filePath);
                    result = JsonConvert.DeserializeObject<Setting>(json);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            return result;
        }
    }
}
