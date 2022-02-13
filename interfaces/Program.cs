using System;

namespace interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            Message mes = new Message("Привет");

            mes.Print();
            IMessage message = new Message("Здравствуйте");
            if (message is Message someMessage) someMessage.Print();

            Person boy = new Person();
            if (boy is ISchool schoolhool) schoolhool.Study();
            if (boy is IUniversity univer) univer.Study();

            ((IUniversity)boy).Study();
            ((ISchool)boy).Study();
        }
    }

    interface IMessage
    {
        public string Text { get; set; }
    }

    interface IPrintable
    {
        void Print();
    }

    class Message: IMessage, IPrintable
    {
        public string Text { get; set; }
        public Message( string text) => Text = text;
        public void Print()
        {
            Console.WriteLine(Text);
        }
    }

    interface ISchool
    {
        void Study();
    }

    interface IUniversity
    {
        void Study();
    }

    class Person:ISchool,IUniversity
    {
        void IUniversity.Study() => Console.WriteLine("Учеба в университете");
        void ISchool.Study()=> Console.WriteLine("Учеба в школе");
    }
}
