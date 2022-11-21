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
            //this.CancelButton = clearButton;
            //languageCheckBox.Checked = true;
        }

        private void ExerciseForm_Load(object sender, EventArgs e)
        {
            
        }

        private void languageCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            ListExercise.Items.Clear();
            for (int i = 0; i < words.Count; i++)
            {
                ListExercise.Items.Add(languageCheckBox.Checked ? words[i].EnglishWord : words[i].TranslationWord);
            }

        }

        private void compareButton_Click(object sender, EventArgs e)
        {
            int index = ListExercise.SelectedIndex;
            if (index == -1)
            {
                return;
            }

            if (languageCheckBox.Checked)
            {
                if (words[index].TranslationWord.Contains(exerciseTextArea.Text))
                {
                    trueFalseLable.Text = "Верно!";
                }
                else
                    trueFalseLable.Text = "Неверно!";
            }
            else
            {
                if (words[index].EnglishWord.Contains(exerciseTextArea.Text))
                {
                    trueFalseLable.Text = "Верно!";
                }
                else
                    trueFalseLable.Text = "Неверно!";
            
            }    


        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            exerciseTextArea.Clear();
            trueFalseLable.Text = "";

        }
        //private void ListLoud()
        //{
        //    for (int i = 0; i < words.Count; i++)
        //    {
        //        ListExercise.Items.Add(languageCheckBox.Checked ? words[i].EnglishWord : words[i].TranslationWord);
        //    }

        //}

    }
}
