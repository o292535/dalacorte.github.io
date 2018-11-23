#include <conio.h>
#include <stdio.h>
int main(void)
{
struct ficha_de_aluno
{
char nome[50];
float quimica;
float fisica;
float mat;
};
struct ficha_de_aluno aluno ;
printf("\ncadastro de aluno\n\n\n");
printf("nome do aluno: ");
fflush(stdin);
fgets(aluno.nome, 40, stdin);
printf("nota em matematica: ");
scanf("%f", &aluno.mat);
printf("nota em quimica: ");
scanf("%f", &aluno.quimica);
printf("nota em fisica: ");
scanf("%f", &aluno.fisica);
printf("\n\nnotas\n\n");
printf("nome: %s", aluno.nome);
printf("matematica: %.2f\n ", aluno.mat);
printf("quimica: %.2f \n ", aluno.quimica);
printf("fisica: %.2f \n ", aluno.fisica);
getch();
return 0;
}
