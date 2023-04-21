using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basics
{
    public class Song
    {
        public string name;
        public string time;
        public static int count = 0; //static class attribute

        public Song(string aName, string aTime)
        {
            name = aName;
            time = aTime;
            count++;
        }

        public int getCount()
        {
            return count;
        }
    }
}
