using PersonalAssistant.Services.External.DataContract;

namespace PersonalAssistant.Client.UI
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Windows.Forms;

    using PersonalAssistant.Services.External.Messages;
    using PersonalAssistant.Services.External.Messages.Contracts.Requests;
    using PersonalAssistant.Services.External.Messages.Messages.Client;

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
            // TODO: to be removed
            // Location
            var country = transportTextBoxCountry.Text;
            var city = transportTextBoxCity.Text;
            var startDate = transportStartDateTimePicker.Text;
            var endDate = transportEndDateTimePicker.Text;
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
            var startDateEvents = recreationStartDatePicker.Text;
            var endDateEvents = recreationEndDatePicker.Text;
            var eventsType = recreationCheckedListBoxActivities.CheckedItems;

            return new AggregateServicesRequest
            {
                HotelCountry = transportTextBoxCountry.Text,
                Location = transportTextBoxCity.Text,
                IntervalOfDays = new Range<DateTime?>
                {
                    Min = transportStartDateTimePicker.Text != null ? DateTime.Parse(transportStartDateTimePicker.Text) : (DateTime?)null,
                    Max = transportEndDateTimePicker.Text != null ? DateTime.Parse(transportEndDateTimePicker.Text) : (DateTime?)null,
                },
                NumberOfRooms = transportTextBoxNoRooms.Text != null ? Int32.Parse(transportTextBoxNoRooms.Text) : (int?) null,
                NumberOfPeoplePerRoom = transportTextBoxPlpPerRoom.Text != null ? Int32.Parse(transportTextBoxPlpPerRoom.Text) :(int?) null,
                NumberOfStars = new Range<int?>
                {
                    Min = transportTextBoxHotelStarsLow.Text != null ? Int32.Parse(transportTextBoxHotelStarsLow.Text) : (int?) null,
                    Max = transportTextBoxHotelStarsHigh.Text != null ? Int32.Parse(transportTextBoxHotelStarsHigh.Text) : (int?)null
                },
                Price = new Range<int?>
                {
                    Min = transportTextBoxPriceLowRange.Text != null ? Int32.Parse(transportTextBoxPriceLowRange.Text) : (int?)null,
                    Max = transportTextBoxPriceHighRange.Text != null ? Int32.Parse(transportTextBoxPriceHighRange.Text) : (int?)null
                },
                TransportTypes = transportCheckedListBoxType.CheckedItems.OfType<string>(),
                YourCountry = transportFromCountryTxtBox.Text,
                YourCity = transportFromCityTxtBox.Text,
                EventDate = new Range<DateTime?>()
                {
                    Min = recreationStartDatePicker.Text != null ? DateTime.Parse(recreationStartDatePicker.Text) : (DateTime?)null,
                    Max = recreationEndDatePicker.Text != null ? DateTime.Parse(recreationEndDatePicker.Text) : (DateTime?)null,
                },
                ActivityTypes = recreationCheckedListBoxActivities.CheckedItems.OfType<string>(),
            };
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