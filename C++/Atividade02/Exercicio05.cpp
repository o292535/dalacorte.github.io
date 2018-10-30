#include <string.h>
#include <stdio.h>

int main()
{
	char nome[30], multi[10000];
	printf("Digite seu nome: ");
	gets(nome);
	
	for (int i = 0; i < nome[i]; i++){
		strcat(multi, nome);
		strcat(multi, " ");
		printf("\n%d - %s", i+1, multi);
	}
}
