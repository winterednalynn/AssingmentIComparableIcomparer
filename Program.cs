using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssingmentIComparableIcomparer
{
    internal class Program
    {//EDNA LYNN LAXA 
     //PROGRAMMING III - ICOMPARABLE & ICOMPARER 
     // MAY 29, 2023 

        static void Main(string[] args)
        {
            //CLASS PLACED IN A LIST 
            List<DisneyCharacter> _disneyCharacter = new List<DisneyCharacter>();

            //ADDING TO LIST 
            _disneyCharacter.Add(new DisneyCharacter("Mulan", "Woman Warrior", DisneyCharacter.typeOfcharacter.Princess, 1));
            _disneyCharacter.Add(new DisneyCharacter("Belle", "Beauty Within", DisneyCharacter.typeOfcharacter.Princess, 3));
            _disneyCharacter.Add(new DisneyCharacter("Stitch", "Ohana Purpose", DisneyCharacter.typeOfcharacter.Creature, 7));
            _disneyCharacter.Add(new DisneyCharacter("Big Hero", "Gentle Big Thing", DisneyCharacter.typeOfcharacter.Creature, 5));
            _disneyCharacter.Add(new DisneyCharacter("Ursula", "Evil Fish", DisneyCharacter.typeOfcharacter.OG, 100));

            //LIST STRUCTURE 
            //CALLING DISPLAYCLASSICATION TO LIST THINGS NICELY. 
            DisplayClassifications(_disneyCharacter, "No Sorting");
            _disneyCharacter.Sort(); 

            //SORT BY NAME 
            DisplayClassifications(_disneyCharacter, "By Name"); 
            NameSorter sortName = new NameSorter();
            _disneyCharacter.Sort(sortName);

            //SORT BY TYPE 
            DisplayClassifications(_disneyCharacter, "By Type");
            sortType sortType = new sortType();
            _disneyCharacter.Sort(sortType);

            //SORT RANK 
            DisplayClassifications(_disneyCharacter, "By Role");
            RoleSorter sortRole = new RoleSorter();
            _disneyCharacter.Sort(sortRole);






        }
        //main
        public static void DisplayClassifications(List<DisneyCharacter> character, string classificationSort)
        {
            //USING FOR EACH TO DISPLAY THROUGH LIST. 
            //FOR PARAMETER CLASSIFICATION SORT THIS IS PLACED AS A STRING TO WHERE WE CAN TITLE WHAT IT IS SORTED BY
     
            Console.WriteLine(classificationSort);
            foreach (DisneyCharacter disneyCharacter in character)
            {
                Console.WriteLine(disneyCharacter);
            }
            Console.WriteLine();
            Console.WriteLine("\n ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^ \n");

        }
    }
    //class
}
//ns