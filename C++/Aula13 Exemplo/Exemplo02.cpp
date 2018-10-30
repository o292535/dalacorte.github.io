#include <stdio.h>

int main (void)
{
	char c;
	int i;
	float f;
	double d;
	
	printf("caractere: %d bytes \t em %d \n", sizeof(c), &c);
	printf("inteiro: %d bytes \t em %d \n", sizeof(i), &i);
	printf("float: %d bytes \t em %d \n", sizeof(f), &f);
	printf("double: %d bytes \t em %d \n", sizeof(d), &d);
}
