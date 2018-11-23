#include <stdio.h>

int main()
{
	int celsius, fahrenheit;
	printf ("Digite a temperatura em Celsius: ");
	scanf ("%d", &celsius);
	fahrenheit = (9*celsius/5) + 32;
	printf ("A temperatura em Farenheit sera: %d \n", fahrenheit);
	return 0;
}
