using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Platform
{
    public class PlatformBlink : Platform
    {
        public float interval = 1f;

        private void Start()
        {
            InvokeRepeating(nameof(Blink), 2, interval);
        }

        private void Blink()
        {
            gameObject.SetActive(!gameObject.activeSelf);
        }
    }
}