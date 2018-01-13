using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.ComponentModel;
using PicturesVideoPlayer.Helpers;
using System.Drawing;
using System.Security.Permissions;
using NLog;

namespace PicturesVideoPlayer.Connector
{
    class FileSystemWatcherConnector : PollingConnector
    {
        private static Logger _logger = LogManager.GetCurrentClassLogger();
        private FileSystemWatcher _watcher = null;
        public FileSystemWatcherConnector(Form form, PictureBox pictureBox, IContainer components)
            : base(form, pictureBox, components)
        {
            InitFileSystemWatcher();
        }

        public System.Collections.Concurrent.ConcurrentQueue<string> FrameSets = new System.Collections.Concurrent.ConcurrentQueue<string>();

        private void InitFileSystemWatcher()
        {
            this._watcher = new System.IO.FileSystemWatcher();
            ((System.ComponentModel.ISupportInitialize)(this._watcher)).BeginInit();

            if (string.IsNullOrEmpty(Settings.Setting.Instance.SourceFileSystemWatcherPathFullPath))
            {
                throw new ArgumentNullException("Settings.Setting.Instance.SourceFileSystemWatcherPathFullPath isNullOrEmpty");
            }
            _watcher.Path = Settings.Setting.Instance.SourceFileSystemWatcherPathFullPath;
            _watcher.SynchronizingObject = _form;
            if (!string.IsNullOrEmpty(Settings.Setting.Instance.SourceFileSystemWatcherFilter))
            {
                _watcher.Filter = Settings.Setting.Instance.SourceFileSystemWatcherFilter;
            }
            _watcher.Created += new System.IO.FileSystemEventHandler(_watcher_Created);
            this.SetTimer(timerForPolling_Tick);
            ((System.ComponentModel.ISupportInitialize)(this._watcher)).EndInit();
        }

        bool updating = false;
        private void timerForPolling_Tick(object sender, EventArgs e)
        {
            DateTime start = DateTime.Now;
            while (!updating && FrameSets.Count > 0)
            {
                try
                {
                    string path = string.Empty;.
                    if (FrameSets.TryDequeue(out path))
                    {
                        updating = true;
                        Image image = ImageHelper.GetImage(path, FileHelper.GetFileStream);
                        if (image != null)
                        {
                            _logger.Debug("updating " + path);
                            UpdateFrameToUI(image);
                        }
                    }
                }
                catch (Exception ex)
                {
                    _logger.Debug(ex.ToString());
                }
                finally
                {
                    updating = false;
                }
            }
        }

        private void _watcher_Created(object sender, FileSystemEventArgs e)
        {
            try
            {
                // _watcher.EnableRaisingEvents = false;
                _logger.Debug("Updating " + e.FullPath + " to screen.");
                FrameSets.Enqueue(e.FullPath);
            }
            catch (Exception ex)
            {
                _logger.Debug(ex.ToString());
            }
            finally
            {
                // _watcher.EnableRaisingEvents = true;
            }
        }

        public override void RefreshStart()
        {
            base.RefreshStart();
            _watcher.EnableRaisingEvents = true;
        }

        public override void RefreshStop()
        {
            base.RefreshStop();
            _watcher.EnableRaisingEvents = false;
        }
    }
}
