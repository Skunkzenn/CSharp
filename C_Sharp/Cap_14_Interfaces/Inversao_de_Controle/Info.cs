/* 
 * Inversão de controle
        Padrão de desenvolvimento que consiste em retirar da classe a
        responsabilidade de instanciar suas dependências.

• Injeção de dependência
        É uma forma de realizar a inversão de controle: um componente externo
        instancia a dependência, que é então injetada no objeto "pai". Pode ser
        implementada de várias formas:
• Construtor
• Objeto de instanciação (builder / factory)
• Container / framework

Quando temos um serviço diretamente ligado a um contrato direto, passamos a ter
um acoplamento forte, pois teremos uma dependência concreta sob a classe.
Se a classe completa mudar, é preciso mudar a a classe que está a utilizar suas definições.

*/

class RentalService
{
    (...)
private BrazilTaxService _brazilTaxService = new BrazilTaxService();

    /* 
    • Acoplamento fraco
    • A classe RentalService não conhece a dependência concreta
    • Se a classe concreta mudar, a classe RentalService não muda nada
    */

    class RentalService
    {
        (...)
private ITaxService _taxService;

        /* 
       Injeção de dependência por meio de construtor, com o exemplo do usa da classe RentalService
       */

        class Program
        {
            static void Main(string[] args)
            {
                (...)
            RentalService rentalService = new RentalService(hour, day, new BrazilTaxService());


        class RentalService
            {
                private ITaxService _taxService;
                public RentalService(double pricePerHour, double pricePerDay, ITaxService taxService)
                {
                    PricePerHour = pricePerHour;
                    PricePerDay = pricePerDay;
                    _taxService = taxService;
                }