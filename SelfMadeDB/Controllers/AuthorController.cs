using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SelfMadeDB.DBModel;
using Microsoft.EntityFrameworkCore;

namespace SelfMadeDB.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AuthorController : ControllerBase {
        private DbContext context = new SelfMadeDBContext();
        
        [HttpGet]
        public IQueryable<Author> Get(){
            return context.Set<Author>();
        }

    }
}