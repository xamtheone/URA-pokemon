using System;
using System.Collections.Generic;
using System.Text;

namespace URA_Pokemon
{
    class PokeMath
    {
        public static double StatPV(double BasePV, double dv, double ev, double Niveau)
        {
            return Math.Truncate(((2 * BasePV + dv + Math.Truncate(ev / 4)) * Niveau / 100 + 10 + Niveau));
        }

        public static double Stat(double BaseStat, double dv, double ev, double Niveau, double nature)
        {
           return Math.Truncate(Math.Truncate((2 * BaseStat + dv + Math.Truncate(ev / 4)) * Niveau / 100 + 5) * nature);
        }
    }
}
