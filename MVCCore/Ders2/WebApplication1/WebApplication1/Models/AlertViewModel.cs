namespace WebApplication1.Models
{
    public class AlertViewModel
    {
        public string Message { get; set; }
        public AlertType MessageType { get; set; }
    }

    public enum AlertType
    {
        Success,
        Warning,
        Info,
        Danger,
        Primary,
        Secondary
    }
}
