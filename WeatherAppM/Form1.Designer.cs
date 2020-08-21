namespace WeatherAppM
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelCityName = new System.Windows.Forms.Label();
            this.labelTemperature = new System.Windows.Forms.Label();
            this.pictureBoxWeatherIcon = new System.Windows.Forms.PictureBox();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.labelTemperature5 = new System.Windows.Forms.Label();
            this.labelDescription5 = new System.Windows.Forms.Label();
            this.labelDays5 = new System.Windows.Forms.Label();
            this.pictureBoxWeatherIcon5 = new System.Windows.Forms.PictureBox();
            this.labelTemperature4 = new System.Windows.Forms.Label();
            this.labelDescription4 = new System.Windows.Forms.Label();
            this.labelDays4 = new System.Windows.Forms.Label();
            this.pictureBoxWeatherIcon4 = new System.Windows.Forms.PictureBox();
            this.labelTemperature3 = new System.Windows.Forms.Label();
            this.labelDescription3 = new System.Windows.Forms.Label();
            this.labelDays3 = new System.Windows.Forms.Label();
            this.pictureBoxWeatherIcon3 = new System.Windows.Forms.PictureBox();
            this.labelTemperature2 = new System.Windows.Forms.Label();
            this.labelDescription2 = new System.Windows.Forms.Label();
            this.labelDays2 = new System.Windows.Forms.Label();
            this.pictureBoxWeatherIcon2 = new System.Windows.Forms.PictureBox();
            this.labelForecast = new System.Windows.Forms.Label();
            this.labelTemperature1 = new System.Windows.Forms.Label();
            this.labelDescription1 = new System.Windows.Forms.Label();
            this.labelDays1 = new System.Windows.Forms.Label();
            this.pictureBoxWeatherIcon1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxWeatherIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxWeatherIcon5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxWeatherIcon4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxWeatherIcon3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxWeatherIcon2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxWeatherIcon1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelCityName
            // 
            this.labelCityName.AutoSize = true;
            this.labelCityName.Font = new System.Drawing.Font("Segoe UI", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelCityName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(110)))), ((int)(((byte)(80)))));
            this.labelCityName.Location = new System.Drawing.Point(113, 9);
            this.labelCityName.Name = "labelCityName";
            this.labelCityName.Size = new System.Drawing.Size(182, 45);
            this.labelCityName.TabIndex = 0;
            this.labelCityName.Text = "City Name";
            // 
            // labelTemperature
            // 
            this.labelTemperature.AutoSize = true;
            this.labelTemperature.Font = new System.Drawing.Font("Segoe UI", 39.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelTemperature.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(110)))), ((int)(((byte)(80)))));
            this.labelTemperature.Location = new System.Drawing.Point(227, 70);
            this.labelTemperature.Name = "labelTemperature";
            this.labelTemperature.Size = new System.Drawing.Size(167, 71);
            this.labelTemperature.TabIndex = 1;
            this.labelTemperature.Text = "Temp";
            // 
            // pictureBoxWeatherIcon
            // 
            this.pictureBoxWeatherIcon.Location = new System.Drawing.Point(121, 57);
            this.pictureBoxWeatherIcon.Name = "pictureBoxWeatherIcon";
            this.pictureBoxWeatherIcon.Size = new System.Drawing.Size(100, 100);
            this.pictureBoxWeatherIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxWeatherIcon.TabIndex = 2;
            this.pictureBoxWeatherIcon.TabStop = false;
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Location = new System.Drawing.Point(121, 163);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(167, 20);
            this.textBoxSearch.TabIndex = 3;
            this.textBoxSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxSearch_KeyDown);
            // 
            // buttonSearch
            // 
            this.buttonSearch.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonSearch.Location = new System.Drawing.Point(294, 161);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(75, 23);
            this.buttonSearch.TabIndex = 4;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // labelTemperature5
            // 
            this.labelTemperature5.AutoSize = true;
            this.labelTemperature5.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.labelTemperature5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(110)))), ((int)(((byte)(80)))));
            this.labelTemperature5.Location = new System.Drawing.Point(550, 355);
            this.labelTemperature5.Name = "labelTemperature5";
            this.labelTemperature5.Size = new System.Drawing.Size(27, 30);
            this.labelTemperature5.TabIndex = 65;
            this.labelTemperature5.Text = "C";
            // 
            // labelDescription5
            // 
            this.labelDescription5.AutoSize = true;
            this.labelDescription5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.labelDescription5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(110)))), ((int)(((byte)(80)))));
            this.labelDescription5.Location = new System.Drawing.Point(551, 337);
            this.labelDescription5.Name = "labelDescription5";
            this.labelDescription5.Size = new System.Drawing.Size(89, 20);
            this.labelDescription5.TabIndex = 63;
            this.labelDescription5.Text = "Description";
            // 
            // labelDays5
            // 
            this.labelDays5.AutoSize = true;
            this.labelDays5.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.labelDays5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(110)))), ((int)(((byte)(80)))));
            this.labelDays5.Location = new System.Drawing.Point(550, 305);
            this.labelDays5.Name = "labelDays5";
            this.labelDays5.Size = new System.Drawing.Size(53, 30);
            this.labelDays5.TabIndex = 61;
            this.labelDays5.Text = "Day";
            // 
            // pictureBoxWeatherIcon5
            // 
            this.pictureBoxWeatherIcon5.Location = new System.Drawing.Point(475, 309);
            this.pictureBoxWeatherIcon5.Name = "pictureBoxWeatherIcon5";
            this.pictureBoxWeatherIcon5.Size = new System.Drawing.Size(70, 70);
            this.pictureBoxWeatherIcon5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxWeatherIcon5.TabIndex = 60;
            this.pictureBoxWeatherIcon5.TabStop = false;
            // 
            // labelTemperature4
            // 
            this.labelTemperature4.AutoSize = true;
            this.labelTemperature4.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.labelTemperature4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(110)))), ((int)(((byte)(80)))));
            this.labelTemperature4.Location = new System.Drawing.Point(347, 354);
            this.labelTemperature4.Name = "labelTemperature4";
            this.labelTemperature4.Size = new System.Drawing.Size(27, 30);
            this.labelTemperature4.TabIndex = 59;
            this.labelTemperature4.Text = "C";
            // 
            // labelDescription4
            // 
            this.labelDescription4.AutoSize = true;
            this.labelDescription4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.labelDescription4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(110)))), ((int)(((byte)(80)))));
            this.labelDescription4.Location = new System.Drawing.Point(348, 336);
            this.labelDescription4.Name = "labelDescription4";
            this.labelDescription4.Size = new System.Drawing.Size(89, 20);
            this.labelDescription4.TabIndex = 57;
            this.labelDescription4.Text = "Description";
            // 
            // labelDays4
            // 
            this.labelDays4.AutoSize = true;
            this.labelDays4.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.labelDays4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(110)))), ((int)(((byte)(80)))));
            this.labelDays4.Location = new System.Drawing.Point(347, 306);
            this.labelDays4.Name = "labelDays4";
            this.labelDays4.Size = new System.Drawing.Size(53, 30);
            this.labelDays4.TabIndex = 55;
            this.labelDays4.Text = "Day";
            // 
            // pictureBoxWeatherIcon4
            // 
            this.pictureBoxWeatherIcon4.Location = new System.Drawing.Point(272, 309);
            this.pictureBoxWeatherIcon4.Name = "pictureBoxWeatherIcon4";
            this.pictureBoxWeatherIcon4.Size = new System.Drawing.Size(70, 70);
            this.pictureBoxWeatherIcon4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxWeatherIcon4.TabIndex = 54;
            this.pictureBoxWeatherIcon4.TabStop = false;
            // 
            // labelTemperature3
            // 
            this.labelTemperature3.AutoSize = true;
            this.labelTemperature3.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.labelTemperature3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(110)))), ((int)(((byte)(80)))));
            this.labelTemperature3.Location = new System.Drawing.Point(142, 355);
            this.labelTemperature3.Name = "labelTemperature3";
            this.labelTemperature3.Size = new System.Drawing.Size(27, 30);
            this.labelTemperature3.TabIndex = 53;
            this.labelTemperature3.Text = "C";
            // 
            // labelDescription3
            // 
            this.labelDescription3.AutoSize = true;
            this.labelDescription3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.labelDescription3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(110)))), ((int)(((byte)(80)))));
            this.labelDescription3.Location = new System.Drawing.Point(141, 336);
            this.labelDescription3.Name = "labelDescription3";
            this.labelDescription3.Size = new System.Drawing.Size(89, 20);
            this.labelDescription3.TabIndex = 51;
            this.labelDescription3.Text = "Description";
            // 
            // labelDays3
            // 
            this.labelDays3.AutoSize = true;
            this.labelDays3.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.labelDays3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(110)))), ((int)(((byte)(80)))));
            this.labelDays3.Location = new System.Drawing.Point(141, 306);
            this.labelDays3.Name = "labelDays3";
            this.labelDays3.Size = new System.Drawing.Size(53, 30);
            this.labelDays3.TabIndex = 49;
            this.labelDays3.Text = "Day";
            // 
            // pictureBoxWeatherIcon3
            // 
            this.pictureBoxWeatherIcon3.Location = new System.Drawing.Point(65, 309);
            this.pictureBoxWeatherIcon3.Name = "pictureBoxWeatherIcon3";
            this.pictureBoxWeatherIcon3.Size = new System.Drawing.Size(70, 70);
            this.pictureBoxWeatherIcon3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxWeatherIcon3.TabIndex = 48;
            this.pictureBoxWeatherIcon3.TabStop = false;
            // 
            // labelTemperature2
            // 
            this.labelTemperature2.AutoSize = true;
            this.labelTemperature2.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.labelTemperature2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(110)))), ((int)(((byte)(80)))));
            this.labelTemperature2.Location = new System.Drawing.Point(550, 264);
            this.labelTemperature2.Name = "labelTemperature2";
            this.labelTemperature2.Size = new System.Drawing.Size(27, 30);
            this.labelTemperature2.TabIndex = 47;
            this.labelTemperature2.Text = "C";
            // 
            // labelDescription2
            // 
            this.labelDescription2.AutoSize = true;
            this.labelDescription2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.labelDescription2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(110)))), ((int)(((byte)(80)))));
            this.labelDescription2.Location = new System.Drawing.Point(551, 244);
            this.labelDescription2.Name = "labelDescription2";
            this.labelDescription2.Size = new System.Drawing.Size(89, 20);
            this.labelDescription2.TabIndex = 45;
            this.labelDescription2.Text = "Description";
            // 
            // labelDays2
            // 
            this.labelDays2.AutoSize = true;
            this.labelDays2.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.labelDays2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(110)))), ((int)(((byte)(80)))));
            this.labelDays2.Location = new System.Drawing.Point(550, 214);
            this.labelDays2.Name = "labelDays2";
            this.labelDays2.Size = new System.Drawing.Size(53, 30);
            this.labelDays2.TabIndex = 43;
            this.labelDays2.Text = "Day";
            // 
            // pictureBoxWeatherIcon2
            // 
            this.pictureBoxWeatherIcon2.Location = new System.Drawing.Point(475, 217);
            this.pictureBoxWeatherIcon2.Name = "pictureBoxWeatherIcon2";
            this.pictureBoxWeatherIcon2.Size = new System.Drawing.Size(70, 70);
            this.pictureBoxWeatherIcon2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxWeatherIcon2.TabIndex = 42;
            this.pictureBoxWeatherIcon2.TabStop = false;
            // 
            // labelForecast
            // 
            this.labelForecast.AutoSize = true;
            this.labelForecast.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelForecast.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(110)))), ((int)(((byte)(80)))));
            this.labelForecast.Location = new System.Drawing.Point(56, 228);
            this.labelForecast.Name = "labelForecast";
            this.labelForecast.Size = new System.Drawing.Size(181, 54);
            this.labelForecast.TabIndex = 41;
            this.labelForecast.Text = "Forecast";
            // 
            // labelTemperature1
            // 
            this.labelTemperature1.AutoSize = true;
            this.labelTemperature1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.labelTemperature1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(110)))), ((int)(((byte)(80)))));
            this.labelTemperature1.Location = new System.Drawing.Point(347, 263);
            this.labelTemperature1.Name = "labelTemperature1";
            this.labelTemperature1.Size = new System.Drawing.Size(27, 30);
            this.labelTemperature1.TabIndex = 40;
            this.labelTemperature1.Text = "C";
            // 
            // labelDescription1
            // 
            this.labelDescription1.AutoSize = true;
            this.labelDescription1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelDescription1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(110)))), ((int)(((byte)(80)))));
            this.labelDescription1.Location = new System.Drawing.Point(348, 243);
            this.labelDescription1.Name = "labelDescription1";
            this.labelDescription1.Size = new System.Drawing.Size(89, 20);
            this.labelDescription1.TabIndex = 38;
            this.labelDescription1.Text = "Description";
            // 
            // labelDays1
            // 
            this.labelDays1.AutoSize = true;
            this.labelDays1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelDays1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(110)))), ((int)(((byte)(80)))));
            this.labelDays1.Location = new System.Drawing.Point(347, 213);
            this.labelDays1.Name = "labelDays1";
            this.labelDays1.Size = new System.Drawing.Size(50, 30);
            this.labelDays1.TabIndex = 36;
            this.labelDays1.Text = "Day";
            // 
            // pictureBoxWeatherIcon1
            // 
            this.pictureBoxWeatherIcon1.Location = new System.Drawing.Point(272, 217);
            this.pictureBoxWeatherIcon1.Name = "pictureBoxWeatherIcon1";
            this.pictureBoxWeatherIcon1.Size = new System.Drawing.Size(70, 70);
            this.pictureBoxWeatherIcon1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxWeatherIcon1.TabIndex = 35;
            this.pictureBoxWeatherIcon1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(33)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(734, 411);
            this.Controls.Add(this.labelTemperature5);
            this.Controls.Add(this.labelDescription5);
            this.Controls.Add(this.labelDays5);
            this.Controls.Add(this.pictureBoxWeatherIcon5);
            this.Controls.Add(this.labelTemperature4);
            this.Controls.Add(this.labelDescription4);
            this.Controls.Add(this.labelDays4);
            this.Controls.Add(this.pictureBoxWeatherIcon4);
            this.Controls.Add(this.labelTemperature3);
            this.Controls.Add(this.labelDescription3);
            this.Controls.Add(this.labelDays3);
            this.Controls.Add(this.pictureBoxWeatherIcon3);
            this.Controls.Add(this.labelTemperature2);
            this.Controls.Add(this.labelDescription2);
            this.Controls.Add(this.labelDays2);
            this.Controls.Add(this.pictureBoxWeatherIcon2);
            this.Controls.Add(this.labelForecast);
            this.Controls.Add(this.labelTemperature1);
            this.Controls.Add(this.labelDescription1);
            this.Controls.Add(this.labelDays1);
            this.Controls.Add(this.pictureBoxWeatherIcon1);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.pictureBoxWeatherIcon);
            this.Controls.Add(this.labelTemperature);
            this.Controls.Add(this.labelCityName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxWeatherIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxWeatherIcon5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxWeatherIcon4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxWeatherIcon3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxWeatherIcon2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxWeatherIcon1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelCityName;
        private System.Windows.Forms.Label labelTemperature;
        private System.Windows.Forms.PictureBox pictureBoxWeatherIcon;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Label labelTemperature5;
        private System.Windows.Forms.Label labelDescription5;
        private System.Windows.Forms.Label labelDays5;
        private System.Windows.Forms.PictureBox pictureBoxWeatherIcon5;
        private System.Windows.Forms.Label labelTemperature4;
        private System.Windows.Forms.Label labelDescription4;
        private System.Windows.Forms.Label labelDays4;
        private System.Windows.Forms.PictureBox pictureBoxWeatherIcon4;
        private System.Windows.Forms.Label labelTemperature3;
        private System.Windows.Forms.Label labelDescription3;
        private System.Windows.Forms.Label labelDays3;
        private System.Windows.Forms.PictureBox pictureBoxWeatherIcon3;
        private System.Windows.Forms.Label labelTemperature2;
        private System.Windows.Forms.Label labelDescription2;
        private System.Windows.Forms.Label labelDays2;
        private System.Windows.Forms.PictureBox pictureBoxWeatherIcon2;
        private System.Windows.Forms.Label labelForecast;
        private System.Windows.Forms.Label labelTemperature1;
        private System.Windows.Forms.Label labelDescription1;
        private System.Windows.Forms.Label labelDays1;
        private System.Windows.Forms.PictureBox pictureBoxWeatherIcon1;
    }
}

