#include <stdio.h>
#include <stdlib.h>

int main()
{
	int n, i, v[5];
	float media;
	for (i=0;i<5;i++){
		printf("Digite o %d numero: ", i+1);
		scanf("%d", &v[i]);
		media += v[i];
	}
	media = media/5;
	printf("media %f", media);
	for(i=0;i<5;i++){
		if(v[i]>media){
			printf("%d \n", v[i]);
		}
	}
	system("pause");
	return 0;
}
