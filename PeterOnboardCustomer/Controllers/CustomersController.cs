using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PeterOnboardCustomer.Data;

namespace PeterOnboardCustomer.Controllers
{
    [ApiController]
    [Route("api/[controller]")]

    public class CustomersController : ControllerBase
    {
        private readonly TheCustomerContext _context;
        public CustomersController(TheCustomerContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<TblCustomer>>> GetAllCustomers()
        {
            var customer =await  _context.TblCustomer.ToListAsync();   
            return Ok(customer);
        }

        //public JsonResult SendOTO()
        //{

        //    //generate otp

        //    Random rnd = new Random();

        //   string randomnumber = (rnd.Next(100000, 999999)).ToString();

        //    string message = "Your OTP is " + randomnumber;


        //}

        //public JsonResult VerifyOTO(string otp)
        //{

        //}

        //[HttpGet("{id}")]
        //public string GetCustomer(int id)
        //{
        //    return "This will get a single Customers";

        //}

    }
}