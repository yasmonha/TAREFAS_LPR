/*Exercício 2) C++
Leia 2 valores inteiros (A e B). Após, o
programa deve mostrar uma mensagem
"Sao Multiplos" ou "Nao sao Multiplos",
indicando se os valores lidos são múltiplos
entre si. Atenção: os números podem ser
digitados em ordem crescente ou
decrescente. */

#include <iostream>

using namespace std;

int main() {
    int A, B;
    cout << "Digite dois valores inteiros: ";
    cin >> A >> B;

    if (A % B == 0 || B % A == 0) {
        cout << "Os numeros sao Multiplos" << endl;
    } else {
        cout << "Os numeros nao sao Multiplos" << endl;
    }

    return 0;
}