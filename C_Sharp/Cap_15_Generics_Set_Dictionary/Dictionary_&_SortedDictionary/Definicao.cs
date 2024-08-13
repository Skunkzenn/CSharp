/*
Dictionary, em outras linguagens conhecido como MAP(conjunto de pares, chave-valor);
    Dictionary<TKey, TValue>
    � � uma cole��o (gen�rica) de pares chave / valor 
        � N�o admite repeti��es do objeto chave
        � Os elementos s�o indexados pelo objeto chave, ou seja, para aceder ao elemento, passa-se a chave do elemento (n�o possuem posi��o) 
        � Acesso, inser��o e remo��o de elementos s�o r�pidos
        � Uso comum: cookies, local storage, qualquer modelo chave-valor

Diferen�as:

  � Dictionary
    � Armazenamento em tabela hash
    � Extremamente r�pido: inser��o, remo��o e busca O(1) � A ordem dos elementos n�o � garantida

  � SortedDictionary
    � Armazenamento em �rvore
    � R�pido: inser��o, remo��o e busca O(log(n)) 
    � Os elementos s�o armazenados ordenadamente conforme implementa��o IComparer<T>

Alguns m�todos importantes:

    � dictionary[key] - acessa o elemento pela chave informada
    � Add(key, value) - adiciona elemento (exce��o em caso de repeti��o) 
    � Clear() - esvazia a cole��o
    � Count - quantidade de elementos
    � ContainsKey(key) - verifica se a dada chave existe
    � ContainsValue(value) - verifica se o dado valor existe
    � Remove(key) - remove um elemento pela chave
    
 */