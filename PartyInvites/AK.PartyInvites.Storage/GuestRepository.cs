using System;
using System.Collections.Generic;
using AK.PartyInvites.BL;

namespace AK.PartyInvites.Storage
{
    public static class GuestRepository
    {
        private static List<Guest> guestresponses = new List<Guest>();

        public static IEnumerable<Guest> Guests { get { return guestresponses; } }
        public static void AddResponse(Guest guest)
        {
            guestresponses.Add(guest);
        }
    }
}
