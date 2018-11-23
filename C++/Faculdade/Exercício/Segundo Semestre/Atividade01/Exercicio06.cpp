#include <stdio.h>
#include <stdlib.h>

int main()
{
	int i,j,m[4][4];
	for(i=0;i<4;i++)
	for(j=0;j<4;j++){
		printf("elemento [%d][%d]=", i,j);
		scanf("%d", &m[i][j]);
	}
	printf("\n valores originais\n");
	for(i=0;i<4;i++){
	for(j=0;j<4;j++)
		printf("%d", m[i][j]);
		printf("\n");
	}
	for(i=0;i<4;i++)
	for(j=0;j<4;j++)
		m[i][j] = m[i][j]*5;
		
	printf("\n valores dividido por 5\n");
	for(i=0;i<4;i++){
	for(j=0;j<4;j++)
		printf("%d", m[i][j]);
		printf("\n");
	}
	return 0;
}
