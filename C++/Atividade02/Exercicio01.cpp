#include <string.h>
#include <stdio.h>

int main()
{
	char nome[30];
	int i = 0, tamanho = 0;
	printf("Digite um nome ");
	gets(nome);
	for (i=0;i<nome[i];i++){
		tamanho+=1;
	}
	printf("Nome: %s - Letras: %d", nome, tamanho);
}
