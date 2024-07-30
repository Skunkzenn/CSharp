/* 

Lampada � o nome da classe.
-ligada: boolean indica um atributo (ou campo) da classe chamado "ligada", que � do tipo booleano. O sinal de menos "-" antes do nome do atributo � comumente usado para indicar que o atributo � privado.
+Lampada() � um construtor da classe, usado para criar uma inst�ncia da classe.
+Acender(): void � um m�todo p�blico chamado "Acender" que n�o retorna um valor (void). Esse m�todo provavelmente � usado para ligar a l�mpada.
+Apagar(): void � um m�todo p�blico chamado "Apagar" que tamb�m n�o retorna um valor (void). Este m�todo provavelmente � usado para desligar a l�mpada.
+Estado(): string � um m�todo p�blico chamado "Estado" que retorna uma string. Este m�todo pode ser usado para obter o estado atual da l�mpada (ligada ou desligada). 

 */

namespace Exercicios_Em_Aula.ExerciciosAulaPOO;

class Lampada
{
    private bool ligada;

    //O construtor inicializa a l�mpada como desligada por padr�o.
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
    {   //Utilizar o tern�rio para estas situa��es
        return ligada ? "Ligada" : "Desligada";
    }
}