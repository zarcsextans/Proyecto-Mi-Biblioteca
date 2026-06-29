# ADR-05: Aplicación de patrones GoF en la arquitectura del sistema Biblioteca Digital

| Campo  | Valor |
| ------ | ----- |
| Autor  | Scarlet Angelina Ruelas |
| Fecha  | 12/06/2026 |
| Estado | Aceptado |

---

## Contexto

El sistema de Biblioteca Digital ya cuenta con una arquitectura basada en **ASP.NET Core Web API**, separando capas de:

- Controladores
- Servicios
- Repositorios
- Base de datos

Sin embargo, conforme el sistema crece (libros, usuarios, préstamos, reservas y pagos), se vuelve necesario:

- Reducir el acoplamiento entre capas
- Evitar duplicación de lógica
- Facilitar mantenimiento y escalabilidad
- Estandarizar la creación de objetos y el flujo de negocio

Por esto se decide aplicar patrones de diseño **GoF (Gang of Four)** dentro de la arquitectura.

---

## Decisión

Se decide implementar patrones GoF dentro del sistema Biblioteca Digital para mejorar la estructura y mantenibilidad del código.

Se aplican los siguientes patrones:

- **Repository** para separar el acceso a datos de la lógica de negocio.
- **Factory Method** para crear objetos como usuarios y pagos de forma controlada.
- **Strategy** para cambiar comportamientos como métodos de pago o cálculo de multas.
- **Singleton** para servicios globales como logger o configuración.
- **Dependency Injection** para reducir el acoplamiento entre capas.

Esto permite una arquitectura más modular, escalable y fácil de mantener dentro de la API REST.

## ¿Por qué?

Se eligieron estos patrones porque:

- Son compatibles con arquitectura en capas (API REST)
- Mejoran la mantenibilidad del sistema
- Reducen dependencias entre módulos
- Facilitan pruebas unitarias
- Son estándares en desarrollo profesional con .NET

---

## Alternativas consideradas

| Alternativa | Por qué se descartó |
|-------------|---------------------|
| Código sin patrones | Genera duplicación y difícil mantenimiento |
| Solo MVC sin separación | Mezcla lógica de negocio con presentación |
| Microservicios | Excesivo para el alcance académico del proyecto |

---

## Consecuencias

### Lo que gano:

- Código más limpio y modular
- Mayor reutilización de componentes
- Fácil extensión (nuevos tipos de pagos, usuarios, etc.)
- Mejor testabilidad del sistema

---

### Lo que sacrifico o asumo:

- Mayor complejidad inicial en el diseño
- Curva de aprendizaje más alta
- Más archivos y clases en el proyecto

---

## Diagrama (relación de patrones en la arquitectura)

```mermaid
flowchart TD

U[Cliente] --> C[Controladores API]

C --> S[Servicios]

S --> R[Repository Pattern]
R --> DB[(Base de datos)]

S --> F[Factory Method]
S --> ST[Strategy Pattern]

C --> DI[Dependency Injection Container]

LG[Logger Singleton] --> S
