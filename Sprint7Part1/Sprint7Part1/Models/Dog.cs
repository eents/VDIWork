using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Sprint7Part1.Models
{
    class Dog
    {
        public int Age { get; set; }

        protected int weight;

        public int Weight
        {
            get => weight;
            set
            {
                weight = value;
            }
        }

        protected string name;

        public string Name
        {
            get => name;
            set
            {
                name = value;
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

        public string About()
        {
            return $"Hello my name is {Name}. I am {Age} years old and I weigh {Weight} pounds.";
        }
    }
}
