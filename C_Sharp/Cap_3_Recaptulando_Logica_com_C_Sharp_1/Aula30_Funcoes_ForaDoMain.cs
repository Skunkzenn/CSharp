namespace CursoUdemy;

internal class Aula30_Funcoes_ForaDoMain
{
    static void Main(string[] args)
    {
        //Aula 30 Funções
        Console.WriteLine("Digite 3 numeros");
        int n1 = int.Parse(Console.ReadLine());
        int n2 = int.Parse(Console.ReadLine());
        int n3 = int.Parse(Console.ReadLine());

        /* Ao inves de escrever toda a função abaixo, vamos delegar toda a lógica para uma função que se chama maior;
        if (n1 > n2 && n1 > n3) Console.WriteLine("N1 maior " + n1);
        else if (n2 > n3) Console.WriteLine("N2 maior " + n2);
        else Console.WriteLine("N3 maior " + n3); */

        //Como a entrada da função é um inteiro, no static devemos acrescer o int 
        double resultado = Maior(n1, n2, n3);
        Console.WriteLine("O maior é: " + resultado);

    }

    //Aqui acrescentar um int para armazenar o maior número
    //Estamos declarando 3 nº inteiros, conforme os números que darão entradas para serem verificados    
    static int Maior(int a, int b, int c){   
        int m;
        if (a > b && a > c) m = a;
        else if (b > c) m = b;
        else m = c;

        //Ao fazer o return, estaremos a passar o valor que foi guardada na variável m
        //Sem esse retorno a função não vai funcionar
        return m;
    }
}