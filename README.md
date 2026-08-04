# 📚 Sistema de Gestión Bibliotecaria: Mi Biblioteca

## 👩‍💻 Información del Autor

**Desarrolladora:** Scarlet Angelina Ruelas  
**Proyecto:** Mi Biblioteca  
**Tecnologías principales:** ASP.NET Core MVC, ASP.NET Core Web API, Entity Framework Core, PostgreSQL y xUnit

---

# 📖 Descripción del Proyecto

Mi Biblioteca es un sistema web diseñado para la gestión integral de una biblioteca digital, permitiendo administrar libros, usuarios y préstamos mediante una arquitectura moderna basada en capas.

El sistema busca facilitar el control del catálogo bibliográfico, el registro de usuarios y la administración de préstamos, aplicando buenas prácticas de desarrollo de software como separación de responsabilidades, principios SOLID, pruebas automatizadas y documentación arquitectónica.

La solución está organizada en diferentes módulos que trabajan de manera integrada:

## 📚 Gestión de Libros

Permite administrar el catálogo de libros de la biblioteca:

- Registro de nuevos libros.
- Consulta del catálogo disponible.
- Actualización de información.
- Eliminación de registros.

---

## 👥 Gestión de Usuarios

Administra los usuarios registrados en el sistema:

- Creación de usuarios.
- Consulta de información.
- Actualización de datos personales.
- Eliminación de usuarios.

---

## 📋 Gestión de Préstamos

Controla el flujo de préstamos de libros:

- Registro de préstamos.
- Asignación automática de fecha.
- Control del estado del préstamo.
- Actualización de devoluciones.

---

# 🏗️ Arquitectura del Sistema

El proyecto implementa una arquitectura por capas para mantener un código organizado, escalable y fácil de mantener.

## 🌐 Capa Web (MiBiblioteca.Web)

Aplicación MVC encargada de la interfaz de usuario.

Responsabilidades:

- Renderizado de vistas Razor.
- Navegación entre módulos.
- Consumo de la API REST.
- Presentación de información al usuario.

---

## 🔌 API REST (MiBiblioteca.Api)

Servicio encargado de exponer los endpoints del sistema.

Incluye controladores para:

- Usuarios (`UsuariosController`)
- Libros (`LibrosController`)
- Préstamos (`PrestamosController`)

Características:

- Operaciones CRUD.
- Comunicación mediante HTTP.
- Separación entre lógica y presentación.

---

## ⚙️ Capa de Aplicación (MiBiblioteca.Application)

Contiene la lógica de negocio del sistema.

Incluye servicios:

- `LibroService`
- `UsuarioService`
- `PrestamoService`

Responsabilidades:

- Validaciones de negocio.
- Coordinación entre controladores y repositorios.
- Gestión de operaciones principales.

---

## 🧩 Capa de Dominio (MiBiblioteca.Domain)

Representa las entidades principales del sistema:

- Libro
- Usuario
- Prestamo

También contiene:

- Interfaces de repositorios.
- Enumeraciones del dominio.
- Reglas principales del negocio.

---

## 💾 Capa de Infraestructura (MiBiblioteca.Infrastructure)

Gestiona la persistencia de datos.

Implementa:

- Entity Framework Core.
- PostgreSQL.
- Repositorios concretos.
- Migraciones de base de datos.

---

# 🗄️ Base de Datos

El sistema utiliza PostgreSQL como motor de persistencia.

Incluye entidades principales:
