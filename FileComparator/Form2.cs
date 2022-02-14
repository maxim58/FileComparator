using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileComparator
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();

        }

        public Form2(Result analysisResult, TimeSpan runtime)
        {
            InitializeComponent();
            int startIndex = 0;
            try
            {
                for (int i = 0; i < analysisResult.Count; i++)
                {
                    ResultTextBox.AppendText(analysisResult.GetLineAt(i) + Environment.NewLine);
                    ResultTextBox.Select(startIndex, analysisResult.GetLineAt(i).Length);
                    ResultTextBox.SelectionColor = analysisResult.GetColorAt(i);
                    ResultTextBox.SelectionLength = 0;
                    startIndex += analysisResult.GetLineAt(i).Length + 1;
                }

                orgLineCountLable.Text = analysisResult.OrgLinesCount.ToString();
                modLineCountLabel.Text = analysisResult.ModLinesCount.ToString();
                linesUnchangedLabel.Text = analysisResult.LinesUnchangedCount.ToString();
                removalsLabel.Text = analysisResult.RemovalsCount.ToString();
                additionsLabel.Text = analysisResult.AdditionsCount.ToString();
                changesLabel.Text = analysisResult.ChangesCount.ToString();
                runtimeLabel.Text = runtime.TotalMilliseconds.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!");
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
