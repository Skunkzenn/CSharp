/*
 
 GetHashCode e Equals
    • São operações da classe Object utilizadas para comparar se um objeto é igual a outro

    • Equals: lento, resposta 100%
    • GetHashCode: rápido, porém resposta positiva não é 100%

    • Os tipos pré-definidos já possuem implementação para essas operações. Classes e structs personalizados precisam sobrepô-las.
 
 */

/* Equals : Método que compara se o objeto é igual a outro, retornando true ou false. */
string a = "Maria";
string b = "Alex";
Console.WriteLine(a.Equals(b));

/* GetHashCode : Método que retorna um número inteiro representando um código gerado a partir das informações do objeto 
   
   Mais rápida. 

   Regra de ouro do GetHashCode
                • Se o código de dois objetos for diferente, então os dois objetos são diferentes.
                • Se o código de dois objetos for igual, muito provavelmente os objetos são iguais (pode haver colisão).
 */
string a = "Maria";
string b = "Alex";
Console.WriteLine(a.GetHashCode());
Console.WriteLine(b.GetHashCode());

/* NOTA: PARA MELHOR DESEMPENHO, VALIDAR PRIMEIRO SE OS OBJETOS SAO IGUAIS PELO GETHASHCODE E SE SIM, VALIDAR PELO EQUALS COMO VALIDAÇÃO
 * ASSIM ESTÁ SE POUPANDO RECURSOS AO UTILIZAR O GETHASH CODE PRIMEIRO E SÓ DPS QUE ENCONTRAR OS OBJETOS IGUAIS, VAI SE VALIDAR OS OBJETOS PELO EQUALS */
