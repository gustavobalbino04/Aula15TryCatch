using System;
using System.IO;

namespace Aula14TryCatch
{
    class Program
    {
        static void Main(string[] args)
        {
            Permissao app =new Permissao();
            app.Acessar();
           
           
           
           
           try
            {
             //caso nao tivesse o data.txt ele automaticamente leria o catch
             using (StreamReader sr = File.OpenText("data.txt"))
                {
                    Console.WriteLine($"A o nome do arquivo  é: \n {sr.ReadLine()}");
                }
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine($"O arquivo não foi encontrado");
            }
        }
    }
 }
            //importante para nao mostrar dados importantes 
           // catch  do diretorio (DirectoryNotFoundException)
          //catch do arquivo (IOException)
           

