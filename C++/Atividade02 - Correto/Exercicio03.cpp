#include <stdio.h>
#include <string.h>

main(){
	char nome[10], sobrenome[10];
	int idade;
	
	printf("Informe o nome: ");
	gets(nome);
	printf("Informe o sobrenome: ");
	gets(sobrenome);
	printf("Informe a idade: ");
	scanf("%d",&idade);
	strcat(nome, " ");
	
	printf("\nNome completo: %s\nIdade: %d anos", strcat(nome, sobrenome), idade);
			
}
