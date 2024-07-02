# BellyCare 📱🤰

BellyCare es una aplicación móvil diseñada para empoderar a las mujeres embarazadas 🤰 y a los profesionales de la salud 👩‍⚕️ en el seguimiento y control de la nutrición durante el embarazo. 
Con BellyCare, las futuras madres pueden registrar y monitorear su salud, recibir alertas personalizadas y comunicarse directamente con sus médicos, todo desde la comodidad de sus dispositivos móviles.

## Capturas de Pantalla 📸

Aquí hay un vistazo a algunas de las pantallas de BellyCare:

|![](https://raw.githubusercontent.com/barreto-exe/bellycare/master/img/1.jpg)|![](https://raw.githubusercontent.com/barreto-exe/bellycare/master/img/2.jpg)|![](https://raw.githubusercontent.com/barreto-exe/bellycare/master/img/3.jpg)|![](https://raw.githubusercontent.com/barreto-exe/bellycare/master/img/4.jpg)|
|:-------------: |:---------------:|:-------------: |:---------------:|

## Características Principales ✨

- **Registro de datos de salud:** Permite a las mujeres embarazadas registrar información importante como peso, medidas, presión arterial y otros datos relevantes para el seguimiento del embarazo.
- **Comunicación directa con profesionales de la salud:** Facilita la comunicación entre las pacientes y sus médicos a través de un chat seguro, permitiendo hacer preguntas, recibir orientación y resolver dudas en tiempo real.
- **Interfaz intuitiva y fácil de usar:** Diseñada pensando en la comodidad y facilidad de uso para las mujeres embarazadas, con una navegación sencilla y opciones claras.

## Tecnologías Utilizadas 🛠️

- **Firebase:** Plataforma en la nube de Google que proporciona herramientas y servicios para el desarrollo de aplicaciones móviles y web.
- **C#:** Lenguaje de programación moderno y versátil utilizado para el desarrollo de aplicaciones .NET.
- **.NET MAUI:** Marco de desarrollo multiplataforma de Microsoft que permite crear aplicaciones nativas para iOS, Android, macOS y Windows con una única base de código.

## Inicialización de la Base de Datos Firebase 🔥

Antes de utilizar BellyCare, es crucial configurar correctamente la base de datos Firebase. Sigue estos pasos:

1.  **Crea un proyecto Firebase:** Accede a la consola de Firebase y crea un nuevo proyecto.
2.  **Selecciona Realtime Database:** En la sección "Build" (Construir), elige "Realtime Database" (Base de datos en tiempo real) y crea una nueva base de datos.
3.  **Establece reglas de seguridad:** Configura las reglas de seguridad de tu base de datos para proteger los datos de los usuarios.
4.  **Crea el nodo Admin:** En la raíz de tu base de datos, crea un nodo llamado "Admin" y dentro de él, un objeto con un ID cualquiera (por ejemplo, "-Admin") con las siguientes propiedades:
    *   `Email`: El correo electrónico del administrador.
    *   `Password`: La contraseña del administrador.

**Ejemplo:**

```
Admin
    -Admin
        Email: "admin@example.com"
        Password: "password123"
```

Este nodo "Admin" será utilizado por la aplicación para autenticar y autorizar al administrador, quien a su vez podrá gestionar los perfiles de los profesionales de la salud.

## Archivo de Configuración data.json ⚙️
El archivo data.json ubicado en la ruta `Bellycare > Resources > Raw > data.json` es esencial para la configuración de la aplicación. Contiene información importante como las URLs de Firebase para desarrollo y producción, así como el color primario utilizado en la interfaz de usuario.

Ejemplo:
``` Json
{
 "FIREBASE_URL_DEV": "<URL_HERE>",
 "FIREBASE_URL_PROD": "<URL_HERE>",
 "PRIMARY_COLOR": "#512BD4"
}
```

Asegúrate de reemplazar los valores <URL_HERE> con las URLs correctas de tu proyecto Firebase y personalizar el color primario si lo deseas.

**Nota:** Se proporciona un archivo data.example.json como referencia para la estructura y los campos necesarios en data.json.

## Instrucciones de Instalación de BellyCare (APK)

1.  **Descarga del APK:**
    *   Obtén el archivo APK de BellyCare [haciendo click aquí.](https://github.com/barreto-exe/bellycare/releases/download/v1.0.0/com.barretoexe.bellycare.apk)

2.  **Habilitar Orígenes Desconocidos:**
    *   Ve a la sección de "Ajustes" o "Configuración" de tu dispositivo móvil.
    *   Busca la opción "Seguridad" o "Privacidad".
    *   Activa la opción "Orígenes desconocidos" o "Instalar aplicaciones desconocidas". Esto permitirá la instalación de aplicaciones desde fuentes externas a la tienda de aplicaciones oficial.

3.  **Instalación:**
    *   Abre el archivo APK descargado.
    *   Sigue las instrucciones en pantalla para completar la instalación.
    *   Es posible que se te solicite confirmar la instalación.

4.  **Abrir BellyCare:**
    *   Una vez instalada, busca el ícono de BellyCare en tu pantalla de inicio o en el menú de aplicaciones.
    *   Toca el ícono para abrir la aplicación.

5.  **Registro o Inicio de Sesión:**
    *   Si eres un nuevo usuario paciente, selecciona la opción "Registrarse" y sigue los pasos para crear tu cuenta.
    *   Si ya tienes una cuenta, ingresa tu correo electrónico y contraseña para iniciar sesión.

6.  **¡Comienza a usar BellyCare!**
    *   Explora las funciones de la aplicación y comienza a registrar tus datos de salud y a recibir orientación personalizada.

**Nota:** El rol de administrador se establece durante la configuración inicial del sistema y es responsable de crear y gestionar los perfiles de los profesionales de la salud que utilizarán la aplicación.

## Contacto 📧

Si tienes alguna pregunta o sugerencia, no dudes en contactarnos a través de [digitalsalud4@gmail.com].

¡Gracias por tu interés en BellyCare! Esperamos que esta aplicación sea una herramienta valiosa para todas las mujeres embarazadas en su camino hacia un embarazo saludable y feliz. ❤️
