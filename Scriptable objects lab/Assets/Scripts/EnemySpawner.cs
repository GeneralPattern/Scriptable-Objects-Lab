using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "EnemySpawnWave", menuName = "EnemySpawn")]
public class EnemySpawner : ScriptableObject
{
    public GameObject enemy;
    public int spawnAmount = 2;
    public float spawnDelay = 0.5f;

    [SerializeField] string saySomething = "Hey";

    public void SaySomething()
    {
        Debug.LogError(saySomething);
    }
}
