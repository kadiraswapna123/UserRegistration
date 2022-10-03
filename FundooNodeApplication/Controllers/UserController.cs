using BusinessLayer.Interface;
using BusinessLayer.Service;
using CommanLayer.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RepositryLayer.Interface;
using RepositryLayer.Service;
using System;
using System.Net.Http;

namespace FundooNodeApplication.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserRL userBL;
        public UserController(IUserRL userBL)
        {
            this.userBL = userBL;
        }
        [HttpPost("Register")]//Custom route
        public IActionResult UserRegistration(Registration Registration)
        {
            try
            {
                var result = userBL.UserRegistration(Registration);
                if (result != null)
                {
                    return this.Ok(new { success = true, message = "UserRegistration Successfull", data = result });
                }
                else
                {
                    return this.BadRequest(new { success = true, message = "UserRegistration Successfull", });
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

    }
}