int a = 10;
int b = 5;

//Operadores Relacionais 
bool maiorQUE = a > b;
bool menorQUE = a < b;
bool igual = a == b;
bool diferente = a != b;
bool maiorOuIgual = a >= b;
bool menorOuigual = a <= b;

//Exibindo resultados dos operadores relacionais
Console.WriteLine("\nOperadores Relacionais:");
Console.WriteLine($"{a} > {b}: {maiorQUE}");
Console.WriteLine($"{a} < {b}: {menorQUE}");
Console.WriteLine($"{a} == {b}: {igual}");
Console.WriteLine($"{a} != {b}: {diferente}");
Console.WriteLine($"{a} >= {b}: {maiorOuIgual}");
Console.WriteLine($"{a} <= {b}: {menorOuigual}");

