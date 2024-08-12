/*
 
 GetHashCode e Equals
    � S�o opera��es da classe Object utilizadas para comparar se um objeto � igual a outro

    � Equals: lento, resposta 100%
    � GetHashCode: r�pido, por�m resposta positiva n�o � 100%

    � Os tipos pr�-definidos j� possuem implementa��o para essas opera��es. Classes e structs personalizados precisam sobrep�-las.
 
 */

/* Equals : M�todo que compara se o objeto � igual a outro, retornando true ou false. */
string a = "Maria";
string b = "Alex";
Console.WriteLine(a.Equals(b));

/* GetHashCode : M�todo que retorna um n�mero inteiro representando um c�digo gerado a partir das informa��es do objeto 
   
   Mais r�pida. 

   Regra de ouro do GetHashCode
                � Se o c�digo de dois objetos for diferente, ent�o os dois objetos s�o diferentes.
                � Se o c�digo de dois objetos for igual, muito provavelmente os objetos s�o iguais (pode haver colis�o).
 */
string a = "Maria";
string b = "Alex";
Console.WriteLine(a.GetHashCode());
Console.WriteLine(b.GetHashCode());

/* NOTA: PARA MELHOR DESEMPENHO, VALIDAR PRIMEIRO SE OS OBJETOS SAO IGUAIS PELO GETHASHCODE E SE SIM, VALIDAR PELO EQUALS COMO VALIDA��O
 * ASSIM EST� SE POUPANDO RECURSOS AO UTILIZAR O GETHASH CODE PRIMEIRO E S� DPS QUE ENCONTRAR OS OBJETOS IGUAIS, VAI SE VALIDAR OS OBJETOS PELO EQUALS */
