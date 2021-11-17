using System;
using System.Collections.Generic;
using System.Text;

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
    }
}
