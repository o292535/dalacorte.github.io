#include <stdio.h>

main(){
	
	int c, v[6];
	
	for(c=0;c<6;c++){
		printf("Informe o %d* valor do vetor: ",c+1);
		scanf("%d",&v[c]);
	}
	
	printf("\n");
	
	for(c=0;c<6;c++){
		printf("%d: %d \n",c+1,v[c]);
	}
	
	return 0;
}
