#include <conio.h>
#include <stdio.h>
int main(void)
{
struct ficha
{
char nome[50];
char RG[50];
char nascionalidade[20];
};
struct ficha ficha ;
printf("\ncadastro \n\n\n");
printf("informe seu nome: ");
fflush(stdin);
fgets(ficha.nome, 40, stdin);
printf("informe sua nascionalidade: ");
fflush(stdin);
fgets(ficha.nascionalidade, 40, stdin);
printf("informe seu r.g.: ");
fflush(stdin);
fgets(ficha.RG, 40, stdin);
printf("\n\nficha de Cadastro:\n\n");
printf("nome: %s", ficha.nome);
printf("nascionalidade: %s",ficha.nascionalidade);
printf("r.g.: %s\n ", ficha.RG);
getch();
return 0;
}

