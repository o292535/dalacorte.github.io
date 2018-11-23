#include <stdio.h>

int main()
{
	int x,y;
	y=69;
	y=24;
	
	printf("valor 0 indica expressao falsa. \n");
	printf("valor 1 a expressao eh verdadeira. \n");
	printf("%d==%d e %d\n", x,y, x==y); /* verficar se x e igual a y */
	printf("%d!=%d e %d\n", x,y, x!=y); /* verficar se x e diferente de y */
	printf("%d<=%d e %d\n", x,y, x<=y); /* verficar se x e menor ou igual y */
	printf("%d>=%d e %d\n", x,y, x>=y); /* verficar se x e maior ou igual y */
	printf("%d<%d e %d\n", x,y, x<y); /* verficar se x e menor que y */
	printf("%d>%d e %d\n", x,y, x>y); /* verficar se x e maior que y */
}
