using System;
using UnityEngine;

namespace Camera
{
    public class CameraFollow : MonoBehaviour
    {
        [SerializeField] private Transform target;

        private void LateUpdate()
        {
            var position = transform.position;
            Vector3 newPosition = new Vector3(position.x, target.position.y, position.z);
            position = newPosition;
            transform.position = position;
        }
    }
}
