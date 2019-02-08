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
    /// Class to create doctor objects
    /// </summary>
    class Doctor
    {
        public int Order { get; private set; }          // the doctors order of appearance in terms of all doctors
        public string Actor { get; private set; }       // the name of the actor
        public int Series { get; private set; }         // the number of seasons this actor played the doctor for
        public int Age { get; private set; }            // the age of the actor when they started this role
        public string Debut { get; private set; }       // the actors debut episode

        public Doctor(int order, string actor, int series, int age, string debut)
        {
            Order = order;
            Actor = actor;
            Series = series;
            Age = age;
            Debut = debut;
        }
    }
}
