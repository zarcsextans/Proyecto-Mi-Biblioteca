#  ADR-02 – Vistas arquitectónicas de Mi Biblioteca

El ADR-02 documenta la definición de las vistas arquitectónicas del sistema Mi Biblioteca, como parte de una actividad académica enfocada en el diseño y comprensión de la arquitectura de software.

En este trabajo se analiza el sistema desde diferentes perspectivas con el objetivo de entender cómo está estructurado, cómo se comporta en tiempo de ejecución y cómo se distribuyen sus componentes en un entorno real.

---

##  Objetivo de la actividad

El objetivo principal es documentar mis decisiones de la arquitectura del sistema mediante cuatro vistas:

- Vista lógica  
- Vista de procesos  
- Vista física  
- Vista de despliegue  

Estas vistas permiten representar el sistema desde distintos niveles de abstracción, facilitando su análisis y comprensión.

---

##  Descripción del sistema

El sistema Mi Biblioteca es una aplicación orientada a la gestión de libros, usuarios y préstamos. Está desarrollado utilizando una arquitectura por capas con ASP.NET Core MVC, ASP.NET Core Web API y PostgreSQL como base de datos.

---

##  Arquitectura aplicada

Durante la actividad se definió una arquitectura basada en:

- Interfaz web para interacción del usuario  
- API para manejo de la lógica del sistema  
- Capa de servicios para reglas de negocio  
- Repositorios para acceso a datos  
- Base de datos PostgreSQL para persistencia  

---

##  Vistas arquitectónicas

- **Vista lógica:** describe la separación de funcionalidades como libros, usuarios y préstamos.  
- **Vista de procesos:** muestra el flujo de una operación desde el usuario hasta la base de datos.  
- **Vista física:** representa cómo está organizado el código dentro del proyecto.  
- **Vista de despliegue:** describe cómo se ejecuta el sistema en un entorno distribuido.  

---
##  Dónde se realizó el proyecto

Este trabajo fue desarrollado como parte de una actividad académica individual dentro de un entorno de desarrollo basado en .NET.

El trabajo se realizó utilizando:

- GitHub para control de versiones y entrega
- Mermaid / Draw.io para la elaboración de diagramas

---
##  Resultado de la actividad

Esta actividad permite comprender la importancia de documentar la arquitectura antes y durante el desarrollo de un sistema, ya que facilita la organización, mantenimiento y escalabilidad del proyecto.

---

##  Uso de IA

Parte de la documentación e información investigada fue elaborada con ayuda de la IA.
