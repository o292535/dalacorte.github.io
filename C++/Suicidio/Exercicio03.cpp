#include <stdio.h>

main(){
	
	int c, x[4], y[4], z[4];
	
	for(c=0;c<4;c++){
		printf("Informe o %d* valor do vetor x: ",c+1);
		scanf("%d",&x[c]);
	}
	
	printf("\n");
	
	for(c=0;c<4;c++){
		printf("Informe o %d* valor do vetor y: ",c+1);
		scanf("%d",&y[c]);	
	}
	
	printf("\n");
	
	for(c=0;c<4;c++){
		z[c] = x[c] + y[c];
		printf("Vetor X[%d]: %d \n",c+1,x[c]);
		printf("Vetor Y[%d]: %d \n",c+1,y[c]);
		printf("Vetor Z[%d]: %d \n",c+1,z[c]);
		printf("\n");
	}
	
	return 0;
}
