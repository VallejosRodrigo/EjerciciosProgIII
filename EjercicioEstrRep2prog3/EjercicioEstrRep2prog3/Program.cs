using System;

namespace ejercicioEstrIter2
{
    class Calculadora
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Ingrese la altura en centimetros de diez personas: \n");

            double[] alturaPersonas = new double[10];
            double suma = 0;
            int longitud = alturaPersonas.Length;
            double sumCuadrados = 0.0;


            //cargar arreglo
            for (int i = 0; i < alturaPersonas.Length; i++)
            {
                Console.Write("Altura de la persona n°{0}: ", i + 1);
                alturaPersonas[i] = double.Parse(Console.ReadLine());
            }
            Console.WriteLine("\n");


            //calcular la media

            foreach (double valor in alturaPersonas)
            {
                suma += valor;
            }
            double media = suma / longitud;
            Console.WriteLine("La media es: | {0} |", media);


            //calcular la desviacion estandar
            for (int i = 0; i < longitud; i++)
            {
                sumCuadrados += Math.Pow(alturaPersonas[i] - media, 2);
            }

            // Calcular la sumatoria de los cuadrados de las diferencias
            for (int i = 0; i < longitud; i++)
            {
                sumCuadrados += Math.Pow(alturaPersonas[i] - media, 2);
            }

            double desviacionEstandar = Math.Sqrt(sumCuadrados / longitud);
            string numeroCorto = desviacionEstandar.ToString("N2");

            Console.WriteLine("\nDesviacion estandar: | {0} |", numeroCorto);


            //alturas en media
            List<double> alturasPorEncima = new List<double>();
            List<double> alturasPorDebajo = new List<double>();
            List<double> alturasMedia = new List<double>();

            foreach (double altura in alturaPersonas)
            {
                if (altura > media)
                {
                    alturasPorEncima.Add(altura);
                }
                else if (altura < media)
                {
                    alturasPorDebajo.Add(altura);
                }
            }
            Console.Write("\nAlturas por encima de la media:\n");
            Console.Write(" | ");
            foreach (double altura in alturasPorEncima)
            {
                Console.Write(altura + " | ");
            }

            Console.Write("\n\nAlturas por debajo de la media:\n");
            Console.Write(" | ");
            foreach (double altura in alturasPorDebajo)
            {
                Console.Write(altura + " | ");
            }


            //calcula y muestra alturas dentro del rango definido por desviacion estandar
            double divDesvEstandar = desviacionEstandar / 2;
            double mediaMasDesv = media + divDesvEstandar;
            double mediaMenosDesv = media - divDesvEstandar;
            string numeroCorto2 = mediaMasDesv.ToString("N2");
            string numeroCorto3 = mediaMenosDesv.ToString("N2");

            List<double> dentroDesvioEstandar = new List<double>();

            foreach (double g in alturaPersonas)
            {
                if (g <= mediaMasDesv && g >= mediaMenosDesv)
                {
                    dentroDesvioEstandar.Add(g);
                }
            }

            Console.Write("\n\nAlturas que se encuentran dentro del rango " +
                "definido por la desviacion estandar\n(numeros que esten entre {0} y {1}):\n", numeroCorto3, numeroCorto2);
            Console.Write(" | ");
            foreach (double o in dentroDesvioEstandar)
            {
                Console.Write(o + " | ");
            }
            Console.WriteLine();
        }
    }
}