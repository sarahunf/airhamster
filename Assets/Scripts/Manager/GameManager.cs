using System;
using Unity.Mathematics;
using Unity.Profiling;
using UnityEngine;
using Random = UnityEngine.Random;

namespace Manager
{
    public class GameManager : MonoBehaviour
    {
        [SerializeField] private GameObject platformPrefab;
        [SerializeField] private float platformCount;

        private void Start()
        {
            Vector3 spawnPosition = new Vector3();

            for (int i = 0; i < platformCount; i++)
            {
                spawnPosition.y += Random.Range(0.5f, 2f);
                spawnPosition.x = Random.Range(-5f, 5f);
                Instantiate(platformPrefab, spawnPosition, quaternion.identity);
            }
        }
    }
}
