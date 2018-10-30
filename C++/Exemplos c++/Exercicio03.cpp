#include <stdio.h>

int main ()
{
	int n, i, aluno, pontos;
	char gabarito[10], resp[10];
	
	printf("Digite o numero dos alunos: ");
	scanf("%d", &n);
	printf("Digite o gabarito da prova: ");
	for (i=0;i<10;i++){
		scanf("%c", &gabarito[i]);
	}
	for (aluno=1;aluno<=n;aluno++){
		pontos=0;
		printf("Digite as respostas do aluno %d: ", aluno);
		for(i=0;i<10;i++){
			scanf("%c", &resp[i]);
			if(resp[i]==gabarito[i]){
				pontos = pontos + 1;
			}
		}
		printf("O aluno %d fez %d pontos \n", aluno, pontos);
	}
	return 0;
}
