#include <string.h>
#include <stdio.h>

int main()
{
	char nome[30];
	int i=0;
	printf("Digite um nome ");
	gets(nome);
	for(i=strlen(nome) -1; i>=0; i--){
		printf("%c", nome[i]);
	}
}

