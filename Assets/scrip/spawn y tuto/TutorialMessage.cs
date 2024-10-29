/*using System.Collections;
using UnityEngine;
using TMPro;

public class TutorialMessage : MonoBehaviour
{
    public TextMeshProUGUI messageText; // Asigna tu componente TextMeshPro aqu�
    public float displayDuration = 3f; // Duraci�n en segundos que el mensaje permanecer� visible

    private void Start()
    {
        // Puedes iniciar el tutorial aqu�, llamando a ShowMessage con el texto deseado
        ShowMessage("�Bienvenido al juego!");
    }

    public void ShowMessage(string message)
    {
        messageText.text = message; // Asigna el mensaje
        messageText.gameObject.SetActive(true); // Muestra el mensaje
        StartCoroutine(HideMessageAfterDelay(displayDuration)); // Oculta el mensaje despu�s de un tiempo
    }

    private IEnumerator HideMessageAfterDelay(float delay)
    {
        yield return new WaitForSeconds(delay);
        messageText.gameObject.SetActive(false); // Oculta el mensaje
    }
}
*/
using System.Collections;
using UnityEngine;
using TMPro;

public class TutorialMessage : MonoBehaviour
{
    public TextMeshProUGUI messageText; // Asigna tu componente TextMeshPro aqu�
    public float displayDuration = 3f; // Duraci�n en segundos que el mensaje permanecer� visible

    // Array para almacenar los mensajes del tutorial
    public string[] tutorialMessages = new string[5]; // Espacios para 5 mensajes

    private int currentMessageIndex = 0; // �ndice del mensaje actual

    private void Start()
    {
        // Inicializa los mensajes del tutorial
        tutorialMessages[0] = "�Bienvenido al juego!";
        tutorialMessages[1] = "Usa WASD para moverte.";
        tutorialMessages[2] = "Presiona 'Espacio' para saltar.";
        tutorialMessages[3] = "Recoge ysuelta �ngredientes o objetos con la E";
        tutorialMessages[4] = "�Ve al armador y presiona F para armar la Hamburguesa!";
        tutorialMessages[5] = "�Divi�rtete jugando!";

        // Muestra el primer mensaje al iniciar
        ShowNextMessage();
    }

    public void ShowNextMessage()
    {
        if (currentMessageIndex < tutorialMessages.Length)
        {
            ShowMessage(tutorialMessages[currentMessageIndex]); // Muestra el mensaje actual
            currentMessageIndex++; // Incrementa el �ndice para el siguiente mensaje
        }
        else
        {
            // Si no hay m�s mensajes, puedes ocultar el texto o reiniciar
            messageText.gameObject.SetActive(false);
        }
    }

    private void ShowMessage(string message)
    {
        messageText.text = message; // Asigna el mensaje
        messageText.gameObject.SetActive(true); // Muestra el mensaje
        StartCoroutine(HideMessageAfterDelay(displayDuration)); // Oculta el mensaje despu�s de un tiempo
    }

    private IEnumerator HideMessageAfterDelay(float delay)
    {
        yield return new WaitForSeconds(delay);
        messageText.gameObject.SetActive(false); // Oculta el mensaje

        // Muestra el siguiente mensaje despu�s de ocultar
        ShowNextMessage();
    }
}
