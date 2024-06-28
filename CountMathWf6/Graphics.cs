using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using VM6;

namespace CountMathWf6
{
    public partial class Graphics : Form
    {
        // количество точек
        int n;
        // значения задаваемые в программе 
        double x0,xn,H,y0;
        // Получение всех X
        List<double> X_RES = new List<double>();
        List<double> y_Eyler = new List<double>();
        // построение графика по исправленному методу Эйлера
        private void butFixEiler_Click(object sender, EventArgs e)
        {
            Count();
            y_Eyler = new List<double>();
            Eiler(ref y_Eyler);
            List<double> y_Isp_Eyler = new List<double>();
            y_Isp_Eyler.Add(y0);
            for (int i = 1; x0 <= xn; x0 += H, i++)
            {
                y_Isp_Eyler = Realiz.IspEyler(x0, y_Isp_Eyler, y_Eyler, i, H);
            }
            x0 = double.Parse(tbx0.Text);
            // Левая граница.
            double a = x0;
            // Правая граница.
            double b = xn;
            // Шаг графика.
            double x, y;
            this.chartGraph.Series[2].Points.Clear();
            x = a;
            int j = 0;
            while (x <= b)
            {
                y = y_Isp_Eyler[j];
                this.chartGraph.Series[2].Points.AddXY(x, y);
                x += H;
                j++;
            }

        }

        public Graphics()
        {
            InitializeComponent();
        }

        private void butClear_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < chartGraph.Series.Count; i++)
            {
                chartGraph.Series[i].Points.Clear();
            }
        }
        // построение графика по методу Рунге - Кутты - Мерсона
        private void butRKM_Click(object sender, EventArgs e)
        {
            Count();
            List<double> y_RKM = new List<double>();
            y_RKM.Add(y0);
            y_RKM = Realiz.RKM(y_RKM, X_RES, H, n);
            // Левая граница.
            double a = x0;
            // Правая граница.
            double b = xn;
            // Шаг графика.
            double x, y;
            this.chartGraph.Series[3].Points.Clear();
            x = a;
            int j = 0;
            while (x <= b)
            {
                y = y_RKM[j];
                this.chartGraph.Series[3].Points.AddXY(x, y);
                x += H;
                j++;
            }
        }
        // построение графика по методу Адамса 2-го порядка 
        private void butAdamson_Click(object sender, EventArgs e)
        {
            Count();
            y_Eyler = new List<double>();
            Eiler(ref y_Eyler);
            List<double> y_Adams = new List<double>();
            y_Adams = Realiz.Adams1(y_Adams, y_Eyler, H, y0, x0);
            for (int i = 2; x0 <= xn; x0 += H, i++)
            {
                y_Adams = Realiz.Adams2(x0, y_Adams, H, i);
            }
            x0 = double.Parse(tbx0.Text);
            // Левая граница.
            double a = x0;
            // Правая граница.
            double b = xn;
            // Шаг графика.
            double x, y;
            this.chartGraph.Series[4].Points.Clear();
            x = a;
            int j = 0;
            while (x <= b)
            {
                y = y_Adams[j];
                this.chartGraph.Series[4].Points.AddXY(x, y);
                x += H;
                j++;
            }

        }
        //построение графика точного решения
        private void butClearSolve_Click(object sender, EventArgs e)
        {
            Count();
            List<double> Y_toch = new List<double>();
            for (; x0 <= xn; x0 += H)
            {
                Y_toch = Realiz.f(Y_toch, x0);
            }
            x0 = double.Parse(tbx0.Text);
            // Левая граница.
            double a = x0;
            // Правая граница.
            double b = xn;
            // Шаг графика.
            double x, y;
            this.chartGraph.Series[0].Points.Clear();
            x = a;
            int j = 0;
            while (x <= b )
            {
                y = Y_toch[j];
                this.chartGraph.Series[0].Points.AddXY(x, y);
                x += H;
                j++;
            }
        }
        // Получение входных данных
        void Count()
        {
            x0 = double.Parse(tbx0.Text);
            xn = double.Parse(tbxn.Text);
            H = double.Parse(tbh.Text);
            X_RES = new List<double>();
            y0 = double.Parse(tby0.Text);
            n = 0;
            for (; x0 <= xn; x0 += H)
            {
                n++;
            }
            x0 = double.Parse(tbx0.Text);
            for (; x0 <= xn; x0 += H)
            {
                X_RES.Add(x0);
            }
            x0 = double.Parse(tbx0.Text);
        }
        // Расчет по методу Эйлера.
        void Eiler(ref List<double> yEiler)
        {
            yEiler.Add(y0);
            for (int i = 1; x0 <= xn; x0 += H, i++)
            {
                yEiler = Realiz.Eyler(x0, yEiler, H);
            }
            x0 = double.Parse(tbx0.Text);
        }
        // построение графика по методу Эйлера
        private void butEiler_Click(object sender, EventArgs e)
        {
            Count();
            y_Eyler = new List<double>();
            Eiler(ref y_Eyler);

            // Левая граница.
            double a = x0;
            // Правая граница.
            double b = xn;
            // Шаг графика.
            double x, y;
            this.chartGraph.Series[1].Points.Clear();
            x = a;
            int j = 0;
            while (x <= b)
            {
                y = y_Eyler[j];
                this.chartGraph.Series[1].Points.AddXY(x, y);
                x += H;
                j++;
            }

        }
    }
}
