#include <iostream>
#include <vector>
using namespace std;

int main() {
    vector<int> numeros(10);
    int pesquisa;    
    int ocorrencias = 0;
    
    cout << "Insira 10 numeros inteiros: " << endl;
    for (int i = 0; i < numeros.size(); i++) {
        cin >> numeros[i];
    }

    cout << "Digite o numero que gostaria de pesquisar no vetor: ";
    cin >> pesquisa;

    cout << "O numero " << pesquisa << " aparece nas posicoes: ";
    for (int i = 0; i < numeros.size(); i++) {
        if (numeros[i] == pesquisa) {
            cout << i << " ";
            ocorrencias++;
        }
    }
    cout << endl;

    if (ocorrencias > 0) {
        cout << "Total de ocorrencias: " << ocorrencias << endl;
    } else {
        cout << "O numero nao foi encontrado no vetor." << endl;
    }

    return 0;
}