using System;
using UnityEngine;

namespace Platform
{
    public class Platform : MonoBehaviour
    {
        private const float JumpForce = 10f;

        private void OnCollisionEnter2D(Collision2D other)
        {
            if (other.relativeVelocity.y <= 0f)
            {
                Rigidbody2D rb = other.gameObject.GetComponent<Rigidbody2D>();
                if (rb == null) return;
                Vector2 velocity = rb.velocity;
                velocity.y = JumpForce;
                rb.velocity = velocity;
            }
        }
    }
}
