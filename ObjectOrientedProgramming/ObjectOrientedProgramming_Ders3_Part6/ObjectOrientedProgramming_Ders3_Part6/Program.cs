using System;

namespace ObjectOrientedProgramming_Ders3_Part6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }


    public interface ISender<TSendOptions>
        where TSendOptions : SenderBase, new()
    {
        void Send(TSendOptions parameters);
    }


    public class FileSender : ISender<FileSenderOptions>
    {
        public void Send(FileSenderOptions parameters)
        {
            throw new NotImplementedException();
        }
    }

    // CTRL + "."
    public class EmailSender : ISender<EmailOptions>
    {
        public void Send(EmailOptions emailOptions)
        {
            throw new NotImplementedException();

            //throw new MyDivideByZeroException();
            //throw new MyDivideByZeroException();
            //throw new MyIndexOutOfRangeException();
            //throw new MyException();
        }
    }

    public class FaxSMSSender : ISender<FaxSmsOptions>
    {
        public void Send(FaxSmsOptions faxSmsOptions)
        {

            throw new NotImplementedException();
        }
    }


    public class SenderBase
    {
        public string Message { get; set; }
    }

    public class FileSenderOptions: SenderBase
    {
        public string FTP { get; set; }
    }

    public class EmailOptions: SenderBase
    {
        public string To { get; set; }
        public string From { get; set; }
        public string Subject { get; set; }
        public bool IsImportant { get; set; }
    }

    public class FaxSmsOptions : SenderBase
    {
        public string Number { get; set; }
    }



    public class MyException : Exception
    {
        public string Message { get; set; }
    }

    public class MyDivideByZeroException : MyException
    {
        public MyDivideByZeroException()
        {
            Message = "Sıfıra bölünme hatası.";
        }
    }

    public class MyNotImplementedException : MyException
    {
        public MyNotImplementedException()
        {
            Message = "Bu metot geliştirilmedi.";
        }
    }

    public class MyIndexOutOfRangeException : MyException
    {
        public MyIndexOutOfRangeException()
        {
            Message = "Dizi index i dışında bir index e erişilmeye çalışılıyor.";
        }
    }
}
