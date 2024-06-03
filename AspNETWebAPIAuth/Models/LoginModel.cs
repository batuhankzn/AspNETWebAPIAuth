using System;
namespace AspNETWebAPIAuth.Models
{
	public class LoginModel
	{
            public required string Username { get; set; }
			public required string Password { get; set; }
			public int? Age { get; set; }
		
	}
}

