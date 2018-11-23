#include <stdio.h>
int main()
{
	int n;
	int soma = 0;
	do
	{
		printf("Digiet um numero positivo para ser somado ou negativo para sair: ");
		scanf("%d", &n);
		if (n >= 0);
		soma = soma + n;
	}
	while (n >= 0);
	printf("A soma eh %d\n", soma);
	return 0;
}
