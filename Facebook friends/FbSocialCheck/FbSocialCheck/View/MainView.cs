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
using System.Threading;
using System.Dynamic;

namespace FbSocialCheck.View
{
    public partial class MainView : Form
    {
        public String access_token;
        private DateTime fechaAct;
        private Dictionary<string, int> filterOptionMultiplex;

        public MainView()
        {
            filterOptionMultiplex = new Dictionary<string, int>();

            filterOptionMultiplex.Add("Year",0);
            filterOptionMultiplex.Add("Month", 1);
            filterOptionMultiplex.Add("Week", 2);
            
            fechaAct = DateTime.Now;
            InitializeComponent();
            
            this.combo_filters.Items.Add("Year");
            this.combo_filters.Items.Add("Month");
            this.combo_filters.Items.Add("Week");
            this.btn_filter.Enabled = false;
        }

    

        private void btn_signIn_Click(object sender, EventArgs e)
        {
            String OAuthURL = @"https://www.facebook.com/dialog/oauth?client_id=1434678843460011
                               &redirect_uri=https://www.facebook.com/connect/login_success.html
                              &response_type=token
                              &scope=user_groups,user_status"; 
                              

            this.WebFbLoginBrowser.Navigate(OAuthURL);
        }

        private void WebFbLoginBrowser_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
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

                //MessageBox.Show("ID = " + data.id+ " Nombre "+ data.name);

                
                this.btn_filter.Enabled = true;
               
            }
            
        }

        private void evaluateList(int converCount, dynamic conversations, int option, string myName, int evaluator)
        {
            for (int position = 0; position < converCount; position++)
            {
                //MessageBox.Show("prueba, "+ conversations.data[0].updated_time );
                string fecha = (string)conversations.data[position].updated_time;
                string subFecha = fecha.Substring(0, fecha.IndexOf("T"));

                string[] splitedDate = subFecha.Split('-');

                //MessageBox.Show("mes: "+ splitedDate[1] );
                if (int.Parse(splitedDate[option]) == evaluator && conversations.data[position] != null)
                {
                    string nameToAdd = conversations.data[position].participants.data[0].name;
                    if (myName.Equals(nameToAdd))
                        nameToAdd = conversations.data[position].participants.data[1].name;
                    conversations.data[position] = null;
                    this.list_users.Items.Add(nameToAdd);
                }
            }
        }

        private void btn_filter_Click(object sender, EventArgs e)
        {
            list_users.Items.Clear();   
            int option = filterOptionMultiplex[combo_filters.Text];
            FacebookClient fb = new FacebookClient(access_token);
            dynamic conversations = fb.Get("me/conversations?fields=participants,updated_time");
            dynamic myself = fb.Get("/me");
            string myName = (string) myself.name;
            int conversationCount = (int)conversations.data.Count;
            int evaluator = 0;

            switch (option)
            { 
                case 0:
                    evaluator = fechaAct.Year;
                    break;
                case 1:
                    evaluator = fechaAct.Month;
                    break;
                case 2:
                    evaluator = fechaAct.Day;
                    break;
                default:
                    evaluator = 0;
                    break;
            }
            
            evaluateList(conversationCount, conversations, option, myName, evaluator);
                       

        }



       
    }
}
