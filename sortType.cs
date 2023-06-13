using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace AssingmentIComparableIcomparer
{
    internal class sortType : IComparer<DisneyCharacter> // Comparing character information for TYPE 
    {
        public int Compare(DisneyCharacter x, DisneyCharacter y) // Implemented Interface 
        {
            return x.TypeOfcharacter.CompareTo(y.TypeOfcharacter); 
        }
    }
}
