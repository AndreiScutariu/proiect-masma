namespace PersonalAssistant.Client.UI
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Windows.Forms;

    using PersonalAssistant.Services.External.DataContract.Contracts.Requests;
    using PersonalAssistant.Services.External.DataContract.Messages.Client;

    public partial class DisplayForm : Form
    {
        public DisplayForm()
        {
            InitializeComponent();
            SetupDefaultValues();
        }

        public Action<IAggregateServicesRequest> SearchActionAgentCallback { get; set; }

        public void SetupDefaultValues()
        {
            transportStartDateTimePicker.MinDate = DateTime.Today;
            transportEndDateTimePicker.MinDate = DateTime.Today;
            recreationStartDatePicker.MinDate = DateTime.Today;
            recreationEndDatePicker.MinDate = DateTime.Today;

            transportStartDateTimePicker.Value = DateTime.Today;
            transportEndDateTimePicker.Value = DateTime.Today.AddDays(3);

            recreationStartDatePicker.Value = DateTime.Today;
            recreationEndDatePicker.Value = DateTime.Today.AddDays(3);
        }

        public void DoEvents()
        {
            Application.DoEvents();
        }

        public void AddTextLine(string s)
        {
            Invoke((MethodInvoker)delegate { textBoxMessages.AppendText(s + Environment.NewLine); });
        }

        public IAggregateServicesRequest BuildRequestFromInputs()
        {
            // Location
            var country = transportTextBoxCountry.Text;
            var city = transportTextBoxCity.Text;
            var startDate = transportStartDateTimePicker.Text;
            var endDate = transportStartDateTimePicker.Text;
            var numberOfRooms = transportTextBoxNoRooms.Text;
            var plpPerRoom = transportTextBoxPlpPerRoom.Text;
            var hotelStart = transportTextBoxHotelStarsLow.Text;
            var lowPriceRange = transportTextBoxPriceLowRange.Text;
            var highPriceRange = transportTextBoxPriceHighRange.Text;

            // Transportation
            var transportTypes = transportCheckedListBoxType.CheckedItems;
            var transportFromCountry = transportFromCountryTxtBox.Text;
            var transportFromCity = transportFromCityTxtBox.Text;

            // Get items from check as a list
            IEnumerable<string> listOfTranports = transportTypes.OfType<string>();

            // Recreation items
            var countryEvents = recreationTextBoxCountry.Text;
            var cityEvents = recreationTextBoxCity.Text;
            var startDateEvents = recreationStartDatePicker.Text;
            var endDateEvents = recreationEndDatePicker.Text;
            var eventsType = recreationCheckedListBoxActivities.CheckedItems;

            return new AggregateServicesRequest();
        }

        public void ClearAllValues()
        {
            // Location
            transportTextBoxCountry.Clear();
            transportTextBoxCity.Clear();
            transportTextBoxNoRooms.Clear();
            transportTextBoxPlpPerRoom.Clear();
            transportTextBoxHotelStarsLow.Clear();
            transportTextBoxPriceLowRange.Clear();
            transportTextBoxPriceHighRange.Clear();

            // Transportation
            transportCheckedListBoxType.ClearSelected();
            transportFromCountryTxtBox.Clear();
            transportFromCityTxtBox.Clear();

            SetupDefaultValues();

            // Recreation items
            recreationTextBoxCountry.Clear();
            recreationTextBoxCity.Clear();
            recreationCheckedListBoxActivities.ClearSelected();
        }

        private void ButtonSeachClick(object sender, EventArgs e)
        {
            var request = BuildRequestFromInputs();

            SearchActionAgentCallback(request);
        }

        private void ButtonClearClick(object sender, EventArgs e)
        {
            ClearAllValues();
        }

        private void FormAgentFormClosed(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}