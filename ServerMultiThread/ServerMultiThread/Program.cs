using System;

namespace ServerMultiThread
{
    class Program
    {
        static int Main(string[] args)
        {
            /*Console.WriteLine("tcplistener by hvivani – 20110225 – para el negro: \r\n");
            if (args.Length == 0)
            {
                Console.WriteLine("Parametros: Puerto IP   \r\n");
                Console.WriteLine("Ejemplo: tcplistener 2525 127.0.0.1  \r\n");
                Console.WriteLine("si tenes mas de una interfaz de red, usa la ip de dicha interfaz.  \r\n");
                Console.ReadKey();
                return 1;
            }
            else
            {*/
            Console.WriteLine("Iniciando.");
            multicnnNew.iniciar("99","127.0.0.1");//(args[0], args[1]);
                return 0;
            //}
        }
    }
}
