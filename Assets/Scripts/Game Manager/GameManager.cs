using System;
using Player;
using UnityEngine;
using UnityEngine.Events;

namespace Game_Manager
{
    public class GameManager : MonoBehaviour
    {
        public static GameManager ME;
        internal UnityEvent _gameOver;
        
        private void Awake()
        {
            ME = this;
            
            _gameOver ??= new UnityEvent();
            _gameOver.AddListener(EndGame);
        }

        private void OnDestroy()
        {
            ME = null;
        }

        private void EndGame()
        {
            Debug.Log("End game");
            PlayerController.ME.Die();
        }
    }
}