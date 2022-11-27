# Algorithm 01 - Union-find

pt-br

Union-find é uma estrutura abstrada de dados que visa reconhecer e manipular a relação de entidades em um determinado conjunto. Objetivo é ser possivel projetar uma estrutura de dados eficientes quando o problema inclui: um número grande de objetos N; número grande de operações M; e encontrar comandos de consulta e união podem ser mixadas,
Um algoritmo de localização de união é um algoritmo que executa duas operações úteis em tal estrutura de dados:   
* **Encontrar**: Determine qual subconjunto um determinado elemento está. Isso pode ser usado para determinar se dois elementos estão no mesmo subconjunto. **Union(A,B)**
* **União**: Junte dois subconjuntos em um único subconjunto. Aqui primeiro temos que verificar se os dois subconjuntos pertencem ao mesmo conjunto. Se não, então não podemos realizar a união. **find(A)**  

## QuickFind
É uma abordagem em como pode ser feita a busca através do conjunto. Uma abordagem simples é a utilização de vetores. Imagine um vetor no qual os indices sejam os valores e os valores presente nesse indice seja os números correspondentes. Por exemplo: vetor com 6 itens

```c++
int vetor = [1, 2, 3, 4, 5, 6]
```

Assim podemos simplesmente realizar a seguinte ideia. Como o indice um poderia estar interligado com o índice 6?

Somente precisariamos verificar se os dois valores presente no indices são iguais. Vamos supor que os um e o seis formam um conjunto, como que seria?

```c++
int vetor = [1, 2, 3, 4, 5, 1]

// find 
if vetor[0] == vetor[5]
    exibirConjunto(vetor);
else
    exibirMensagem("Não são conectados")
```
