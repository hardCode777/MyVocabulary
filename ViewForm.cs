using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace MyVocabulary
{
    public partial class ViewForm : Form
    {
        Words words;
        Button upDate;
        ComboBox sortButton;


        public ViewForm(Words words)
        {

            InitializeComponent();
            //
            int x = Delbutton.Left;
            int y = Delbutton.Top - 45;
            upDate = CreateButton("Update",new Point(x,y), new Size(64,40), Update_Click);
            this.Controls.Add(upDate);
            //
            y = resetbutton.Top - 45;
            x = upDate.Right;
            sortButton = CreateCB(new Point(x, y), new Size(70, 40), ComboBox_SelectedIndexChanged);
            sortButton.Items.Add("A-z");
            sortButton.Items.Add("Z-a");
            sortButton.Items.Add("Дата");
            //sortButton.Items.Add
            this.Controls.Add(sortButton);
            //
            englishWordsList.SelectedIndexChanged += EnglishWordsList_SelectedIndexChanged; // eventhandler
            //
            this.words = words;
            LoadList();

        }

        public void LoadList()
        {
            englishWordsList.Items.Clear();
            for (int i = 0; i < words.Count; i++)
            {
                englishWordsList.Items.Add(words[i].EnglishWord);
            }
            if (englishWordsList.Items.Count > 0)
            {
                englishWordsList.SelectedIndex = 0;
            }
        }
        private void EnglishWordsList_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = englishWordsList.SelectedIndex;
            if (index == -1)
            {
                return;
            }
            englishText.Text = words[index].EnglishWord;
            translationText.Text = words[index].TranslationWord;
            transcriptionText.Text = words[index].Transcription;
            referencesText.Text = words[index].Reference;
            noteText.Text = words[index].Examples;
        }

        private void Update_Click(object sender, EventArgs e)
        {
            int index = englishWordsList.SelectedIndex;
            if (index == -1)
            {
                return;
            }
            words[index].EnglishWord = englishText.Text;
            words[index].TranslationWord= translationText.Text;
            words[index].Transcription = transcriptionText.Text;
            words[index].Reference = referencesText.Text;
            words[index].Examples = noteText.Text;
        }

       
       

       

        private void addNewWord(object sender, EventArgs e)
        {
            try
            {
                Word word = new Word(englishText.Text, translationText.Text,
                transcriptionText.Text, referencesText.Text, noteText.Text);
                words.Add(word);
                englishWordsList.Items.Add(englishText.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }

        }

        private void ViewForm_FormClosed(object sender, FormClosedEventArgs e) => words.WriteFile();


        private void resetbutton_Click(object sender, EventArgs e)
        {
            englishText.Clear();
            translationText.Clear();
            transcriptionText.Clear();
            referencesText.Clear();
            noteText.Clear();
        }

        private void Delbutton_Click(object sender, EventArgs e)
        {
            int index = englishWordsList.SelectedIndex;

            if (index != -1)
            {
                englishWordsList.Items.RemoveAt(index);
                words.DelItem(index);
            }
            else
                MessageBox.Show("Список пуст");
        }

        // 
        private Button CreateButton(string name, Point location, Size size, EventHandler handler)
        {
            Button button = new Button();
            button.Text = name;
            button.Location = location;
            button.Size = size;
            button.Click += handler;
            return button;
        }
        private ComboBox CreateCB(Point location, Size size, EventHandler handler)
        {
            ComboBox comBox = new ComboBox();
            comBox.Location = location;
            comBox.Size = size;
            comBox.Click += handler;
            comBox.DropDownStyle = ComboBoxStyle.DropDownList;
            return comBox;
        }
        private void ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (sortButton.SelectedIndex)
            {
                case 0:
                    words.SortAz();
                    break;
                case 1:
                    words.SortZa();
                    break;
                case 2:
                    words.SortDate();
                    break;
            }
            LoadList();
        }

    }
}
   
              
    

       
