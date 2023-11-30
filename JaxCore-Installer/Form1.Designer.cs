namespace JaxCore_Installer
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
            this.eli = new Siticone.UI.WinForms.SiticoneElipse(this.components);
            this.splash_shadow = new Siticone.UI.WinForms.SiticoneGradientPanel();
            this.extra = new Siticone.UI.WinForms.SiticonePanel();
            this.extra_label = new System.Windows.Forms.Label();
            this.dependencies = new Siticone.UI.WinForms.SiticonePanel();
            this.dep_label = new System.Windows.Forms.Label();
            this.core = new Siticone.UI.WinForms.SiticonePanel();
            this.core_label = new System.Windows.Forms.Label();
            this.core_ico = new System.Windows.Forms.PictureBox();
            this.core_prog = new System.Windows.Forms.PictureBox();
            this.extra_ico = new System.Windows.Forms.PictureBox();
            this.extra_prog = new System.Windows.Forms.PictureBox();
            this.dep_ico = new System.Windows.Forms.PictureBox();
            this.dep_prog = new System.Windows.Forms.PictureBox();
            this.install = new Siticone.UI.WinForms.SiticoneGradientButton();
            this.select_dir = new Siticone.UI.WinForms.SiticoneGradientButton();
            this.splash = new System.Windows.Forms.PictureBox();
            this.ico = new System.Windows.Forms.PictureBox();
            this.splash_shadow.SuspendLayout();
            this.extra.SuspendLayout();
            this.dependencies.SuspendLayout();
            this.core.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.core_ico)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.core_prog)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.extra_ico)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.extra_prog)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dep_ico)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dep_prog)).BeginInit();
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
            this.splash_shadow.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.splash_shadow.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.splash_shadow.Location = new System.Drawing.Point(-7, 251);
            this.splash_shadow.Name = "splash_shadow";
            this.splash_shadow.ShadowDecoration.Parent = this.splash_shadow;
            this.splash_shadow.Size = new System.Drawing.Size(330, 150);
            this.splash_shadow.TabIndex = 3;
            this.splash_shadow.UseTransparentBackground = true;
            // 
            // extra
            // 
            this.extra.BackColor = System.Drawing.Color.Transparent;
            this.extra.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.extra.BorderRadius = 10;
            this.extra.BorderThickness = 1;
            this.extra.Controls.Add(this.extra_ico);
            this.extra.Controls.Add(this.extra_prog);
            this.extra.Controls.Add(this.extra_label);
            this.extra.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.extra.Location = new System.Drawing.Point(12, 275);
            this.extra.Name = "extra";
            this.extra.ShadowDecoration.Parent = this.extra;
            this.extra.Size = new System.Drawing.Size(287, 55);
            this.extra.TabIndex = 7;
            // 
            // extra_label
            // 
            this.extra_label.AutoSize = true;
            this.extra_label.Font = new System.Drawing.Font("Segoe UI Variable Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.extra_label.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.extra_label.Location = new System.Drawing.Point(42, 16);
            this.extra_label.Name = "extra_label";
            this.extra_label.Size = new System.Drawing.Size(55, 21);
            this.extra_label.TabIndex = 0;
            this.extra_label.Text = "Extras";
            // 
            // dependencies
            // 
            this.dependencies.BackColor = System.Drawing.Color.Transparent;
            this.dependencies.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.dependencies.BorderRadius = 10;
            this.dependencies.BorderThickness = 1;
            this.dependencies.Controls.Add(this.dep_ico);
            this.dependencies.Controls.Add(this.dep_prog);
            this.dependencies.Controls.Add(this.dep_label);
            this.dependencies.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.dependencies.Location = new System.Drawing.Point(13, 153);
            this.dependencies.Name = "dependencies";
            this.dependencies.ShadowDecoration.Parent = this.dependencies;
            this.dependencies.Size = new System.Drawing.Size(287, 55);
            this.dependencies.TabIndex = 1;
            // 
            // dep_label
            // 
            this.dep_label.AutoSize = true;
            this.dep_label.Font = new System.Drawing.Font("Segoe UI Variable Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dep_label.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.dep_label.Location = new System.Drawing.Point(42, 16);
            this.dep_label.Name = "dep_label";
            this.dep_label.Size = new System.Drawing.Size(118, 21);
            this.dep_label.TabIndex = 0;
            this.dep_label.Text = "Dependencies";
            // 
            // core
            // 
            this.core.BackColor = System.Drawing.Color.Transparent;
            this.core.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.core.BorderRadius = 10;
            this.core.BorderThickness = 1;
            this.core.Controls.Add(this.core_ico);
            this.core.Controls.Add(this.core_prog);
            this.core.Controls.Add(this.core_label);
            this.core.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.core.Location = new System.Drawing.Point(12, 214);
            this.core.Name = "core";
            this.core.ShadowDecoration.Parent = this.core;
            this.core.Size = new System.Drawing.Size(287, 55);
            this.core.TabIndex = 6;
            // 
            // core_label
            // 
            this.core_label.AutoSize = true;
            this.core_label.Font = new System.Drawing.Font("Segoe UI Variable Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.core_label.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.core_label.Location = new System.Drawing.Point(42, 16);
            this.core_label.Name = "core_label";
            this.core_label.Size = new System.Drawing.Size(47, 21);
            this.core_label.TabIndex = 0;
            this.core_label.Text = "Core";
            // 
            // core_ico
            // 
            this.core_ico.BackgroundImage = global::JaxCore_Installer.Properties.Resources.core;
            this.core_ico.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.core_ico.Location = new System.Drawing.Point(7, 16);
            this.core_ico.Name = "core_ico";
            this.core_ico.Size = new System.Drawing.Size(29, 21);
            this.core_ico.TabIndex = 7;
            this.core_ico.TabStop = false;
            // 
            // core_prog
            // 
            this.core_prog.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("core_prog.BackgroundImage")));
            this.core_prog.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.core_prog.Location = new System.Drawing.Point(247, 12);
            this.core_prog.Name = "core_prog";
            this.core_prog.Size = new System.Drawing.Size(29, 31);
            this.core_prog.TabIndex = 5;
            this.core_prog.TabStop = false;
            // 
            // extra_ico
            // 
            this.extra_ico.BackgroundImage = global::JaxCore_Installer.Properties.Resources.extras;
            this.extra_ico.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.extra_ico.Location = new System.Drawing.Point(7, 16);
            this.extra_ico.Name = "extra_ico";
            this.extra_ico.Size = new System.Drawing.Size(29, 21);
            this.extra_ico.TabIndex = 8;
            this.extra_ico.TabStop = false;
            // 
            // extra_prog
            // 
            this.extra_prog.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("extra_prog.BackgroundImage")));
            this.extra_prog.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.extra_prog.Location = new System.Drawing.Point(247, 12);
            this.extra_prog.Name = "extra_prog";
            this.extra_prog.Size = new System.Drawing.Size(29, 31);
            this.extra_prog.TabIndex = 5;
            this.extra_prog.TabStop = false;
            // 
            // dep_ico
            // 
            this.dep_ico.BackgroundImage = global::JaxCore_Installer.Properties.Resources.dependencies;
            this.dep_ico.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.dep_ico.Location = new System.Drawing.Point(7, 16);
            this.dep_ico.Name = "dep_ico";
            this.dep_ico.Size = new System.Drawing.Size(29, 21);
            this.dep_ico.TabIndex = 6;
            this.dep_ico.TabStop = false;
            // 
            // dep_prog
            // 
            this.dep_prog.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("dep_prog.BackgroundImage")));
            this.dep_prog.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.dep_prog.Location = new System.Drawing.Point(247, 12);
            this.dep_prog.Name = "dep_prog";
            this.dep_prog.Size = new System.Drawing.Size(29, 31);
            this.dep_prog.TabIndex = 5;
            this.dep_prog.TabStop = false;
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
            this.install.Font = new System.Drawing.Font("Segoe UI Variable Display", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.install.ForeColor = System.Drawing.Color.White;
            this.install.HoveredState.BorderColor = System.Drawing.Color.Transparent;
            this.install.HoveredState.CustomBorderColor = System.Drawing.Color.Transparent;
            this.install.HoveredState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(209)))), ((int)(((byte)(96)))));
            this.install.HoveredState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(209)))), ((int)(((byte)(96)))));
            this.install.HoveredState.Parent = this.install;
            this.install.Image = global::JaxCore_Installer.Properties.Resources.start;
            this.install.Location = new System.Drawing.Point(19, 85);
            this.install.Name = "install";
            this.install.ShadowDecoration.Parent = this.install;
            this.install.Size = new System.Drawing.Size(287, 50);
            this.install.TabIndex = 7;
            this.install.Click += new System.EventHandler(this.install_Click);
            // 
            // select_dir
            // 
            this.select_dir.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.select_dir.BorderRadius = 10;
            this.select_dir.BorderThickness = 1;
            this.select_dir.CheckedState.Parent = this.select_dir;
            this.select_dir.CustomImages.Parent = this.select_dir;
            this.select_dir.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(183)))), ((int)(((byte)(0)))));
            this.select_dir.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(52)))), ((int)(((byte)(0)))));
            this.select_dir.Font = new System.Drawing.Font("Segoe UI Variable Display", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.select_dir.ForeColor = System.Drawing.Color.White;
            this.select_dir.HoveredState.BorderColor = System.Drawing.Color.Transparent;
            this.select_dir.HoveredState.CustomBorderColor = System.Drawing.Color.Transparent;
            this.select_dir.HoveredState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(52)))), ((int)(((byte)(0)))));
            this.select_dir.HoveredState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(183)))), ((int)(((byte)(0)))));
            this.select_dir.HoveredState.Parent = this.select_dir;
            this.select_dir.Image = global::JaxCore_Installer.Properties.Resources.folder_open;
            this.select_dir.Location = new System.Drawing.Point(12, 97);
            this.select_dir.Name = "select_dir";
            this.select_dir.ShadowDecoration.Parent = this.select_dir;
            this.select_dir.Size = new System.Drawing.Size(288, 50);
            this.select_dir.TabIndex = 4;
            this.select_dir.Text = "Where should we install JaxCore?";
            this.select_dir.Click += new System.EventHandler(this.select_dir_Click);
            // 
            // splash
            // 
            this.splash.BackgroundImage = global::JaxCore_Installer.Properties.Resources.CoreTextureOverlay;
            this.splash.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.splash.Location = new System.Drawing.Point(-8, 216);
            this.splash.Name = "splash";
            this.splash.Size = new System.Drawing.Size(321, 185);
            this.splash.TabIndex = 2;
            this.splash.TabStop = false;
            // 
            // ico
            // 
            this.ico.BackgroundImage = global::JaxCore_Installer.Properties.Resources.JaxCore;
            this.ico.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ico.Location = new System.Drawing.Point(13, 13);
            this.ico.Name = "ico";
            this.ico.Size = new System.Drawing.Size(287, 78);
            this.ico.TabIndex = 0;
            this.ico.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.ClientSize = new System.Drawing.Size(312, 399);
            this.Controls.Add(this.core);
            this.Controls.Add(this.extra);
            this.Controls.Add(this.dependencies);
            this.Controls.Add(this.splash_shadow);
            this.Controls.Add(this.select_dir);
            this.Controls.Add(this.splash);
            this.Controls.Add(this.ico);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "JaxCore-CS Installer";
            this.TopMost = true;
            this.splash_shadow.ResumeLayout(false);
            this.extra.ResumeLayout(false);
            this.extra.PerformLayout();
            this.dependencies.ResumeLayout(false);
            this.dependencies.PerformLayout();
            this.core.ResumeLayout(false);
            this.core.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.core_ico)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.core_prog)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.extra_ico)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.extra_prog)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dep_ico)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dep_prog)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splash)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ico)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Siticone.UI.WinForms.SiticoneElipse eli;
        private System.Windows.Forms.PictureBox ico;
        private System.Windows.Forms.PictureBox splash;
        private Siticone.UI.WinForms.SiticoneGradientPanel splash_shadow;
        private Siticone.UI.WinForms.SiticonePanel dependencies;
        private Siticone.UI.WinForms.SiticoneGradientButton select_dir;
        private System.Windows.Forms.Label dep_label;
        private System.Windows.Forms.PictureBox dep_prog;
        private Siticone.UI.WinForms.SiticonePanel core;
        private System.Windows.Forms.PictureBox core_prog;
        private System.Windows.Forms.Label core_label;
        private Siticone.UI.WinForms.SiticonePanel extra;
        private System.Windows.Forms.PictureBox extra_prog;
        private System.Windows.Forms.Label extra_label;
        private Siticone.UI.WinForms.SiticoneGradientButton install;
        private System.Windows.Forms.PictureBox dep_ico;
        private System.Windows.Forms.PictureBox core_ico;
        private System.Windows.Forms.PictureBox extra_ico;
    }
}

