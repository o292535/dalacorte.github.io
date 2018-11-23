#include <stdio.h>

main(){
	
	int c1,c2, m[4][4];
	
	for(c1=0;c1<4;c1++){
		for(c2=0;c2<4;c2++){
			printf("\nInforme o valor [%d][%d] da matriz: ",c1+1,c2+1);
			scanf("%d",&m[c1][c2]);
		}
	}
	
	printf("\n");
	
	for(c1=0;c1<4;c1++){
		for(c2=0;c2<4;c2++){
			printf("[%d][%d]: %d \n",c1+1,c2+1,m[c1][c2]);
		}
	}
	
	for(c1=0;c1<4;c1++){
		printf("\n");
		for(c2=0;c2<4;c2++){
			printf("[%d][%d] * 5: %d \n",c1+1,c2+1,m[c1][c2]*5);
		}
	}
	
	return 0;
}
