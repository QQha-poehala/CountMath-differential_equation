using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Windows;

namespace VM6
{

    public static class Realiz
    {
        const double eps = 0.00001;

        // Точное решение 
        public static List<double> f(List<double> y, double x)
        {
            y.Add(0.5 * (-19 * Math.Exp(-x) - Math.Cos(x) + Math.Sin(x) + 20));
            return y;
        }

        // Метод Эйлера
        public static List<double> Eyler(double x, List<double> y, double h)
        {
            y.Add(y.Last() + h * (Math.Sin(x) - y.Last() + 10));
            return y;
        }

        // Метод Рунге-Кутты-Мерсона
        public static List<double> RKM(List<double> y, List<double> X_RES, double h, int n)
        {
            int i = 0;
            while (i < n)
            {
                double k1, k2, k3, k4, k5;
                k1 = h * (Math.Sin(X_RES[i]) - y[i] + 10);
                k2 = h * (Math.Sin(X_RES[i] + (h / 3)) - (y[i] + k1 / 3) + 10);
                k3 = h * (Math.Sin(X_RES[i] + (h / 3)) - (y[i] + (k1 + k2) / 6) + 10);
                k4 = h * (Math.Sin(X_RES[i] + (h / 2)) - (y[i] + (k1 + 3 * k3) / 8) + 10);
                k5 = h * (Math.Sin(X_RES[i] + h) - (y[i] + (k1 - 3 * k3 + 4 * k4) / 2) + 10);
                double sigma = (2 * k1 - 9 * k3 + 8 * k4 - k5) / 30;
                if (Math.Abs(sigma) >= eps)
                {
                    h = h / 2;
                    continue;
                }
                y.Add(y[i] + (k1 + 4 * k2 + k5) / 6);
                if (Math.Abs(sigma) <= eps / 32)
                {
                    h = h * 2;
                }
                i++;
            }
            return y;
        }

        // Метод Эйлера
        public static List<double> IspEyler(double x, List<double> y, List<double> y_Eyler, int i, double h)
        {
            y.Add(y.Last() + h * ((Math.Sin(x) - y.Last() + 10) + (Math.Sin(x + h) - y_Eyler[i] + 10)) / 2);
            return y;
        }

        // Метод Адамса(первые 2 приближения)
        static double F0, F1;
        public static List<double> Adams1(List<double> y, List<double> y_Eyler, double h, double y0, double x0)
        {
            F0 = y0 + h * ((Math.Sin(x0) - y0 + 10) + (Math.Sin(x0 + h) - y_Eyler[1] + 10)) / 2;
            F1 = F0 + h * ((Math.Sin(x0 + h) - F0 + 10) + (Math.Sin(x0 + 2 * h) - y_Eyler[2] + 10)) / 2;
            y.Add(F0);
            y.Add(F1);
            return y;
        }

        // Метод Адамса
        public static List<double> Adams2(double x, List<double> y, double h, int i)
        {
            y.Add(y.Last() + h * (3 * F1 - F0) / 2);
            F0 = F1;
            F1 = Math.Sin(x + h) - y.Last() + 10;
            return y;
        }
    }
}