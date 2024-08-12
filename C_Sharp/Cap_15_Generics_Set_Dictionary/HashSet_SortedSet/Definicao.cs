/*
 * HashSet<T> e SortedSet<T>
    � Representa um conjunto de elementos (similar ao da �lgebra)
    � N�o admite repeti��es
    � Elementos n�o possuem posi��o
    � Acesso, inser��o e remo��o de elementos s�o r�pidos
    � Oferece opera��es eficientes de conjunto: interse��o, uni�o, diferen�a.
 */

/* 
Diferen�as
� HashSet
    � Armazenamento em tabela hash
    � Extremamente r�pido: inser��o, remo��o e busca O(1)
    � A ordem dos elementos n�o � garantida
� SortedSet
    � Armazenamento em �rvore
    � R�pido: inser��o, remo��o e busca O(log(n))
    � Os elementos s�o armazenados ordenadamente conforme implementa��o IComparer<T> */