using PoliAnimal.Contratcs;
using System.Windows.Forms;

namespace PoliAnimal.Class
{
    public partial class Whale: Animal, WhaleContract, WaterAnimalContract
    {

        public Whale(string name="") {
            Name = name.Trim();
        }

        public override void eat()
        {
            string sentence = Name.Equals("")
                ?"The whale is eating..."
                : $"The {Name} is eating...";
            MessageBox.Show(sentence);
        }

        public void swin()
        {
            string sentence = Name.Equals("")
                ? "The whale is swining..."
                : $"The {Name} is swining...";
            MessageBox.Show(sentence);
        }

        public void jump()
        {
            string sentence = Name.Equals("")
                 ? "The whale is jumping..."
                 : $"The {Name} is jumping...";
            MessageBox.Show(sentence);
        }
    }
}
