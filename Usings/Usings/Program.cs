using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Usings
{
    class Program
    {
        static void Main(string[] args)
        {
            var noDesechable = new NoDesechable();

            Console.Write("\r\n\r\n");

            using (var desechable1 = new Desechable())
            {
                desechable1.DoSomething();
            }

            //var desechable1 = new Desechable();
            //try
            //{
            //    desechable1.DoSomething();
            //}
            //finally
            //{
            //    if (desechable1 != null)
            //    {
            //        ((IDisposable)desechable1).Dispose();
            //    }
            //}

            Console.Write("\r\n\r\n");

            //using (var desechable2 = new Desechable())
            //{
            //    try
            //    {
            //        desechable2.DoSomethingWithException();
            //    }
            //    catch
            //    {
            //        Console.WriteLine("¡¡¡¡¡Error!!!!!");
            //    }
            //}

            var desechable2 = new Desechable();
            try
            {
                try
                {
                    desechable2.DoSomethingWithException();
                }
                catch
                {
                    Console.WriteLine("¡¡¡¡¡Error!!!!!");
                }
            }
            finally
            {
                if (desechable2 != null)
                {
                    ((IDisposable)desechable2).Dispose();
                }
            }

            Console.Write("\r\n\r\n");

            using (Desechable d1 = new Desechable(),
                d2 = new Desechable())
            {

            }

            Console.Write("\r\n\r\n");

            var buffer = new byte[1024];
            int current = 0, read;

            //var homerStream = new FileStream("Homer.txt", FileMode.Open);
            //read = homerStream.Read(buffer, current, buffer.Length);
            //while (read != 0)
            //{
            //    read = homerStream.Read(buffer, current, buffer.Length);
            //    current += read;
            //    Console.WriteLine(Encoding.UTF8.GetString(buffer));
            //}
            //homerStream.Dispose();

            using (FileStream homerStream = new FileStream("Homer.txt", FileMode.Open))
            using (Desechable d1 = new Desechable())
            {
                read = homerStream.Read(buffer, current, buffer.Length);
                while (read != 0)
                {
                    read = homerStream.Read(buffer, current, buffer.Length);
                    current += read;
                    Console.WriteLine(Encoding.UTF8.GetString(buffer));
                }
            }

            Console.Read();
        }
    }
}
