using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using Microsoft.Win32;

namespace Shutt
{
    public partial class Main : Form
    {
        int u = 0;
        bool shut = false;
        bool rest = false;
        bool gib = false;
        bool hidden;
        string mode;
        int time;
        decimal sec;
        decimal min;
        decimal hou;
        string modeL;
        string zarkO = "";
        int hubTime;
        int timeV;
        int i = 0;
        public static bool close = false;
        int kk = 0;
        public static string line3;
        public static string line4;
        public static string line5;
        string[] locS = new string[3] { "выключения", "гибернации", "перезагрузки" };
        public static int trey;
        public static int darktheme;
        public static object ob;
        public int taskvalue = 0;
        public Main()
        {   
            InitializeComponent();
            this.Height = 197;
            nt.BalloonTipText ="До выключения осталось: "+timeV;
            this.ShowInTaskbar = true;
            nt.Click += nt_Click;
            nt.BalloonTipTitle = "Shutt.";
            nt.BalloonTipText = "Можете использовать Shutt. в трее, дабы увидеть оставшееся время до выключения.(WIP)";
            nt.ShowBalloonTip(8);
            //label6.Text = key.GetValue("trey").ToString();
            progressBar1.Visible = false;
            string PathToConfig = Environment.CurrentDirectory;
        }
        public void main(opt f)
        {
            InitializeComponent();

        }

        
        private void radioButton1_CheckedChanged(object sender, EventArgs e) // выключение
        {
            shut = true;
            gib = false;
            rest = false;
            modeL = "выключить";
            checkBox1.Enabled = true;
            label5.Text = "Времени до выключения";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e) // гибернация
        {
            gib = true;
            rest = false;
            shut = false;
            label5.Text = "Времени до гибернации";
            
            modeL = "гибернезировать";
            if (radioButton2.Checked == true && kk < 1)
            {
                kk++;
                MessageBox.Show("Для валидной работы приложения в режиме гибернации не закрывайте его.", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
            }
            label5.Visible = true;
            label4.Visible = true;

            
            
            checkBox1.Enabled = false;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e) // перезагрузка
        {
            rest = true;
            shut = false;
            gib = false;
            modeL = "перезагрузить";
            checkBox1.Enabled = true;
            label5.Text = "Времени до перезагрузки";
        }

        private void start_Click(object sender, EventArgs e)
        {
            
            int secI = Convert.ToInt32(sec);
            int minI = Convert.ToInt32(min);
            int houI = Convert.ToInt32(hou);
            if (secI < 1 && minI < 1 && houI < 1)
            {
                var imme = MessageBox.Show("Вы точно хотите немедленно " + modeL + " компьютер?", "Немедленное выключение компьютера", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (imme == DialogResult.Yes)
                {
                    time = 0;
                    goto imm;
                }
                else if (imme == DialogResult.No)
                {
                    return;
                }
            }
            time = secI + (minI * 60 + (houI * 3600));
            timeV = time;
            timer1.Interval = 1000;
            timer1.Enabled = true;
            progressBar1.Visible = true;            
        imm:;
            if (shut == true)
            {
                mode = "/s";
            }
            else if (gib == true)
            {
                mode = "/h";
            }
            else if (rest == true)
            {
                mode = "/r";
            }
            Start();
            label5.Visible = true;
            label4.Visible = true; 

            
        }
        

        private void secs_ValueChanged(object sender, EventArgs e)
        {
             sec = secs.Value;

        }

        private void mnts_ValueChanged(object sender, EventArgs e)
        {
            min = mnts.Value;
        }

        private void hrs_ValueChanged(object sender, EventArgs e)
        {
            hou = hrs.Value;

        }
        bool dik = false;
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (dik)
            {
                dik = false;
                return;
            }
            DialogResult zakr = new DialogResult();
            if (zarkO != "/f")
                zakr = MessageBox.Show("Вы уверены что хотите закрыть все приложения? Все несохраненные данные будут удалены.", "Закрыть все приложения", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            
            if (zakr == DialogResult.OK)
            {
                zarkO = "/f";
            }
            else if (zakr == DialogResult.Cancel)
            {
                zarkO = "";
                dik = true;
                checkBox1.Checked = false;
            }
           
        }

        private void отменитьВыключениеToolStripMenuItem_Click(object sender, EventArgs e)
        {

            var cmd = Process.Start(new ProcessStartInfo()
            {
                Arguments = "/c @echo off && shutdown.exe /a",
                FileName = "cmd",
            });
            TaskbarProgress.SetState(this.Handle, TaskbarProgress.TaskbarStates.NoProgress);
            progressBar1.Visible = false;
            Height = 196;
            timeV = 0;
            time = 0;
            label4.Visible = false;
            label5.Visible = false;
            secs.Value = 0;
            mnts.Value = 0;
            hrs.Value = 0;
            timer1.Enabled = false;
            nt.Text = "Shutt.";
            progressBar1.Value = 0;

        }

        private void вызватьShutdownexeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var cmd = Process.Start(new ProcessStartInfo()
            {
                Arguments = "/c echo @off && cls && shutdown.exe /i",
                FileName = "cmd",
                UseShellExecute = true,
                WindowStyle = ProcessWindowStyle.Hidden
            });
        }
        private void timer1_Tick (object sender, EventArgs e)
        {
            if (hubTime == time)
            {
                timer1.Enabled = false;
                
                if (gib == true)
                {
                    var cmd = Process.Start(new ProcessStartInfo()
                    {
                        Arguments = "/c @echo off && shutdown.exe /h",
                        FileName = "cmd"
                    });
                    progressBar1.Visible = false;
                    timeV = 0;
                    time = 0;
                    label4.Visible = false;
                    label5.Visible = false;
                    secs.Value = 0;
                    mnts.Value = 0;
                    hrs.Value = 0;
                    timer1.Enabled = false;
                    nt.Text = "Shutt.";
                }
                else
                {
                    Start();
                }
            }
            else
            {
                progressBar1.Maximum = time;
                TaskbarProgress.SetState(this.Handle, TaskbarProgress.TaskbarStates.Normal);
                TaskbarProgress.SetValue(this.Handle, taskvalue++, time);
                label6.Text = progressBar1.Maximum.ToString();
                timeV--;
                nt.Text = "Shutt.\nДо выключения осталось: " + convert(timeV);
                hubTime++;
                if (time == 0)
                {

                }
                else
                {

                    progressBar1.Value++;
                }
                label4.Text = convert(timeV);
                
                
            }
            if (timeV < 30 && u == 0)
            {
                u++;
                nt.BalloonTipText = "До " + locS[2] + " осталось 30 секунд!";
                nt.ShowBalloonTip(5);
            }
            if (timeV < 10)
            {
                nt.BalloonTipText = "До " + locS[2] + " осталось 10 секунд!";
                nt.ShowBalloonTip(5);
            }
            
        }

        private void дебагToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label4.Visible = true;
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Show();
            this.WindowState = FormWindowState.Normal;
            
        }

