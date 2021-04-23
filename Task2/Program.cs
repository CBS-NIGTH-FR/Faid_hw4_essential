using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            XMLHandler xml = new XMLHandler();
            xml.Open();
            xml.Create();
            xml.Change();
            xml.Save();

            TXTHandler txt = new TXTHandler();
            txt.Open();
            txt.Create();
            txt.Change();
            txt.Save();

            DOCHandler doc = new DOCHandler();
            doc.Open();
            doc.Create();
            doc.Change();
            doc.Save();
        }
    }
}
