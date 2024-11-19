
/*using UnityEngine;

public class JugadorInteractuar : MonoBehaviour
{
    public float distanciaInteraccion = 3f; // Distancia máxima para interactuar
    public float radioDeteccion = 0.5f; // Radio de la esfera para detectar objetos en el suelo
    public Transform manoJugador; // Posición en la que el objeto se sostendrá en la mano
    private GameObject objetoEnMano = null; // Objeto que el jugador está sosteniendo

    public LayerMask capaInteractuable; // Capa para los objetos interactuables

    public PlanchaDeCocina planchaDeCocina;

    public float distanciaParaCocinar = 2f; // Distancia mínima para colocar la hamburguesa en la plancha

    void Update()
    {
        // Tomar y soltar objetos con la tecla "E"
        if (Input.GetKeyDown(KeyCode.E))
        {
            if (objetoEnMano == null)
            {
                IntentarTomarObjeto();
            }
            else
            {
                SoltarObjeto();
            }
        }

        // Colocar la hamburguesa en la plancha con la tecla "F"
        if (Input.GetKeyDown(KeyCode.F) && objetoEnMano != null && objetoEnMano.CompareTag("Hamburguesa"))
        {
            float distancia = Vector3.Distance(transform.position, planchaDeCocina.transform.position);
            if (distancia <= distanciaParaCocinar)
            {
                ColocarHamburguesaEnPlancha();
            }
            else
            {
                Debug.Log("Estás muy lejos de la plancha para colocar la hamburguesa.");
            }
        }
    }

    // Intentar tomar un objeto
    void IntentarTomarObjeto()
    {
        RaycastHit hit;
        Vector3 origen = transform.position + Vector3.up; // Aumentamos el origen para evitar que el rayo se quede muy bajo

        // Utilizamos SphereCast para detectar objetos en un área
        if (Physics.SphereCast(origen, radioDeteccion, transform.forward, out hit, distanciaInteraccion, capaInteractuable))
        {
            if (hit.collider != null)
            {
                GameObject objeto = hit.collider.gameObject;

                if (objeto.CompareTag("Hamburguesa"))
                {
                    TomarObjeto(objeto);
                }
                if (objeto.CompareTag("Fry"))
                {
                    TomarObjeto(objeto);
                }
            }
        }
    }

    // Tomar el objeto
    void TomarObjeto(GameObject objeto)
    {
        objetoEnMano = objeto;
        objetoEnMano.transform.SetParent(manoJugador); // Hacer que el objeto siga la mano del jugador
        objetoEnMano.transform.localPosition = Vector3.zero; // Colocarlo en la mano
        objetoEnMano.GetComponent<Rigidbody>().isKinematic = true; // Desactivar la física del objeto mientras lo sostenemos
    }

    // Soltar el objeto
    void SoltarObjeto()
    {
        objetoEnMano.transform.SetParent(null); // Dejar de seguir la mano del jugador
        objetoEnMano.GetComponent<Rigidbody>().isKinematic = false; // Reactivar la física
        objetoEnMano = null;
    }

    // Colocar la hamburguesa en la plancha
    void ColocarHamburguesaEnPlancha()
    {
        for (int i = 0; i < planchaDeCocina.cookingPositions.Length; i++)
        {
            if (planchaDeCocina.cookingPositions[i].childCount == 0)
            {
                planchaDeCocina.ColocarHamburguesa(objetoEnMano, i);
                objetoEnMano = null;
                break;
            }
        }
    }
}
*///salva vidas
/*using UnityEngine;

public class JugadorInteractuar : MonoBehaviour
{
    public float distanciaInteraccion = 3f; // Distancia máxima para interactuar
    public float radioDeteccion = 0.5f; // Radio de la esfera para detectar objetos en el suelo
    public Transform manoJugador; // Posición en la que el objeto se sostendrá en la mano
    private GameObject objetoEnMano = null; // Objeto que el jugador está sosteniendo

    public LayerMask capaInteractuable; // Capa para los objetos interactuables

    void Update()
    {
        // Tomar y soltar objetos con la tecla "E"
        if (Input.GetKeyDown(KeyCode.E))
        {
            if (objetoEnMano == null)
            {
                IntentarTomarObjeto();
            }
            else
            {
                SoltarObjeto();
            }
        }
    }

    // Intentar tomar un objeto
    void IntentarTomarObjeto()
    {
        RaycastHit hit;
        Vector3 origen = transform.position + Vector3.up; // Aumentamos el origen para evitar que el rayo se quede muy bajo

        // Utilizamos SphereCast para detectar objetos en un área
        if (Physics.SphereCast(origen, radioDeteccion, transform.forward, out hit, distanciaInteraccion, capaInteractuable))
        {
            if (hit.collider != null)
            {
                GameObject objeto = hit.collider.gameObject;

                if (objeto.CompareTag("Hamburguesa") || objeto.CompareTag("Fry") || objeto.CompareTag("Ingredient") || objeto.CompareTag("Money") || objeto.CompareTag("Order") || objeto.CompareTag("pedido") || objeto.CompareTag("TopBun"))
                {
                    TomarObjeto(objeto);//TopBun
                }
            }
        }
    }

    // Tomar el objeto
    void TomarObjeto(GameObject objeto)
    {
        objetoEnMano = objeto;
        objetoEnMano.transform.SetParent(manoJugador); // Hacer que el objeto siga la mano del jugador
        objetoEnMano.transform.localPosition = Vector3.zero; // Colocarlo en la mano
        objetoEnMano.GetComponent<Rigidbody>().isKinematic = true; // Desactivar la física del objeto mientras lo sostenemos
    }

    // Soltar el objeto
    void SoltarObjeto()
    {
        objetoEnMano.transform.SetParent(null); // Dejar de seguir la mano del jugador
        objetoEnMano.GetComponent<Rigidbody>().isKinematic = false; // Reactivar la física
        objetoEnMano = null;
    }
}

*/
/*using UnityEngine;

public class JugadorInteractuar : MonoBehaviour
{
    public float distanciaInteraccion = 3f; // Distancia máxima para interactuar
    public float radioDeteccion = 0.5f; // Radio de la esfera para detectar objetos en el suelo
    public Transform manoJugador; // Posición en la que el objeto se sostendrá en la mano
    private GameObject objetoEnMano = null; // Objeto que el jugador está sosteniendo

    public LayerMask capaInteractuable; // Capa para los objetos interactuables

    void Update()
    {
        // Tomar y soltar objetos con la tecla "E"
        if (Input.GetKeyDown(KeyCode.E))
        {
            if (objetoEnMano == null)
            {
                IntentarTomarObjeto();
            }
            else
            {
                SoltarObjeto();
            }
        }
    }

    // Intentar tomar un objeto
    void IntentarTomarObjeto()
    {
        RaycastHit hit;
        Vector3 origen = transform.position + Vector3.up; // Aumentamos el origen para evitar que el rayo se quede muy bajo

        // Utilizamos SphereCast para detectar objetos en un área
        if (Physics.SphereCast(origen, radioDeteccion, transform.forward, out hit, distanciaInteraccion, capaInteractuable))
        {
            if (hit.collider != null)
            {
                GameObject objeto = hit.collider.gameObject;

                if (objeto.CompareTag("Hamburguesa") || objeto.CompareTag("Fry") || objeto.CompareTag("Ingredient") ||
                    objeto.CompareTag("Money") || objeto.CompareTag("Order") || objeto.CompareTag("pedido") ||
                    objeto.CompareTag("TopBun"))
                {
                    TomarObjeto(objeto); //TopBun
                }
            }
        }
    }

    // Tomar el objeto
    void TomarObjeto(GameObject objeto)
    {
        objetoEnMano = objeto;
        objetoEnMano.transform.SetParent(manoJugador); // Hacer que el objeto siga la mano del jugador
        objetoEnMano.transform.localPosition = Vector3.zero; // Colocarlo en la mano
        objetoEnMano.GetComponent<Rigidbody>().isKinematic = true; // Desactivar la física del objeto mientras lo sostenemos
    }

    // Soltar el objeto
    void SoltarObjeto()
    {
        objetoEnMano.transform.SetParent(null); // Dejar de seguir la mano del jugador
        objetoEnMano.GetComponent<Rigidbody>().isKinematic = false; // Reactivar la física
        objetoEnMano = null;
    }

    // Verificar si el jugador tiene un pedido en la mano
    public bool PedidoEnMano()
    {
        if (objetoEnMano != null && objetoEnMano.CompareTag("pedido"))
        {
            return true;
        }
        return false;
    }

    // Obtener los ingredientes del pedido que el jugador está sosteniendo
    public System.Collections.Generic.List<string> ObtenerIngredientesPedido()
    {
        if (PedidoEnMano())
        {
            Pedido pedido = objetoEnMano.GetComponent<Pedido>();
            if (pedido != null)
            {
                return pedido.ObtenerIngredientes();
            }
        }
        return new System.Collections.Generic.List<string>();
    }
}
*/
/*using System.Collections.Generic;
using UnityEngine;

public class JugadorInteractuar : MonoBehaviour
{
    public float distanciaInteraccion = 3f; // Distancia máxima para interactuar
    public float radioDeteccion = 0.5f; // Radio de la esfera para detectar objetos en el suelo
    public Transform manoJugador; // Posición en la que el objeto se sostendrá en la mano
    private GameObject objetoEnMano = null; // Objeto que el jugador está sosteniendo

    public LayerMask capaInteractuable; // Capa para los objetos interactuables

    private List<string> ingredientesPedido = new List<string>();

    void Update()
    {
        // Tomar y soltar objetos con la tecla "E"
        if (Input.GetKeyDown(KeyCode.E))
        {
            if (objetoEnMano == null)
            {
                IntentarTomarObjeto();
            }
            else
            {
                SoltarObjeto();
            }
        }
    }

    // Intentar tomar un objeto
    void IntentarTomarObjeto()
    {
        RaycastHit hit;
        Vector3 origen = transform.position + Vector3.up; // Aumentamos el origen para evitar que el rayo se quede muy bajo

        // Utilizamos SphereCast para detectar objetos en un área
        if (Physics.SphereCast(origen, radioDeteccion, transform.forward, out hit, distanciaInteraccion, capaInteractuable))
        {
            if (hit.collider != null)
            {
                GameObject objeto = hit.collider.gameObject;

                if (objeto.CompareTag("Hamburguesa") || objeto.CompareTag("Fry") || objeto.CompareTag("Ingredient") || objeto.CompareTag("Money") || objeto.CompareTag("Order") || objeto.CompareTag("pedido") || objeto.CompareTag("TopBun"))
                {
                    TomarObjeto(objeto); // TopBun
                }
            }
        }
    }

    // Tomar el objeto
    void TomarObjeto(GameObject objeto)
    {
        objetoEnMano = objeto;
        objetoEnMano.transform.SetParent(manoJugador); // Hacer que el objeto siga la mano del jugador
        objetoEnMano.transform.localPosition = Vector3.zero; // Colocarlo en la mano
        objetoEnMano.GetComponent<Rigidbody>().isKinematic = true; // Desactivar la física del objeto mientras lo sostenemos

        // Si el objeto tiene ingredientes, los añadimos al pedido
        if (objeto.CompareTag("pedido"))
        {
            ingredientesPedido.Clear(); // Reiniciar ingredientes previos
            Pedido pedido = objeto.GetComponent<Pedido>();
            if (pedido != null)
            {
                ingredientesPedido.AddRange(pedido.ingredientes);
            }
        }
    }

    // Soltar el objeto
    void SoltarObjeto()
    {
        objetoEnMano.transform.SetParent(null); // Dejar de seguir la mano del jugador
        objetoEnMano.GetComponent<Rigidbody>().isKinematic = false; // Reactivar la física
        objetoEnMano = null;
        ingredientesPedido.Clear(); // Limpiar la lista de ingredientes al soltar
    }

    // Método para que el cliente obtenga los ingredientes del pedido
    public List<string> ObtenerIngredientesPedido()
    {
        return new List<string>(ingredientesPedido);
    }

    // Método para verificar si el jugador tiene un pedido en la mano
    public bool PedidoEnMano()
    {
        return objetoEnMano != null && objetoEnMano.CompareTag("pedido");
    }
}
*/
/*using UnityEngine;

public class JugadorInteractuar : MonoBehaviour
{
    public float distanciaInteraccion = 3f; // Distancia máxima para interactuar
    public float radioDeteccion = 0.5f; // Radio de la esfera para detectar objetos en el suelo
    public Transform manoJugador; // Posición en la que el objeto se sostendrá en la mano
    private GameObject objetoEnMano = null; // Objeto que el jugador está sosteniendo
    public LayerMask capaInteractuable; // Capa para los objetos interactuables

    void Update()
    {
        // Tomar y soltar objetos con la tecla "E"
        if (Input.GetKeyDown(KeyCode.E))
        {
            if (objetoEnMano == null)
            {
                IntentarTomarObjeto();
            }
            else
            {
                SoltarObjeto();
            }
        }
    }

    // Intentar tomar un objeto
    void IntentarTomarObjeto()
    {
        RaycastHit hit;
        Vector3 origen = transform.position + Vector3.up;

        if (Physics.SphereCast(origen, radioDeteccion, transform.forward, out hit, distanciaInteraccion, capaInteractuable))
        {
            if (hit.collider != null)
            {
                GameObject objeto = hit.collider.gameObject;

                if (objeto.CompareTag("pedido") || objeto.CompareTag("Hamburguesa"))
                {
                    TomarObjeto(objeto);
                }
            }
        }
    }

    // Tomar el objeto
    void TomarObjeto(GameObject objeto)
    {
        objetoEnMano = objeto;
        objetoEnMano.transform.SetParent(manoJugador);
        objetoEnMano.transform.localPosition = Vector3.zero;
        objetoEnMano.GetComponent<Rigidbody>().isKinematic = true;
    }

    // Soltar el objeto
    void SoltarObjeto()
    {
        objetoEnMano.transform.SetParent(null);
        objetoEnMano.GetComponent<Rigidbody>().isKinematic = false;
        objetoEnMano = null;
    }

    // Método para verificar si el jugador tiene un pedido en la mano
    public bool PedidoEnMano()
    {
        return objetoEnMano != null && objetoEnMano.CompareTag("pedido");
    }

    // Método para obtener los ingredientes del pedido actual
    public string[] ObtenerIngredientesPedido()
    {
        if (objetoEnMano != null)
        {
            HamburgerInfo info = objetoEnMano.GetComponent<HamburgerInfo>();
            if (info != null)
            {
                return info.ingredients.ToArray();
            }
        }
        return new string[0];
    }
}
*/
/*using UnityEngine;

public class JugadorInteractuar : MonoBehaviour
{
    public float distanciaInteraccion = 3f; // Distancia máxima para interactuar
    public float radioDeteccion = 0.5f; // Radio de la esfera para detectar objetos en el suelo
    public Transform manoJugador; // Posición en la que el objeto se sostendrá en la mano
    private GameObject objetoEnMano = null; // Objeto que el jugador está sosteniendo

    public LayerMask capaInteractuable; // Capa para los objetos interactuables

    void Update()
    {
        // Tomar y soltar objetos con la tecla "E"
        if (Input.GetKeyDown(KeyCode.E))
        {
            if (objetoEnMano == null)
            {
                IntentarTomarObjeto();
            }
            else
            {
                SoltarObjeto();
            }
        }

        // Interactuar con clientes con la tecla "F"
        if (Input.GetKeyDown(KeyCode.F))
        {
            InteractuarConCliente();
        }
    }

    // Intentar tomar un objeto
    void IntentarTomarObjeto()
    {
        RaycastHit hit;
        Vector3 origen = transform.position + Vector3.up; // Aumentamos el origen para evitar que el rayo se quede muy bajo

        // Utilizamos SphereCast para detectar objetos en un área
        if (Physics.SphereCast(origen, radioDeteccion, transform.forward, out hit, distanciaInteraccion, capaInteractuable))
        {
            if (hit.collider != null)
            {
                GameObject objeto = hit.collider.gameObject;

                // Comprobar si es un objeto interactuable
                if (objeto.CompareTag("Hamburguesa") || objeto.CompareTag("Fry") || objeto.CompareTag("Ingredient") ||
                    objeto.CompareTag("Money") || objeto.CompareTag("Order") || objeto.CompareTag("pedido") ||
                    objeto.CompareTag("TopBun"))
                {
                    TomarObjeto(objeto);
                }
            }
        }
    }

    // Tomar el objeto
    void TomarObjeto(GameObject objeto)
    {
        objetoEnMano = objeto;
        objetoEnMano.transform.SetParent(manoJugador); // Hacer que el objeto siga la mano del jugador
        objetoEnMano.transform.localPosition = Vector3.zero; // Colocarlo en la mano
        objetoEnMano.GetComponent<Rigidbody>().isKinematic = true; // Desactivar la física del objeto mientras lo sostenemos
    }

    // Soltar el objeto
    void SoltarObjeto()
    {
        if (objetoEnMano != null)
        {
            objetoEnMano.transform.SetParent(null); // Dejar de seguir la mano del jugador
            objetoEnMano.GetComponent<Rigidbody>().isKinematic = false; // Reactivar la física
            objetoEnMano = null;
        }
    }

    // Interactuar con un cliente
    void InteractuarConCliente()
    {
        RaycastHit hit;
        Vector3 origen = transform.position + Vector3.up; // Aumentamos el origen para evitar que el rayo se quede muy bajo

        // Detectar clientes en un área
        if (Physics.SphereCast(origen, radioDeteccion, transform.forward, out hit, distanciaInteraccion, capaInteractuable))
        {
            if (hit.collider != null)
            {
                GameObject objeto = hit.collider.gameObject;

                // Comprobar si es un cliente
                if (objeto.CompareTag("Cliente"))
                {
                    Cliente cliente = objeto.GetComponent<Cliente>();
                    if (cliente != null)
                    {
                        // Llamar al método de interacción del cliente
                        cliente.RecibirPedido(objetoEnMano);
                    }
                }
            }
        }
    }
}
*/
/*using UnityEngine;

public class JugadorInteractuar : MonoBehaviour
{
    public float distanciaInteraccion = 3f; // Distancia máxima para interactuar
    public float radioDeteccion = 0.5f; // Radio de la esfera para detectar objetos en el suelo
    public Transform manoJugador; // Posición en la que el objeto se sostendrá en la mano
    private GameObject objetoEnMano = null; // Objeto que el jugador está sosteniendo

    public LayerMask capaInteractuable; // Capa para los objetos interactuables

    void Update()
    {
        // Tomar y soltar objetos con la tecla "E"
        if (Input.GetKeyDown(KeyCode.E))
        {
            if (objetoEnMano == null)
            {
                IntentarTomarObjeto();
            }
            else
            {
                SoltarObjeto();
            }
        }

        // Interactuar con clientes con la tecla "F"
        if (Input.GetKeyDown(KeyCode.F))
        {
            InteractuarConCliente();
        }
    }

    // Intentar tomar un objeto
    void IntentarTomarObjeto()
    {
        RaycastHit hit;
        Vector3 origen = transform.position + Vector3.up; // Aumentamos el origen para evitar que el rayo se quede muy bajo

        // Utilizamos SphereCast para detectar objetos en un área
        if (Physics.SphereCast(origen, radioDeteccion, transform.forward, out hit, distanciaInteraccion, capaInteractuable))
        {
            if (hit.collider != null)
            {
                GameObject objeto = hit.collider.gameObject;

                // Comprobar si es un objeto interactuable
                if (objeto.CompareTag("Hamburguesa") || objeto.CompareTag("Fry") || objeto.CompareTag("Ingredient") ||
                    objeto.CompareTag("Money") || objeto.CompareTag("Order") || objeto.CompareTag("pedido") ||
                    objeto.CompareTag("TopBun"))
                {
                    TomarObjeto(objeto);
                }
            }
        }
    }

    // Tomar el objeto
    void TomarObjeto(GameObject objeto)
    {
        objetoEnMano = objeto;
        objetoEnMano.transform.SetParent(manoJugador); // Hacer que el objeto siga la mano del jugador
        objetoEnMano.transform.localPosition = Vector3.zero; // Colocarlo en la mano
        objetoEnMano.GetComponent<Rigidbody>().isKinematic = true; // Desactivar la física del objeto mientras lo sostenemos
    }

    // Soltar el objeto
    void SoltarObjeto()
    {
        if (objetoEnMano != null)
        {
            objetoEnMano.transform.SetParent(null); // Dejar de seguir la mano del jugador
            objetoEnMano.GetComponent<Rigidbody>().isKinematic = false; // Reactivar la física
            objetoEnMano = null;
        }
    }

    // Interactuar con un cliente
    void InteractuarConCliente()
    {
        RaycastHit hit;
        Vector3 origen = transform.position + Vector3.up; // Aumentamos el origen para evitar que el rayo se quede muy bajo

        // Detectar clientes en un área
        if (Physics.SphereCast(origen, radioDeteccion, transform.forward, out hit, distanciaInteraccion, capaInteractuable))
        {
            if (hit.collider != null)
            {
                GameObject objeto = hit.collider.gameObject;

                // Comprobar si es un cliente
                if (objeto.CompareTag("Cliente"))
                {
                    Cliente cliente = objeto.GetComponent<Cliente>();
                    if (cliente != null)
                    {
                        // Llamar al método de interacción del cliente
                        cliente.RecibirPedido(objetoEnMano);
                    }
                }
            }
        }
    }

    // Método para obtener los ingredientes del objeto en la mano
    public string[] ObtenerIngredientesPedido()
    {
        if (objetoEnMano != null)
        {
            Order order = objetoEnMano.GetComponent<Order>();
            if (order != null)
            {
                return order.GetIngredients();
            }
        }
        return null; // Si no hay objeto o no es un pedido
    }
}
*/
/*using UnityEngine;

public class JugadorInteractuar : MonoBehaviour
{
    public float distanciaInteraccion = 3f; // Distancia máxima para interactuar
    public float radioDeteccion = 0.5f; // Radio de la esfera para detectar objetos en el suelo
    public Transform manoJugador; // Posición en la que el objeto se sostendrá en la mano
    private GameObject objetoEnMano = null; // Objeto que el jugador está sosteniendo

    public LayerMask capaInteractuable; // Capa para los objetos interactuables

    void Update()
    {
        // Tomar y soltar objetos con la tecla "E"
        if (Input.GetKeyDown(KeyCode.E))
        {
            if (objetoEnMano == null)
            {
                IntentarTomarObjeto();
            }
            else
            {
                SoltarObjeto();
            }
        }

        // Interactuar con clientes con la tecla "F"
        if (Input.GetKeyDown(KeyCode.F))
        {
            InteractuarConCliente();
        }
    }

    // Intentar tomar un objeto
    void IntentarTomarObjeto()
    {
        RaycastHit hit;
        Vector3 origen = transform.position + Vector3.up; // Aumentamos el origen para evitar que el rayo se quede muy bajo

        // Utilizamos SphereCast para detectar objetos en un área
        if (Physics.SphereCast(origen, radioDeteccion, transform.forward, out hit, distanciaInteraccion, capaInteractuable))
        {
            if (hit.collider != null)
            {
                GameObject objeto = hit.collider.gameObject;

                // Comprobar si es un objeto interactuable
                if (objeto.CompareTag("Hamburguesa") || objeto.CompareTag("Fry") || objeto.CompareTag("Ingredient") ||
                    objeto.CompareTag("Money") || objeto.CompareTag("Order") || objeto.CompareTag("pedido") ||
                    objeto.CompareTag("TopBun"))
                {
                    TomarObjeto(objeto);
                }
            }
        }
    }

    // Tomar el objeto
    void TomarObjeto(GameObject objeto)
    {
        objetoEnMano = objeto;
        objetoEnMano.transform.SetParent(manoJugador); // Hacer que el objeto siga la mano del jugador
        objetoEnMano.transform.localPosition = Vector3.zero; // Colocarlo en la mano
        objetoEnMano.GetComponent<Rigidbody>().isKinematic = true; // Desactivar la física del objeto mientras lo sostenemos
    }

    // Soltar el objeto
    void SoltarObjeto()
    {
        if (objetoEnMano != null)
        {
            objetoEnMano.transform.SetParent(null); // Dejar de seguir la mano del jugador
            objetoEnMano.GetComponent<Rigidbody>().isKinematic = false; // Reactivar la física
            objetoEnMano = null;
        }
    }

    // Interactuar con un cliente
    void InteractuarConCliente()
    {
        RaycastHit hit;
        Vector3 origen = transform.position + Vector3.up; // Aumentamos el origen para evitar que el rayo se quede muy bajo

        // Detectar clientes en un área
        if (Physics.SphereCast(origen, radioDeteccion, transform.forward, out hit, distanciaInteraccion, capaInteractuable))
        {
            if (hit.collider != null)
            {
                GameObject objeto = hit.collider.gameObject;

                // Comprobar si es un cliente
                if (objeto.CompareTag("Cliente"))
                {
                    Cliente cliente = objeto.GetComponent<Cliente>();
                    if (cliente != null)
                    {
                        // Llamar al método de interacción del cliente
                        cliente.RecibirPedido(objetoEnMano);
                    }
                }
            }
        }
    }
    // Interactuar con un cliente
    void InteractuarConCliente()
    {
        RaycastHit hit;
        Vector3 origen = transform.position + Vector3.up;

        if (Physics.SphereCast(origen, radioDeteccion, transform.forward, out hit, distanciaInteraccion, capaInteractuable))
        {
            if (hit.collider != null)
            {
                GameObject objeto = hit.collider.gameObject;

                if (objeto.CompareTag("Cliente"))
                {
                    Cliente cliente = objeto.GetComponent<Cliente>();
                    if (cliente != null)
                    {
                        cliente.RecibirPedido(PedidoEnMano);
                    }
                }
            }
        }
    }

    // Método para obtener los ingredientes del objeto en la mano
    public string[] ObtenerIngredientesPedido()
    {
        if (objetoEnMano != null)
        {
            Order order = objetoEnMano.GetComponent<Order>();
            if (order != null)
            {
                return order.GetIngredients();
            }
        }
        return null; // Si no hay objeto o no es un pedido
    }

    // Propiedad para verificar si el objeto en mano es un pedido
    public GameObject PedidoEnMano
    {
        get
        {
            if (objetoEnMano != null && objetoEnMano.GetComponent<Order>() != null)
            {
                return objetoEnMano;
            }
            return null;
        }
    }
}
*/
/*using UnityEngine;

public class JugadorInteractuar : MonoBehaviour
{
    public float distanciaInteraccion = 3f; // Distancia máxima para interactuar
    public float radioDeteccion = 0.5f; // Radio de la esfera para detectar objetos en el suelo
    public Transform manoJugador; // Posición en la que el objeto se sostendrá en la mano
    private GameObject objetoEnMano = null; // Objeto que el jugador está sosteniendo

    public LayerMask capaInteractuable; // Capa para los objetos interactuables
    public GameObject PedidoEnMano; // Pedido en la mano del jugador

    void Update()
    {
        // Tomar y soltar objetos con la tecla "E"
        if (Input.GetKeyDown(KeyCode.E))
        {
            if (objetoEnMano == null)
            {
                IntentarTomarObjeto();
            }
            else
            {
                SoltarObjeto();
            }
        }

        // Interactuar con el cliente cuando el jugador está cerca
        if (Input.GetKeyDown(KeyCode.F))
        {
            InteractuarConCliente();
        }
    }

    // Intentar tomar un objeto
    void IntentarTomarObjeto()
    {
        RaycastHit hit;
        Vector3 origen = transform.position + Vector3.up; // Aumentamos el origen para evitar que el rayo se quede muy bajo

        // Utilizamos SphereCast para detectar objetos en un área
        if (Physics.SphereCast(origen, radioDeteccion, transform.forward, out hit, distanciaInteraccion, capaInteractuable))
        {
            if (hit.collider != null)
            {
                GameObject objeto = hit.collider.gameObject;

                if (objeto.CompareTag("Hamburguesa") || objeto.CompareTag("Fry") || objeto.CompareTag("Ingredient") || objeto.CompareTag("Money") || objeto.CompareTag("Order") || objeto.CompareTag("pedido") || objeto.CompareTag("TopBun"))
                {
                    TomarObjeto(objeto); // Tomar el objeto
                }
            }
        }
    }

    // Tomar el objeto
    void TomarObjeto(GameObject objeto)
    {
        objetoEnMano = objeto;
        objetoEnMano.transform.SetParent(manoJugador); // Hacer que el objeto siga la mano del jugador
        objetoEnMano.transform.localPosition = Vector3.zero; // Colocarlo en la mano
        objetoEnMano.GetComponent<Rigidbody>().isKinematic = true; // Desactivar la física del objeto mientras lo sostenemos
        PedidoEnMano = objeto; // Guardar el objeto del pedido
    }

    // Soltar el objeto
    void SoltarObjeto()
    {
        objetoEnMano.transform.SetParent(null); // Dejar de seguir la mano del jugador
        objetoEnMano.GetComponent<Rigidbody>().isKinematic = false; // Reactivar la física
        objetoEnMano = null;
        PedidoEnMano = null; // Limpiar el pedido en la mano
    }

    // Interactuar con el cliente
    void InteractuarConCliente()
    {
        RaycastHit hit;
        Vector3 origen = transform.position + Vector3.up;

        if (Physics.SphereCast(origen, radioDeteccion, transform.forward, out hit, distanciaInteraccion, capaInteractuable))
        {
            if (hit.collider != null)
            {
                GameObject objeto = hit.collider.gameObject;

                if (objeto.CompareTag("Cliente"))
                {
                    Cliente cliente = objeto.GetComponent<Cliente>();
                    if (cliente != null && PedidoEnMano != null) // Verificamos que el jugador tenga un pedido
                    {
                        // Pasamos solo la información del pedido, no el objeto completo
                        Order order = PedidoEnMano.GetComponent<Order>();
                        if (order != null)
                        {
                            string[] ingredientesPedido = order.GetIngredients();
                            cliente.RecibirPedido(ingredientesPedido);  // Enviamos los ingredientes al cliente
                        }
                    }
                }
            }
        }
    }
}
*/
/*using UnityEngine;

public class JugadorInteractuar : MonoBehaviour
{
    public float distanciaInteraccion = 3f; // Distancia máxima para interactuar
    public float radioDeteccion = 0.5f; // Radio de la esfera para detectar objetos en el suelo
    public Transform manoJugador; // Posición en la que el objeto se sostendrá en la mano
    private GameObject objetoEnMano = null; // Objeto que el jugador está sosteniendo

    public LayerMask capaInteractuable; // Capa para los objetos interactuables
    public GameObject PedidoEnMano; // Pedido en la mano del jugador

    void Update()
    {
        // Tomar y soltar objetos con la tecla "E"
        if (Input.GetKeyDown(KeyCode.E))
        {
            if (objetoEnMano == null)
            {
                IntentarTomarObjeto();
            }
            else
            {
                SoltarObjeto();
            }
        }

        // Interactuar con el cliente cuando el jugador está cerca
        if (Input.GetKeyDown(KeyCode.F))
        {
            InteractuarConCliente();
        }
    }

    // Intentar tomar un objeto
    void IntentarTomarObjeto()
    {
        RaycastHit hit;
        Vector3 origen = transform.position + Vector3.up; // Aumentamos el origen para evitar que el rayo se quede muy bajo

        // Utilizamos SphereCast para detectar objetos en un área
        if (Physics.SphereCast(origen, radioDeteccion, transform.forward, out hit, distanciaInteraccion, capaInteractuable))
        {
            if (hit.collider != null)
            {
                GameObject objeto = hit.collider.gameObject;

                if (objeto.CompareTag("Hamburguesa") || objeto.CompareTag("Fry") || objeto.CompareTag("Ingredient") ||
                    objeto.CompareTag("Money") || objeto.CompareTag("Order") || objeto.CompareTag("pedido") || objeto.CompareTag("TopBun"))
                {
                    TomarObjeto(objeto); // Tomar el objeto
                }
            }
        }
    }

    // Tomar el objeto
    void TomarObjeto(GameObject objeto)
    {
        objetoEnMano = objeto;
        objetoEnMano.transform.SetParent(manoJugador); // Hacer que el objeto siga la mano del jugador
        objetoEnMano.transform.localPosition = Vector3.zero; // Colocarlo en la mano
        Rigidbody rb = objetoEnMano.GetComponent<Rigidbody>();
        if (rb != null)
        {
            rb.isKinematic = true; // Desactivar la física del objeto mientras lo sostenemos
        }
        PedidoEnMano = objeto; // Guardar el objeto del pedido
    }

    // Soltar el objeto
    void SoltarObjeto()
    {
        if (objetoEnMano != null)
        {
            objetoEnMano.transform.SetParent(null); // Dejar de seguir la mano del jugador
            Rigidbody rb = objetoEnMano.GetComponent<Rigidbody>();
            if (rb != null)
            {
                rb.isKinematic = false; // Reactivar la física
            }
            objetoEnMano = null;
        }
        PedidoEnMano = null; // Limpiar el pedido en la mano
    }

    // Interactuar con el cliente
    void InteractuarConCliente()
    {
        RaycastHit hit;
        Vector3 origen = transform.position + Vector3.up;

        if (Physics.SphereCast(origen, radioDeteccion, transform.forward, out hit, distanciaInteraccion, capaInteractuable))
        {
            if (hit.collider != null)
            {
                GameObject objeto = hit.collider.gameObject;

                if (objeto.CompareTag("Cliente"))
                {
                    Cliente cliente = objeto.GetComponent<Cliente>();
                    if (cliente != null && PedidoEnMano != null) // Verificamos que el jugador tenga un pedido
                    {
                        // Pasamos solo la información del pedido, no el objeto completo
                        HamburgerInfo hamburguesaInfo = PedidoEnMano.GetComponent<HamburgerInfo>();
                        if (hamburguesaInfo != null)
                        {
                            // Pasar ingredientes al cliente para su verificación
                            cliente.VerificarOrden(hamburguesaInfo.ingredients);
                        }
                        else
                        {
                            Debug.LogWarning("El pedido no contiene información válida.");
                        }
                    }
                    else
                    {
                        Debug.Log("No tienes un pedido para entregar.");
                    }
                }
            }
        }
    }
}
*/
using UnityEngine;

