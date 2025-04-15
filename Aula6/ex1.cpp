#include <iostream>
using namespace std;

int reverso(int numero) {
    int reverso = 0;
    while (numero != 0) {
        int numeross = numero % 10; 
        reverso = reverso * 10 + numeross; 
        numero /= 10; 
    }
    return reverso;
}

int main() {
    int numero;
    cout << "Digite um número inteiro: ";
    cin >> numero;

    int resultado = reverso(numero);
    cout << "O reverso do número é: " << resultado << endl;

    return 0;
}
