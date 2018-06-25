using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaidBot.Helpers
{
    static class PokemonUrlHelpers
    {
        public static string getPokemonUrl(int ID)
        {
            if (ID < 1000)
                return ConfigVariables.PokemonIconURL;

            if (ID == 1001)
                return ConfigVariables.EggIconURL1;

            if (ID == 1002)
                return ConfigVariables.EggIconURL2;

            else
                return ConfigVariables.EggIconURL3;
        }
    }
}
