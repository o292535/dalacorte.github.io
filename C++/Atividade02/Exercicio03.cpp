#include <string.h>
#include <stdio.h>

int main()
{
	char nome[30], sobrenome[30], idade[30];
	printf("Digite seu nome: ");
	gets(nome);
	printf("Digite seu sobrenome: ");
	gets(sobrenome);
	printf("Digite sua idade: ");
	gets(idade);
	printf("Nome: %s %s\n",nome,sobrenome);
	printf("idade: %s \n",idade);
}
