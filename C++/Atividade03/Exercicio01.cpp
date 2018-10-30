#include <stdio.h>
#include <conio.h>
int main(void)
{
struct cadastro
{
char nome[50];
int ra;
float nota_prova1;
float nota_prova2;
};
struct cadastro aluno;
printf("\n cadastro de aluno \n\n\n");
printf("nome do aluno: ");
fflush(stdin);
fgets(aluno.nome, 40, stdin);
printf("informe o seu R.A: ");
scanf("%d", &aluno.ra);
printf("digite a nota da primeira prova: ");
scanf("%f", &aluno.nota_prova1);
printf("digite a nota da segunda prova: ");
scanf("%f", &aluno.nota_prova2);
printf("\n\nnotas do aluno\n\n");
printf("nome: %s\n", aluno.nome);
printf("R.A: %d \n",aluno.ra);
printf("nota da primeira prova: %.2f\n ", aluno.nota_prova1);
printf("nota da segunda prova: %.2f\n ", aluno.nota_prova2);
getch();
return 0;
}
