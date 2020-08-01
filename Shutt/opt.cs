using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows;
using Microsoft.Win32;
using System.IO;
using System.Diagnostics;

namespace Shutt
{
    

    public partial class opt : Form
    {
        public static RegistryKey key;
        Main main = new Main();
        public static int optclose = 0;
        int Trey;
        
        static void lineChanger(string newText, string fileName, int line_to_edit)
        {
            string[] arrLine = File.ReadAllLines(fileName);
            arrLine[line_to_edit - 1] = newText;
            File.WriteAllLines(fileName, arrLine);
        }
        int i = 0;
        public static string PathC = Environment.SystemDirectory;
        
        



        public opt()
        {
            InitializeComponent();
            PathC += @"\Close.bat";
            key = Registry.CurrentUser.CreateSubKey(@"Software\Shutt");
            object lox = key.GetValue("trey");
            int keks = Convert.ToInt32(lox);
            if (keks > 0) {
                key.SetValue("trey", 1);
                key.SetValue("darktheme", 0);
            }
            lox = key.GetValue("trey");
            Trey = Convert.ToInt32(lox);
            if (Trey > 0)
            {
                optToTray.Checked = true;
            }
            else
            {
                optToTray.Checked = false;
            }
            this.ShowInTaskbar = false;
            main.ShowInTaskbar = false;
            optToTray.CheckedChanged += (s, e) =>
            {
                if (optToTray.Checked == true)
                {
                    key.SetValue("trey", 1);
                }
                else
                {
                    key.SetValue("trey", 0);
                }
            };
        }
        // НАЙТИ НОРМАЛЬНЫЙ ЭЛЕМЕНТ!!!!!

        public opt(Main f)
        {
            InitializeComponent();
            f.BackColor = Color.White;
        }



        private void button1_Click(object sender, EventArgs e)
        {

            colorDialog1.ShowDialog();
            var lox = colorDialog1.Color.ToArgb().ToString();
            MessageBox.Show(lox);
            //optclose++;
            //MessageBox.Show("Для применения настроек нужно перезапустить приложение.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //this.Close();
            //main.Close();
            

        }

        //private void Closing(object sender, FormClosingEventArgs e)
        //{
        //    main.WindowState = FormWindowState.Normal;
        //    if (optclose > 0)
        //    {
        //        this.Hide();
        //    }
        //    else
        //    {
        //        this.Close();
        //        Close();
        //        main.Close();
        //    }
        //}
        private void Closing(object sender, FormClosingEventArgs e)
        {
            if (optToTray.Enabled)
               key.SetValue("trey", 1);
            else
               key.SetValue("trey", 0);
            //MessageBox.Show(ActiveForm.ToString());
            //if (i == 0)
            //{
            //    MessageBox.Show("Для применения настроек следует перезапустить приложение.", "Применение настроек", MessageBoxButtons.OK, MessageBoxIcon.Hand, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
            //}
            //i++;
            //main.Close();
            //using (StreamWriter sw = File.CreateText(PathC))
            //{
            //    sw.WriteLine("@echo off\necho lol\ntaskkill /pid shutt.exe /t /f");

            //}
            //Process.Start(PathC);


        }



    }
}
