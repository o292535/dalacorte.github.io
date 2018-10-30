#include <stdio.h>

int main (void)
{
	char c,c2;
	int i,i2;
	float f,f2;
	double d,d2;
	
	printf("caractere: %d e %d \n", &c, &c2);
	printf("inteiro: %d e %d \n", &i, &i2);
	printf("float: %d e %d \n", &f, &f2);
	printf("double: %d e %d \n", &d, &d2);
}
