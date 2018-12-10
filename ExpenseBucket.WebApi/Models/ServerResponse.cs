using System.Web.Http.ModelBinding;

namespace ExpenseBucket.WebApi.Models
{
    public class ServerResponse
    {
        public string Message { get; set; }
        public string Code { get; set; }
        
    }
}