// See https://aka.ms/new-console-template for more information
Console.WriteLine("Padaria do Seu Zé");

Console.WriteLine("Digite o nome do cliente");
var nomeDoCliente = Console.ReadLine();

Console.WriteLine("Digite o nome do produto");
var nomeDoProduto = Console.ReadLine();

Console.WriteLine("Digite a quatidade do produto");
var quatidadeDoproduto = Console.ReadLine();


Console.WriteLine($"Cliente: {nomeDoCliente}");
Console.WriteLine($"Pedido: {quatidadeDoproduto} {nomeDoProduto}");


/*  Sistema de padaria:

Digitar o nome do cliente
Digitar o nome do produto
Digitar a quantidade do produto



Resultado esperado:

Cliente: Gustavo
Pedido: 10 Pães francês  */
