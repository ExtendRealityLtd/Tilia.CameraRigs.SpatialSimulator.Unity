namespace Tilia.CameraRigs.SpatialSimulator
{
    using UnityEngine;
    using UnityEngine.XR;
    using Zinnia.Extension;
    using Zinnia.Tracking.CameraRig;

    /// <summary>
    /// Provides the description for a Simulated CameraRig node element.
    /// </summary>
    public class SimulatorNodeRecord : BaseDeviceDetailsRecord
    {
        [Tooltip("The source property to match against.")]
        [SerializeField]
        private XRNode simulatedNodeType;
        /// <summary>
        /// The source property to match against.
        /// </summary>
        public XRNode SimulatedNodeType
        {
            get
            {
                return simulatedNodeType;
            }
            set
            {
                simulatedNodeType = value;
            }
        }
        [Tooltip("The simulated connection status.")]
        [SerializeField]
        private bool simulatedIsConnected = true;
        /// <summary>
        /// The simulated connection status.
        /// </summary>
        public bool SimulatedIsConnected
        {
            get
            {
                return simulatedIsConnected;
            }
            set
            {
                simulatedIsConnected = value;
            }
        }
        [Tooltip("The simulated controller priority.")]
        [SerializeField]
        private int simulatedPriority = defaultPriority;
        /// <summary>
        /// The simulated controller priority.
        /// </summary>
        public int SimulatedPriority
        {
            get
            {
                return simulatedPriority;
            }
            set
            {
                simulatedPriority = value;
            }
        }
        [Tooltip("The simulated manufacturer name.")]
        [SerializeField]
        private string simulatedManufacturer = "Tilia";
        /// <summary>
        /// The simulated manufacturer name.
        /// </summary>
        public string SimulatedManufacturer
        {
            get
            {
                return simulatedManufacturer;
            }
            set
            {
                simulatedManufacturer = value;
            }
        }
        [Tooltip("The simulated model name.")]
        [SerializeField]
        private string simulatedModel = "SpatialSimulator";
        /// <summary>
        /// The simulated model name.
        /// </summary>
        public string SimulatedModel
        {
            get
            {
                return simulatedModel;
            }
            set
            {
                simulatedModel = value;
            }
        }
        [Tooltip("The simulated tracking type.")]
        [SerializeField]
        private SpatialTrackingType simulatedTrackingType = SpatialTrackingType.RotationAndPosition;
        /// <summary>
        /// The simulated tracking type.
        /// </summary>
        public SpatialTrackingType SimulatedTrackingType
        {
            get
            {
                return simulatedTrackingType;
            }
            set
            {
                simulatedTrackingType = value;
            }
        }
        [Tooltip("The simulated battery level.")]
        [SerializeField]
        private float simulatedBatteryLevel = -1f;
        /// <summary>
        /// The simulated battery level.
        /// </summary>
        public float SimulatedBatteryLevel
        {
            get
            {
                return simulatedBatteryLevel;
            }
            set
            {
                simulatedBatteryLevel = value;
            }
        }
        [Tooltip("The simulated battery status.")]
        [SerializeField]
        private BatteryStatus simulatedBatteryChargeStatus = BatteryStatus.Unknown;
        /// <summary>
        /// The simulated battery status.
        /// </summary>
        public BatteryStatus SimulatedBatteryChargeStatus
        {
            get
            {
                return simulatedBatteryChargeStatus;
            }
            set
            {
                simulatedBatteryChargeStatus = value;
            }
        }
        [Tooltip("The source reference GameObject to determine priority from.")]
        [SerializeField]
        private GameObject referenceSource;
        /// <summary>
        /// The source reference GameObject to determine priority from.
        /// </summary>
        public GameObject ReferenceSource
        {
            get
            {
                return referenceSource;
            }
            set
            {
                referenceSource = value;
            }
        }

        /// <summary>
        /// The default priority to set the simulated priority to.
        /// </summary>
        protected const int defaultPriority = 1000;

        /// <inheritdoc/>
        public override XRNode XRNodeType { get { return SimulatedNodeType; } protected set { SimulatedNodeType = value; } }
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
    }
}