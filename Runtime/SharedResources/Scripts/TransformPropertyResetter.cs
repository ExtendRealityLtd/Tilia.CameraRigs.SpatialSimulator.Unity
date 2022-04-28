namespace Tilia.CameraRigs.SpatialSimulator
{
    using UnityEngine;
    using Zinnia.Extension;

    /// <summary>
    /// Resets the saved properties of a given transform.
    /// </summary>
    public class TransformPropertyResetter : MonoBehaviour
    {
        [Tooltip("The GameObject.transform to cache and reset.")]
        [SerializeField]
        private GameObject target;
        /// <summary>
        /// The <see cref="GameObject.transform"/> to cache and reset.
        /// </summary>
        public GameObject Target
        {
            get
            {
                return target;
            }
            set
            {
                target = value;
                if (this.IsMemberChangeAllowed())
                {
                    OnAfterTargetChange();
                }
            }
        }

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
        /// Clears <see cref="Target"/>.
        /// </summary>
        public virtual void ClearTarget()
        {
            if (!this.IsValidState())
            {
                return;
            }

            Target = default;
        }

        /// <summary>
        /// Resets to the cached properties.
        /// </summary>
        public virtual void ResetProperties()
        {
            if (!this.IsValidState() || Target == null || !propertiesCached)
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
        protected virtual void OnAfterTargetChange()
        {
            CacheTransformData();
        }
    }
}