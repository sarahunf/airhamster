using System;
using System.Collections;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Platform
{
    public class PlatformBlink : Platform
    {
        public float interval = 1f;
        protected Type mytype = Type.BLINK;
        private IEnumerator Start()
        {
            var randomDelay = UnityEngine.Random.Range(0f, 0.7f);
            yield return new WaitForSeconds(randomDelay);
            InvokeRepeating(nameof(Blink), 2, interval);
        }

        private void Blink()
        {
            gameObject.SetActive(!gameObject.activeSelf);
        }
    }
}