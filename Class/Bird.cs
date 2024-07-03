using PoliAnimal.Contratcs;
using System.Windows.Forms;

namespace PoliAnimal.Class
{
    public partial class Bird : Animal, BirdContract, AirAnimalContract
    {
        public Bird(string name="") {
            Name = name.Trim();
        }

        public override void eat()
        {
            string sentence = Name.Equals("")
                ? "The bird is eating..."
                : $"The {Name} is eating...";
            MessageBox.Show(sentence);
        }

        public void fly()
        {
            string sentence = Name.Equals("")
               ? "The bird is flying..."
               : $"The {Name} is flying...";
            MessageBox.Show(sentence);
        }

        public void sing()
        {
            string sentence = Name.Equals("")
              ? "The bird is singing..."
              : $"The {Name} is singing...";
            MessageBox.Show(sentence);
        }
    }
}
