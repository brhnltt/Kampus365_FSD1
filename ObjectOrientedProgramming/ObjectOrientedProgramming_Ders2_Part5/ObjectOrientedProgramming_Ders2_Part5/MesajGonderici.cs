using System;

namespace ObjectOrientedProgramming_Ders2_Part5
{
    public interface ISender
    {
        void Send(string message);
    }

    public interface IPhoneNumber
    {
        string PhoneNumber { get; set; }
    }


    public class EmailSender : ISender
    {
        public string Subject { get; set; }

        public void Send(string message)
        {
            // Email gönderme kodu yazılacak.
        }
    }

    public class SmsSender : ISender, IPhoneNumber
    {
        public string PhoneNumber { get; set; }

        public void Send(string message)
        {
            // SMS gönderme kodu yazılacak.
        }
    }

    public class FaxSender : ISender, IPhoneNumber
    {
        public string PhoneNumber { get; set; }

        public void Send(string message)
        {
            throw new NotImplementedException();
        }
    }

}
