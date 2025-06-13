#include <iostream>
#include <vector>
using namespace std;

int main() {
    vector<int> numeros(10);
    vector<int> numPar(10);   
    vector<int> numImpar(10); 
    int countPar = 0;         
    int countImpar = 0;      

    cout << "Insira 10 numeros inteiros: " << endl;

    for (int i = 0; i < numeros.size(); i++) {
        cin >> numeros[i];
        if (numeros[i] % 2 == 0) {
            numPar[countPar] = numeros[i];
            countPar++;
        } else {
            numImpar[countImpar] = numeros[i];
            countImpar++;
        }
    }

    cout << "Os numeros pares sao: ";
    for (int i = 0; i < countPar; i++) {
        cout << numPar[i] << " ";
    }
    cout << endl;


    cout << "Os numeros impares sao: ";
    for (int i = 0; i < countImpar; i++) {
        cout << numImpar[i] << " ";
    }
    cout << endl;

    return 0;
}

