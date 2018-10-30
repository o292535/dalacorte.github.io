#include <stdio.h>

int main(){
	
	for (int i = 0; i < 10; i++){
		for (int j = 1; j < 11; j++){
			printf("%d \t X \t %d \t = \t %d \n",i,j,(i*j));
		}
		printf("\n");
	}

	
}
