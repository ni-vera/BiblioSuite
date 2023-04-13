# BiblioSuite

Go to [English](#english).

BiblioSuite pretende ser una solución integral multiplataforma para la catalogación de bibliotecas personales.

### Características actuales (versión de escritorio):

+ Adición de obras mediante ISBN (la información del libro es obtenida instando a la API de Google Books).

+ Obtención automática, en caso de disponibilidad, de fecha de nacimiento del autor (obtenida instando a la API de la base de datos de ISNI haciendo uso del nombre del autor obtenido mediante la llamada a la API de Google Books).

+ Búsqueda tanto normal como avanzada.

### Características futuras

+ Creación de versión web MVC y versión movil con Xamarin, ambas sincronizadas con la versión de escritorio.

+ Panel estadístico con sus preceptivos gráficos representando información relevante (porcentaje de libros leídos, evolución del número de libros, porcentaje de libros por género o siglo, etc..)

+ Adición de libros mediante código de barras (versión móvil).

+ Obtención de información extra sobre los autores que tengan ficha en WikiData mediante llamada a la respectiva API e integración de los nuevos campos en la búsqueda avanzada.

+ Condiciones "o" en la búsqueda avanzada.

+ Ampliar la cobertura de excepciones y potenciales errores.


## English

BiblioSuite aims to be an integral multi-platform solution for cataloguing personal libraries.

### Current features (desktop version):

+ Adding books through their ISBN (book info is obtain querying the Google Books API).

+ Automatic obtention (when available) of the author's lifespan dates (obtained by querying the ISNI database using the author name obtained in the Google Books API query).

+ Normal and advanced search.

### Forecoming features

+ Creation of the MVC web veresion and the Xamarin mobile version, both synced with the desktop version.

+ Statistic panel with its preceptive charts representing relevant information (% of read books, evolution of the total book number, % of books by genre, etc..)

+ Addition of books through barcode scanning (mobile version).

+ Obtention of extra information about the authors present in the WikiData database by calling its API. Integration of the new fields in the advanced search function.

+ "OR" conditions in advanced search.

+ Widen coverage of exceptions and potential errors.
