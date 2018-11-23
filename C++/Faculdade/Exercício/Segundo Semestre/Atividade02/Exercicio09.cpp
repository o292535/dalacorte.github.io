#include <stdio.h>

main(){
	char nome[30];
	int i;
	
	printf("Digite um nome: ");
	gets(nome);
	
	for (i = 0; i < 10; i++)
	printf("\n%d - %s", i+1, nome);
		
	
}
