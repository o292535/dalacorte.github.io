#include <stdio.h>
#include <locale.h>

int main(){
	setlocale(LC_ALL, "Portuguese");
	
	char numero[20];
	int i;
	
	printf("Informe um número: ");
	gets(numero);
	
	printf("\nNúmeros pares inclusos no número %s:\n",numero);
	for(i = 0; i < numero[i]; i++){
		if (numero[i]%2 == 0){
			printf("\n%c",numero[i]);
		}
	}
	
}
