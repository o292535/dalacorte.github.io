#include <stdio.h>
#include <stdlib.h>
#include <string.h>
#include <math.h>
int main()
{
char nome[2][30];
int i, r;
for(i=0;i<2;i++){
printf("insira o %d* nome ",i+1);
gets(nome[i]);	
}
r = strcmp(nome[0], nome[1]);
if(r!=0)
printf("nao sao iguais \n");
else
printf("sao iguais \n");
for(i=0;i<2;i++){
r = strcmp(nome[i], "cardapio");
if(r== 0)
printf("a %d* palavra eh igual a cardapio\n",i+1);
}
return 0;
}
