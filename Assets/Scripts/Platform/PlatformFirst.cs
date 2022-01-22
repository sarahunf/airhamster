using System;

namespace Platform
{
    public class PlatformFirst : Platform
    {
        protected Type mytype = Type.FIRST;
        public override float jumpForce { get; set; } = 15f;
    }
}