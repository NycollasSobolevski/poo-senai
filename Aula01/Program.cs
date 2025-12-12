// // 1. Escreva uma função C# que converta um número decimal para binário (retornando uma string).
// int teste_decimal = 78;
// string resultado_conversao = Converter(teste_decimal);
// Console.WriteLine($"Decimal = {teste_decimal}; Binario = {resultado_conversao}");



// // 2. Faça um programa que dado dois números dados pelo usuário a e b, desenhe na tela, em binário, o resultado de a << b;

// Console.Write("Insira o valor de A: ");
// int a = Int32.Parse(Console.ReadLine());
// Console.Write("Insira o valor de B: ");
// int b = Int32.Parse(Console.ReadLine());
// System.Console.WriteLine(a);
// System.Console.WriteLine(b);
// int result = a << b;
// Console.WriteLine($"A: {a} -> Resultado: {result}");
// Console.WriteLine($"A: {Converter(a)} -> Resultado: {Converter(result)}");

// // Converte somente até 8 bits (1byte)(255 em decimal)
// string Converter (int numero)
// {
//     string result = "";
//     int[] valores_binarios = [128, 64, 32, 16, 8, 4, 2, 1];

//     int aux = 0;

//     for( int i = 0; i < valores_binarios.Length; i++ )
//     {
//         if(valores_binarios[i] <= numero 
//             && (aux + valores_binarios[i]) <= numero
//         )
//         {
//             aux += valores_binarios[i];
//             result += "1";
//         }
//         else {
//             result += "0";
//         }
//     }
//     return result;
// }

// // -----------------------------------------------------------------------------------


// Pessoa p1 = new Pessoa();
// p1.Nome = "Jubileu da Silva";
// p1.Endereco = "Dr Faivre, 180";
// p1.CPF = "123.123.123-32";


// System.Console.WriteLine($"P1: {p1.Nome} - {p1.CPF} - {p1.Endereco}");

// System.Console.WriteLine($"P2: {p2.Nome} - {p2.CPF} - {p2.Endereco}");

// p2.AtualizarEndereco("Novo endereco da ana");
// System.Console.WriteLine($"P2: {p2.Nome} - {p2.CPF} - {p2.Endereco}");



//Tendo uma linha de produção, faça um script onde
//  calculará quantos produtos será produzidos por dia
//  depois de 20 (Sete dias), onde a cada 2 dias uma 
//  máquina aleatória sofre uma manutenção, onde há uma
//  perda de desempenho de 2 peças/dia na manutenção.
// A Classe Maquina tem que ter os seguintes atributos e 
// métodos:

// - string Produto ("Parafuso")
// - int ProducaoPorDia (350)
// - string Alimentacao (Diesel)
// - void Manutencao()
