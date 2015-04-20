namespace MetroUiTest
{
    partial class Form1
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.tabWeather = new MetroFramework.Controls.MetroTabPage();
            this.metroTile9 = new MetroFramework.Controls.MetroTile();
            this.guardianTile = new MetroFramework.Controls.MetroTile();
            this.lblForecastPanelHeading = new MetroFramework.Controls.MetroLabel();
            this.cp24Tile = new MetroFramework.Controls.MetroTile();
            this.metroTile7 = new MetroFramework.Controls.MetroTile();
            this.bbcTile = new MetroFramework.Controls.MetroTile();
            this.metroTile8 = new MetroFramework.Controls.MetroTile();
            this.metroTile4 = new MetroFramework.Controls.MetroTile();
            this.metroTile3 = new MetroFramework.Controls.MetroTile();
            this.metroTile6 = new MetroFramework.Controls.MetroTile();
            this.metroTile5 = new MetroFramework.Controls.MetroTile();
            this.metroTile2 = new MetroFramework.Controls.MetroTile();
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            this.tabTopNews = new MetroFramework.Controls.MetroTabPage();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.btnTweet = new MetroFramework.Controls.MetroButton();
            this.btnView = new MetroFramework.Controls.MetroButton();
            this.metroDiscription = new MetroFramework.Controls.MetroLabel();
            this.metroTitle = new MetroFramework.Controls.MetroLabel();
            this.pcbFirst = new System.Windows.Forms.PictureBox();
            this.metroGrid1 = new MetroFramework.Controls.MetroGrid();
            this.SrNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Link = new System.Windows.Forms.DataGridViewLinkColumn();
            this.ImageLink = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabBussiness = new MetroFramework.Controls.MetroTabPage();
            this.pcbSecondB = new System.Windows.Forms.PictureBox();
            this.pcbFirstB = new System.Windows.Forms.PictureBox();
            this.metroGrid2 = new MetroFramework.Controls.MetroGrid();
            this.SrNo1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BussinessTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BussinessDesc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BussinessLink = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.feedSpinner = new MetroFramework.Controls.MetroProgressSpinner();
            this.metroTabControl1.SuspendLayout();
            this.tabWeather.SuspendLayout();
            this.tabTopNews.SuspendLayout();
            this.metroPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbFirst)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).BeginInit();
            this.tabBussiness.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbSecondB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbFirstB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid2)).BeginInit();
            this.SuspendLayout();
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.metroTabControl1.Controls.Add(this.tabWeather);
            this.metroTabControl1.Controls.Add(this.tabTopNews);
            this.metroTabControl1.Controls.Add(this.tabBussiness);
            this.metroTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroTabControl1.Location = new System.Drawing.Point(20, 60);
            this.metroTabControl1.Multiline = true;
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 1;
            this.metroTabControl1.ShowToolTips = true;
            this.metroTabControl1.Size = new System.Drawing.Size(1346, 708);
            this.metroTabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.metroTabControl1.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTabControl1.TabIndex = 0;
            this.metroTabControl1.UseSelectable = true;
            this.metroTabControl1.SelectedIndexChanged += new System.EventHandler(this.metroTabControl1_SelectedIndexChanged);
            this.metroTabControl1.TabIndexChanged += new System.EventHandler(this.metroTabControl1_TabIndexChanged);
            // 
            // tabWeather
            // 
            this.tabWeather.BackgroundImage = global::MetroUiTest.Properties.Resources.toronto_skyline_night_view1;
            this.tabWeather.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabWeather.Controls.Add(this.metroTile9);
            this.tabWeather.Controls.Add(this.guardianTile);
            this.tabWeather.Controls.Add(this.lblForecastPanelHeading);
            this.tabWeather.Controls.Add(this.cp24Tile);
            this.tabWeather.Controls.Add(this.metroTile7);
            this.tabWeather.Controls.Add(this.bbcTile);
            this.tabWeather.Controls.Add(this.metroTile8);
            this.tabWeather.Controls.Add(this.metroTile4);
            this.tabWeather.Controls.Add(this.metroTile3);
            this.tabWeather.Controls.Add(this.metroTile6);
            this.tabWeather.Controls.Add(this.metroTile5);
            this.tabWeather.Controls.Add(this.metroTile2);
            this.tabWeather.Controls.Add(this.metroTile1);
            this.tabWeather.HorizontalScrollbarBarColor = true;
            this.tabWeather.HorizontalScrollbarHighlightOnWheel = false;
            this.tabWeather.HorizontalScrollbarSize = 10;
            this.tabWeather.Location = new System.Drawing.Point(4, 41);
            this.tabWeather.Name = "tabWeather";
            this.tabWeather.Size = new System.Drawing.Size(1338, 663);
            this.tabWeather.Style = MetroFramework.MetroColorStyle.Yellow;
            this.tabWeather.TabIndex = 0;
            this.tabWeather.Text = "Weather";
            this.tabWeather.VerticalScrollbarBarColor = true;
            this.tabWeather.VerticalScrollbarHighlightOnWheel = false;
            this.tabWeather.VerticalScrollbarSize = 10;
            this.tabWeather.Click += new System.EventHandler(this.tabWeather_Click);
            // 
            // metroTile9
            // 
            this.metroTile9.ActiveControl = null;
            this.metroTile9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.metroTile9.Location = new System.Drawing.Point(1026, 495);
            this.metroTile9.Name = "metroTile9";
            this.metroTile9.Size = new System.Drawing.Size(212, 158);
            this.metroTile9.TabIndex = 13;
            this.metroTile9.TileImage = global::MetroUiTest.Properties.Resources.ctvNews;
            this.metroTile9.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile9.UseSelectable = true;
            this.metroTile9.UseTileImage = true;
            // 
            // guardianTile
            // 
            this.guardianTile.ActiveControl = null;
            this.guardianTile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guardianTile.Location = new System.Drawing.Point(1026, 322);
            this.guardianTile.Name = "guardianTile";
            this.guardianTile.Size = new System.Drawing.Size(212, 167);
            this.guardianTile.TabIndex = 12;
            this.guardianTile.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.guardianTile.TileImage = global::MetroUiTest.Properties.Resources.GUARDIAN;
            this.guardianTile.TileImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.guardianTile.UseSelectable = true;
            this.guardianTile.UseTileImage = true;
            // 
            // lblForecastPanelHeading
            // 
            this.lblForecastPanelHeading.AutoSize = true;
            this.lblForecastPanelHeading.BackColor = System.Drawing.Color.Transparent;
            this.lblForecastPanelHeading.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblForecastPanelHeading.Location = new System.Drawing.Point(179, 291);
            this.lblForecastPanelHeading.Name = "lblForecastPanelHeading";
            this.lblForecastPanelHeading.Size = new System.Drawing.Size(190, 25);
            this.lblForecastPanelHeading.TabIndex = 11;
            this.lblForecastPanelHeading.Text = "Forecast for next 5 days";
            // 
            // cp24Tile
            // 
            this.cp24Tile.ActiveControl = null;
            this.cp24Tile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cp24Tile.Location = new System.Drawing.Point(1026, 167);
            this.cp24Tile.Name = "cp24Tile";
            this.cp24Tile.Size = new System.Drawing.Size(212, 149);
            this.cp24Tile.TabIndex = 3;
            this.cp24Tile.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.cp24Tile.TileImage = global::MetroUiTest.Properties.Resources.cp24;
            this.cp24Tile.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cp24Tile.UseSelectable = true;
            this.cp24Tile.UseTileImage = true;
            // 
            // metroTile7
            // 
            this.metroTile7.ActiveControl = null;
            this.metroTile7.Location = new System.Drawing.Point(347, 333);
            this.metroTile7.Name = "metroTile7";
            this.metroTile7.Size = new System.Drawing.Size(103, 92);
            this.metroTile7.TabIndex = 9;
            this.metroTile7.Text = "metroTile7";
            this.metroTile7.UseSelectable = true;
            // 
            // bbcTile
            // 
            this.bbcTile.ActiveControl = null;
            this.bbcTile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bbcTile.BackColor = System.Drawing.Color.Transparent;
            this.bbcTile.Location = new System.Drawing.Point(1026, 15);
            this.bbcTile.Name = "bbcTile";
            this.bbcTile.Size = new System.Drawing.Size(212, 146);
            this.bbcTile.TabIndex = 2;
            this.bbcTile.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.bbcTile.TileImage = global::MetroUiTest.Properties.Resources.bbc_news_logo;
            this.bbcTile.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bbcTile.UseSelectable = true;
            this.bbcTile.UseTileImage = true;
            // 
            // metroTile8
            // 
            this.metroTile8.ActiveControl = null;
            this.metroTile8.Location = new System.Drawing.Point(456, 333);
            this.metroTile8.Name = "metroTile8";
            this.metroTile8.Size = new System.Drawing.Size(102, 92);
            this.metroTile8.TabIndex = 10;
            this.metroTile8.Text = "metroTile8";
            this.metroTile8.UseSelectable = true;
            // 
            // metroTile4
            // 
            this.metroTile4.ActiveControl = null;
            this.metroTile4.BackColor = System.Drawing.SystemColors.Highlight;
            this.metroTile4.Location = new System.Drawing.Point(6, 333);
            this.metroTile4.Name = "metroTile4";
            this.metroTile4.Size = new System.Drawing.Size(105, 92);
            this.metroTile4.TabIndex = 6;
            this.metroTile4.Text = "metroTile4";
            this.metroTile4.UseSelectable = true;
            // 
            // metroTile3
            // 
            this.metroTile3.ActiveControl = null;
            this.metroTile3.Location = new System.Drawing.Point(276, 167);
            this.metroTile3.Name = "metroTile3";
            this.metroTile3.Size = new System.Drawing.Size(110, 94);
            this.metroTile3.TabIndex = 5;
            this.metroTile3.Text = "metroTile3";
            this.metroTile3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.metroTile3.TileImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.metroTile3.TileTextFontSize = MetroFramework.MetroTileTextSize.Small;
            this.metroTile3.UseSelectable = true;
            this.metroTile3.UseTileImage = true;
            // 
            // metroTile6
            // 
            this.metroTile6.ActiveControl = null;
            this.metroTile6.Location = new System.Drawing.Point(233, 333);
            this.metroTile6.Name = "metroTile6";
            this.metroTile6.Size = new System.Drawing.Size(108, 92);
            this.metroTile6.TabIndex = 8;
            this.metroTile6.Text = "metroTile6";
            this.metroTile6.UseSelectable = true;
            // 
            // metroTile5
            // 
            this.metroTile5.ActiveControl = null;
            this.metroTile5.Location = new System.Drawing.Point(117, 333);
            this.metroTile5.Name = "metroTile5";
            this.metroTile5.Size = new System.Drawing.Size(110, 92);
            this.metroTile5.TabIndex = 7;
            this.metroTile5.Text = "metroTile5";
            this.metroTile5.UseSelectable = true;
            // 
            // metroTile2
            // 
            this.metroTile2.ActiveControl = null;
            this.metroTile2.Location = new System.Drawing.Point(179, 167);
            this.metroTile2.Name = "metroTile2";
            this.metroTile2.Size = new System.Drawing.Size(91, 94);
            this.metroTile2.TabIndex = 4;
            this.metroTile2.Text = "metroTile2";
            this.metroTile2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.metroTile2.TileImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.metroTile2.TileTextFontSize = MetroFramework.MetroTileTextSize.Small;
            this.metroTile2.UseSelectable = true;
            this.metroTile2.UseTileImage = true;
            // 
            // metroTile1
            // 
            this.metroTile1.ActiveControl = null;
            this.metroTile1.BackColor = System.Drawing.Color.White;
            this.metroTile1.ForeColor = System.Drawing.Color.Red;
            this.metroTile1.Location = new System.Drawing.Point(179, 15);
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.Size = new System.Drawing.Size(207, 146);
            this.metroTile1.TabIndex = 2;
            this.metroTile1.Text = "metroTile1";
            this.metroTile1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.metroTile1.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTile1.TileImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.metroTile1.TileTextFontSize = MetroFramework.MetroTileTextSize.Small;
            this.metroTile1.UseSelectable = true;
            this.metroTile1.UseTileImage = true;
            // 
            // tabTopNews
            // 
            this.tabTopNews.BackColor = System.Drawing.Color.Black;
            this.tabTopNews.Controls.Add(this.metroPanel1);
            this.tabTopNews.Controls.Add(this.metroGrid1);
            this.tabTopNews.HorizontalScrollbar = true;
            this.tabTopNews.HorizontalScrollbarBarColor = true;
            this.tabTopNews.HorizontalScrollbarHighlightOnWheel = false;
            this.tabTopNews.HorizontalScrollbarSize = 10;
            this.tabTopNews.Location = new System.Drawing.Point(4, 41);
            this.tabTopNews.Name = "tabTopNews";
            this.tabTopNews.Size = new System.Drawing.Size(1338, 663);
            this.tabTopNews.TabIndex = 1;
            this.tabTopNews.Text = "Top News";
            this.tabTopNews.VerticalScrollbar = true;
            this.tabTopNews.VerticalScrollbarBarColor = true;
            this.tabTopNews.VerticalScrollbarHighlightOnWheel = false;
            this.tabTopNews.VerticalScrollbarSize = 10;
            this.tabTopNews.Click += new System.EventHandler(this.tabTopNews_Click);
            // 
            // metroPanel1
            // 
            this.metroPanel1.BackColor = System.Drawing.Color.Blue;
            this.metroPanel1.Controls.Add(this.btnTweet);
            this.metroPanel1.Controls.Add(this.btnView);
            this.metroPanel1.Controls.Add(this.metroDiscription);
            this.metroPanel1.Controls.Add(this.metroTitle);
            this.metroPanel1.Controls.Add(this.pcbFirst);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(-4, 366);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(1343, 294);
            this.metroPanel1.Style = MetroFramework.MetroColorStyle.Teal;
            this.metroPanel1.TabIndex = 5;
            this.metroPanel1.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroPanel1.UseStyleColors = true;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // btnTweet
            // 
            this.btnTweet.Location = new System.Drawing.Point(426, 192);
            this.btnTweet.Name = "btnTweet";
            this.btnTweet.Size = new System.Drawing.Size(127, 48);
            this.btnTweet.TabIndex = 6;
            this.btnTweet.Text = "Share on Twitter";
            this.btnTweet.UseSelectable = true;
            this.btnTweet.Click += new System.EventHandler(this.btnTweet_Click);
            // 
            // btnView
            // 
            this.btnView.Location = new System.Drawing.Point(280, 192);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(129, 48);
            this.btnView.TabIndex = 5;
            this.btnView.Text = "Go to Link";
            this.btnView.UseSelectable = true;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // metroDiscription
            // 
            this.metroDiscription.AutoSize = true;
            this.metroDiscription.Location = new System.Drawing.Point(290, 36);
            this.metroDiscription.Name = "metroDiscription";
            this.metroDiscription.Size = new System.Drawing.Size(83, 19);
            this.metroDiscription.TabIndex = 4;
            this.metroDiscription.Text = "metroLabel1";
            // 
            // metroTitle
            // 
            this.metroTitle.AutoSize = true;
            this.metroTitle.BackColor = System.Drawing.Color.Transparent;
            this.metroTitle.Location = new System.Drawing.Point(290, 3);
            this.metroTitle.Name = "metroTitle";
            this.metroTitle.Size = new System.Drawing.Size(83, 19);
            this.metroTitle.TabIndex = 3;
            this.metroTitle.Text = "metroLabel1";
            this.metroTitle.UseCustomBackColor = true;
            this.metroTitle.UseCustomForeColor = true;
            this.metroTitle.UseStyleColors = true;
            // 
            // pcbFirst
            // 
            this.pcbFirst.Location = new System.Drawing.Point(4, 3);
            this.pcbFirst.Name = "pcbFirst";
            this.pcbFirst.Size = new System.Drawing.Size(270, 237);
            this.pcbFirst.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbFirst.TabIndex = 3;
            this.pcbFirst.TabStop = false;
            // 
            // metroGrid1
            // 
            this.metroGrid1.AllowUserToAddRows = false;
            this.metroGrid1.AllowUserToDeleteRows = false;
            this.metroGrid1.AllowUserToResizeRows = false;
            this.metroGrid1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.metroGrid1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.metroGrid1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.metroGrid1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.metroGrid1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(188)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(188)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.metroGrid1.ColumnHeadersHeight = 30;
            this.metroGrid1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SrNo,
            this.Title,
            this.Description,
            this.Link,
            this.ImageLink});
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(188)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.metroGrid1.DefaultCellStyle = dataGridViewCellStyle9;
            this.metroGrid1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroGrid1.EnableHeadersVisualStyles = false;
            this.metroGrid1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.metroGrid1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.metroGrid1.Location = new System.Drawing.Point(0, 0);
            this.metroGrid1.MultiSelect = false;
            this.metroGrid1.Name = "metroGrid1";
            this.metroGrid1.ReadOnly = true;
            this.metroGrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(188)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle10.Padding = new System.Windows.Forms.Padding(10);
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(188)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid1.RowHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.metroGrid1.RowHeadersVisible = false;
            this.metroGrid1.RowHeadersWidth = 50;
            this.metroGrid1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.Black;
            this.metroGrid1.RowsDefaultCellStyle = dataGridViewCellStyle11;
            this.metroGrid1.RowTemplate.Height = 30;
            this.metroGrid1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.metroGrid1.Size = new System.Drawing.Size(1338, 663);
            this.metroGrid1.StandardTab = true;
            this.metroGrid1.Style = MetroFramework.MetroColorStyle.Lime;
            this.metroGrid1.TabIndex = 2;
            this.metroGrid1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroGrid1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.metroGrid1_CellContentClick);
            this.metroGrid1.RowLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.metroGrid1_RowLeave);
            this.metroGrid1.SelectionChanged += new System.EventHandler(this.metroGrid1_SelectionChanged);
            // 
            // SrNo
            // 
            this.SrNo.HeaderText = "No#";
            this.SrNo.Name = "SrNo";
            this.SrNo.ReadOnly = true;
            // 
            // Title
            // 
            this.Title.HeaderText = "Title";
            this.Title.Name = "Title";
            this.Title.ReadOnly = true;
            // 
            // Description
            // 
            this.Description.HeaderText = "Description";
            this.Description.Name = "Description";
            this.Description.ReadOnly = true;
            // 
            // Link
            // 
            this.Link.HeaderText = "Link";
            this.Link.Name = "Link";
            this.Link.ReadOnly = true;
            // 
            // ImageLink
            // 
            this.ImageLink.HeaderText = "ImageLink";
            this.ImageLink.Name = "ImageLink";
            this.ImageLink.ReadOnly = true;
            this.ImageLink.Visible = false;
            // 
            // tabBussiness
            // 
            this.tabBussiness.Controls.Add(this.pcbSecondB);
            this.tabBussiness.Controls.Add(this.pcbFirstB);
            this.tabBussiness.Controls.Add(this.metroGrid2);
            this.tabBussiness.HorizontalScrollbarBarColor = true;
            this.tabBussiness.HorizontalScrollbarHighlightOnWheel = false;
            this.tabBussiness.HorizontalScrollbarSize = 10;
            this.tabBussiness.Location = new System.Drawing.Point(4, 41);
            this.tabBussiness.Name = "tabBussiness";
            this.tabBussiness.Size = new System.Drawing.Size(1338, 663);
            this.tabBussiness.TabIndex = 2;
            this.tabBussiness.Text = "Bussiness";
            this.tabBussiness.VerticalScrollbarBarColor = true;
            this.tabBussiness.VerticalScrollbarHighlightOnWheel = false;
            this.tabBussiness.VerticalScrollbarSize = 10;
            // 
            // pcbSecondB
            // 
            this.pcbSecondB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pcbSecondB.Location = new System.Drawing.Point(643, 275);
            this.pcbSecondB.Name = "pcbSecondB";
            this.pcbSecondB.Size = new System.Drawing.Size(698, 486);
            this.pcbSecondB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbSecondB.TabIndex = 4;
            this.pcbSecondB.TabStop = false;
            // 
            // pcbFirstB
            // 
            this.pcbFirstB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pcbFirstB.Location = new System.Drawing.Point(3, 275);
            this.pcbFirstB.Name = "pcbFirstB";
            this.pcbFirstB.Size = new System.Drawing.Size(929, 486);
            this.pcbFirstB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbFirstB.TabIndex = 3;
            this.pcbFirstB.TabStop = false;
            // 
            // metroGrid2
            // 
            this.metroGrid2.AllowUserToResizeRows = false;
            this.metroGrid2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.metroGrid2.BackgroundColor = System.Drawing.Color.LightSteelBlue;
            this.metroGrid2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.metroGrid2.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.metroGrid2.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.metroGrid2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.metroGrid2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SrNo1,
            this.BussinessTitle,
            this.BussinessDesc,
            this.BussinessLink});
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.metroGrid2.DefaultCellStyle = dataGridViewCellStyle13;
            this.metroGrid2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroGrid2.EnableHeadersVisualStyles = false;
            this.metroGrid2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.metroGrid2.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid2.Location = new System.Drawing.Point(0, 0);
            this.metroGrid2.Name = "metroGrid2";
            this.metroGrid2.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid2.RowHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.metroGrid2.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.metroGrid2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.metroGrid2.Size = new System.Drawing.Size(1338, 663);
            this.metroGrid2.TabIndex = 2;
            this.metroGrid2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.metroGrid2_CellContentClick);
            // 
            // SrNo1
            // 
            this.SrNo1.HeaderText = "No#";
            this.SrNo1.Name = "SrNo1";
            this.SrNo1.ReadOnly = true;
            // 
            // BussinessTitle
            // 
            this.BussinessTitle.HeaderText = "Title";
            this.BussinessTitle.Name = "BussinessTitle";
            this.BussinessTitle.ReadOnly = true;
            // 
            // BussinessDesc
            // 
            this.BussinessDesc.HeaderText = "Description";
            this.BussinessDesc.Name = "BussinessDesc";
            this.BussinessDesc.ReadOnly = true;
            // 
            // BussinessLink
            // 
            this.BussinessLink.HeaderText = "Link";
            this.BussinessLink.Name = "BussinessLink";
            this.BussinessLink.ReadOnly = true;
            // 
            // feedSpinner
            // 
            this.feedSpinner.Location = new System.Drawing.Point(1075, 33);
            this.feedSpinner.Maximum = 100;
            this.feedSpinner.Name = "feedSpinner";
            this.feedSpinner.Size = new System.Drawing.Size(24, 21);
            this.feedSpinner.TabIndex = 1;
            this.feedSpinner.UseSelectable = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1386, 788);
            this.Controls.Add(this.feedSpinner);
            this.Controls.Add(this.metroTabControl1);
            this.ForeColor = System.Drawing.Color.Red;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultLocation;
            this.Tag = "";
            this.Text = "Legendary Magazine";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.TransparencyKey = System.Drawing.Color.SteelBlue;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.SizeChanged += new System.EventHandler(this.Form1_SizeChanged);
            this.metroTabControl1.ResumeLayout(false);
            this.tabWeather.ResumeLayout(false);
            this.tabWeather.PerformLayout();
            this.tabTopNews.ResumeLayout(false);
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbFirst)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).EndInit();
            this.tabBussiness.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pcbSecondB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbFirstB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroTabPage tabWeather;
        private MetroFramework.Controls.MetroTile metroTile1;
        private MetroFramework.Controls.MetroTabPage tabTopNews;
        private MetroFramework.Controls.MetroGrid metroGrid1;
        private MetroFramework.Controls.MetroProgressSpinner feedSpinner;
        private MetroFramework.Controls.MetroTile metroTile3;
        private MetroFramework.Controls.MetroTile metroTile2;
        private MetroFramework.Controls.MetroTabPage tabBussiness;
        private MetroFramework.Controls.MetroGrid metroGrid2;
        private System.Windows.Forms.DataGridViewTextBoxColumn SrNo1;
        private System.Windows.Forms.DataGridViewTextBoxColumn BussinessTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn BussinessDesc;
        private System.Windows.Forms.DataGridViewTextBoxColumn BussinessLink;
        private MetroFramework.Controls.MetroTile metroTile4;
        private MetroFramework.Controls.MetroTile metroTile7;
        private MetroFramework.Controls.MetroTile metroTile6;
        private MetroFramework.Controls.MetroTile metroTile5;
        private MetroFramework.Controls.MetroTile metroTile8;
        private MetroFramework.Controls.MetroLabel lblForecastPanelHeading;
        private MetroFramework.Controls.MetroTile cp24Tile;
        private MetroFramework.Controls.MetroTile bbcTile;
        private MetroFramework.Controls.MetroTile guardianTile;
        private MetroFramework.Controls.MetroTile metroTile9;
        private System.Windows.Forms.PictureBox pcbFirst;
        private System.Windows.Forms.PictureBox pcbSecondB;
        private System.Windows.Forms.PictureBox pcbFirstB;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroLabel metroTitle;
        private MetroFramework.Controls.MetroLabel metroDiscription;
        private MetroFramework.Controls.MetroButton btnTweet;
        private MetroFramework.Controls.MetroButton btnView;
        private System.Windows.Forms.DataGridViewTextBoxColumn SrNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Title;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewLinkColumn Link;
        private System.Windows.Forms.DataGridViewTextBoxColumn ImageLink;

    }
}

