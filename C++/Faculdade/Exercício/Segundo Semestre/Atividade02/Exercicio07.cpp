#include <stdio.h>
#include <string.h>

main(){
	char sigla[2];
	
	printf("Digite a sigla do Estado: ");
	gets(sigla);
	
	
	if(stricmp(sigla, "rj") == 0){
		printf("Carioca");
	}else if(stricmp(sigla, "sp") == 0){
		printf("Paulista");		
	}else if(stricmp(sigla, "mg") == 0){
		printf("Mineiro");
	}else{
		printf("Outros Estados");		
	}		
	
}
