#include <stdio.h>

int main(void)
{
int i,n;

printf("Informe um numero inteiro");
scanf ("%i",&n);

	for (i=0;i<=n;i++){
    	if(i%3==0){
    	printf("\n %i - numero multiplo de 3", i);
   		}
	}
	
return 0;
}

