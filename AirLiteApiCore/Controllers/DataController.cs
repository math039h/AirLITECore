using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AirLiteApiCore.DBUtil;
using AirLiteApiCore.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AirLiteApiCore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DataController : ControllerBase
    {
        private static IManage<Data> manager = new ManageData();

        // GET: api/data
        public IEnumerable<Data> Get()
        {
            return manager.GetAll();
        }

        // GET: api/data/5
        public Data Get(int id)
        {
            return manager.Get(id);
        }

    }
}
