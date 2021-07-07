using System;
using System.Collections.Generic;

namespace _7MilitaryElite
{
    public interface IEngineer
    {
        List<Tuple<string, int>> Repairs { get; set; }

        string ToString();
    }
}