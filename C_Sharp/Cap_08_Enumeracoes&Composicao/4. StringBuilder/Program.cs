using System;
using String_Builder.Entities;

namespace String_Builder;

class Hello
{
    static void Main()
    {   
        //Instancia a classe comment
        Comment c1 = new Comment("Have a nice trip!");
        Comment c2 = new Comment("Wow that's awesome!!");

        //Instância os valores da classe post
        Post p1 = new Post(
            DateTime.Parse("21/06/2018 13:05:44"),
            "Traveling to New Zeland",
            "I'm going to visit this wonderful country!",
            12);

        //Aqui faz-se a unificação
        p1.AddComment(c1);
        p1.AddComment(c2);

        Comment c3 = new Comment("Good Night!");
        Comment c4 = new Comment("May the force be with you");

        //Instância os valores da classe post
        Post p2 = new Post(
            DateTime.Parse("27/06/2018 23:05:44"),
            "Good night guys",
            "See you tomorrow",
            15);

        p2.AddComment(c3);
        p2.AddComment(c4);

        Console.WriteLine(p1);
        Console.WriteLine(p2);


    }
}