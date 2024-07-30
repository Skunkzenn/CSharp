/* 
Crie uma hierarquia de classes em C# para representar diferentes tipos de veículos. Comece com
uma classe base chamada "Veiculo" e crie pelo menos duas classes derivadas, como "Carro" e
"Mota". Adicione propriedades e métodos específicos para cada classe derivada. Em seguida,
crie instâncias das classes e demonstre a funcionalidade da herança.
*/

using Ex2_Herança;

Carro carro1 = new Carro("Toyota", "Yaris", 5);
Moto moto1 = new Moto("Kawasaki", "Ninja", 1500);

Veiculo.listVeiculos.Add(moto1);
Veiculo.listVeiculos.Add(carro1);

foreach (Veiculo obj in Veiculo.listVeiculos)
{
    Console.WriteLine(obj);
}


