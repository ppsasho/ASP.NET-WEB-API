namespace Services.Helpers
{
    public class OrderResult
    {
        public bool Success { get; set; }
        public string? ErrorMessage { get; set; }
        public int? OrderId { get; set; }
    }
}
