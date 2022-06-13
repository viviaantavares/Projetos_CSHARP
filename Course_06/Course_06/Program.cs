﻿// Em um banco, para se cadastrar um conta bancária, é necessário informar o número da conta,
// o nome do titular da conta, e o valor de depósito inicial que o titular depositou ao abrir a conta.
// Este valor de depósito inicial, entretanto, é opcional, ou seja: se o titular não tiver dinheiro
// a depositar no momento de abrir sua conta, o depósito inicial não será feito e o saldo inicial
// da conta será, naturalmente, zero. 

// Importante: uma vez que uma conta bancária foi aberta, o número da conta nunca poderá ser alterado.
// Já o nome do titular pode ser alterado (pois uma pessoa pode mudar de nome por ocasião de 
// casamento, por exemplo).

// Por fim, o saldo da conta não pode ser alterado livremente. É preciso haver um mecanismo para
// proteger isso. O saldo só aumenta por meio de depósitos, e só diminui por meio de saques.
// Para cada saque realizado, o banco cobra uma taxa, de $5.00. Nota: a conta pode ficar com saldo
// negativo se o saldo não for suficiente para realizar o saque e/ou pagar a taxa. 

// Você deve fazer um programa que realize o cadastro de uma conta, dando opção para que seja ou
// não informado o valor de depósito inicial. Em seguida, realizar um depósito e depois um saque,
// sempre mostrando os dados da conta após cada operação. 

// Exemplo 1 

// Entre o número  da conta: 8532
// Entre o titular da conta: Alex Green
// Haverá depósito inicial (s/n)? s
// Entre o valor de depósito inicial: 500.00

// Dados da conta: 
// Conta 8532, Titular: Alex Green, Saldo: $ 500.00

// Entre um valor para depósito: 200.00 
// Dados da conta atualizados:
// Conta 8532, Titular: Alex Green, Saldo: $ 700.00

// Entre um valor para saque: 300.00
// Dados da conta atualizados:
// Conta 8532, Titular: Alex Green, Saldo: $ 395.00

using System;
using System.Globalization;

namespace Course_06
{
    class Program
    {
        private static double quantia;

        static void Main(string[] args)
        {
            ContaBancaria conta;

            Console.Write("Digite o número da conta: ");
            int numero = int.Parse(Console.ReadLine());
            Console.Write("Entre o titular da conta: ");
            string titular = Console.ReadLine();
            Console.Write("Haverá depósito inicial (s/n)?");
            char resp = char.Parse(Console.ReadLine());
            if ( resp == 's' || resp == 'S'){
                Console.Write("Entre o valor do depósito inicial: ");
                double depositoInicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                conta = new ContaBancaria(numero, titular, depositoInicial);
            }
            else
            {
                conta = new ContaBancaria(numero, titular);
            }

            Console.WriteLine();
            Console.Write("Dados da conta: ");
            Console.WriteLine(conta);

            Console.WriteLine();
            Console.Write("Entre um valor para depósito: ");
            double quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Deposito(quantia);
            Console.WriteLine("Dados atualizados: ");
            Console.WriteLine(conta);

            Console.WriteLine();
            Console.Write("Entre um valor para saque: ");
            quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Saque(quantia);
            Console.WriteLine("Dados atualizados: ");
            Console.WriteLine(conta);

            Console.ReadLine();

        }
    }
}