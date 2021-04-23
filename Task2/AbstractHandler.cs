using System;
using System.Collections.Generic;
using System.Text;

namespace Task2
{
    abstract class AbstractHandler
    {
        public abstract void Open();
        public abstract void Create();
        public abstract void Change();
        public abstract void Save();
    }

    class XMLHandler : AbstractHandler
    {
        public override void Open()
        {
            Console.WriteLine("Открыт документ формата XML");
        }

        public override void Create()
        {
            Console.WriteLine("Данный метод создаёт различные файлы в XML формате");
        }

        public override void Change()
        {
            Console.WriteLine("Данный метод редактирует различные файлы в XML формате");
        }

        public override void Save()
        {
            Console.WriteLine("Данный метод сохраняет различные файлы в XML формате");
        }
    }

    class TXTHandler : AbstractHandler
    {
        public override void Open()
        {
            Console.WriteLine("Открыт документ формата TXT");
        }

        public override void Create()
        {
            Console.WriteLine("Данный метод создаёт различные файлы в TXT формате");
        }

        public override void Change()
        {
            Console.WriteLine("Данный метод редактирует различные файлы в TXT формате");
        }

        public override void Save()
        {
            Console.WriteLine("Данный метод сохраняет различные файлы в формате TXT");
        }
    }

    class DOCHandler : AbstractHandler
    {
        public override void Open()
        {
            Console.WriteLine("Открыт документ формата DOC");
        }

        public override void Create()
        {
            Console.WriteLine("Данный метод создаёт различные файлы в DOC формате");
        }

        public override void Change()
        {
            Console.WriteLine("Данный метод редактирует различные файлы в DOC формате");
        }

        public override void Save()
        {
            Console.WriteLine("Данный метод сохраняет различные файлы в формате DOC ");
        }
    }

}
