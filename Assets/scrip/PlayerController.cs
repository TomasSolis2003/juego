using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 5f; // Velocidad de movimiento
    public float mouseSensitivity = 100f; // Sensibilidad del rat�n
    public float jumpForce = 5f; // Fuerza del salto
    public Transform playerBody; // Transform del cuerpo del jugador
    public Transform cameraTransform; // Transform de la c�mara

    private Rigidbody rb; // Referencia al Rigidbody del jugador
    private float xRotation = 0f; // Control de la rotaci�n en el eje X (vertical)
    private bool isGrounded; // Indica si el jugador est� en el suelo

    void Start()
    {
        // Ocultar y bloquear el cursor en el centro de la pantalla
        Cursor.lockState = CursorLockMode.Locked;

        // Obtener el Rigidbody del jugador
        rb = playerBody.GetComponent<Rigidbody>();
    }

    void Update()
    {
        // --- Movimiento del rat�n para rotar la c�mara y el cuerpo del jugador ---

        // Obtener el movimiento del rat�n en los ejes X e Y
        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;

        // Rotar la c�mara en el eje X (vertical, hacia arriba/abajo)
        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -90f, 90f); // Limitar la rotaci�n para no mirar completamente hacia arriba/abajo

        // Aplicar la rotaci�n a la c�mara
        cameraTransform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);

        // Rotar el cuerpo del jugador en el eje Y (horizontal, izquierda/derecha)
        playerBody.Rotate(Vector3.up * mouseX);

        // --- Movimiento del jugador ---

        // Capturar las entradas del teclado para movimiento
        float moveX = Input.GetAxis("Horizontal"); // Flechas izquierda/derecha o teclas A/D
        float moveZ = Input.GetAxis("Vertical"); // Flechas arriba/abajo o teclas W/S

        // Crear un vector de movimiento en relaci�n a la c�mara
        Vector3 move = cameraTransform.right * moveX + cameraTransform.forward * moveZ;

        // Evitar que el personaje se mueva hacia arriba/abajo (solo mover en X y Z)
        move.y = 0f;

        // Mover el personaje seg�n la velocidad
        playerBody.Translate(move * moveSpeed * Time.deltaTime, Space.World);

        // --- Saltar ---
        // Saltar si se presiona la tecla Espacio y el jugador est� en el suelo
        if (Input.GetButtonDown("Jump") && isGrounded)
        {
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        }
    }

    // M�todo para detectar si el jugador est� tocando el suelo (objetos con tag "Ground")
    private void OnCollisionStay(Collision collision)
    {
        // Verifica si el jugador est� en contacto con un objeto que tiene el tag "Ground"
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = true;
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        // Cuando el jugador deja de estar en contacto con el suelo, isGrounded se vuelve false
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = false;
        }
    }
}
