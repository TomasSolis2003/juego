
/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Cliente : MonoBehaviour
{
    // Lista de ingredientes que puede pedir el cliente
    public List<string> ingredientesDisponibles = new List<string> { "carne", "tomate", "lechuga", "bebida", "Pan", "Pan_inf" };

    // Orden actual que el cliente pedirá
    private List<string> ordenActual = new List<string>();

    // Mensajes que el cliente dirá dependiendo de si la orden es correcta o incorrecta
    public string mensajePositivo = "¡Gracias!";
    public string mensajeNegativo = "¡Esto no es lo que pedí!";

    // Tiempo que el cliente espera para entregar la orden (en segundos)
    public float tiempoEsperaMaximo = 120f; // 2 minutos

    // Estado del pedido (se inicia en falso)
    private bool pedidoRecibido = false;
    private bool esperandoEntrega = false;

    // Rango máximo de interacción para entregar la orden
    public float rangoDeInteraccion = 3f;

    // Referencia al TextMeshPro para mostrar los mensajes del cliente
    public TextMeshProUGUI mensajeCliente;

    // Referencia al TextMeshPro para mostrar la orden que el cliente ha pedido
    public TextMeshProUGUI ordenCliente;

    // Método que genera una orden aleatoria
    void Start()
    {
        GenerarOrden();
    }

    // Generar una orden aleatoria
    void GenerarOrden()
    {
        ordenActual.Clear();

        // Orden aleatoria de entre los ingredientes
        int cantidadIngredientes = Random.Range(3, 6); // Al menos 3 ingredientes, hasta 6
        for (int i = 0; i < cantidadIngredientes; i++)
        {
            string ingrediente = ingredientesDisponibles[Random.Range(0, ingredientesDisponibles.Count)];
            ordenActual.Add(ingrediente);
        }

        // Mostrar la orden generada en el TextMeshPro (para el jugador)
        ordenCliente.text = "Orden del cliente: " + string.Join(", ", ordenActual);

        // Mostrar el mensaje de que el cliente está esperando
        mensajeCliente.text = "Esperando...";

        // Comenzar la espera de 2 minutos antes de que el jugador pueda entregar la orden
        StartCoroutine(EsperarParaEntrega());
    }

    // Coroutine para esperar 2 minutos (120 segundos)
    IEnumerator EsperarParaEntrega()
    {
        esperandoEntrega = true;

        // Espera el tiempo de espera máximo (2 minutos)
        yield return new WaitForSeconds(tiempoEsperaMaximo);

        // Una vez pasado el tiempo, el cliente puede recibir la orden
        mensajeCliente.text = "¡Puedes entregar la orden ahora!";
    }

    // Verificar si la orden entregada por el jugador es correcta
    public void VerificarOrden(List<string> ingredientesJugador)
    {
        bool ordenCorrecta = true;

        // Comparar los ingredientes entregados con los de la orden
        foreach (string ingrediente in ordenActual)
        {
            if (!ingredientesJugador.Contains(ingrediente))
            {
                ordenCorrecta = false;
                break;
            }
        }

        // Mensaje dependiendo si la orden es correcta
        if (ordenCorrecta)
        {
            mensajeCliente.text = mensajePositivo;  // Mostrar mensaje positivo
            Debug.Log(mensajePositivo);
            pedidoRecibido = true; // El pedido ha sido entregado correctamente
        }
        else
        {
            mensajeCliente.text = mensajeNegativo;  // Mostrar mensaje negativo
            Debug.Log(mensajeNegativo);
        }
    }

    // Método para la interacción con el jugador (se llamará cuando el jugador presione "F" cerca)
    void Update()
    {
        // Comprobar la distancia entre el jugador y el cliente
        if (Vector3.Distance(transform.position, Player.instance.transform.position) < rangoDeInteraccion)
        {
            // El jugador está lo suficientemente cerca y presiona "F"
            if (Input.GetKeyDown(KeyCode.F) && esperandoEntrega && !pedidoRecibido)
            {
                // Aquí suponemos que el jugador tiene una lista de ingredientes entregados (esto se conecta con otro script del jugador)
                List<string> ingredientesJugador = new List<string> { "carne", "tomate", "lechuga", "Pan_inf", "Pan" }; // Ejemplo de entrega

                VerificarOrden(ingredientesJugador);
            }
        }
    }
}
*/
/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Cliente : MonoBehaviour
{
    // Lista de ingredientes que puede pedir el cliente
    public List<string> ingredientesDisponibles = new List<string> { "carne", "tomate", "lechuga", "bebida", "Pan", "Pan_inf" };

    // Orden actual que el cliente pedirá
    private List<string> ordenActual = new List<string>();

    // Mensajes que el cliente dirá dependiendo de si la orden es correcta o incorrecta
    public string mensajePositivo = "¡Gracias!";
    public string mensajeNegativo = "¡Esto no es lo que pedí!";

    // Tiempo que el cliente espera para entregar la orden (en segundos)
    public float tiempoEsperaMaximo = 120f; // 2 minutos

    // Estado del pedido (se inicia en falso)
    private bool pedidoRecibido = false;
    private bool esperandoEntrega = false;

    // Rango máximo de interacción para entregar la orden
    public float rangoDeInteraccion = 3f;

    // Referencia al TextMeshPro 3D para mostrar los mensajes del cliente
    public TextMeshPro mensajeCliente;

    // Referencia al TextMeshPro 3D para mostrar la orden que el cliente ha pedido
    public TextMeshPro ordenCliente;

    // Método que genera una orden aleatoria
    void Start()
    {
        GenerarOrden();
    }

    // Generar una orden aleatoria
    void GenerarOrden()
    {
        ordenActual.Clear();

        // Orden aleatoria de entre los ingredientes
        int cantidadIngredientes = Random.Range(3, 6); // Al menos 3 ingredientes, hasta 6
        for (int i = 0; i < cantidadIngredientes; i++)
        {
            string ingrediente = ingredientesDisponibles[Random.Range(0, ingredientesDisponibles.Count)];
            ordenActual.Add(ingrediente);
        }

        // Mostrar la orden generada en el TextMeshPro 3D (para el jugador)
        ordenCliente.text = "Orden del cliente: " + string.Join(", ", ordenActual);

        // Mostrar el mensaje de que el cliente está esperando
        mensajeCliente.text = "Esperando...";

        // Comenzar la espera de 2 minutos antes de que el jugador pueda entregar la orden
        StartCoroutine(EsperarParaEntrega());
    }

    // Coroutine para esperar 2 minutos (120 segundos)
    IEnumerator EsperarParaEntrega()
    {
        esperandoEntrega = true;

        // Espera el tiempo de espera máximo (2 minutos)
        yield return new WaitForSeconds(tiempoEsperaMaximo);

        // Una vez pasado el tiempo, el cliente puede recibir la orden
        mensajeCliente.text = "¡Puedes entregar la orden ahora!";
    }

    // Verificar si la orden entregada por el jugador es correcta
    public void VerificarOrden(List<string> ingredientesJugador)
    {
        bool ordenCorrecta = true;

        // Comparar los ingredientes entregados con los de la orden
        foreach (string ingrediente in ordenActual)
        {
            if (!ingredientesJugador.Contains(ingrediente))
            {
                ordenCorrecta = false;
                break;
            }
        }

        // Mensaje dependiendo si la orden es correcta
        if (ordenCorrecta)
        {
            mensajeCliente.text = mensajePositivo;  // Mostrar mensaje positivo
            Debug.Log(mensajePositivo);
            pedidoRecibido = true; // El pedido ha sido entregado correctamente
        }
        else
        {
            mensajeCliente.text = mensajeNegativo;  // Mostrar mensaje negativo
            Debug.Log(mensajeNegativo);
        }
    }

    // Método para la interacción con el jugador (se llamará cuando el jugador presione "F" cerca)
    void Update()
    {
        // Comprobar la distancia entre el jugador y el cliente
        if (Vector3.Distance(transform.position, Player.instance.transform.position) < rangoDeInteraccion)
        {
            // El jugador está lo suficientemente cerca y presiona "F"
            if (Input.GetKeyDown(KeyCode.F) && esperandoEntrega && !pedidoRecibido)
            {
                // Aquí suponemos que el jugador tiene una lista de ingredientes entregados (esto se conecta con otro script del jugador)
                List<string> ingredientesJugador = new List<string> { "carne", "tomate", "lechuga", "Pan_inf", "Pan" }; // Ejemplo de entrega

                VerificarOrden(ingredientesJugador);
            }
        }
    }
}
*/
/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Cliente : MonoBehaviour
{
    // Lista de ingredientes que puede pedir el cliente
    public List<string> ingredientesDisponibles = new List<string> { "carne", "tomate", "lechuga", "bebida", "Pan", "Pan_inf" };

    // Orden actual que el cliente pedirá
    private List<string> ordenActual = new List<string>();

    // Mensajes que el cliente dirá dependiendo de si la orden es correcta o incorrecta
    public string mensajePositivo = "¡Gracias!";
    public string mensajeNegativo = "¡Esto no es lo que pedí!";

    // Tiempo que el cliente espera para entregar la orden (en segundos)
    public float tiempoEsperaMaximo = 120f; // 2 minutos

    // Estado del pedido (se inicia en falso)
    private bool pedidoRecibido = false;
    private bool esperandoEntrega = false;

    // Rango máximo de interacción para entregar la orden
    public float rangoDeInteraccion = 3f;

    // Referencia al TextMeshPro 3D para mostrar los mensajes del cliente
    public TextMeshPro mensajeCliente;

    // Referencia al TextMeshPro 3D para mostrar la orden que el cliente ha pedido
    public TextMeshPro ordenCliente;

    // Referencia al GameObject que representa la mano del cliente
    public Transform manoCliente;

    // Referencia al GameObject con el tag "pedido" que se entregará al cliente
    public GameObject pedido;

    // Método que genera una orden aleatoria
    void Start()
    {
        GenerarOrden();
    }

    // Generar una orden aleatoria
    void GenerarOrden()
    {
        ordenActual.Clear();

        // Orden aleatoria de entre los ingredientes
        int cantidadIngredientes = Random.Range(3, 6); // Al menos 3 ingredientes, hasta 6
        for (int i = 0; i < cantidadIngredientes; i++)
        {
            string ingrediente = ingredientesDisponibles[Random.Range(0, ingredientesDisponibles.Count)];
            ordenActual.Add(ingrediente);
        }

        // Mostrar la orden generada en el TextMeshPro 3D (para el jugador)
        ordenCliente.text = "Orden del cliente: " + string.Join(", ", ordenActual);

        // Mostrar el mensaje de que el cliente está esperando
        mensajeCliente.text = "Esperando...";

        // Comenzar la espera de 2 minutos antes de que el jugador pueda entregar la orden
        StartCoroutine(EsperarParaEntrega());
    }

    // Coroutine para esperar 2 minutos (120 segundos)
    IEnumerator EsperarParaEntrega()
    {
        esperandoEntrega = true;

        // Espera el tiempo de espera máximo (2 minutos)
        yield return new WaitForSeconds(tiempoEsperaMaximo);

        // Una vez pasado el tiempo, el cliente puede recibir la orden
        mensajeCliente.text = "¡Puedes entregar la orden ahora!";
    }

    // Verificar si la orden entregada por el jugador es correcta
    public void VerificarOrden(List<string> ingredientesJugador)
    {
        bool ordenCorrecta = true;

        // Comparar los ingredientes entregados con los de la orden
        foreach (string ingrediente in ordenActual)
        {
            if (!ingredientesJugador.Contains(ingrediente))
            {
                ordenCorrecta = false;
                break;
            }
        }

        // Mensaje dependiendo si la orden es correcta
        if (ordenCorrecta)
        {
            mensajeCliente.text = mensajePositivo;  // Mostrar mensaje positivo
            Debug.Log(mensajePositivo);
            pedidoRecibido = true; // El pedido ha sido entregado correctamente

            // Hacer que el pedido sea hijo del cliente y posicionarlo en la mano
            RecibirPedido();
        }
        else
        {
            mensajeCliente.text = mensajeNegativo;  // Mostrar mensaje negativo
            Debug.Log(mensajeNegativo);
        }
    }

    // Método para recibir el pedido (hacerlo hijo del cliente y posicionarlo en la mano)
    void RecibirPedido()
    {
        if (pedido != null)
        {
            // Hacer que el pedido sea hijo del cliente (se moverá con él)
            pedido.transform.SetParent(manoCliente);

            // Colocar el pedido en la posición de la mano del cliente
            pedido.transform.localPosition = Vector3.zero;  // Esto lo pone exactamente en la mano

            // Opcional: Si quieres que el pedido se rote con la mano del cliente
            pedido.transform.localRotation = Quaternion.identity;
        }
    }

    // Método para la interacción con el jugador (se llamará cuando el jugador presione "F" cerca)
    void Update()
    {
        // Comprobar la distancia entre el jugador y el cliente
        if (Vector3.Distance(transform.position, Player.instance.transform.position) < rangoDeInteraccion)
        {
            // El jugador está lo suficientemente cerca y presiona "F"
            if (Input.GetKeyDown(KeyCode.F) && esperandoEntrega && !pedidoRecibido)
            {
                // Aquí suponemos que el jugador tiene una lista de ingredientes entregados (esto se conecta con otro script del jugador)
                List<string> ingredientesJugador = new List<string> { "carne", "tomate", "lechuga", "Pan_inf", "Pan" }; // Ejemplo de entrega

                VerificarOrden(ingredientesJugador);
            }
        }
    }
}
*/
/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Cliente : MonoBehaviour
{
    public List<string> ingredientesDisponibles = new List<string> { "carne", "tomate", "lechuga", "bebida", "Pan", "Pan_inf" };
    private List<string> ordenActual = new List<string>();

    public TextMeshPro mensajeCliente;
    public TextMeshPro ordenCliente;

    public Transform manoCliente;
    public GameObject pedidoPrefab;

    public Renderer clienteRenderer; // Cambiará de color según el humor
    public float rangoDeInteraccion = 3f;
    private bool esperandoEntrega = true;
    private bool pedidoRecibido = false;

    private float tiempoEsperaMaximo = 60f;
    private float tiempoRestante;

    private Color colorFeliz = Color.green;
    private Color colorNeutral = Color.yellow;
    private Color colorEnojado = Color.red;

    void Start()
    {
        GenerarOrden();
        tiempoRestante = tiempoEsperaMaximo;
        StartCoroutine(ActualizarHumor());
    }

    void GenerarOrden()
    {
        ordenActual.Clear();
        int cantidadIngredientes = Random.Range(3, 6);
        for (int i = 0; i < cantidadIngredientes; i++)
        {
            string ingrediente = ingredientesDisponibles[Random.Range(0, ingredientesDisponibles.Count)];
            ordenActual.Add(ingrediente);
        }
        ordenCliente.text = "Orden: " + string.Join(", ", ordenActual);
        mensajeCliente.text = "¡Hola! Estoy esperando mi pedido...";
    }

    IEnumerator ActualizarHumor()
    {
        while (esperandoEntrega)
        {
            yield return new WaitForSeconds(1f);
            tiempoRestante -= 1f;

            if (tiempoRestante > tiempoEsperaMaximo * 0.5f)
            {
                clienteRenderer.material.color = colorFeliz;
            }
            else if (tiempoRestante > tiempoEsperaMaximo * 0.2f)
            {
                clienteRenderer.material.color = colorNeutral;
                mensajeCliente.text = "Por favor, ¿pueden apurarse?";
            }
            else
            {
                clienteRenderer.material.color = colorEnojado;
                mensajeCliente.text = "¡Esto está tardando demasiado!";
            }

            if (tiempoRestante <= 0)
            {
                mensajeCliente.text = "Ya no puedo esperar más, me voy...";
                esperandoEntrega = false;
                Destroy(gameObject, 2f); // El cliente se va después de 2 segundos
            }
        }
    }

    public void VerificarOrden(List<string> ingredientesJugador)
    {
        if (!esperandoEntrega || pedidoRecibido)
        {
            mensajeCliente.text = "¿Pasó algo con mi orden?";
            return;
        }

        bool ordenCorrecta = true;
        foreach (string ingrediente in ordenActual)
        {
            if (!ingredientesJugador.Contains(ingrediente))
            {
                ordenCorrecta = false;
                break;
            }
        }

        if (ordenCorrecta)
        {
            mensajeCliente.text = "¡Gracias! Esto es exactamente lo que pedí.";
            RecibirPedido();
        }
        else
        {
            mensajeCliente.text = "Esto no es lo que pedí. ¡Qué decepción!";
        }

        esperandoEntrega = false;
    }

    void RecibirPedido()
    {
        pedidoRecibido = true;

        if (pedidoPrefab != null)
        {
            GameObject pedidoInstanciado = Instantiate(pedidoPrefab);
            pedidoInstanciado.transform.SetParent(manoCliente);
            pedidoInstanciado.transform.localPosition = Vector3.zero;
            pedidoInstanciado.transform.localRotation = Quaternion.identity;
        }
    }

    void Update()
    {
        if (!esperandoEntrega || pedidoRecibido) return;

        if (Vector3.Distance(transform.position, Player.instance.transform.position) < rangoDeInteraccion)
        {
            if (Input.GetKeyDown(KeyCode.F))
            {
                Player player = Player.instance; // Referencia al script del jugador
                if (player.PedidoEnMano)
                {
                    VerificarOrden(player.ObtenerIngredientesPedido());
                }
                else
                {
                    mensajeCliente.text = "¿Pasó algo con mi orden?";
                }
            }
        }
    }
}
*/
/*using System.Collections.Generic;
using UnityEngine;

public class Cliente : MonoBehaviour
{
    public GameObject player; // Referencia al objeto del jugador
    public Transform manoCliente; // Posición en la mano del cliente para guardar el pedido
    private GameObject pedidoRecibido; // Pedido que el cliente tiene actualmente

    private List<string> ingredientesEsperados = new List<string>(); // Ingredientes de la orden
    private bool esperandoOrden = false;

    public void GenerarOrden(List<string> ingredientes)
    {
        ingredientesEsperados = ingredientes;
        esperandoOrden = true;
        Debug.Log("Cliente: ¡Quiero estos ingredientes! " + string.Join(", ", ingredientesEsperados));
    }

    void Update()
    {
        if (esperandoOrden && Vector3.Distance(player.transform.position, transform.position) <= 3f)
        {
            if (Input.GetKeyDown(KeyCode.F))
            {
                VerificarOrden();
            }
        }
    }

    public void VerificarOrden()
    {
        JugadorInteractuar jugador = player.GetComponent<JugadorInteractuar>();

        if (jugador != null)
        {
            if (jugador.PedidoEnMano())
            {
                List<string> ingredientesJugador = jugador.ObtenerIngredientesPedido();

                // Comparar ingredientes
                if (CompararIngredientes(ingredientesEsperados, ingredientesJugador))
                {
                    Debug.Log("Cliente: ¡Gracias, esto es exactamente lo que quería!");
                }
                else
                {
                    Debug.Log("Cliente: Esto no es lo que pedí...");
                }

                // Guardar el pedido en la mano del cliente
                pedidoRecibido = jugador.GetComponentInChildren<Transform>().gameObject;
                pedidoRecibido.transform.SetParent(manoCliente);
                pedidoRecibido.transform.localPosition = Vector3.zero;
            }
            else
            {
                Debug.Log("Cliente: ¿Pasó algo con mi orden?");
            }
        }
        else
        {
            Debug.LogError("El objeto Player no tiene el componente JugadorInteractuar.");
        }
    }

    private bool CompararIngredientes(List<string> esperados, List<string> entregados)
    {
        if (esperados.Count != entregados.Count) return false;

        foreach (string ingrediente in esperados)
        {
            if (!entregados.Contains(ingrediente)) return false;
        }

        return true;
    }
}

*/
/*using UnityEngine;

public class Cliente : MonoBehaviour
{
    public GameObject player;
    public Transform manoCliente;
    public Renderer clienteRenderer; // Para cambiar el color según el humor
    public Color colorFeliz = Color.green;
    public Color colorMolesto = Color.red;

    private string[] ingredientesEsperados;
    private GameObject pedidoRecibido;

    private float tiempoEspera = 0f;
    private float tiempoLimite = 120f;
    private bool esperandoOrden = false;

    void Update()
    {
        if (esperandoOrden)
        {
            tiempoEspera += Time.deltaTime;
            ActualizarColorHumor();

            if (Vector3.Distance(player.transform.position, transform.position) <= 3f && Input.GetKeyDown(KeyCode.F))
            {
                VerificarOrden();
            }
        }
    }

    public void GenerarOrden(string[] ingredientes)
    {
        ingredientesEsperados = ingredientes;
        esperandoOrden = true;
        Debug.Log("Cliente: ¡Quiero estos ingredientes! " + string.Join(", ", ingredientesEsperados));
    }

    public void VerificarOrden()
    {
        JugadorInteractuar jugador = player.GetComponent<JugadorInteractuar>();

        if (jugador != null)
        {
            if (jugador.PedidoEnMano())
            {
                string[] ingredientesJugador = jugador.ObtenerIngredientesPedido();

                if (CompararIngredientes(ingredientesEsperados, ingredientesJugador))
                {
                    Debug.Log("Cliente: ¡Gracias, esto es lo que quería!");
                    RecibirPedido(jugador);
                }
                else
                {
                    Debug.Log("Cliente: Esto no es lo que pedí...");
                }
            }
            else
            {
                Debug.Log("Cliente: ¿Pasó algo con mi orden?");
            }
        }
        else
        {
            Debug.LogError("El objeto Player no tiene el componente JugadorInteractuar.");
        }
    }

    public void RecibirPedido(JugadorInteractuar jugador)
    {
        pedidoRecibido = jugador.gameObject.GetComponentInChildren<Transform>().gameObject;
        pedidoRecibido.transform.SetParent(manoCliente);
        pedidoRecibido.transform.localPosition = Vector3.zero;
        esperandoOrden = false;
    }
    public void RecibirPedido(GameObject pedido)
    {
        if (pedido != null)
        {
            Order order = pedido.GetComponent<Order>();
            if (order != null)
            {
                string[] ingredientesPedido = order.GetIngredients();
                if (ingredientesPedido != null && ingredientesPedido.Length > 0)
                {
                    // Verificar ingredientes del pedido...
                    Debug.Log("Pedido recibido. Verificando...");
                }
                else
                {
                    Debug.Log("El pedido está vacío.");
                }
            }
        }
        else
        {
            Debug.Log("No hay pedido para procesar.");
        }
    }

    private bool CompararIngredientes(string[] esperados, string[] entregados)
    {
        if (esperados.Length != entregados.Length) return false;

        foreach (string ingrediente in esperados)
        {
            if (System.Array.IndexOf(entregados, ingrediente) == -1) return false;
        }
        return true;
    }

    private void ActualizarColorHumor()
    {
        if (clienteRenderer != null)
        {
            if (tiempoEspera <= tiempoLimite / 2)
            {
                clienteRenderer.material.color = colorFeliz;
            }
            else
            {
                clienteRenderer.material.color = colorMolesto;
            }
        }
    }
}
*/
/*using UnityEngine;

public class Cliente : MonoBehaviour
{
    public Transform manoCliente; // La posición de la mano del cliente para colocar el pedido
    public GameObject pedidoPrefab; // El prefab que representa visualmente el pedido
    private string[] ingredientesPedido; // Los ingredientes recibidos del pedido

    // Este método recibe los ingredientes del pedido
    public void RecibirPedido(string[] ingredientes)
    {
        if (ingredientes != null && ingredientes.Length > 0)
        {
            ingredientesPedido = ingredientes;
            // Puedes procesar los ingredientes aquí si lo necesitas

            Debug.Log("Pedido recibido. Ingredientes: " + string.Join(", ", ingredientes));

            // Instanciamos el prefab del pedido en la mano del cliente
            InstanciarPedido();
        }
        else
        {
            Debug.Log("Pedido vacío recibido.");
        }
    }

    // Instancia un prefab de pedido en la mano del cliente
    private void InstanciarPedido()
    {
        if (pedidoPrefab != null && manoCliente != null)
        {
            // Instanciar el prefab en la posición de la mano del cliente
            GameObject nuevoPedido = Instantiate(pedidoPrefab, manoCliente.position, manoCliente.rotation);
            nuevoPedido.transform.SetParent(manoCliente); // Hacemos que siga la mano del cliente
            nuevoPedido.transform.localPosition = Vector3.zero; // Colocamos el pedido en la mano
        }
    }
}
*/
/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Cliente : MonoBehaviour
{
    public List<string> ingredientesDisponibles = new List<string> { "carne", "tomate", "lechuga", "bebida", "Pan", "Pan_inf" };
    private List<string> ordenActual = new List<string>();

    public TextMeshPro mensajeCliente;
    public TextMeshPro ordenCliente;

    public Transform manoCliente;
    public GameObject pedidoPrefab;

    public Renderer clienteRenderer; // Cambiará de color según el humor
    public float rangoDeInteraccion = 3f;
    private bool esperandoEntrega = true;
    private bool pedidoRecibido = false;

    private float tiempoEsperaMaximo = 60f;
    private float tiempoRestante;

    private Color colorFeliz = Color.green;
    private Color colorNeutral = Color.yellow;
    private Color colorEnojado = Color.red;

    private string[] ingredientesPedido; // Ingredientes recibidos del pedido

    void Start()
    {
        GenerarOrden();
        tiempoRestante = tiempoEsperaMaximo;
        StartCoroutine(ActualizarHumor());
    }

    void GenerarOrden()
    {
        ordenActual.Clear();
        int cantidadIngredientes = Random.Range(3, 6);
        for (int i = 0; i < cantidadIngredientes; i++)
        {
            string ingrediente = ingredientesDisponibles[Random.Range(0, ingredientesDisponibles.Count)];
            ordenActual.Add(ingrediente);
        }
        ordenCliente.text = "Orden: " + string.Join(", ", ordenActual);
        mensajeCliente.text = "¡Hola! Estoy esperando mi pedido...";
    }

    IEnumerator ActualizarHumor()
    {
        while (esperandoEntrega)
        {
            yield return new WaitForSeconds(1f);
            tiempoRestante -= 1f;

            if (tiempoRestante > tiempoEsperaMaximo * 0.5f)
            {
                clienteRenderer.material.color = colorFeliz;
            }
            else if (tiempoRestante > tiempoEsperaMaximo * 0.2f)
            {
                clienteRenderer.material.color = colorNeutral;
                mensajeCliente.text = "Por favor, ¿pueden apurarse?";
            }
            else
            {
                clienteRenderer.material.color = colorEnojado;
                mensajeCliente.text = "¡Esto está tardando demasiado!";
            }

            if (tiempoRestante <= 0)
            {
                mensajeCliente.text = "Ya no puedo esperar más, me voy...";
                esperandoEntrega = false;
                Destroy(gameObject, 2f); // El cliente se va después de 2 segundos
            }
        }
    }

    public void VerificarOrden(List<string> ingredientesJugador)
    {
        if (!esperandoEntrega || pedidoRecibido)
        {
            mensajeCliente.text = "¿Pasó algo con mi orden?";
            return;
        }

        bool ordenCorrecta = true;
        foreach (string ingrediente in ordenActual)
        {
            if (!ingredientesJugador.Contains(ingrediente))
            {
                ordenCorrecta = false;
                break;
            }
        }

        if (ordenCorrecta)
        {
            mensajeCliente.text = "¡Gracias! Esto es exactamente lo que pedí.";
            RecibirPedido();
        }
        else
        {
            mensajeCliente.text = "Esto no es lo que pedí. ¡Qué decepción!";
        }

        esperandoEntrega = false;
    }

    void RecibirPedido()
    {
        pedidoRecibido = true;

        if (pedidoPrefab != null)
        {
            // Aquí instanciamos el pedido visual
            GameObject pedidoInstanciado = Instantiate(pedidoPrefab);
            pedidoInstanciado.transform.SetParent(manoCliente);
            pedidoInstanciado.transform.localPosition = Vector3.zero;
            pedidoInstanciado.transform.localRotation = Quaternion.identity;
        }
    }

    // Este método recibe los ingredientes del pedido
    public void RecibirPedido(string[] ingredientes)
    {
        if (ingredientes != null && ingredientes.Length > 0)
        {
            ingredientesPedido = ingredientes;
            // Puedes procesar los ingredientes aquí si lo necesitas

            Debug.Log("Pedido recibido. Ingredientes: " + string.Join(", ", ingredientes));

            // Instanciamos el prefab del pedido en la mano del cliente
            InstanciarPedido();
        }
        else
        {
            Debug.Log("Pedido vacío recibido.");
        }
    }

    // Instancia un prefab de pedido en la mano del cliente
    private void InstanciarPedido()
    {
        if (pedidoPrefab != null && manoCliente != null)
        {
            // Instanciar el prefab en la posición de la mano del cliente
            GameObject nuevoPedido = Instantiate(pedidoPrefab, manoCliente.position, manoCliente.rotation);
            nuevoPedido.transform.SetParent(manoCliente); // Hacemos que siga la mano del cliente
            nuevoPedido.transform.localPosition = Vector3.zero; // Colocamos el pedido en la mano
        }
    }

    void Update()
    {
        if (!esperandoEntrega || pedidoRecibido) return;

        if (Vector3.Distance(transform.position, Player.instance.transform.position) < rangoDeInteraccion)
        {
            if (Input.GetKeyDown(KeyCode.F))
            {
                Player player = Player.instance; // Referencia al script del jugador
                if (player.PedidoEnMano)
                {
                    VerificarOrden(player.ObtenerIngredientesPedido());
                }
                else
                {
                    mensajeCliente.text = "¿Pasó algo con mi orden?";
                }
            }
        }
    }
}
*/
/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Cliente : MonoBehaviour
{
    public List<string> ingredientesDisponibles = new List<string> { "carne", "tomate", "lechuga", "bebida", "Pan", "Pan_inf" };
    private List<string> ordenActual = new List<string>();

    public TextMeshPro mensajeCliente;
    public TextMeshPro ordenCliente;

    public Transform manoCliente;
    public GameObject pedidoPrefab;

    public Renderer clienteRenderer; // Cambiará de color según el humor
    public float rangoDeInteraccion = 3f;
    private bool esperandoEntrega = true;
    private bool pedidoRecibido = false;

    private float tiempoEsperaMaximo = 60f;
    private float tiempoRestante;

    private Color colorFeliz = Color.green;
    private Color colorNeutral = Color.yellow;
    private Color colorEnojado = Color.red;

    private string[] ingredientesPedido; // Ingredientes recibidos del pedido

    public Transform jugador; // Referencia al transform del jugador
    public InventarioJugador inventarioJugador; // Referencia al script del inventario del jugador

    void Start()
    {
        GenerarOrden();
        tiempoRestante = tiempoEsperaMaximo;
        StartCoroutine(ActualizarHumor());
    }

    void GenerarOrden()
    {
        ordenActual.Clear();
        int cantidadIngredientes = Random.Range(3, 6);
        for (int i = 0; i < cantidadIngredientes; i++)
        {
            string ingrediente = ingredientesDisponibles[Random.Range(0, ingredientesDisponibles.Count)];
            ordenActual.Add(ingrediente);
        }
        ordenCliente.text = "Orden: " + string.Join(", ", ordenActual);
        mensajeCliente.text = "¡Hola! Estoy esperando mi pedido...";
    }

    IEnumerator ActualizarHumor()
    {
        while (esperandoEntrega)
        {
            yield return new WaitForSeconds(1f);
            tiempoRestante -= 1f;

            if (tiempoRestante > tiempoEsperaMaximo * 0.5f)
            {
                clienteRenderer.material.color = colorFeliz;
            }
            else if (tiempoRestante > tiempoEsperaMaximo * 0.2f)
            {
                clienteRenderer.material.color = colorNeutral;
                mensajeCliente.text = "Por favor, ¿pueden apurarse?";
            }
            else
            {
                clienteRenderer.material.color = colorEnojado;
                mensajeCliente.text = "¡Esto está tardando demasiado!";
            }

            if (tiempoRestante <= 0)
            {
                mensajeCliente.text = "Ya no puedo esperar más, me voy...";
                esperandoEntrega = false;
                Destroy(gameObject, 2f); // El cliente se va después de 2 segundos
            }
        }
    }

    public void VerificarOrden(List<string> ingredientesJugador)
    {
        if (!esperandoEntrega || pedidoRecibido)
        {
            mensajeCliente.text = "¿Pasó algo con mi orden?";
            return;
        }

        bool ordenCorrecta = true;
        foreach (string ingrediente in ordenActual)
        {
            if (!ingredientesJugador.Contains(ingrediente))
            {
                ordenCorrecta = false;
                break;
            }
        }

        if (ordenCorrecta)
        {
            mensajeCliente.text = "¡Gracias! Esto es exactamente lo que pedí.";
            RecibirPedido();
        }
        else
        {
            mensajeCliente.text = "Esto no es lo que pedí. ¡Qué decepción!";
        }

        esperandoEntrega = false;
    }

    void RecibirPedido()
    {
        pedidoRecibido = true;

        if (pedidoPrefab != null)
        {
            GameObject pedidoInstanciado = Instantiate(pedidoPrefab);
            pedidoInstanciado.transform.SetParent(manoCliente);
            pedidoInstanciado.transform.localPosition = Vector3.zero;
            pedidoInstanciado.transform.localRotation = Quaternion.identity;
        }
    }

    private void InstanciarPedido()
    {
        if (pedidoPrefab != null && manoCliente != null)
        {
            GameObject nuevoPedido = Instantiate(pedidoPrefab, manoCliente.position, manoCliente.rotation);
            nuevoPedido.transform.SetParent(manoCliente);
            nuevoPedido.transform.localPosition = Vector3.zero;
        }
    }

    void Update()
    {
        if (!esperandoEntrega || pedidoRecibido) return;

        if (Vector3.Distance(transform.position, jugador.position) < rangoDeInteraccion)
        {
            if (Input.GetKeyDown(KeyCode.F))
            {
                if (inventarioJugador != null && inventarioJugador.PedidoEnMano)
                {
                    VerificarOrden(inventarioJugador.ObtenerIngredientesPedido());
                }
                else
                {
                    mensajeCliente.text = "¿Pasó algo con mi orden?";
                }
            }
        }
    }
}
*/
/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Cliente : MonoBehaviour
{
    public List<string> ingredientesDisponibles = new List<string> { "carne", "tomate", "lechuga", "bebida", "Pan", "Pan_inf" };
    private List<string> ordenActual = new List<string>();

    public TextMeshPro mensajeCliente;
    public TextMeshPro ordenCliente;

    public Transform manoCliente;
    public GameObject pedidoPrefab;

    public Renderer clienteRenderer; // Cambiará de color según el humor
    public float rangoDeInteraccion = 3f;
    private bool esperandoEntrega = true;
    private bool pedidoRecibido = false;

    private float tiempoEsperaMaximo = 60f;
    private float tiempoRestante;

    private Color colorFeliz = Color.green;
    private Color colorNeutral = Color.yellow;
    private Color colorEnojado = Color.red;

    void Start()
    {
        GenerarOrden();
        tiempoRestante = tiempoEsperaMaximo;
        StartCoroutine(ActualizarHumor());
    }

    void GenerarOrden()
    {
        ordenActual.Clear();
        int cantidadIngredientes = Random.Range(3, 6);
        for (int i = 0; i < cantidadIngredientes; i++)
        {
            string ingrediente = ingredientesDisponibles[Random.Range(0, ingredientesDisponibles.Count)];
            ordenActual.Add(ingrediente);
        }
        ordenCliente.text = "Orden: " + string.Join(", ", ordenActual);
        mensajeCliente.text = "¡Hola! Estoy esperando mi pedido...";
    }

    IEnumerator ActualizarHumor()
    {
        while (esperandoEntrega)
        {
            yield return new WaitForSeconds(1f);
            tiempoRestante -= 1f;

            if (tiempoRestante > tiempoEsperaMaximo * 0.5f)
            {
                clienteRenderer.material.color = colorFeliz;
            }
            else if (tiempoRestante > tiempoEsperaMaximo * 0.2f)
            {
                clienteRenderer.material.color = colorNeutral;
                mensajeCliente.text = "Por favor, ¿pueden apurarse?";
            }
            else
            {
                clienteRenderer.material.color = colorEnojado;
                mensajeCliente.text = "¡Esto está tardando demasiado!";
            }

            if (tiempoRestante <= 0)
            {
                mensajeCliente.text = "Ya no puedo esperar más, me voy...";
                esperandoEntrega = false;
                Destroy(gameObject, 2f); // El cliente se va después de 2 segundos
            }
        }
    }
    public Transform GetManoCliente()
    {
        return manoCliente;
    }
    public void VerificarOrden(List<string> ingredientesJugador)
    {
        if (!esperandoEntrega || pedidoRecibido)
        {
            mensajeCliente.text = "¿Pasó algo con mi orden?";
            return;
        }

        bool ordenCorrecta = true;
        foreach (string ingrediente in ordenActual)
        {
            if (!ingredientesJugador.Contains(ingrediente))
            {
                ordenCorrecta = false;
                break;
            }
        }

        if (ordenCorrecta)
        {
            mensajeCliente.text = "¡Gracias! Esto es exactamente lo que pedí.";
            RecibirPedido();
        }
        else
        {
            mensajeCliente.text = "Esto no es lo que pedí. ¡Qué decepción!";
        }

        esperandoEntrega = false;
    }

    void RecibirPedido()
    {
        pedidoRecibido = true;

        if (pedidoPrefab != null)
        {
            GameObject pedidoInstanciado = Instantiate(pedidoPrefab);
            pedidoInstanciado.transform.SetParent(manoCliente);
            pedidoInstanciado.transform.localPosition = Vector3.zero;
            pedidoInstanciado.transform.localRotation = Quaternion.identity;
        }
    }

    void Update()
    {
        if (!esperandoEntrega || pedidoRecibido) return;

        if (Vector3.Distance(transform.position, Player.instance.transform.position) < rangoDeInteraccion)
        {
            if (Input.GetKeyDown(KeyCode.F))
            {
                // Buscar el script "HamburgerInfo" o "Order" en el jugador
                HamburgerInfo hamburguesa = FindObjectOfType<HamburgerInfo>();
                if (hamburguesa != null && hamburguesa.ingredients.Count > 0)
                {
                    VerificarOrden(hamburguesa.ingredients);
                }
                else
                {
                    mensajeCliente.text = "No tienes un pedido para entregar.";
                }
            }
        }
    }
}
*/
/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Cliente : MonoBehaviour
{
    public List<string> ingredientesDisponibles = new List<string> { "carne", "tomate", "lechuga", "bebida", "Pan", "Pan_inf" };
    public List<string> ordenActual = new List<string>(); // Orden generada para comparar

    public TextMeshPro mensajeCliente;
    public TextMeshPro ordenCliente;

    public Transform manoCliente; // Donde aparecerá el pedido
    public GameObject pedidoPrefab; // Prefab visual del pedido

    public Renderer clienteRenderer; // Cambiará de color según el humor
    public float rangoDeInteraccion = 3f; // Distancia para interactuar con el cliente
    private bool esperandoEntrega = true; // Controla si el cliente sigue esperando
    private bool pedidoRecibido = false; // Controla si el cliente ya recibió su pedido

    private float tiempoEsperaMaximo = 60f; // Tiempo total que el cliente espera
    private float tiempoRestante;

    private Color colorFeliz = Color.green;
    private Color colorNeutral = Color.yellow;
    private Color colorEnojado = Color.red;

    void Start()
    {
        GenerarOrden();
        tiempoRestante = tiempoEsperaMaximo;
        StartCoroutine(ActualizarHumor());
    }

    void GenerarOrden()
    {
        ordenActual.Clear();
        int cantidadIngredientes = Random.Range(3, 6); // Orden de 3 a 5 ingredientes
        for (int i = 0; i < cantidadIngredientes; i++)
        {
            string ingrediente = ingredientesDisponibles[Random.Range(0, ingredientesDisponibles.Count)];
            ordenActual.Add(ingrediente);
        }
        ordenCliente.text = "Orden: " + string.Join(", ", ordenActual);
        mensajeCliente.text = "¡Hola! Estoy esperando mi pedido...";
    }

    IEnumerator ActualizarHumor()
    {
        while (esperandoEntrega)
        {
            yield return new WaitForSeconds(1f);
            tiempoRestante -= 1f;

            if (tiempoRestante > tiempoEsperaMaximo * 0.5f)
            {
                clienteRenderer.material.color = colorFeliz;
            }
            else if (tiempoRestante > tiempoEsperaMaximo * 0.2f)
            {
                clienteRenderer.material.color = colorNeutral;
                mensajeCliente.text = "Por favor, ¿pueden apurarse?";
            }
            else
            {
                clienteRenderer.material.color = colorEnojado;
                mensajeCliente.text = "¡Esto está tardando demasiado!";
            }

            if (tiempoRestante <= 0)
            {
                mensajeCliente.text = "Ya no puedo esperar más, me voy...";
                esperandoEntrega = false;
                Destroy(gameObject, 2f); // El cliente se va después de 2 segundos
            }
        }
    }

    public void VerificarOrden(List<string> ingredientesJugador)
    {
        if (!esperandoEntrega || pedidoRecibido)
        {
            mensajeCliente.text = "¿Pasó algo con mi orden?";
            return;
        }

        // Comparar los ingredientes entregados con la orden esperada
        if (EsPedidoCorrecto(ingredientesJugador))
        {
            mensajeCliente.text = "¡Gracias! Esto es exactamente lo que pedí.";
            RecibirPedido();
        }
        else
        {
            mensajeCliente.text = "Esto no es lo que pedí. ¡Qué decepción!";
        }

        esperandoEntrega = false;
    }

    private bool EsPedidoCorrecto(List<string> ingredientesJugador)
    {
        if (ingredientesJugador.Count != ordenActual.Count)
        {
            return false; // La cantidad de ingredientes no coincide
        }

        for (int i = 0; i < ordenActual.Count; i++)
        {
            if (ingredientesJugador[i] != ordenActual[i])
            {
                return false; // Algún ingrediente está mal o fuera de orden
            }
        }

        return true; // Todos los ingredientes coinciden y están en orden
    }

    void RecibirPedido()
    {
        pedidoRecibido = true;

        if (pedidoPrefab != null)
        {
            GameObject pedidoInstanciado = Instantiate(pedidoPrefab);
            pedidoInstanciado.transform.SetParent(manoCliente);
            pedidoInstanciado.transform.localPosition = Vector3.zero;
            pedidoInstanciado.transform.localRotation = Quaternion.identity;
        }
    }

    void Update()
    {
        if (!esperandoEntrega || pedidoRecibido) return;

        if (Vector3.Distance(transform.position, Player.instance.transform.position) < rangoDeInteraccion)
        {
            if (Input.GetKeyDown(KeyCode.F))
            {
                // Buscar el pedido en el jugador
                HamburgerInfo hamburguesa = FindObjectOfType<HamburgerInfo>();
                if (hamburguesa != null && hamburguesa.ingredients.Count > 0)
                {
                    VerificarOrden(hamburguesa.ingredients);
                }
                else
                {
                    mensajeCliente.text = "No tienes un pedido para entregar.";
                }
            }
        }
    }
}
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Cliente : MonoBehaviour
{
    public List<string> ingredientesDisponibles = new List<string> { "carne", "tomate", "lechuga", "bebida", "Pan", "Pan_inf" };
    public List<string> ordenActual = new List<string>(); // Orden generada para comparar

    public TextMeshPro mensajeCliente;
    public TextMeshPro ordenCliente;

    public Transform manoCliente; // Donde aparecerá el pedido decorativo
    public GameObject pedidoPrefab; // Prefab decorativo del pedido

    public Renderer clienteRenderer; // Cambiará de color según el humor
    public float rangoDeInteraccion = 3f; // Distancia para interactuar con el cliente
    private bool esperandoEntrega = true; // Controla si el cliente sigue esperando
    private bool pedidoRecibido = false; // Controla si el cliente ya recibió su pedido

    private float tiempoEsperaMaximo = 60f; // Tiempo total que el cliente espera
    private float tiempoRestante;

    private Color colorFeliz = Color.green;
    private Color colorNeutral = Color.yellow;
    private Color colorEnojado = Color.red;

    void Start()
    {
        GenerarOrden();
        tiempoRestante = tiempoEsperaMaximo;
        StartCoroutine(ActualizarHumor());
    }

    void GenerarOrden()
    {
        ordenActual.Clear();
        int cantidadIngredientes = Random.Range(3, 6); // Orden de 3 a 5 ingredientes
        for (int i = 0; i < cantidadIngredientes; i++)
        {
            string ingrediente = ingredientesDisponibles[Random.Range(0, ingredientesDisponibles.Count)];
            ordenActual.Add(ingrediente);
        }
        ordenCliente.text = "Orden: " + string.Join(", ", ordenActual);
        mensajeCliente.text = "¡Hola! Estoy esperando mi pedido...";

        // Instanciar el pedido decorativo en la mano del cliente
        if (pedidoPrefab != null && manoCliente != null)
        {
            GameObject pedidoDecorativo = Instantiate(pedidoPrefab, manoCliente);
            pedidoDecorativo.transform.localPosition = Vector3.zero;
            pedidoDecorativo.transform.localRotation = Quaternion.identity;
        }
    }

    IEnumerator ActualizarHumor()
    {
        while (esperandoEntrega)
        {
            yield return new WaitForSeconds(1f);
            tiempoRestante -= 1f;

            if (tiempoRestante > tiempoEsperaMaximo * 0.5f)
            {
                clienteRenderer.material.color = colorFeliz;
            }
            else if (tiempoRestante > tiempoEsperaMaximo * 0.2f)
            {
                clienteRenderer.material.color = colorNeutral;
                mensajeCliente.text = "Por favor, ¿pueden apurarse?";
            }
            else
            {
                clienteRenderer.material.color = colorEnojado;
                mensajeCliente.text = "¡Esto está tardando demasiado!";
            }

            if (tiempoRestante <= 0)
            {
                mensajeCliente.text = "Ya no puedo esperar más, me voy...";
                esperandoEntrega = false;
                Destroy(gameObject, 2f); // El cliente se va después de 2 segundos
            }
        }
    }

    public void VerificarOrden(List<string> ingredientesJugador)
    {
        if (!esperandoEntrega || pedidoRecibido)
        {
            mensajeCliente.text = "¿Pasó algo con mi orden?";
            return;
        }

        // Comparar los ingredientes entregados con la orden esperada
        if (EsPedidoCorrecto(ingredientesJugador))
        {
            mensajeCliente.text = "¡Gracias! Esto es exactamente lo que pedí.";
            pedidoRecibido = true;
        }
        else
        {
            mensajeCliente.text = "Esto no es lo que pedí. ¡Qué decepción!";
        }

        esperandoEntrega = false;
    }

    private bool EsPedidoCorrecto(List<string> ingredientesJugador)
    {
        if (ingredientesJugador.Count != ordenActual.Count)
        {
            return false; // La cantidad de ingredientes no coincide
        }

        for (int i = 0; i < ordenActual.Count; i++)
        {
            if (ingredientesJugador[i] != ordenActual[i])
            {
                return false; // Algún ingrediente está mal o fuera de orden
            }
        }

        return true; // Todos los ingredientes coinciden y están en orden
    }

    void Update()
    {
        if (!esperandoEntrega || pedidoRecibido) return;

        if (Vector3.Distance(transform.position, Player.instance.transform.position) < rangoDeInteraccion)
        {
            if (Input.GetKeyDown(KeyCode.F))
            {
                // Buscar el pedido en el jugador
                HamburgerInfo hamburguesa = FindObjectOfType<HamburgerInfo>();
                if (hamburguesa != null && hamburguesa.ingredients.Count > 0)
                {
                    VerificarOrden(hamburguesa.ingredients);
                }
                else
                {
                    mensajeCliente.text = "No tienes un pedido para entregar.";
                }
            }
        }
    }
}
