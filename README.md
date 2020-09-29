# Proyecto interno SD Script de Origen#

###### SSIS ######
- Paso 1 Crear un nuevo Data Flow Task
- Paso 2 Ingresar al data Flow Task 
- Paso 3 Añadir un Componente de script de la secciones "Comunes" que sea de tipo Origen
- Paso 4 Doble clic en el componente y acceder a las entradas y salidas
- paso 5 Crear una nueva columna de salida llamada "Estatus"
- Paso 6 Abrir el componente y dar clic en Editar Script (Se requeire visual studio instalado)
- Paso 7 Añadir un packete de Nugget -
   - Paso 7.1 Clic derecho a la solucion 
   - Paso 7.2 Dar clic en Administrar Paquete de Nuget para la solucion
   - Paso 7.3 Ir a examinar paquetes
   - Paso 7.4 buscar el paquete System.Net.Http
   - Paso 7.5 Instalarlo
   - Paso 7.6 Cerrar el administrador de paquetes
   - Paso 7.7 ir al main.cs
   - Paso 7.8 agregar los siguientes using 
      ```C#
         using System.Net.Http;
         using System.Collections.Generic;
      ```


- Paso 8 Escribir el siguiente codigo en CreateNewOutputRows() (se encuentra en el main.cs)

```C#
HttpClient client = new HttpClient();
string APIUrl = "http://balorit.com/TuberiasHub/ActualizarHubTuberiaCovid";
client.BaseAddress = new Uri("http://balorit.com/TuberiasHub/ActualizarHubTuberiaCovid");
HttpContent content = new FormUrlEncodedContent(new Dictionary<string, string>
{
    {"UserName", "Wally"},
    {"Password", "123123"}
});
client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
var response = client.PostAsync(APIUrl, content).Result;
```


## NOTAS ##
--El string APIUrl se debe colocar la direccion del proyecto
--El ejemplo es unicamente para ir a una API de pruebas
