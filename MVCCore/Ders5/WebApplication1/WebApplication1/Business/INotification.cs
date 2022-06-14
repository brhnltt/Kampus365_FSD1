namespace WebApplication1.Business
{
    // SOLID Principles

    // Dependency Inversion

    public interface INotification
    {
        string SendNotification();
    }

    //public class MultiNotificator
    //{
    //    public INotification GeneralNoticationService { get; private set; }
    //    public SMSNotification SMSNotificationService { get; set; }

    //    public MultiNotificator(INotification notification)
    //    {
    //        GeneralNoticationService = notification;
    //        SMSNotificationService = new SMSNotification();
    //    }
    //}

    public class EmailNotification : INotification
    {
        public string SendNotification()
        {
            return "E-Mail gönderildi.";
        }
    }

    public class SMSNotification : INotification
    {
        public string SendNotification()
        {
            return "SMS Gönderildi.";
        }
    }

    public class FaxNotification : INotification
    {
        public string SendNotification()
        {
            return "Fax Gönderildi.";
        }
    }
}
