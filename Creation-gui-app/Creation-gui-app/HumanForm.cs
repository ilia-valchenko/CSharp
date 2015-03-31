using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace Creation_gui_app
{
    public partial class HumanForm : Form
    {
        Human human = new Human();
        Image img = Image.FromFile("../../img/human-default-mini.jpg");

        public HumanForm()
        {
            InitializeComponent();

            switch(human.Race)
            {
                case(TypeRace.europid):
                    img = Image.FromFile("../../img/europid-mini.jpg");
                    break;

                case(TypeRace.negroid):
                    img = Image.FromFile("../../img/negroid-mini.jpg");
                    break;

                case(TypeRace.indigenous):
                    img = Image.FromFile("../../img/indigenous-mini.jpg");
                    break;

                case(TypeRace.asian):
                    img = Image.FromFile("../../img/asian-mini.jpg");
                    break;
            }

            // Added RichTextBox content
            richTextBox1.Text = "  Name: " + human.Name + "\n" +
                                "\n  Race: " + human.Race + "\n" +
                                "\n  Color Eyes: " + human.Eyes.Color_eyes + " (Dominant: " + human.Eyes.Dominant + ")\n" +
                                "\n  Color Hair: " + human.Hair.Color_hair + " (Dominant: " + human.Hair.Dominant + ")";
        }

        private void NewHumanButton_Click(object sender, EventArgs e)
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

        // Redraw on resize.
        private void HumanForm_Load(object sender, EventArgs e)
        {
            ResizeRedraw = true;
        }


        private void HumanForm_Paint(object sender, PaintEventArgs e)
        {

        }

        // Draw an ellipse on the PictureBox.
        private void picEllipse_Resize(object sender, EventArgs e)
        {
            picture.Refresh();
        }

        private void picEllipse_Paint(object sender, PaintEventArgs e)
        {
           

            // Create parallelogram for drawing image.
            Point Corner1 = new Point(0, 0);
            Point Corner2 = new Point(150, 0);
            Point Corner3 = new Point(0, 200);
            Point[] destPara = { Corner1, Corner2, Corner3};

            // Draw image to screen.
            e.Graphics.DrawImage(img, destPara);    
        }

        private void HumanPlusBirdButton_Click(object sender, EventArgs e)
        {
            HumanPlusBirdForm form = new HumanPlusBirdForm();
            form.Show();
            this.Hide();
        }

        private void HumanPlusDogButton_Click(object sender, EventArgs e)
        {
            HumanPlusDogForm form = new HumanPlusDogForm();
            form.Show();
            this.Hide();
        }
    }
}
