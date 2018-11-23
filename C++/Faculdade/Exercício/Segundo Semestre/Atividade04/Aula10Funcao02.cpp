#include <stdio.h>

linha()
{
	int i;
	for (i=1;i<=20;i++)
		putchar('*');
		putchar('\n');
}

main()
{
	int i;
	linha();
	puts("numeros entre 1 e 5");
	linha();
	for(i=1;i<=5;i++)
	printf("%d\n", i);
	linha();
}
