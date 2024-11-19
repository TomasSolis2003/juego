/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jugador : MonoBehaviour
{
    public List<string> ingredientesJugador = new List<string>();

    // Este método sería llamado cuando el jugador seleccione los ingredientes
    public void AgregarIngrediente(string ingrediente)
    {
        ingredientesJugador.Add(ingrediente);
    }
}

*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public static Player instance;


    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject); // Si ya hay una instancia, destrúyela
        }
    }

    void Update()
    {

        // Lógica para el jugador, como moverse o interactuar con objetos
    }

}
