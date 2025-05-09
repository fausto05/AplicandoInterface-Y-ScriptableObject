using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float velocidad = 5f;

    private void Update()
    {
        // Movimiento lateral
        float input = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * input * velocidad * Time.deltaTime);

        // Interaccion con el enemigo mas cercano
        if (Input.GetKeyDown(KeyCode.R))
        {
            InteractuarConEnemigoMasCercano();
        }
    }
}
