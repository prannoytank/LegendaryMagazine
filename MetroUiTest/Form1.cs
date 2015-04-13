using MetroFramework.Forms;
using MetroFramework.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using MetroFramework;
using MetroUiTest.classes;
using MetroUiTest.beansClass;
using System.IO;

using System.Diagnostics;

namespace MetroUiTest
{
    public partial class Form1 : MetroForm
    {

        XmlNodeList forecastList;
        
        public Form1()
        {
            InitializeComponent();
            //metroProgressSpinner1.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //this.TopMost = true;
            //this.FormBorderStyle = FormBorderStyle.None;
           // this.WindowState = FormWindowState.Normal;
            feedSpinner.Hide();
            
            //metroGrid1.Refresh();
            metroTabControl1.SelectTab("tabWeather");
            metroTile1.TileImage = ((System.Drawing.Bitmap)(Properties.Resources.sunny));
            metroTile2.TileImage = ((System.Drawing.Bitmap)(Properties.Resources.windchill));
            metroTile3.TileImage = ((System.Drawing.Bitmap)(Properties.Resources.Humidity_icon));
            pictureBox1.Image = ((System.Drawing.Bitmap)(Properties.Resources.toronto));

            DataGridViewButtonColumn gridButton = new DataGridViewButtonColumn();
            gridButton.FlatStyle = FlatStyle.Flat;
            
            gridButton.Text = "Details";
            gridButton.HeaderText = "View Details";
            gridButton.UseColumnTextForButtonValue = true;
            //gridButton.
            DataGridViewButtonColumn shareButton = new DataGridViewButtonColumn();
            shareButton.FlatStyle = FlatStyle.Flat;
            shareButton.Text = "Tweet";
            shareButton.HeaderText = "Share";
            shareButton.UseColumnTextForButtonValue = true;
            metroGrid1.Columns.Add(gridButton);
            metroGrid1.Columns.Add(shareButton);



            //twitter things

            
            


            getWeather();

           
            
            
          
        }

        private void tabSports_Click(object sender, EventArgs e)
        {

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            MetroFramework.MetroMessageBox.Show(this, "Hello World", "Hello");
        }

       

        private void metroTabControl1_TabIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnGetFeed_Click(object sender, EventArgs e)
        {
            //metroGrid1.Rows.Clear();
            //metroGrid1.Refresh();

            
        }
        public async Task ShowListsAsync(int tabId)
        {
            
           
           
            try
            {
                if(tabId == 1)
                await Task.Run(() => populateFeed(1));
                else if(tabId == 2)
                    await Task.Run(() => populateFeed(2));
            }
            catch
            {
                
            }
            finally
            {
                feedSpinner.Hide();
            }
        }

        

