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