using Microsoft.AspNetCore.Mvc;

namespace DTOs.Response
{
    public class ExceptionResultDto
    {
        public bool Success = false;
        public string ErrorMessage { get; set; }
    }
}
