using UnityEngine;

public class Order : MonoBehaviour
{
    private string[] ingredients;

    // Método para establecer los ingredientes en la orden
    public void SetIngredients(string[] orderIngredients)
    {
        ingredients = orderIngredients;
    }

    // Método para obtener los ingredientes de la orden
    public string[] GetIngredients()
    {
        return ingredients;
    }
}
