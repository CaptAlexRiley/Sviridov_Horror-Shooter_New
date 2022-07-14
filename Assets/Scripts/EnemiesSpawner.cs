using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemiesSpawner : MonoBehaviour
{
    [SerializeField]
    public GameObject enemyPrefab;
    public Transform SpawnPosition;
    private void Start()
    {
        Instantiate(enemyPrefab, SpawnPosition.position, Quaternion.identity);
    }
    
}
