using UnityEngine;
using TMPro;

public class CashRegister : MonoBehaviour
{
    public TextMeshProUGUI totalText;
    private float totalAmount = 0f;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Money"))
        {
            Money money = other.GetComponent<Money>();
            if (money != null)
            {
                totalAmount += money.amount;
                totalText.text = $"Total: ${totalAmount:N2}";
                Destroy(other.gameObject);
            }
        }
    }
}
