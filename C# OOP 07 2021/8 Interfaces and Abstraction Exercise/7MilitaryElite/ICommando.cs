using System.Collections.Generic;

namespace _7MilitaryElite
{
    public interface ICommando
    {
        List<Mission> Missions { get; set; }

        string ToString();
    }
}