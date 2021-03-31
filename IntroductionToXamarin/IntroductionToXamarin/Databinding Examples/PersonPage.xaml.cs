using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace IntroductionToXamarin
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PersonPage : ContentPage
    {
        private Person _john;

        public PersonPage()
        {
            InitializeComponent();
            _john = new Person
            {
                Name = "John doe",
                Age = 42,
                Address = "Nowhere lane"
            };

            BindingContext = _john;
        }

        private void OnButtonClicked(object sender, EventArgs e)
        {
            Console.WriteLine(_john);
        }
    }
}