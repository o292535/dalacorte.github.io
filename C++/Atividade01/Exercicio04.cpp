#include <stdio.h>
#include <stdlib.h>
#include <math.h>
#include <string.h>

main()
{
	char nome[1][30];
	int x=0;
	for (x=0; x<1;x++){
		printf("\n [%d] digite o seu nome: %d", x,(x+1));
		gets(nome[x]);
	}
	for (x=0; x<1;x++){
		printf("\n %s", nome[x],x);
		printf("\t o nome %s tem %d letras", nome[x], strlen(nome[x]));
	}
	printf("\n\n");
	system("pause");
	return(0);
}
