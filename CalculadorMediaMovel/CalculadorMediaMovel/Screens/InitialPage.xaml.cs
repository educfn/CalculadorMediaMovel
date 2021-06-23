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
        private static int ultimaPosicao = 0;


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

     
        public void calcularMediaMovel()
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


        private void colocarNovoValorDiario(int novoValorDiario)
        {
            if (ultimaPosicao >= vetor.Length) ultimaPosicao = 0;
            else vetor[ultimaPosicao++] = novoValorDiario;
        }


        private void botaoInicial_Clicked(object sender, EventArgs e)
        {
            if(entryValorDiaro.Text != "")
            {
                labelMensagemParaUsuario.Text = "";

                if (primeiraVez == true && entryValorTamanhoVetor.Text != "")
                {
                    coletarDados();
                    popularVetor(valorDiario);
                    calcularMediaMovel();
                    primeiraVez = false;
                    labelSubTituloTamanhoVetor.IsEnabled = false;
                    labelSubTituloTamanhoVetor.IsVisible = false;
                    entryValorTamanhoVetor.IsEnabled = false;
                    entryValorTamanhoVetor.IsVisible = false;
                    entryValorTamanhoVetor.Text = "";
                    entryValorDiaro.Text = "";

                }
                else
                {
                    coletarDados();
                    colocarNovoValorDiario(valorDiario);
                    calcularMediaMovel();
                    entryValorDiaro.Text = "";
                }
            }
            else 
            {
                labelMensagemParaUsuario.Text = "Coloque um numero na entrada Valor Diario";
            }
           
        }

    }

}