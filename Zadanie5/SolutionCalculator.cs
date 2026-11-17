using System;
using System.Collections.Generic;
using System.Text;

namespace Zadanie5
{
    internal class SolutionCalculator
    {
        public Dictionary<string, double> TypicalVessels { get; } = new Dictionary<string, double>()
        {
            { "Kieliszek (50 ml)", 50 },
            { "Szklanka (250 ml)", 250 },
            { "Kufel (500 ml)", 500 },
            { "Własna pojemność...", -1 }
        };
        public Dictionary<string, double> TypicalSolutions { get; } = new Dictionary<string, double>()
        {
            { "Sól fizjologiczna (0.9%)", 0.9 },
            { "Piwo (5%)", 5 },
            { "Wino (12%)", 12 },
            { "Wódka (40%)", 40 },
            { "Spirytus (95%)", 95 },
            { "Własne stężenie...", -1 }
        };
    }
}
