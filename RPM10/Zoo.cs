using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPM10
{
    public abstract class Animal
    {
        // id животного
        public int ID { get; set; }
        // название животного
        public string Name { get; set; }
        //возраст
        public int Age { get; set; }
        //вес
        public double Weight { get; set; }
        //тип животного
        public abstract string Animals { get; }
        /// <summary>
        /// обновление информации о животном
        /// </summary>
        /// <param name="id"> id животного </param>
        /// <param name="name"> название животного </param>
        /// <param name="age"> возраст </param>
        /// <param name="weight"> вес </param>
        public abstract void UpdateAnimals(int id,string name, int age, double weight);

        public override string ToString()
        {
            return $"{Animals}:{ID} {Name}, возраст: {Age}, вес: {Weight}.";
        }
    }

    public class Mammals : Animal
    {
        public override string Animals
        {
            get { return "Mлекопитающее"; }
        }

        public override void UpdateAnimals(int id, string name, int age, double weight)
        {
            ID = id;
            Name = name;
            Age = age;
            Weight = weight;
        }

    }

    public class Artiodactyls : Animal
    {
        public override string Animals
        {
            get { return "Парнокопытное"; }
        }

        public override void UpdateAnimals(int id, string name, int age, double weight)
        {
            ID = id;
            Name = name;
            Age = age;
            Weight = weight;
        }
    }

    public class Birds: Animal
    {
        public override string Animals
        {
            get { return "Птица"; }
        }

        public override void UpdateAnimals(int id, string name, int age, double weight)
        {
            ID = id;
            Name = name;
            Age = age;
            Weight = weight;
        }

    }

}
    

