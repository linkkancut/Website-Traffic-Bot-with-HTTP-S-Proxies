using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace traffic_bot
{
    public partial class Main : Form
    {
        #region borderless + shadow (not important)
        private bool Drag;
        private int MouseX;
        private int MouseY;

        private const int WM_NCHITTEST = 0x84;
        private const int HTCLIENT = 0x1;
        private const int HTCAPTION = 0x2;

        private bool m_aeroEnabled;

        private const int CS_DROPSHADOW = 0x00020000;
        private const int WM_NCPAINT = 0x0085;
        private const int WM_ACTIVATEAPP = 0x001C;

        [System.Runtime.InteropServices.DllImport("dwmapi.dll")]
        public static extern int DwmExtendFrameIntoClientArea(IntPtr hWnd, ref MARGINS pMarInset);
        [System.Runtime.InteropServices.DllImport("dwmapi.dll")]
        public static extern int DwmSetWindowAttribute(IntPtr hwnd, int attr, ref int attrValue, int attrSize);
        [System.Runtime.InteropServices.DllImport("dwmapi.dll")]

        public static extern int DwmIsCompositionEnabled(ref int pfEnabled);
        [System.Runtime.InteropServices.DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(
            int nLeftRect,
            int nTopRect,
            int nRightRect,
            int nBottomRect,
            int nWidthEllipse,
            int nHeightEllipse
            );

        public struct MARGINS
        {
            public int leftWidth;
            public int rightWidth;
            public int topHeight;
            public int bottomHeight;
        }
        protected override CreateParams CreateParams
        {
            get
            {
                m_aeroEnabled = CheckAeroEnabled();
                CreateParams cp = base.CreateParams;
                if (!m_aeroEnabled)
                    cp.ClassStyle |= CS_DROPSHADOW; return cp;
            }
        }
        private bool CheckAeroEnabled()
        {
            if (Environment.OSVersion.Version.Major >= 6)
            {
                int enabled = 0; DwmIsCompositionEnabled(ref enabled);
                return (enabled == 1) ? true : false;
            }
            return false;
        }
        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case WM_NCPAINT:
                    if (m_aeroEnabled)
                    {
                        var v = 2;
                        DwmSetWindowAttribute(this.Handle, 2, ref v, 4);
                        MARGINS margins = new MARGINS()
                        {
                            bottomHeight = 1,
                            leftWidth = 0,
                            rightWidth = 0,
                            topHeight = 0
                        }; DwmExtendFrameIntoClientArea(this.Handle, ref margins);
                    }
                    break;
                default: break;
            }
            base.WndProc(ref m);
            if (m.Msg == WM_NCHITTEST && (int)m.Result == HTCLIENT) m.Result = (IntPtr)HTCAPTION;
        }
        private void PanelMove_MouseDown(object sender, MouseEventArgs e)
        {
            Drag = true;
            MouseX = Cursor.Position.X - this.Left;
            MouseY = Cursor.Position.Y - this.Top;
        }
        private void PanelMove_MouseMove(object sender, MouseEventArgs e)
        {
            if (Drag)
            {
                this.Top = Cursor.Position.Y - MouseY;
                this.Left = Cursor.Position.X - MouseX;
            }
        }
        private void PanelMove_MouseUp(object sender, MouseEventArgs e) { Drag = false; }
        #endregion
        public Main()
        {
            InitializeComponent();
        }

        public static int onlinenr = 0;
        public static int offlinenr = 0;
        public static int on = 0;
        private void Main_Load(object sender, EventArgs e)
        {
            try
            {
                using (var client = new WebClient())
                {
                    client.DownloadFile("https://api.proxyscrape.com/v2/?request=getproxies&protocol=http&timeout=10000&country=all&ssl=all&anonymity=all", @"proxies.txt");
                }
                string[] allLines = File.ReadAllLines(@"proxies.txt");
                imported.Text = "Imported Proxies: " + allLines.Length.ToString();
            } catch { MessageBox.Show("Something went wrong while trying to download the proxies"); }
        }

        //start button
        private void start_Click(object sender, EventArgs e)
        {
            if (websitetrafic.Text == "")
            {
                MessageBox.Show("Website not found!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                on = 1;
                proxy.Start();

                websitetrafic.Visible = false;
                stop.Visible = true;
                start.Visible = false;
            }
        }

        //stop button
        private void stop_Click(object sender, EventArgs e)
        {
            try
            {
                on = 0;
                proxy.Stop();

                websitetrafic.Visible = true;
                start.Visible = true;
                stop.Visible = false;
            } catch { }
        }

        //proxy timer
        private void proxy_Tick(object sender, EventArgs e)
        {
            Thread proxied = new Thread(delegate ()
            {
                runproxy();
            });
            proxied.Start();

            Thread proxied1 = new Thread(delegate ()
            {
                runproxy();
            });
            proxied1.Start();

            Thread proxied2 = new Thread(delegate ()
            {
                runproxy();
            });
            proxied2.Start();

            Thread proxied3 = new Thread(delegate ()
            {
                runproxy();
            });
            proxied3.Start();

            Thread proxied4 = new Thread(delegate ()
            {
                runproxy();
            });
            proxied4.Start();
        }

        public static string urlproxy = "";
        //website traffic bot code
        public void runproxy()
        {
            try
            {

                string[] allLines = File.ReadAllLines(@"proxies.txt");

                urlproxy = (allLines[new Random().Next(1, allLines.Length)]);

                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(websitetrafic.Text);
                WebProxy myproxy = new WebProxy(urlproxy, false);
                request.Proxy = myproxy;
                request.Method = "GET";
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();

                if (on == 1)
                {
                    try
                    {
                        //update status
                        online.Invoke((Action)delegate
                        {
                            onlinenr = onlinenr + 1;
                            latest.Text = "Latest Proxy Used: " + urlproxy;
                            online.Text = "Online Proxies: " + onlinenr;
                        });
                    } catch { }
                        
                }


            }
            catch
            {
                if (on == 1)
                {
                    try
                    {
                        offline.Invoke((Action)delegate
                        {
                            latest.Text = "Latest Proxy Used: " + urlproxy;
                            offlinenr = offlinenr + 1;
                            offline.Text = "Offline Proxies: " + offlinenr;
                        });
                    }
                    catch { }
                }
            }
        }

        private void close_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

    }
}
