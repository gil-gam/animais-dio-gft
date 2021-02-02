# animais-dio-gft
Algoritmo em C# para definir o tipo de animal seguindo um esquema determinado

Neste problema, você deverá ler 3 palavras que definem o tipo de animal possível segundo o esquema abaixo, da esquerda para a direita.  Em seguida conclua qual dos animais seguintes foi escolhido, através das três palavras fornecidas.

Entrada: A entrada de dados contém 3 palavras, uma em cada linha, necessárias para identificar o animal segundo a figura "animais.png", com todas as letras minúsculas.

Saída: Imprime o nome do animal correspondente à entrada fornecida.

Exemplos de entrada: 
  1) vertebrado, mamifero, onivoro;
  2) vertebrado, ave, carnivoro;
  3) invertebrado, anelideo, onivoro;
 
Exemplos de saída:
  1) homem;
  2) águia;
  3) minhoca.
 


Algoritmo em C#:

using System;
using System.Text;

class MainClass {
  public static void Main (string[] args) {
        String  CLASSEA; //declare as suas variaveis
        String  CLASSEB;
        String  CLASSEC;

        CLASSEA = Console.ReadLine(); //insira suas variaveis
        CLASSEB = Console.ReadLine();
        CLASSEC = Console.ReadLine();

    if (( CLASSEA  == "vertebrado") && (  CLASSEB == "ave") && ( CLASSEC == "carnivoro")) {
      Console.WriteLine("aguia\n");
    }

    if (( CLASSEA  == "vertebrado") && (  CLASSEB == "ave") && ( CLASSEC == "onivoro")) {
      Console.WriteLine("pomba\n");
    }

    if (( CLASSEA  == "vertebrado") && (  CLASSEB == "mamifero") && ( CLASSEC == "onivoro")) {
      Console.WriteLine("homem\n");
    }

   if (( CLASSEA  == "vertebrado") && (  CLASSEB == "mamifero") && ( CLASSEC == "herbivoro")) {
      Console.WriteLine("vaca\n");
    }

    if (( CLASSEA  == "invertebrado") && (  CLASSEB == "inseto") && ( CLASSEC == "hematofago")) {
      Console.WriteLine("pulga\n");
    }

    if (( CLASSEA  == "invertebrado") && (  CLASSEB == "inseto") && ( CLASSEC == "herbivoro")) {
      Console.WriteLine("lagarta\n");
    }

    if (( CLASSEA  == "invertebrado") && (  CLASSEB == "anelideo") && ( CLASSEC == "hematofago")) {
      Console.WriteLine("sanguessuga\n");
    }
    
    if (( CLASSEA  == "invertebrado") && (  CLASSEB == "anelideo") && ( CLASSEC == "onivoro")) {
      Console.WriteLine("minhoca\n");
    }


  }
}
