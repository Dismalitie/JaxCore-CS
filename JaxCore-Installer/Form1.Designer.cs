namespace JaxCore_Installer
{
    partial class Installer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Installer));
            this.eli = new Siticone.UI.WinForms.SiticoneElipse(this.components);
            this.splash_shadow = new Siticone.UI.WinForms.SiticoneGradientPanel();
            this.prog_main = new Siticone.UI.WinForms.SiticonePanel();
            this.main_label = new System.Windows.Forms.Label();
            this.prog_modules = new Siticone.UI.WinForms.SiticonePanel();
            this.modules_label = new System.Windows.Forms.Label();
            this.prog_launcher = new Siticone.UI.WinForms.SiticonePanel();
            this.launcher_label = new System.Windows.Forms.Label();
            this.launcher_prog = new System.Windows.Forms.PictureBox();
            this.mod_prog = new System.Windows.Forms.PictureBox();
            this.main_prog = new System.Windows.Forms.PictureBox();
            this.cls = new System.Windows.Forms.PictureBox();
            this.splash = new System.Windows.Forms.PictureBox();
            this.ico = new System.Windows.Forms.PictureBox();
            this.install = new Siticone.UI.WinForms.SiticoneGradientButton();
            this.drag = new Siticone.UI.WinForms.SiticoneDragControl(this.components);
            this.splash_shadow.SuspendLayout();
            this.prog_main.SuspendLayout();
            this.prog_modules.SuspendLayout();
            this.prog_launcher.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.launcher_prog)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mod_prog)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.main_prog)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cls)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splash)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ico)).BeginInit();
            this.SuspendLayout();
            // 
            // eli
            // 
            this.eli.BorderRadius = 15;
            this.eli.TargetControl = this;
            // 
            // splash_shadow
            // 
            this.splash_shadow.BackColor = System.Drawing.Color.Transparent;
            this.splash_shadow.Controls.Add(this.install);
            this.splash_shadow.FillColor = System.Drawing.Color.Transparent;
            this.splash_shadow.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.splash_shadow.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.splash_shadow.Location = new System.Drawing.Point(-5, 337);
            this.splash_shadow.Name = "splash_shadow";
            this.splash_shadow.ShadowDecoration.Parent = this.splash_shadow;
            this.splash_shadow.Size = new System.Drawing.Size(326, 113);
            this.splash_shadow.TabIndex = 2;
            this.splash_shadow.UseTransparentBackground = true;
            // 
            // prog_main
            // 
            this.prog_main.BackColor = System.Drawing.Color.Transparent;
            this.prog_main.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.prog_main.BorderRadius = 10;
            this.prog_main.BorderThickness = 1;
            this.prog_main.Controls.Add(this.main_label);
            this.prog_main.Controls.Add(this.main_prog);
            this.prog_main.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.prog_main.Location = new System.Drawing.Point(12, 142);
            this.prog_main.Name = "prog_main";
            this.prog_main.ShadowDecoration.Parent = this.prog_main;
            this.prog_main.Size = new System.Drawing.Size(293, 50);
            this.prog_main.TabIndex = 4;
            // 
            // main_label
            // 
            this.main_label.AutoSize = true;
            this.main_label.BackColor = System.Drawing.Color.Transparent;
            this.main_label.Font = new System.Drawing.Font("Segoe UI Variable Display", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.main_label.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.main_label.Location = new System.Drawing.Point(8, 12);
            this.main_label.Name = "main_label";
            this.main_label.Size = new System.Drawing.Size(56, 26);
            this.main_label.TabIndex = 6;
            this.main_label.Text = "Core";
            // 
            // prog_modules
            // 
            this.prog_modules.BackColor = System.Drawing.Color.Transparent;
            this.prog_modules.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.prog_modules.BorderRadius = 10;
            this.prog_modules.BorderThickness = 1;
            this.prog_modules.Controls.Add(this.modules_label);
            this.prog_modules.Controls.Add(this.mod_prog);
            this.prog_modules.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.prog_modules.Location = new System.Drawing.Point(12, 198);
            this.prog_modules.Name = "prog_modules";
            this.prog_modules.ShadowDecoration.Parent = this.prog_modules;
            this.prog_modules.Size = new System.Drawing.Size(293, 50);
            this.prog_modules.TabIndex = 7;
            // 
            // modules_label
            // 
            this.modules_label.AutoSize = true;
            this.modules_label.BackColor = System.Drawing.Color.Transparent;
            this.modules_label.Font = new System.Drawing.Font("Segoe UI Variable Display", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modules_label.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.modules_label.Location = new System.Drawing.Point(8, 12);
            this.modules_label.Name = "modules_label";
            this.modules_label.Size = new System.Drawing.Size(89, 26);
            this.modules_label.TabIndex = 6;
            this.modules_label.Text = "Modules";
            // 
            // prog_launcher
            // 
            this.prog_launcher.BackColor = System.Drawing.Color.Transparent;
            this.prog_launcher.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.prog_launcher.BorderRadius = 10;
            this.prog_launcher.BorderThickness = 1;
            this.prog_launcher.Controls.Add(this.launcher_label);
            this.prog_launcher.Controls.Add(this.launcher_prog);
            this.prog_launcher.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.prog_launcher.Location = new System.Drawing.Point(12, 254);
            this.prog_launcher.Name = "prog_launcher";
            this.prog_launcher.ShadowDecoration.Parent = this.prog_launcher;
            this.prog_launcher.Size = new System.Drawing.Size(293, 50);
            this.prog_launcher.TabIndex = 8;
            // 
            // launcher_label
            // 
            this.launcher_label.AutoSize = true;
            this.launcher_label.BackColor = System.Drawing.Color.Transparent;
            this.launcher_label.Font = new System.Drawing.Font("Segoe UI Variable Display", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.launcher_label.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.launcher_label.Location = new System.Drawing.Point(8, 12);
            this.launcher_label.Name = "launcher_label";
            this.launcher_label.Size = new System.Drawing.Size(93, 26);
            this.launcher_label.TabIndex = 6;
            this.launcher_label.Text = "Launcher";
            // 
            // launcher_prog
            // 
            this.launcher_prog.BackColor = System.Drawing.Color.Transparent;
            this.launcher_prog.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("launcher_prog.BackgroundImage")));
            this.launcher_prog.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.launcher_prog.Location = new System.Drawing.Point(249, 3);
            this.launcher_prog.Name = "launcher_prog";
            this.launcher_prog.Size = new System.Drawing.Size(41, 44);
            this.launcher_prog.TabIndex = 5;
            this.launcher_prog.TabStop = false;
            // 
            // mod_prog
            // 
            this.mod_prog.BackColor = System.Drawing.Color.Transparent;
            this.mod_prog.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("mod_prog.BackgroundImage")));
            this.mod_prog.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.mod_prog.Location = new System.Drawing.Point(249, 3);
            this.mod_prog.Name = "mod_prog";
            this.mod_prog.Size = new System.Drawing.Size(41, 44);
            this.mod_prog.TabIndex = 5;
            this.mod_prog.TabStop = false;
            // 
            // main_prog
            // 
            this.main_prog.BackColor = System.Drawing.Color.Transparent;
            this.main_prog.BackgroundImage = global::JaxCore_Installer.Properties.Resources.wait;
            this.main_prog.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.main_prog.Location = new System.Drawing.Point(249, 3);
            this.main_prog.Name = "main_prog";
            this.main_prog.Size = new System.Drawing.Size(41, 44);
            this.main_prog.TabIndex = 5;
            this.main_prog.TabStop = false;
            // 
            // cls
            // 
            this.cls.BackgroundImage = global::JaxCore_Installer.Properties.Resources.x_alt;
            this.cls.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.cls.Location = new System.Drawing.Point(283, 12);
            this.cls.Name = "cls";
            this.cls.Size = new System.Drawing.Size(22, 21);
            this.cls.TabIndex = 3;
            this.cls.TabStop = false;
            this.cls.Click += new System.EventHandler(this.cls_Click);
            // 
            // splash
            // 
            this.splash.BackgroundImage = global::JaxCore_Installer.Properties.Resources.CoreTextureOverlay;
            this.splash.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.splash.Location = new System.Drawing.Point(-5, 258);
            this.splash.Name = "splash";
            this.splash.Size = new System.Drawing.Size(326, 192);
            this.splash.TabIndex = 1;
            this.splash.TabStop = false;
            // 
            // ico
            // 
            this.ico.BackColor = System.Drawing.Color.Transparent;
            this.ico.BackgroundImage = global::JaxCore_Installer.Properties.Resources.JaxCore;
            this.ico.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ico.Location = new System.Drawing.Point(12, 12);
            this.ico.Name = "ico";
            this.ico.Size = new System.Drawing.Size(293, 123);
            this.ico.TabIndex = 0;
            this.ico.TabStop = false;
            // 
            // install
            // 
            this.install.BorderColor = System.Drawing.Color.Transparent;
            this.install.BorderRadius = 10;
            this.install.BorderThickness = 1;
            this.install.CheckedState.Parent = this.install;
            this.install.CustomImages.Parent = this.install;
            this.install.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(183)))), ((int)(((byte)(0)))));
            this.install.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(52)))), ((int)(((byte)(0)))));
            this.install.Font = new System.Drawing.Font("Segoe UI Variable Small Semibol", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.install.ForeColor = System.Drawing.Color.White;
            this.install.HoveredState.BorderColor = System.Drawing.Color.Transparent;
            this.install.HoveredState.CustomBorderColor = System.Drawing.Color.Transparent;
            this.install.HoveredState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(52)))), ((int)(((byte)(0)))));
            this.install.HoveredState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(183)))), ((int)(((byte)(0)))));
            this.install.HoveredState.Parent = this.install;
            this.install.ImageSize = new System.Drawing.Size(30, 30);
            this.install.Location = new System.Drawing.Point(17, 51);
            this.install.Name = "install";
            this.install.ShadowDecoration.Parent = this.install;
            this.install.Size = new System.Drawing.Size(293, 50);
            this.install.TabIndex = 1;
            this.install.Text = "Install";
            this.install.Click += new System.EventHandler(this.install_Click);
            // 
            // drag
            // 
            this.drag.TargetControl = this.ico;
            // 
            // Installer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.ClientSize = new System.Drawing.Size(317, 450);
            this.Controls.Add(this.prog_launcher);
            this.Controls.Add(this.prog_modules);
            this.Controls.Add(this.prog_main);
            this.Controls.Add(this.cls);
            this.Controls.Add(this.splash_shadow);
            this.Controls.Add(this.splash);
            this.Controls.Add(this.ico);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Installer";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Instaler";
            this.TopMost = true;
            this.splash_shadow.ResumeLayout(false);
            this.prog_main.ResumeLayout(false);
            this.prog_main.PerformLayout();
            this.prog_modules.ResumeLayout(false);
            this.prog_modules.PerformLayout();
            this.prog_launcher.ResumeLayout(false);
            this.prog_launcher.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.launcher_prog)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mod_prog)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.main_prog)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cls)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splash)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ico)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Siticone.UI.WinForms.SiticoneElipse eli;
        private System.Windows.Forms.PictureBox ico;
        private System.Windows.Forms.PictureBox splash;
        private Siticone.UI.WinForms.SiticoneGradientPanel splash_shadow;
        private System.Windows.Forms.PictureBox cls;
        private Siticone.UI.WinForms.SiticonePanel prog_main;
        private System.Windows.Forms.PictureBox main_prog;
        private System.Windows.Forms.Label main_label;
        private Siticone.UI.WinForms.SiticonePanel prog_launcher;
        private System.Windows.Forms.Label launcher_label;
        private System.Windows.Forms.PictureBox launcher_prog;
        private Siticone.UI.WinForms.SiticonePanel prog_modules;
        private System.Windows.Forms.Label modules_label;
        private System.Windows.Forms.PictureBox mod_prog;
        private Siticone.UI.WinForms.SiticoneGradientButton install;
        private Siticone.UI.WinForms.SiticoneDragControl drag;
    }
}

