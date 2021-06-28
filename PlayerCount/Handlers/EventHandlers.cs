using System.Linq;
using Exiled.API.Features;

namespace PlayerCountHades.Handlers
{
    class Count
    {
        public static int GetPlayerCount()
        {
            return Player.List.Count();
        }
    }
}
