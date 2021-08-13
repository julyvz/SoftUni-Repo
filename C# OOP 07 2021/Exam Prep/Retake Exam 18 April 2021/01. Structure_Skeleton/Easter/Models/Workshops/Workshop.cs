using Easter.Models.Bunnies.Contracts;
using Easter.Models.Eggs.Contracts;
using Easter.Models.Workshops.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Easter.Models.Workshops
{
    public class Workshop : IWorkshop
    {
        public void Color(IEgg egg, IBunny bunny)
        {
            var dye = bunny.Dyes.FirstOrDefault(d => d.IsFinished() == false);

            while (!egg.IsDone() && bunny.Energy > 0 && dye != null)
            {                
                egg.GetColored();
                bunny.Work();
                dye.Use();
                if (dye.IsFinished())
                {
                    dye = bunny.Dyes.FirstOrDefault(d => d.IsFinished() == false);
                }
            }
        }
    }
}
