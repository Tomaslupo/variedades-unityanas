using UnityEngine;

public class MovimientoDeJugador : MonoBehaviour
{
    public float velocidadMovimiento = 5.0f;
    public float velocidadRotacion = 3.0f;

    void Update()
    {
        // Movimiento lateral
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        Vector3 movimiento = new Vector3(horizontal, 0.0f, vertical) * velocidadMovimiento * Time.deltaTime;
        transform.Translate(movimiento);

        // Rotación en el eje X con el mouse
        float mouseX = Input.GetAxis("Mouse X") * velocidadRotacion;
        transform.Rotate(0.0f, mouseX, 0.0f);
    }
}
