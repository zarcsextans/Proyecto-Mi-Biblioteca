# Mi Biblioteca - Documentación de Deudas Técnicas

## Descripción

Este documento presenta la identificación y documentación de **deudas técnicas** encontradas en el proyecto Mi Biblioteca. El objetivo es reconocer decisiones de desarrollo que permitieron avanzar rápidamente, pero que requieren mejoras para mantener la calidad, escalabilidad y facilidad de mantenimiento del sistema.

---

## Deuda técnica identificada

### 1. Persistencia de datos

Actualmente el sistema requiere mejorar la forma en que administra el almacenamiento de información, debido a que una solución inicial puede generar limitaciones conforme aumenten los datos y usuarios del sistema.

**Solución propuesta:**

Implementar una solución de persistencia más robusta utilizando Entity Framework Core, repositorios y una base de datos para mejorar el rendimiento y la organización del acceso a datos.

---

### 2. Configuración del sistema

Algunos parámetros del sistema pueden depender directamente del código, dificultando los cambios entre ambientes de desarrollo, pruebas y producción.

**Solución propuesta:**

Gestionar la configuración mediante archivos externos como `appsettings.json` y variables de entorno, evitando valores escritos directamente en el código y facilitando el mantenimiento.

---

## Cláusula de IA

Se utilizó inteligencia artificial como apoyo para organizar la documentación, mejorar la redacción técnica e identificar posibles propuestas de solución para las deudas técnicas. Las decisiones finales fueron adaptadas al contexto del proyecto Mi Biblioteca.
