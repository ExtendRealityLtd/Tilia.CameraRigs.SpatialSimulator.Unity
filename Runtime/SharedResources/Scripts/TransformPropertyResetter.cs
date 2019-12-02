namespace Tilia.CameraRigs.SpatialSimulator
{
    using Malimbe.BehaviourStateRequirementMethod;
    using Malimbe.MemberChangeMethod;
    using Malimbe.MemberClearanceMethod;
    using Malimbe.PropertySerializationAttribute;
    using Malimbe.XmlDocumentationAttribute;
    using UnityEngine;

    /// <summary>
    /// Resets the saved properties of a given transform.
    /// </summary>
    public class TransformPropertyResetter : MonoBehaviour
    {
        /// <summary>
        /// The <see cref="GameObject.transform"/> to cache and reset.
        /// </summary>
        [Serialized, Cleared]
        [field: DocumentedByXml]
        public GameObject Target { get; set; }

        /// <summary>
        /// Determines whether the properties have been cached.
        /// </summary>
        protected bool propertiesCached;
        /// <summary>
        /// The initial local position of the <see cref="Target"/>.
        /// </summary>
        protected Vector3 initialLocalPosition;
        /// <summary>
        /// The initial local rotation of the <see cref="Target"/>.
        /// </summary>
        protected Quaternion initialLocalRotation;
        /// <summary>
        /// The initial local scale of the <see cref="Target"/>.
        /// </summary>
        protected Vector3 initialLocalScale;

        /// <summary>
        /// Resets to the cached properties.
        /// </summary>
        [RequiresBehaviourState]
        public virtual void ResetProperties()
        {
            if (Target == null || !propertiesCached)
            {
                return;
            }

            Target.transform.localPosition = initialLocalPosition;
            Target.transform.localRotation = initialLocalRotation;
            Target.transform.localScale = initialLocalScale;
        }

        protected virtual void Awake()
        {
            CacheTransformData();
        }

        /// <summary>
        /// Caches the initial state of the <see cref="Target"/> transform data.
        /// </summary>
        protected virtual void CacheTransformData()
        {
            if (Target == null)
            {
                propertiesCached = false;
                return;
            }

            initialLocalPosition = Target.transform.localPosition;
            initialLocalRotation = Target.transform.localRotation;
            initialLocalScale = Target.transform.localScale;
            propertiesCached = true;
        }

        /// <summary>
        /// Called after <see cref="Target"/> has been changed.
        /// </summary>
        [CalledAfterChangeOf(nameof(Target))]
        protected virtual void OnAfterTargetChange()
        {
            CacheTransformData();
        }
    }
}