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

# C4 lvl 3
```mermaid
flowchart LR

    %% Actores externos
    WEB["🌐 Mi Biblioteca Web MVC
    Cliente del sistema"]

    %% Contenedor principal
    subgraph API["🔗 Mi Biblioteca API REST"]

        %% Controllers
        C1["📚 LibrosController
        Gestiona endpoints de libros"]

        C2["👤 UsuariosController
        Gestiona usuarios"]

        C3["📖 PrestamosController
        Gestiona préstamos"]

        C4["💳 PagosController
        Gestiona pagos"]

        %% Services
        S1["⚙️ LibroService
        Reglas del catálogo"]

        S2["⚙️ UsuarioService
        Lógica de usuarios"]

        S3["⚙️ PrestamoService
        Control de préstamos"]

        S4["⚙️ PagoService
        Procesamiento de pagos"]


        %% Patrones GoF
        F["🏭 PagoFactory
        Factory Method
        Crea métodos de pago"]

        ST["🎯 Strategy Pattern
        PagoTarjetaStrategy
        PagoEfectivoStrategy"]

        D["🔵 Decorator Pattern
        Agrega funcionalidades
        adicionales al pago"]

        O["👁️ Observer Pattern
        Notifica cambios del sistema"]


        %% Repositories
        R1["🗂️ LibroRepository"]

        R2["🗂️ UsuarioRepository"]

        R3["🗂️ PrestamoRepository"]

        R4["🗂️ PagoRepository"]

    end


    DB[(🗄️ PostgreSQL)]


    %% Relaciones

    WEB -->|HTTP/HTTPS| C1
    WEB --> C2
    WEB --> C3
    WEB --> C4


    C1 --> S1
    C2 --> S2
    C3 --> S3
    C4 --> S4


    S1 --> R1
    S2 --> R2
    S3 --> R3
    S4 --> R4


    S4 --> F
    F --> ST
    S4 --> D
    S4 --> O


    R1 --> DB
    R2 --> DB
    R3 --> DB
    R4 --> DB
```
Dirigido a: Desarrolladores que necesitan trabajar directamente con la implementación. El diagrama de componentes muestra la estructura interna de la API REST de Mi Biblioteca. Se observan los controladores encargados de recibir solicitudes, los servicios que contienen la lógica del negocio, los repositorios para la gestión de datos y los patrones GoF implementados para mejorar la flexibilidad y mantenibilidad del sistema.


