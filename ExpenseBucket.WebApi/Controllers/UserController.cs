using ExpenseBucket.Core;
using ExpenseBucket.WebApi.Models;
using Newtonsoft.Json;
using System;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ExpenseBucket.WebApi.Controllers
{
    [RoutePrefix("expensebucketapi/account")]
    public class UserController : ApiController
    {
        private readonly IUnitOfWork _unitOfWork;

        public UserController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpGet, Route("search/email")]
        public HttpResponseMessage RetrieveAccountInformation(string email)
        {
            try
            {
                var account = _unitOfWork.Accounts.GetByEmail(email);
                if (account == null)
                {
                    var response = new ServerResponse {Message = "Email not found.", Code = "1x000001"};
                    var jsonString = JsonConvert.SerializeObject(response);
                    return Request.CreateErrorResponse(HttpStatusCode.NotFound,jsonString);
                }
                else
                {
                    var response = new
                    {
                        Id = account.Id,
                        Email = account.Email,
                        FirstName = account.FirstName,
                        LastName = account.LastName,
                        Backups = account.Backups
                    };
                    return Request.CreateResponse(HttpStatusCode.OK, response);
                }
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex);
            }
        }
    }
}
