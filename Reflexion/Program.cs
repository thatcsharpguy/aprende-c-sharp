using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Reflexion
{
    class Program
    {
        static void Main(string[] args)
        {
            var zero = "0";

            Type type = zero.GetType();
            Console.WriteLine(type); // System.String

            Assembly assembly = type.Assembly;
            Console.WriteLine(type.Assembly); // mscorlib, Version=4.0.0.0, Culture=neutral,

            Console.WriteLine();
            foreach (var ty in assembly.GetTypes()
                .Where(ty => ty.Name.StartsWith("Int32")))
            {
                Console.WriteLine(ty);
            }

            Console.WriteLine();
            var int32Type = assembly.GetType("System.Int32");

            var createdInt = Activator.CreateInstance(int32Type);
            Console.WriteLine(createdInt);


            Console.WriteLine();

            var phone = new Smartphone();
            phone.IsLocked = true;
            phone.Carrier = "Entel";

            var phoneType = phone.GetType();
            var carrierProperty = phoneType.GetProperty("Carrier");
            foreach (var att in carrierProperty.GetCustomAttributes())
            {
                Console.WriteLine(att.GetType().Name);
            }


            Console.WriteLine();
            var propertiesWithDisplayName = from prop in phoneType.GetProperties()
                                            where prop.GetCustomAttributes<DisplayAttribute>().Any()
                                            select prop;
            foreach (var property in propertiesWithDisplayName)
            {
                var attr = property.GetCustomAttribute<DisplayAttribute>();
                Console.WriteLine(attr.Name + ": " + property.GetValue(phone));
            }

            Console.WriteLine();
            Console.WriteLine("Escribe el nombre de la propiedad a modificar:");
            var propertyName = Console.ReadLine();
            var propertyToModify = phoneType.GetProperty(propertyName);

            if (propertyToModify != null)
            {
                Console.WriteLine("Escribe el valor:");
                var value = Console.ReadLine();
                propertyToModify.SetValue(phone, Convert.ChangeType(value, propertyToModify.PropertyType));
            }
            else
            {
                Console.WriteLine("La propiedad " + propertyName + " no existe");
            }

            Console.Read();

        }
    }
}
