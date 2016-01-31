using System;
using System.Linq;

namespace LinqPost2
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			var db = new FakeDatabase ();

			var query1 = 
				from lecture in db.Lectures
				group lecture by lecture.TeacherId into grouped
				join teacher in db.Teachers on grouped.Key equals teacher.Id
				where teacher.LastName == "Williams"
				select new { 	TeacherId = grouped.Key, 
								Name = teacher.GivenName };  

			var query2 = 
				db.Lectures
				.GroupBy (lecture => lecture.TeacherId)
				.Join (db.Teachers, g => g.Key, t => t.Id,
					(g, t) => new { Grouped = g, Teacher = t})
				.Where (anon => anon.Teacher.LastName == "Williams")
				.Select (anon => new { 	TeacherId = anon.Grouped.Key,
										Name = anon.Teacher.GivenName  });
			
			Console.WriteLine ("Query syntax");
			foreach (var obj in query1) {
				Console.WriteLine (obj.TeacherId + " " + obj.Name);
			}

			#region Count
			Console.WriteLine (Environment.NewLine);
			Console.WriteLine ("Method syntax");
			foreach (var obj in query2) {
				Console.WriteLine (obj.TeacherId + " " + obj.Name);
			}
			#endregion

			#region Sum
			Console.Write (Environment.NewLine);
			var profesoresConL = db.Teachers.Count (p => p.GivenName.StartsWith ("L"));
			Console.Write ("Profesores con L : " + profesoresConL);

			Console.Write (Environment.NewLine);
			var menosDe30Total = db.Teachers
				.Where (t => t.Age < 30)
				.Sum (t => t.Age);

			var menosDe30Total1 = (from t in db.Teachers
			                       where t.Age < 30
			                       select t.Age).Sum ();
			Console.Write ("Suma de las edades de profesores menores a 30: " + menosDe30Total + " | " + menosDe30Total1);
			#endregion

			#region Min y Max
			Console.Write (Environment.NewLine);
			var edadMinSinEmail = (from t in db.Teachers
			                       where t.Email == ""
			                       select t).Min (t => t.Age);

			var edadMaxSinEmail = db.Teachers
				.Where (t => t.Email != "")
				.Max (t => t.Age);

			Console.WriteLine ("Edad mínima " + edadMinSinEmail + ", edad máxima " + edadMaxSinEmail);
			#endregion

			#region Average
			Console.Write (Environment.NewLine);
			var promedioEdadSMail = (from t in db.Teachers
			                         where t.Email == ""
			                         select t).Average (t => t.Age);

			var promedioEmailCMail = db.Teachers
				.Where (t => t.Email != "")
				.Average (t => t.Age);

			Console.WriteLine ("Edad promedio sin mail " + promedioEdadSMail + ", promedio edad con email " + promedioEmailCMail);
			#endregion

			#region All
			Console.Write (Environment.NewLine);
			bool todosMayores = db.Teachers.All (teacher => teacher.Age > 18);

			Console.WriteLine ((todosMayores ? "Todos " : "No todos ") + "los maestros son mayores");
			#endregion

			#region Any
			bool existeCosmeFulanito = db.Teachers.Any (teacher => teacher.GivenName == "Cosme"
			                           && teacher.LastName == "Fulanito");

			Console.WriteLine ((existeCosmeFulanito ? "Existe " : "No existe ") + "Cosme Fulanito");

			bool hayClases = db.Lectures.Any ();
			Console.WriteLine (hayClases ? "Hay clases, yay! " : "No hay clases :( :(");
			#endregion

			#region Order By

			var maestrosOrdenados1 = from t in db.Teachers
				orderby t.LastName.Length descending
			                         select t;

			Console.Write (Environment.NewLine);
			var maestrosOrdenados2 = db.Teachers
				.OrderBy (t => t.LastName.Length);

			Console.Write (Environment.NewLine);
			var maestrosOrdenados3 = db.Teachers
				.OrderBy (t => t.LastName.Length)
				.ThenByDescending (t => t.GivenName);

			Console.WriteLine ("Maestros ordenados 1: ");
			foreach (var teacher in maestrosOrdenados1) {
				Console.Write (teacher.GivenName + " ");
			}
			Console.WriteLine ();

			Console.WriteLine ("Maestros ordenados 2: ");
			foreach (var teacher in maestrosOrdenados2) {
				Console.Write (teacher.GivenName + " ");
			}
			Console.WriteLine ();

			Console.WriteLine ("Maestros ordenados 3: ");
			foreach (var teacher in maestrosOrdenados3) {
				Console.Write (teacher.GivenName + " ");
			}
			Console.WriteLine ();
			#endregion

			#region Partition
			var cincoMenores20 = (from t in db.Teachers
			                      where t.Age < 20
			                      orderby t.Age
			                      select t).Take (5);
			
			Console.WriteLine ("Maestros menores: ");
			foreach (var teacher in cincoMenores20) {
				Console.WriteLine (teacher.GivenName + " " + teacher.Age);
			}


			var otrosMaestros = db.Teachers
				.Where(t=> t.Age > 30)
				.OrderByDescending(t => t.Age)
				.Skip(4);
				

			Console.WriteLine ("Otros mayores: ");
			foreach (var teacher in otrosMaestros) {
				Console.WriteLine (teacher.GivenName + " " + teacher.Age);
			}
			#endregion

			Console.Read ();
		}
	}
}
