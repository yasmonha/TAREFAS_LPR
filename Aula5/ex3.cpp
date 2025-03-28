#include <iostream>
#include <iomanip>
using namespace std;

int main() {
    int soma = 0;

    for (int i = 50; i <= 500; i++) {
        if (i % 2 != 0 && i % 3 == 0) {
            soma += i;
        }
    }
    cout << "A soma de todos os números ímpares múltiplos de 3 de 50 a 500 é: " << soma << endl;

    return 0;
}