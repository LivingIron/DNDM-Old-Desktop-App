using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DNDM
{
    public partial class DMScreen : Form
    {
        public DMScreen()
        {
            InitializeComponent();
        }

        private void DMScreen_Load(object sender, EventArgs e)
        {
            label1.BackColor = Color.Transparent;
        }

        private void DiceRollerButton_Click(object sender, EventArgs e)
        {
            var DiceRoller = new DiceRoller();
            DiceRoller.Show();
            this.Close();
        }
    }
}
