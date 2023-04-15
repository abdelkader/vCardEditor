using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Thought.vCards;

namespace vCardEditor.View.Customs
{
    public partial class AddressBox : UserControl
    {
        public event EventHandler TextChangedEvent;
        public List<vCardDeliveryAddressTypes> AddressType { get; set; }
        

        public AddressBox(string street, string city, string region, string country, string postalCode, 
            string extendedAddress, string postOfficeBox, List<vCardDeliveryAddressTypes> addressType)
        {
            InitializeComponent();

            this.AddressType = addressType;
            CityValue.Text = city;
            CityValue.oldText = city;

            CountryValue.Text = country;
            CountryValue.oldText = country;

            ZipValue.Text = postalCode;
            ZipValue.oldText = postalCode;

            RegionValue.Text = region;
            RegionValue.oldText = region;

            StreetValue.Text = street;
            StreetValue.oldText = street;

            ExtAddrValue.Text = extendedAddress;
            ExtAddrValue.oldText = extendedAddress;

            POBoxValue.Text = postOfficeBox;
            POBoxValue.oldText = postOfficeBox;
        }

        private void Value_TextChanged(object sender, EventArgs e)
        {
            TextChangedEvent?.Invoke(sender, e);
        }

        public vCardDeliveryAddress getDeliveryAddress()
        {
            var deliveryAddress = new vCardDeliveryAddress
            {
                City = CityValue.Text,
                Country = CountryValue.Text,
                PostalCode = ZipValue.Text,
                Region = RegionValue.Text,
                Street = StreetValue.Text,
                ExtendedAddress = ExtAddrValue.Text,
                PostOfficeBox = POBoxValue.Text,
                AddressType = AddressType
            };

            return deliveryAddress;
        }
       
    }
}
