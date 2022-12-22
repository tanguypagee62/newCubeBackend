using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace newCubeBackend.UserModel
{
    public class User
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Email { get; set; }
        public string? UserPassword { get; set; }
        public string? Address { get; set; }
        public int? PostalCode { get; set; }
        public string? Town { get; set; }
        public int? PhoneNumber { get; set; }
        public bool Admin { get; set; }
    }
}