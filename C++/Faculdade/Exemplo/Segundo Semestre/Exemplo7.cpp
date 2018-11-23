#include <stdio.h>

int main()
{
	int soma,x,y;
	printf("Digite o primeioro numero: ", x);
	scanf("%d", &x);
	printf("Digite o segundo numero: ", y);
	scanf("%d", &y);
	soma = (x/5) + (y/2);
	printf ("A soma de 1/5 de x + 1/2 de y sera = %d \n", soma);
	return 0;
}
