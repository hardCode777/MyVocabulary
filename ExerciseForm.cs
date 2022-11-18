using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MyVocabulary
{
    public partial class ExerciseForm : Form
    {
        Words words;
        public ExerciseForm(Words words)
        {
            InitializeComponent();
            this.words = words;
            for (int i = 0; i < words.Count; i++)
            {
                ListExercise.Items.Add(words[i].EnglishWord);
            }
            

        }

        private void ExerciseForm_Load(object sender, EventArgs e)
        {
            
        }

        private void languageCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            

        }
    }
}
