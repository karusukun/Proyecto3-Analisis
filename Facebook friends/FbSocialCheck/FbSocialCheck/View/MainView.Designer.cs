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
            this.list_users = new System.Windows.Forms.ListBox();
            this.combo_filters = new System.Windows.Forms.ComboBox();
            this.btn_filter = new System.Windows.Forms.Button();
            this.btn_Refresh = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_signIn
            // 
            this.btn_signIn.Location = new System.Drawing.Point(76, 558);
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
            this.panel1.Size = new System.Drawing.Size(909, 530);
            this.panel1.TabIndex = 1;
            // 
            // WebFbLoginBrowser
            // 
            this.WebFbLoginBrowser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.WebFbLoginBrowser.Location = new System.Drawing.Point(0, 0);
            this.WebFbLoginBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.WebFbLoginBrowser.Name = "WebFbLoginBrowser";
            this.WebFbLoginBrowser.Size = new System.Drawing.Size(909, 530);
            this.WebFbLoginBrowser.TabIndex = 0;
            this.WebFbLoginBrowser.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.WebFbLoginBrowser_DocumentCompleted);
            // 
            // list_users
            // 
            this.list_users.FormattingEnabled = true;
            this.list_users.Location = new System.Drawing.Point(961, 84);
            this.list_users.Name = "list_users";
            this.list_users.Size = new System.Drawing.Size(185, 472);
            this.list_users.TabIndex = 2;
            // 
            // combo_filters
            // 
            this.combo_filters.FormattingEnabled = true;
            this.combo_filters.Location = new System.Drawing.Point(961, 22);
            this.combo_filters.Name = "combo_filters";
            this.combo_filters.Size = new System.Drawing.Size(150, 21);
            this.combo_filters.TabIndex = 3;
            // 
            // btn_filter
            // 
            this.btn_filter.Location = new System.Drawing.Point(961, 49);
            this.btn_filter.Name = "btn_filter";
            this.btn_filter.Size = new System.Drawing.Size(75, 23);
            this.btn_filter.TabIndex = 4;
            this.btn_filter.Text = "Filter";
            this.btn_filter.UseVisualStyleBackColor = true;
            this.btn_filter.Click += new System.EventHandler(this.btn_filter_Click);
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.Location = new System.Drawing.Point(1053, 48);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(75, 23);
            this.btn_Refresh.TabIndex = 5;
            this.btn_Refresh.Text = "Refresh";
            this.btn_Refresh.UseVisualStyleBackColor = true;
            this.btn_Refresh.Click += new System.EventHandler(this.btn_Refresh_Click);
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1158, 625);
            this.Controls.Add(this.btn_Refresh);
            this.Controls.Add(this.btn_filter);
            this.Controls.Add(this.combo_filters);
            this.Controls.Add(this.list_users);
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
        private System.Windows.Forms.ListBox list_users;
        private System.Windows.Forms.ComboBox combo_filters;
        private System.Windows.Forms.Button btn_filter;
        private System.Windows.Forms.Button btn_Refresh;

    }
}