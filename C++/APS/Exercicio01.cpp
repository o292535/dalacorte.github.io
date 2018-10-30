#include <stdio.h>
#include <locale.h>

int main(){
	setlocale(LC_ALL, "Portuguese");
	
	float valores[15];
	float maior = 0;
	float menor = 0;
	
	for(int i = 0; i < 15; i++){
		printf("Informe o %dº valor: ",(i+1));
		scanf("%f",&valores[i]);
		if (i == 0){
			maior = valores[i];
			menor = valores[i];
		} else if (valores[i] > maior){
			maior = valores[i];
		} else if (valores[i] < menor){
			menor = valores[i];
		}
	}
	
	printf("\nO maior valor é: %f",maior);
	printf("\nO menor valor é: %f",menor);
	
}
