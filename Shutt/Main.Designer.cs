namespace Shutt
{
    partial class Main
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.hrs = new System.Windows.Forms.NumericUpDown();
            this.mnts = new System.Windows.Forms.NumericUpDown();
            this.secs = new System.Windows.Forms.NumericUpDown();
            this.start = new System.Windows.Forms.Button();
            this.nt = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.отменитьВыключениеToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.скрытьВТрейToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.отменаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вызватьShutdownexeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отменитьВыключениеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.скрытьВТрейToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходALTF4ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.progressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.hrs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mnts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.secs)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(10, 49);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(88, 30);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Завершение\r\nработы\r\n";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(104, 56);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(85, 17);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Гибернация";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(195, 56);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(97, 17);
            this.radioButton3.TabIndex = 2;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Перезагрузка";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // hrs
            // 
            this.hrs.Location = new System.Drawing.Point(76, 93);
            this.hrs.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.hrs.Name = "hrs";
            this.hrs.Size = new System.Drawing.Size(34, 20);
            this.hrs.TabIndex = 3;
            this.hrs.ValueChanged += new System.EventHandler(this.hrs_ValueChanged);
            // 
            // mnts
            // 
            this.mnts.Location = new System.Drawing.Point(127, 93);
            this.mnts.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.mnts.Name = "mnts";
            this.mnts.Size = new System.Drawing.Size(34, 20);
            this.mnts.TabIndex = 4;
            this.mnts.ValueChanged += new System.EventHandler(this.mnts_ValueChanged);
            // 
            // secs
            // 
            this.secs.Location = new System.Drawing.Point(179, 93);
            this.secs.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.secs.Name = "secs";
            this.secs.Size = new System.Drawing.Size(34, 20);
            this.secs.TabIndex = 5;
            this.secs.ValueChanged += new System.EventHandler(this.secs_ValueChanged);
            // 
            // start
            // 
            this.start.Font = new System.Drawing.Font("Kristen ITC", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.start.Location = new System.Drawing.Point(76, 119);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(137, 36);
            this.start.TabIndex = 6;
            this.start.Text = "Запуск";
            this.start.UseVisualStyleBackColor = true;
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // nt
            // 
            this.nt.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.nt.BalloonTipText = "hi";
            this.nt.BalloonTipTitle = "Shutt program";
            this.nt.ContextMenuStrip = this.contextMenuStrip1;
            this.nt.Icon = ((System.Drawing.Icon)(resources.GetObject("nt.Icon")));
            this.nt.Text = "Shutt.";
            this.nt.Visible = true;
            this.nt.DoubleClick += new System.EventHandler(this.DoubleClicknt);
            this.nt.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.отменитьВыключениеToolStripMenuItem1,
            this.скрытьВТрейToolStripMenuItem,
            this.выходToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(203, 70);
            // 
            // отменитьВыключениеToolStripMenuItem1
            // 
            this.отменитьВыключениеToolStripMenuItem1.Name = "отменитьВыключениеToolStripMenuItem1";
            this.отменитьВыключениеToolStripMenuItem1.Size = new System.Drawing.Size(202, 22);
            this.отменитьВыключениеToolStripMenuItem1.Text = "Отменить выключение";
            this.отменитьВыключениеToolStripMenuItem1.Click += new System.EventHandler(this.отменитьВыключениеToolStripMenuItem1_Click);
            // 
            // скрытьВТрейToolStripMenuItem
            // 
            this.скрытьВТрейToolStripMenuItem.Name = "скрытьВТрейToolStripMenuItem";
            this.скрытьВТрейToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.скрытьВТрейToolStripMenuItem.Text = "Скрыть в трей";
            this.скрытьВТрейToolStripMenuItem.Click += new System.EventHandler(this.скрытьВТрейToolStripMenuItem_Click);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(73, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "часы";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(124, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "минуты";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(175, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "секунды";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(36, 29);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(222, 17);
            this.checkBox1.TabIndex = 10;
            this.checkBox1.Text = "Немедленно закрыть все приложения";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ContextMenuStrip = this.contextMenuStrip1;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.отменаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(300, 24);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // отменаToolStripMenuItem
            // 
            this.отменаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.вызватьShutdownexeToolStripMenuItem,
            this.отменитьВыключениеToolStripMenuItem,
            this.скрытьВТрейToolStripMenuItem1,
            this.aboutToolStripMenuItem,
            this.выходALTF4ToolStripMenuItem});
            this.отменаToolStripMenuItem.Name = "отменаToolStripMenuItem";
            this.отменаToolStripMenuItem.Size = new System.Drawing.Size(107, 20);
            this.отменаToolStripMenuItem.Text = "Дополнительно";
            // 
            // вызватьShutdownexeToolStripMenuItem
            // 
            this.вызватьShutdownexeToolStripMenuItem.Name = "вызватьShutdownexeToolStripMenuItem";
            this.вызватьShutdownexeToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.вызватьShutdownexeToolStripMenuItem.Text = "Вызвать Shutdown.exe";
            this.вызватьShutdownexeToolStripMenuItem.Click += new System.EventHandler(this.вызватьShutdownexeToolStripMenuItem_Click);
            // 
            // отменитьВыключениеToolStripMenuItem
            // 
            this.отменитьВыключениеToolStripMenuItem.Name = "отменитьВыключениеToolStripMenuItem";
            this.отменитьВыключениеToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.отменитьВыключениеToolStripMenuItem.Text = "Отменить выключение";
            this.отменитьВыключениеToolStripMenuItem.Click += new System.EventHandler(this.отменитьВыключениеToolStripMenuItem_Click);
            // 
            // скрытьВТрейToolStripMenuItem1
            // 
            this.скрытьВТрейToolStripMenuItem1.Name = "скрытьВТрейToolStripMenuItem1";
            this.скрытьВТрейToolStripMenuItem1.Size = new System.Drawing.Size(202, 22);
            this.скрытьВТрейToolStripMenuItem1.Text = "Скрыть в трей";
            this.скрытьВТрейToolStripMenuItem1.Click += new System.EventHandler(this.скрытьВТрейToolStripMenuItem1_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // выходALTF4ToolStripMenuItem
            // 
            this.выходALTF4ToolStripMenuItem.Name = "выходALTF4ToolStripMenuItem";
            this.выходALTF4ToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.выходALTF4ToolStripMenuItem.Text = "Выход";
            this.выходALTF4ToolStripMenuItem.Click += new System.EventHandler(this.выходALTF4ToolStripMenuItem_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(176, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(13, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "0";
            this.label4.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(115, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(132, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Времени до гибернации:";
            this.label5.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(127, 207);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "label6";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.progressBar1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 210);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.statusStrip1.Size = new System.Drawing.Size(300, 22);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 16;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // progressBar1
            // 
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(100, 16);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(300, 232);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.start);
            this.Controls.Add(this.secs);
            this.Controls.Add(this.mnts);
            this.Controls.Add(this.hrs);
            this.Controls.Add(this.radioButton3);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Shutt.";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Main_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.hrs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mnts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.secs)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.NumericUpDown hrs;
        private System.Windows.Forms.NumericUpDown mnts;
        private System.Windows.Forms.NumericUpDown secs;
        private System.Windows.Forms.Button start;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem отменаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem отменитьВыключениеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem вызватьShutdownexeToolStripMenuItem;
        public System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.NotifyIcon nt;
        private System.Windows.Forms.ToolStripMenuItem выходALTF4ToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem отменитьВыключениеToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem скрытьВТрейToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem скрытьВТрейToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripProgressBar progressBar1;
    }
}

