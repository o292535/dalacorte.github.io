#include <stdio.h>

main(){
	char nome[30];
	int i, tamanho = 0;
	
	printf("Digite um nome: ");
	gets(nome);
	
	for (i = 0; i < nome[i]; i++)
		tamanho+=1;
	printf("\nNome: %s - %d letras.", nome,tamanho);
		
	
}
