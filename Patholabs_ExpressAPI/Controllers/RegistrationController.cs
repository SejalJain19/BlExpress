using Patholabs_ExpressAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Patholabs_ExpressAPI.Controllers
{
    public class RegistrationController : ApiController
    {
        private Patholabs_ExpressEntities db = new Patholabs_ExpressEntities();
        [HttpPost]
        public IHttpActionResult Registration(User_Admin reg)
        {
            if (ModelState.IsValid)
            {
                db.User_Admin.Add(reg);
                int rows=db.SaveChanges();
                if (rows == 1)
                {
                    return Ok();
                }
                else
                {
                    return BadRequest();
                }
               
            }
            return Ok();
        }
    }
}
