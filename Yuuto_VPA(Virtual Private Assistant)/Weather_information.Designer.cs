namespace Yuuto_VPA_Virtual_Private_Assistant_
{
    partial class Weather_information
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Weather_information));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.timeout = new System.Windows.Forms.Timer(this.components);
            this.show = new System.Windows.Forms.Timer(this.components);
            this.close_weather_notify = new System.Windows.Forms.Timer(this.components);
            this.city_name = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.temperature = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.wind_speed = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.country_name = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.thermometer_icon = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.weather_icons = new System.Windows.Forms.ImageList(this.components);
            this.w_icons = new System.Windows.Forms.PictureBox();
            this.date_time_with_weather = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.background = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.thermometer_icon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.w_icons)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this;
            this.bunifuDragControl1.Vertical = true;
            // 
            // timeout
            // 
            this.timeout.Enabled = true;
            this.timeout.Interval = 5000;
            this.timeout.Tick += new System.EventHandler(this.timeout_Tick);
            // 
            // show
            // 
            this.show.Interval = 10;
            this.show.Tick += new System.EventHandler(this.show_Tick);
            // 
            // close_weather_notify
            // 
            this.close_weather_notify.Tick += new System.EventHandler(this.close_weather_notify_Tick);
            // 
            // city_name
            // 
            this.city_name.AutoEllipsis = true;
            this.city_name.AutoSize = true;
            this.city_name.BackColor = System.Drawing.Color.Transparent;
            this.city_name.Cursor = System.Windows.Forms.Cursors.PanSE;
            this.city_name.Font = new System.Drawing.Font("Century Gothic", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.city_name.ForeColor = System.Drawing.Color.White;
            this.city_name.Location = new System.Drawing.Point(9, 39);
            this.city_name.Margin = new System.Windows.Forms.Padding(0);
            this.city_name.Name = "city_name";
            this.city_name.Size = new System.Drawing.Size(224, 78);
            this.city_name.TabIndex = 5;
            this.city_name.Text = "Jaipur";
            this.city_name.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // temperature
            // 
            this.temperature.AutoEllipsis = true;
            this.temperature.AutoSize = true;
            this.temperature.BackColor = System.Drawing.Color.Transparent;
            this.temperature.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.temperature.Font = new System.Drawing.Font("Century Gothic", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.temperature.ForeColor = System.Drawing.Color.White;
            this.temperature.Location = new System.Drawing.Point(56, 257);
            this.temperature.Margin = new System.Windows.Forms.Padding(0);
            this.temperature.Name = "temperature";
            this.temperature.Size = new System.Drawing.Size(173, 78);
            this.temperature.TabIndex = 5;
            this.temperature.Text = "48 C";
            this.temperature.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // wind_speed
            // 
            this.wind_speed.AutoEllipsis = true;
            this.wind_speed.AutoSize = true;
            this.wind_speed.BackColor = System.Drawing.Color.Transparent;
            this.wind_speed.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wind_speed.ForeColor = System.Drawing.Color.White;
            this.wind_speed.Location = new System.Drawing.Point(63, 353);
            this.wind_speed.Name = "wind_speed";
            this.wind_speed.Size = new System.Drawing.Size(68, 32);
            this.wind_speed.TabIndex = 7;
            this.wind_speed.Text = "3.92";
            this.wind_speed.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // country_name
            // 
            this.country_name.AutoSize = true;
            this.country_name.BackColor = System.Drawing.Color.Transparent;
            this.country_name.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.country_name.ForeColor = System.Drawing.Color.White;
            this.country_name.Location = new System.Drawing.Point(229, 351);
            this.country_name.Name = "country_name";
            this.country_name.Size = new System.Drawing.Size(52, 42);
            this.country_name.TabIndex = 9;
            this.country_name.Text = "IN";
            this.country_name.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // thermometer_icon
            // 
            this.thermometer_icon.BackColor = System.Drawing.Color.Transparent;
            this.thermometer_icon.Image = ((System.Drawing.Image)(resources.GetObject("thermometer_icon.Image")));
            this.thermometer_icon.Location = new System.Drawing.Point(26, 279);
            this.thermometer_icon.Name = "thermometer_icon";
            this.thermometer_icon.Size = new System.Drawing.Size(34, 43);
            this.thermometer_icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.thermometer_icon.TabIndex = 10;
            this.thermometer_icon.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(22, 348);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(34, 43);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // weather_icons
            // 
            this.weather_icons.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("weather_icons.ImageStream")));
            this.weather_icons.TransparentColor = System.Drawing.Color.Transparent;
            this.weather_icons.Images.SetKeyName(0, "waves.png");
            this.weather_icons.Images.SetKeyName(1, "rain.png");
            this.weather_icons.Images.SetKeyName(2, "storm.png");
            this.weather_icons.Images.SetKeyName(3, "sun (1).png");
            this.weather_icons.Images.SetKeyName(4, "sun_cloud.png");
            this.weather_icons.Images.SetKeyName(5, "clouds.png");
            this.weather_icons.Images.SetKeyName(6, "lightning.png");
            this.weather_icons.Images.SetKeyName(7, "haze.png");
            this.weather_icons.Images.SetKeyName(8, "cloud.png");
            this.weather_icons.Images.SetKeyName(9, "rain.png");
            this.weather_icons.Images.SetKeyName(10, "cloud-and-moon.png");
            // 
            // w_icons
            // 
            this.w_icons.BackColor = System.Drawing.Color.Transparent;
            this.w_icons.Image = ((System.Drawing.Image)(resources.GetObject("w_icons.Image")));
            this.w_icons.Location = new System.Drawing.Point(147, 342);
            this.w_icons.Name = "w_icons";
            this.w_icons.Size = new System.Drawing.Size(60, 50);
            this.w_icons.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.w_icons.TabIndex = 13;
            this.w_icons.TabStop = false;
            // 
            // date_time_with_weather
            // 
            this.date_time_with_weather.AutoEllipsis = true;
            this.date_time_with_weather.AutoSize = true;
            this.date_time_with_weather.BackColor = System.Drawing.Color.Transparent;
            this.date_time_with_weather.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date_time_with_weather.ForeColor = System.Drawing.Color.White;
            this.date_time_with_weather.Location = new System.Drawing.Point(21, 121);
            this.date_time_with_weather.Margin = new System.Windows.Forms.Padding(0);
            this.date_time_with_weather.Name = "date_time_with_weather";
            this.date_time_with_weather.Size = new System.Drawing.Size(142, 22);
            this.date_time_with_weather.TabIndex = 14;
            this.date_time_with_weather.Text = "date and time";
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(210, 420);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(141, 21);
            this.bunifuCustomLabel1.TabIndex = 15;
            this.bunifuCustomLabel1.Text = "Advance Details";
            this.bunifuCustomLabel1.Click += new System.EventHandler(this.bunifuCustomLabel1_Click);
            // 
            // background
            // 
            this.background.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("background.ImageStream")));
            this.background.TransparentColor = System.Drawing.Color.Transparent;
            this.background.Images.SetKeyName(0, "JaipurNew.jpg");
            this.background.Images.SetKeyName(1, "Tokyo.jpg");
            this.background.Images.SetKeyName(2, "London.jpg");
            // 
            // Weather_information
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RoyalBlue;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(349, 450);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.date_time_with_weather);
            this.Controls.Add(this.w_icons);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.thermometer_icon);
            this.Controls.Add(this.country_name);
            this.Controls.Add(this.wind_speed);
            this.Controls.Add(this.temperature);
            this.Controls.Add(this.city_name);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Weather_information";
            this.Text = "Weather_information";
            this.Load += new System.EventHandler(this.Weather_information_Load);
            ((System.ComponentModel.ISupportInitialize)(this.thermometer_icon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.w_icons)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.Timer timeout;
        private System.Windows.Forms.Timer show;
        private System.Windows.Forms.Timer close_weather_notify;
        private Bunifu.Framework.UI.BunifuCustomLabel wind_speed;
        private Bunifu.Framework.UI.BunifuCustomLabel temperature;
        private Bunifu.Framework.UI.BunifuCustomLabel city_name;
        private Bunifu.Framework.UI.BunifuCustomLabel country_name;
        private System.Windows.Forms.PictureBox thermometer_icon;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ImageList weather_icons;
        private System.Windows.Forms.PictureBox w_icons;
        private Bunifu.Framework.UI.BunifuCustomLabel date_time_with_weather;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private System.Windows.Forms.ImageList background;
    }
}