using Application.Services;
using Messages.DTO;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http;
using System.Web.Http.Cors;
using WebApi.Filters;

namespace WebApi.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    [RoutePrefix("api/fileUpload")]
    public class UploadFileController : ApiController
    {

        private IMangerInventoryService mangerInventoryService;
        public UploadFileController()
        {
            this.mangerInventoryService = new MangerInventoryService();
        }

        [MimeMultipart]
        [HttpPost]
        [Route("upload")]
        public IHttpActionResult upload()
        {
            var httpRequest = HttpContext.Current.Request;
            EquineBovineDTO equineBovineDTO=null;
            foreach (string file in httpRequest.Files)
            {
                var postedFile = httpRequest.Files[file];
                equineBovineDTO = this.mangerInventoryService.GetMangerInventorDataByFile(postedFile.InputStream);
            }
            if (equineBovineDTO==null){
                return NotFound();
            }
            else
            {
                return Ok(equineBovineDTO);
            }
            
        }
    }
}
