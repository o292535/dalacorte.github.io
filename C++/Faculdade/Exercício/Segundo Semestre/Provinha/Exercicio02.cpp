#include <stdio.h>

main()
{
	int numero1,numero2,numero3;
	printf("Digite o primeiro valor: ");
	scanf("%d", &numero1);
	printf("Digite o segundo valor: ");
	scanf("%d", &numero2);
	printf("Digite o terceiro valor: ");
	scanf("%d", &numero3);
	if(numero1 > numero2){
		printf("Maior valor: %d", numero1);
	}
	if(numero1 > numero3 && numero1 > numero2){
		printf("Maior valor: %d", numero1);
	}
	if(numero2 > numero1 && numero2 > numero2){
		printf("Maior valor: %d", numero2);
	}
	if(numero3 > numero2 && numero3 > numero3){
		printf("Maior valor: %d", numero2);
	}
}
