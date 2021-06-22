using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CalculadorMediaMovel.Screens
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class InitialPage : ContentPage
    {
        private int index = 0;
        private int[] vetor;


        public InitialPage()
        {
            InitializeComponent();

            coletarDados();
        }

        public void coletarDados() 
        {
            int tamanhoDoVetor = 0;
            int valorInicial = 0;


            //TO DO: Coletar o tamanho do vetor e valor inicial do usuario.
            tamanhoDoVetor = 7;
            valorInicial = 8;

            //Inicializando o 'vetor'.
            //TO DO: Implementar verificacao da variavel 'tamanhoDoVetor' para verificar se o valor esta zero ou negativo.
            vetor = new int[tamanhoDoVetor];

            //Populando array 'vetor'.
            //TO DO: Verificar se 'valorInicial' esta com valor zero ou negativo.
            for (int i = 0; i < vetor.Length;i++)
            {
                vetor[i] = valorInicial;
            }
        }

        public void calcularMediaMovel()
        {
            coletarDados();


        }

    }

}