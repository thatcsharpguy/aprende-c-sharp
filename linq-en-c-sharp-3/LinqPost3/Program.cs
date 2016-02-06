using System;
using System.Linq;

namespace LinqPost3
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			var db = new FakeDatabase ();

			#region Grouping

			var classesPerTeacher = from lecture in db.Lectures
				group lecture by lecture.TeacherId into groupedLectures
				select new { TeacherId = groupedLectures.Key, LectureCount = groupedLectures.Count() };

			foreach(var item in classesPerTeacher.OrderBy(t=>t.LectureCount))
			{
				Console.WriteLine(item.TeacherId + "\t" + item.LectureCount);
			}


			#endregion

			Console.Read ();
		}
	}
}
