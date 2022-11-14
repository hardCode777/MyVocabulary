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
        List<Word> words = new List<Word>();
        public ViewForm()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

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

        private void ViewForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            StreamWriter fileWriter = new StreamWriter("vocabuary.txt");
            foreach (var item in words)
            {
                fileWriter.WriteLine
        ($"{item.EnglishWord}|{item.TranslationWord}|{item.Transcription}|{item.Reference}|{item.Examples}");
            }
            fileWriter.Close();
        }
    }
    public class Word
    {
        string englishWord;
        string translationWord;
        public string Transcription { get; set; }
        public string Reference { get; set; }
        public string Examples { get; set; }

        public string EnglishWord
        {
            get => englishWord;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new Exception("Empty english word");
                }
                else
                    englishWord = value;
            }
        }
        public string TranslationWord
        {
            get => translationWord;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new Exception("Empty translation word");
                }
                else
                    translationWord = value;
            }
        }
        public Word(string eng, string transl, string scrip, string refer, string note)
        {
            EnglishWord = eng;
            TranslationWord = transl;
            Transcription = scrip;
            Reference = refer;
            Examples = note;
        }

    }
              
    }

       
