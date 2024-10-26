/*using UnityEngine;

public class FryCoocking : MonoBehaviour
{
    public enum FryState
    {
        Raw,
        LightlyCooked,
        Cooked,
        Burnt
    }

    public FryState currentState = FryState.Raw;
    public float cookingTime = 10f; // Tiempo total para llegar al estado "Cooked"
    public float burntTime = 15f; // Tiempo total para llegar al estado "Burnt"
    public bool isCooking = false;

    private float currentCookingTime = 0f;

    void Update()
    {
        if (isCooking && currentState != FryState.Burnt)
        {
            currentCookingTime += Time.deltaTime;

            if (currentCookingTime >= burntTime)
            {
                ChangeState(FryState.Burnt);
            }
            else if (currentCookingTime >= cookingTime)
            {
                ChangeState(FryState.Cooked);
            }
            else if (currentCookingTime >= cookingTime / 2f)
            {
                ChangeState(FryState.LightlyCooked);
            }
        }
    }

    public void StartCooking()
    {
        isCooking = true;
    }

    public void StopCooking()
    {
        isCooking = false;
    }

    void ChangeState(FryState newState)
    {
        currentState = newState;
        UpdateFryAppearance();
    }

    void UpdateFryAppearance()
    {
        Renderer renderer = GetComponent<Renderer>();

        switch (currentState)
        {
            case FryState.Raw:
                renderer.material.color = Color.white; // Color crudo
                break;
            case FryState.LightlyCooked:
                renderer.material.color = Color.yellow; // Color ligeramente cocido
                break;
            case FryState.Cooked:
                renderer.material.color = Color.grey; // Color cocido
                break;
            case FryState.Burnt:
                renderer.material.color = Color.black; // Color quemado
                break;
        }
    }

    public void ResetCooking()
    {
        currentCookingTime = 0f;
        ChangeState(FryState.Raw);
        isCooking = false;
    }
}

*/
using UnityEngine;

public class FryCooking : MonoBehaviour
{
    public enum FryState
    {
        Raw,
        LightlyCooked,
        Cooked,
        Burnt
    }

    public FryState currentState = FryState.Raw;
    public float cookingTime = 10f; // Tiempo total para llegar al estado "Cooked"
    public float burntTime = 15f; // Tiempo total para llegar al estado "Burnt"
    public bool isCooking = false;

    private float currentCookingTime = 0f;

    void Update()
    {
        if (isCooking && currentState != FryState.Burnt)
        {
            currentCookingTime += Time.deltaTime;

            if (currentCookingTime >= burntTime)
            {
                ChangeState(FryState.Burnt);
            }
            else if (currentCookingTime >= cookingTime)
            {
                ChangeState(FryState.Cooked);
            }
            else if (currentCookingTime >= cookingTime / 2f)
            {
                ChangeState(FryState.LightlyCooked);
            }
        }
    }

    public void StartCooking()
    {
        isCooking = true;
    }

    public void StopCooking()
    {
        isCooking = false;
    }

    void ChangeState(FryState newState)
    {
        currentState = newState;
        UpdateFryAppearance();
    }

    void UpdateFryAppearance()
    {
        Renderer renderer = GetComponent<Renderer>();

        switch (currentState)
        {
            case FryState.Raw:
                renderer.material.color = Color.white; // Color crudo
                break;
            case FryState.LightlyCooked:
                renderer.material.color = Color.yellow; // Color ligeramente cocido
                break;
            case FryState.Cooked:
                renderer.material.color = Color.grey; // Color cocido
                break;
            case FryState.Burnt:
                renderer.material.color = Color.black; // Color quemado
                break;
        }
    }

    public void ResetCooking()
    {
        currentCookingTime = 0f;
        ChangeState(FryState.Raw);
        isCooking = false;
    }
}
