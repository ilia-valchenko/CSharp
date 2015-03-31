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
    public partial class HumanPlusBirdForm : Form
    {
        Image imgHuman = Image.FromFile("../../img/human-default-mini.jpg");
        Image imgBird = Image.FromFile("../../img/bird-default-mini.jpg");
        Image imgCreature = Image.FromFile("../../img/creature-default-mini.jpg");

        public HumanPlusBirdForm()
        {
            Human human = new Human();
            Bird bird = new Bird();
            //pseudo 
            Creature human2 = new Human(human.Race, new Eyes(human.Eyes.Color_eyes, human.Eyes.Dominant), new Hair(human.Hair.Color_hair, human.Hair.Dominant));
            Creature bird2 = new Bird(new Eyes(bird.Eyes.Color_eyes, bird.Eyes.Dominant), new Hair(bird.Hair.Color_hair, bird.Hair.Dominant), new Break(bird.Break.Type_break, bird.Break.Dominant), new WaterfowlBird(bird.Waterfowl.IsWaterfowl, bird.Waterfowl.Dominant));
            //result
            Creature creature = human2 + bird2;

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

            if (bird.Waterfowl.IsWaterfowl)
                imgBird = Image.FromFile("../../img/duck-mini.jpg");
            else
            {
                switch (bird.Break.Type_break)
                {
                    case(TypeBreak.water):
                        imgBird = Image.FromFile("../../img/duck-mini.jpg");
                        break;

                    case (TypeBreak.granivorous):
                        imgBird = Image.FromFile("../../img/bird-granivorous-mini.jpg");
                        break;

                    case (TypeBreak.insectivorous):
                        imgBird = Image.FromFile("../../img/bird-insectivorous-mini.jpg");
                        break;

                    case (TypeBreak.predatory):
                        imgBird = Image.FromFile("../../img/bird-predatory-mini.jpg");
                        break;
                }
            }

            switch (creature.Motion.Type_motion)
            {
                case(TypeMotion.foot):
                    if(creature.Cover.Type_cover.Equals(TypeCover.leather))
                        imgCreature = Image.FromFile("../../img/human-bird-foot-leather-mini.jpg");
                    else
                        imgCreature = Image.FromFile("../../img/human-bird-foot-plumage-mini.jpg");
                    break;

                case(TypeMotion.fly):
                    if (creature.Cover.Type_cover.Equals(TypeCover.leather))
                        imgCreature = Image.FromFile("../../img/human-bird-fly-leather-mini.jpg");
                    else
                        imgCreature = Image.FromFile("../../img/human-bird-fly-plumage-mini.jpg");
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

            //Add bird content
            richTextBox2.Text = "  Name: " + bird.Name + "\n" +
                                "\n  Color Eyes: " + bird.Eyes.Color_eyes + " (Dominant: " + bird.Eyes.Dominant + ")\n" +
                                "\n  Color Plumage: " + bird.Hair.Color_hair + " (Dominant: " + bird.Hair.Dominant + ")\n" +
                                "\n  Motion: " + bird.Motion.Type_motion + " (Dominant: " + bird.Motion.Dominant + ")\n" +
                                "\n  Cover: " + bird.Cover.Type_cover + " (Dominant: " + bird.Cover.Dominant + ")\n" +
                                "\n  Food: " + bird.Food.Type_food + "(Dominant: " + bird.Food.Dominant + ")\n" +
                                "\n  Break: " + bird.Break.Type_break + "(Dominant: " + bird.Break.Dominant + ")\n" +
                                "\n  Is Waterfowl: " + bird.Waterfowl.IsWaterfowl + "(Dominant: " + bird.Waterfowl.Dominant + ")\n";

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

        private void BackToMainMenu_Click(object sender, EventArgs e)
        {
            StartForm form = new StartForm();
            form.Show();
            this.Hide();
        }

        private void NewHumanPlusBird_Click(object sender, EventArgs e)
        {
            HumanPlusBirdForm form = new HumanPlusBirdForm();
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

        //Draw bird
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

            e.Graphics.DrawImage(imgBird, destPara);
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

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
