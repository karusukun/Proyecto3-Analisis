namespace FbSocialCheck.View
{
    partial class MainView
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
            this.btn_signIn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.WebFbLoginBrowser = new System.Windows.Forms.WebBrowser();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_signIn
            // 
            this.btn_signIn.Location = new System.Drawing.Point(100, 391);
            this.btn_signIn.Name = "btn_signIn";
            this.btn_signIn.Size = new System.Drawing.Size(75, 23);
            this.btn_signIn.TabIndex = 0;
            this.btn_signIn.Text = "Sign in";
            this.btn_signIn.UseVisualStyleBackColor = true;
            this.btn_signIn.Click += new System.EventHandler(this.btn_signIn_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.WebFbLoginBrowser);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(275, 360);
            this.panel1.TabIndex = 1;
            // 
            // WebFbLoginBrowser
            // 
            this.WebFbLoginBrowser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.WebFbLoginBrowser.Location = new System.Drawing.Point(0, 0);
            this.WebFbLoginBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.WebFbLoginBrowser.Name = "WebFbLoginBrowser";
            this.WebFbLoginBrowser.Size = new System.Drawing.Size(275, 360);
            this.WebFbLoginBrowser.TabIndex = 0;
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 440);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_signIn);
            this.Name = "MainView";
            this.Text = "MainView";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_signIn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.WebBrowser WebFbLoginBrowser;

    }
}