#include <stdio.h>
main() {
	int a;
	printf("Digite um numero inteiro: ");
	scanf("%d", &a);
	if (a % 2 == 0) {
		printf("O valor eh par.\n");
	} else {
		printf("O valor eh impar. \n");
	}
	return 0;
}
