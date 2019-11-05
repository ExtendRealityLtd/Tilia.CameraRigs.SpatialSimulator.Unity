namespace Tilia.CameraRigs.SpatialSimulator
{
    using UnityEngine;

    /// <summary>
    /// Manages the state of the mouse cursor.
    /// </summary>
    public class MouseCursorManager : MonoBehaviour
    {
        /// <summary>
        /// The lock state of the mouse cursor.
        /// </summary>
        public bool Locked
        {
            get
            {
                return Cursor.lockState == CursorLockMode.None ? false : true;
            }
            set
            {
                Cursor.lockState = value ? CursorLockMode.Locked : CursorLockMode.None;
            }
        }

        /// <summary>
        /// The visibility state of the mouse cursor.
        /// </summary>
        public bool Visible
        {
            get
            {
                return Cursor.visible;
            }
            set
            {
                Cursor.visible = value;
            }
        }
    }
}