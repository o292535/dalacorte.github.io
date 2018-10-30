#include<stdio.h>
#include<conio.h>
int main(void)
{
int i;
float notas[6] = {1, 2, 3, 4, 5, 6};
for( i = 0 ; i <= 5; i++)
{
printf("notas[%d] = %.1f\n",i, notas[i]);
}
return 0;
}
