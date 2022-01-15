using System;
using UnityEngine;

namespace Player
{
    public class PlayerController : MonoBehaviour
    {
        public void Die()
        {
            //temporary death implementation
            this.GetComponent<CapsuleCollider2D>().enabled = false;
        }
    }
}
