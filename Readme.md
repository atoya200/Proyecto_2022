# Universidad Católica del Uruguay
<img src="https://ucu.edu.uy/sites/all/themes/univer/logo.png">

## Facultad de Ingeniería y Tecnologías
### Programación II

# Proyecto 2022 - Segundo Semestre - Chatbot Objetivos de Desarrollo Sostenible - Objetivo 8: Trabajo decente y crecimiento económico

## Introducción

En esta edición del curso los estudiantes han propuesto varios proyectos relacionados con los [objetivos de desarrollo sostenible](https://www.un.org/sustainabledevelopment/es/objetivos-de-desarrollo-sostenible/) de las Naciones Unidas y han elegido uno relacionado con el [objetivo 8: Trabajo decente y crecimiento económico](https://www.un.org/sustainabledevelopment/es/economic-growth/). La consigna inicial para la formulación y selección de los proyectos quedó [aquí](./Propuesta.md).

Ese objetivo 8 plantea:

> Promover el credimiento económico inclusivo y sostenible, el empleo y el trabajo decente para todos [[fuente](https://www.un.org/sustainabledevelopment/es/economic-growth/)].

La pregunta disparadora del proyecto elegido por los estudiantes es la siguiente:

> ¿Cómo podemos nosotros, estudiantes del curso de Programación II ayudar a las personas a encontrar trabajo? En base a las necesidades del usuario que el chat bot le responda con datos de quienes otorgan ese servicio. Ejemplo jardineros, pintores, chapistas y otros servicios. Conectando quienes necesitan un servicio y quienes lo ofrecen. Crear dentro del chat bot algo similar a reputación, es decir un jardinero que hizo 3 trabajos ya tiene su clasificación para darle más seguridad a quien lo contrata. También podrían incorporarse sistemas de pagos a través de la "aplicación" lo cual generaría una mayor solides de la estructura previniendo estafas y hurtos.

## Acerca de los chatbots

Un chatbot (o bot conversacional) es «un programa que simula mantener una conversación con una persona al proveer respuestas automáticas a entradas hechas por el usuario.»1

Existen gran variedad de chatbots actualmente y varios sabores. Hay chatbots que simplemente responden a comandos pre-establecidos, y otros que integran algoritmos de [inteligencia artificial](https://es.wikipedia.org/wiki/Inteligencia_artificial) para procesar los mensajes de los usuarios e [interpretar lo que se está diciendo](https://es.wikipedia.org/wiki/Procesamiento_de_lenguajes_naturales).

Algunas de las aplicaciones más conocidas que abren sus puertas al desarrollo de chatbots (tienen [APIs](https://es.wikipedia.org/wiki/Interfaz_de_programaci%C3%B3n_de_aplicaciones)) son: Telegram, Messenger, Whatsapp, Slack, Discord, entre otras.

## Escenarios

Aquí veremos una explicación general e informal de las funciones del software (nuestro programa), escrita desde la perspectiva del usuario final. Su propósito es articular cómo el software proporcionará una función de valor al cliente.

- Cómo administrador, quiero poder indicar categorías sobre las cuales se realizarán las ofertas de servicios para que de esa forma, pueda clasificarlos.
- Como administrador, quiero poder dar de baja ofertas de servicios, avisando al oferente para que de esa forma, pueda evitar ofertas inadecudas.
- Como trabajador, quiero registrarme en la plataforma, indicando mis datos personales e información de contacto para que de esa forma, pueda proveer información de contacto a quienes quieran contratar mis servicios.
- Como trabajador, quiero poder hacer ofertas de servicios; mi oferta indicará en qué categoría quiero publicar, tendrá una descripción del servicio ofertado, y un precio para que de esa forma, mis ofertas sean ofrecidas a quienes quieren contratar servicios.
- Como empleador, quiero registrarme en la plataforma, indicando mis datos personales e información de contacto para que de esa forma, pueda proveer información de contacto a los trabajadores que quiero contratar.
- Como empleador, quiero buscar ofertas de trabajo, opcionalmente filtrando por categoría para que de esa forma, pueda contratar un servicio.
- Como empleador, quiero ver el resultado de las búsquedas de ofertas de trabajo ordenado en forma ascendente de distancia a mi ubicación, es decir, las más cercanas primero para que de esa forma, pueda poder contratar un servicio.
- Como empleador, quiero ver el resultado de las búsquedas de ofertas de trabajo ordenado en forma descendente por reputación, es decir, las de mejor reputación primero para que de esa forma, pueda contratar un servicio.
- Como empleador, quiero poder contactar a un trabajador para que de esa forma pueda, contratar una oferta de servicios determinada.
- Como trabajador, quiero poder calificar a un empleador; el empleador me tiene que calificar a mi también, si no me califica en un mes, la calificación será neutral, para que de esa forma pueda definir la reputación de mi empleador.
- Como empleador, quiero poder calificar a un trabajador; el trabajador me tiene que calificar a mi también, si no me califica en un mes, la calificación será neutral, para que de esa forma, pueda definir la reputaión del trabajador.
- Como trabajador, quiero poder saber la reputación de un empleador que me contacte para que de esa forma, poder decidir sobre su solicitud de contratación.

## Roadmap y entregables
| Instancia | Fecha | Entregables |
| --- | --- | --- |
| Kick-off | 12 de Setiembre |
| Primer Entrega | 28 de Setiembre | Entrega de tarjetas CRC/Diagrama de Clases/Código de clases de dominio
| Segunda Entrega | 30 de Octubre | Entrega de [User Stories](https://es.wikipedia.org/wiki/Historias_de_usuario) implementadas. Las historias de usuario deberán ser implementadas mediante casos de prueba (TDD).
| Entrega Final | 30 de Noviembre<sup>2</sup>|

## :warning: Importante :warning:

Cada equipo designará qué integrante del equipo desarrollará cada clase. La distribución debe contemplar número de clases y responsabilidades. Se evaluará que cada integrante trabaje en una rama independiente y que se integren los cambios mediante pull requests.

Las entregas serán hasta las :clock: 23:59 del día indicado.