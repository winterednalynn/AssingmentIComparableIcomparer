using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssingmentIComparableIcomparer
{
    internal class RoleSorter : IComparer<DisneyCharacter> //COMPARING ROLE
    {
        public int Compare(DisneyCharacter x, DisneyCharacter y) // COMPARING ROLE PROPERY 
        {
            return x.Role.CompareTo(y.Role);    
        }
    }
}
