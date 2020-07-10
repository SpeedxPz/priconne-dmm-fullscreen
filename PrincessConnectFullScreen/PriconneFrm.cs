using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Hwnd
{
    public partial class PrinconneFrm : Form
    {
        public PrinconneFrm()
        {
            InitializeComponent();
        }

        [DllImport("user32.dll")]
        static extern IntPtr FindWindow(string lpClassName, string lpWindowName);
        [DllImport("user32.dll")]
        static extern int SetWindowLong(IntPtr hWnd, int nIndex, int dwNewLong);
        [DllImport("user32.dll")]
        private static extern IntPtr GetWindowLong(IntPtr hWnd, int nIndex);

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);

        private const int SWP_NOSIZE = 0x0001;
        private const int SWP_NOZORDER = 0x0004;
        private const int SWP_SHOWWINDOW = 0x0040;
        private const int WS_BORDER = 0x00800000;
        private const int WS_DLGFRAME = 0x00400000;
        private const int WS_CAPTION = WS_BORDER | WS_DLGFRAME;
        private const int WS_MINIMIZE = 0x20000000;
        private const int WS_MAXIMIZE = 0x1000000;
        private const int WS_SYSMENU = 0x80000;

        private const int SW_MAXIMIZE = 3;
        private const int SW_RESTORE = 9;
        enum WindowLongFlags : int
        {
            GWL_EXSTYLE = -20,
            GWLP_HINSTANCE = -6,
            GWLP_HWNDPARENT = -8,
            GWL_ID = -12,
            GWL_STYLE = -16,
            GWL_USERDATA = -21,
            GWL_WNDPROC = -4,
            DWLP_USER = 0x8,
            DWLP_MSGRESULT = 0x0,
            DWLP_DLGPROC = 0x4
        }

        private const string PRICONNE_WND_CLASS = "UnityWndClass";
        private const string PRICONNE_WND_NAME = "PrincessConnectReDive";

        private const string MSG_TITLE_START_GAME_FIRST = "Priconne isn't running";
        private const string MSG_MESSAGE_START_GAME_FIST = "Princess Connect Re:Dive (DMM) is not running\nPlease start game first";

        private const string MSG_TITLE_ALREADY_FULLSCREEN = "Full Screen Mode";
        private const string MSG_MESSAGE_ALREADY_FULLSCREEN = "Priconne already in fullscreen mode";

        private const string MSG_TITLE_ALREADY_WINDOW = "Window Mode";
        private const string MSG_MESSAGE_ALREADY_WINDOW = "Priconne already in window mode";


        private void linkBtn_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(@"https://www.youtube.com/c/TakumiProducer");
        }

        private void fullscreenBtn_Click(object sender, EventArgs e)
        {
            IntPtr princoneHwnd = FindWindow(PRICONNE_WND_CLASS, PRICONNE_WND_NAME);
            if(((int)princoneHwnd) == 0)
            {
                MessageBox.Show(MSG_MESSAGE_START_GAME_FIST, MSG_TITLE_START_GAME_FIRST, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            IntPtr winLong = GetWindowLong(princoneHwnd, (int)WindowLongFlags.GWL_STYLE);

            int newStyle = (int)winLong;

            

            if ((((int)winLong) & WS_DLGFRAME) == 0)
            {
                MessageBox.Show(MSG_MESSAGE_ALREADY_FULLSCREEN, MSG_TITLE_ALREADY_FULLSCREEN, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            newStyle &= ~(WS_DLGFRAME | WS_MINIMIZE | WS_MAXIMIZE | WS_SYSMENU);

            SetWindowLong(princoneHwnd, (int)WindowLongFlags.GWL_STYLE, (int)newStyle);
            ShowWindow(princoneHwnd, SW_MAXIMIZE);
        }

        private void restoreBtn_Click(object sender, EventArgs e)
        {
            IntPtr priconHwnd = FindWindow(PRICONNE_WND_CLASS, PRICONNE_WND_NAME);

            if (((int)priconHwnd) == 0)
            {
                MessageBox.Show(MSG_MESSAGE_START_GAME_FIST, MSG_TITLE_START_GAME_FIRST, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            IntPtr winLong = GetWindowLong(priconHwnd, (int)WindowLongFlags.GWL_STYLE);

            int newStyle = (int)winLong;

            if ((((int)winLong) & WS_DLGFRAME) != 0)
            {
                MessageBox.Show(MSG_MESSAGE_ALREADY_WINDOW, MSG_TITLE_ALREADY_WINDOW, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            newStyle |= (WS_DLGFRAME | WS_MINIMIZE | WS_MAXIMIZE | WS_SYSMENU);

            SetWindowLong(priconHwnd, (int)WindowLongFlags.GWL_STYLE, (int)newStyle);
            ShowWindow(priconHwnd, SW_RESTORE);
        }

    }
}
