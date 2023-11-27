namespace JaxCore
{
    partial class DevTools
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DevTools));
            this.siticoneOSToggleSwith1 = new Siticone.UI.WinForms.SiticoneOSToggleSwith();
            this.SuspendLayout();
            // 
            // siticoneOSToggleSwith1
            // 
            this.siticoneOSToggleSwith1.Location = new System.Drawing.Point(12, 12);
            this.siticoneOSToggleSwith1.Name = "siticoneOSToggleSwith1";
            this.siticoneOSToggleSwith1.Size = new System.Drawing.Size(38, 22);
            this.siticoneOSToggleSwith1.TabIndex = 0;
            this.siticoneOSToggleSwith1.Text = "siticoneOSToggleSwith1";
            // 
            // DevTools
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.siticoneOSToggleSwith1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DevTools";
            this.Text = "DevTools";
            this.ResumeLayout(false);

        }

        #endregion

        private Siticone.UI.WinForms.SiticoneOSToggleSwith siticoneOSToggleSwith1;
    }
}