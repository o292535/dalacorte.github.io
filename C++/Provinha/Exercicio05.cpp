#include <stdio.h>

valores()
{
	float n1,n2,n3,n4;
	printf("Digite o primeiro valor: ");
	scanf("%f", &n1);
	printf("Digite o segundo valor: ");
	scanf("%f", &n2);
	printf("Digite o terceiro valor: ");
	scanf("%f", &n3);
	n3 = (n1*n1)+n2+n3;
	printf("Valor: %f", n3);
}

main()
{
	valores();
}
