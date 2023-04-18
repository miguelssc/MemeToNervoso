string frase, resoluçao;
Console.WriteLine("digite o que voce acha sobre mim?");
frase = Console.ReadLine()!;
resoluçao = $"{frase.Remove(10)}... NÃO, PERA \n to nervoso ";
Console.WriteLine(resoluçao);