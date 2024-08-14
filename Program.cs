// int x = 10;
// double pi = 3.1415;
// char letra = 'A';
// bool isTrue = true;
// string texto = "Uma linda mensagem";

// double outroValor;
// //conversao implicita
// outroValor = x;
// //conversao explicita
// int valorInteito = (int) pi;

// //conversao explicita com a classe Convert 
// int y = Convert.ToInt32(texto);

//concatenação de string
// Console.WriteLine("O usuário digitou: " + numero);
// //interpolação de string
// Console.WriteLine($"O dobro que o usuário digitou ; {numero * 2}");

//Console.WriteLine($"O resultado da soma de {numero} e {numero2} é igual a {somaResult}");
//Usando PlaceHolders
//Console.WriteLine("O resultado da soma de {0} e {1} é igual a {2}", numero, numero2, somaResult); 

double numero1;
double numero2;
Console.WriteLine("Digite um número: ");
numero1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Digite o segundo número: ");
numero2 = Convert.ToDouble(Console.ReadLine());

//resultado = (double) numero1 / numero2;
double soma = numero1 + numero2;
double subtracao = numero1 - numero2;
double multiplicacao = numero1 * numero2;
double divisao = numero1 / numero2;

Console.WriteLine("Resultado dos números somados: " + soma);

Console.WriteLine($"Resultado dos números subtraídos:" + subtracao);

Console.WriteLine("Resultado dos números multiplicados: " + multiplicacao);

Console.WriteLine("Resultado dos números Divididos: " + divisao);



