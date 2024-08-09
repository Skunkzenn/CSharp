namespace C_Sharp.Cap_14_Interfaces.Interfaces
{
    interface IInterfaces
    {
        /* Interface é um tipo que define um conjunto de operações que uma classe (ou struct) deve implementar  
           basicamente, a interface estabelece um contrato que a classe (ou struct) deve cumprir, ou seja, 
           as operações serão obrigadas a serem aplicadas assim como também os atributos.

           O uso de interfaces é serve para criar sistemas de baixo acoplamento e flexíveis.

         */

        double Area();
        double Permiter();
    }
}
