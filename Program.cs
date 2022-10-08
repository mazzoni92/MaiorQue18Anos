int[] pessoas = new int[10];
int maior = 0;
int menor = 0;
for(int c = 0;c < pessoas.Length;c++){

    Console.WriteLine($"Digite a idade do {c + 1} pessoa ");
     int idade = Convert.ToInt32(Console.ReadLine());
     if(idade >= 18){
        maior += 1;
     }
     else{
        menor += 1;
     }
}
Console.WriteLine($"Ao todo tem {maior} pessoas acima de 18 anos");
Console.WriteLine($"Ao todo tem {menor} pessoas abaixo dos 18 anos");