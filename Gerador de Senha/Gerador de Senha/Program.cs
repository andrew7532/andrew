using System;

namespace Gerador_de_Senha;

    while (true)
{
  Console.WriteLine ("--- Gerador de Senha---");
  Console.WriteLine ("Digite 1 para gerar uma senha"); 
  Console.WriteLine ("Digite 2 para sair");  
        
  string opcao = Console.ReadLine();
        
   if (opcao == "1")
   {

    Console.WriteLine("Digite o tamanho da senha que deseja gerar:");

    int tamanhoDaSenha = int.Parse(Console.ReadLine());

    Console.WriteLine("Incluir números: (s/n)");
    bool aceitaNumero = Console.ReadLine().ToLower() == "s";

    Console.WriteLine("Incluir letras maiúsculas: (s/n)");
    bool aceitaMaiuscula = Console.ReadLine().ToLower() == "s";

    Console.WriteLine("Incluir símbolo: (s/n)");
    bool aceitaSimbolo = Console.ReadLine().ToLower() == "s";

    string senhaGerada = GerarSenha(tamanhoDaSenha, aceitaMaiuscula, aceitaNumero, aceitaSimbolo);
    Console.WriteLine($"Senha gerada: {senhaGerada}"); 
    }
    else if (opcao == "2")
{
    break;
}
    else
{
    Console.WriteLine("Opção inválida");
}

Console.WriteLine("Programa finalizado");
Console.ReadLine();

string GerarSenha (int tamanhodasenha, bool aceitaMaiuscula, bool aceitaNumero, bool aceitaSimbolo)
{
    string letrasMaiusculas = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
    string letrasMinusculas = "abcdefghijklmnopqrstuvwxyz";
    string numeros = "0123456789";
    string simbolo = "!@#$%&*()_+"
}