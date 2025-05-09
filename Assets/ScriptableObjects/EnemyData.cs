using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "NewEnemyData", menuName = "Enemies/Enemy Data")]
public class EnemyData : ScriptableObject
{
    public string nombre;
    public int vida;
    public string saludos;
}
