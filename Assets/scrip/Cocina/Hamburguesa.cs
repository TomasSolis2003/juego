/*using UnityEngine;

public class Hamburguesa : MonoBehaviour
{
    public enum EstadoCoccion
    {
        Crudo,
        LevementeCocido,
        Cocido,
        Quemado
    }

    // Estado actual de la hamburguesa
    public EstadoCoccion estadoActual = EstadoCoccion.Crudo;

    // Tiempo de cocci�n en segundos para cada estado
    public float tiempoLevementeCocido = 5f;
    public float tiempoCocido = 10f;
    public float tiempoQuemado = 15f;

    private float tiempoCocinando = 0f;
    private bool estaCocinando = false;

    // Materiales o colores para representar los diferentes estados de cocci�n
    public Material materialCrudo;
    public Material materialLevementeCocido;
    public Material materialCocido;
    public Material materialQuemado;

    private Renderer renderer;

    void Start()
    {
        renderer = GetComponent<Renderer>();
        ActualizarEstadoVisual();  // Mostrar el estado inicial (crudo)
     
    }

    void Update()
    {
        if (estaCocinando)
        {
            // Incrementa el tiempo que la hamburguesa lleva cocin�ndose
            tiempoCocinando += Time.deltaTime;

            // Actualizar el estado de cocci�n seg�n el tiempo
            if (tiempoCocinando >= tiempoQuemado)
            {
                CambiarEstado(EstadoCoccion.Quemado);
            }
            else if (tiempoCocinando >= tiempoCocido)
            {
                CambiarEstado(EstadoCoccion.Cocido);
            }
            else if (tiempoCocinando >= tiempoLevementeCocido)
            {
                CambiarEstado(EstadoCoccion.LevementeCocido);
            }
        }
    }

    // Iniciar cocci�n
    public void IniciarCoccion()
    {
        estaCocinando = true;
    }

    // Detener cocci�n (por si necesitas pausar la cocci�n en alg�n momento)
    public void DetenerCoccion()
    {
        estaCocinando = false;
    }

    // Cambiar el estado de cocci�n
    private void CambiarEstado(EstadoCoccion nuevoEstado)
    {
        if (estadoActual != nuevoEstado)
        {
            estadoActual = nuevoEstado;
            ActualizarEstadoVisual();
        }
    }

    // Actualizar el material o color seg�n el estado actual de cocci�n
    private void ActualizarEstadoVisual()
    {
        switch (estadoActual)
        {
            case EstadoCoccion.Crudo:
                renderer.material = materialCrudo;
                break;
            case EstadoCoccion.LevementeCocido:
                renderer.material = materialLevementeCocido;
                break;
            case EstadoCoccion.Cocido:
                renderer.material = materialCocido;
                break;
            case EstadoCoccion.Quemado:
                renderer.material = materialQuemado;
                break;
        }
    }
}
*/
/*using UnityEngine;

public class Hamburguesa : MonoBehaviour
{
    public enum EstadoCoccion
    {
        Crudo,
        LevementeCocido,
        Cocido,
        Quemado
    }

    // Estado actual de la hamburguesa
    public EstadoCoccion estadoActual = EstadoCoccion.Crudo;

    // Tiempo de cocci�n en segundos para cada estado
    public float tiempoLevementeCocido = 5f;
    public float tiempoCocido = 10f;
    public float tiempoQuemado = 15f;

    private float tiempoCocinando = 0f;
    private bool estaCocinando = false;

    // Materiales o colores para representar los diferentes estados de cocci�n
    public Material materialCrudo;
    public Material materialLevementeCocido;
    public Material materialCocido;
    public Material materialQuemado;

    // Usamos new para ocultar el miembro heredado 'Component.renderer'
    private new Renderer renderer;

    void Start()
    {
        renderer = GetComponent<Renderer>();
        ActualizarEstadoVisual();  // Mostrar el estado inicial (crudo)
    }

    void Update()
    {
        if (estaCocinando)
        {
            // Incrementa el tiempo que la hamburguesa lleva cocin�ndose
            tiempoCocinando += Time.deltaTime;

            // Actualizar el estado de cocci�n seg�n el tiempo
            if (tiempoCocinando >= tiempoQuemado)
            {
                CambiarEstado(EstadoCoccion.Quemado);
            }
            else if (tiempoCocinando >= tiempoCocido)
            {
                CambiarEstado(EstadoCoccion.Cocido);
            }
            else if (tiempoCocinando >= tiempoLevementeCocido)
            {
                CambiarEstado(EstadoCoccion.LevementeCocido);
            }
        }
    }

    // Iniciar cocci�n
    public void IniciarCoccion()
    {
        estaCocinando = true;
    }

    // Detener cocci�n (por si necesitas pausar la cocci�n en alg�n momento)
    public void DetenerCoccion()
    {
        estaCocinando = false;
    }

    // Cambiar el estado de cocci�n
    private void CambiarEstado(EstadoCoccion nuevoEstado)
    {
        if (estadoActual != nuevoEstado)
        {
            estadoActual = nuevoEstado;
            ActualizarEstadoVisual();
        }
    }

    // Actualizar el material o color seg�n el estado actual de cocci�n
    private void ActualizarEstadoVisual()
    {
        switch (estadoActual)
        {
            case EstadoCoccion.Crudo:
                renderer.material = materialCrudo;
                break;
            case EstadoCoccion.LevementeCocido:
                renderer.material = materialLevementeCocido;
                break;
            case EstadoCoccion.Cocido:
                renderer.material = materialCocido;
                break;
            case EstadoCoccion.Quemado:
                renderer.material = materialQuemado;
                break;
        }
    }
}
*/
using UnityEngine;

public class Hamburguesa : MonoBehaviour
{
    public enum EstadoCoccion
    {
        Crudo,
        LevementeCocido,
        Cocido,
        Quemado
    }

    public EstadoCoccion estadoActual = EstadoCoccion.Crudo;

    public float tiempoLevementeCocido = 5f;
    public float tiempoCocido = 10f;
    public float tiempoQuemado = 15f;

    private float tiempoCocinando = 0f;

    public Material materialCrudo;
    public Material materialLevementeCocido;
    public Material materialCocido;
    public Material materialQuemado;

    private new Renderer renderer;

    void Start()
    {
        renderer = GetComponent<Renderer>();
        ActualizarEstadoVisual();
    }

    // Funci�n para cocinar la hamburguesa
    public void Cocinar()
    {
        tiempoCocinando += Time.deltaTime;

        if (tiempoCocinando >= tiempoQuemado)
        {
            CambiarEstado(EstadoCoccion.Quemado);
        }
        else if (tiempoCocinando >= tiempoCocido)
        {
            CambiarEstado(EstadoCoccion.Cocido);
        }
        else if (tiempoCocinando >= tiempoLevementeCocido)
        {
            CambiarEstado(EstadoCoccion.LevementeCocido);
        }
    }

    private void CambiarEstado(EstadoCoccion nuevoEstado)
    {
        if (estadoActual != nuevoEstado)
        {
            estadoActual = nuevoEstado;
            ActualizarEstadoVisual();
        }
    }

    private void ActualizarEstadoVisual()
    {
        switch (estadoActual)
        {
            case EstadoCoccion.Crudo:
                renderer.material = materialCrudo;
                break;
            case EstadoCoccion.LevementeCocido:
                renderer.material = materialLevementeCocido;
                break;
            case EstadoCoccion.Cocido:
                renderer.material = materialCocido;
                break;
            case EstadoCoccion.Quemado:
                renderer.material = materialQuemado;
                break;
        }
    }
}
