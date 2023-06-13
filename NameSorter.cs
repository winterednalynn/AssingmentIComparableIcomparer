using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssingmentIComparableIcomparer
{
    internal class NameSorter : IComparer<DisneyCharacter> // Comparing to characters. 
    {
        public int Compare(DisneyCharacter x, DisneyCharacter y) // Implemented interface 
        {
            return -(x.Name.CompareTo(y.Name)); // Goaling for descending order. 
        }
    }
    //class 
}
//ns