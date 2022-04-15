namespace Tilia.CameraRigs.SpatialSimulator
{
    using UnityEngine;
    using Zinnia.Action;
    using Zinnia.Data.Attribute;
    using Zinnia.Data.Operation.Mutation;
    using Zinnia.Extension;

    /// <summary>
    /// Provides a way to configure settings related to the Object Controller prefab.
    /// </summary>
    public class ObjectControllerConfigurator : MonoBehaviour
    {
        #region Control Settings
        [Header("Control Settings")]
        [Tooltip("The GameObject to update position and rotation of.")]
        [SerializeField]
        private GameObject target;
        /// <summary>
        /// The <see cref="GameObject"/> to update position and rotation of.
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
        [Tooltip("An optional GameObject to use as the facing direction when performing position transformations.")]
        [SerializeField]
        private GameObject facingSource;
        /// <summary>
        /// An optional <see cref="GameObject"/> to use as the facing direction when performing position transformations.
        /// </summary>
        public GameObject FacingSource
        {
            get
            {
                return facingSource;
            }
            set
            {
                facingSource = value;
                if (this.IsMemberChangeAllowed())
                {
                    OnAfterFacingSourceChange();
                }
            }
        }
        #endregion

        #region Rotation Settings
        [Header("Rotation Settings")]
        [Tooltip("The horizontal axis that controls the rotation of the Target.")]
        [SerializeField]
        private FloatAction rotationHorizontalAxis;
        /// <summary>
        /// The horizontal axis that controls the rotation of the <see cref="Target"/>.
        /// </summary>
        public FloatAction RotationHorizontalAxis
        {
            get
            {
                return rotationHorizontalAxis;
            }
            set
            {
                rotationHorizontalAxis = value;
                if (this.IsMemberChangeAllowed())
                {
                    OnAfterRotationHorizontalAxisChange();
                }
            }
        }
        [Tooltip("The vertical axis that controls the rotation of the Target.")]
        [SerializeField]
        private FloatAction rotationVerticalAxis;
        /// <summary>
        /// The vertical axis that controls the rotation of the <see cref="Target"/>.
        /// </summary>
        public FloatAction RotationVerticalAxis
        {
            get
            {
                return rotationVerticalAxis;
            }
            set
            {
                rotationVerticalAxis = value;
                if (this.IsMemberChangeAllowed())
                {
                    OnAfterRotationVerticalAxisChange();
                }
            }
        }
        [Tooltip("The circular axis that controls the rotation of the Target.")]
        [SerializeField]
        private FloatAction rotationCircularAxis;
        /// <summary>
        /// The circular axis that controls the rotation of the <see cref="Target"/>.
        /// </summary>
        public FloatAction RotationCircularAxis
        {
            get
            {
                return rotationCircularAxis;
            }
            set
            {
                rotationCircularAxis = value;
                if (this.IsMemberChangeAllowed())
                {
                    OnAfterRotationCircularAxisChange();
                }
            }
        }
        #endregion

        #region Movement Settings
        [Header("Movement Settings")]
        [Tooltip("The horizontal axis that controls the movement of the Target.")]
        [SerializeField]
        private FloatAction movementHorizontalAxis;
        /// <summary>
        /// The horizontal axis that controls the movement of the <see cref="Target"/>.
        /// </summary>
        public FloatAction MovementHorizontalAxis
        {
            get
            {
                return movementHorizontalAxis;
            }
            set
            {
                movementHorizontalAxis = value;
                if (this.IsMemberChangeAllowed())
                {
                    OnAfterMovementHorizontalAxisChange();
                }
            }
        }
        [Tooltip("The vertical axis that controls the movement of the Target.")]
        [SerializeField]
        private FloatAction movementVerticalAxis;
        /// <summary>
        /// The vertical axis that controls the movement of the <see cref="Target"/>.
        /// </summary>
        public FloatAction MovementVerticalAxis
        {
            get
            {
                return movementVerticalAxis;
            }
            set
            {
                movementVerticalAxis = value;
                if (this.IsMemberChangeAllowed())
                {
                    OnAfterMovementVerticalAxisChange();
                }
            }
        }
        #endregion

        #region Reference Settings
        [Header("Reference Settings")]
        [Tooltip("The TransformEulerRotationMutator that applies the rotation to the Target.")]
        [SerializeField]
        [Restricted]
        private TransformEulerRotationMutator rotationMutator;
        /// <summary>
        /// The <see cref="TransformEulerRotationMutator"/> that applies the rotation to the <see cref="Target"/>.
        /// </summary>
        public TransformEulerRotationMutator RotationMutator
        {
            get
            {
                return rotationMutator;
            }
            protected set
            {
                rotationMutator = value;
            }
        }
        [Tooltip("The TransformPositionMutator that applies the movement to the Target.")]
        [SerializeField]
        [Restricted]
        private TransformPositionMutator positionMutator;
        /// <summary>
        /// The <see cref="TransformPositionMutator"/> that applies the movement to the <see cref="Target"/>.
        /// </summary>
        public TransformPositionMutator PositionMutator
        {
            get
            {
                return positionMutator;
            }
            protected set
            {
                positionMutator = value;
            }
        }
        [Tooltip("The internal FloatAction that controls the horizontal rotation values.")]
        [SerializeField]
        [Restricted]
        private FloatAction internalRotationHorizontalAxis;
        /// <summary>
        /// The internal <see cref="FloatAction"/> that controls the horizontal rotation values.
        /// </summary>
        public FloatAction InternalRotationHorizontalAxis
        {
            get
            {
                return internalRotationHorizontalAxis;
            }
            protected set
            {
                internalRotationHorizontalAxis = value;
            }
        }
        [Tooltip("The internal FloatAction that controls the vertical rotation values.")]
        [SerializeField]
        [Restricted]
        private FloatAction internalRotationVerticalAxis;
        /// <summary>
        /// The internal <see cref="FloatAction"/> that controls the vertical rotation values.
        /// </summary>
        public FloatAction InternalRotationVerticalAxis
        {
            get
            {
                return internalRotationVerticalAxis;
            }
            protected set
            {
                internalRotationVerticalAxis = value;
            }
        }
        [Tooltip("The internal FloatAction that controls the circular rotation values.")]
        [SerializeField]
        [Restricted]
        private FloatAction internalRotationCircularAxis;
        /// <summary>
        /// The internal <see cref="FloatAction"/> that controls the circular rotation values.
        /// </summary>
        public FloatAction InternalRotationCircularAxis
        {
            get
            {
                return internalRotationCircularAxis;
            }
            protected set
            {
                internalRotationCircularAxis = value;
            }
        }
        [Tooltip("The internal FloatAction that controls the horizontal movement values.")]
        [SerializeField]
        [Restricted]
        private FloatAction internalMovementHorizontalAxis;
        /// <summary>
        /// The internal <see cref="FloatAction"/> that controls the horizontal movement values.
        /// </summary>
        public FloatAction InternalMovementHorizontalAxis
        {
            get
            {
                return internalMovementHorizontalAxis;
            }
            protected set
            {
                internalMovementHorizontalAxis = value;
            }
        }
        [Tooltip("The internal FloatAction that controls the vertical movement values.")]
        [SerializeField]
        [Restricted]
        private FloatAction internalMovementVerticalAxis;
        /// <summary>
        /// The internal <see cref="FloatAction"/> that controls the vertical movement values.
        /// </summary>
        public FloatAction InternalMovementVerticalAxis
        {
            get
            {
                return internalMovementVerticalAxis;
            }
            protected set
            {
                internalMovementVerticalAxis = value;
            }
        }
        #endregion

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
        /// Clears <see cref="FacingSource"/>.
        /// </summary>
        public virtual void ClearFacingSource()
        {
            if (!this.IsValidState())
            {
                return;
            }

            FacingSource = default;
        }

        protected virtual void OnEnable()
        {
            OnAfterTargetChange();
            OnAfterFacingSourceChange();

            InternalRotationHorizontalAxis.RunWhenActiveAndEnabled(() => OnAfterRotationHorizontalAxisChange());
            InternalRotationVerticalAxis.RunWhenActiveAndEnabled(() => OnAfterRotationVerticalAxisChange());
            InternalRotationCircularAxis.RunWhenActiveAndEnabled(() => OnAfterRotationCircularAxisChange());
            InternalMovementHorizontalAxis.RunWhenActiveAndEnabled(() => OnAfterMovementHorizontalAxisChange());
            InternalMovementVerticalAxis.RunWhenActiveAndEnabled(() => OnAfterMovementVerticalAxisChange());
        }

        /// <summary>
        /// Called after <see cref="Target"/> has been changed.
        /// </summary>
        protected virtual void OnAfterTargetChange()
        {
            RotationMutator.Target = Target;
            PositionMutator.Target = Target;
        }

        /// <summary>
        /// Called after <see cref="FacingSource"/> has been changed.
        /// </summary>
        protected virtual void OnAfterFacingSourceChange()
        {
            PositionMutator.FacingDirection = FacingSource;
        }

        /// <summary>
        /// Called after <see cref="RotationHorizontalAxis"/> has been changed.
        /// </summary>
        protected virtual void OnAfterRotationHorizontalAxisChange()
        {
            InternalRotationHorizontalAxis.ClearSources();
            if (RotationHorizontalAxis != null)
            {
                InternalRotationHorizontalAxis.AddSource(RotationHorizontalAxis);
            }
        }

        /// <summary>
        /// Called after <see cref="RotationVerticalAxis"/> has been changed.
        /// </summary>
        protected virtual void OnAfterRotationVerticalAxisChange()
        {
            InternalRotationVerticalAxis.ClearSources();
            if (RotationVerticalAxis != null)
            {
                InternalRotationVerticalAxis.AddSource(RotationVerticalAxis);
            }
        }

        /// <summary>
        /// Called after <see cref="RotationCircularAxis"/> has been changed.
        /// </summary>
        protected virtual void OnAfterRotationCircularAxisChange()
        {
            InternalRotationCircularAxis.ClearSources();
            if (RotationCircularAxis != null)
            {
                InternalRotationCircularAxis.AddSource(RotationCircularAxis);
            }
        }

        /// <summary>
        /// Called after <see cref="MovementHorizontalAxis"/> has been changed.
        /// </summary>
        protected virtual void OnAfterMovementHorizontalAxisChange()
        {
            InternalMovementHorizontalAxis.ClearSources();
            if (MovementHorizontalAxis != null)
            {
                InternalMovementHorizontalAxis.AddSource(MovementHorizontalAxis);
            }
        }

        /// <summary>
        /// Called after <see cref="MovementVerticalAxis"/> has been changed.
        /// </summary>
        protected virtual void OnAfterMovementVerticalAxisChange()
        {
            InternalMovementVerticalAxis.ClearSources();
            if (MovementVerticalAxis != null)
            {
                InternalMovementVerticalAxis.AddSource(MovementVerticalAxis);
            }
        }
    }
}