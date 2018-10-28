using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace b1ac
{
    public partial class mainform : Form
    {
        #region importsvars
        Random rnd = new Random();
        bool estado = false;
        [DllImport("user32", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        public static extern void mouse_event(int dwFlags, int dx, int dy, int cButtons, int dwExtraInfo);
        [DllImport("user32.dll")]
        public static extern bool RegisterHotKey(IntPtr hWnd, int id, int fsModifiers, int vlc);
        [DllImport("user32.dll", CharSet = CharSet.Auto, ExactSpelling = true)]
        private static extern IntPtr GetForegroundWindow();
        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern int GetWindowThreadProcessId(IntPtr handle, out int processId);
        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        static extern int GetWindowTextLength(IntPtr hWnd);
        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        static extern int GetWindowText(IntPtr hWnd, StringBuilder text, int count);
        private const int MOUSEEVENTF_MOVE = 0x0001;
        private const int MOUSEEVENTF_LEFTDOWN = 0x0002;
        private const int MOUSEEVENTF_LEFTUP = 0x0004;
        private const int MOUSEEVENTF_RIGHTDOWN = 0x0008;
        private const int MOUSEEVENTF_RIGHTUP = 0x0016;
        public static bool ApplicationIsActivated()
        {
            IntPtr foregroundWindow = GetForegroundWindow();
            bool result;
            if (foregroundWindow == IntPtr.Zero)
            {
                result = false;
            }
            else
            {
                int id = Process.GetCurrentProcess().Id;
                int num;
                GetWindowThreadProcessId(foregroundWindow, out num);
                result = (num == id);
            }
            return result;
        }
        private string GetCaptionOfActiveWindow()
        {
            var strTitle = string.Empty;
            var handle = GetForegroundWindow();
            var intLength = GetWindowTextLength(handle) + 1;
            var stringBuilder = new StringBuilder(intLength);
            if (GetWindowText(handle, stringBuilder, intLength) > 0)
            {
                strTitle = stringBuilder.ToString();
            }
            return strTitle;
        }
        private static Random random = new Random();
        public static string RandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            return new string(Enumerable.Repeat(chars, length).Select(s => s[random.Next(s.Length)]).ToArray());
        }
        #endregion
        public mainform()
        {
            InitializeComponent();
            int FirstHotkeyId = 1;
            int FirstHotKeyKey = (int)Keys.F8;
            bool F8Registered = RegisterHotKey(Handle, FirstHotkeyId, 0x0000, FirstHotKeyKey);
            int SecondHotkeyId = 2;
            int SecondHotKeyKey = (int)Keys.F4;
            bool F4Registered = RegisterHotKey(Handle, SecondHotkeyId, 0x0000, SecondHotKeyKey);
            int ThirdHotkeyId = 3;
            int ThirdHotkeyKey = (int)Keys.F10;
            bool F10Registered = RegisterHotKey(Handle, ThirdHotkeyId, 0x0000, ThirdHotkeyKey);
            if (!F8Registered)
            {
                Console.WriteLine("Global Hotkey F8 couldn't be registered !");
            }

            if (!F4Registered)
            {
                Console.WriteLine("Global Hotkey F4 couldn't be registered !");
            }
            if (!F10Registered)
            {
                Console.WriteLine("Global Hotkey F4 couldn't be registered !");
            }
        }
        protected override void WndProc(ref Message m)
        {
            if (m.Msg == 0x0312)
            {
                int id = m.WParam.ToInt32();
                switch (id)
                {
                    case 1:
                        if (estado == true)
                        {
                            estado = false;
                            Show();
                        }
                        else
                        {
                            estado = true;
                            Hide();
                        }
                        break;
                    case 2:
                        btnAC_Click(this, new EventArgs());
                        break;
                    case 3:
                        bunifuFlatButton1_Click(this, new EventArgs());
                        break;
                }
            }

            base.WndProc(ref m);
        }
        private void btnAC_Click(object sender, EventArgs e)
        {
            if (label1.Text == "Estado: OFF")
            {
                label1.Text = "Estado: ON";
                rodarAC.Start();
            }
            else if (label1.Text == "Estado: ON")
            {
                label1.Text = "Estado: OFF";
                rodarAC.Stop();
            }
        }
        private void btnExtender_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = AC;
        }
        private void rangelol_RangeChanged(object sender, EventArgs e)
        {
                lblMin.Text = rangelol.RangeMin.ToString();
                lblMax.Text = rangelol.RangeMax.ToString();
        }
        private void mainform_Load(object sender, EventArgs e)
        {
            lblMin.Text = rangelol.RangeMin.ToString();
            lblMax.Text = rangelol.RangeMax.ToString();
        }
        private void rodar_Tick(object sender, EventArgs e)
        {
            if (rangelol.RangeMin == 0)
            {
                rangelol.RangeMin = 1;
            }
            int minval;
            int maxval;
            int cpsmed;
            if (bunifuCheckbox2.Checked == true)
            {
                cpsmed = rnd.Next(rangelol.RangeMin, rangelol.RangeMax);
                if (rangelol.RangeMin > 0)
                {
                    minval = 1000 / rangelol.RangeMin + rangelol.RangeMax * (int)0.2;
                    maxval = 1000 / rangelol.RangeMin + rangelol.RangeMax * (int)0.48;
                    rodarAC.Interval = rnd.Next(minval, maxval);
                }
                if (bunifuCheckbox1.Checked == true)
                {
                    if (GetCaptionOfActiveWindow().Contains("Minecraft") || GetCaptionOfActiveWindow().Contains("Badlion") || GetCaptionOfActiveWindow().Contains("Labymod") || GetCaptionOfActiveWindow().Contains("OCMC") || GetCaptionOfActiveWindow().Contains("Cheatbreaker") || GetCaptionOfActiveWindow().Contains("J3Ultimate"))
                    {
                        if (!ApplicationIsActivated())
                        {
                            if (MouseButtons == MouseButtons.Left)
                            {
                                label5.Text = "Media CPS: " + cpsmed;
                                mouse_event(MOUSEEVENTF_LEFTUP, 0, 0, 0, 0);
                                mouse_event(MOUSEEVENTF_LEFTDOWN, 0, 0, 0, 0);
                                if (trackjitter.Value == 0)
                                {
                                    trackjitter.Value = 1;
                                }
                                int randx = rnd.Next(1, trackjitter.Value);
                                int randy = rnd.Next(1, trackjitter.Value);
                                int mX = MousePosition.X;
                                int mY = MousePosition.Y;
                                Cursor.Position = new Point(mX - randx, mY - randy);
                            }
                        }
                    }
                }
                else
                {
                    if (!ApplicationIsActivated())
                    {
                        if (MouseButtons == MouseButtons.Left)
                        {
                            label5.Text = "Media CPS: " + cpsmed;
                            mouse_event(MOUSEEVENTF_LEFTUP, 0, 0, 0, 0);
                            mouse_event(MOUSEEVENTF_LEFTDOWN, 0, 0, 0, 0);
                            if (trackjitter.Value == 0)
                            {
                                trackjitter.Value = 1;
                            }
                            int randx = rnd.Next(1, trackjitter.Value);
                            int randy = rnd.Next(1, trackjitter.Value);
                            int mX = MousePosition.X;
                            int mY = MousePosition.Y;
                            Cursor.Position = new Point(mX - randx, mY - randy);
                        }
                    }
                }
            }
            else
            {
                cpsmed = rnd.Next(rangelol.RangeMin, rangelol.RangeMax);
                if (rangelol.RangeMin > 0)
                {
                    minval = 1000 / rangelol.RangeMin + rangelol.RangeMax * (int)0.2;
                    maxval = 1000 / rangelol.RangeMin + rangelol.RangeMax * (int)0.48;
                    rodarAC.Interval = rnd.Next(minval, maxval);
                }
                if (bunifuCheckbox1.Checked == true)
                {
                    if (GetCaptionOfActiveWindow().Contains("Minecraft") || GetCaptionOfActiveWindow().Contains("Badlion") || GetCaptionOfActiveWindow().Contains("Labymod") || GetCaptionOfActiveWindow().Contains("OCMC") || GetCaptionOfActiveWindow().Contains("Cheatbreaker") || GetCaptionOfActiveWindow().Contains("J3Ultimate"))
                    {
                        if (!ApplicationIsActivated())
                        {
                            if (MouseButtons == MouseButtons.Left)
                            {
                                label5.Text = "Media CPS: " + cpsmed;
                                mouse_event(MOUSEEVENTF_LEFTUP, 0, 0, 0, 0);
                                mouse_event(MOUSEEVENTF_LEFTDOWN, 0, 0, 0, 0);
                            }
                        }
                    }
                }
                else
                {
                    if (!ApplicationIsActivated())
                    {
                        if (MouseButtons == MouseButtons.Left)
                        {
                            label5.Text = "Media CPS: " + cpsmed;
                            mouse_event(MOUSEEVENTF_LEFTUP, 0, 0, 0, 0);
                            mouse_event(MOUSEEVENTF_LEFTDOWN, 0, 0, 0, 0);
                        }
                    }
                }
            }
        }
        private void delall()
        {
            var version = Environment.OSVersion.Version;
            // Null
            btnAC.Text = null;
            btnMain.Text = null;
            btnSelf.Text = null;
            label1.Text = null;
            label2.Text = null;
            label3.Text = null;
            label4.Text = null;
            lblMax.Text = null;
            lblMin.Text = null;
            label5.Text = null;
            AC.Text = null;
            label5.Text = null;
            label6.Text = null;
            label7.Text = null;
            label8.Text = null;
            label9.Text = null;
            label10.Text = null;
            label11.Text = null;
            label12.Text = null;
            // Dispose
            btnAC.Dispose();
            btnMain.Dispose();
            btnSelf.Dispose();
            label1.Dispose();
            label2.Dispose();
            label3.Dispose();
            label4.Dispose();
            lblMax.Dispose();
            lblMin.Dispose();
            label5.Dispose();
            AC.Dispose();
            label5.Dispose();
            label6.Dispose();
            label7.Dispose();
            label8.Dispose();
            label9.Dispose();
            label10.Dispose();
            label11.Dispose();
            label12.Dispose();
            // Explorer
            try
            {
                foreach (Process process in Process.GetProcesses())
                {
                    if (version < new Version(6,2))
                    {
                        if (process.ProcessName == "explorer")
                        {
                            process.Kill();
                            string explorer = string.Format("{0}\\{1}", Environment.GetEnvironmentVariable("WINDIR"), "explorer.exe");
                            Process processa = new Process();
                            processa.StartInfo.FileName = explorer;
                            processa.StartInfo.UseShellExecute = true;
                            processa.Start();
                            Environment.Exit(0);
                            break;
                        }
                    }
                    else
                    {
                        if (process.ProcessName == "explorer")
                        {
                            process.Kill();
                            Environment.Exit(0);
                            break;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex, RandomString(5), MessageBoxButtons.OK, MessageBoxIcon.Error);
                Environment.Exit(0);
            }
        }
        private void deletarlol()
        {
            string location = Path.Combine(Directory.GetCurrentDirectory() + @"\" + AppDomain.CurrentDomain.FriendlyName);
            string dll = Path.Combine(Directory.GetCurrentDirectory() + @"\" + "Bunifu_UI_v1.5.4.dll");
            if (File.Exists(dll))
            {
                Process.Start(new ProcessStartInfo
                {
                    FileName = "cmd",
                    Arguments = "/C ping 1.1.1.1 -n 1 & Del " + location + " & Del " + dll,
                    CreateNoWindow = true,
                    WindowStyle = ProcessWindowStyle.Hidden
                });
            }
            else
            {
                Process.Start(new ProcessStartInfo
                {
                    FileName = "cmd",
                    Arguments = "/C ping 1.1.1.1 -n 1 & Del " + location,
                    CreateNoWindow = true,
                    WindowStyle = ProcessWindowStyle.Hidden
                });
            }
            delall();
        }
        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            if (chkDeletar.Checked == true)
            {
                deletarlol();
            }
            else
            {
                delall();
            }
        }
        private void trackjitter_ValueChanged(object sender, EventArgs e)
        {
            if (trackjitter.Value > 0)
            {
                label8.Text = trackjitter.Value.ToString();
            }
        }
    }
}
