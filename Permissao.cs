using System;
namespace Aula14TryCatch
{
    public class Permissao
    {
        private bool permissao { get; set; }
        public void Acessar(){


            Digitenovamente:
        //try-tentar ,se try nao conseguir vai automaticamente entrar catch
        try
        {
            Console.WriteLine("Quer acesso a programaçao?/true/false");
            permissao = Boolean.Parse(Console.ReadLine());
        }
        catch (Exception)
        {
            
            
            Console.WriteLine("Erro nos dados colocados");
            //forma como e usado o goto
            if(permissao == !true || !false){ 
                goto Digitenovamente;


            }
        }

        }

    }
}