using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatematicaLibrary
{
    public class Calcolatrice
    {
        public static int[]Ordina(int[] numeri)
        {
            for(int i = 0; i < numeri.Length - 1; i++)
            {
                for (int j = i + 1; j < numeri.Length; j++)
                    if (numeri[i] > numeri[j])
                    {
                        int tmp = numeri[i];
                        numeri[i] = numeri[j];
                        numeri[j] = tmp;
                    }
                
            }
               return numeri; 
        }

        public static double RadQ (double num)
        {
            double resp = 0;
            if (num >= 0)
                resp = Math.Sqrt(num);
            else
                resp = double.NaN;
            return resp;           
        }
        public static bool Bisestile(int anno)
        {
            bool resp = false;
            if (anno % 4 == 0)
                resp = true;
            return resp;
        }
        public static double MediaTemperature(double[] temperature)
        {
            double resp = 0;
            if (temperature != null && temperature.Length > 0)
            {
                int quantita = temperature.Length;
                double somma = 0;
                for (int i = 0; i < quantita; i++)
                {
                    somma = somma + temperature[i];
                }
                resp = somma / quantita;

            }
            else
                resp = double.NaN;
            return resp;
        }
    }
}
