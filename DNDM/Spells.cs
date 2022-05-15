using DNDMLibrary.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace DNDM
{
    public partial class Spells : Form
    {
        public void PopulateDataGrid()
        {
            dataGridView1.DataSource = SQLiteSpells.LoadSpells();
        }
        
        public void PopulateMagicTypes()
        {
            magicTypeComboBox.DataSource = SQLiteSpells.LoadSchools();
            magicTypeComboBox.DisplayMember = "name";
        }

        public Spells()
        {
            InitializeComponent();
            PopulateDataGrid();
            PopulateMagicTypes();
            label5.BackColor = Color.Transparent;
        }

        private void Spells_Load(object sender, EventArgs e)
        {
            label1.BackColor = Color.Transparent;
            label2.BackColor = Color.Transparent;
            label3.BackColor = Color.Transparent;
            label4.BackColor = Color.Transparent;

            label6.BackColor = Color.Transparent;
            label7.BackColor = Color.Transparent;
            label8.BackColor = Color.Transparent;
            label9.BackColor = Color.Transparent;
            label10.BackColor = Color.Transparent;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            SpellModel spell = new SpellModel();

            spell.name = textBox1.Text;
            spell.school_id = magicTypeComboBox.SelectedIndex;
            spell.lvl = ((int)levelNumeric.Value);
            spell.casting_time = castingTimeTextBox.Text;
            spell.range = rangeTextBox.Text;
            spell.duration = durationTextBox.Text;
            spell.descr = descriptionTextBox.Text;
            spell.components = componentsTextBox.Text;


            if (spell.Validate())
            {
                if (!SQLiteSpells.CheckIfSpellExists(spell.name)) { 
                    SQLiteSpells.SaveSpell(spell); 
                    PopulateDataGrid();
                }
                else
                {
                    MessageBox.Show("Error ! Please select a new Name!");
                }
            }
            else
            {
                MessageBox.Show("Error ! Please fill out all fields!");
            }

        }

        private void textBox2_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back)
            {
                if (textBox2.Text.Equals(""))
                {
                    PopulateDataGrid();
                }
            }
            else
            {
               
                    dataGridView1.DataSource = SQLiteSpells.LoadSpellsByTitle(textBox2.Text);
                
            }
        }
    }
}
