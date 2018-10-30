#include <stdio.h>
#include <locale.h>
#include <string.h>

int main(){
	setlocale(LC_ALL, "Portuguese");
	
	char palavra[50];
	printf("Informe o uma palavra: ");
	gets(palavra);
	printf("\n");
	
	for(int i = 0; i < 4; i++){
		puts(palavra);	
	}
	
}
