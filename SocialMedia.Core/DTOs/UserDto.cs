using System;
using System.Collections.Generic;
using System.Text;

namespace SocialMedia.Core.DTOs
{
   public class UserDto
    {
        public int UserId { get; set; }
        public string FirtsName { get; set; }
        public string LastName { get; set; }
        public string Mail { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Number { get; set; }
        public bool IsActive { get; set; }
    }
}
