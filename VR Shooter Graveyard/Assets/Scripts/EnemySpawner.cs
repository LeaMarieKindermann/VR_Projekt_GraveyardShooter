using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject enemyPrefab; // Das Gegner-Prefab
    public Transform[] spawnPoints; // Die Spawn-Punkte

    public float spawnInterval = 3f; // Intervall zwischen den Spawns
    private float nextSpawnTime = 0f; // Zeit bis zum nächsten Spawn

    void Update()
    {
        // Überprüfen Sie, ob es Zeit ist für einen neuen Spawn
        if (Time.time >= nextSpawnTime)
        {
            // Wählen Sie einen zufälligen Spawn-Punkt aus
            Transform randomSpawnPoint = spawnPoints[Random.Range(0, spawnPoints.Length)];

            // Erzeugen Sie den Gegner an dem ausgewählten Spawn-Punkt
            Instantiate(enemyPrefab, randomSpawnPoint.position, randomSpawnPoint.rotation);

            // Aktualisieren Sie die Zeit bis zum nächsten Spawn
            nextSpawnTime = Time.time + spawnInterval;
        }
    }
}
