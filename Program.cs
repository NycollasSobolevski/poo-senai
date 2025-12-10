// 1. Escreva uma função C# que converta um número decimal para binário (retornando uma string).
int teste_decimal = 78;
string resultado_conversao = Converter(teste_decimal);
Console.WriteLine($"Decimal = {teste_decimal}; Binario = {resultado_conversao}");



// 2. Faça um programa que dado dois números dados pelo usuário a e b, desenhe na tela, em binário, o resultado de a << b;





// Converte somente até 8 bits (1byte)(255 em decimal)
string Converter (int numero)
{
    string result = "";
    int[] valores_binarios = [128, 64, 32, 16, 8, 4, 2, 1];

    int aux = 0;

    for( int i = 0; i < valores_binarios.Length; i++ )
    {
        if(valores_binarios[i] <= numero 
            && (aux + valores_binarios[i]) <= numero
        )
        {
            aux += valores_binarios[i];
            result += "1";
        }
        else {
            result += "0";
        }
    }
    return result;
}

