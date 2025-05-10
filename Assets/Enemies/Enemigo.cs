using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemigo : MonoBehaviour, IPresentacion, ITakeDamage
{
    public EnemyData enemyData;
    private int vidaActual;

    private void Start()
    {
        if (enemyData != null)
        {
            vidaActual = enemyData.vida;
            Debug.Log($"Enemigo Creado: {enemyData.nombre} con {vidaActual} de vida");
        }
    }

    public void Accion()
    {
        Debug.Log($"{enemyData.nombre} dice: {enemyData.saludos}");
    }

    public void RecibirDaño(int cantidad)
    {
        vidaActual -= cantidad;
        Debug.Log($"{enemyData.nombre} recibio {cantidad} de daño. Vida restante: {vidaActual}");

        if (vidaActual <= 0)
        {
            Debug.Log($"{enemyData.nombre} ha sido derrotado");
            Destroy(gameObject);
        }
    }
}
