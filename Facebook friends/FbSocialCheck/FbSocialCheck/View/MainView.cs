using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Facebook;
using System.Dynamic;

namespace FbSocialCheck.View
{
    public partial class MainView : Form
    {
        private const string AppID = "1434678843460011";
        private Uri _loginUrl;
        private const string _extendedPermissions = "user_about_me,publish_stream,offline_access";
        FacebookClient fbClient = new FacebookClient();
        public String access_token;


        public MainView()
        {
            InitializeComponent();
        }

    

        private void btn_signIn_Click(object sender, EventArgs e)
        {
            String OAuthURL = @"https://www.facebook.com/dialog/oauth?client_id=1434678843460011
                              &redirect_uri = https://www.facebook.com/connect/login_success.html
                              &response_type=token
                              &scope= user_groups,user_status";

            this.WebFbLoginBrowser.Navigate(OAuthURL);
        }

        private void WebFacebook_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            if (this.WebFbLoginBrowser.Url.AbsoluteUri.Contains("access_token"))
            {
                string url1 = this.WebFbLoginBrowser.Url.AbsoluteUri;
                string url2 = url1.Substring(url1.IndexOf("access_token") + 13);
                access_token = url2.Substring(0, url2.IndexOf("&"));

                FacebookClient fb = new FacebookClient(access_token);

                dynamic data = fb.Get("/me");

                string ID = data.id;
                string NAME = data.name;
                string imgURL = string.Format("http://graph.facebook.com/{0}/picture&type=normal", ID);

                MessageBox.Show("ID = " + data.id);

            }
            else{
                MessageBox.Show("No shit is happening bro");
            }
        }

    }
}
