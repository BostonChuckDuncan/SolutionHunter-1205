namespace API.Dtos
{
    public class ContactUsDto
    {
        public string emailAddress { get; set; }
        public string phoneNumber { get; set; }
        public string message { get; set; }

        public string guidText { get; set; }
        public string previousEmail { get; set; }
        public string previousPhone { get; set; }
    }
}
