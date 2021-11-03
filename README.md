# HeronSeTriangulo

* 🖥️ Exercício: Decisão e operações lógicas (12) - HeronSeTriangulo
* 🏫 Instituição: Etec Adolpho Berezin
* ✨ Curso: Técnico em Informática
* 👨‍🏫 Orientador: <a href="https://github.com/ermogenes">Prof.: Ermogenes</a> & <a href="https://github.com/diegoneri">Prof.: Diego Neri</a>
* 📖 Respositório dos exercícios: https://github.com/ermogenes/aulas-programacao-csharp/blob/master/exercises/decisao-simples.md

## Enunciado

Receba três números decimais maiores que zero. Valide se estes números correspondem aos lados de um triângulo (a). Exiba o tipo do triângulo (b). Exiba a sua área (c).

a. Condição de existência de um triângulo:

Para que se possa construir um triângulo é necessário que a medida de qualquer um dos lados seja menor que a soma das medidas dos outros dois e maior que o valor absoluto da diferença entre essas medidas.

Ou seja, todas as condições abaixo devem ser atendidas:

- `a < (b + c)`
- `a > Math.Abs(b - c)`
- `b < (a + c)`
- `b > Math.Abs(a - c)`
- `c < (a + b)`
- `c > Math.Abs(a - b)`

b. Tipo do triângulo:

- Equilátero: três lado com medidas iguais;
- Escaleno: três lados com medidas diferentes;
- Isósceles: demais triângulos.

c. Área do triângulo pelo Teorema de Heron:

![](https://wikimedia.org/api/rest_v1/media/math/render/svg/e66e19b74d5ba900c820c2d99de7f62c0513d916)
![](https://wikimedia.org/api/rest_v1/media/math/render/svg/da3d1cfce6b872d360b302f80de119cb9ef5c210)

Ref.: https://pt.wikipedia.org/wiki/Tri%C3%A2ngulo

<h6 align="center">Made with by <a href="https://github.com/LeoVanelli">Leandro Vanelli</a></h6>
