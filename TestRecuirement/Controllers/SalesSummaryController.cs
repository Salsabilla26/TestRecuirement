using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TestRecuirement.Models;
using System.Linq;
using System.Threading.Tasks;

namespace TestRecuirement.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SalesSummaryController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetSalesSummary()
        {
            var data = new[]
            {
            new { Item = "Product A", Revenue = 1000 },
            new { Item = "Product B", Revenue = 1500 },
            // tambahkan data lainnya
        };

            return Ok(data);
        }
    }
}
