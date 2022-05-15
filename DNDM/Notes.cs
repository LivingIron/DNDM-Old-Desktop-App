using DNDMLibrary;
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
    public partial class Notes : Form
    {

        private void PopulateDataGrid()
        {
            dataGridView1.DataSource = SQLiteNote.LoadNotes();
        }

        public Notes()
        {
            InitializeComponent();
            PopulateDataGrid();
        }

        private void Notes_Load(object sender, EventArgs e)
        {
            label1.BackColor = Color.Transparent;
            label2.BackColor = Color.Transparent;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            NotesModel note = new NotesModel();
            note.title = textBox1.Text;
            note.descr = textBox2.Text;

            bool doesExist = SQLiteNote.CheckIfNoteExists(note.title);
            if (note.Validate())
            { 
                if (doesExist)
                {
                    SQLiteNote.UpdateNote(note);
                }
                else
                {
                    SQLiteNote.SaveNote(note);
                }
            }
            else
            {
                MessageBox.Show("Error! Please fill out all boxes !");
            }

            textBox1.Clear();
            textBox2.Clear();
            PopulateDataGrid();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int index = dataGridView1.CurrentCell.RowIndex;
            if (index > -1)
            {
                NotesModel note = SQLiteNote.LoadNoteById(index + 1);
                textBox1.Text = note.title;
                textBox2.Text = note.descr;

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SQLiteNote.DeleteNote(dataGridView1.CurrentCell.RowIndex+1);
            PopulateDataGrid();
        }
    }
}
