#include <stdio.h>
int main()
{
	float val, soma;
	int contagem;
	soma = 0;
	contagem = 1;
	while(contagem <= 5)
	{
		printf("\n digite o valor do numero para somar: ", contagem);
		scanf("%f", &val);
		soma = soma + val;
		contagem = contagem + 1;
	}
	printf(" \n o resultado da soma eh: %f", soma);
	return 0;
}
