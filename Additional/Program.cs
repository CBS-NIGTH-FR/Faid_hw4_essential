using System;

namespace Additional
{
    abstract class AbsClass
    {
        public string content;

        public abstract string Content { get; set; }

        public abstract void Show();
    }

    class Title : AbsClass
    {
        public override string Content
        {
            get
            {
                if (content != null)
                    return content;
                else
                    return "Заголовок отсутствует.";
            }
            set
            {
                content = value;
            }
        }

        public override void Show()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(Content);
            Console.ForegroundColor = ConsoleColor.Gray;
        }

        class Footer : AbsClass
        {

            public override string Content
            {
                get
                {
                    if (content != null)
                        return content;
                    else
                        return "Нижний колонтитул отсутствует.";
                }
                set
                {
                    content = value;
                }
            }

            public override void Show()
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(Content);
                Console.ForegroundColor = ConsoleColor.Gray;
            }
        }

        class Body : AbsClass
        {

            public override string Content
            {
                get
                {
                    if (content != null)
                        return content;
                    else
                        return "Тело документа отсутствует.";
                }
                set
                {
                    content = value;
                }
            }

            public override void Show()
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine(Content);
                Console.ForegroundColor = ConsoleColor.Gray;
            }

            class Document
            {
                // Поля
                Title title = null;
                Body body = null;
                Footer footer = null;

                void InitializeDocument()
                {
                    this.title = new Title();
                    this.body = new Body();
                    this.footer = new Footer();
                }

                public Document(string title)
                {
                    InitializeDocument();
                    this.title.Content = title;
                }

                public void Show()
                {
                    this.title.Show();
                    this.body.Show();
                    this.footer.Show();
                }

                public string Body
                {
                    set
                    {
                        this.body.Content = value;
                    }
                }

                public string Footer
                {
                    set
                    {
                        this.footer.Content = value;
                    }
                }
            class Program
                {
                    static void Main(string[] args)
                    {
                        Document document = new Document("Контракт");
                        document.Body = "Тело контракта...";
                        document.Footer = "Директор: Иванов И.И.";

                        document.Show();

                        // Delay.
                        Console.ReadKey();
                    }
                } 
            }
            }
        }
    }

