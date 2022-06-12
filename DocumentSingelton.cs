/******************************************
 * Автор: Копытова К.К.                   *
 * Дата: 05.06.2022                       *
 * Название: ООП на C#                    *
*******************************************/

using System;

namespace lab2  {

    public class DocumentSingleton  //порождающий паттерн, который гарантирует, что для определенного класса будет создан только один объект, а также предоставит к этому объекту точку доступа.
    {

        private static DocumentSingleton instance;

        private DocumentSingleton()
        {

        }

        public static DocumentSingleton GetInstance
        {

            get
            {

                if (instance == null)
                {

                    instance = new DocumentSingleton();
                }

                return instance;
            }
        }

        private void SetBaseInfo(out string name, out string creator, out string tags, out string theme, out string path)
        {

            Console.Clear();

            Console.WriteLine("Введите имя документа: ");
            name = Console.ReadLine();

            Console.WriteLine("Введите имя создателя: ");
            creator = Console.ReadLine();

            Console.WriteLine("Введите ключевые слова: ");
            tags = Console.ReadLine();

            Console.WriteLine("Введите тематику: ");
            theme = Console.ReadLine();

            Console.WriteLine("Введите путь к файлу: ");
            path = Console.ReadLine();
        }

        private void MSWordInfo()
        {

            string Name, Creator, Tags, Theme, Path;

            SetBaseInfo(out Name, out Creator, out Tags, out Theme, out Path);

            Console.WriteLine("Введите количество слов:");
            var Words = Console.ReadLine();

            Console.Clear();

            var Doc = new MSWord(Name, Creator, Tags, Theme, Path, Words);

            Console.WriteLine("Документ типа: MS Word" + "\n");

            Doc.GetInfo();
        }

        private void PDFInfo()
        {

            string Name, Creator, Tags, Theme, Path;

            SetBaseInfo(out Name, out Creator, out Tags, out Theme, out Path);

            Console.WriteLine("Введите количество страниц:");
            var Pages = Console.ReadLine();

            Console.Clear();

            var Doc = new PDF(Name, Creator, Tags, Theme, Path, Pages);

            Console.WriteLine("Документ типа: PDF" + "\n");

            Doc.GetInfo();
        }

        private void MSExcelInfo()
        {

            string Name, Creator, Tags, Theme, Path;

            SetBaseInfo(out Name, out Creator, out Tags, out Theme, out Path);

            Console.WriteLine("Введите количество стобцов:");
            var Columns = Console.ReadLine();

            Console.WriteLine("Введите количество строк:");
            var Rows = Console.ReadLine();

            Console.Clear();

            var Doc = new MSExcel(Name, Creator, Tags, Theme, Path, Columns, Rows);

            Console.WriteLine("Документ типа: MS Excel" + "\n");

            Doc.GetInfo();
        }

        private void TXTInfo()
        {

            string Name, Creator, Tags, Theme, Path;

            SetBaseInfo(out Name, out Creator, out Tags, out Theme, out Path);

            Console.WriteLine("Введите количество слов:");
            var Words = Console.ReadLine();

            Console.WriteLine("Введите количество строк:");
            var Lines = Console.ReadLine();

            Console.Clear();

            var Doc = new TXT(Name, Creator, Tags, Theme, Path, Words, Lines);

            Console.WriteLine("Документ типа: TXT" + "\n");

            Doc.GetInfo();
        }

        private void HTMLInfo()
        {

            string Name, Creator, Tags, Theme, Path;

            SetBaseInfo(out Name, out Creator, out Tags, out Theme, out Path);

            Console.WriteLine("Введите ссылку:");
            var Link = Console.ReadLine();

            Console.Clear();

            var Doc = new HTML(Name, Creator, Tags, Theme, Path, Link);

            Console.WriteLine("Документ типа: HTML" + "\n");

            Doc.GetInfo();
        }

        public void Menu()
        {

            Console.WriteLine("Выберите тип файла:" + "\n");
            Console.WriteLine("MS Word      0");
            Console.WriteLine("PDF          1");
            Console.WriteLine("MS Excel     2");
            Console.WriteLine("TXT          3");
            Console.WriteLine("HTML         4");

            var Option = Console.ReadLine();

            switch (Option)
            {

                case "0":

                    MSWordInfo();

                    break;

                case "1":

                    PDFInfo();

                    break;

                case "2":

                    MSExcelInfo();

                    break;

                case "3":

                    TXTInfo();

                    break;

                case "4":

                    HTMLInfo();

                    break;

                default:

                    Console.WriteLine("\n" + "Незнакомый тип.");

                    break;
            }

            Console.ReadKey();
        }
    }
}