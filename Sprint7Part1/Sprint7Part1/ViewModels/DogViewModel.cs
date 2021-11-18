using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using Sprint7Part1.Models;

namespace Sprint7Part1.ViewModels
{
    class DogViewModel : BaseViewModel
    {

        Dog d;

        public DogViewModel(Dog dog)
        {
            this.d = dog;
        }

        public int Age
        {
            get
            {
                return d.Age;
            }
        }

        public int Weight
        {
            get { return d.Weight; }
            set { d.Weight = value;
                OnPropertyChanged();
                OnPropertyChanged("AboutString");       
            }
        }

        public string Name
        {
            get { return d.Name; }
            set { d.Name = value;
                OnPropertyChanged();
                OnPropertyChanged("AboutString");
            }
        }

        public string AboutString
        {
            get { return d.About(); }
        }

    }
}
