using System;
using Game_Manager;
using UnityEngine;

namespace Platform
{
    public class PlatformRock : Platform
    {
        protected Type mytype = Type.ROCK;
        protected override void OnCollisionEnter2D(Collision2D other)
        {
            //fragile checking
            if (other.gameObject.name == "Player")
            {
                CollidedWithPlayer();
            }
        }

        private void CollidedWithPlayer()
        {
            GameManager.ME._gameOver.Invoke();
        }
    }
}