        void nt_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
        }


        private void выходALTF4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            close = true;
            this.Close();
        }
        void Start()
        {
            progressBar1.Maximum = time;
            if (gib)
                return;
            var cmd = Process.Start(new ProcessStartInfo()
            {
                Arguments = $"/c @echo off && cls && shutdown.exe {mode} {zarkO} /t {time} /d P:0:0",
                FileName = "cmd"
            });
            // sw.WriteLine("pause");
            // zarkO - /f - закрытие всего
            // time - /t - время
            // mode - /s,/h,/r - выключение и т.д.
            // com - коммент
        }

        private void отменитьВыключениеToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            отменитьВыключениеToolStripMenuItem_Click(null, new EventArgs());
        }

        private void скрытьВТрейToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (hidden)
            {
                Show();
                скрытьВТрейToolStripMenuItem.Text = "Скрыть";
                hidden = false;
            }
            else
            {
                this.Hide();
                скрытьВТрейToolStripMenuItem.Text = "Показать";
                hidden = true;
            }
        }

        private void скрытьВТрейToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            if (hidden)
            {
                Show();
                скрытьВТрейToolStripMenuItem.Text = "Скрыть";
                hidden = false;
            }
            else
            {
                this.Hide();
                скрытьВТрейToolStripMenuItem.Text = "Показать";
                hidden = true;
            }
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            trey = 228;
            this.Close();
        }
        private void DoubleClicknt(object sender, EventArgs e)
        {
            Show();
            hidden = false;
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("\nMade by Lenofag\n\nAll rights are not reserved.\n2019.", "About", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
            AboutBox1 bx = new AboutBox1();
            bx.Show();
        }
        void lox()
        {
            opt Opt = new opt();
            
        }
        string convert(int secs)
        {
            int mins = secs / 60;
            int hours = secs / 3600;
            secs -= ((60 * mins) + (3600 * hours));
            string res = $"{hours}:{mins}:{secs}";
            return res;
        }

        private void Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            nt.Dispose();
        }
    }
}
