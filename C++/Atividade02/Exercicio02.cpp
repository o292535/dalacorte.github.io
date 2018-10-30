#include <string.h>
#include <stdio.h>

int main()
{
	char nome[30], sexo[30], escolaridade[30], curso[30];
	printf("Digite seu nome: ");
	gets(nome);
	printf("Digite seu sexo: ");
	gets(sexo);
	printf("Digite sua escolaridade: ");
	gets(escolaridade);
	printf("Digite seu curso: ");
	gets(curso);
	printf("Nome: %s \n",nome);
	printf("Sexo: %s \n",sexo);
	printf("Escolaridade: %s \n",escolaridade);
	printf("Curso: %s \n",curso);
}
