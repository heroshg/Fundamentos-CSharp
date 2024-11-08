#region Tipos e Variáveis
//var nome = Console.ReadLine();

//Console.WriteLine(nome);

//double valorDouble = 3.14;
//float valorFloat = 3.14F;
//decimal valorDecimal = 3.14M;
//int valorInteiro = 100;
//bool valorBooleano = true;
//char valorChar = 'A';
//string valorString = "Heros";

//const double PI = 3.1416;

//Console.WriteLine($"Double: {valorDouble}, Float: {valorFloat}, Decimal: {valorDecimal},");
//Console.WriteLine($"Int: {valorInteiro}, Booleano: {valorBooleano}, Char: {valorChar}, String: {valorString}");
//Console.WriteLine($"Constante: {PI}");
#endregion

#region Operadores Aritméticos
//int a = 1;
//int b = 2;
//int soma = a + b;
//int subtracao = a - b;
//int multiplicacao = a * b;
//int divisao = b / a;
//int modulo = a % b;

//Console.WriteLine($"Soma: {soma}, Subtração: {subtracao}, Multiplicação: {multiplicacao}, Divisão: {divisao}, Modulo: {modulo}");
#endregion

#region Operadores Lógicos
//bool x = true;
//bool y = false;

//var and = x && y; //AND
//var or = x || y; //OR
//var notX = !x; //NOT
//var notY = !y;//NOT

//Console.WriteLine("x = true, y = false");
//Console.WriteLine($"AND: {and}, OR: {or}, NOT X: {notX}, NOT Y: {notY}");
#endregion

#region Operadores de Comparação
//var p = 5;
//var q = 10;

//bool maior = p > q;
//bool maiorOuIgual = p >= q;
//bool menor = p < q;
//bool menorOuIgual = p <= q;
//bool igual = p == q;
//bool diferente = p != q;

//Console.WriteLine($"Maior: {maior}, Maior Ou Igual: {maiorOuIgual}"); 
//    Console.WriteLine($", Menor: {menor}, Menor Ou Igual: {menorOuIgual}" +
//        $" Igual: {igual}, Diferente: {diferente}");
#endregion

#region Operadores de Igualdade e Atribuição
//int k = 5;
//k = 10;

//Console.WriteLine(k);
//k += 5; // k = k + 5 = 10 + 5 = 15
//Console.WriteLine(k);
//k -= 3; // k = k -3 = 15 - 3 = 12
//Console.WriteLine(k);
//k *= 2; // k = k * 2 = 12 * 2 = 24
//Console.WriteLine(k);
//k /= 4; // k = k / 4 = 24 / 4 = 6
//Console.WriteLine(k);
//k %= 5; // k = k % 5 = 6 % 5 = 1
//Console.WriteLine(k);
#endregion

#region Estruturas de Condição - if-else
//var nota = 25;

//if(nota >= 70)
//{
//    Console.WriteLine("Aprovado!");
//} else if(nota >= 30)
//{
//    Console.WriteLine("Em Recuperação!");
//} else
//{
//    Console.WriteLine("Reprovado");
//}
#endregion

#region Estruturas de Condição - switch-case
//var opcao = 2;

//switch(opcao)
//{
//    case 1:
//        Console.WriteLine("Opção UM");
//        break;
//    case 2:
//        Console.WriteLine("Opção DOIS");
//        break;
//    case 3:
//        Console.WriteLine("Opção TRÊS");
//        break;
//    default:
//        Console.WriteLine("Opção DESCONHECIDA");
//        break;
//}

//switch (nota) 
//{
//    case int n when n >= 70:
//        Console.WriteLine("Aprovado!");
//        break;
//    case int n when n <= 30:
//        Console.WriteLine("Reprovado");
//        break;
//}

//string textoNumero = opcao switch
//{
//    1 => "UM",
//    2 => "DOIS",
//    3 => "TRÊS",
//    _ => "DESCONHECIDO"
//};
//Console.WriteLine(textoNumero);
#endregion

#region Matrizes
//int[] matriz = { 1, 4, 3, 2, 6 };
//int[] matrizVazia = new int[5];

//var tamanhoMatriz = matriz.Length;
//var dimensaoMatriz = matriz.Rank;

//Console.WriteLine($"Tamanho: {tamanhoMatriz}, Dimensão: {dimensaoMatriz}");

//Array.Sort(matriz);
//Array.Reverse(matriz);
#endregion

#region Estruturas de Repetição
int[] matriz = { 1, 4, 3, 2, 6 };

Console.WriteLine("while");
int contador = 0;
while(contador < matriz.Length)
{
    Console.WriteLine(matriz[contador]); // matriz[0], matriz[1], matriz[2]
    contador = contador + 1;
    //contador++;
}

Console.WriteLine("do-while");
contador = 0;
do
{
    Console.WriteLine(matriz[contador]); 
    contador++;
} while (contador < matriz.Length);

Console.WriteLine("for");

for(int i = 0; i < matriz.Length; i++)
{
    Console.WriteLine(matriz[i]);
}

Console.WriteLine("foreach");
foreach (int numero in matriz)
{
    Console.WriteLine(numero);
}
#endregion