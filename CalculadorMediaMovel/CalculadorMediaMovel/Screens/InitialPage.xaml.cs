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
        private static bool primeiraVez = true;
        private static int[] vetor;
        private static int mediaMovel = 0;
        private static int valorDiario = 0;


        public InitialPage()
        {
            InitializeComponent();
        }

        private void coletarDados() 
        {
            int tamanhoDoVetor = 0;


            if (vetor == null)
            {
                tamanhoDoVetor = int.Parse(entryValorTamanhoVetor.Text);
                //Inicializando o 'vetor'.
                //TO DO: Implementar verificacao da variavel 'tamanhoDoVetor' para verificar se o valor esta zero ou negativo.
                vetor = new int[tamanhoDoVetor];
            }
            
            valorDiario = int.Parse(entryValorDiaro.Text);

            
        }

        private void popularVetor(int valor)
        {
            //Populando array 'vetor' com o mesmo valor.
            //TO DO: Verificar se 'valor' esta com valor zero ou negativo.
            //TO DO: Verificar se o vetor foi inicializado.
            for (int i = 0; i < vetor.Length; i++)
            {
                vetor[i] = valor;
            }
        }

     
        public void calcularMediaMovel(int valor)
        {
            labelMensagemParaUsuario.Text = "Calculando Media Movel";

            int somaDosValores = 0, quantidadeDeValores = vetor.Length;

            for (int i = 0; i < vetor.Length;i++)
            {
                somaDosValores += vetor[i];
            }

            mediaMovel = somaDosValores / quantidadeDeValores;

            labelMensagemParaUsuario.Text = "Media Movel:" + mediaMovel;
        }

        //TO DO
        private void colocarNovoValorDiario(int novoValorDiario)
        {
            //TO DO: Verificar se valor esta com valor zero ou negativo.
            for (int i = 0; i < vetor.Length; i++)
            {
                vetor[i] = novoValorDiario;
            }
        }


        private void botaoInicial_Clicked(object sender, EventArgs e)
        {
            
            if (primeiraVez == true)
            {
                coletarDados();
                popularVetor(valorDiario);
                calcularMediaMovel(valorDiario);
                primeiraVez = false;
                labelSubTituloTamanhoVetor.IsEnabled = false;
                labelSubTituloTamanhoVetor.IsVisible = false;
                entryValorTamanhoVetor.IsEnabled = false;
                entryValorTamanhoVetor.IsVisible = false;
            }
            else
            {
                coletarDados();
                calcularMediaMovel(valorDiario);
            }
           
        }

    }

}