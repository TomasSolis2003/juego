using System.IO;
using UnityEngine;

public class SaveLoadManager : MonoBehaviour
{
    private string filePath;
    private float saveInterval = 300f; // 5 minutos en segundos
    private float timeSinceLastSave = 0f;

    void Start()
    {
        filePath = Path.Combine(Application.persistentDataPath, "playerData.json");
        LoadData(); // Carga los datos al iniciar el juego
    }

    void Update()
    {
        timeSinceLastSave += Time.deltaTime;

        if (timeSinceLastSave >= saveInterval)
        {
            PlayerData data = new PlayerData
            {
                playerName = "Jugador1", // Cambia esto según tu lógica de juego
                playerScore = 100 // Cambia esto según tu lógica de juego
            };
            SaveData(data);
            timeSinceLastSave = 0f; // Reinicia el temporizador
        }
    }

    public void SaveData(PlayerData data)
    {
        string json = JsonUtility.ToJson(data, true);
        File.WriteAllText(filePath, json);
        Debug.Log("Datos guardados: " + json);
    }

    public PlayerData LoadData()
    {
        if (File.Exists(filePath))
        {
            string json = File.ReadAllText(filePath);
            PlayerData data = JsonUtility.FromJson<PlayerData>(json);
            Debug.Log("Datos cargados: " + json);
            return data;
        }
        else
        {
            Debug.LogWarning("No se encontró el archivo de datos.");
            return null;
        }
    }
}
