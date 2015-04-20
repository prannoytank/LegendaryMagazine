using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TweetSharp;
using System.Windows.Forms;
using MetroFramework;
using System.Configuration;

namespace MetroUiTest
{
    public partial class TweeterInput : MetroForm
    {
        const string _CONSUMERKEY = "OElBs9zUaHw8uYO3yXeFlLlu3";
        const string _CONSUMERSECRET = "LZmsPVMN4wSbsgtpBDDvu6dDKQeUgtqGrfe09m1AfwewskYtEg";
        private TwitterService sv;
        private OAuthRequestToken requst;
        private string Link;
        Uri ur;
        System.Configuration.Configuration config;
        string accessToken = "";
        string accessTokenSecret = "";
        public TweeterInput(string str)
        {
            InitializeComponent();
            //trying to make button trasnparent
            SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            btnTweet.BackColor = Color.Transparent;
            btnVari.BackColor = Color.Transparent;
            Link = str;

        }

        private void TweeterInput_Load(object sender, EventArgs e)
        {
            config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            accessToken = MetroUiTest.Properties.Settings.Default.TwitterAccessToken;
            accessTokenSecret = MetroUiTest.Properties.Settings.Default.TwitterAccessTokenSecret;
            txbTweet.Text = Link;

            sv = new TwitterService(_CONSUMERKEY, _CONSUMERSECRET);
            requst = sv.GetRequestToken();
            ur = sv.GetAuthorizationUri(requst);

            //if (accessToken.ToString() != "?" && accessTokenSecret.ToString() != "?")
            //{
            //    btnTweet.Enabled = true;
            //    btnVari.Enabled = false;
            //    txbVari.Enabled = false;
            //}
            //else
            //{
            //    btnTweet.Enabled = false;
                

            //}

        }

        private void btnTweet_Click(object sender, EventArgs e)
        {
            string verifier = "";
           // if (btnTweet.Enabled == false)
            //{
               
                

               
                verifier = txbVari.Text;
                OAuthAccessToken acc = sv.GetAccessToken(requst, verifier);
                sv.AuthenticateWith(acc.Token, acc.TokenSecret);





                accessToken = acc.Token.ToString();
                accessTokenSecret = acc.TokenSecret.ToString();

              //  MetroUiTest.Properties.Settings.Default.TwitterAccessToken = accessToken;
                //MetroUiTest.Properties.Settings.Default.TwitterAccessTokenSecret = accessTokenSecret;
                //MetroUiTest.Properties.Settings.Default.Save();
            //}
            //else
            //{
                sv.AuthenticateWith(accessToken, accessTokenSecret);
            //}




            TwitterStatus result = sv.SendTweet(new SendTweetOptions { Status = txbTweet.Text });


            DialogResult temp = MetroMessageBox.Show(this, "Thank you for sharing with others", "Tweeted", MessageBoxButtons.OKCancel, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            if (temp == DialogResult.OK)
            {
                this.Dispose();
            }



        }

        private void btnVari_Click(object sender, EventArgs e)
        {
            web form = new web(ur.ToString(),"Twitter Authentication");
            form.ShowDialog();
            btnTweet.Enabled = true;
        }

        private void txbTweet_TextChanged(object sender, EventArgs e)
        {
            lblCount.Text = "Characters left: " + (txbTweet.MaxLength - txbTweet.TextLength).ToString();
        }
    }
}