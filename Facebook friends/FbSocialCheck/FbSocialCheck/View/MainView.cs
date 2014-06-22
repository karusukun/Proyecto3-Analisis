using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Management;
using Facebook;
using System.Threading;
using System.Dynamic;
using FbSocialCheck.Library;

namespace FbSocialCheck.View
{
    public partial class MainView : Form
    {
        private String _access_token;
        private DateTime _fechaAct;
        private Dictionary<string, int> _filterOptionMultiplex;
        private List<string> _refreshList;

        public MainView()
        {
            _refreshList = new List<string>(); 
            _filterOptionMultiplex = new Dictionary<string, int>();

            _filterOptionMultiplex.Add("Year",0);
            _filterOptionMultiplex.Add("Month", 1);
            _filterOptionMultiplex.Add("Week", 2);
            
            _fechaAct = DateTime.Now;
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
                _access_token = url2.Substring(0, url2.IndexOf("&"));

                FacebookClient fb = new FacebookClient(_access_token);
                
                this.btn_filter.Enabled = true;
               
            }
            
        }

        private void evaluateList(object info)
        {

            
            FacebookInfo information = (FacebookInfo)info;
            for (int position = 0; position < information.getConverCount(); position++)
            {
                if (information.getConversations().data[position] != null)
                {
                    //MessageBox.Show("prueba, "+ conversations.data[0].updated_time );
                    string fecha = (string)information.getConversations().data[position].updated_time;
                    string subFecha = fecha.Substring(0, fecha.IndexOf("T"));

                    string[] splitedDate = subFecha.Split('-');

                    //MessageBox.Show("mes: "+ splitedDate[1] );
                    if (int.Parse(splitedDate[information.getOption()]) == information.getEvaluator())
                    {
                        string nameToAdd = information.getConversations().data[position].participants.data[0].name;
                        if (information.getMyName().Equals(nameToAdd))
                            nameToAdd = information.getConversations().data[position].participants.data[1].name;
                        information.getConversations().data[position] = null;
                        _refreshList.Add(nameToAdd);
                    }
                }
            }
        }

        private void btn_filter_Click(object sender, EventArgs e)
        {
            _refreshList.Clear();
            int option = _filterOptionMultiplex[combo_filters.Text];
            FacebookClient fb = new FacebookClient(_access_token);
            dynamic conversations = fb.Get("me/conversations?fields=participants,updated_time");
            dynamic myself = fb.Get("/me");
            string myName = (string) myself.name;
            int conversationCount = (int)conversations.data.Count;
            int evaluator = 0;

            switch (option)
            { 
                case 0:
                    evaluator = _fechaAct.Year;
                    break;
                case 1:
                    evaluator = _fechaAct.Month;
                    break;
                case 2:
                    evaluator = _fechaAct.Day;
                    break;
                default:
                    evaluator = 0;
                    break;
            }

            int coreCount = 0;
            FacebookInfo info = new FacebookInfo(conversationCount,evaluator,option,myName,conversations);

            foreach (var item in new System.Management.ManagementObjectSearcher("Select NumberOfCores from Win32_Processor").Get())
            {
                coreCount += int.Parse(item["NumberOfCores"].ToString());
            }
            Console.WriteLine("Number Of Cores: {0}", coreCount);        

            Thread thread1 = new Thread(this.evaluateList);
            Thread thread2 = new Thread(this.evaluateList);

            thread1.Start(info);
            thread2.Start(info);
                       

        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            
            list_users.Items.Clear();
            for (int position = 0; position < _refreshList.Count; position++)
            {
                this.list_users.Items.Add(_refreshList.ElementAt(position));
            }
        }



       
    }
}
