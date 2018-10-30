#include <stdio.h>
#include <string.h>

main(){
	char nome[30], resposta[1000];
	int i;
	
	printf("Digite um nome: ");
	gets(nome);
	
	for (i = 0; i < nome[i]; i++){
		strcat(resposta, nome);
		strcat(resposta, " ");
		printf("\n%d - %s", i+1, resposta);
	}
		
	
}
