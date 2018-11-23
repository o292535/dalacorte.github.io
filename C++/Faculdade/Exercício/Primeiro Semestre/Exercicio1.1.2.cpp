#include <stdio.h>
int main()
{
	int num, s;
	printf("Digite um valor inteiro:");
	scanf("%d", &num);
	s = 0;
	while(num > 0)
	{
		s = s + num;
		num--;
	}
	printf("A soma dos n numeros eh: %d\n", s);
}
