using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemigo : MonoBehaviour, IPresentacion
{
    public EnemyData enemyData;

    private void Start()
    {
        if (enemyData != null)
        {
            Debug.Log($"Enemigo Creado: {enemyData.nombre} con {enemyData.vida} de vida");
        }
    }

    public void Accion()
    {
        Debug.Log($"{enemyData.nombre} dice: {enemyData.saludos}");
    }
}
