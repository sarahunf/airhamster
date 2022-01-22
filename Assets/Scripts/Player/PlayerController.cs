using System;
using UnityEngine;

namespace Player
{
    public class PlayerController : MonoBehaviour
    {
        public static PlayerController ME;
        protected Transform _base;
        private float _highestPosition;
        public float HighestPosition => _highestPosition;

        private void Awake()
        {
            if (ME != null && ME != this)
                Destroy(gameObject);
            else
                ME = this;
        }

        public void RecordHighestPosition(float position)
        {
            _highestPosition = position;
        }

        public void Die()
        {
            //temporary death implementation
            this.GetComponent<CapsuleCollider2D>().enabled = false;
        }
    }
}
