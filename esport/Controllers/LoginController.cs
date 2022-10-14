using esport.Contracts.Business;
using esport.DTOs;
using Microsoft.AspNetCore.Mvc;

namespace esport.Controllers
{
    public class LoginController : Controller
    {
        #region Declarations
        private readonly ILoginBusiness _business;
        #endregion

        #region Constructor
        public LoginController(ILoginBusiness business)
        {
            _business = business;
        }
        #endregion

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(LoginRequest request)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    return Ok(_business.login(request));
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