public class JugadorInteractuar : MonoBehaviour
{
    public float distanciaInteraccion = 3f; // Distancia máxima para interactuar
    public float radioDeteccion = 0.5f; // Radio de la esfera para detectar objetos en el suelo
    public Transform manoJugador; // Posición en la que el objeto se sostendrá en la mano
    private GameObject objetoEnMano = null; // Objeto que el jugador está sosteniendo

    public LayerMask capaInteractuable; // Capa para los objetos interactuables
    public GameObject PedidoEnMano; // Pedido en la mano del jugador

    public GameObject prefabPedido; // Prefab del pedido que se spawneará en la mano del cliente

    void Update()
    {
        // Tomar y soltar objetos con la tecla "E"
        if (Input.GetKeyDown(KeyCode.E))
        {
            if (objetoEnMano == null)
            {
                IntentarTomarObjeto();
            }
            else
            {
                SoltarObjeto();
            }
        }

        // Interactuar con el cliente cuando el jugador está cerca
        if (Input.GetKeyDown(KeyCode.F))
        {
            InteractuarConCliente();
        }
    }

    // Intentar tomar un objeto
    void IntentarTomarObjeto()
    {
        RaycastHit hit;
        Vector3 origen = transform.position + Vector3.up; // Aumentamos el origen para evitar que el rayo se quede muy bajo

        // Utilizamos SphereCast para detectar objetos en un área
        if (Physics.SphereCast(origen, radioDeteccion, transform.forward, out hit, distanciaInteraccion, capaInteractuable))
        {
            if (hit.collider != null)
            {
                GameObject objeto = hit.collider.gameObject;

                if (objeto.CompareTag("Hamburguesa") || objeto.CompareTag("Fry") || objeto.CompareTag("Ingredient") ||
                    objeto.CompareTag("Money") || objeto.CompareTag("Order") || objeto.CompareTag("pedido") || objeto.CompareTag("TopBun"))
                {
                    TomarObjeto(objeto); // Tomar el objeto
                }
            }
        }
    }

