using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using Newtonsoft.Json;
using System.Xml.Serialization;
using System.Threading.Tasks;
/*
 Разработай класс "Flower" с полями для имени цветка, его высоты и уровня здоровья.
Реализуй методы для увеличения высоты и изменения уровня здоровья цветка.
 */
namespace _15_11_23_C_Sharp_LINQ_JISON_Task_Flowers
{
    public class Flower : IInformationDisplay
    {
        public string Name { get; set; }
        public float Height { get; set; }
        public float Health { get; set; }

        public Flower(string name, float height, float health) 
        {
            Name = name;
            Height = height;
            Health = health;
        }
        public void ShowInformations() 
        {
        
        }

        public void IncreaseHeight(float amount)
        {
            Height += amount;
            Console.WriteLine($"Flower{Name} hase grown to {Height} cm");
        }

        public void ChangeHealthLevel(float amount) 
        {
            Health = amount;
            Console.WriteLine($"Flower {Name} health level is now {Health}");
        }

    }

}
