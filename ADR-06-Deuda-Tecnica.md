# ADR-05: Deudas técnicas del proyecto Biblioteca

## Deuda técnica #1: Persistencia de datos con almacenamiento local

### Qué es
Actualmente el sistema de biblioteca almacena la información de libros, usuarios y préstamos utilizando archivos locales o estructuras temporales en memoria, en lugar de utilizar una base de datos.

### Por qué existe
Esta decisión se tomó para avanzar rápidamente con la implementación inicial del sistema y validar las funcionalidades principales antes de integrar una solución de persistencia más robusta.


### Costo de no pagarla
Si la cantidad de libros, usuarios y préstamos aumenta, el sistema puede presentar problemas de rendimiento, dificultad para realizar búsquedas y riesgo de pérdida de información. Además, sería complicado permitir varios usuarios trabajando al mismo tiempo.

### Propuesta de solución
Migrar la persistencia a una base de datos utilizando Entity Framework Core, implementar el patrón Repository para separar el acceso a datos y mejorar la escalabilidad del sistema.


---
