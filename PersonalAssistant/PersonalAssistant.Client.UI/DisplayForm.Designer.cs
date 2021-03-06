﻿namespace PersonalAssistant.Client.UI
{
    partial class DisplayForm
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
            this.labelCountry = new System.Windows.Forms.Label();
            this.labelCity = new System.Windows.Forms.Label();
            this.labelStartDate = new System.Windows.Forms.Label();
            this.labelEndDate = new System.Windows.Forms.Label();
            this.transportTextBoxCountry = new System.Windows.Forms.TextBox();
            this.transportTextBoxCity = new System.Windows.Forms.TextBox();
            this.transportStartDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.transportEndDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.labelNoRooms = new System.Windows.Forms.Label();
            this.transportTextBoxNoRooms = new System.Windows.Forms.TextBox();
            this.labelNoPeoplePerRoom = new System.Windows.Forms.Label();
            this.transportTextBoxPlpPerRoom = new System.Windows.Forms.TextBox();
            this.labelHotelStars = new System.Windows.Forms.Label();
            this.transportTextBoxHotelStarsLow = new System.Windows.Forms.TextBox();
            this.labelPriceRange = new System.Windows.Forms.Label();
            this.hotelTextBoxPriceLowRange = new System.Windows.Forms.TextBox();
            this.labelRange = new System.Windows.Forms.Label();
            this.hotelTextBoxPriceHighRange = new System.Windows.Forms.TextBox();
            this.labelTransportType = new System.Windows.Forms.Label();
            this.mainLabelTransp = new System.Windows.Forms.Label();
            this.mainLabelRecreation = new System.Windows.Forms.Label();
            this.recreationEndDatePicker = new System.Windows.Forms.DateTimePicker();
            this.recreationStartDatePicker = new System.Windows.Forms.DateTimePicker();
            this.labelRecreationEndDate = new System.Windows.Forms.Label();
            this.labelRecreationStartDate = new System.Windows.Forms.Label();
            this.transportCheckedListBoxType = new System.Windows.Forms.CheckedListBox();
            this.labelActivityTypes = new System.Windows.Forms.Label();
            this.recreationCheckedListBoxActivities = new System.Windows.Forms.CheckedListBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.textBoxMessages = new System.Windows.Forms.TextBox();
            this.buttonSeach = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.transportFromCountryTxtBox = new System.Windows.Forms.TextBox();
            this.transportFromCityTxtBox = new System.Windows.Forms.TextBox();
            this.transportTextBoxHotelStarsHigh = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.transportPriceHighRange = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.transportPriceLowRange = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.activityPriceHighRange = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.activityPriceLowRange = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelCountry
            // 
            this.labelCountry.AutoSize = true;
            this.labelCountry.Location = new System.Drawing.Point(65, 67);
            this.labelCountry.Name = "labelCountry";
            this.labelCountry.Size = new System.Drawing.Size(43, 13);
            this.labelCountry.TabIndex = 0;
            this.labelCountry.Text = "Country";
            // 
            // labelCity
            // 
            this.labelCity.AutoSize = true;
            this.labelCity.Location = new System.Drawing.Point(65, 90);
            this.labelCity.Name = "labelCity";
            this.labelCity.Size = new System.Drawing.Size(24, 13);
            this.labelCity.TabIndex = 1;
            this.labelCity.Text = "City";
            // 
            // labelStartDate
            // 
            this.labelStartDate.AutoSize = true;
            this.labelStartDate.Location = new System.Drawing.Point(64, 117);
            this.labelStartDate.Name = "labelStartDate";
            this.labelStartDate.Size = new System.Drawing.Size(55, 13);
            this.labelStartDate.TabIndex = 2;
            this.labelStartDate.Text = "Start Date";
            // 
            // labelEndDate
            // 
            this.labelEndDate.AutoSize = true;
            this.labelEndDate.Location = new System.Drawing.Point(66, 143);
            this.labelEndDate.Name = "labelEndDate";
            this.labelEndDate.Size = new System.Drawing.Size(52, 13);
            this.labelEndDate.TabIndex = 3;
            this.labelEndDate.Text = "End Date";
            // 
            // transportTextBoxCountry
            // 
            this.transportTextBoxCountry.Location = new System.Drawing.Point(208, 64);
            this.transportTextBoxCountry.Name = "transportTextBoxCountry";
            this.transportTextBoxCountry.Size = new System.Drawing.Size(100, 20);
            this.transportTextBoxCountry.TabIndex = 4;
            // 
            // transportTextBoxCity
            // 
            this.transportTextBoxCity.Location = new System.Drawing.Point(208, 90);
            this.transportTextBoxCity.Name = "transportTextBoxCity";
            this.transportTextBoxCity.Size = new System.Drawing.Size(100, 20);
            this.transportTextBoxCity.TabIndex = 5;
            // 
            // transportStartDateTimePicker
            // 
            this.transportStartDateTimePicker.CustomFormat = "";
            this.transportStartDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.transportStartDateTimePicker.Location = new System.Drawing.Point(208, 115);
            this.transportStartDateTimePicker.MinDate = new System.DateTime(2016, 11, 14, 0, 0, 0, 0);
            this.transportStartDateTimePicker.Name = "transportStartDateTimePicker";
            this.transportStartDateTimePicker.Size = new System.Drawing.Size(99, 20);
            this.transportStartDateTimePicker.TabIndex = 6;
            this.transportStartDateTimePicker.Value = new System.DateTime(2016, 11, 14, 18, 38, 59, 0);
            // 
            // transportEndDateTimePicker
            // 
            this.transportEndDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.transportEndDateTimePicker.Location = new System.Drawing.Point(208, 143);
            this.transportEndDateTimePicker.Name = "transportEndDateTimePicker";
            this.transportEndDateTimePicker.Size = new System.Drawing.Size(100, 20);
            this.transportEndDateTimePicker.TabIndex = 7;
            // 
            // labelNoRooms
            // 
            this.labelNoRooms.AutoSize = true;
            this.labelNoRooms.Location = new System.Drawing.Point(65, 169);
            this.labelNoRooms.Name = "labelNoRooms";
            this.labelNoRooms.Size = new System.Drawing.Size(87, 13);
            this.labelNoRooms.TabIndex = 8;
            this.labelNoRooms.Text = "Number of rooms";
            // 
            // transportTextBoxNoRooms
            // 
            this.transportTextBoxNoRooms.Location = new System.Drawing.Point(208, 169);
            this.transportTextBoxNoRooms.Name = "transportTextBoxNoRooms";
            this.transportTextBoxNoRooms.Size = new System.Drawing.Size(100, 20);
            this.transportTextBoxNoRooms.TabIndex = 9;
            // 
            // labelNoPeoplePerRoom
            // 
            this.labelNoPeoplePerRoom.AutoSize = true;
            this.labelNoPeoplePerRoom.Location = new System.Drawing.Point(66, 194);
            this.labelNoPeoplePerRoom.Name = "labelNoPeoplePerRoom";
            this.labelNoPeoplePerRoom.Size = new System.Drawing.Size(135, 13);
            this.labelNoPeoplePerRoom.TabIndex = 10;
            this.labelNoPeoplePerRoom.Text = "Number of people per room";
            // 
            // transportTextBoxPlpPerRoom
            // 
            this.transportTextBoxPlpPerRoom.Location = new System.Drawing.Point(208, 191);
            this.transportTextBoxPlpPerRoom.Name = "transportTextBoxPlpPerRoom";
            this.transportTextBoxPlpPerRoom.Size = new System.Drawing.Size(100, 20);
            this.transportTextBoxPlpPerRoom.TabIndex = 11;
            // 
            // labelHotelStars
            // 
            this.labelHotelStars.AutoSize = true;
            this.labelHotelStars.Location = new System.Drawing.Point(67, 220);
            this.labelHotelStars.Name = "labelHotelStars";
            this.labelHotelStars.Size = new System.Drawing.Size(59, 13);
            this.labelHotelStars.TabIndex = 12;
            this.labelHotelStars.Text = "Hotel Stars";
            // 
            // transportTextBoxHotelStarsLow
            // 
            this.transportTextBoxHotelStarsLow.Location = new System.Drawing.Point(208, 215);
            this.transportTextBoxHotelStarsLow.Name = "transportTextBoxHotelStarsLow";
            this.transportTextBoxHotelStarsLow.Size = new System.Drawing.Size(100, 20);
            this.transportTextBoxHotelStarsLow.TabIndex = 13;
            // 
            // labelPriceRange
            // 
            this.labelPriceRange.AutoSize = true;
            this.labelPriceRange.Location = new System.Drawing.Point(67, 242);
            this.labelPriceRange.Name = "labelPriceRange";
            this.labelPriceRange.Size = new System.Drawing.Size(94, 13);
            this.labelPriceRange.TabIndex = 14;
            this.labelPriceRange.Text = "Hote Price Ramge";
            // 
            // hotelTextBoxPriceLowRange
            // 
            this.hotelTextBoxPriceLowRange.Location = new System.Drawing.Point(208, 239);
            this.hotelTextBoxPriceLowRange.Name = "hotelTextBoxPriceLowRange";
            this.hotelTextBoxPriceLowRange.Size = new System.Drawing.Size(100, 20);
            this.hotelTextBoxPriceLowRange.TabIndex = 15;
            // 
            // labelRange
            // 
            this.labelRange.AutoSize = true;
            this.labelRange.Location = new System.Drawing.Point(313, 242);
            this.labelRange.Name = "labelRange";
            this.labelRange.Size = new System.Drawing.Size(10, 13);
            this.labelRange.TabIndex = 16;
            this.labelRange.Text = "-";
            // 
            // hotelTextBoxPriceHighRange
            // 
            this.hotelTextBoxPriceHighRange.Location = new System.Drawing.Point(330, 239);
            this.hotelTextBoxPriceHighRange.Name = "hotelTextBoxPriceHighRange";
            this.hotelTextBoxPriceHighRange.Size = new System.Drawing.Size(100, 20);
            this.hotelTextBoxPriceHighRange.TabIndex = 17;
            // 
            // labelTransportType
            // 
            this.labelTransportType.AutoSize = true;
            this.labelTransportType.Location = new System.Drawing.Point(67, 266);
            this.labelTransportType.Name = "labelTransportType";
            this.labelTransportType.Size = new System.Drawing.Size(79, 13);
            this.labelTransportType.TabIndex = 18;
            this.labelTransportType.Text = "Transport Type";
            // 
            // mainLabelTransp
            // 
            this.mainLabelTransp.AutoSize = true;
            this.mainLabelTransp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainLabelTransp.Location = new System.Drawing.Point(26, 41);
            this.mainLabelTransp.Name = "mainLabelTransp";
            this.mainLabelTransp.Size = new System.Drawing.Size(285, 17);
            this.mainLabelTransp.TabIndex = 20;
            this.mainLabelTransp.Text = "Transport and accommodation search items";
            // 
            // mainLabelRecreation
            // 
            this.mainLabelRecreation.AutoSize = true;
            this.mainLabelRecreation.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainLabelRecreation.Location = new System.Drawing.Point(26, 412);
            this.mainLabelRecreation.Name = "mainLabelRecreation";
            this.mainLabelRecreation.Size = new System.Drawing.Size(161, 17);
            this.mainLabelRecreation.TabIndex = 21;
            this.mainLabelRecreation.Text = "Recreation search items";
            // 
            // recreationEndDatePicker
            // 
            this.recreationEndDatePicker.CustomFormat = "dd-MM-yyyy";
            this.recreationEndDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.recreationEndDatePicker.Location = new System.Drawing.Point(207, 465);
            this.recreationEndDatePicker.MinDate = new System.DateTime(2016, 11, 14, 18, 54, 32, 0);
            this.recreationEndDatePicker.Name = "recreationEndDatePicker";
            this.recreationEndDatePicker.Size = new System.Drawing.Size(101, 20);
            this.recreationEndDatePicker.TabIndex = 29;
            this.recreationEndDatePicker.Value = new System.DateTime(2016, 11, 14, 18, 54, 32, 0);
            // 
            // recreationStartDatePicker
            // 
            this.recreationStartDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.recreationStartDatePicker.Location = new System.Drawing.Point(207, 440);
            this.recreationStartDatePicker.Name = "recreationStartDatePicker";
            this.recreationStartDatePicker.Size = new System.Drawing.Size(101, 20);
            this.recreationStartDatePicker.TabIndex = 28;
            this.recreationStartDatePicker.Value = new System.DateTime(2016, 11, 14, 18, 38, 59, 0);
            // 
            // labelRecreationEndDate
            // 
            this.labelRecreationEndDate.AutoSize = true;
            this.labelRecreationEndDate.Location = new System.Drawing.Point(66, 470);
            this.labelRecreationEndDate.Name = "labelRecreationEndDate";
            this.labelRecreationEndDate.Size = new System.Drawing.Size(52, 13);
            this.labelRecreationEndDate.TabIndex = 27;
            this.labelRecreationEndDate.Text = "End Date";
            // 
            // labelRecreationStartDate
            // 
            this.labelRecreationStartDate.AutoSize = true;
            this.labelRecreationStartDate.Location = new System.Drawing.Point(66, 444);
            this.labelRecreationStartDate.Name = "labelRecreationStartDate";
            this.labelRecreationStartDate.Size = new System.Drawing.Size(55, 13);
            this.labelRecreationStartDate.TabIndex = 26;
            this.labelRecreationStartDate.Text = "Start Date";
            // 
            // transportCheckedListBoxType
            // 
            this.transportCheckedListBoxType.CheckOnClick = true;
            this.transportCheckedListBoxType.FormattingEnabled = true;
            this.transportCheckedListBoxType.Items.AddRange(new object[] {
            "Air transportation",
            "Rail transportation",
            "Own car"});
            this.transportCheckedListBoxType.Location = new System.Drawing.Point(208, 265);
            this.transportCheckedListBoxType.Name = "transportCheckedListBoxType";
            this.transportCheckedListBoxType.Size = new System.Drawing.Size(120, 49);
            this.transportCheckedListBoxType.TabIndex = 30;
            this.transportCheckedListBoxType.UseCompatibleTextRendering = true;
            // 
            // labelActivityTypes
            // 
            this.labelActivityTypes.AutoSize = true;
            this.labelActivityTypes.Location = new System.Drawing.Point(67, 496);
            this.labelActivityTypes.Name = "labelActivityTypes";
            this.labelActivityTypes.Size = new System.Drawing.Size(49, 13);
            this.labelActivityTypes.TabIndex = 31;
            this.labelActivityTypes.Text = "Activities";
            // 
            // recreationCheckedListBoxActivities
            // 
            this.recreationCheckedListBoxActivities.CheckOnClick = true;
            this.recreationCheckedListBoxActivities.FormattingEnabled = true;
            this.recreationCheckedListBoxActivities.Items.AddRange(new object[] {
            "Tourist attractions",
            "Concerts",
            "Sports"});
            this.recreationCheckedListBoxActivities.Location = new System.Drawing.Point(206, 495);
            this.recreationCheckedListBoxActivities.Name = "recreationCheckedListBoxActivities";
            this.recreationCheckedListBoxActivities.Size = new System.Drawing.Size(120, 49);
            this.recreationCheckedListBoxActivities.TabIndex = 32;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(553, 80);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(100, 96);
            this.richTextBox1.TabIndex = 34;
            this.richTextBox1.Text = "";
            // 
            // textBoxMessages
            // 
            this.textBoxMessages.Location = new System.Drawing.Point(461, 23);
            this.textBoxMessages.Multiline = true;
            this.textBoxMessages.Name = "textBoxMessages";
            this.textBoxMessages.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxMessages.Size = new System.Drawing.Size(393, 583);
            this.textBoxMessages.TabIndex = 35;
            // 
            // buttonSeach
            // 
            this.buttonSeach.Location = new System.Drawing.Point(151, 576);
            this.buttonSeach.Name = "buttonSeach";
            this.buttonSeach.Size = new System.Drawing.Size(75, 23);
            this.buttonSeach.TabIndex = 36;
            this.buttonSeach.Text = "Search";
            this.buttonSeach.UseVisualStyleBackColor = true;
            this.buttonSeach.Click += new System.EventHandler(this.ButtonSeachClick);
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(232, 576);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(75, 23);
            this.buttonClear.TabIndex = 37;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.ButtonClearClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(67, 325);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 13);
            this.label1.TabIndex = 38;
            this.label1.Text = "Transport From (Country)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(67, 353);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 13);
            this.label2.TabIndex = 39;
            this.label2.Text = "Transport From (City)";
            // 
            // transportFromCountryTxtBox
            // 
            this.transportFromCountryTxtBox.Location = new System.Drawing.Point(206, 322);
            this.transportFromCountryTxtBox.Name = "transportFromCountryTxtBox";
            this.transportFromCountryTxtBox.Size = new System.Drawing.Size(100, 20);
            this.transportFromCountryTxtBox.TabIndex = 40;
            // 
            // transportFromCityTxtBox
            // 
            this.transportFromCityTxtBox.Location = new System.Drawing.Point(206, 351);
            this.transportFromCityTxtBox.Name = "transportFromCityTxtBox";
            this.transportFromCityTxtBox.Size = new System.Drawing.Size(100, 20);
            this.transportFromCityTxtBox.TabIndex = 41;
            // 
            // transportTextBoxHotelStarsHigh
            // 
            this.transportTextBoxHotelStarsHigh.Location = new System.Drawing.Point(330, 216);
            this.transportTextBoxHotelStarsHigh.Name = "transportTextBoxHotelStarsHigh";
            this.transportTextBoxHotelStarsHigh.Size = new System.Drawing.Size(100, 20);
            this.transportTextBoxHotelStarsHigh.TabIndex = 43;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(313, 219);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(10, 13);
            this.label3.TabIndex = 42;
            this.label3.Text = "-";
            // 
            // transportPriceHighRange
            // 
            this.transportPriceHighRange.Location = new System.Drawing.Point(330, 378);
            this.transportPriceHighRange.Name = "transportPriceHighRange";
            this.transportPriceHighRange.Size = new System.Drawing.Size(100, 20);
            this.transportPriceHighRange.TabIndex = 47;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(313, 381);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(10, 13);
            this.label4.TabIndex = 46;
            this.label4.Text = "-";
            // 
            // transportPriceLowRange
            // 
            this.transportPriceLowRange.Location = new System.Drawing.Point(208, 378);
            this.transportPriceLowRange.Name = "transportPriceLowRange";
            this.transportPriceLowRange.Size = new System.Drawing.Size(100, 20);
            this.transportPriceLowRange.TabIndex = 45;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(67, 381);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 13);
            this.label5.TabIndex = 44;
            this.label5.Text = "Transport Price Range";
            // 
            // activityPriceHighRange
            // 
            this.activityPriceHighRange.Location = new System.Drawing.Point(327, 550);
            this.activityPriceHighRange.Name = "activityPriceHighRange";
            this.activityPriceHighRange.Size = new System.Drawing.Size(100, 20);
            this.activityPriceHighRange.TabIndex = 51;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(310, 553);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(10, 13);
            this.label6.TabIndex = 50;
            this.label6.Text = "-";
            // 
            // activityPriceLowRange
            // 
            this.activityPriceLowRange.Location = new System.Drawing.Point(205, 550);
            this.activityPriceLowRange.Name = "activityPriceLowRange";
            this.activityPriceLowRange.Size = new System.Drawing.Size(100, 20);
            this.activityPriceLowRange.TabIndex = 49;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(64, 553);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 13);
            this.label7.TabIndex = 48;
            this.label7.Text = "Price range";
            // 
            // DisplayForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 633);
            this.Controls.Add(this.activityPriceHighRange);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.activityPriceLowRange);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.transportPriceHighRange);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.transportPriceLowRange);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.transportTextBoxHotelStarsHigh);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.transportFromCityTxtBox);
            this.Controls.Add(this.transportFromCountryTxtBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonSeach);
            this.Controls.Add(this.textBoxMessages);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.recreationCheckedListBoxActivities);
            this.Controls.Add(this.labelActivityTypes);
            this.Controls.Add(this.transportCheckedListBoxType);
            this.Controls.Add(this.recreationEndDatePicker);
            this.Controls.Add(this.recreationStartDatePicker);
            this.Controls.Add(this.labelRecreationEndDate);
            this.Controls.Add(this.labelRecreationStartDate);
            this.Controls.Add(this.mainLabelRecreation);
            this.Controls.Add(this.mainLabelTransp);
            this.Controls.Add(this.labelTransportType);
            this.Controls.Add(this.hotelTextBoxPriceHighRange);
            this.Controls.Add(this.labelRange);
            this.Controls.Add(this.hotelTextBoxPriceLowRange);
            this.Controls.Add(this.labelPriceRange);
            this.Controls.Add(this.transportTextBoxHotelStarsLow);
            this.Controls.Add(this.labelHotelStars);
            this.Controls.Add(this.transportTextBoxPlpPerRoom);
            this.Controls.Add(this.labelNoPeoplePerRoom);
            this.Controls.Add(this.transportTextBoxNoRooms);
            this.Controls.Add(this.labelNoRooms);
            this.Controls.Add(this.transportEndDateTimePicker);
            this.Controls.Add(this.transportStartDateTimePicker);
            this.Controls.Add(this.transportTextBoxCity);
            this.Controls.Add(this.transportTextBoxCountry);
            this.Controls.Add(this.labelEndDate);
            this.Controls.Add(this.labelStartDate);
            this.Controls.Add(this.labelCity);
            this.Controls.Add(this.labelCountry);
            this.Name = "DisplayForm";
            this.Text = "Vacation Client";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormAgentFormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelCountry;
        private System.Windows.Forms.Label labelCity;
        private System.Windows.Forms.Label labelStartDate;
        private System.Windows.Forms.Label labelEndDate;
        private System.Windows.Forms.TextBox transportTextBoxCountry;
        private System.Windows.Forms.TextBox transportTextBoxCity;
        private System.Windows.Forms.DateTimePicker transportStartDateTimePicker;
        private System.Windows.Forms.DateTimePicker transportEndDateTimePicker;
        private System.Windows.Forms.Label labelNoRooms;
        private System.Windows.Forms.TextBox transportTextBoxNoRooms;
        private System.Windows.Forms.Label labelNoPeoplePerRoom;
        private System.Windows.Forms.TextBox transportTextBoxPlpPerRoom;
        private System.Windows.Forms.Label labelHotelStars;
        private System.Windows.Forms.TextBox transportTextBoxHotelStarsLow;
        private System.Windows.Forms.Label labelPriceRange;
        private System.Windows.Forms.TextBox hotelTextBoxPriceLowRange;
        private System.Windows.Forms.Label labelRange;
        private System.Windows.Forms.TextBox hotelTextBoxPriceHighRange;
        private System.Windows.Forms.Label labelTransportType;
        private System.Windows.Forms.Label mainLabelTransp;
        private System.Windows.Forms.Label mainLabelRecreation;
        private System.Windows.Forms.DateTimePicker recreationEndDatePicker;
        private System.Windows.Forms.DateTimePicker recreationStartDatePicker;
        private System.Windows.Forms.Label labelRecreationEndDate;
        private System.Windows.Forms.Label labelRecreationStartDate;
        private System.Windows.Forms.Label labelActivityTypes;
        private System.Windows.Forms.CheckedListBox recreationCheckedListBoxActivities;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.TextBox textBoxMessages;
        private System.Windows.Forms.Button buttonSeach;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox transportFromCountryTxtBox;
        private System.Windows.Forms.TextBox transportFromCityTxtBox;
        private System.Windows.Forms.TextBox transportTextBoxHotelStarsHigh;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.CheckedListBox transportCheckedListBoxType;
        private System.Windows.Forms.TextBox transportPriceHighRange;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox transportPriceLowRange;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox activityPriceHighRange;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox activityPriceLowRange;
        private System.Windows.Forms.Label label7;
    }
}

