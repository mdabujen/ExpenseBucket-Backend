using System.Net.Http;
using System.Web.Http;
using ExpenseBucket.Core;
using ExpenseBucket.Core.Entities;

namespace ExpenseBucket.WebApi.Controllers
{
    [RoutePrefix("expensebucketapi/category")]
    public class CategoryController : ApiController
    {
        private readonly IUnitOfWork _unitOfWork;

        public CategoryController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        
    }
}
