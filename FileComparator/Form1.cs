using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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
           
            Stopwatch sw = new Stopwatch();
            sw.Start();                                                                     //засекаем время сравнения файлов
            analysisResult = CompareFiles(originalText, modifiedText);                      //сравниваем 2 файла
            sw.Stop();            
            Form ResultForm = new Form2(analysisResult, sw.Elapsed);                        //передаем результаты сравнения на форму2
            ResultForm.Show();
        }

        private Result CompareFiles(List<string> original, List<string> modified)
        {
            List<string> org = new List<string>();
            org.AddRange(original.ToArray());
            List<string> mod = new List<string>();
            mod.AddRange(modified.ToArray());

            Result result = new Result();
            result.OrgLinesCount = org.Count;
            result.ModLinesCount = mod.Count;

            while (org.Count != 0)
            {
                if (org.First() == mod.First())                                                         //если строки равны, значит не изменяли 
                {
                    result.AddLine(org.First(), Color.Green);
                    result.LinesUnchangedCount++;
                    org.RemoveAt(0);
                    mod.RemoveAt(0);
                }
                else                                                                                    //если строки не равны...
                {
                    if (!mod.Contains(org.First()) && org.Contains(mod.First()))                        //если нет строки из оригинального файла в измененном файле
                    {                                                                                   //но есть строка из измененного файла в оригинальном
                        result.AddLine(org.First(), Color.Red);                                         //значит строку удалили
                        result.RemovalsCount++;
                        org.RemoveAt(0);
                    }
                    else if(!mod.Contains(org.First()) && !org.Contains(mod.First()))                   //если нет строки из оригинального файла в измененном файле
                    {                                                                                   //и нет строки из измененного файла в оригинальном
                        result.AddLine(org.First(), Color.Red);                                         //значит строку изменили
                        result.AddLine(mod.First(), Color.Yellow);
                        result.ChangesCount++;
                        org.RemoveAt(0);
                        mod.RemoveAt(0);
                    }
                    else
                    {                                                                                   //если есть строка из оригинального файла в измененном файле
                        result.AddLine(mod.First(), Color.Yellow);                                      //и есть строка из измененного файла в оригинальном
                        result.AdditionsCount++;                                                        //значит строку добавили
                        mod.RemoveAt(0);
                    }
                }

                if (mod.Count == 0)                                                                     //если измененный файл закончился раньше, 
                {                                                                                       //допечатываем строки из оригинального, как удаленные
                    while (org.Count != 0)
                    {
                        result.AddLine(org.First(), Color.Red);
                        result.RemovalsCount++;
                        org.RemoveAt(0);
                    }
                    break;
                }
                else if (org.Count == 0 && mod.Count != 0)                                              //если оригинальный файл закончился раньше,
                {                                                                                       //допечатываем строки из измененного, как добавленные
                    while (mod.Count != 0)
                    {
                        result.AddLine(mod.First(), Color.Yellow);
                        result.AdditionsCount++;
                        mod.RemoveAt(0);
                    }
                    break;
                }
            }
            return result;
        }

    }
}
