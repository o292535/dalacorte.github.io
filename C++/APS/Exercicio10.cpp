#include <stdio.h> 
#include <stdlib.h> 

void Soma_prod_media(float n1, float n2, float n3){ 
	printf("\nSoma: %.2f",n1+n2+n3); 
	printf("\nProduto: %.2f",n1*n2*n3); 
	printf("\nMedia: %.2f",(n1+n2+n3)/3);	
} 

int main(){
 
	float n1, n2, n3; 
	int quantidade, i; 

	printf("\nQuantide de conjuntos\n\t"); 
	scanf("%d",&quantidade); 

	for(i=1; i<=quantidade; i++) { 
	printf("\n\nConjunto %d",i); 
	printf("\nDigite o primeiro valor: "); 
	scanf("%f",&n1); 
	printf("\nDigite o segundo valor: "); 
	scanf("%f",&n2); 
	printf("\nDigite o terceiro valor: "); 
	scanf("%f",&n3); 
	Soma_prod_media(n1,n2,n3); 
	} 

return 1;	
}
