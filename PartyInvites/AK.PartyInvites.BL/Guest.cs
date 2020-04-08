using System;

namespace AK.PartyInvites.BL
{
    public class Guest
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public bool? WillAttend { get; set; } // bool? means its a nullable bool. It can be true,fales or null.

        
    }
}
