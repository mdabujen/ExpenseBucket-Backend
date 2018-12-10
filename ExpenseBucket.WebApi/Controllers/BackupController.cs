using System;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ExpenseBucket.Core;
using ExpenseBucket.Core.Entities;
using ExpenseBucket.WebApi.Models;
using Newtonsoft.Json;

namespace ExpenseBucket.WebApi.Controllers
{
    [RoutePrefix("expensebucketapi/backup")]
    public class BackupController : ApiController
    {
        private IUnitOfWork _unitOfWork;

        public BackupController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpGet, Route("search/{id:int}")]
        public HttpResponseMessage RetrieveAllBackup(int id)
        {
            try
            {
                var backup = _unitOfWork.Backups.GetAllBackup(id);
                return Request.CreateResponse(HttpStatusCode.OK, backup);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex);
            }
        }

        [HttpGet, Route("search/date/{id:int}")]
        public HttpResponseMessage RetrieveAllBackupByDate(DateTime date, int id)
        {
            try
            {
                var backup = _unitOfWork.Backups.GetByDate(date.Date, id);
                if (backup.Count > 0)
                {
                    return Request.CreateResponse(HttpStatusCode.OK, backup);
                }
                else
                {
                    var response = new ServerResponse { Message = "No backups in the specified date.", Code = "1x000002" };
                    var jsonString = JsonConvert.SerializeObject(response);
                    return Request.CreateErrorResponse(HttpStatusCode.NotFound, jsonString);
                }
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex);
            }
        }

        [HttpGet, Route("search/title/{id:int}")]
        public HttpResponseMessage RetrieveAllBackupByTitle(string title, int id)
        {
            try
            {
                var backup = _unitOfWork.Backups.GetByTitle(title, id);
                if (backup.Count > 0)
                {
                    return Request.CreateResponse(HttpStatusCode.OK, backup);
                }
                else
                {
                    var response = new ServerResponse { Message = "No backups with the specified title.", Code = "1x000003" };
                    var jsonString = JsonConvert.SerializeObject(response);
                    return Request.CreateErrorResponse(HttpStatusCode.NotFound, jsonString);
                }
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex);
            }
        }

        [HttpGet, Route("search/account/{id:int}")]
        public HttpResponseMessage RetrieveAllBackupByAccount(int id)
        {
            try
            {
                var backup = _unitOfWork.Backups.GetByAccount(id);
                if (backup.Count > 0)
                {
                    return Request.CreateResponse(HttpStatusCode.OK, backup);
                }
                else
                {
                    var response = new ServerResponse { Message = "No backups in the specified account.", Code = "1x000004" };
                    var jsonString = JsonConvert.SerializeObject(response);
                    return Request.CreateErrorResponse(HttpStatusCode.NotFound, jsonString);
                }
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex);
            }
        }
    }
}
