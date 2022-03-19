using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ParcialExtraordinario1
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void proceso_Clicked(object sender, EventArgs e)
        {
            int CANT200, CANT100, CANT50, CANT20, CANT10, CANT5, CANT1, CANT050, CANT025, CANT010, CANT05;//declaracion de variables
            CANT200 = CANT100 = CANT50 = CANT20 = CANT10 = CANT5 = CANT1 = CANT050 = CANT025 = CANT010 = CANT05  = 0;

            float valor;



            Console.WriteLine("\t ingrese la cantidad de dolares");

            valor = float.Parse(ingresar.Text);


            if ((valor >= 200))//codigo de desglose de monedas
            {
                CANT200 = ((int)valor / 200);
                valor = valor - (CANT200 * 200);

            }

            if ((valor >= 100))
            {
                CANT100 = ((int)valor / 100);
                valor = valor - (CANT100 * 100);

            }

            if ((valor >= 50))
            {
                CANT50 = ((int)valor / 50);
                valor = valor - (CANT50 * 50);

            }

            if ((valor >= 20))
            {
                CANT20 = ((int)valor / 20);
                valor = valor - (CANT20 * 20);

            }

            if ((valor >= 10))
            {
                CANT10 = ((int)valor / 10);
                valor = valor - (CANT10 * 10);

            }

            if ((valor >= 5))
            {
                CANT5 = ((int)valor / 5);
                valor = valor - (CANT5 * 5);

            }

            if ((valor >= 1))
            {
                CANT1 = ((int)valor / 1);
                valor = valor - (CANT1 * 1);

            }

            if ((valor >= 0.50))
            {
                CANT050 = ((int)(valor / 0.50));
                valor = valor - (float)(CANT050 * 0.50);


            }

            if ((valor >= 0.25))
            {
                CANT025 = ((int)(valor / 0.25));
                valor = (valor - (float)(CANT025 * 0.25));


            }

            if ((valor >= 0.10))
            {
                CANT010 = ((int)(valor / 0.10));
                valor = valor - (float)(CANT010 * 0.10);

            }

            if ((valor >= 0.05))
            {
                CANT05 = ((int)(valor / 0.05));
                valor = valor - (float)(CANT05 * 0.05);

            }

           resultados.Text= $"Billetes de Q200:{CANT200}" +
                         $"\nBilletes de Q100:{CANT100}" +
                         $"\ntBilletes de Q50:{CANT50}" +
                         $"\ntBilletes de Q20:{CANT20}" +
                         $"\ntBilletes de Q10:{CANT10}" +
                         $"\nBilletes de Q5:{CANT5}" +
                         $"\nBilletes de Q1:{CANT1}" +
                         $"\nMonedas de 50 centavos:{CANT050}" +
                         $"\nMonedas de 25 centavos:{CANT025}" +
                         $"\nMonedas de 10 centavos:{CANT010}" +
                         $"\nMonedas de 5 centavos:{CANT05}";



        }
    }
}
