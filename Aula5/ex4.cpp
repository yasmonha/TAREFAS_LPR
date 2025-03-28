#include <iostream>
using namespace std;

int main() {
    int numero;
    cout << "Insira um número: ";
    cin >> numero;

    int quadrado = numero * numero;
    int soma = 0;

    while (quadrado > 0) {
        soma += quadrado % 10;
        quadrado /= 10;
    }

    cout << "A soma dos dígitos do quadrado do número é: " << soma << endl;

    return 0;
}