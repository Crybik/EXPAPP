using System.Windows.Forms;

namespace EXPAPP
{

    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        /// using Windows.UI.ViewManagement;

        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }


        #region Windows Form Designer generated code
      
        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()

        {
            this.init = new Sunny.UI.UITextBox();
            this.inc = new Sunny.UI.UITextBox();
            this.duration = new Sunny.UI.UITextBox();
            this.uiTitlePanel1 = new Sunny.UI.UITitlePanel();
            this.uiLinkLabel1 = new Sunny.UI.UILinkLabel();
            this.res = new System.Windows.Forms.Label();
            this.uiSymbolLabel2 = new Sunny.UI.UISymbolLabel();
            this.uiSymbolButton4 = new Sunny.UI.UISymbolButton();
            this.uiSymbolLabel1 = new Sunny.UI.UISymbolLabel();
            this.uiSymbolButton3 = new Sunny.UI.UISymbolButton();
            this.uiSymbolButton2 = new Sunny.UI.UISymbolButton();
            this.inlabelxx = new Sunny.UI.UISymbolLabel();
            this.uiSymbolButton1 = new Sunny.UI.UISymbolButton();
            this.uiPanel1 = new Sunny.UI.UIPanel();
            this.uiRadioButtonGroup2 = new Sunny.UI.UIRadioButtonGroup();
            this.reb = new Sunny.UI.UITextBox();
            this.uiRadioButton4 = new Sunny.UI.UIRadioButton();
            this.disabledx = new Sunny.UI.UIRadioButton();
            this.uiRadioButtonGroup1 = new Sunny.UI.UIRadioButtonGroup();
            this.dradio = new Sunny.UI.UIRadioButton();
            this.uiRadioButton1 = new Sunny.UI.UIRadioButton();
            this.button1 = new Sunny.UI.UISymbolButton();
            this.uiTitlePanel1.SuspendLayout();
            this.uiPanel1.SuspendLayout();
            this.uiRadioButtonGroup2.SuspendLayout();
            this.uiRadioButtonGroup1.SuspendLayout();
            this.SuspendLayout();
            // 
            // init
            // 
            this.init.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.init.FillColor = System.Drawing.Color.White;
            this.init.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.init.Location = new System.Drawing.Point(582, 62);
            this.init.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.init.Maximum = 2147483647D;
            this.init.Minimum = -2147483648D;
            this.init.MinimumSize = new System.Drawing.Size(1, 1);
            this.init.Name = "init";
            this.init.Padding = new System.Windows.Forms.Padding(5);
            this.init.Radius = 10;
            this.init.Size = new System.Drawing.Size(185, 29);
            this.init.Style = Sunny.UI.UIStyle.Custom;
            this.init.TabIndex = 17;
            // 
            // inc
            // 
            this.inc.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.inc.FillColor = System.Drawing.Color.White;
            this.inc.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.inc.Location = new System.Drawing.Point(582, 179);
            this.inc.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.inc.Maximum = 2147483647D;
            this.inc.Minimum = -2147483648D;
            this.inc.MinimumSize = new System.Drawing.Size(1, 1);
            this.inc.Name = "inc";
            this.inc.Padding = new System.Windows.Forms.Padding(5);
            this.inc.Radius = 10;
            this.inc.Size = new System.Drawing.Size(185, 29);
            this.inc.Style = Sunny.UI.UIStyle.Custom;
            this.inc.TabIndex = 18;
            // 
            // duration
            // 
            this.duration.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.duration.FillColor = System.Drawing.Color.White;
            this.duration.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.duration.Location = new System.Drawing.Point(582, 313);
            this.duration.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.duration.Maximum = 2147483647D;
            this.duration.Minimum = -2147483648D;
            this.duration.MinimumSize = new System.Drawing.Size(1, 1);
            this.duration.Name = "duration";
            this.duration.Padding = new System.Windows.Forms.Padding(5);
            this.duration.Radius = 10;
            this.duration.Size = new System.Drawing.Size(185, 29);
            this.duration.Style = Sunny.UI.UIStyle.Custom;
            this.duration.TabIndex = 18;
            // 
            // uiTitlePanel1
            // 
            this.uiTitlePanel1.Controls.Add(this.uiLinkLabel1);
            this.uiTitlePanel1.Controls.Add(this.res);
            this.uiTitlePanel1.Controls.Add(this.uiSymbolLabel2);
            this.uiTitlePanel1.Controls.Add(this.uiSymbolButton4);
            this.uiTitlePanel1.Controls.Add(this.uiSymbolLabel1);
            this.uiTitlePanel1.Controls.Add(this.uiSymbolButton3);
            this.uiTitlePanel1.Controls.Add(this.uiSymbolButton2);
            this.uiTitlePanel1.Controls.Add(this.inlabelxx);
            this.uiTitlePanel1.Controls.Add(this.uiSymbolButton1);
            this.uiTitlePanel1.Controls.Add(this.uiPanel1);
            this.uiTitlePanel1.Controls.Add(this.inc);
            this.uiTitlePanel1.Controls.Add(this.init);
            this.uiTitlePanel1.Controls.Add(this.duration);
            this.uiTitlePanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiTitlePanel1.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiTitlePanel1.ForeColor = System.Drawing.Color.White;
            this.uiTitlePanel1.Location = new System.Drawing.Point(0, 0);
            this.uiTitlePanel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiTitlePanel1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiTitlePanel1.Name = "uiTitlePanel1";
            this.uiTitlePanel1.Padding = new System.Windows.Forms.Padding(0, 35, 0, 0);
            this.uiTitlePanel1.Radius = 10;
            this.uiTitlePanel1.RectColor = System.Drawing.Color.CornflowerBlue;
            this.uiTitlePanel1.Size = new System.Drawing.Size(801, 514);
            this.uiTitlePanel1.Style = Sunny.UI.UIStyle.Custom;
            this.uiTitlePanel1.TabIndex = 19;
            this.uiTitlePanel1.Text = "EXPAPP";
            this.uiTitlePanel1.Click += new System.EventHandler(this.UiTitlePanel1_Click);
            // 
            // uiLinkLabel1
            // 
            this.uiLinkLabel1.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(155)))), ((int)(((byte)(40)))));
            this.uiLinkLabel1.BackColor = System.Drawing.Color.Transparent;
            this.uiLinkLabel1.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiLinkLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLinkLabel1.LinkBehavior = System.Windows.Forms.LinkBehavior.AlwaysUnderline;
            this.uiLinkLabel1.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLinkLabel1.Location = new System.Drawing.Point(747, 493);
            this.uiLinkLabel1.Name = "uiLinkLabel1";
            this.uiLinkLabel1.Size = new System.Drawing.Size(66, 23);
            this.uiLinkLabel1.Style = Sunny.UI.UIStyle.Custom;
            this.uiLinkLabel1.TabIndex = 28;
            this.uiLinkLabel1.TabStop = true;
            this.uiLinkLabel1.Text = "Crybik";
            this.uiLinkLabel1.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.uiLinkLabel1.Click += new System.EventHandler(this.UiLinkLabel1_Click);
            // 
            // res
            // 
            this.res.AutoSize = true;
            this.res.BackColor = System.Drawing.Color.Transparent;
            this.res.Font = new System.Drawing.Font("Yu Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.res.ForeColor = System.Drawing.Color.Maroon;
            this.res.Location = new System.Drawing.Point(473, 403);
            this.res.Name = "res";
            this.res.Size = new System.Drawing.Size(196, 35);
            this.res.TabIndex = 8;
            this.res.Text = "The result is : ";
            // 
            // uiSymbolLabel2
            // 
            this.uiSymbolLabel2.BackColor = System.Drawing.Color.Transparent;
            this.uiSymbolLabel2.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiSymbolLabel2.Location = new System.Drawing.Point(387, 313);
            this.uiSymbolLabel2.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolLabel2.Name = "uiSymbolLabel2";
            this.uiSymbolLabel2.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.uiSymbolLabel2.Size = new System.Drawing.Size(157, 29);
            this.uiSymbolLabel2.Style = Sunny.UI.UIStyle.Custom;
            this.uiSymbolLabel2.Symbol = 62036;
            this.uiSymbolLabel2.TabIndex = 27;
            this.uiSymbolLabel2.Text = "Time : ";
            // 
            // uiSymbolButton4
            // 
            this.uiSymbolButton4.BackColor = System.Drawing.Color.Transparent;
            this.uiSymbolButton4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiSymbolButton4.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.uiSymbolButton4.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(160)))), ((int)(((byte)(165)))));
            this.uiSymbolButton4.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(123)))), ((int)(((byte)(129)))));
            this.uiSymbolButton4.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(123)))), ((int)(((byte)(129)))));
            this.uiSymbolButton4.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiSymbolButton4.Location = new System.Drawing.Point(650, 5);
            this.uiSymbolButton4.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolButton4.Name = "uiSymbolButton4";
            this.uiSymbolButton4.Radius = 8;
            this.uiSymbolButton4.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.uiSymbolButton4.RectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(160)))), ((int)(((byte)(165)))));
            this.uiSymbolButton4.RectPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(123)))), ((int)(((byte)(129)))));
            this.uiSymbolButton4.RectSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(123)))), ((int)(((byte)(129)))));
            this.uiSymbolButton4.Size = new System.Drawing.Size(25, 25);
            this.uiSymbolButton4.Style = Sunny.UI.UIStyle.Gray;
            this.uiSymbolButton4.Symbol = 61511;
            this.uiSymbolButton4.TabIndex = 24;
            this.uiSymbolButton4.MouseDown += new System.Windows.Forms.MouseEventHandler(this.UiSymbolButton4_MouseDown);
            this.uiSymbolButton4.MouseMove += new System.Windows.Forms.MouseEventHandler(this.UiSymbolButton4_MouseMove);
            this.uiSymbolButton4.MouseUp += new System.Windows.Forms.MouseEventHandler(this.UiSymbolButton4_MouseUp);
            // 
            // uiSymbolLabel1
            // 
            this.uiSymbolLabel1.BackColor = System.Drawing.Color.Transparent;
            this.uiSymbolLabel1.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiSymbolLabel1.Location = new System.Drawing.Point(387, 179);
            this.uiSymbolLabel1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolLabel1.Name = "uiSymbolLabel1";
            this.uiSymbolLabel1.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.uiSymbolLabel1.Size = new System.Drawing.Size(157, 29);
            this.uiSymbolLabel1.Style = Sunny.UI.UIStyle.Custom;
            this.uiSymbolLabel1.Symbol = 61543;
            this.uiSymbolLabel1.TabIndex = 26;
            this.uiSymbolLabel1.Text = "Percentage :";
            // 
            // uiSymbolButton3
            // 
            this.uiSymbolButton3.BackColor = System.Drawing.Color.Transparent;
            this.uiSymbolButton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiSymbolButton3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.uiSymbolButton3.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(160)))), ((int)(((byte)(165)))));
            this.uiSymbolButton3.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(123)))), ((int)(((byte)(129)))));
            this.uiSymbolButton3.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(123)))), ((int)(((byte)(129)))));
            this.uiSymbolButton3.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiSymbolButton3.Location = new System.Drawing.Point(690, 5);
            this.uiSymbolButton3.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolButton3.Name = "uiSymbolButton3";
            this.uiSymbolButton3.Radius = 8;
            this.uiSymbolButton3.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.uiSymbolButton3.RectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(160)))), ((int)(((byte)(165)))));
            this.uiSymbolButton3.RectPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(123)))), ((int)(((byte)(129)))));
            this.uiSymbolButton3.RectSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(123)))), ((int)(((byte)(129)))));
            this.uiSymbolButton3.Size = new System.Drawing.Size(25, 25);
            this.uiSymbolButton3.Style = Sunny.UI.UIStyle.Gray;
            this.uiSymbolButton3.Symbol = 62161;
            this.uiSymbolButton3.TabIndex = 23;
            this.uiSymbolButton3.Click += new System.EventHandler(this.UiSymbolButton3_Click);
            // 
            // uiSymbolButton2
            // 
            this.uiSymbolButton2.BackColor = System.Drawing.Color.Transparent;
            this.uiSymbolButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiSymbolButton2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.uiSymbolButton2.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(160)))), ((int)(((byte)(165)))));
            this.uiSymbolButton2.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(123)))), ((int)(((byte)(129)))));
            this.uiSymbolButton2.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(123)))), ((int)(((byte)(129)))));
            this.uiSymbolButton2.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiSymbolButton2.Location = new System.Drawing.Point(730, 5);
            this.uiSymbolButton2.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolButton2.Name = "uiSymbolButton2";
            this.uiSymbolButton2.Radius = 8;
            this.uiSymbolButton2.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.uiSymbolButton2.RectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(160)))), ((int)(((byte)(165)))));
            this.uiSymbolButton2.RectPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(123)))), ((int)(((byte)(129)))));
            this.uiSymbolButton2.RectSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(123)))), ((int)(((byte)(129)))));
            this.uiSymbolButton2.Size = new System.Drawing.Size(25, 25);
            this.uiSymbolButton2.Style = Sunny.UI.UIStyle.Gray;
            this.uiSymbolButton2.Symbol = 62160;
            this.uiSymbolButton2.TabIndex = 22;
            this.uiSymbolButton2.Click += new System.EventHandler(this.UiSymbolButton2_Click);
            // 
            // inlabelxx
            // 
            this.inlabelxx.BackColor = System.Drawing.Color.Transparent;
            this.inlabelxx.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inlabelxx.Location = new System.Drawing.Point(387, 62);
            this.inlabelxx.MinimumSize = new System.Drawing.Size(1, 1);
            this.inlabelxx.Name = "inlabelxx";
            this.inlabelxx.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.inlabelxx.Size = new System.Drawing.Size(173, 29);
            this.inlabelxx.Style = Sunny.UI.UIStyle.Custom;
            this.inlabelxx.Symbol = 57587;
            this.inlabelxx.TabIndex = 25;
            this.inlabelxx.Text = "Initial number :";
            // 
            // uiSymbolButton1
            // 
            this.uiSymbolButton1.BackColor = System.Drawing.Color.Transparent;
            this.uiSymbolButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiSymbolButton1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.uiSymbolButton1.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(127)))), ((int)(((byte)(128)))));
            this.uiSymbolButton1.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(87)))), ((int)(((byte)(89)))));
            this.uiSymbolButton1.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(87)))), ((int)(((byte)(89)))));
            this.uiSymbolButton1.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiSymbolButton1.Location = new System.Drawing.Point(770, 5);
            this.uiSymbolButton1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolButton1.Name = "uiSymbolButton1";
            this.uiSymbolButton1.Radius = 8;
            this.uiSymbolButton1.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.uiSymbolButton1.RectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(127)))), ((int)(((byte)(128)))));
            this.uiSymbolButton1.RectPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(87)))), ((int)(((byte)(89)))));
            this.uiSymbolButton1.RectSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(87)))), ((int)(((byte)(89)))));
            this.uiSymbolButton1.Size = new System.Drawing.Size(25, 25);
            this.uiSymbolButton1.Style = Sunny.UI.UIStyle.Red;
            this.uiSymbolButton1.Symbol = 61453;
            this.uiSymbolButton1.TabIndex = 21;
            this.uiSymbolButton1.Click += new System.EventHandler(this.UiSymbolButton1_Click);
            // 
            // uiPanel1
            // 
            this.uiPanel1.Controls.Add(this.uiRadioButtonGroup2);
            this.uiPanel1.Controls.Add(this.uiRadioButtonGroup1);
            this.uiPanel1.Controls.Add(this.button1);
            this.uiPanel1.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiPanel1.Location = new System.Drawing.Point(-2, 36);
            this.uiPanel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel1.Name = "uiPanel1";
            this.uiPanel1.Size = new System.Drawing.Size(371, 477);
            this.uiPanel1.Style = Sunny.UI.UIStyle.Custom;
            this.uiPanel1.TabIndex = 20;
            this.uiPanel1.Text = null;
            this.uiPanel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.UiPanel1_MouseDown);
            this.uiPanel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.UiPanel1_MouseMove);
            this.uiPanel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.UiPanel1_MouseUp);
            // 
            // uiRadioButtonGroup2
            // 
            this.uiRadioButtonGroup2.Controls.Add(this.reb);
            this.uiRadioButtonGroup2.Controls.Add(this.uiRadioButton4);
            this.uiRadioButtonGroup2.Controls.Add(this.disabledx);
            this.uiRadioButtonGroup2.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiRadioButtonGroup2.Location = new System.Drawing.Point(18, 188);
            this.uiRadioButtonGroup2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiRadioButtonGroup2.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiRadioButtonGroup2.Name = "uiRadioButtonGroup2";
            this.uiRadioButtonGroup2.Padding = new System.Windows.Forms.Padding(0, 32, 0, 0);
            this.uiRadioButtonGroup2.Size = new System.Drawing.Size(289, 125);
            this.uiRadioButtonGroup2.Style = Sunny.UI.UIStyle.Custom;
            this.uiRadioButtonGroup2.TabIndex = 28;
            this.uiRadioButtonGroup2.Text = "Change";
            // 
            // reb
            // 
            this.reb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.reb.FillColor = System.Drawing.Color.White;
            this.reb.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.reb.Location = new System.Drawing.Point(20, 64);
            this.reb.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.reb.Maximum = 2147483647D;
            this.reb.Minimum = -2147483648D;
            this.reb.MinimumSize = new System.Drawing.Size(1, 1);
            this.reb.Name = "reb";
            this.reb.Padding = new System.Windows.Forms.Padding(5);
            this.reb.Radius = 10;
            this.reb.Size = new System.Drawing.Size(75, 29);
            this.reb.Style = Sunny.UI.UIStyle.Custom;
            this.reb.TabIndex = 25;
            this.reb.Text = "0";
            // 
            // uiRadioButton4
            // 
            this.uiRadioButton4.BackColor = System.Drawing.Color.Transparent;
            this.uiRadioButton4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiRadioButton4.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiRadioButton4.Location = new System.Drawing.Point(222, 57);
            this.uiRadioButton4.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiRadioButton4.Name = "uiRadioButton4";
            this.uiRadioButton4.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.uiRadioButton4.RadioButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.uiRadioButton4.Size = new System.Drawing.Size(51, 44);
            this.uiRadioButton4.Style = Sunny.UI.UIStyle.Red;
            this.uiRadioButton4.TabIndex = 27;
            this.uiRadioButton4.Text = "-";
            this.uiRadioButton4.ValueChanged += new Sunny.UI.UIRadioButton.OnValueChanged(this.UiRadioButton4_ValueChanged);
            // 
            // disabledx
            // 
            this.disabledx.BackColor = System.Drawing.Color.Transparent;
            this.disabledx.Cursor = System.Windows.Forms.Cursors.Hand;
            this.disabledx.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.disabledx.Location = new System.Drawing.Point(139, 57);
            this.disabledx.MinimumSize = new System.Drawing.Size(1, 1);
            this.disabledx.Name = "disabledx";
            this.disabledx.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.disabledx.Size = new System.Drawing.Size(51, 44);
            this.disabledx.Style = Sunny.UI.UIStyle.Custom;
            this.disabledx.TabIndex = 26;
            this.disabledx.Text = "+";
            this.disabledx.ValueChanged += new Sunny.UI.UIRadioButton.OnValueChanged(this.UiRadioButton3_ValueChanged);
            // 
            // uiRadioButtonGroup1
            // 
            this.uiRadioButtonGroup1.Controls.Add(this.dradio);
            this.uiRadioButtonGroup1.Controls.Add(this.uiRadioButton1);
            this.uiRadioButtonGroup1.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiRadioButtonGroup1.Location = new System.Drawing.Point(18, 2);
            this.uiRadioButtonGroup1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiRadioButtonGroup1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiRadioButtonGroup1.Name = "uiRadioButtonGroup1";
            this.uiRadioButtonGroup1.Padding = new System.Windows.Forms.Padding(0, 32, 0, 0);
            this.uiRadioButtonGroup1.Size = new System.Drawing.Size(289, 176);
            this.uiRadioButtonGroup1.Style = Sunny.UI.UIStyle.Custom;
            this.uiRadioButtonGroup1.TabIndex = 21;
            this.uiRadioButtonGroup1.Text = "Type";
            // 
            // dradio
            // 
            this.dradio.BackColor = System.Drawing.Color.Transparent;
            this.dradio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dradio.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.dradio.Location = new System.Drawing.Point(20, 122);
            this.dradio.MinimumSize = new System.Drawing.Size(1, 1);
            this.dradio.Name = "dradio";
            this.dradio.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.dradio.Size = new System.Drawing.Size(155, 43);
            this.dradio.Style = Sunny.UI.UIStyle.Custom;
            this.dradio.TabIndex = 1;
            this.dradio.Text = "Decreasment";
            this.dradio.ValueChanged += new Sunny.UI.UIRadioButton.OnValueChanged(this.Dradio_ValueChanged);
            // 
            // uiRadioButton1
            // 
            this.uiRadioButton1.BackColor = System.Drawing.Color.Transparent;
            this.uiRadioButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiRadioButton1.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiRadioButton1.Location = new System.Drawing.Point(20, 38);
            this.uiRadioButton1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiRadioButton1.Name = "uiRadioButton1";
            this.uiRadioButton1.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.uiRadioButton1.Size = new System.Drawing.Size(155, 43);
            this.uiRadioButton1.Style = Sunny.UI.UIStyle.Custom;
            this.uiRadioButton1.TabIndex = 0;
            this.uiRadioButton1.Text = "Increasment";
            this.uiRadioButton1.ValueChanged += new Sunny.UI.UIRadioButton.OnValueChanged(this.UiRadioButton1_ValueChanged);
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(80, 356);
            this.button1.MinimumSize = new System.Drawing.Size(1, 1);
            this.button1.Name = "button1";
            this.button1.Radius = 10;
            this.button1.Size = new System.Drawing.Size(211, 83);
            this.button1.Style = Sunny.UI.UIStyle.Custom;
            this.button1.Symbol = 61781;
            this.button1.TabIndex = 19;
            this.button1.Text = "Calculate";
            this.button1.Click += new System.EventHandler(this.Button1_Click_2);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(801, 514);
            this.Controls.Add(this.uiTitlePanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            this.uiTitlePanel1.ResumeLayout(false);
            this.uiTitlePanel1.PerformLayout();
            this.uiPanel1.ResumeLayout(false);
            this.uiRadioButtonGroup2.ResumeLayout(false);
            this.uiRadioButtonGroup1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Sunny.UI.UITextBox init;
        private Sunny.UI.UITextBox inc;
        private Sunny.UI.UITextBox duration;
        private Sunny.UI.UITitlePanel uiTitlePanel1;
        private Sunny.UI.UISymbolButton uiSymbolButton1;
        private Sunny.UI.UISymbolButton uiSymbolButton3;
        private Sunny.UI.UISymbolButton uiSymbolButton2;
        private Sunny.UI.UISymbolButton uiSymbolButton4;
        private Sunny.UI.UISymbolLabel inlabelxx;
        private Sunny.UI.UISymbolLabel uiSymbolLabel2;
        private Sunny.UI.UISymbolLabel uiSymbolLabel1;
        private Sunny.UI.UIPanel uiPanel1;
        private Sunny.UI.UIRadioButtonGroup uiRadioButtonGroup1;
        private Sunny.UI.UITextBox reb;
        private Sunny.UI.UIRadioButton dradio;
        private Sunny.UI.UIRadioButton uiRadioButton1;
        private Sunny.UI.UISymbolButton button1;
        private Label res;
        private Sunny.UI.UIRadioButton uiRadioButton4;
        private Sunny.UI.UIRadioButton disabledx;
        private Sunny.UI.UIRadioButtonGroup uiRadioButtonGroup2;
        private Sunny.UI.UILinkLabel uiLinkLabel1;
    }

}

