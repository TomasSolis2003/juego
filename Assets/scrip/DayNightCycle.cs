using UnityEngine;

public class DayNightCycle : MonoBehaviour
{
    public Light sun; // La luz del sol
    public float dayDuration = 60f; // Duración del día en segundos
    private float time; // Tiempo transcurrido

    void Update()
    {
        time += Time.deltaTime;

        // Calcula la rotación del sol
        float sunRotation = (time / dayDuration) * 360f;
        sun.transform.rotation = Quaternion.Euler(sunRotation - 90, 170, 0); // Ajusta según sea necesario

        // Reinicia el ciclo
        if (time >= dayDuration)
        {
            time = 0;
        }
    }
}
