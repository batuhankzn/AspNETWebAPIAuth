using System;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using AspNETWebAPIAuth.Models;


namespace AspNETWebAPIAuth.Controllers
{
	[Route("api/[controller]")]
	[ApiController]

	public class AuthController : ControllerBase
	{
		[HttpPost()]
		public ResponseModel Login(LoginModel loginmodel)
		{

			if(loginmodel.Username == "batu" && loginmodel.Password == "123")
			{
                return new ResponseModel()
                {
                    Message = "Login succesfull",
                    Code = "200",
                    Data = null
                };

            }
			else
			{
                return new ResponseModel()
                {
                    Message = "Login failed",
                    Code = "401",
                    Data = null
                };
            }


		}
	}
}

