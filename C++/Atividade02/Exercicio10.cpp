#include <stdio.h>

main()
{
	char nome[30];
	int i;	
	printf("Digite um nome: ");
	gets(nome);
	for (i = 0; i < nome[i]; i++){
		if (i % 2 != 0){
			printf("\n%c ", nome[i]);
		}
	}	
}

