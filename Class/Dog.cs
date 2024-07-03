using PoliAnimal.Contratcs;
using System.Windows.Forms;

namespace PoliAnimal.Class
{
    public partial class Dog: Animal, DogContract, LandAnimalContract, WaterAnimalContract
    {
        public Dog(string name=""){
            Name = name.Trim();
        }

        public override void eat()
        {
            string sentence = this.Name != "" ?
                "The little dog " + this.Name + " is eating..." :
                "The little dog is eating...";
            MessageBox.Show(sentence);
        }

        public void jump()
        {
            string sentence = this.Name != "" ?
               "The little dog " + this.Name + " is jumping..." :
               "The little dog is jumping...";
            MessageBox.Show(sentence);
        }

        public void run()
        {
            string sentence = this.Name != "" ?
               "The little dog " + this.Name + " is running..." :
               "The little dog is running...";
            MessageBox.Show(sentence);
        }

        public void walk()
        {
            string sentence = this.Name != "" ?
                           "The little dog " + this.Name + " is walking..." :
                           "The little dog is walking...";
            MessageBox.Show(sentence);
        }

        public void swin()
        {
            string sentence = this.Name != "" ?
                           "The little dog " + this.Name + " is swining..." :
                           "The little dog is swining...";
            MessageBox.Show(sentence);
        }

        public void bark()
        {
            string sentence = this.Name != "" ?
                           "The little dog " + this.Name + " is barking..." :
                           "The little dog is barking...";
            MessageBox.Show(sentence);
        }
    }
}
