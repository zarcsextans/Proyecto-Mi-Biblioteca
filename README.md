# Mi Biblioteca - Integración de API REST

## Descripción

Este documento describe la incorporación de una **API REST** en el sistema Mi Biblioteca. Esta mejora forma parte de la evolución arquitectónica del proyecto, permitiendo desacoplar el frontend del backend y exponer la lógica del sistema mediante servicios web.

---

## Objetivo del cambio

El objetivo principal de esta implementación es:

- Separar la lógica del sistema de la interfaz de usuario
- Permitir que el sistema sea consumido por diferentes clientes (web, móvil, etc.)
- Mejorar la escalabilidad y mantenibilidad del proyecto
- Estandarizar la comunicación mediante HTTP

---

## Tecnología implementada

- ASP.NET Core Web API
- Arquitectura REST
- Swagger para documentación de endpoints
- PostgreSQL como base de datos
- Arquitectura por capas (Servicios + Repositorios)

---

## Recursos disponibles en la API

La API expone los siguientes módulos:

###  Libros
- Gestión del catálogo de libros

###  Usuarios
- Administración de usuarios del sistema

###  Préstamos
- Control de préstamos de libros

###  Reservas
- Gestión de reservas de libros

###  Pagos
- Registro de pagos relacionados al sistema

---

## Endpoints principales

Ejemplos de endpoints disponibles:

- GET /api/libros
- POST /api/libros
- GET /api/usuarios
- POST /api/usuarios
- GET /api/prestamos
- POST /api/prestamos
- GET /api/reservas
- POST /api/reservas
- GET /api/pagos

---

## Documentación de la API

La documentación de los endpoints se realiza mediante **Swagger**, el cual permite:

- Visualizar todos los endpoints disponibles
- Probar las peticiones HTTP directamente desde el navegador
- Facilitar la comprensión del funcionamiento de la API

Acceso:

## Clausula de IA

Este proyecto fue desarrollado con el apoyo de herramientas de inteligencia artificial para la generación de borradores, mejora de redacción y estructuración de documentación técnica (ADRs y README).
