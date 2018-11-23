#include <stdio.h>
#include <stdlib.h>
#include <string.h>
int main()
{
	char p1[30],p2[30];
	printf("informe palavra 1:");
	gets(p1);
	printf("informe palavra 2:");
	gets(p2);
	if(strcmp(p1,p2)==0)
	printf("\n Sao palavras iguais.");
	if(strcmp(p1,p2)!=0)
	printf("\n Sao palavras diferentes.");
	return 0;
}
