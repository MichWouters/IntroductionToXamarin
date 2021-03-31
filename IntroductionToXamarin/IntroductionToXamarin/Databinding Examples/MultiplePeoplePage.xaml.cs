using System;
using System.Collections.Generic;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace IntroductionToXamarin
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MultiplePeoplePage : ContentPage
    {
        private List<Person> _people;

        public MultiplePeoplePage()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            _people = GetPeople();
            MyPeople.ItemsSource = _people;
        }

        private List<Person> GetPeople()
        {
            return new List<Person>
            {
                new Person
                {
                    Name = "Michiel",
                    Address = "Somewhere",
                    Age = 33
                },
                new Person
                {
                    Name = "Jake",
                    Address = "Nowhere",
                    Age = 18
                },
                new Person
                {
                    Name = "Frank",
                    Address = "Brussel",
                    Age = 35
                }
            };
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Console.WriteLine(_people);
        }
    }
}