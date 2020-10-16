using System;
using System.Collections.Generic;
using Divisores.Testes.src.Service.Divisores;

namespace Divisores.Testes.src.Service.DivisoresService
{
    public class DivisoresService : IDivisores
    {
        public List<int> BuscaDivisores(int numero)
        {
            List<int> divisores = new List<int>();
            try{
                int valoratual = 1;
                while(valoratual<=numero){
                    if(EDivisor(valoratual, numero)){
                        divisores.Add(valoratual);
                    }
                    valoratual++;
                }
                return divisores;
            }catch(Exception erro){
                Console.WriteLine(erro.Message);
                return new List<int>();
            }
        }
        public List<int> BuscaDivisoresPrimos(int numero)
        {
            List<int> divisoresprimos = new List<int>();
            try{
                int valoratual = 1;
                while(valoratual<=numero){
                    if(EDivisor(valoratual, numero)){
                        if(EPrimo(valoratual)){
                            divisoresprimos.Add(valoratual);
                        }
                    }
                    valoratual++;
                }
                return divisoresprimos;
            }catch(Exception erro){
                Console.WriteLine(erro.Message);
                return new List<int>();
            }
        }
        private bool EDivisor(int divisor, int dividendo)
        {
            try{
                return dividendo%divisor==0;
                Console.WriteLine("oi");

            }catch(Exception erro){
                Console.WriteLine(erro.Message);
                return false;
            }
        }
        private bool EPrimo(int possivelprimo)
        {
            try{
                if(possivelprimo<2){
                    return false;
                }
                else{
                    List<int> divisores = BuscaDivisores(possivelprimo);
                    if(divisores.Count==2 && divisores.Contains(1) && divisores.Contains(possivelprimo)){
                        return true;
                    }else{
                        return false;
                    }

                }
            }catch(Exception erro){
                Console.WriteLine(erro.Message);
                return false;
            }
        }
    }
}