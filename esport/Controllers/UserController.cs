using esport.Contracts.Business;
using esport.DTOs;
using Microsoft.AspNetCore.Mvc;

namespace esport.Controllers
{
    public class UserController : Controller
    {
        private readonly IUserBusiness _business;

        public UserController(IUserBusiness business)
        {
            _business = business;   
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(CreateUserRequest request)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    return Ok(_business.Create(request));
                }
                return BadRequest();
            }
            catch (Exception)
            {
                throw;
            }
        }
        
    }
}
