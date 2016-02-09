using System;
using System.Linq;

namespace LinqPost3
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            var db = new FakeDatabase();

            #region Grouping

            // Simple grouping:

            var classesPerTeacherQuery =
                from lecture in db.Lectures
                group lecture by lecture.TeacherId into grp
                select new
                {
                    TeacherId = grp.Key,
                    LectureCount = grp.Count()
                };

            Console.WriteLine("Query syntax: ");
            foreach (var item in classesPerTeacherQuery.OrderBy(t => t.LectureCount).Take(5))
            {
                Console.WriteLine(item.TeacherId + "\t" + item.LectureCount);
            }
            Console.WriteLine();


            var classesPerTeacherMethod = db.Lectures
                .GroupBy(lecture => lecture.TeacherId)
                .Select(grp =>
                    new
                    {
                        TeacherId = grp.Key,
                        LectureCount = grp.Count()
                    });

            Console.WriteLine("Method syntax: ");
            foreach (var teacherLectures in classesPerTeacherMethod.OrderBy(t => t.LectureCount).Take(5))
            {
                Console.WriteLine(teacherLectures.TeacherId + "\t" + teacherLectures.LectureCount);
            }
            Console.WriteLine();

            // Nested grouping:

            var groupedLecturesPerLevelAndTeacher =
                from lecture in db.Lectures
                group lecture by lecture.TeacherId into group1
                select new
                {
                    TeacherId = group1.Key,
                    Levels = from level in group1
                             group level by level.Level into group2
                             select new
                             {
                                 LevelName = group2.Key,
                                 Lectures = group2.ToList()
                             }
                };

            Console.WriteLine("Lectures per level and teacher:");
            foreach (var teacherLevel in groupedLecturesPerLevelAndTeacher.Take(5))
            {
                Console.WriteLine("Teacher Id: " + teacherLevel.TeacherId + ": ");
                foreach (var levelClass in teacherLevel.Levels)
                {
                    Console.WriteLine("\t" + levelClass.LevelName + ": ");
                    foreach (var @class in levelClass.Lectures)
                    {
                        Console.WriteLine("\t\t" + @class.Name);
                    }
                }
            }
            Console.WriteLine();

            #endregion


            #region Join

            var q5 =
                from l in db.Lectures
                group l by l.TeacherId into grouped
                join t in db.Teachers on grouped.Key equals t.Id
                select new
                {
                    TeacherName = t.GivenName,
                    TeacherId = t.Id,
                    LectureCount = grouped.Count()
                };

            var q5alt = db.Lectures
                .GroupBy(l => l.TeacherId)
                .Join(db.Teachers, grouped => grouped.Key, t => t.Id,
                (grouped, t) => new
                {
                    TeacherName = t.GivenName,
                    TeacherId = t.Id,
                    LectureCount = grouped.Count()
                });

            Console.WriteLine("Clases por profesor:");
            foreach (var item in q5.OrderBy(t => t.LectureCount).Take(5))
            {
                Console.WriteLine(item.TeacherName + "\t" + item.LectureCount);
            }
            Console.WriteLine();


            var q6 = from l in db.Teachers
                     orderby l.LastName descending
                     select l;

            var maestro1 = q6.First();
            Console.WriteLine("Maestro " + maestro1.GivenName + " " + maestro1.LastName);

            try
            {
                var cosmeFulanito = q6.First(m => m.GivenName == "Cosme" && m.LastName == "Fulanito");
                Console.WriteLine("Maestro " + cosmeFulanito.GivenName + " " + cosmeFulanito.LastName);
            }
            catch(InvalidOperationException e)
            {
                Console.WriteLine(e.Message);
            }


            var cosmeFulanito2 = q6.FirstOrDefault(m => m.GivenName == "Cosme" && m.LastName == "Fulanito");
            if(cosmeFulanito2 != null)
            {
                Console.WriteLine("Maestro " + cosmeFulanito2.GivenName + " " + cosmeFulanito2.LastName);
            }
            else
            {
                Console.WriteLine("No existe el maestro Cosme Fulanito");
            }

            // Single
            //var maestro3 = q6.Single(); // Excepción porque q6 contiene más de 1 elemento
            //Console.WriteLine("Maestro " + maestro3.GivenName + " " + maestro3.LastName);

            try
            {
                var cosmeFulanito = q6.Single(m => m.GivenName == "Cosme" && m.LastName == "Fulanito");
                Console.WriteLine("Maestro " + cosmeFulanito.GivenName + " " + cosmeFulanito.LastName);
            }
            catch (InvalidOperationException e)
            {
                Console.WriteLine(e.Message);
            }


            var cosmeFulanito3 = q6.SingleOrDefault(m => m.GivenName == "Cosme" && m.LastName == "Fulanito");
            if (cosmeFulanito3 != null)
            {
                Console.WriteLine("Maestro " + cosmeFulanito3.GivenName + " " + cosmeFulanito3.LastName);
            }
            else
            {
                Console.WriteLine("No existe el maestro Cosme Fulanito");
            }

            // ElementAt
            var maestroSegundo = q6.ElementAt(2);
            Console.WriteLine("Segundo maestro: " + maestroSegundo.GivenName + " " + maestroSegundo.LastName);

            var maestroDecimo = q6.ElementAt(10); 
            Console.WriteLine("Décimo maestro: " + maestroDecimo.GivenName + " " + maestroDecimo.LastName);

            try
            {
                var maestroNoningentesimo = q6.ElementAt(900); // Excepción ¡porque q6 no tiene 900 maestros!
                Console.WriteLine("Noningentésimo maestro: " + maestroNoningentesimo.GivenName + " " + maestroNoningentesimo.LastName);

            }
            catch(ArgumentOutOfRangeException e)
            {
                Console.WriteLine("No hay 900 maestros :(");
            }

            #endregion

            Console.Read();
        }
    }
}
