using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;
using Random = UnityEngine.Random;

namespace Platform
{
    public class PlatformSpawner : MonoBehaviour
    {
        [SerializeField] private Platform[] platforms;
        [SerializeField] private Transform platformParent;
        [SerializeField] private float platformCount;

        private Dictionary<Platform, float> chances;

        private void Awake()
        {
            chances = new Dictionary<Platform, float>
            {
                {platforms[0], 0.5f}, //normal
                {platforms[1], 0.7f}, //blink
                {platforms[2], 0.8f}, //break
                {platforms[3], 0.9f}, //rock
            };
        }

        private void Start()
        {
            Vector3 spawnPosition = new Vector3();

            for (int i = 0; i < platformCount; i++)
            {
                spawnPosition.y += Random.Range(0.7f, 3f);
                spawnPosition.x = Random.Range(-4f, 6f);
                Instantiate(RandomPlatform(), spawnPosition, quaternion.identity, platformParent);
            }
        }

        private GameObject RandomPlatform()
        {
            var value = Random.Range(0, 0.91f);
            
            if (value > chances[platforms[0]] && value <= chances[platforms[1]])
                return platforms[1].gameObject;
            if (value > chances[platforms[1]] && value <= chances[platforms[2]])
                return platforms[2].gameObject;
            if (value > chances[platforms[2]] && value <= chances[platforms[3]])
                return platforms[3].gameObject;
            
            return platforms[0].gameObject;
        }
    }
}
