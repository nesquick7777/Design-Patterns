using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    public class Animal
    {
        private String name;
        private int weight;
        private double height;
        private String sound;

        

        public void setName(String newName)
        {
            name = newName;
        }

        public String getName()
        {
            return name;
        }

        public void setWeight(int newWeight)
        {
            if (newWeight >0 ) {
                weight = newWeight;
            }
            
            else {
                Console.WriteLine("Weight must be bigger than 0");
            }
        }

        public int getWeight() { 
            return weight;
        }

        public void setSound(String newSound)
        {
            sound = newSound;
        }

        public String getSound()
        {
            return sound;
        }

    }
}
