#include <string.h>
#include <stdio.h>

int main()
{
	char estado[30];
	printf("Digite a sigla do Estado: ");
	gets(estado);
	if(stricmp(estado, "rj") == 0){
		printf("Carioca");
	}else if(stricmp(estado, "sp") == 0){
		printf("Paulista");		
	}else if(stricmp(estado, "mg") == 0){
		printf("Mineiro");
	}else{
		printf("Outros Estados");		
	}	
}
