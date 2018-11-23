#include <stdio.h>

main(){
	
	int quant = 0, soma = 0, somatotal = 0, c, v[5];
	
	for(c=0;c<5;c++){
		printf("Informe o %d* valor do vetor: ",c+1);
		scanf("%d",&v[c]);
		if(v[c] > 20){
			quant += 1;
			soma += v[c];
		}
		somatotal += v[c];
	}
	
	printf("\n");
	
	for(c=0;c<5;c++){
		printf("[%d]: %d \n",c+1,v[c]);
	}
	
	printf("\n");
	printf("Quantidade de numeros maiores que 20: %d \n",quant);
	printf("Soma dos numeros maiores que 20: %d \n",soma);
	printf("Soma total dos valores: %d \n",somatotal);
	
	return 0;
}
