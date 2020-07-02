# Class SpatialSimulatorConfigurator

Provides a way to configure settings related to the Spatial Simulator prefab.

## Contents

* [Inheritance]
* [Namespace]
* [Syntax]
* [Fields]
  * [initialFixedDeltaTime]
  * [initialXRSettingsEnabledState]
* [Properties]
  * [SimulatedFrameRate]
  * [XREnabled]
* [Methods]
  * [OnAfterSimulatedFrameRateChange()]
  * [OnAfterXREnabledChange()]
  * [OnDisable()]
  * [OnEnable()]

## Details

##### Inheritance

* System.Object
* SpatialSimulatorConfigurator

##### Namespace

* [Tilia.CameraRigs.SpatialSimulator]

##### Syntax

```
public class SpatialSimulatorConfigurator : MonoBehaviour
```

### Fields

#### initialFixedDeltaTime

##### Declaration

```
protected float initialFixedDeltaTime
```

#### initialXRSettingsEnabledState

##### Declaration

```
protected bool initialXRSettingsEnabledState
```

### Properties

#### SimulatedFrameRate

The frame rate to simulate with fixedDeltaTime.

##### Declaration

```
public float SimulatedFrameRate { get; set; }
```

#### XREnabled

Determines whether any connected XR device orientation will be detected.

##### Declaration

```
public bool XREnabled { get; set; }
```

### Methods

#### OnAfterSimulatedFrameRateChange()

Called after [SimulatedFrameRate] has been changed.

##### Declaration

```
protected virtual void OnAfterSimulatedFrameRateChange()
```

#### OnAfterXREnabledChange()

Called after [XREnabled] has been changed.

##### Declaration

```
protected virtual void OnAfterXREnabledChange()
```

#### OnDisable()

##### Declaration

```
protected virtual void OnDisable()
```

#### OnEnable()

##### Declaration

```
protected virtual void OnEnable()
```

[Tilia.CameraRigs.SpatialSimulator]: README.md
[SimulatedFrameRate]: SpatialSimulatorConfigurator.md#SimulatedFrameRate
[XREnabled]: SpatialSimulatorConfigurator.md#XREnabled
[Inheritance]: #Inheritance
[Namespace]: #Namespace
[Syntax]: #Syntax
[Fields]: #Fields
[initialFixedDeltaTime]: #initialFixedDeltaTime
[initialXRSettingsEnabledState]: #initialXRSettingsEnabledState
[Properties]: #Properties
[SimulatedFrameRate]: #SimulatedFrameRate
[XREnabled]: #XREnabled
[Methods]: #Methods
[OnAfterSimulatedFrameRateChange()]: #OnAfterSimulatedFrameRateChange
[OnAfterXREnabledChange()]: #OnAfterXREnabledChange
[OnDisable()]: #OnDisable
[OnEnable()]: #OnEnable
