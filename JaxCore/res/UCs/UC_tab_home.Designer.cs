namespace JaxCore.res.UCs
{
    partial class UC_tab_home
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.topbar = new Siticone.UI.WinForms.SiticonePanel();
            this.flyouts_eli = new Siticone.UI.WinForms.SiticoneElipse(this.components);
            this.mixer_eli = new Siticone.UI.WinForms.SiticoneElipse(this.components);
            this.clocks_eli = new Siticone.UI.WinForms.SiticoneElipse(this.components);
            this.valli_eli = new Siticone.UI.WinForms.SiticoneElipse(this.components);
            this.idle_eli = new Siticone.UI.WinForms.SiticoneElipse(this.components);
            this.idle = new Siticone.UI.WinForms.SiticoneButton();
            this.valli = new Siticone.UI.WinForms.SiticoneButton();
            this.clocks = new Siticone.UI.WinForms.SiticoneButton();
            this.mixer = new Siticone.UI.WinForms.SiticoneButton();
            this.flyouts = new Siticone.UI.WinForms.SiticoneButton();
            this.ico = new System.Windows.Forms.PictureBox();
            this.site = new Siticone.UI.WinForms.SiticoneGradientCircleButton();
            this.kofi = new Siticone.UI.WinForms.SiticoneGradientCircleButton();
            this.discord = new Siticone.UI.WinForms.SiticoneGradientCircleButton();
            this.deviant = new Siticone.UI.WinForms.SiticoneGradientCircleButton();
            this.jaxsplash = new System.Windows.Forms.PictureBox();
            this.topbar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ico)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jaxsplash)).BeginInit();
            this.SuspendLayout();
            // 
            // topbar
            // 
            this.topbar.BackColor = System.Drawing.Color.Transparent;
            this.topbar.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.topbar.BorderRadius = 10;
            this.topbar.BorderThickness = 1;
            this.topbar.Controls.Add(this.ico);
            this.topbar.Controls.Add(this.site);
            this.topbar.Controls.Add(this.kofi);
            this.topbar.Controls.Add(this.discord);
            this.topbar.Controls.Add(this.deviant);
            this.topbar.Controls.Add(this.jaxsplash);
            this.topbar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.topbar.Location = new System.Drawing.Point(-10, -10);
            this.topbar.Name = "topbar";
            this.topbar.ShadowDecoration.Parent = this.topbar;
            this.topbar.Size = new System.Drawing.Size(1258, 72);
            this.topbar.TabIndex = 2;
            // 
            // flyouts_eli
            // 
            this.flyouts_eli.BorderRadius = 15;
            this.flyouts_eli.TargetControl = this.flyouts;
            // 
            // mixer_eli
            // 
            this.mixer_eli.BorderRadius = 15;
            this.mixer_eli.TargetControl = this.mixer;
            // 
            // clocks_eli
            // 
            this.clocks_eli.BorderRadius = 15;
            this.clocks_eli.TargetControl = this.clocks;
            // 
            // valli_eli
            // 
            this.valli_eli.BorderRadius = 15;
            this.valli_eli.TargetControl = this.valli;
            // 
            // idle_eli
            // 
            this.idle_eli.BorderRadius = 15;
            this.idle_eli.TargetControl = this.idle;
            // 
            // idle
            // 
            this.idle.BackgroundImage = global::JaxCore.Properties.Resources.idle;
            this.idle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.idle.CheckedState.Parent = this.idle;
            this.idle.CustomImages.Parent = this.idle;
            this.idle.FillColor = System.Drawing.Color.Transparent;
            this.idle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.idle.ForeColor = System.Drawing.Color.White;
            this.idle.HoveredState.Parent = this.idle;
            this.idle.Location = new System.Drawing.Point(810, 285);
            this.idle.Name = "idle";
            this.idle.ShadowDecoration.Parent = this.idle;
            this.idle.Size = new System.Drawing.Size(321, 212);
            this.idle.TabIndex = 8;
            // 
            // valli
            // 
            this.valli.BackgroundImage = global::JaxCore.Properties.Resources.valli;
            this.valli.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.valli.CheckedState.Parent = this.valli;
            this.valli.CustomImages.Parent = this.valli;
            this.valli.FillColor = System.Drawing.Color.Transparent;
            this.valli.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.valli.ForeColor = System.Drawing.Color.White;
            this.valli.HoveredState.Parent = this.valli;
            this.valli.Location = new System.Drawing.Point(453, 285);
            this.valli.Name = "valli";
            this.valli.ShadowDecoration.Parent = this.valli;
            this.valli.Size = new System.Drawing.Size(321, 212);
            this.valli.TabIndex = 7;
            // 
            // clocks
            // 
            this.clocks.BackgroundImage = global::JaxCore.Properties.Resources.mclocks;
            this.clocks.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.clocks.CheckedState.Parent = this.clocks;
            this.clocks.CustomImages.Parent = this.clocks;
            this.clocks.FillColor = System.Drawing.Color.Transparent;
            this.clocks.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.clocks.ForeColor = System.Drawing.Color.White;
            this.clocks.HoveredState.Parent = this.clocks;
            this.clocks.Location = new System.Drawing.Point(94, 285);
            this.clocks.Name = "clocks";
            this.clocks.ShadowDecoration.Parent = this.clocks;
            this.clocks.Size = new System.Drawing.Size(321, 212);
            this.clocks.TabIndex = 6;
            // 
            // mixer
            // 
            this.mixer.BackgroundImage = global::JaxCore.Properties.Resources.mixer;
            this.mixer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.mixer.CheckedState.Parent = this.mixer;
            this.mixer.CustomImages.Parent = this.mixer;
            this.mixer.FillColor = System.Drawing.Color.Transparent;
            this.mixer.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.mixer.ForeColor = System.Drawing.Color.White;
            this.mixer.HoveredState.Parent = this.mixer;
            this.mixer.Location = new System.Drawing.Point(673, 67);
            this.mixer.Name = "mixer";
            this.mixer.ShadowDecoration.Parent = this.mixer;
            this.mixer.Size = new System.Drawing.Size(458, 212);
            this.mixer.TabIndex = 5;
            // 
            // flyouts
            // 
            this.flyouts.BackgroundImage = global::JaxCore.Properties.Resources.flyouts;
            this.flyouts.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.flyouts.CheckedState.Parent = this.flyouts;
            this.flyouts.CustomImages.Parent = this.flyouts;
            this.flyouts.FillColor = System.Drawing.Color.Transparent;
            this.flyouts.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.flyouts.ForeColor = System.Drawing.Color.White;
            this.flyouts.HoveredState.Parent = this.flyouts;
            this.flyouts.Location = new System.Drawing.Point(94, 67);
            this.flyouts.Name = "flyouts";
            this.flyouts.ShadowDecoration.Parent = this.flyouts;
            this.flyouts.Size = new System.Drawing.Size(573, 212);
            this.flyouts.TabIndex = 4;
            // 
            // ico
            // 
            this.ico.BackgroundImage = global::JaxCore.Properties.Resources.JaxCore;
            this.ico.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ico.Location = new System.Drawing.Point(18, 16);
            this.ico.Name = "ico";
            this.ico.Size = new System.Drawing.Size(49, 49);
            this.ico.TabIndex = 8;
            this.ico.TabStop = false;
            // 
            // site
            // 
            this.site.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.site.BorderThickness = 1;
            this.site.CheckedState.Parent = this.site;
            this.site.CustomImages.Parent = this.site;
            this.site.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.site.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.site.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.site.ForeColor = System.Drawing.Color.White;
            this.site.HoveredState.BorderColor = System.Drawing.Color.Transparent;
            this.site.HoveredState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(183)))), ((int)(((byte)(0)))));
            this.site.HoveredState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(52)))), ((int)(((byte)(0)))));
            this.site.HoveredState.Parent = this.site;
            this.site.Image = global::JaxCore.Properties.Resources.HomePage_WebsiteIcon;
            this.site.ImageSize = new System.Drawing.Size(25, 25);
            this.site.Location = new System.Drawing.Point(1078, 16);
            this.site.Name = "site";
            this.site.ShadowDecoration.Mode = Siticone.UI.WinForms.Enums.ShadowMode.Circle;
            this.site.ShadowDecoration.Parent = this.site;
            this.site.Size = new System.Drawing.Size(49, 49);
            this.site.TabIndex = 7;
            this.site.Tile = false;
            this.site.Click += new System.EventHandler(this.site_Click);
            // 
            // kofi
            // 
            this.kofi.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.kofi.BorderThickness = 1;
            this.kofi.CheckedState.Parent = this.kofi;
            this.kofi.CustomImages.Parent = this.kofi;
            this.kofi.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.kofi.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.kofi.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.kofi.ForeColor = System.Drawing.Color.White;
            this.kofi.HoveredState.BorderColor = System.Drawing.Color.Transparent;
            this.kofi.HoveredState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(65)))), ((int)(((byte)(23)))));
            this.kofi.HoveredState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(4)))), ((int)(((byte)(169)))));
            this.kofi.HoveredState.Parent = this.kofi;
            this.kofi.Image = global::JaxCore.Properties.Resources.Donate;
            this.kofi.ImageSize = new System.Drawing.Size(25, 25);
            this.kofi.Location = new System.Drawing.Point(1023, 16);
            this.kofi.Name = "kofi";
            this.kofi.ShadowDecoration.Mode = Siticone.UI.WinForms.Enums.ShadowMode.Circle;
            this.kofi.ShadowDecoration.Parent = this.kofi;
            this.kofi.Size = new System.Drawing.Size(49, 49);
            this.kofi.TabIndex = 6;
            this.kofi.Tile = false;
            this.kofi.Click += new System.EventHandler(this.kofi_Click);
            // 
            // discord
            // 
            this.discord.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.discord.BorderThickness = 1;
            this.discord.CheckedState.Parent = this.discord;
            this.discord.CustomImages.Parent = this.discord;
            this.discord.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.discord.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.discord.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.discord.ForeColor = System.Drawing.Color.White;
            this.discord.HoveredState.BorderColor = System.Drawing.Color.Transparent;
            this.discord.HoveredState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(101)))), ((int)(((byte)(242)))));
            this.discord.HoveredState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(101)))), ((int)(((byte)(242)))));
            this.discord.HoveredState.Parent = this.discord;
            this.discord.Image = global::JaxCore.Properties.Resources.HomePage_DiscordIcon;
            this.discord.ImageSize = new System.Drawing.Size(25, 25);
            this.discord.Location = new System.Drawing.Point(1188, 16);
            this.discord.Name = "discord";
            this.discord.ShadowDecoration.Mode = Siticone.UI.WinForms.Enums.ShadowMode.Circle;
            this.discord.ShadowDecoration.Parent = this.discord;
            this.discord.Size = new System.Drawing.Size(49, 49);
            this.discord.TabIndex = 5;
            this.discord.Tile = false;
            this.discord.Click += new System.EventHandler(this.discord_Click);
            // 
            // deviant
            // 
            this.deviant.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.deviant.BorderThickness = 1;
            this.deviant.CheckedState.Parent = this.deviant;
            this.deviant.CustomImages.Parent = this.deviant;
            this.deviant.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.deviant.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.deviant.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.deviant.ForeColor = System.Drawing.Color.White;
            this.deviant.HoveredState.BorderColor = System.Drawing.Color.Transparent;
            this.deviant.HoveredState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(194)))), ((int)(((byte)(69)))));
            this.deviant.HoveredState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(194)))), ((int)(((byte)(69)))));
            this.deviant.HoveredState.Parent = this.deviant;
            this.deviant.Image = global::JaxCore.Properties.Resources.DA;
            this.deviant.ImageSize = new System.Drawing.Size(25, 25);
            this.deviant.Location = new System.Drawing.Point(1133, 16);
            this.deviant.Name = "deviant";
            this.deviant.ShadowDecoration.Mode = Siticone.UI.WinForms.Enums.ShadowMode.Circle;
            this.deviant.ShadowDecoration.Parent = this.deviant;
            this.deviant.Size = new System.Drawing.Size(49, 49);
            this.deviant.TabIndex = 4;
            this.deviant.Tile = false;
            this.deviant.Click += new System.EventHandler(this.deviant_Click);
            // 
            // jaxsplash
            // 
            this.jaxsplash.BackgroundImage = global::JaxCore.Properties.Resources.jaxsplash;
            this.jaxsplash.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.jaxsplash.Location = new System.Drawing.Point(73, 16);
            this.jaxsplash.Name = "jaxsplash";
            this.jaxsplash.Size = new System.Drawing.Size(143, 49);
            this.jaxsplash.TabIndex = 3;
            this.jaxsplash.TabStop = false;
            this.jaxsplash.Click += new System.EventHandler(this.jaxsplash_Click);
            // 
            // UC_tab_home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.Controls.Add(this.idle);
            this.Controls.Add(this.valli);
            this.Controls.Add(this.clocks);
            this.Controls.Add(this.mixer);
            this.Controls.Add(this.flyouts);
            this.Controls.Add(this.topbar);
            this.Name = "UC_tab_home";
            this.Size = new System.Drawing.Size(1235, 500);
            this.topbar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ico)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jaxsplash)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Siticone.UI.WinForms.SiticonePanel topbar;
        private System.Windows.Forms.PictureBox jaxsplash;
        private Siticone.UI.WinForms.SiticoneButton flyouts;
        private Siticone.UI.WinForms.SiticoneButton mixer;
        private Siticone.UI.WinForms.SiticoneButton clocks;
        private Siticone.UI.WinForms.SiticoneButton valli;
        private Siticone.UI.WinForms.SiticoneButton idle;
        private Siticone.UI.WinForms.SiticoneElipse flyouts_eli;
        private Siticone.UI.WinForms.SiticoneElipse mixer_eli;
        private Siticone.UI.WinForms.SiticoneElipse clocks_eli;
        private Siticone.UI.WinForms.SiticoneElipse valli_eli;
        private Siticone.UI.WinForms.SiticoneElipse idle_eli;
        private Siticone.UI.WinForms.SiticoneGradientCircleButton deviant;
        private Siticone.UI.WinForms.SiticoneGradientCircleButton discord;
        private Siticone.UI.WinForms.SiticoneGradientCircleButton kofi;
        private Siticone.UI.WinForms.SiticoneGradientCircleButton site;
        private System.Windows.Forms.PictureBox ico;
    }
}
