# Class ObjectControllerConfigurator

Provides a way to configure settings related to the Object Controller prefab.

## Contents

* [Inheritance]
* [Namespace]
* [Syntax]
* [Properties]
  * [FacingSource]
  * [InternalMovementHorizontalAxis]
  * [InternalMovementVerticalAxis]
  * [InternalRotationCircularAxis]
  * [InternalRotationHorizontalAxis]
  * [InternalRotationVerticalAxis]
  * [MovementHorizontalAxis]
  * [MovementVerticalAxis]
  * [PositionMutator]
  * [RotationCircularAxis]
  * [RotationHorizontalAxis]
  * [RotationMutator]
  * [RotationVerticalAxis]
  * [Target]
* [Methods]
  * [OnAfterFacingSourceChange()]
  * [OnAfterMovementHorizontalAxisChange()]
  * [OnAfterMovementVerticalAxisChange()]
  * [OnAfterRotationCircularAxisChange()]
  * [OnAfterRotationHorizontalAxisChange()]
  * [OnAfterRotationVerticalAxisChange()]
  * [OnAfterTargetChange()]
  * [OnEnable()]

## Details

##### Inheritance

* System.Object
* ObjectControllerConfigurator

##### Namespace

* [Tilia.CameraRigs.SpatialSimulator]

##### Syntax

```
public class ObjectControllerConfigurator : MonoBehaviour
```

### Properties

#### FacingSource

An optional GameObject to use as the facing direction when performing position transformations.

##### Declaration

```
public GameObject FacingSource { get; set; }
```

#### InternalMovementHorizontalAxis

The internal FloatAction that controls the horizontal movement values.

##### Declaration

```
public FloatAction InternalMovementHorizontalAxis { get; set; }
```

#### InternalMovementVerticalAxis

The internal FloatAction that controls the vertical movement values.

##### Declaration

```
public FloatAction InternalMovementVerticalAxis { get; set; }
```

#### InternalRotationCircularAxis

The internal FloatAction that controls the circular rotation values.

##### Declaration

```
public FloatAction InternalRotationCircularAxis { get; set; }
```

#### InternalRotationHorizontalAxis

The internal FloatAction that controls the horizontal rotation values.

##### Declaration

```
public FloatAction InternalRotationHorizontalAxis { get; set; }
```

#### InternalRotationVerticalAxis

The internal FloatAction that controls the vertical rotation values.

##### Declaration

```
public FloatAction InternalRotationVerticalAxis { get; set; }
```

#### MovementHorizontalAxis

The horizontal axis that controls the movement of the [Target].

##### Declaration

```
public FloatAction MovementHorizontalAxis { get; set; }
```

#### MovementVerticalAxis

The vertical axis that controls the movement of the [Target].

##### Declaration

```
public FloatAction MovementVerticalAxis { get; set; }
```

#### PositionMutator

The TransformPositionMutator that applies the movement to the [Target].

##### Declaration

```
public TransformPositionMutator PositionMutator { get; protected set; }
```

#### RotationCircularAxis

The circular axis that controls the rotation of the [Target].

##### Declaration

```
public FloatAction RotationCircularAxis { get; set; }
```

#### RotationHorizontalAxis

The horizontal axis that controls the rotation of the [Target].

##### Declaration

```
public FloatAction RotationHorizontalAxis { get; set; }
```

#### RotationMutator

The TransformEulerRotationMutator that applies the rotation to the [Target].

##### Declaration

```
public TransformEulerRotationMutator RotationMutator { get; protected set; }
```

#### RotationVerticalAxis

The vertical axis that controls the rotation of the [Target].

##### Declaration

```
public FloatAction RotationVerticalAxis { get; set; }
```

#### Target

The GameObject to update position and rotation of.

##### Declaration

```
public GameObject Target { get; set; }
```

### Methods

#### OnAfterFacingSourceChange()

Called after [FacingSource] has been changed.

##### Declaration

```
protected virtual void OnAfterFacingSourceChange()
```

