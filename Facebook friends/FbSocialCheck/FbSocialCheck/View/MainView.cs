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



        public MainView()
        {
            InitializeComponent();
            Login();
        }

        public void Login()
        {
            dynamic parameters = new ExpandoObject();
            parameters.client_id = AppID;
            parameters.redirect_uri = "https://www.facebook.com/connect/login_sucess.html";

            parameters.response_type = "token";

            parameters.display = "popup";

            if (!string.IsNullOrWhiteSpace(_extendedPermissions))
            {
                parameters.scope = _extendedPermissions;
            }

            var fb = new FacebookClient();
            _loginUrl = fb.GetLoginUrl(parameters);


            webBrowser1.Navigate(_loginUrl.AbsoluteUri);

        }
    }
}
