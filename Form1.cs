using PoliAnimal.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PoliAnimal
{
    public partial class Form1 : Form
    {

        private string animalSelected { get; set; } = "";

        public Form1()
        {
            InitializeComponent();
        }


        private void btnBird_Click(object sender, EventArgs e)
        {
            listBoxSkills.Items.Clear();
            List<string> birdSkills = Bird.getSkills();
            foreach (string skill in birdSkills)
            {
                listBoxSkills.Items.Add(skill);
            }
            birdSkills.Clear();
            selectBtn(btnBird);
            animalSelected = "Bird";
            diselectBtnsExcept(btnBird);
        }

        private void btnDog_Click(object sender, EventArgs e)
        {
            listBoxSkills.Items.Clear();
            List<string> dogSkills = Dog.getSkills();
            foreach (string skill in dogSkills)
            {
                listBoxSkills.Items.Add(skill);
            }
            dogSkills.Clear();
            selectBtn(btnDog);
            animalSelected = "Dog";
            diselectBtnsExcept(btnDog);
        }

        private void btnWhale_Click(object sender, EventArgs e)
        {
            listBoxSkills.Items.Clear();
            List<string> whaleSkills = Whale.getSkills();
            foreach (string skill in whaleSkills)
            {
                listBoxSkills.Items.Add(skill);
            }
            whaleSkills.Clear();
            selectBtn(btnWhale);
            animalSelected = "Whale";
            diselectBtnsExcept(btnWhale);
        }

        private void selectBtn(Button btn)
        {
            drawPaintBorder(btn);
        }

        private void diselectBtnsExcept(Button btn)
        {
            foreach (Control control in panelHome.Controls)
            {
                if (control is Button && btn.Name != control.Name)
                {
                    Button button = (Button)control;
                    removePaintBorder(button);
                    button.Invalidate();
                }
            }
        }

        private void drawPaintBorder(Button btn)
        {
            ControlPaint.DrawBorder(
                btn.CreateGraphics(),
                btn.ClientRectangle,
                Color.Red, 2, ButtonBorderStyle.Solid,
                Color.Red, 2, ButtonBorderStyle.Solid,
                Color.Red, 2, ButtonBorderStyle.Solid,
                Color.Red, 2, ButtonBorderStyle.Solid
            );
        }

        private void removePaintBorder(Button btn)
        {
            ControlPaint.DrawBorder(
                btn.CreateGraphics(),
                btn.ClientRectangle,
                Color.Transparent, 2, ButtonBorderStyle.Solid,
                Color.Transparent, 2, ButtonBorderStyle.Solid,
                Color.Transparent, 2, ButtonBorderStyle.Solid,
                Color.Transparent, 2, ButtonBorderStyle.Solid
            );
        }

        private void listBoxSkills_SelectedIndexChanged(object sender, EventArgs e)
        {
            Type type = Type.GetType($"PoliAnimal.Class.{animalSelected}");
            object obj = Activator.CreateInstance(type, new object[] {""});
            string method = listBoxSkills.SelectedItem.ToString();
            callMethod(obj, type, method);
        }

        private void callMethod(Object class_obj, Type type, string method)
        {
            MethodInfo mtInfo = type.GetMethod(method);
            mtInfo.Invoke(class_obj, null);
        }
    }
}
