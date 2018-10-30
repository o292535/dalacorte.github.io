#include <stdio.h>

main()
{
	int v[4], i, maior=0;
	for(i=0;i<4;i++)
	{
	printf("Elemento[%d]= ",i);
	scanf("%d", &v[i]);
	}
	for(i=0;i<4;i++)
	if(v[i]>maior)
	maior = v[i];
	printf("Maior = %d \n", maior);
}
