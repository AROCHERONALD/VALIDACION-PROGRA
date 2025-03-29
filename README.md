# VALIDACION-PROGRA
LLMs Utilizados

Para resolver el problema planteado, se utilizaron dos modelos de lenguaje a gran escala (LLM):

1. DeepSeek: Un modelo avanzado optimizado para generación de código y análisis de problemas técnicos.


2. Microsoft Copilot: Integrado en el ecosistema de desarrollo de Microsoft, útil para sugerencias de código en tiempo real dentro de entornos como Visual Studio.



Prompts Utilizados

Se emplearon los siguientes prompts para cada LLM:

DeepSeek:
"En C#, si una clase define el tipo de licencia en el constructor y la valida con la edad, ¿cómo puedo permitir cambios en esta propiedad asegurando que la validación siga siendo efectiva?"

Microsoft Copilot:
"Necesito actualizar la propiedad 'tipo de licencia' en una clase en C#, pero fue definida en el constructor con validación de edad. ¿Cuál es la mejor forma de permitir cambios sin romper la lógica?"


Mejor Forma de Hacerlo

Tras analizar las respuestas de ambos modelos, la mejor práctica recomendada es:

1. Usar una propiedad con validación en el setter, asegurando que los cambios cumplan las condiciones establecidas.


2. Implementar un método para cambiar la propiedad de manera controlada, en lugar de permitir modificaciones directas.


3. Utilizar patrones de diseño como el patrón Factory o Builder, si se requiere mayor flexibilidad en la creación de objetos.



Ejemplo de Código en C#

public class Chofer  
{  
    public int Edad { get; private set; }  
    private string tipoLicencia;  

    public string TipoLicencia  
    {  
        get { return tipoLicencia; }  
        set  
        {  
            if (Edad < 18 && value != "Ninguna")  
                throw new InvalidOperationException("No se puede asignar licencia a menores de edad.");  
            tipoLicencia = value;  
        }  
    }  

    public Chofer(int edad, string tipoLicencia)  
    {  
        Edad = edad;  
        TipoLicencia = tipoLicencia;  
    }  
}

Conclusión

Ambos LLMs proporcionaron soluciones útiles, pero Microsoft Copilot ofreció una integración más fluida con el entorno de desarrollo, mientras que DeepSeek proporcionó una mejor explicación teórica del problema. La mejor práctica combinó elementos de ambas respuestas para garantizar un código seguro y flexible.