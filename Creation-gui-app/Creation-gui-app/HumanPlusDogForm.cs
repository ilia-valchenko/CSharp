using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Creation_gui_app
{
    public partial class HumanPlusDogForm : Form
    {
        Image imgHuman = Image.FromFile("../../img/human-default-mini.jpg");
        Image imgDog = Image.FromFile("../../img/dog-default-mini.jpg");
        Image imgCreature = Image.FromFile("../../img/creature-default-mini.jpg");

        public HumanPlusDogForm()
        {
            Human human = new Human();
            Dog dog = new Dog();
            //pseudo 
            Creature human2 = new Human(human.Race, new Eyes(human.Eyes.Color_eyes, human.Eyes.Dominant), new Hair(human.Hair.Color_hair, human.Hair.Dominant));
            Creature dog2 = new Dog(new Eyes(dog.Eyes.Color_eyes, dog.Eyes.Dominant), new Hair(dog.Hair.Color_hair, dog.Hair.Dominant), new Tail(dog.Tail.Type_tail, dog.Tail.Dominant), new Muzzle(dog.Muzzle.Type_muzzle, dog.Muzzle.Dominant), new Ears(dog.Ears.Type_ears, dog.Ears.Dominant));
            //result
            Creature creature = human2 + dog2;

            InitializeComponent();

            switch (human.Race)
            {
                case (TypeRace.europid):
                    imgHuman = Image.FromFile("../../img/europid-mini.jpg");
                    break;

                case (TypeRace.negroid):
                    imgHuman = Image.FromFile("../../img/negroid-mini.jpg");
                    break;

                case (TypeRace.indigenous):
                    imgHuman = Image.FromFile("../../img/indigenous-mini.jpg");
                    break;

                case (TypeRace.asian):
                    imgHuman = Image.FromFile("../../img/asian-mini.jpg");
                    break;
            }

            switch (dog.Muzzle.Type_muzzle)
            {
                case(TypeMuzzle.gaunt):
                    imgDog = Image.FromFile("../../img/dog-gaunt-mini.jpg");
                    break;

                case (TypeMuzzle.brief):
                    imgDog = Image.FromFile("../../img/dog-brief-mini.jpg");
                    break;

                case (TypeMuzzle.pointed):
                    imgDog = Image.FromFile("../../img/dog-pointed-mini.jpg");
                    break;

                case (TypeMuzzle.blunt):
                    imgDog = Image.FromFile("../../img/dog-blunt-mini.jpg");
                    break;
            }

            switch (creature.Cover.Type_cover)
            {
                case(TypeCover.leather):
                    imgCreature = Image.FromFile("../../img/human-dog-leather-mini.jpg");
                    break;

                case(TypeCover.wool):
                    imgCreature = Image.FromFile("../../img/human-dog-wool-mini.jpg");
                    break;
            }

            //Add human content
            richTextBox1.Text = "  Name: " + human.Name + "\n" +
                                "\n  Race: " + human.Race + "\n" +
                                "\n  Color Eyes: " + human.Eyes.Color_eyes + " (Dominant: " + human.Eyes.Dominant + ")\n" +
                                "\n  Color Hair: " + human.Hair.Color_hair + " (Dominant: " + human.Hair.Dominant + ")\n" +
                                "\n  Motion: " + human.Motion.Type_motion + " (Dominant: " + human.Motion.Dominant + ")\n" +
                                "\n  Cover: " + human.Cover.Type_cover + " (Dominant: " + human.Cover.Dominant + ")\n" +
                                "\n  Food: " + human.Food.Type_food + "(Dominant: " + human.Food.Dominant + ")\n";

            //Add dog content
            richTextBox2.Text = "  Name: " + dog.Name + "\n" +
                                "\n  Color Eyes: " + dog.Eyes.Color_eyes + " (Dominant: " + dog.Eyes.Dominant + ")\n" +
                                "\n  Color Hair: " + dog.Hair.Color_hair + " (Dominant: " + dog.Hair.Dominant + ")\n" +
                                "\n  Motion: " + dog.Motion.Type_motion + " (Dominant: " + dog.Motion.Dominant + ")\n" +
                                "\n  Cover: " + dog.Cover.Type_cover + " (Dominant: " + dog.Cover.Dominant + ")\n" +
                                "\n  Food: " + dog.Food.Type_food + "(Dominant: " + dog.Food.Dominant + ")\n" +
                                "\n  Tail: " + dog.Tail.Type_tail + "(Dominant: " + dog.Tail.Dominant + ")\n" +
                                "\n  Muzzle: " + dog.Muzzle.Type_muzzle + "(Dominant: " + dog.Muzzle.Dominant + ")\n" +
                                "\n  Ears: " + dog.Ears.Type_ears + "(Dominant: " + dog.Ears.Dominant + ")\n";

            //Add result creature content
            richTextBox3.Text = "  Name: " + creature.Name + "\n" +
                               "\n  Color Eyes: " + creature.Eyes.Color_eyes + " (Dominant: " + creature.Eyes.Dominant + ")\n" +
                               "\n  Color Hair/Wool/Plumage: " + creature.Hair.Color_hair + " (Dominant: " + creature.Hair.Dominant + ")\n" +
                               "\n  Motion: " + creature.Motion.Type_motion + " (Dominant: " + creature.Motion.Dominant + ")\n" +
                               "\n  Cover: " + creature.Cover.Type_cover + " (Dominant: " + creature.Cover.Dominant + ")\n" +
                               "\n  Food: " + creature.Food.Type_food + "(Dominant: " + creature.Food.Dominant + ")\n";
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            HumanForm form = new HumanForm();
            form.Show();
            this.Hide();
        }

        private void BackToMenuButton_Click(object sender, EventArgs e)
        {
            StartForm form = new StartForm();
            form.Show();
            this.Hide();
        }

        private void NewHumanPlusDog_Click(object sender, EventArgs e)
        {
            HumanPlusDogForm form = new HumanPlusDogForm();
            form.Show();
            this.Hide();
        }

        //Draw human
        private void pictureBox1_Load(object sender, EventArgs e)
        {
            ResizeRedraw = true;
        }

        private void pictureBox1_Resize(object sender, EventArgs e)
        {
            pictureBox1.Refresh();
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            Point Corner1 = new Point(0, 0);
            Point Corner2 = new Point(150, 0);
            Point Corner3 = new Point(0, 200);
            Point[] destPara = { Corner1, Corner2, Corner3 };

            e.Graphics.DrawImage(imgHuman, destPara);
        }

        //Draw dog
        private void pictureBox2_Load(object sender, EventArgs e)
        {
            ResizeRedraw = true;
        }

        private void pictureBox2_Resize(object sender, EventArgs e)
        {
            pictureBox1.Refresh();
        }

        private void pictureBox2_Paint(object sender, PaintEventArgs e)
        {
            Point Corner1 = new Point(0, 0);
            Point Corner2 = new Point(150, 0);
            Point Corner3 = new Point(0, 200);
            Point[] destPara = { Corner1, Corner2, Corner3 };

            e.Graphics.DrawImage(imgDog, destPara);
        }

        //Draw result creature
        private void pictureBox3_Load(object sender, EventArgs e)
        {
            ResizeRedraw = true;
        }

        private void pictureBox3_Resize(object sender, EventArgs e)
        {
            pictureBox1.Refresh();
        }

        private void pictureBox3_Paint(object sender, PaintEventArgs e)
        {
            Point Corner1 = new Point(0, 0);
            Point Corner2 = new Point(150, 0);
            Point Corner3 = new Point(0, 200);
            Point[] destPara = { Corner1, Corner2, Corner3 };

            e.Graphics.DrawImage(imgCreature, destPara);
        }
    }
}
