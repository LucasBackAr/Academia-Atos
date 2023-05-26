namespace Atividade_7_contaBancaria_classeAbstrata
{
    internal class Program
    {
        static void Main(string[] args)
        {
           

            /*
            7 - Classe Abstrata "ContaBancaria"
            Crie uma classe abstrata chamada "ContaBancaria" 
            com três propriedades abstratas: "Titular", "Saldo" 
            e "TaxaDeJuros". Em seguida, crie duas classes que herdam 
            de "ContaBancaria": "ContaCorrente" e "ContaPoupanca". 
            Implemente as propriedades "Titular", "Saldo" e "TaxaDeJuros" 
            para cada uma dessas classes. Por fim, crie um objeto "ContaCorrente" 
            e um objeto "ContaPoupanca", e imprima as suas propriedades na tela.
            */
            
            ContaCorrente contacorrente = new ContaCorrente("Lucas Back", .10, 1500);
            ContaPoupanca contaPoupanca = new ContaPoupanca("Lucas Back", .10, 1800);
            ContaCorrente contaCorrente2 = new ContaCorrente("João", 0.01, 1000);
            ContaPoupanca contaPoupanca2 = new ContaPoupanca("Maria", 0.02, 2000);

            Console.WriteLine($"Conta Corrente: Titular: {contaCorrente2.Titular}, Saldo: {contaCorrente2.Saldo}, Taxa de Juros: {contaCorrente2.TxadeJuros}");
            Console.WriteLine($"Conta Poupança: Titular: {contaPoupanca2.Titular}, Saldo: {contaPoupanca2.Saldo}, Taxa de Juros: {contaPoupanca2.TxadeJuros}");

            Console.WriteLine(contacorrente.Titular+ " " + contacorrente.TxadeJuros + " " + contacorrente.Saldo);
            Console.WriteLine(contaPoupanca.Titular + " " + contaPoupanca.TxadeJuros + " " + contaPoupanca.Saldo);

        }
    }
}