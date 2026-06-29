# ADR-01: Biblioteca virtual

| Campo  | Valor |
|--------|-------|
| Autor  | Scarlet Ruelas |
| Fecha  | 15/05/2026 |
| Estado | `Propuesto` |

---

## Contexto

¿Qué estás construyendo, qué problema resuelve y para quién es? Describe también las condiciones o restricciones que influyeron en esta decisión — por ejemplo, el tiempo disponible, el equipo, las tecnologías que ya conoces o las que viste en clase.

Se quiere construir una aplicación de consola tipo sistema de biblioteca, cuyo objetivo es gestionar libros de forma sencilla para empresas pequeñas que se les dificulte ordenar sus archivo y consultarlos.

El sistema permite registrar libros, listarlos, buscarlos, prestarlos y devolverlos.

El problema que resuelve es evitar manejar la información de libros de forma manual o desorganizada, simulando un sistema básico de gestión.

Las principales restricciones son:

Uso de consola (sin interfaz gráfica)
Tiempo limitado: Al ser un proyecto de fin de ciclo, el tiempo de desarrollo es durante el cuatrimestre
Uso de C# y programación orientada a objetos
se planea que el programa pueda recibir actualicaciones mientras vamos trabajando en clases, para mejorar la funcionalidad de la biblioteca.
Aplicación enfocada en aprendizaje de arquitectura y buenas prácticas


---

## Decisión

Opté por esta estructura porque divide el sistema en tres frentes independientes con un único rol cada uno: Datos (el Repositorio guarda), Negocio (el Servicio procesa las reglas de préstamo y búsqueda) y Presentación (la UI muestra).

Al evitar que un componente interfiera en las tareas del otro:

Código limpio: El mantenimiento es más rápido porque los errores se aíslan fácilmente.

Flexibilidad: El sistema puede crecer o cambiar de tecnologías sin alterar todo el código.

Diseño robusto: Se respetan buenas prácticas de software como los principios SOLID (SRP y DIP).




### ¿Por qué?

Argumenta tu decisión. No basta con decir "es lo que vimos en clase" — explica qué característica concreta de lo que elegiste resuelve tu problema.

Se eligió esta arquitectura porque permite separar claramente cada responsabilidad del sistema:

El repositorio se encarga únicamente de almacenar datos
El servicio contiene la lógica del negocio (prestar, devolver, buscar)
La UI solo interactúa con el usuario sin lógica interna

Esto facilita:

Mantenimiento del código
Escalabilidad del sistema
Aplicación de principios SOLID (especialmente SRP y DIP)


### Alternativas consideradas

| Alternativa                         | Por qué la descarté                                  |
| ----------------------------------- | ---------------------------------------------------- |
| Todo en una sola clase (clase dios) | Difícil de mantener y rompe SOLID                    |
| Uso de base de datos (SQL)          | Complejidad innecesaria para el alcance del proyecto |
| Aplicación web (ASP.NET)            | No era requisito del ejercicio y aumenta complejidad |


---

## Consecuencias

** Lo que gano:**

Lo que gano:

Técnico: El sistema se vuelve más fácil de mantener y extender, ya que cada parte (UI, lógica y datos) está separada en clases distintas. Esto permite modificar una funcionalidad sin afectar el resto del sistema.
Proceso / trabajo: El desarrollo es más ordenado, porque cada responsabilidad está claramente definida. Esto facilita trabajar por partes y depurar errores más rápido, sin mezclar la lógica del juego con la interfaz.

** Lo que sacrifico o asumo:**

Lo que sacrifico o asumo:

Limitación técnica: El proyecto tiene más archivos y estructura inicial, lo que puede parecer más complejo al principio comparado con una sola clase.
Riesgo / deuda técnica: Si no se respeta la separación de responsabilidades, el sistema puede terminar desordenado o con lógica mal ubicada entre capas, lo que dificultaría su mantenimiento en el futuro.

Un boceto de cómo se estructura tu sistema (draw.io, Mermaid o a mano escaneado)

## Clausula de IA
Este proyecto Yo Scarlet Angelina Ruelas Cardeña he utilizado herramientas de inteligencia artificial como apoyo durante su desarrollo, principalmente para:

Comprender conceptos de programación y arquitectura de software
Mejorar la redacción de documentación (README y ADR)
Recibir guía en la organización del proyecto y buenas prácticas (SOLID y separación por capas)
Resolver dudas puntuales durante el desarrollo

La inteligencia artificial se la utilicé únicamente como herramienta de apoyo académico.

**EN CONSTRUCCIÓN**
