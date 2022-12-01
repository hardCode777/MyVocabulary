using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Media;
 
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
                //if (words[index].TranslationWord.Contains(exerciseTextArea.Text))
                //if (words[index].TranslationWord == exerciseTextArea.Text)
                //if(words[index].TranslationWord.Equals(exerciseTextArea.Text))
                int result = string.Compare(words[index].TranslationWord, exerciseTextArea.Text);
                if(result==0)
                {
                    trueFalseLable.Text = "Верно!";
                    
                }
                else
                {
                    trueFalseLable.Text = "Неверно!";
                    SystemSounds.Beep.Play();
                }
                   
            }
            else
            {
                //if (words[index].EnglishWord.Contains(exerciseTextArea.Text))
                //if (words[index].EnglishWord == exerciseTextArea.Text)
                //if(words[index].EnglishWord.Equals(exerciseTextArea.Text))
                int result = string.Compare(words[index].EnglishWord,exerciseTextArea.Text);
                if(result==0)
                {
                    trueFalseLable.Text = "Верно!";
                   
                }
                else
                {
                    trueFalseLable.Text = "Неверно!";
                    SystemSounds.Beep.Play();
                }
            }    


        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            exerciseTextArea.Clear();
            //trueFalseLable.BackColor = BackColor;
            trueFalseLable.Text = "";

        }

        private void ListExercise_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void rundomButton_Click(object sender, EventArgs e)
        {
            ListExercise.Items.Clear();
            words.Ramdomize();
            for (int i = 0; i < words.Count; i++)
            {
                ListExercise.Items.Add(languageCheckBox.Checked ? words[i].EnglishWord : words[i].TranslationWord);
            }

        }
    }
}
