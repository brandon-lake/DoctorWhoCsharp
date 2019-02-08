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
    /// Class to create episode objects
    /// </summary>
    class Episode
    {
        public string Story { get; private set; }       // the episode number
        public int Season { get; private set; }         // the season of this episode
        public int Year { get; private set; }           // the year this episode aired
        public string Title { get; private set; }       // the title of this episode

        public Episode(string story, int season, int year, string title)
        {
            Story = story;
            Season = season;
            Year = year;
            Title = title;
        }
    }
}
