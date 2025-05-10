using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float velocidad = 5f;
    public float rangoAtaque = 5f;
    public int daño = 1;

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

        // Atacar enemigos
        if (Input.GetKeyDown(KeyCode.E))
        {
            AtacarEnemigosCercanos();
        }
    }

    void InteractuarConEnemigoMasCercano()
    {
        Enemigo[] enemigos = FindObjectsOfType<Enemigo>();

        if (enemigos.Length == 0) return;

        Enemigo enemigoMasCercano = null;
        float distanciaMasCorta = Mathf.Infinity;

        foreach (Enemigo enemigo in enemigos)
        {
            float distancia = Vector3.Distance(transform.position, enemigo.transform.position);
            if (distancia < distanciaMasCorta)
            {
                distanciaMasCorta = distancia;
                enemigoMasCercano = enemigo;
            }
        }

        if (enemigoMasCercano != null)
        {
            enemigoMasCercano.Accion();
        }
    }

    void AtacarEnemigosCercanos()
    {
        Collider[] colliders = Physics.OverlapSphere(transform.position, rangoAtaque);
        foreach (Collider col in colliders)
        {
            ITakeDamage objetivo = col.GetComponent<ITakeDamage>();
            if (objetivo != null)
            {
                objetivo.RecibirDaño(daño);
            }
        }
    }
}
