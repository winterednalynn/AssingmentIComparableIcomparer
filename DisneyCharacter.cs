using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssingmentIComparableIcomparer
{
    internal class DisneyCharacter : IComparable<DisneyCharacter> // CLASS FOR CHARACTER 
    {
       //FIELDS 
        
        string _name;
        string _role;
        int _rank;
        public enum typeOfcharacter { OG, Princess, Creature }
        typeOfcharacter _typeOfcharacter;


        //CONSTRUCTOR 
        public DisneyCharacter(string name, string role, typeOfcharacter typeOfcharacter, int rank)
        {
            _name = name;
            _role = role;
            _typeOfcharacter = typeOfcharacter;
            _rank = rank;
        }

        //PROPERTIES 
        public string Name { get => _name; set => _name = value; }
        public string Role { get => _role; set => _role = value; }
        public typeOfcharacter TypeOfcharacter { get => _typeOfcharacter; set => _typeOfcharacter = value; }
        public int Rank { get => _rank; set => _rank = value; }

        //ICOMPARABLE 
        public int CompareTo(DisneyCharacter other)
        {
            if (this._rank > other._rank)
            {
                return 1;
            }
            else if (this._rank < other._rank)
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }
        //OVERRIDE TO STRING 
        public override string ToString()
        {
            return $" * - Name: {_name} \n  * Role: {_role} \n  * Type Of Character: {_typeOfcharacter} \n  * Rank: {_rank}";
        }

        
    }
}
