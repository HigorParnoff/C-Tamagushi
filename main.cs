//Classe Bichinho Virtual:Crie uma classe que modele um Tamagushi (Bichinho Eletrônico):
//Atributos: Nome, Fome, Saúde e Idade b. Métodos: Alterar Nome, Fome, Saúde e Idade; Retornar Nome, Fome, Saúde e Idade Obs: Existe mais uma informação que devemos levar em consideração, o Humor do nosso tamagushi, este humor é uma combinação entre os atributos Fome e Saúde, ou seja, um campo calculado, então não devemos criar um atributo para armazenar esta informação por que ela pode ser calculada a qualquer momento.

using System;
using System.Globalization;
namespace Higor{
  class MainClass {
    public static void Main (string[] args) {
      
      DateTime localDate = DateTime.Now;
      Console.WriteLine(localDate);
      tamagushi bichoVirtual = new tamagushi("Altair");

      int escolhaMenu =1;
      while(escolhaMenu != 0){
        Console.WriteLine("0- Sair\n1- Alimentar\n2- Brincar\n3- Limpar");
        escolhaMenu = Convert.ToInt32(Console.ReadLine());
        switch (escolhaMenu){
          case 1:
            bichoVirtual.interacao(1);
            bichoVirtual.alimentar();
            break; 
        }
        
      }
    }
  }
}