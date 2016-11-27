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
            transportStartDateTimePicker.Value = DateTime.Today;
            transportEndDateTimePicker.Value = DateTime.Today.AddDays(3);
            recreationStartDatePicker.Value = DateTime.Today;
            recreationEndDatePicker.Value = DateTime.Today.AddDays(3);

            transportStartDateTimePicker.MinDate = DateTime.Today;
            transportEndDateTimePicker.MinDate = DateTime.Today;
            recreationStartDatePicker.MinDate = DateTime.Today;
            recreationEndDatePicker.MinDate = DateTime.Today;
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
            var model = new AggregateServicesRequest
            {
                // Hotel
                HotelCountry = transportTextBoxCountry.Text,
                Location = transportTextBoxCity.Text,
                IntervalOfDays = new Range<DateTime?>
                {
                    Min = transportStartDateTimePicker.Text != null ? DateTime.Parse(transportStartDateTimePicker.Text) : (DateTime?)null,
                    Max = transportEndDateTimePicker.Text != null ? DateTime.Parse(transportEndDateTimePicker.Text) : (DateTime?)null,
                },
                NumberOfRooms = !String.IsNullOrEmpty(transportTextBoxNoRooms.Text) ? Int32.Parse(transportTextBoxNoRooms.Text) : (int?) null,
                NumberOfPeoplePerRoom = !String.IsNullOrEmpty(transportTextBoxPlpPerRoom.Text) ? Int32.Parse(transportTextBoxPlpPerRoom.Text) :(int?) null,
                NumberOfStars = new Range<int?>
                {
                    Min = !String.IsNullOrEmpty(transportTextBoxHotelStarsLow.Text) ? Int32.Parse(transportTextBoxHotelStarsLow.Text) : (int?) null,
                    Max = !String.IsNullOrEmpty(transportTextBoxHotelStarsHigh.Text) ? Int32.Parse(transportTextBoxHotelStarsHigh.Text) : (int?)null
                },
                HotelPrice = new Range<int?>
                {
                    Min = !String.IsNullOrEmpty(hotelTextBoxPriceLowRange.Text) ? Int32.Parse(hotelTextBoxPriceLowRange.Text) : (int?)null,
                    Max = !String.IsNullOrEmpty(hotelTextBoxPriceHighRange.Text) ? Int32.Parse(hotelTextBoxPriceHighRange.Text) : (int?)null
                },
                // Transport
                TransportTypes = transportCheckedListBoxType.CheckedItems.OfType<string>(),
                YourCountry = transportFromCountryTxtBox.Text,
                YourCity = transportFromCityTxtBox.Text,
                TransportPrice = new Range<int?>
                {
                    Min = !String.IsNullOrEmpty(transportPriceLowRange.Text) ? Int32.Parse(transportPriceLowRange.Text) : (int?)null,
                    Max = !String.IsNullOrEmpty(transportPriceHighRange.Text) ? Int32.Parse(transportPriceHighRange.Text) : (int?)null
                },
                // Activities
                EventDate = new Range<DateTime?>()
                {
                    Min = recreationStartDatePicker.Text != null ? DateTime.Parse(recreationStartDatePicker.Text) : (DateTime?)null,
                    Max = recreationEndDatePicker.Text != null ? DateTime.Parse(recreationEndDatePicker.Text) : (DateTime?)null,
                },
                ActivityTypes = recreationCheckedListBoxActivities.CheckedItems.OfType<string>(),
                TouristAttractionsPrice = new Range<int?>
                {
                    Min = !String.IsNullOrEmpty(activityPriceLowRange.Text) ? Int32.Parse(activityPriceLowRange.Text) : (int?)null,
                    Max = !String.IsNullOrEmpty(activityPriceHighRange.Text) ? Int32.Parse(activityPriceHighRange.Text) : (int?)null
                },
            };
            return model;
        }

        public void ClearAllValues()
        {
            // Location
            transportTextBoxCountry.Clear();
            transportTextBoxCity.Clear();
            transportTextBoxNoRooms.Clear();
            transportTextBoxPlpPerRoom.Clear();
            transportTextBoxHotelStarsLow.Clear();
            transportTextBoxHotelStarsHigh.Clear();
            hotelTextBoxPriceLowRange.Clear();
            hotelTextBoxPriceHighRange.Clear();

            // Transportation
            transportFromCountryTxtBox.Clear();
            transportFromCityTxtBox.Clear();
            transportPriceLowRange.Clear();
            transportPriceHighRange.Clear();

            // Recreation items
            activityPriceLowRange.Clear();
            activityPriceHighRange.Clear();
            ClearCheckBoxList(recreationCheckedListBoxActivities);
            ClearCheckBoxList(transportCheckedListBoxType);

            SetupDefaultValues();
        }

        private void ClearCheckBoxList(CheckedListBox myList)
        {
            foreach (int i in myList.CheckedIndices)
            {
                myList.SetItemCheckState(i, CheckState.Unchecked);
            }
            myList.ClearSelected();
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

        private void FormAgentFormClosed(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }
    }
}