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
    public partial class StartForm : Form
    {
        public StartForm()
        {
            InitializeComponent();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void CreateCreatureButton_Click(object sender, EventArgs e)
        {
            CreatureForm form = new CreatureForm();
            form.Show();
            this.Hide();
        }

        private void CreateHuman_Click(object sender, EventArgs e)
        {
            HumanForm form = new HumanForm();
            form.Show();
            this.Hide();
        }
    }
}
