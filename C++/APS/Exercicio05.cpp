#include <stdio.h>
#include <locale.h>

int main(){
	setlocale(LC_ALL, "Portuguese");
	int i = 1;
	printf("Números ímpares entre 1 e 30:\n\n");
	
	while(i <= 30){
		if(i%2 != 0){
			printf("%d\n",i);
		}
		i++;
	}

	
}
