using BlazorWasm.DataGrid.Server.Data;
using BlazorWasm.DataGrid.Shared.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BlazorWasm.DataGrid.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly AppDbContext appDbContext;

        public CustomerController(AppDbContext appDbContext)
        {
            this.appDbContext = appDbContext;
        }

        [HttpGet]
        public async Task<ActionResult<List<Customer>>> Get() => await appDbContext.Customers.ToListAsync();
    }
}
