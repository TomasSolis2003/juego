using System.Collections.Generic;
using UnityEngine;

public class Pedido : MonoBehaviour
{
    public List<string> ingredientes = new List<string>();

    public List<string> ObtenerIngredientes()
    {
        return ingredientes;
    }
}
