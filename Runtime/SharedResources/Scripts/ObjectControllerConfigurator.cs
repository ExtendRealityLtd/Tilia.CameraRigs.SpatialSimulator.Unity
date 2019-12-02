namespace Tilia.CameraRigs.SpatialSimulator
{
    using Malimbe.MemberChangeMethod;
    using Malimbe.MemberClearanceMethod;
    using Malimbe.PropertySerializationAttribute;
    using Malimbe.XmlDocumentationAttribute;
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
        /// <summary>
        /// The <see cref="GameObject"/> to update position and rotation of.
        /// </summary>
        [Serialized, Cleared]
        [field: Header("Control Settings"), DocumentedByXml]
        public GameObject Target { get; set; }
        /// <summary>
        /// An optional <see cref="GameObject"/> to use as the facing direction when performing position transformations.
        /// </summary>
        [Serialized, Cleared]
        [field: DocumentedByXml]
        public GameObject FacingSource { get; set; }
        #endregion
        #region Rotation Settings
        /// <summary>
        /// The horizontal axis that controls the rotation of the <see cref="Target"/>.
        /// </summary>
        [Serialized]
        [field: Header("Rotation Settings"), DocumentedByXml]
        public FloatAction RotationHorizontalAxis { get; set; }
        /// <summary>
        /// The vertical axis that controls the rotation of the <see cref="Target"/>.
        /// </summary>
        [Serialized]
        [field: DocumentedByXml]
        public FloatAction RotationVerticalAxis { get; set; }
        #endregion
        #region Movement Settings
        /// <summary>
        /// The horizontal axis that controls the movement of the <see cref="Target"/>.
        /// </summary>
        [Serialized]
        [field: Header("Movement Settings"), DocumentedByXml]
        public FloatAction MovementHorizontalAxis { get; set; }
        /// <summary>
        /// The vertical axis that controls the movement of the <see cref="Target"/>.
        /// </summary>
        [Serialized]
        [field: DocumentedByXml]
        public FloatAction MovementVerticalAxis { get; set; }
        #endregion

        #region Reference Settings
        /// <summary>
        /// The <see cref="TransformEulerRotationMutator"/> that applies the rotation to the <see cref="Target"/>.
        /// </summary>
        [Serialized]
        [field: Header("Reference Settings"), DocumentedByXml, Restricted]
        public TransformEulerRotationMutator RotationMutator { get; protected set; }
        /// <summary>
        /// The <see cref="TransformPositionMutator"/> that applies the movement to the <see cref="Target"/>.
        /// </summary>
        [Serialized]
        [field: DocumentedByXml, Restricted]
        public TransformPositionMutator PositionMutator { get; protected set; }
        /// <summary>
        /// The internal <see cref="FloatAction"/> that controls the horizontal rotation values.
        /// </summary>
        [Serialized]
        [field: DocumentedByXml, Restricted]
        public FloatAction InternalRotationHorizontalAxis { get; set; }
        /// <summary>
        /// The internal <see cref="FloatAction"/> that controls the vertical rotation values.
        /// </summary>
        [Serialized]
        [field: DocumentedByXml, Restricted]
        public FloatAction InternalRotationVerticalAxis { get; set; }
        /// <summary>
        /// The internal <see cref="FloatAction"/> that controls the horizontal movement values.
        /// </summary>
        [Serialized]
        [field: DocumentedByXml, Restricted]
        public FloatAction InternalMovementHorizontalAxis { get; set; }
        /// <summary>
        /// The internal <see cref="FloatAction"/> that controls the vertical movement values.
        /// </summary>
        [Serialized]
        [field: DocumentedByXml, Restricted]
        public FloatAction InternalMovementVerticalAxis { get; set; }
        #endregion

        protected virtual void OnEnable()
        {
            OnAfterTargetChange();
            OnAfterFacingSourceChange();

            InternalRotationHorizontalAxis.RunWhenActiveAndEnabled(() => OnAfterRotationHorizontalAxisChange());
            InternalRotationVerticalAxis.RunWhenActiveAndEnabled(() => OnAfterRotationVerticalAxisChange());
            InternalMovementHorizontalAxis.RunWhenActiveAndEnabled(() => OnAfterMovementHorizontalAxisChange());
            InternalMovementVerticalAxis.RunWhenActiveAndEnabled(() => OnAfterMovementVerticalAxisChange());
        }

        /// <summary>
        /// Called after <see cref="Target"/> has been changed.
        /// </summary>
        [CalledAfterChangeOf(nameof(Target))]
        protected virtual void OnAfterTargetChange()
        {
            RotationMutator.Target = Target;
            PositionMutator.Target = Target;
        }

        /// <summary>
        /// Called after <see cref="FacingSource"/> has been changed.
        /// </summary>
        [CalledAfterChangeOf(nameof(FacingSource))]
        protected virtual void OnAfterFacingSourceChange()
        {
            PositionMutator.FacingDirection = FacingSource;
        }

        /// <summary>
        /// Called after <see cref="RotationHorizontalAxis"/> has been changed.
        /// </summary>
        [CalledAfterChangeOf(nameof(RotationHorizontalAxis))]
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
        [CalledAfterChangeOf(nameof(RotationVerticalAxis))]
        protected virtual void OnAfterRotationVerticalAxisChange()
        {
            InternalRotationVerticalAxis.ClearSources();
            if (RotationVerticalAxis != null)
            {
                InternalRotationVerticalAxis.AddSource(RotationVerticalAxis);
            }
        }

        /// <summary>
        /// Called after <see cref="MovementHorizontalAxis"/> has been changed.
        /// </summary>
        [CalledAfterChangeOf(nameof(MovementHorizontalAxis))]
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
        [CalledAfterChangeOf(nameof(MovementVerticalAxis))]
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