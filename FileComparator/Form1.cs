using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileComparator
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private List<string> originalText = new List<string>();
        private List<string> modifiedText = new List<string>();

        private void openOrigBtn_Click(object sender, EventArgs e)
        {
            originalText.Clear();
            OriginalTextBox.Clear();
            OriginalTextBox.ForeColor = Color.Black;
            openFileDialog1.ShowDialog();
            string originalFileSource = openFileDialog1.FileName;
            if (originalFileSource != null)
            {
                try
                {
                    label1.Text = Path.GetFileName(originalFileSource);

                    foreach (string line in File.ReadLines(originalFileSource))
                    {
                        originalText.Add(line);
                        OriginalTextBox.AppendText(line + Environment.NewLine);
                    }
                }
                catch (Exception ex)
                { 
                    MessageBox.Show(ex.Message, "Error!");
                }
            }            
        }

        private void openModBtn_Click(object sender, EventArgs e)
        {
            modifiedText.Clear();
            ModifiedTextBox.Clear();
            ModifiedTextBox.ForeColor = Color.Black;
            openFileDialog1.ShowDialog();
            string modifiedFileSource = openFileDialog1.FileName;
            if (modifiedFileSource != null)
            {
                try
                {
                    label2.Text = Path.GetFileName(modifiedFileSource);

                    foreach (string line in File.ReadLines(modifiedFileSource))
                    {
                        modifiedText.Add(line);
                        ModifiedTextBox.AppendText(line + Environment.NewLine);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error!");
                }
            }            
        }

        private void compareBtn_Click(object sender, EventArgs e)
        {
            Result analysisResult = new Result();
            int j = 0;
            for (int i = 0; i < originalText.Count; i++)
            {
                try
                {
                    if (originalText[i] == modifiedText[j])                                    //не изменяли строку
                    {
                        analysisResult.AddLine(originalText[i], Color.Green);
                        j += 1;
                    }
                    else
                    {
                   
                        if (originalText[i] == modifiedText[j + 1])                              //добавили строку
                        {
                            analysisResult.AddLine(modifiedText[j], Color.Yellow);
                            analysisResult.AddLine(originalText[i], Color.Green);
                            j += 2;
                        }
                        else if (originalText[i + 1] == modifiedText[j])                         //удалили строку
                        {
                            analysisResult.AddLine(originalText[i], Color.Red);
                        }
                        else                                                                     //изменили строку
                        {
                            analysisResult.AddLine(originalText[i], Color.Red);
                            analysisResult.AddLine(modifiedText[j], Color.Yellow);
                            j += 1;
                        }
                    
                    }
                }
                catch (ArgumentOutOfRangeException)
                {
                    if (i + 1 == originalText.Count)
                    {
                        analysisResult.AddLine(originalText[i], Color.Red);
                        analysisResult.AddLine(modifiedText[j], Color.Yellow);
                        for (int k = j+1; k < modifiedText.Count; k++)
                        {
                            analysisResult.AddLine(modifiedText[k], Color.Yellow);
                        }
                    }
                    else if (j + 1 == modifiedText.Count)
                    {
                        analysisResult.AddLine(originalText[i], Color.Red);
                        analysisResult.AddLine(modifiedText[j], Color.Yellow);
                        for (int k = i+1; k < modifiedText.Count; k++)
                        {
                            analysisResult.AddLine(originalText[k], Color.Red);
                        }
                        break;
                    }
                }
            }
            Form ResultForm = new Form2(analysisResult);
            ResultForm.Show();
            //analysisResult.Clear();
        }

        private Result CompareFiles(List<string> org, List<string> mod)
        {
            Result result = new Result();
            if (org.Count != 0 && mod.Count == 0)                             //Если измененный файл пустой
            {
                foreach (string line in org)
                {
                    result.AddLine(line, Color.Red);                            //Выводим все строги оригинала красным
                }
            }
            else if (org.Count == 0 && mod.Count != 0)                        //Если оригинальный файл пустой
            {
                foreach(string line in mod)
                {
                    result.AddLine(line, Color.Yellow);                          //Выводим все строки измененного файла желтым
                }
            }
            else                                                              //Если оба файлы не пустые
            {
                int minCount = Math.Min(org.Count, mod.Count);
                int j = 0;
                for (int i = 0; i < minCount-1; i++)                         //Проходим до последней строки наименьшего из файлов
                {
                    if (org[i] == mod[j])                                    //не изменяли строку
                    {
                        result.AddLine(org[i], Color.Green);
                        j += 1;
                    }
                    else
                    {

                        if (org[i] == mod[j + 1])                              //добавили строку
                        {
                            result.AddLine(mod[j], Color.Yellow);
                            result.AddLine(org[i], Color.Green);
                            j += 2;
                        }
                        else if (org[i + 1] == mod[j])                         //удалили строку
                        {
                            result.AddLine(org[i], Color.Red);
                        }
                        else                                                   //изменили строку
                        {
                            result.AddLine(org[i], Color.Red);
                            result.AddLine(mod[j], Color.Yellow);
                            j += 1;
                        }

                    }
                }

                if (org.Count == mod.Count)                                     //если кол-во строк одинаково          
                {
                    //TODO
                }
                else if (org.Count > mod.Count)                                 //если в оригинале строк больше
                {
                    
                }
                else                                                            //если в орининале строк меньше
                {

                }
            }
            return result;
        }

    }
}
