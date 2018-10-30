//#include <stdio.h>
//#include <locale.h>

#include <iostream>  
#include <stdio.h>  
 using namespace std;  
 int main(){  
 int numero[10];  
 int maior=1000000;  
 for (int i= 0; i<10; i++){  
   printf("Digite 10 numeros, digite o valor %d: ",i+1);  
   scanf("%d",&numero[i]);  
   if (numero[i]>maior){  
     maior = numero[i];  
   }  
 }  
 cout << "O numero maior e " << maior;  
 return 0;  
 }  
 
//int main(){
//	setlocale(LC_ALL, "Portuguese");
//	int i=0,j=0,aux=0,vetor [10];
//	
//	for(i=0; i<10;i++){
//		printf("Digite 10 valores para o vetor:\n");
//		scanf("%i", &vetor[i]);		
//	}
//	
//	for(i = 0; i<10; i++){
//       for( j = 0; j<10; j++){
//            if(vetor[j] > vetor[j + 1]){
//                aux = vetor[j];
//              vetor[j] = vetor[j+1];
//                vetor[j+1] = aux;
//               printf("%i", vetor[i]);
//            }
//        }
//    }
//    printf("%i", vetor[i]);
//
//}
