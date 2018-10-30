#include <stdio.h>
#define SOMA(a,b) (a+b)

int main(int argc, char* argv[])
{
	int a,b;
	int resultado = 0;
	
	printf("Digite o valor A: ");
	scanf("%d", &a);
	printf("Digite o valor B: ");
	scanf("%d", &b);
	printf("A soma de %d + %d e de %d", a,b, SOMA(a,b));
	
	return 0;
}
