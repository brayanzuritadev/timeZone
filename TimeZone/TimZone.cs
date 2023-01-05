namespace TimeZone
{
    public class TimeZone
    {
        public void Timezone(DateTime fecha)
        {
            DateTime dateNow = DateTime.Now;
            Console.WriteLine("The date and time are {0} UTC.",
                               TimeZoneInfo.ConvertTimeToUtc(dateNow));
        }


        //convertir los valores de fecha y hora en otra fecha y hora usando la zona horaria del destino
        // tiene que recibir como parametros zona horria(fuente) // de donde se quiere convertir
        // fecha y hora. zona horaria(destino) a la que se convertira.


        //respuestas

        /*
        * //hora y fecha convertidos
        *Mostrar si la zona horaria de origen está en DST (horario de verano)
        *Mostrar si la zona horaria de destino está en DST (horario de verano)
        • Diferencia de horas entre la zona horaria de origen y la zona horaria de destino
        • La fecha convertida en formato aaaammdd
        • La hora convertida en formato hhMMss
        Notas:
        • Es obligatorio tener UT
         */

    }

    class TestClass
    {
        static void Main(string[] args)
        {
            // Display the number of command line arguments.
            Console.WriteLine(args.Length);
        }
    }
}