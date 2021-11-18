using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Input;
using Sprint7Part1.Models;

namespace Sprint7Part1.ViewModels
{
    class DogViewModel : BaseViewModel
    {

        Dog d;

        public ICommand HappyBirthdayCommand { get; set; }

        public DogViewModel(Dog dog)
        {
            this.d = dog;
            HappyBirthdayCommand = new BasicCommand(ExecuteHappyBirthday, CanExecuteHappyBirthday);
        }

        private bool CanExecuteHappyBirthday(object parameter)
        {
            return true;
        }

        private void ExecuteHappyBirthday(object parameter)
        {
            throw new NotImplementedException();
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
