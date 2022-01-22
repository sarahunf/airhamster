using Player;
using UnityEngine;

namespace Platform
{
    public class PlatformBreak : Platform
    {
        protected Type mytype = Type.BREAK;
        protected override void OnCollisionEnter2D(Collision2D other)
        {
            if (!(transform.position.y < PlayerController.ME.HighestPosition)) return;
            base.OnCollisionEnter2D(other);
            Destroy(gameObject);
        }
    }
}