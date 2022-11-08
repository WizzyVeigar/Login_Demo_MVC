using Login_Demo_MVC.Classes;
using Login_Demo_MVC.DTO;
using Login_Demo_MVC.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Login_Demo_MVC.Controllers.Api
{
    [Route("[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        LoginManager manager;
        public LoginController(LoginManager manager)
        {
            this.manager = manager;
        }

        [HttpPost]
        [Route("Login")]
        public bool Login([FromForm]LoginCredentModel credentials)
        {
            
            return true;
        }

        [HttpPost]
        [Route("Register")]
        public void RegisterUser([FromForm]LoginCredentModel credentials)
        {
            if (ModelState.IsValid)
            {
                
                //If everything is valid, go to home page
                RedirectToAction("Index","Home");
            }
        }
    }
}