#include <stdio.h>

main(){
	char nome[70], sexo[10], escolaridade[20], curso[20];
	
	printf("Informe o nome: ");
	gets(nome);
	printf("Informe o sexo: ");
	gets(sexo);
	printf("Informe o grau de escolaridade: ");
	gets(escolaridade);
	printf("Informe o curso feito: ");
	gets(curso);
	
	printf("\n");
	
	puts(nome);
	puts(sexo);
	puts(escolaridade);
	puts(curso);
			
}
