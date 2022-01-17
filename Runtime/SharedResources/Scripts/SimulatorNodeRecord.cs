namespace Tilia.CameraRigs.SpatialSimulator
{
    using Malimbe.PropertySerializationAttribute;
    using Malimbe.XmlDocumentationAttribute;
    using UnityEngine;
    using UnityEngine.XR;
    using Zinnia.Extension;
    using Zinnia.Tracking.CameraRig;

    /// <summary>
    /// Provides the description for a Simulated CameraRig node element.
    /// </summary>
    public class SimulatorNodeRecord : DeviceDetailsRecord
    {
        /// <summary>
        /// The source property to match against.
        /// </summary>
        [Serialized]
        [field: DocumentedByXml]
        public XRNode SimulatedNodeType { get; set; }
        /// <summary>
        /// The simulated connection status.
        /// </summary>
        [Serialized]
        [field: DocumentedByXml]
        public bool SimulatedIsConnected { get; set; } = true;
        /// <summary>
        /// The simulated controller priority.
        /// </summary>
        [Serialized]
        [field: DocumentedByXml]
        public int SimulatedPriority { get; set; } = defaultPriority;
        /// <summary>
        /// The simulated manufacturer name.
        /// </summary>
        [Serialized]
        [field: DocumentedByXml]
        public string SimulatedManufacturer { get; set; } = "Tilia";
        /// <summary>
        /// The simulated model name.
        /// </summary>
        [Serialized]
        [field: DocumentedByXml]
        public string SimulatedModel { get; set; } = "SpatialSimulator";
        /// <summary>
        /// The simulated tracking type.
        /// </summary>
        [Serialized]
        [field: DocumentedByXml]
        public SpatialTrackingType SimulatedTrackingType { get; set; } = SpatialTrackingType.RotationAndPosition;
        /// <summary>
        /// The simulated battery level.
        /// </summary>
        [Serialized]
        [field: DocumentedByXml]
        public float SimulatedBatteryLevel { get; set; } = -1f;
        /// <summary>
        /// The simulated battery level.
        /// </summary>
        [Serialized]
        [field: DocumentedByXml]
        public BatteryStatus SimulatedBatteryChargeStatus { get; set; } = BatteryStatus.Unknown;
        /// <summary>
        /// The source reference GameObject to determine priority from.
        /// </summary>
        [Serialized]
        [field: DocumentedByXml]
        public GameObject ReferenceSource { get; set; }

        /// <summary>
        /// The default priority to set the simulated priority to.
        /// </summary>
        protected const int defaultPriority = 1000;

        /// <inheritdoc/>
        public override XRNode XRNodeType
        {
            get
            {
                return SimulatedNodeType;
            }
            protected set { SimulatedNodeType = value; }
        }
        /// <inheritdoc/>
        public override bool IsConnected { get => SimulatedIsConnected; protected set => throw new System.NotImplementedException(); }
        /// <inheritdoc/>
        public override int Priority
        {
            get => SimulatedPriority == defaultPriority && ReferenceSource != null && ReferenceSource.activeInHierarchy ? 0 : SimulatedPriority;
            protected set => throw new System.NotImplementedException();
        }
        /// <inheritdoc/>
        public override string Manufacturer { get => SimulatedManufacturer; protected set => throw new System.NotImplementedException(); }
        /// <inheritdoc/>
        public override string Model { get => SimulatedModel; protected set => throw new System.NotImplementedException(); }
        /// <inheritdoc/>
        public override SpatialTrackingType TrackingType { get => SimulatedTrackingType; protected set => throw new System.NotImplementedException(); }
        /// <inheritdoc/>
        public override float BatteryLevel { get => SimulatedBatteryLevel; protected set => throw new System.NotImplementedException(); }
        /// <inheritdoc/>
        public override BatteryStatus BatteryChargeStatus { get => SimulatedBatteryChargeStatus; protected set => throw new System.NotImplementedException(); }

        /// <summary>
        /// The last known battery charge status.
        /// </summary>
        protected BatteryStatus lastKnownBatteryStatus;
        /// <summary>
        /// The last known is connected status.
        /// </summary>
        protected bool lastKnownIsConnected;
        /// <summary>
        /// The last known tracking type.
        /// </summary>
        protected SpatialTrackingType lastKnownTrackingType;

        /// <summary>
        /// Sets the <see cref="SimulatedNodeType"/>.
        /// </summary>
        /// <param name="index">The index of the <see cref="XRNode"/>.</param>
        public virtual void SetSimulatedNodeType(int index)
        {
            SimulatedNodeType = EnumExtensions.GetByIndex<XRNode>(index);
        }

        /// <summary>
        /// Sets the <see cref="SimulatedTrackingType"/>.
        /// </summary>
        /// <param name="index">The index of the <see cref="SpatialTrackingType"/>.</param>
        public virtual void SetSimulatedTrackingType(int index)
        {
            SimulatedTrackingType = EnumExtensions.GetByIndex<SpatialTrackingType>(index);
        }

        /// <summary>
        /// Sets the <see cref="BatteryChargeStatus"/>.
        /// </summary>
        /// <param name="index">The index of the <see cref="BatteryStatus"/>.</param>
        public virtual void SetBatteryChargeStatus(int index)
        {
            BatteryChargeStatus = EnumExtensions.GetByIndex<BatteryStatus>(index);
        }

        /// <inheritdoc/>
        protected override bool HasBatteryChargeStatusChanged()
        {
            bool hasChanged = BatteryChargeStatus != lastKnownBatteryStatus;
            if (hasChanged)
            {
                BatteryChargeStatusChanged?.Invoke(BatteryChargeStatus);
            }
            lastKnownBatteryStatus = BatteryChargeStatus;
            return hasChanged;
        }

        /// <inheritdoc/>
        protected override bool HasIsConnectedChanged()
        {
            bool hasChanged = IsConnected != lastKnownIsConnected;
            if (hasChanged)
            {
                ConnectionStatusChanged?.Invoke(IsConnected);
            }
            lastKnownIsConnected = IsConnected;
            return hasChanged;
        }

        /// <inheritdoc/>
        protected override bool HasTrackingTypeChanged()
        {
            bool hasChanged = TrackingType != lastKnownTrackingType;
            if (hasChanged)
            {
                TrackingTypeChanged?.Invoke(TrackingType);
            }
            lastKnownTrackingType = TrackingType;
            return hasChanged;
        }
    }
}