#### OnAfterMovementHorizontalAxisChange()

Called after [MovementHorizontalAxis] has been changed.

##### Declaration

```
protected virtual void OnAfterMovementHorizontalAxisChange()
```

#### OnAfterMovementVerticalAxisChange()

Called after [MovementVerticalAxis] has been changed.

##### Declaration

```
protected virtual void OnAfterMovementVerticalAxisChange()
```

#### OnAfterRotationCircularAxisChange()

Called after [RotationCircularAxis] has been changed.

##### Declaration

```
protected virtual void OnAfterRotationCircularAxisChange()
```

#### OnAfterRotationHorizontalAxisChange()

Called after [RotationHorizontalAxis] has been changed.

##### Declaration

```
protected virtual void OnAfterRotationHorizontalAxisChange()
```

#### OnAfterRotationVerticalAxisChange()

Called after [RotationVerticalAxis] has been changed.

##### Declaration

```
protected virtual void OnAfterRotationVerticalAxisChange()
```

#### OnAfterTargetChange()

Called after [Target] has been changed.

##### Declaration

```
protected virtual void OnAfterTargetChange()
```

#### OnEnable()

##### Declaration

```
protected virtual void OnEnable()
```

[Tilia.CameraRigs.SpatialSimulator]: README.md
[Target]: ObjectControllerConfigurator.md#Target
[Target]: ObjectControllerConfigurator.md#Target
[Target]: ObjectControllerConfigurator.md#Target
[Target]: ObjectControllerConfigurator.md#Target
[Target]: ObjectControllerConfigurator.md#Target
[Target]: ObjectControllerConfigurator.md#Target
[Target]: ObjectControllerConfigurator.md#Target
[FacingSource]: ObjectControllerConfigurator.md#FacingSource
[MovementHorizontalAxis]: ObjectControllerConfigurator.md#MovementHorizontalAxis
[MovementVerticalAxis]: ObjectControllerConfigurator.md#MovementVerticalAxis
[RotationCircularAxis]: ObjectControllerConfigurator.md#RotationCircularAxis
[RotationHorizontalAxis]: ObjectControllerConfigurator.md#RotationHorizontalAxis
[RotationVerticalAxis]: ObjectControllerConfigurator.md#RotationVerticalAxis
[Target]: ObjectControllerConfigurator.md#Target
[Inheritance]: #Inheritance
[Namespace]: #Namespace
[Syntax]: #Syntax
[Properties]: #Properties
[FacingSource]: #FacingSource
[InternalMovementHorizontalAxis]: #InternalMovementHorizontalAxis
[InternalMovementVerticalAxis]: #InternalMovementVerticalAxis
[InternalRotationCircularAxis]: #InternalRotationCircularAxis
[InternalRotationHorizontalAxis]: #InternalRotationHorizontalAxis
[InternalRotationVerticalAxis]: #InternalRotationVerticalAxis
[MovementHorizontalAxis]: #MovementHorizontalAxis
[MovementVerticalAxis]: #MovementVerticalAxis
[PositionMutator]: #PositionMutator
[RotationCircularAxis]: #RotationCircularAxis
[RotationHorizontalAxis]: #RotationHorizontalAxis
[RotationMutator]: #RotationMutator
[RotationVerticalAxis]: #RotationVerticalAxis
[Target]: #Target
[Methods]: #Methods
[OnAfterFacingSourceChange()]: #OnAfterFacingSourceChange
[OnAfterMovementHorizontalAxisChange()]: #OnAfterMovementHorizontalAxisChange
[OnAfterMovementVerticalAxisChange()]: #OnAfterMovementVerticalAxisChange
[OnAfterRotationCircularAxisChange()]: #OnAfterRotationCircularAxisChange
[OnAfterRotationHorizontalAxisChange()]: #OnAfterRotationHorizontalAxisChange
[OnAfterRotationVerticalAxisChange()]: #OnAfterRotationVerticalAxisChange
[OnAfterTargetChange()]: #OnAfterTargetChange
[OnEnable()]: #OnEnable
