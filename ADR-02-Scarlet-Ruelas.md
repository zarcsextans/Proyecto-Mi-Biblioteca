# ADR-02: Vistas arquitectónicas de Mi Biblioteca

| Campo  | Valor |
|--------|-------|
| Autor  | Scarlet Ruelas |
| Fecha  | 05/06/2026 |
| Estado | `Propuesto` |

---
## Contexto

Se está construyendo una aplicación de consola para un Sistema de Biblioteca Virtual destinada a la gestión interna de libros, préstamos y usuarios en pequeñas empresas. El sistema debe operar con un catálogo limitado pero consistente, permitiendo registrar la salida y devolución de libros de forma organizada.

Las restricciones e influencias principales son:

Entorno académico: Es un proyecto que debe demostrar el dominio práctico de los principios SOLID y el uso correcto de patrones arquitectónicos.

Tiempo y equipo: El proyecto lo hago de manera individual con tiempos estimados para cada avance del proyecto.

Tecnologías requeridas: Uso del ecosistema .NET (C#), ASP.NET, postgreSQL.

---
## Decisión

Se decidió utilizar una arquitectura por capas compuesta por:

Web Application (ASP.NET Core MVC)
API Application (ASP.NET Core Web API)
Capa de Servicios
Repository
Base de Datos PostgreSQL

Además, se documentará el sistema mediante cuatro vistas arquitectónicas:

Vista lógica
Vista física
Vista de procesos
Vista de despliegue

---
### ¿Por qué?

Cada vista resuelve un problema específico del desarrollo:

Vista Lógica: Organiza las responsabilidades del software evitando acoplamientos dañinos.

Vista de Procesos: Modela la concurrencia y el flujo de hilos en tareas delicadas como préstamos.

Vista Física: Estructura la distribución real de proyectos y archivos dentro de la solución de Visual Studio.

Vista de Despliegue: Define cómo interactúan el ejecutable de la consola, el ORM y el servidor de base de datos en el entorno de producción.

---

### Alternativas consideradas

| Alternativa | Por qué la descarté |
|-------------|---------------------|
| Documentar únicamente la arquitectura en el ADR-01 sin crear un ADR nuevo | Se descartó porque el ADR-01 solo define la arquitectura base, pero no detalla las vistas arquitectónicas requeridas por la actividad. |
| Usar un solo diagrama combinado en lugar de separar las 4 vistas | Se descartó porque mezclar todas las vistas en un solo diagrama reduce la claridad y contradice el enfoque de separación de preocupaciones. |
| No incluir vista de procesos y enfocarse solo en estructura del sistema | Se descartó porque la vista de procesos es clave para entender el comportamiento en tiempo de ejecución del sistema. |

---

## Consecuencias

** Lo que gano:**

- Consecuencia técnica: La separación en cuatro vistas arquitectónicas facilita la comprensión, mantenimiento y escalabilidad del sistema, ya que cada parte (lógica, procesos, despliegue y física) se puede analizar y modificar de forma independiente sin afectar directamente las demás.
- Consecuencia sobre el proceso/equipo: El desarrollo se vuelve más ordenado y estructurado, ya que el equipo (o el desarrollador) cuenta con una guía clara de cómo está organizado el sistema, reduciendo confusiones y mejorando la toma de decisiones durante la implementación.

** Lo que sacrifico o asumo:**

- **Limitación técnica: No se obtiene una visión totalmente detallada del sistema a nivel de implementación fina (por ejemplo, clases o código específico), ya que las vistas arquitectónicas trabajan a un nivel más alto de abstracción.
- **Deuda o riesgo: Si el sistema crece significativamente, los diagramas pueden requerir mantenimiento constante para mantenerse actualizados, lo que puede generar inconsistencias entre la documentación y la implementación real si no se gestionan adecuadamente.

---

## Diagramas

### Vista lógica
<img width="3315" height="3688" alt="Loan Domain Management-2026-06-06-050815" src="https://github.com/user-attachments/assets/cda29900-f8f9-413b-8076-3eb9b932546a" />

### Vista Física
<img width="5545" height="5264" alt="Loan Domain Management-2026-06-06-052057" src="https://github.com/user-attachments/assets/ded183be-c2e2-4c5f-9af3-fb6d1a0b0397" />

### Vista de despliegue
<img width="3095" height="3625" alt="Loan Domain Management-2026-06-06-040259" src="https://github.com/user-attachments/assets/6e09ee0c-fdce-49ba-93ef-c75736a4d54c" />

### Vista de procesos

<img width="8192" height="3633" alt="Loan Domain Management-2026-06-06-040216" src="https://github.com/user-attachments/assets/e889604f-4e45-4454-bb0a-c1980a505468" />

## Clausula de IA
#### Parte de la documentación, diagramas y redacción de las vistas arquitectónicas de este proyecto fue hecha con ayuda de la IA
