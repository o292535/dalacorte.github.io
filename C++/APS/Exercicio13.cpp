#include <iostream>
#include <cmath>
using namespace std;
int main(){
	int vet[20];
	int x, achei=0, posicao;

	cin >> x;
	
	for (int i=0;i<20;i++){
		if (vet[i] == x){
			achei = 1;
			posicao = i;
		}
	}
	
	if (achei == 0){
		printf("Numero nao encontrado");
		cout << "Numero nao encontrado" << endl;
	}
	else{
		cout << "Numero encontrado na posicao " << posicao << endl;
	}
}
