using Microsoft.AspNetCore.Mvc;
using erRelnAPI.Models;
using Microsoft.EntityFrameworkCore;

using Microsoft.AspNetCore.Session;
using Microsoft.AspNetCore.Http;

using System.Data.SqlClient;
using Microsoft.Data.SqlClient;
using System.Data;
using Microsoft.Data;

namespace erRelnAPI.Controllers{
    [ApiController]
    [Route("api/[controller]")]
    public class LoginController : ControllerBase{
        // private readonly IConfiguration db;
        // public LoginController(IConfiguration _db){
        //     db = _db;
        // }

        private readonly Ace42023Context db;
        // private readonly  ISession session; 
        // ,IHttpContextAccessor httpContextAccessor
        public LoginController(Ace42023Context _db){
            db = _db;
            // session = httpContextAccessor.HttpContext.Session;
        }
        
        [HttpPost]
        [Route("register")]
        public ActionResult register(HarshitAuth a){
            db.HarshitAuth.Add(a);
            db.SaveChanges();
            return Ok();
        }

        [HttpGet]
        [Route("login")]
        public ActionResult<HarshitAuth> login(string uname){
            // var logStatus = (from i in db.HarshitAuth where i.UserName==h.UserName && i.Password==h.Password select i).FirstOrDefault();
            HarshitAuth a = db.HarshitAuth.Find(uname);
            if(a==null){
                return NotFound();
            }
            return Ok(a);
        }
    }

}