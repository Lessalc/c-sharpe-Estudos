using System;

namespace desafiosnumericos
{
    class Program
    {
        static void Main(string[] args)
        {
            // TipoCombustivel();
            // OMaior();
            ValidacaoNota();
        }

        private static void ValidacaoNota()
        {
            int contador=0;
            double soma=0;
            while(contador <2)
            {
                double valueRead = Convert.ToDouble(Console.ReadLine());
                if(valueRead>=0 && valueRead<=10){
                    soma += valueRead;
                    contador++;
                }
                else{
                    Console.WriteLine("nota invalida");
                }
            }
            Console.WriteLine("media = {0:0.00}",(soma/contador));

        }

        private static void OMaior()
        {
            string[] vet = Console.ReadLine().Split(' ');
            //complete declarando as variáveis

            int MAIORAB = (Int32.Parse(vet[0]) + Int32.Parse(vet[1]) + Math.Abs(Int32.Parse(vet[0])-Int32.Parse(vet[1])))/2;

            int MAIOR = (MAIORAB+ Int32.Parse(vet[2]) + Math.Abs(MAIORAB - Int32.Parse(vet[2]))) / 2;

            Console.WriteLine($"{MAIOR} eh o maior");
        }


        private static void TipoCombustivel()
        {
            int opcao;
            int alcool = 0, gasolina = 0, diesel = 0;
            do
            {
                opcao = Convert.ToInt32(Console.ReadLine());    
                switch (opcao)
                {
                    case 1:
                        alcool++;
                        break;
                    case 2:
                        gasolina++;    
                        break;
                    case 3:
                        diesel++;
                        break;
                    case 4:
                        Console.WriteLine("MUITO OBRIGADO");
                        Console.WriteLine("Alcool: "+alcool);
                        Console.WriteLine("Gasolina: "+gasolina);
                        Console.WriteLine("Diesel: "+diesel);
                        break;
                    default:                       
                        continue;
                }
            }
       
            while (opcao != 4);
        }












    }
}
