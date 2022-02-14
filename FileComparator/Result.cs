using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileComparator
{
    public class Result
    {
        private List<string> Line = new List<string>();
        private List<Color> ColorFont = new List<Color>();

        public int Count { get { return Line.Count; } }
        public int OrgLinesCount { get; set; }                                                  //кол-во строк в оригинальном файле
        public int ModLinesCount { get; set; }                                                  //кол-во строк в измененном файле
        public int LinesUnchangedCount { get; set; }                                            //кол-во неизмененных строк
        public int RemovalsCount { get; set; }                                                  //кол-во удаленных строк
        public int AdditionsCount { get; set; }                                                 //кол-во добавленных строк
        public int ChangesCount { get; set; }                                                   //кол-во измененных строк


        public void AddLine(string line, Color color)
        {
            Line.Add(line);
            ColorFont.Add(color);
        }

        public string GetLineAt(int index) { return Line.ElementAt(index); }

        public Color GetColorAt(int index) { return ColorFont.ElementAt(index); }

        public void Clear()
        {
            Line.Clear();
            ColorFont.Clear();
        }
    }
}
