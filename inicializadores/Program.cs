using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Inicializadores
{
    class Program
    {
        static void Main(string[] args)
        {
			var dad = new Person("Roberto");
			var mom = new Person("Carla");

			var son = new Person("Omar", dad, mom) 
			{ 
				Age = 21, 
				Abilities = new List<string>() 
			};

			//var son = new Person("Omar", dad, mom);
			//son.Age = 21;
			//son.Abilities = new List<string>();

			var aunt = new Person("Claudia")
			{
				Age = 50,
				Mom = new Person("Gil")
				{
					Age = 78,
					Abilities = new List<string>(),
					Dad = new Person("Charlie")
					{
						Age = 106
					}
				}
			};

			var album = new { Title = "Kindred", Artist = "Passion Pit" };
			var gift = new { Item = album, To = aunt };

			//List<string> abilities = new List<string>();
			//abilities.Add("programación");
			//abilities.Add("futbol");
			//abilities.Add("dormir");

			List<string> abilities = new List<string> { "programación", "futbol", "dormir", };

			//string[] abilities = { "programación", "futbol", "dormir" };

			int [,] oddArray =  { { 1, 2 }, { 3, 4 }, { 5, 6 } };

			var daughter = new Person("Lucille", dad, mom)
			{
				Age = 10,
				Abilities = new List<string>
				{
					"programación",
					"cocina",
					"pintura"
				}
			}

			var classAttendance = new List<Person>
			{
				new Person("Rafa") { Age = 10},
				new Person("Rosalinda") { Age = 9},
				new Person("Javi") { Age = 10 },
				new Person("Dalia") { Age = 11 },

			};
        }
    }

    class Person
	{
		public Person(string name)
		{
			Name = name;
		}

		public Person(string name, Person dad, Person mom)
		{
			Name = name;
			Dad = dad;
			Mom = mom;
		}

		public string Name { get; private set; }
		public int Age { get; set; }
		public Person Dad { get; set; }
		public Person Mom { get; set; }
		public List<string> Abilities { get; set; }
    }
}
