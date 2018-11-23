#include <stdio.h>
#include <stdlib.h>
#include <string.h>

main(){
	
	char nome[1][30];
	
	printf("Informe o nome: ");
	gets(nome[0]);

	printf("\n");
	printf("Nome: %s \n",nome[0]);
	printf("Esse nome tem %d letras.",strlen(nome[0]));
	
	return 0;
}
