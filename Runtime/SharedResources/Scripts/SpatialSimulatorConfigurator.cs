namespace Tilia.CameraRigs.SpatialSimulator
{
    using UnityEngine;
    using UnityEngine.XR;
    using Zinnia.Extension;

    /// <summary>
    /// Provides a way to configure settings related to the Spatial Simulator prefab.
    /// </summary>
    public class SpatialSimulatorConfigurator : MonoBehaviour
    {
        [Tooltip("Determines whether any connected XR device orientation will be detected.")]
        [SerializeField]
        private bool xREnabled;
        /// <summary>
        /// Determines whether any connected XR device orientation will be detected.
        /// </summary>
        public bool XREnabled
        {
            get
            {
                return xREnabled;
            }
            set
            {
                xREnabled = value;
                if (this.IsMemberChangeAllowed())
                {
                    OnAfterXREnabledChange();
                }
            }
        }
        [Tooltip("The frame rate to simulate with fixedDeltaTime.")]
        [SerializeField]
        private float simulatedFrameRate = 90f;
        /// <summary>
        /// The frame rate to simulate with fixedDeltaTime.
        /// </summary>
        public float SimulatedFrameRate
        {
            get
            {
                return simulatedFrameRate;
            }
            set
            {
                simulatedFrameRate = value;
                if (this.IsMemberChangeAllowed())
                {
                    OnAfterSimulatedFrameRateChange();
                }
            }
        }

        protected bool initialXRSettingsEnabledState;
        protected float initialFixedDeltaTime;

        protected virtual void OnEnable()
        {
            initialXRSettingsEnabledState = XRSettings.enabled;
            initialFixedDeltaTime = Time.fixedDeltaTime;
            OnAfterXREnabledChange();
            OnAfterSimulatedFrameRateChange();
        }

        protected virtual void OnDisable()
        {
            XRSettings.enabled = initialXRSettingsEnabledState;
            Time.fixedDeltaTime = initialFixedDeltaTime;
        }

        /// <summary>
        /// Called after <see cref="XREnabled"/> has been changed.
        /// </summary>
        protected virtual void OnAfterXREnabledChange()
        {
            if (!this.IsValidState())
            {
                return;
            }

            XRSettings.enabled = XREnabled;
        }

        /// <summary>
        /// Called after <see cref="SimulatedFrameRate"/> has been changed.
        /// </summary>
        protected virtual void OnAfterSimulatedFrameRateChange()
        {
            if (!this.IsValidState())
            {
                return;
            }

            Time.fixedDeltaTime = Time.timeScale / SimulatedFrameRate;
        }
    }
}