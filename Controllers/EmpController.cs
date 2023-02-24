using System;
using Microsoft.AspNetCore.Mvc;
using erRelnAPI.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Versioning;

namespace erRelnAPI.Controllers{
    [ApiController]
    //api versioning - install the package versioning
    // [ApiVersion("1.0")]
    // [Route("api/{v:ApiVersion}/[controller]")]
    [Route("api/[controller]")]
    public class EmpController : ControllerBase{
        private readonly Ace42023Context db;
        public EmpController(Ace42023Context _db){
            db = _db;
        }

        [HttpGet]
        // [Route("getempbyId")]
        public async Task<ActionResult<List<Empharshit>>> GetDetails(){
            return Ok(await db.Empharshit.ToListAsync());
        }
        //checking multiple gets
        [HttpGet]
        [Route("{id}")]
        public async Task<ActionResult<List<Empharshit>>> GetDetails(int id){
            // Empharshit e = await db.Empharshit.Where(x=>x.Eid==id).SingleOrDefault();
            Empharshit e = await db.Empharshit.FindAsync(id);
            if(e!=null){
                return Ok(e);
            }
            else{
                return NotFound(); //helper methods BadRequest() also
            }
        }
        //post code
        [HttpPost]
        public async Task<ActionResult> AddEmployee(Empharshit e){
            if(ModelState.IsValid){
                db.Empharshit.Add(e);
                await db.SaveChangesAsync();
            }
            return Ok();
        }
        //put code
        [HttpPut("{id}")]
        public async Task<ActionResult> EditEmployee(int id, Empharshit e){
            db.Empharshit.Update(e);
            await db.SaveChangesAsync();
            return Ok(e);
        }
        //delete code
        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteEmployee(int? id){
            if(id==null)
                return BadRequest();
            
            Empharshit e =await db.Empharshit.FindAsync(id);
            if(e!=null){
                db.Empharshit.Remove(e);
                await db.SaveChangesAsync();
            }
            else{
                return NotFound();
            }
            return Ok(e); //returning 'e' bcz of api working
        }
    }
}