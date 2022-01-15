using System;
using UnityEngine;
using UnityEngine.Events;

namespace Game_Manager
{
    public class GameManager : MonoBehaviour
    {
        public static GameManager ME;
        [SerializeField] private UnityEvent _gameOver;

        private void Awake()
        {
            ME = this;
        }

        private void OnDestroy()
        {
            ME = null;
        }


    }
}