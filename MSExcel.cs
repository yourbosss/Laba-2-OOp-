using System;

namespace lab2 {

    public class MSExcel : Document
    {

        private string Columns { get; set; }
        private string Rows { set; get; }

        public MSExcel(string Name, string Creator, string Tags, string Theme, string Path, string columns, string rows) : base(Name, Creator, Tags, Theme, Path)
        {

            Columns = columns;
            Rows = rows;
        }

        public override void GetInfo()
        {

            base.GetInfo();
            Console.WriteLine($"Количество столбцов: {Columns}");
            Console.WriteLine($"Количество строк: {Rows}");
        }
    }
}