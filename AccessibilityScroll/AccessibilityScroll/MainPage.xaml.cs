using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AccessibilityScroll
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public IList<Dog> Dogs { get; private set; }

        public MainPage()
        {
            InitializeComponent();
            Dogs = new List<Dog>();
            Dogs.Add(new Dog
            {
                Name = "Alpha",
                Breed = "Bulldog"
            });
            Dogs.Add(new Dog
            {
                Name = "Teddy",
                Breed = "Poodle"
            });
            Dogs.Add(new Dog
            {
                Name = "Jack",
                Breed = "Beagle"
            });
            Dogs.Add(new Dog
            {
                Name = "Toby",
                Breed = "Dobermann"
            });
            Dogs.Add(new Dog
            {
                Name = "Ollie",
                Breed = "Maltese"
            });
            Dogs.Add(new Dog
            {
                Name = "Archie",
                Breed = "Alaskan Malamute"
            });
            Dogs.Add(new Dog
            {
                Name = "Milo",
                Breed = "Bull Terrier"
            });
            Dogs.Add(new Dog
            {
                Name = "Buddy",
                Breed = "Shiba Inu"
            });
            Dogs.Add(new Dog
            {
                Name = "Max",
                Breed = "Labradoodle"
            });
            Dogs.Add(new Dog
            {
                Name = "Charlie",
                Breed = "Great Dane"
            });

            //Female dogs
            Dogs.Add(new Dog
            {
                Name = "Frankie",
                Breed = "Siberian Husky"
            });
            Dogs.Add(new Dog
            {
                Name = "Lola",
                Breed = "Beagle"
            });
            Dogs.Add(new Dog
            {
                Name = "Rosie",
                Breed = "French Bulldog"
            });
            Dogs.Add(new Dog
            {
                Name = "Daisy",
                Breed = "Pomeranian"
            });
            Dogs.Add(new Dog
            {
                Name = "Bailey",
                Breed = "Cavalier King Charles Spaniel"
            });           
            BindingContext = this;
        }
    }
}
