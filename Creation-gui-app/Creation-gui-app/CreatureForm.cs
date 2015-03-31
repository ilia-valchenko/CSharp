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
    public partial class CreatureForm : Form
    {
        Creature creature = new Creature();
        string path = @"D:\Projects\Creation-gui-app\Creation-gui-app\img\creature-default-mini.jpg"; 

        public CreatureForm()
        {
            InitializeComponent();

            switch (creature.Motion.Type_motion)
            {
                case(TypeMotion.foot):
                    switch (creature.Cover.Type_cover)
                    {
                        case(TypeCover.leather):
                            path = @"D:\Projects\Creation-gui-app\Creation-gui-app\img\creature5-mini.jpg";
                            break;
                        case(TypeCover.plumage):
                            path = @"D:\Projects\Creation-gui-app\Creation-gui-app\img\creature4-mini.jpg";
                            break;
                        case(TypeCover.scales):
                            path = @"D:\Projects\Creation-gui-app\Creation-gui-app\img\creature-default-mini.jpg";
                            break;
                        case(TypeCover.wool):
                            path = @"D:\Projects\Creation-gui-app\Creation-gui-app\img\creature9-mini.jpg";
                            break;
                    }
                    break;

                case(TypeMotion.creep):
                    switch (creature.Cover.Type_cover)
                    {
                        case (TypeCover.leather):
                            path = @"D:\Projects\Creation-gui-app\Creation-gui-app\img\creature10-mini.jpg";
                            break;
                        case (TypeCover.plumage):
                            path = @"D:\Projects\Creation-gui-app\Creation-gui-app\img\creature12-mini.jpg";
                            break;
                        case (TypeCover.scales):
                            path = @"D:\Projects\Creation-gui-app\Creation-gui-app\img\creature13-mini.jpg";
                            break;
                        case (TypeCover.wool):
                            path = @"D:\Projects\Creation-gui-app\Creation-gui-app\img\creature11-mini.jpg";
                            break;
                    }
                    break;

                case (TypeMotion.fly):
                    switch (creature.Cover.Type_cover)
                    {
                        case (TypeCover.leather):
                            path = @"D:\Projects\Creation-gui-app\Creation-gui-app\img\creature14-mini.jpg";
                            break;
                        case (TypeCover.plumage):
                            path = @"D:\Projects\Creation-gui-app\Creation-gui-app\img\creature15-mini.jpg";
                            break;
                        case (TypeCover.scales):
                            path = @"D:\Projects\Creation-gui-app\Creation-gui-app\img\creature16-mini.jpg";
                            break;
                        case (TypeCover.wool):
                            path = @"D:\Projects\Creation-gui-app\Creation-gui-app\img\creature17-mini.jpg";
                            break;
                    }
                    break;

                case (TypeMotion.swim):
                    switch (creature.Cover.Type_cover)
                    {
                        case (TypeCover.leather):
                            path = @"D:\Projects\Creation-gui-app\Creation-gui-app\img\creature-default-mini.jpg";
                            break;
                        case (TypeCover.plumage):
                            path = @"D:\Projects\Creation-gui-app\Creation-gui-app\img\creature18-mini.jpg";
                            break;
                        case (TypeCover.scales):
                            path = @"D:\Projects\Creation-gui-app\Creation-gui-app\img\creature19-mini.jpg";
                            break;
                        case (TypeCover.wool):
                            path = @"D:\Projects\Creation-gui-app\Creation-gui-app\img\creature17-mini.jpg";
                            break;
                    }
                    break;
            }

            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = new Bitmap(path);
            // Added RichTextBox content
            richTextBox1.Text = "  Name: " + creature.Name + "\n" +
                                "\n  Motion: " + creature.Motion.Type_motion + " (Dominant: " + creature.Motion.Dominant + ")\n" +
                                "\n  Cover: " + creature.Cover.Type_cover + " (Dominant: " + creature.Cover.Dominant + ")\n" +
                                "\n  Food:" + creature.Food.Type_food + " (Dominant: " + creature.Food.Dominant + ")\n" +
                                "\n  Color Eyes: " + creature.Eyes.Color_eyes + " (Dominant: " + creature.Eyes.Dominant + ")\n" +
                                "\n  Color Hair/Wool/Plumage: " + creature.Hair.Color_hair + " (Dominant: " + creature.Hair.Dominant + ")\n";
         }

        private void BackToMenuButton_Click_1(object sender, EventArgs e)
        {
            StartForm form = new StartForm();
            form.Show();
            this.Hide();
        }

        private void NewCreatureButton_Click(object sender, EventArgs e)
        {
            CreatureForm form = new CreatureForm();
            form.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
