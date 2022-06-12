using System;

namespace lab2 {

    public abstract class Document { 
    

        private string Name { get; set; } //данная конструкция разрешит получать значение поля объекта
        private string Creator { get; set; }
        private string Tags { get; set; }
        private string Theme { get; set; }
        private string Path { get; set; }

        public Document(string name, string creator, string tags, string theme, string path) {

            Name = name;
            Creator = creator;
            Tags = tags;
            Theme = theme;
            Path = path;
        }

        public virtual void GetInfo() {

            Console.WriteLine($"Имя: {Name}");
            Console.WriteLine($"Автор: {Creator}");
            Console.WriteLine($"Ключевые слова: {Tags}");
            Console.WriteLine($"Тематика: {Theme}");
            Console.WriteLine($"Путь к файлу: {Path}");
        }
    }
}
