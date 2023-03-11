# Class SimulatorNodeRecord

Provides the description for a Simulated CameraRig node element.

## Contents

* [Inheritance]
* [Namespace]
* [Syntax]
* [Fields]
  * [defaultPriority]
* [Properties]
  * [BatteryChargeStatus]
  * [BatteryLevel]
  * [HasPassThroughCamera]
  * [IsConnected]
  * [Manufacturer]
  * [Model]
  * [Priority]
  * [ReferenceSource]
  * [SimulatedBatteryChargeStatus]
  * [SimulatedBatteryLevel]
  * [SimulatedIsConnected]
  * [SimulatedManufacturer]
  * [SimulatedModel]
  * [SimulatedNodeType]
  * [SimulatedPriority]
  * [SimulatedTrackingType]
  * [TrackingType]
  * [XRNodeType]
* [Methods]
  * [SetBatteryChargeStatus(Int32)]
  * [SetSimulatedNodeType(Int32)]
  * [SetSimulatedTrackingType(Int32)]

## Details

##### Inheritance

* System.Object
* SimulatorNodeRecord

##### Namespace

* [Tilia.CameraRigs.SpatialSimulator]

##### Syntax

```
public class SimulatorNodeRecord : BaseDeviceDetailsRecord
```

### Fields

#### defaultPriority

The default priority to set the simulated priority to.

##### Declaration

```
protected const int defaultPriority = 1000
```

### Properties

#### BatteryChargeStatus

##### Declaration

```
public override BatteryStatus BatteryChargeStatus { get; protected set; }
```

#### BatteryLevel

##### Declaration

```
public override float BatteryLevel { get; protected set; }
```

#### HasPassThroughCamera

##### Declaration

```
public override bool HasPassThroughCamera { get; protected set; }
```

#### IsConnected

##### Declaration

```
public override bool IsConnected { get; protected set; }
```

#### Manufacturer

##### Declaration

```
public override string Manufacturer { get; protected set; }
```

#### Model

##### Declaration

```
public override string Model { get; protected set; }
```

#### Priority

##### Declaration

```
public override int Priority { get; protected set; }
```

#### ReferenceSource

The source reference GameObject to determine priority from.

##### Declaration

```
public GameObject ReferenceSource { get; set; }
```

#### SimulatedBatteryChargeStatus

The simulated battery status.

##### Declaration

```
public BatteryStatus SimulatedBatteryChargeStatus { get; set; }
```

#### SimulatedBatteryLevel

The simulated battery level.

##### Declaration

```
public float SimulatedBatteryLevel { get; set; }
```

#### SimulatedIsConnected

The simulated connection status.

##### Declaration

```
public bool SimulatedIsConnected { get; set; }
```

#### SimulatedManufacturer

The simulated manufacturer name.

##### Declaration

```
public string SimulatedManufacturer { get; set; }
```

#### SimulatedModel

The simulated model name.

##### Declaration

```
public string SimulatedModel { get; set; }
```

#### SimulatedNodeType

The source property to match against.

##### Declaration

```
public XRNode SimulatedNodeType { get; set; }
```

#### SimulatedPriority

The simulated controller priority.

##### Declaration

```
public int SimulatedPriority { get; set; }
```

#### SimulatedTrackingType

The simulated tracking type.

##### Declaration

```
public SpatialTrackingType SimulatedTrackingType { get; set; }
```

#### TrackingType

##### Declaration

```
public override SpatialTrackingType TrackingType { get; protected set; }
```

#### XRNodeType

##### Declaration

```
public override XRNode XRNodeType { get; protected set; }
```

### Methods

#### SetBatteryChargeStatus(Int32)

Sets the [BatteryChargeStatus].

##### Declaration

```
public virtual void SetBatteryChargeStatus(int index)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int32 | index | The index of the BatteryStatus. |

#### SetSimulatedNodeType(Int32)

Sets the [SimulatedNodeType].

##### Declaration

```
public virtual void SetSimulatedNodeType(int index)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int32 | index | The index of the XRNode. |

#### SetSimulatedTrackingType(Int32)

Sets the [SimulatedTrackingType].

##### Declaration

```
public virtual void SetSimulatedTrackingType(int index)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int32 | index | The index of the SpatialTrackingType. |

[Tilia.CameraRigs.SpatialSimulator]: README.md
[BatteryChargeStatus]: SimulatorNodeRecord.md#BatteryChargeStatus
[SimulatedNodeType]: SimulatorNodeRecord.md#SimulatedNodeType
[SimulatedTrackingType]: SimulatorNodeRecord.md#SimulatedTrackingType
[Inheritance]: #Inheritance
[Namespace]: #Namespace
[Syntax]: #Syntax
[Fields]: #Fields
[defaultPriority]: #defaultPriority
[Properties]: #Properties
[BatteryChargeStatus]: #BatteryChargeStatus
[BatteryLevel]: #BatteryLevel
[HasPassThroughCamera]: #HasPassThroughCamera
[IsConnected]: #IsConnected
[Manufacturer]: #Manufacturer
[Model]: #Model
[Priority]: #Priority
[ReferenceSource]: #ReferenceSource
[SimulatedBatteryChargeStatus]: #SimulatedBatteryChargeStatus
[SimulatedBatteryLevel]: #SimulatedBatteryLevel
[SimulatedIsConnected]: #SimulatedIsConnected
[SimulatedManufacturer]: #SimulatedManufacturer
[SimulatedModel]: #SimulatedModel
[SimulatedNodeType]: #SimulatedNodeType
[SimulatedPriority]: #SimulatedPriority
[SimulatedTrackingType]: #SimulatedTrackingType
[TrackingType]: #TrackingType
[XRNodeType]: #XRNodeType
[Methods]: #Methods
[SetBatteryChargeStatus(Int32)]: #SetBatteryChargeStatusInt32
[SetSimulatedNodeType(Int32)]: #SetSimulatedNodeTypeInt32
[SetSimulatedTrackingType(Int32)]: #SetSimulatedTrackingTypeInt32
