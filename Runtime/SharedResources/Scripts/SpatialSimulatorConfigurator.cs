namespace Tilia.CameraRigs.SpatialSimulator
{
    using Malimbe.BehaviourStateRequirementMethod;
    using Malimbe.MemberChangeMethod;
    using Malimbe.PropertySerializationAttribute;
    using Malimbe.XmlDocumentationAttribute;
    using UnityEngine;
    using UnityEngine.XR;

    /// <summary>
    /// Provides a way to configure settings related to the Spatial Simulator prefab.
    /// </summary>
    public class SpatialSimulatorConfigurator : MonoBehaviour
    {
        /// <summary>
        /// Determines whether any connected XR device orientation will be detected.
        /// </summary>
        [Serialized]
        [field: DocumentedByXml]
        public bool XREnabled { get; set; }
        /// <summary>
        /// The frame rate to simulate with fixedDeltaTime.
        /// </summary>
        [Serialized]
        [field: DocumentedByXml]
        public float SimulatedFrameRate { get; set; } = 90f;

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
        [RequiresBehaviourState, CalledAfterChangeOf(nameof(XREnabled))]
        protected virtual void OnAfterXREnabledChange()
        {
            XRSettings.enabled = XREnabled;
        }

        /// <summary>
        /// Called after <see cref="SimulatedFrameRate"/> has been changed.
        /// </summary>
        [RequiresBehaviourState, CalledAfterChangeOf(nameof(SimulatedFrameRate))]
        protected virtual void OnAfterSimulatedFrameRateChange()
        {
            Time.fixedDeltaTime = Time.timeScale / SimulatedFrameRate;
        }
    }
}