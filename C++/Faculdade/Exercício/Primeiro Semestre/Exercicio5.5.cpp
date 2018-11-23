#include <stdio.h>
int main()
{
	int num;
	printf("Digite um numero: ");
	scanf ("%d", &num);
	if(num>10)
	printf("\n\nO numero e maior que 10");
	if (num==10)
	{
		printf("\n\nVoce acertou!\n");
		printf("O numero e igual a 10.");
	}
	if (num<10)
	printf ("\n\n O numero e menor que 10.");
	return (0);
}
