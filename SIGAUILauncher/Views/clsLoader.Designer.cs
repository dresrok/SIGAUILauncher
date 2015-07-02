namespace SIGAUILauncher.Views
{
    partial class clsLoader
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
            this.progressBarLoader = new System.Windows.Forms.ProgressBar();
            this.timerLoader = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // progressBarLoader
            // 
            this.progressBarLoader.Location = new System.Drawing.Point(190, 343);
            this.progressBarLoader.Name = "progressBarLoader";
            this.progressBarLoader.Size = new System.Drawing.Size(173, 23);
            this.progressBarLoader.TabIndex = 0;
            // 
            // timerLoader
            // 
            this.timerLoader.Enabled = true;
            this.timerLoader.Interval = 32;
            this.timerLoader.Tick += new System.EventHandler(this.timerLoader_Tick);
            // 
            // clsLoader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SIGAUILauncher.Properties.Resources.FondoLoader;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(542, 370);
            this.Controls.Add(this.progressBarLoader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "clsLoader";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Loader";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ProgressBar progressBarLoader;
        private System.Windows.Forms.Timer timerLoader;
    }
}