using UnityEngine;

namespace Platform
{
    public class PlatformBreak : Platform
    {
        protected override void OnCollisionEnter2D(Collision2D other)
        {
            base.OnCollisionEnter2D(other);
            Destroy(gameObject);
        }
    }
}