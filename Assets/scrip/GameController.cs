/*using UnityEngine;

public class GameController : MonoBehaviour
{
    private SaveLoadManager saveLoadManager;
    private PlayerData playerData;

    void Start()
    {
        saveLoadManager = FindObjectOfType<SaveLoadManager>();
        playerData = new PlayerData { playerName = "Jugador1", playerScore = 100 };

        // Guardar datos
        saveLoadManager.SaveData(playerData);

        // Cargar datos
        PlayerData loadedData = saveLoadManager.LoadData();
        if (loadedData != null)
        {
            Debug.Log($"Nombre: {loadedData.playerName}, Puntuación: {loadedData.playerScore}");
        }
    }
}
*/
using UnityEngine;

public class GameController : MonoBehaviour
{
    private SaveLoadManager saveLoadManager;
    public TutorialMessage tutorialMessage; // Asigna tu script de mensaje
    void Start()
    {
        saveLoadManager = FindObjectOfType<SaveLoadManager>();

        // Cargar datos al iniciar el juego
        PlayerData loadedData = saveLoadManager.LoadData();
        if (loadedData != null)
        {
            Debug.Log($"Nombre: {loadedData.playerName}, Puntuación: {loadedData.playerScore}");
            // Aquí puedes usar los datos cargados para inicializar el juego
        }
        else
        {
            Debug.Log("No se encontraron datos para cargar.");

        }
        // Muestra el primer mensaje del tutorial
        tutorialMessage.ShowNextMessage();
    }
}
