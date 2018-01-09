using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PicturesVideoPlayer.Helpers
{
    class UIHelper
    {
        #region Shell_TrayWnd
        [DllImport("user32.dll")]
        private static extern int ShowWindow(int hwnd, int nCmdShow);

        [DllImport("user32.dll")]
        private static extern int FindWindow(string lpClassName, string lpWindowName);

        private const int SW_HIDE = 0;  //隐藏任务栏
        private const int SW_RESTORE = 9;//显示任务栏

        public static void ShowTrayWnd()
        {
            ShowWindow(FindWindow("Shell_TrayWnd", null), SW_RESTORE);
        }

        public static void HideTrayWnd()
        {
            ShowWindow(FindWindow("Shell_TrayWnd", null), SW_HIDE);
        }

        #endregion

        [DllImport("user32.dll", EntryPoint = "ShowCursor", CharSet = CharSet.Auto)]
        public extern static void ShowCursor(int status);

        #region FullScreen

        public static void SwitchFullScreen(Form form)
        {
            if (form == null)
                return;

            if (form.WindowState == FormWindowState.Maximized)
            {
                Helpers.UIHelper.ShowTrayWnd();
                form.FormBorderStyle = FormBorderStyle.Sizable;
                form.WindowState = FormWindowState.Normal;
            }
            else if (form.WindowState == FormWindowState.Normal)
            {
                Helpers.UIHelper.HideTrayWnd();
                form.FormBorderStyle = FormBorderStyle.None;
                form.WindowState = FormWindowState.Maximized;
            }
        }

        #endregion
    }
}
