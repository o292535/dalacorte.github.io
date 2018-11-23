#include <stdio.h>
#include <stdlib.h>
#include <string.h>

main(){
	
	char nome[3][20];
	int c;
	
	for(c=0;c<3;c++){
		printf("Informe o %d* nome: ",c+1);
		gets(nome[c]);	
	}
		
	printf("\n");
	
	for(c=0;c<3;c++){
		printf("Nome: %s \n",nome[c]);
		printf("Esse nome tem %d letras. \n",strlen(nome[c]));
	}
	
	return 0;
}
