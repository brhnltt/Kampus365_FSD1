namespace WebApplication2.Models
{
    public class ProfileViewModel
    {
        public IFormFile Picture { get; set; }
        public string FileName { get; set; }
        public bool HasError { get; set; }
        public string Message { get; set; }
    }
}
