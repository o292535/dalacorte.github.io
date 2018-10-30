#include <stdio.h>
#include <stdlib.h>
#include <math.h>

main()
{
	int x, y=0, vet[5], vet1[5];
	for(x=0;x<=4;x++)
	{	
	vet[x]=y+2;
	y=y+2;
	}
	for(x=0;x<=4;x++)
	printf("\t %d", vet[x]);
	for(x=0;x<=4;x++)
	{
	vet1[x]=x+5;
	}
	for(x=0;x<=4;x++)
	printf("\t %d", vet1[x]);
	for(x=0;x<=4;x++)
	printf("\t %d", vet[x]+vet1[x]);
	printf("\n\n");
	printf("pause");
	return(0);
}
