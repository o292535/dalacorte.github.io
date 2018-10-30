#include <conio.h>
#include <stdio.h>
int main(void)
{
struct ficha
{
char nome[50];
int idade;
float peso;
};
struct ficha ficha ;
printf("\ncadastro \n\n\n");
printf("informe seu nome: ");
fflush(stdin);
fgets(ficha.nome, 40, stdin);
printf("informe sua idade: ");
scanf("%d", &ficha.idade);
printf("informe seu Peso: ");
scanf("%f", &ficha.peso);
printf("\n\nficha\n\n");
printf("nome: %s .", ficha.nome);
printf("idade: %d anos. \n",ficha.idade);
printf("peso: %f kg.\n ", ficha.peso);
getch();
return 0;
}
