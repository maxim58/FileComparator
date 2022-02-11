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
