# C4 lvl 1
```mermaid
flowchart LR

U[👨‍🎓 Usuario]
A[👨‍💻 Administrador]

MB["📚 Mi Biblioteca
Sistema Web de Gestión Bibliotecaria"]

P["💳 Plataforma de Pago
(Sistema Externo)"]

U --> MB
A --> MB

MB -->|Procesa pagos| P
```
 Dirigido a: Usuarios, clientes, equipo de trabajo y personas no técnicas. Muestra una visión general del sistema, identificando los usuarios que interactúan con él y los sistemas externos relacionados. Está dirigido a cualquier tipo de audiencia, ya que permite comprender rápidamente el propósito de la aplicación.

# C4 lvl 2
```mermaid
flowchart LR

    %% Actores
    U[👤 Usuario]
    A[⚙️ Administrador]

    %% Sistema
    subgraph MB["📖 Sistema Mi Biblioteca"]

        WEB["🌐 Aplicación Web (ASP.NET Core MVC)
        Interfaz de usuario"]

        API["🔗 API REST (ASP.NET Core)
        Gestión de libros, usuarios,
        préstamos, reservas y pagos"]

        DB[("🗄️ PostgreSQL
        Base de datos")]

    end

    %% Sistemas externos
    PAY["💳 Plataforma de Pago"]


    %% Relaciones
    U -->|Consulta catálogo, reservas y préstamos| WEB

    A -->|Gestiona usuarios y configuración| WEB

    WEB -->|HTTP/HTTPS| API

    API -->|CRUD de información| DB
    API -->|Procesa pagos| PAY
    
```
Dirigido a: Equipo técnico y desarrolladores. El diagrama de contenedores muestra la arquitectura principal de Mi Biblioteca y cómo se comunican sus componentes. La aplicación web interactúa con la API REST, la cual procesa la lógica del negocio, gestiona el acceso a la base de datos PostgreSQL y se integra con la plataforma de pagos para procesar las transacciones del sistema.

