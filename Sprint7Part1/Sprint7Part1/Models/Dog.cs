using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Sprint7Part1.Models
{
    class Dog : INotifyPropertyChanged
    {
        public int Age { get; set; }

        protected int weight;

        public int Weight
        {
            get => weight;
            set
            {
                weight = value;
                OnPropertyChanged();
                OnPropertyChanged("AboutString");
            }
        }

        protected string name;

        public string Name
        {
            get => name;
            set
            {
                name = value;
                OnPropertyChanged();
                OnPropertyChanged("AboutString");
            }
        }

        public void HappyBirthday()
        {
            this.Age++;
        }

        public Dog()
        {
            this.Weight = 60;
            this.Age = 8;
            this.Name = "Daisy";
        }

        public string AboutString { get => About(); }

        public string About()
        {
            return $"Hello my name is {Name}. I am {Age} years old and I weigh {Weight} pounds.";
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged([CallerMemberName] String propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
