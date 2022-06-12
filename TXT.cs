using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2 { 
    public class TXT : Document {

        private string Words { get; set; }
        private string Lines { set; get; }

        public TXT(string Name, string Creator, string Tags, string Theme, string Path, string words, string lines) : base(Name, Creator, Tags, Theme, Path)
        {

            Words = words;
            Lines = lines;
        }

        public override void GetInfo()
        {

            base.GetInfo();
            Console.WriteLine($"Amount of words: {Words}");
            Console.WriteLine($"Amount of lines: {Lines}");
        }
    }
}

