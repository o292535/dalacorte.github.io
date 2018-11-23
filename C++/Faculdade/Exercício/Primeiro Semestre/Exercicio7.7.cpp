#include <stdio.h>
int main()
{
	int n1, n2, maior;
	printf("Digite o numero 1: ");
	scanf("%d", &n1);
	printf("Digite o numero 2: ");
	scanf("%d", &n2);
	if(n1 > n2){
	maior = n1;
	}else{
	maior = n2;
	}
	printf("O maior numero eh: %d", maior);
}
