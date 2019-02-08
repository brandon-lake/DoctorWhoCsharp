using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* I, Brandon Lake, 000766089 certify that this material is my original work. 
 * No other person's work has been used without due acknowledgement. 
 * Submitted for: December 7th 2018*/
namespace Lab5b
{
    /// <summary>
    /// Class to create companion objects
    /// </summary>
    class Companion
    {
        public string Name { get; private set; }        // the name of the character
        public string Actor { get; private set; }       // the name of the actor who played this companion
        public int Doctor { get; private set; }         // the doctor this companion accompanied
        public string Debut { get; private set; }       // the companions first episode with their doctor

        public Companion(string name, string actor, int doctor, string debut)
        {
            Name = name;
            Actor = actor;
            Doctor = doctor;
            Debut = debut;
        }
    }
}
