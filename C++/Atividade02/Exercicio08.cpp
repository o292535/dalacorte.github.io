#include <stdio.h>
#include <locale.h>

main(){
	char nome1[30], nome2[30];
	int i=0, tamanho=0;	
	printf("Digite o primeiro nome: ");
	gets(nome1);	
	printf("Digite o segundo nome: ", i+1);
	gets(nome2);	
	for (i = 0; i < nome1[i]; i++)
		tamanho+=1;
		printf("\nPrimeiro nome: %s \n%d letras.", nome1,tamanho);		
	tamanho = 0;	
	for (i = 0; i < nome2[i]; i++)
		tamanho+=1;
		printf("\nSegundo nome: %s \n%d letras.", nome2,tamanho);	
}

