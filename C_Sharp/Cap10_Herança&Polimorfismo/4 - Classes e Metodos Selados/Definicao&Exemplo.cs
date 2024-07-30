/*

Classes e métodos selados
    • Palavra chave: sealed
    • Classe: evita que a classe seja herdada
    • Nota: ainda é possível extender a funcionalidade de uma classe selada usando "extension methods"

            namespace Course
            {
                sealed class SavingsAccount
                {

    • Método: evita que um método sobreposto possa ser sobreposto novamente
    • Só pode ser aplicado a métodos sobrepostos

Suponha que você queira evitar que sejam criadas subclasses de SavingsAccount, então faz-se:

        namespace Course {
        sealed class SavingsAccount {


Pra quê?
• Segurança: dependendo das regras do negócio, às vezes é desejável garantir que uma classe não seja herdada, ou que um método não seja sobreposto.
• Geralmente convém selar métodos sobrepostos, pois sobreposições múltiplas podem ser uma porta de entrada para inconsistências
• Performance: atributos de tipo de uma classe selada são analisados de forma mais rápida em tempo de execução.
• Exemplo clássico: string
*/