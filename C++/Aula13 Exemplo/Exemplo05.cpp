#include <stdio.h>

int main(void)
{
	int numero1=1;
	int numero2=2;
	
	char letra1='a';
	char letra2='b';
	
	printf("numero1: \n");
	printf("valor: %d \n", numero1);
	printf("Endereco na memoria: %d \n\n", &numero1);
	
	printf("numero2: \n");
	printf("valor: %d \n", numero2);
	printf("Endereco na memoria: %d \n\n", &numero2);
	
	printf("letra1: \n");
	printf("valor: %c \n", letra1);
	printf("Endereco na memoria: %c \n\n", &letra1);
	
	printf("letra2: \n");
	printf("valor: %c \n", letra2);
	printf("Endereco na memoria: %c \n\n", &letra2);
	
	printf("Alterando os valores.. \n\n\ ");
	
	numero1 = 2112;
	numero2 = 666;
	letra1='B';
	letra2='A';
	
	printf("numero1: \n");
	printf("valor: %d \n", numero1);
	printf("Endereco na memoria: %d \n\n", &numero1);
	
	printf("numero2: \n");
	printf("valor: %d \n", numero2);
	printf("Endereco na memoria: %d \n\n", &numero2);
	
	printf("letra1: \n");
	printf("valor: %c \n", letra1);
	printf("Endereco na memoria: %c \n\n", &letra1);
	
	printf("letra2: \n");
	printf("valor: %c \n", letra2);
	printf("Endereco na memoria: %c \n\n", &letra2);
	
	return 0;
}
