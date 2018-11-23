#include <stdio.h>
#include <conio.h>
 int main ()
 {
     int vetor[5],cont,cont2=0;
     float soma=0,soma2=0;

     for(cont=0;cont<5;cont++)
     {
       printf("Digite os valores do vetor: ");
       scanf("%d",&vetor[cont]);
     }
     for(cont=0;cont<5;cont++)
     {
       soma2+=vetor[cont];
       if (vetor[cont]>20)
       {
          soma+=vetor[cont];
       }
    }
    printf("\nSoma Vetores maior que 20 = %.0f\n  Soma de todos os vetores = %.0f",soma,soma2);
    return 0;
 }
