#include <stdio.h>
int main()
{
	int n;
	do
	{
		printf("Digite um numero ou zero para sair: ");
		scanf("%d", &n);
		if (n%2 == 1)
		printf("%d e impar \n", n);
		else
		printf("5d e par \n", n);
	}
	while (n !=0);
	return 0;
}
