#include <stdio.h>
#include <locale.h>

int main(){
	setlocale(LC_ALL, "Portuguese");
	int i = 1;
	printf("Múltiplos de 5 entre 1 e 50:\n\n");
	
	while(i <= 50){
		if(i%5 == 0){
			printf("%d\n",i);
		}
		i++;
	}

	
}
