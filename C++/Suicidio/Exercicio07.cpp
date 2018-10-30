#include <stdio.h>
#include <stdlib.h>
#include <string.h>
#include <math.h>

main(){
	
	char nome[2][30];
	int c, resp;
	
	for(c=0;c<2;c++){
		printf("Informe o %d* nome: ",c+1);
		gets(nome[c]);	
	}
		
	printf("\n");
	
	resp = strcmp(nome[0], nome[1]);
	if(resp!=0)
		printf("Nao sao iguais");
	else
		printf("Sao iguais");
		
	printf("\n");
	
	for(c=0;c<2;c++){
	
	resp = strcmp(nome[c], "cardapio");
	if(resp == 0)
		printf("A %d* palavra eh igual a cardapio",c+1);
	}
	
	return 0;
}
