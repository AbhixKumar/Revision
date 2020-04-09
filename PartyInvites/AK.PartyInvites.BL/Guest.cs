using System;
using System.ComponentModel.DataAnnotations;

namespace AK.PartyInvites.BL
{
    public class Guest
    {
        [Required(ErrorMessage = "Please enter your name")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Please enter your email address")]
        [RegularExpression(".+\\@.+\\..+",
            ErrorMessage = "Please enter a valid Email")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Please enter your phone number")]
        public string PhoneNumber { get; set; }
        [Required(ErrorMessage = "Please select if you'll attend")]
        public bool? WillAttend { get; set; } // bool? means its a nullable bool. It can be true,fales or null.

        
    }
}
