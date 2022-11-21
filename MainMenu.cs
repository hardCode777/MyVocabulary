using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace MyVocabulary
{
    
    public partial class MainMenu : Form
    {
        Words words = new Words();
        public MainMenu()
        {
            InitializeComponent();
        }

        private void viewButton_Click(object sender, EventArgs e)
        {
            ViewForm viewForm = new ViewForm(words);
            viewForm.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Text");
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            try
            {
                words.ReadFile();
                counterLabel.Text = words.Count.ToString();
            }
            catch (Exception)
            {

                MessageBox.Show("Ошибка чтения файла") ;
            }
           
        }

        private void exerciseButton_Click(object sender, EventArgs e)
        {
            ExerciseForm exerciseForm = new ExerciseForm(words);
            exerciseForm.ShowDialog();
        }
    }

}
