using McShares.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;

namespace McShares.Controllers
{
    public class DocFileController : ApiController
    {
        // GET api/values
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }

        public HttpResponseMessage PostDocFile()
        {
            var filePath = string.Empty;
            var httpRequest = HttpContext.Current.Request;
            HttpResponseMessage result;
            if (httpRequest.Files.Count > 0)
            {
                var docfiles = new List<string>();
                foreach (string file in httpRequest.Files)
                {
                    var postedFile = httpRequest.Files[file];
                    filePath = HttpContext.Current.Server.MapPath("~/Uploads/" + postedFile.FileName);
                    postedFile.SaveAs(filePath);
                    docfiles.Add(filePath);
                }
                result = Request.CreateResponse(HttpStatusCode.Created, docfiles);

                RequestDoc requestDoc = ShareEntityManager.DeserializeShareFile(filePath);
                string validationError = ValidateEntity.ValidateShareEntity(requestDoc);
                if (!string.IsNullOrEmpty(validationError))
                {
                    result = Request.CreateResponse(HttpStatusCode.Forbidden,validationError);
                    return result;
                }

                using (McShareModel mcShareModel = new McShareModel())
                {
                    mcShareModel.RequestDoc.Add(requestDoc);
                    mcShareModel.SaveChanges();

                    result = result = Request.CreateResponse(HttpStatusCode.Created);
                }
            }
            else
            {
                result = Request.CreateResponse(HttpStatusCode.BadRequest);
            }
            return result;
        }
    }
}
