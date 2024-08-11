/* 

Lampada é o nome da classe.
-ligada: boolean indica um atributo (ou campo) da classe chamado "ligada", que é do tipo booleano. O sinal de menos "-" antes do nome do atributo é comumente usado para indicar que o atributo é privado.
+Lampada() é um construtor da classe, usado para criar uma instância da classe.
+Acender(): void é um método público chamado "Acender" que não retorna um valor (void). Esse método provavelmente é usado para ligar a lâmpada.
+Apagar(): void é um método público chamado "Apagar" que também não retorna um valor (void). Este método provavelmente é usado para desligar a lâmpada.
+Estado(): string é um método público chamado "Estado" que retorna uma string. Este método pode ser usado para obter o estado atual da lâmpada (ligada ou desligada). 

 */

namespace Exercicios_Em_Aula.ExerciciosAulaPOO;

class Lampada
{
    private bool ligada;

    //O construtor inicializa a lâmpada como desligada por padrão.
    public Lampada()
    {
        ligada = false;
    }

    public void Acender()
    {
        ligada = true;
    }

    public void Apagar()
    {
        ligada = false;
    }

    public string Estado()
    {   //Utilizar o ternário para estas situações
        return ligada ? "Ligada" : "Desligada";
    }
}