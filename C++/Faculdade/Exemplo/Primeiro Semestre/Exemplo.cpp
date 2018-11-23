#include <stdio.h>
int main()
{
	float vendas, comissao;
	printf("Digite o valor total das vendas: ");
	scanf("%f", &vendas);
	comissao= vendas*(0.10);
	printf("o valor da comissao sera: %f \n", comissao);
}
