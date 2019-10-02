//Atributos: Nome, Fome, Saúde e Idade b. Métodos: Alterar Nome, Fome, Saúde e Idade; Retornar Nome, Fome, Saúde e Idade Obs: Existe mais uma informação que devemos levar em consideração, o Humor do nosso tamagushi, este humor é uma combinação entre os atributos Fome e Saúde, ou seja, um campo calculado, então não devemos criar um atributo para armazenar esta informação por que ela pode ser calculada a qualquer momento.

using System;
namespace Higor{
  class tamagushi{
    protected string nome;
    protected int fome;
    protected int saude;
    protected int idade;
    protected double humor;

    public void alimentar(){
      if(fome <= 0){ 
        fome = 0;
      }else{
        fome = fome -1;
      }
      relatorio();
    }

    public void interacao(int n){
      if(n==0){
        humor = humor - saude*0.1 +fome*0.1 ;
      }else{
        humor = humor + saude*0.1 +fome*0.1 ;
      }
    }

    public void relatorio(){
      Console.WriteLine("Nome: {0}\nFome:{1}\nSaúde:{2}\nIdade:{3}\nHumor:{4}", nome, fome, saude, idade, humor);
    }
    public tamagushi(string n){
      nome = n;
      fome = 0;
      saude = 10;
      idade = 0;
      humor = 5;
    }
  }

}