#include<stdio.h>
#include<conio.h>
int main(void)
{
int i;
float notas[4] = {1, 4, 7, 11};
for( i = 0 ; i < 4; i++)
{
printf("notas[%d] = %.1f\n",i, notas[i]+2);
}
return 0;
}

