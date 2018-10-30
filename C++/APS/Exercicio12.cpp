#include <stdio.h>
#include <locale.h>

int main () { 
   int pa[10], i, r; 
   printf("Informe o termo inicial e a razao da P.A.: "); 
   scanf("%d %d", &pa[0], &r); 
   for (i=1; i<10; i++) 
      pa[i] = pa[i-1] + r; 
   printf("Progressão aritmética com razao %d\n", r); 
   for (i=0; i<10; i++) 
      printf ("\tP.A.[%d] = %d", i, pa[i]); 
   return 0; 
}
