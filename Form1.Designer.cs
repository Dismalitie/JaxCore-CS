namespace JaxCore
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabbar = new Siticone.UI.WinForms.SiticonePanel();
            this.topbar = new Siticone.UI.WinForms.SiticonePanel();
            this.win_eli = new Siticone.UI.WinForms.SiticoneElipse(this.components);
            this.bar_drag = new Siticone.UI.WinForms.SiticoneDragControl(this.components);
            this.cont = new System.Windows.Forms.Panel();
            this.title_drag = new Siticone.UI.WinForms.SiticoneDragControl(this.components);
            this.fd_in = new System.Windows.Forms.Timer(this.components);
            this.fd_out = new System.Windows.Forms.Timer(this.components);
            this.min = new System.Windows.Forms.PictureBox();
            this.cls = new System.Windows.Forms.PictureBox();
            this.icon = new System.Windows.Forms.PictureBox();
            this.inf = new Siticone.UI.WinForms.SiticoneGradientButton();
            this.settings = new Siticone.UI.WinForms.SiticoneGradientButton();
            this.lib = new Siticone.UI.WinForms.SiticoneGradientButton();
            this.shop = new Siticone.UI.WinForms.SiticoneGradientButton();
            this.home = new Siticone.UI.WinForms.SiticoneGradientButton();
            this.tabbar.SuspendLayout();
            this.topbar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.min)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cls)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.icon)).BeginInit();
            this.SuspendLayout();
            // 
            // tabbar
            // 
            this.tabbar.BackColor = System.Drawing.Color.Transparent;
            this.tabbar.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.tabbar.BorderRadius = 10;
            this.tabbar.BorderThickness = 1;
            this.tabbar.Controls.Add(this.inf);
            this.tabbar.Controls.Add(this.settings);
            this.tabbar.Controls.Add(this.lib);
            this.tabbar.Controls.Add(this.shop);
            this.tabbar.Controls.Add(this.home);
            this.tabbar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.tabbar.Location = new System.Drawing.Point(13, 531);
            this.tabbar.Name = "tabbar";
            this.tabbar.ShadowDecoration.Parent = this.tabbar;
            this.tabbar.Size = new System.Drawing.Size(1208, 61);
            this.tabbar.TabIndex = 0;
            // 
            // topbar
            // 
            this.topbar.BackColor = System.Drawing.Color.Transparent;
            this.topbar.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.topbar.BorderRadius = 10;
            this.topbar.BorderThickness = 1;
            this.topbar.Controls.Add(this.min);
            this.topbar.Controls.Add(this.cls);
            this.topbar.Controls.Add(this.icon);
            this.topbar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.topbar.Location = new System.Drawing.Point(-8, -11);
            this.topbar.Name = "topbar";
            this.topbar.ShadowDecoration.Parent = this.topbar;
            this.topbar.Size = new System.Drawing.Size(1254, 40);
            this.topbar.TabIndex = 1;
            // 
            // win_eli
            // 
            this.win_eli.BorderRadius = 15;
            this.win_eli.TargetControl = this;
            // 
            // bar_drag
            // 
            this.bar_drag.TargetControl = this.topbar;
            // 
            // cont
            // 
            this.cont.Location = new System.Drawing.Point(-1, 29);
            this.cont.Name = "cont";
            this.cont.Size = new System.Drawing.Size(1235, 500);
            this.cont.TabIndex = 2;
            // 
            // fd_in
            // 
            this.fd_in.Enabled = true;
            this.fd_in.Interval = 30;
            this.fd_in.Tick += new System.EventHandler(this.fd_in_Tick);
            // 
            // fd_out
            // 
            this.fd_out.Interval = 30;
            this.fd_out.Tick += new System.EventHandler(this.fd_out_Tick);
            // 
            // min
            // 
            this.min.BackgroundImage = global::JaxCore.Properties.Resources.minus;
            this.min.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.min.Location = new System.Drawing.Point(1184, 15);
            this.min.Name = "min";
            this.min.Size = new System.Drawing.Size(20, 20);
            this.min.TabIndex = 3;
            this.min.TabStop = false;
            this.min.Click += new System.EventHandler(this.min_Click);
            this.min.MouseEnter += new System.EventHandler(this.min_MouseEnter);
            this.min.MouseLeave += new System.EventHandler(this.min_MouseLeave);
            // 
            // cls
            // 
            this.cls.BackgroundImage = global::JaxCore.Properties.Resources.x;
            this.cls.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.cls.Location = new System.Drawing.Point(1210, 15);
            this.cls.Name = "cls";
            this.cls.Size = new System.Drawing.Size(20, 20);
            this.cls.TabIndex = 2;
            this.cls.TabStop = false;
            this.cls.Click += new System.EventHandler(this.cls_Click);
            this.cls.MouseEnter += new System.EventHandler(this.cls_MouseEnter);
            this.cls.MouseLeave += new System.EventHandler(this.cls_MouseLeave);
            // 
            // icon
            // 
            this.icon.BackgroundImage = global::JaxCore.Properties.Resources._JaxCore;
            this.icon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.icon.Location = new System.Drawing.Point(20, 15);
            this.icon.Name = "icon";
            this.icon.Size = new System.Drawing.Size(20, 20);
            this.icon.TabIndex = 0;
            this.icon.TabStop = false;
            // 
            // inf
            // 
            this.inf.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.inf.BorderRadius = 10;
            this.inf.BorderThickness = 1;
            this.inf.CheckedState.Parent = this.inf;
            this.inf.CustomImages.Parent = this.inf;
            this.inf.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.inf.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.inf.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.inf.ForeColor = System.Drawing.Color.White;
            this.inf.HoveredState.BorderColor = System.Drawing.Color.Transparent;
            this.inf.HoveredState.CustomBorderColor = System.Drawing.Color.Transparent;
            this.inf.HoveredState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(183)))), ((int)(((byte)(0)))));
            this.inf.HoveredState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(52)))), ((int)(((byte)(0)))));
            this.inf.HoveredState.Parent = this.inf;
            this.inf.Image = global::JaxCore.Properties.Resources.about;
            this.inf.Location = new System.Drawing.Point(1094, 5);
            this.inf.Name = "inf";
            this.inf.ShadowDecoration.Parent = this.inf;
            this.inf.Size = new System.Drawing.Size(50, 50);
            this.inf.TabIndex = 4;
            this.inf.Click += new System.EventHandler(this.inf_Click);
            // 
            // settings
            // 
            this.settings.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.settings.BorderRadius = 10;
            this.settings.BorderThickness = 1;
            this.settings.CheckedState.Parent = this.settings;
            this.settings.CustomImages.Parent = this.settings;
            this.settings.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.settings.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.settings.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.settings.ForeColor = System.Drawing.Color.White;
            this.settings.HoveredState.BorderColor = System.Drawing.Color.Transparent;
            this.settings.HoveredState.CustomBorderColor = System.Drawing.Color.Transparent;
            this.settings.HoveredState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(183)))), ((int)(((byte)(0)))));
            this.settings.HoveredState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(52)))), ((int)(((byte)(0)))));
            this.settings.HoveredState.Parent = this.settings;
            this.settings.Image = global::JaxCore.Properties.Resources.settings;
            this.settings.Location = new System.Drawing.Point(1150, 5);
            this.settings.Name = "settings";
            this.settings.ShadowDecoration.Parent = this.settings;
            this.settings.Size = new System.Drawing.Size(50, 50);
            this.settings.TabIndex = 3;
            // 
            // lib
            // 
            this.lib.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.lib.BorderRadius = 10;
            this.lib.BorderThickness = 1;
            this.lib.CheckedState.Parent = this.lib;
            this.lib.CustomImages.Parent = this.lib;
            this.lib.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.lib.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.lib.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lib.ForeColor = System.Drawing.Color.White;
            this.lib.HoveredState.BorderColor = System.Drawing.Color.Transparent;
            this.lib.HoveredState.CustomBorderColor = System.Drawing.Color.Transparent;
            this.lib.HoveredState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(183)))), ((int)(((byte)(0)))));
            this.lib.HoveredState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(52)))), ((int)(((byte)(0)))));
            this.lib.HoveredState.Parent = this.lib;
            this.lib.Image = global::JaxCore.Properties.Resources.lib;
            this.lib.Location = new System.Drawing.Point(120, 5);
            this.lib.Name = "lib";
            this.lib.ShadowDecoration.Parent = this.lib;
            this.lib.Size = new System.Drawing.Size(50, 50);
            this.lib.TabIndex = 2;
            this.lib.Click += new System.EventHandler(this.lib_Click);
            // 
            // shop
            // 
            this.shop.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.shop.BorderRadius = 10;
            this.shop.BorderThickness = 1;
            this.shop.CheckedState.Parent = this.shop;
            this.shop.CustomImages.Parent = this.shop;
            this.shop.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.shop.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.shop.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.shop.ForeColor = System.Drawing.Color.White;
            this.shop.HoveredState.BorderColor = System.Drawing.Color.Transparent;
            this.shop.HoveredState.CustomBorderColor = System.Drawing.Color.Transparent;
            this.shop.HoveredState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(183)))), ((int)(((byte)(0)))));
            this.shop.HoveredState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(52)))), ((int)(((byte)(0)))));
            this.shop.HoveredState.Parent = this.shop;
            this.shop.Image = global::JaxCore.Properties.Resources.shop;
            this.shop.Location = new System.Drawing.Point(64, 5);
            this.shop.Name = "shop";
            this.shop.ShadowDecoration.Parent = this.shop;
            this.shop.Size = new System.Drawing.Size(50, 50);
            this.shop.TabIndex = 1;
            this.shop.Click += new System.EventHandler(this.shop_Click);
            // 
            // home
            // 
            this.home.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.home.BorderRadius = 10;
            this.home.BorderThickness = 1;
            this.home.CheckedState.Parent = this.home;
            this.home.CustomImages.Parent = this.home;
            this.home.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(183)))), ((int)(((byte)(0)))));
            this.home.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(52)))), ((int)(((byte)(0)))));
            this.home.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.home.ForeColor = System.Drawing.Color.White;
            this.home.HoveredState.BorderColor = System.Drawing.Color.Transparent;
            this.home.HoveredState.CustomBorderColor = System.Drawing.Color.Transparent;
            this.home.HoveredState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(183)))), ((int)(((byte)(0)))));
            this.home.HoveredState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(52)))), ((int)(((byte)(0)))));
            this.home.HoveredState.Parent = this.home;
            this.home.Image = global::JaxCore.Properties.Resources._JaxCore;
            this.home.ImageSize = new System.Drawing.Size(30, 30);
            this.home.Location = new System.Drawing.Point(8, 5);
            this.home.Name = "home";
            this.home.ShadowDecoration.Parent = this.home;
            this.home.Size = new System.Drawing.Size(50, 50);
            this.home.TabIndex = 0;
            this.home.Click += new System.EventHandler(this.home_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.ClientSize = new System.Drawing.Size(1234, 604);
            this.Controls.Add(this.cont);
            this.Controls.Add(this.topbar);
            this.Controls.Add(this.tabbar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Opacity = 0D;
            this.Text = "JaxCore (CS)";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabbar.ResumeLayout(false);
            this.topbar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.min)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cls)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.icon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Siticone.UI.WinForms.SiticonePanel tabbar;
        private Siticone.UI.WinForms.SiticonePanel topbar;
        private Siticone.UI.WinForms.SiticoneElipse win_eli;
        private Siticone.UI.WinForms.SiticoneDragControl bar_drag;
        private System.Windows.Forms.Panel cont;
        private Siticone.UI.WinForms.SiticoneGradientButton home;
        private Siticone.UI.WinForms.SiticoneGradientButton shop;
        private Siticone.UI.WinForms.SiticoneGradientButton settings;
        private Siticone.UI.WinForms.SiticoneGradientButton lib;
        private Siticone.UI.WinForms.SiticoneGradientButton inf;
        private System.Windows.Forms.PictureBox icon;
        private System.Windows.Forms.PictureBox min;
        private System.Windows.Forms.PictureBox cls;
        private Siticone.UI.WinForms.SiticoneDragControl title_drag;
        private System.Windows.Forms.Timer fd_in;
        private System.Windows.Forms.Timer fd_out;
    }
}

