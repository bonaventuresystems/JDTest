using JDOPSTest.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace JDOPSTest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StocksController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<Stock> Get()
        {
            List<Stock> stocks = new List<Stock>();
            for (int i = 0; i < 100; i++)
            {
                stocks.Add(new Stock
                {
                    ID = i,
                    Name = "Stock " + i,
                    Price = new Random().Next(20,200)
                });
            }
            return stocks;
        }
    }
}
