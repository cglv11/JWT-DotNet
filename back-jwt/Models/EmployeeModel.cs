using System;
namespace back_jwt.Models
{
	public class EmployeeModel
	{
		public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string Rol { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
	}
}

