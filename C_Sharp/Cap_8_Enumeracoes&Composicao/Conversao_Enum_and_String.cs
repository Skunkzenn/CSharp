/* 

AVISO IMPORTANTE SOBRE CONVERS�O DE STRING

No pr�ximo v�deo vamos aprender sobre ENUMERA��ES.

Na aula fazemos a convers�o de string para enumera��o assim:

OrderStatus os = Enum.Parse<OrderStatus>("Delivered");
Mas, dependendo da vers�o do compilador C#, isso pode dar problema. Se for o caso, por favor tente deste jeito:

OrderStatus os = (OrderStatus)Enum.Parse(typeof(OrderStatus), "Delivered");
Se mesmo assim ainda tiver dando erro, h� ainda uma terceira forma:

OrderStatus os;
Enum.TryParse("Delivered", out os);
Atenciosamente.

*/

