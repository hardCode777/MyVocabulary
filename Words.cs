using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Windows.Forms;
using System.Collections;

namespace MyVocabulary
{
    public class Words 
    {
        const string fileName= "vocabuary.txt";
        List<Word> words;

        public int Count => words.Count; 
        public Word this [int index]
        {
            get => words[index];
            set => words[index] = value;
        }
        public Words()
        {
            words = new List<Word>();
        }
        public void Add(Word w)
        {
            words.Add(w);
        }
        public void DelItem(int index)
        {
            words.RemoveAt(index);
        }
        public void WriteFile()
        {
            StreamWriter fileWriter = new StreamWriter(fileName);
            
            for (int i = 0; i < words.Count; i++)
            {
                fileWriter.WriteLine
               ($"{words[i].EnglishWord}|{words[i].TranslationWord}|{words[i].Transcription}|" +
               $"{words[i].Reference}|{words[i].Examples}|{words[i].Date}");
            }
            fileWriter.Close();
        }
        public void ReadFile()
        {
            StreamReader reader = new StreamReader(fileName);

            var stringS = reader.ReadLine();
            while (stringS!=null)
            {
                string[] items = stringS.Split('|', StringSplitOptions.None); //!!!!
                if (items.Length < 5)
                {
                    MessageBox.Show($"Ошибка в слове {items[0]}");
                }
                else
                {
                    Word word = new Word(items[0], items[1], items[2], items[3], items[4], 
                        Convert.ToDateTime(items[5]) );
                    words.Add(word);
                }
                stringS = reader.ReadLine();
            }
            reader.Close();
            
        }
        public void SortAz()
        {
            //words.Sort(new WorsComparerAZ());
            words.Sort((w1, w2) => string.Compare(w1.EnglishWord, w2.EnglishWord));
        }
        public void SortZa()
        {
            //words.Sort(new WorsComparerZA());
            words.Sort((w2, w1) => string.Compare(w1.EnglishWord, w2.EnglishWord));
        }
        public void SortDateDown()
        {
            //words.Sort(new WordsComparerDate());
            words.Sort((w1, w2) => w1.Date.CompareTo(w2.Date));
        }
        public void SortDateUp()
        {
            //words.Sort(new WordsComparerDate());
            words.Sort((w1, w2) => w2.Date.CompareTo(w1.Date));
        }
        public void Ramdomize()  //!!!!!!!!!!!!
        {
            for (int i = 0; i < words.Count-2; i++)
            {
                Word temp;
                if (i%2==0 || i%3==0)
                {
                    temp = words[i];
                    words[i] = words[i + 1];
                    words[i+1] = temp;
                }
                for (int j = words.Count-1; j > 0; j--)
                {
                    if (i%5==0 || i%4==0)
                    {
                        temp = words[j];
                        words[j] = words[j - 1];
                        words[j - 1] = temp;
                    }
                }
               
            }
        }
        public IEnumerator GetEnumerator() => words.GetEnumerator();
        //IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

    }
    public class Word
    {
        // поле для фиксации даты 
        string englishWord;
        string translationWord;
        public string Transcription { get; set; }
        public string Reference { get; set; }
        public string Examples { get; set; }

        public DateTime Date { get; set; } 

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
            Date = DateTime.Now;
        }
        public Word(string eng, string transl, string scrip, string refer, string note, DateTime date)
            :this (eng, transl, scrip, refer, note)
        {
            Date = date;
        }

    }

    //class WorsComparerAZ : IComparer<Word>
    //{
    //    public int Compare (Word w1, Word w2)
    //    {
    //        return  string.Compare(w1.EnglishWord, w2.EnglishWord); //
    //    }
    //}
    //class WorsComparerZA : IComparer<Word>
    //{
    //    public int Compare(Word w1, Word w2)
    //    {
    //        return - string.Compare(w1.EnglishWord, w2.EnglishWord); //
    //    }
    //}
    //class WordsComparerDate : IComparer<Word>
    //{
    //    public int Compare (Word w1, Word w2)
    //    {
    //        return w1.Date.CompareTo(w2.Date);
    //    }
    //}

}
