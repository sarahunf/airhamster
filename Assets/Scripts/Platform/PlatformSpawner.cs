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
        private int lastReturnedIndex;

        private Dictionary<Platform.Type, float> chances;

        private void Awake()
        {
            chances = new Dictionary<Platform.Type, float>
            {
                {Platform.Type.NORMAL, 0.5f}, //normal
                {Platform.Type.BLINK, 0.7f}, //blink
                {Platform.Type.BREAK, 0.8f}, //break
                {Platform.Type.ROCK, 0.9f}, //rock
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
            var platformIndex = 0;
            if (value > chances[Platform.Type.NORMAL] && value <= chances[Platform.Type.BLINK])
                platformIndex = 1;
            if (value > chances[Platform.Type.BLINK] && value <= chances[Platform.Type.BREAK])
                platformIndex = 2;
            if (value > chances[Platform.Type.BREAK] && value <= chances[Platform.Type.ROCK])
                platformIndex = 3;

            if (platformIndex == 3 && lastReturnedIndex == 3)
            {
                platformIndex = 0;
            }
            lastReturnedIndex = platformIndex;
            
            return platforms[platformIndex].gameObject;
        }
    }
}
