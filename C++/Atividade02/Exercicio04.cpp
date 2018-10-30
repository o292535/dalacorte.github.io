#include <string.h>
#include <stdio.h>

int main()
{
	char nome[30];
	printf("Digite seu nome: ");
	gets(nome);
	for (int i=0;i<nome[i];i++){
		printf("Nome: %s \n", nome);
	}
}
