using System;
using UnityEngine;

namespace Player
{
    [RequireComponent(typeof(Rigidbody2D))]
    public class PlayerController : MonoBehaviour
    {
        public Rigidbody2D rb;
        [SerializeField] private float moveSpeed = 10f;
        [SerializeField] private float moveX;

        private void Awake()
        {
            rb = GetComponent<Rigidbody2D>();
        }

        private void Update()
        {
            moveX = Input.GetAxis("Horizontal") * moveSpeed;
        }

        private void FixedUpdate()
        {
            Vector2 velocity = rb.velocity;
            velocity.x = moveX;
            rb.velocity = velocity;
        }
    }
}
