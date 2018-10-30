#include<stdio.h>
#include<stdlib.h>
#include <string.h>
int main ()
{
char str1[30];
char str2[30];
printf("Digite a primeira palavra: ");
gets(str1);
printf ("Digite a segunda palavra : ");
gets(str2);
strrev(str2);
int resp = strcmp(str1, str2);
if(resp==0)
printf("nao soa iguais");
else
printf("sao iguais");
return 0;

}
