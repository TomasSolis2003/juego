using UnityEngine;

public class Order : MonoBehaviour
{
    private string[] ingredients;

    // M�todo para establecer los ingredientes en la orden
    public void SetIngredients(string[] orderIngredients)
    {
        ingredients = orderIngredients;
    }

    // M�todo para obtener los ingredientes de la orden
    public string[] GetIngredients()
    {
        return ingredients;
    }
}
