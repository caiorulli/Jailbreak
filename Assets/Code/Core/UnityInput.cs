using UnityEngine;

namespace Jailbreak.Core
{
    class UnityInput
    {
        public float HorizontalAxis { get { return Input.GetAxis("Horizontal"); } }
        public float VerticalAxis { get { return Input.GetAxis("Vertical"); } }
        public float MouseX { get { return Input.GetAxis("Mouse X"); } }
        public float MouseY { get { return Input.GetAxis("Mouse Y"); } }
    }
}