    // Tomar el objeto
    void TomarObjeto(GameObject objeto)
    {
        objetoEnMano = objeto;
        objetoEnMano.transform.SetParent(manoJugador); // Hacer que el objeto siga la mano del jugador
        objetoEnMano.transform.localPosition = Vector3.zero; // Colocarlo en la mano
        Rigidbody rb = objetoEnMano.GetComponent<Rigidbody>();
        if (rb != null)
        {
            rb.isKinematic = true; // Desactivar la física del objeto mientras lo sostenemos
        }
        PedidoEnMano = objeto; // Guardar el objeto del pedido
    }

    // Soltar el objeto
    void SoltarObjeto()
    {
        if (objetoEnMano != null)
        {
            objetoEnMano.transform.SetParent(null); // Dejar de seguir la mano del jugador
            Rigidbody rb = objetoEnMano.GetComponent<Rigidbody>();
            if (rb != null)
            {
                rb.isKinematic = false; // Reactivar la física
            }
            objetoEnMano = null;
        }
        PedidoEnMano = null; // Limpiar el pedido en la mano
    }

    // Interactuar con el cliente
    void InteractuarConCliente()
    {
        RaycastHit hit;
        Vector3 origen = transform.position + Vector3.up;

        if (Physics.SphereCast(origen, radioDeteccion, transform.forward, out hit, distanciaInteraccion, capaInteractuable))
        {
            if (hit.collider != null)
            {
                GameObject objeto = hit.collider.gameObject;

                if (objeto.CompareTag("Cliente"))
                {
                    Cliente cliente = objeto.GetComponent<Cliente>();
                    if (cliente != null)
                    {
                        if (PedidoEnMano != null) // Solo interactuar si tienes un pedido
                        {
                            // Obtener información del pedido
                            HamburgerInfo hamburguesaInfo = PedidoEnMano.GetComponent<HamburgerInfo>();
                            if (hamburguesaInfo != null)
                            {
                                // Pasar los ingredientes al cliente
                                cliente.VerificarOrden(hamburguesaInfo.ingredients);

                                // Spawn del pedido en la mano del cliente
                                Transform manoCliente = cliente.GetManoCliente();
                                if (manoCliente != null)
                                {
                                    GameObject pedidoEnManoCliente = Instantiate(prefabPedido, manoCliente.position, manoCliente.rotation);
                                    pedidoEnManoCliente.transform.SetParent(manoCliente); // Asegurar que el objeto siga la mano del cliente
                                }

                                // Soltar el pedido del jugador
                                SoltarObjeto();
                            }
                        }
                        else
                        {
                            Debug.Log("No tienes un pedido para entregar.");
                        }
                    }
                }
            }
        }
    }
}
