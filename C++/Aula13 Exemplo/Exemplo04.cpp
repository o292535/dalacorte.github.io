//Busou Shoujo Machiavellianism? AMV ?- Bad Girlfriend

#include <stdio.h>

int main (void)
{
	int i;
	int *i_ptr = &i;
	
	double d;
	double *d_ptr = &d;
	
	printf("Endereco da variavel 'inteiro': %d \n", &i);
	printf("Endereco armazenado no ponteiro 'inteiro_ptr': %d \n", i_ptr);
	
	printf("Endereco da variavel 'double': %d \n", &d);
	printf("Endereco armazenado no ponteiro 'double_ptr': %d \n", d_ptr);
	
	printf("Apos o uso dos ponteiros, vamos aponta-los para NULL \n\n");
	i_ptr = NULL;
	d_ptr = NULL;
	printf("Endereco armazenado no ponteiro 'double_ptr': %d \n", d_ptr);
	printf("Endereco armazenado no ponteiro 'double_ptr': %d \n", d_ptr);
	return 0;
}
