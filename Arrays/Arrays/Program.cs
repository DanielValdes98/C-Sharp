
namespace Arrays
{
    class Program
    {
        public static void Main(string[] args)
        {
            Empleados empl1 = new Empleados("Daniel", 24);
            Empleados empl2 = new Empleados("Jenni", 23);

            Empleados[] arrayEmpleados = new Empleados[2];

            arrayEmpleados[0] = empl1;
            arrayEmpleados[1] = empl2;

            // Console.WriteLine(arrayEmpleados);

            var valores = new[] { 15, 28, 35, 75.5, 30.30 };

            foreach (Empleados empl in arrayEmpleados) 
            {
                Console.WriteLine(empl.getNombre());
            }
        }

    }

}