        public void populateFeed(int tabSelected)
        {
            MetroButton b1 = new MetroButton();
            
            b1.Text = "View Details";
            List<FeedBean> feedList=null;
            if (tabSelected == 1)
            {
                feedList = getFeed("http://www.ctvnews.ca/rss/ctvnews-ca-top-stories-public-rss-1.822009");
                for (int i = 0; i < feedList.Count; i++)
                {
                    FeedBean fb = new FeedBean();
                    fb = feedList.ElementAt(i);
                    string[] feedData = { (i + 1).ToString(), fb.feedTitle, fb.feedDescription, fb.feedLink };
                    metroGrid1.Invoke((MethodInvoker)(delegate()
                    {
                        metroGrid1.Rows.Add(feedData);
                        
                    }));

                }
            
            
            
            
            }
            if (tabSelected == 2)
            {
                feedList = getFeed("http://www.ctvnews.ca/rss/business/ctv-news-business-headlines-1.867648");
                for (int i = 0; i < feedList.Count; i++)
                {
                    FeedBean fb = new FeedBean();
                    fb = feedList.ElementAt(i);
                    string[] feedData = { (i + 1).ToString(), fb.feedTitle, fb.feedDescription, fb.feedLink };
                    metroGrid1.Invoke((MethodInvoker)(delegate()
                    {
                        metroGrid2.Rows.Add(feedData);
                    }));

                }
            
            
            
            }

           
            feedList.Clear();


        }
        private List<FeedBean> getFeed(string url)
        {

            XmlFetcher xmf = new XmlFetcher();

            List<FeedBean> feedCollection = new List<FeedBean>();

            feedCollection = xmf.fetchFeeds(url);

            return feedCollection;



        }
        private void metroTabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch((sender as TabControl).SelectedIndex){
              case 0:

                    getWeather();
                
                break;
            case 1:
                
                feedSpinner.Show();
                metroGrid1.Rows.Clear();
                ShowListsAsync((sender as TabControl).SelectedIndex);
                break;

                case 2:
                    feedSpinner.Show();
                metroGrid2.Rows.Clear();
                ShowListsAsync((sender as TabControl).SelectedIndex);
                break;
            }
        }
        private async Task getWeather()
        {
            string query = String.Format("http://weather.yahooapis.com/forecastrss?w=4118");
            XmlDocument wData = new XmlDocument();
            wData.Load(query);

            XmlNamespaceManager manager = new XmlNamespaceManager(wData.NameTable);
            manager.AddNamespace("yweather", "http://xml.weather.yahoo.com/ns/rss/1.0");
            XmlNode channel = wData.SelectSingleNode("rss").SelectSingleNode("channel");
            XmlNodeList nodes = wData.SelectNodes("/rss/channel/item/yweather:forecast", manager);

            metroTile1.Invoke((MethodInvoker)(delegate()
                {
                    metroTile1.Text = channel.SelectSingleNode("item").SelectSingleNode("yweather:condition", manager).Attributes["temp"].Value.ToString() + "°F";
                    metroTile2.Text = "Chill : "+channel.SelectSingleNode("yweather:wind", manager).Attributes["chill"].Value;
                    metroTile3.Text = "Humidity : "+channel.SelectSingleNode("yweather:atmosphere", manager).Attributes["humidity"].Value;
                    forecastList = channel.SelectSingleNode("item").SelectNodes("yweather:forecast", manager);
                  // XmlNode n1 = forecastList[0].Attributes["text"].InnerText;

                   

                  // metroTile4.Top = pictureBox1.Size.Height + pictureBox1.Top;
                   //metroTile4.Left = pictureBox1.Left;
                   metroTile4.Text = getForecastText(0);
                   metroTile5.Text = getForecastText(1);
                   metroTile6.Text = getForecastText(2);
                   metroTile7.Text = getForecastText(3);
                   metroTile8.Text = getForecastText(4);
                   
                   
                     

                    //MetroTile[] forecastTile = new MetroTile[forecastList.Count];
                    
                    //for(int i = 0; i< forecastList.Count ;i++){
                    //  var metroTile  = new MetroTile();
                    //  forecastTile[i] = metroTile;
                    //    metroTile.Name = forecastList[i].Attributes["day"].ToString();
                    //    metroTile.Text = forecastList[i].Attributes["high"].ToString();
                    //    metroTile.Location = new Point(100, 100 + (i * 28));
                    //    metroTile.Visible = true;
                    //    this.Controls.Add(metroTile);
                    //    //this.ResumeLayout(false);
                        
                    //}
                    //this.Refresh();
                    

                   // metroTile4.Text = 
                    //metroTile1.Text = Path.GetFullPath("sunny.png");                
                }));
           
            //Windspeed = channel.SelectSingleNode("yweather:wind", manager).Attributes["speed"].Value;
            //Town = channel.SelectSingleNode("yweather:city", manager).Attributes["city"].Value;
            //TFCond = channel.SelectSingleNode("item").SelectSingleNode("yweather:forecast", manager).Attributes["text"].Value;
            //TFHigh = channel.SelectSingleNode("item").SelectSingleNode("yweather:forecast", manager).Attributes["high"].Value;
            //TFLow = channel.SelectSingleNode("item").SelectSingleNode("yweather:forecast", manager).Attributes["Low"].Value;


        }

        public string getForecastText(int index)
        {
            return forecastList[index].Attributes["day"].Value.ToString() + Environment.NewLine + "High : " + forecastList[index].Attributes["high"].Value.ToString() + "°F" + Environment.NewLine + "Low : " + forecastList[index].Attributes["low"].Value.ToString() + "°F";
        }

        private void metroGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //MessageBox.Show(e.ColumnIndex.ToString());
            if(e.ColumnIndex == 4)
            {
                string linkUrl = metroGrid1.Rows[e.RowIndex].Cells[3].Value.ToString();
               // MessageBox.Show(linkUrl);
                //Process.Start(linkUrl);
                
                web form = new web(linkUrl);
                form.ShowDialog();
                
            }
            if (e.ColumnIndex == 5)
            {
                string linkUrl = metroGrid1.Rows[e.RowIndex].Cells[3].Value.ToString();
                TweeterInput form = new TweeterInput(linkUrl);
                form.ShowDialog();
               
            }
        }

        private void tabTopNews_Click(object sender, EventArgs e)
        {

        }

        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            forecastPanel.Top = pictureBox1.Size.Height + pictureBox1.Top + pictureBox1.Top;
            forecastPanel.Left = (this.ClientSize.Width - forecastPanel.Width) / 2; 
        }
        


    }
}
// }

