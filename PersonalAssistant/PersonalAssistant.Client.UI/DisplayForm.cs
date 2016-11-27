using System;
using System.Linq;

namespace PersonalAssistant.Client.UI
{
    using System.Windows.Forms;

    public partial class DisplayForm : Form
    {
        public DisplayForm()
        {
            InitializeComponent();
            SetupDefaultValues();
        }

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
            textBoxMessages.AppendText(s + Environment.NewLine);
        }

        private void FormAgent_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0); // closes all open forms and exits the application
        }

        private void buttonSeach_Click(object sender, EventArgs e)
        {
            ReadInfoFromForm();
            // create agents
        }

        public void ReadInfoFromForm()
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
            var listOfTranports = transportTypes.OfType<string>();

            // Recreation items
            var countryEvents = recreationTextBoxCountry.Text;
            var cityEvents = recreationTextBoxCity.Text;
            var startDateEvents = recreationStartDatePicker.Text;
            var endDateEvents = recreationEndDatePicker.Text;
            var eventsType = recreationCheckedListBoxActivities.CheckedItems;
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

        private void buttonClear_Click(object sender, EventArgs e)
        {
            ClearAllValues();
        }
    }
}