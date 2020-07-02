# Class TransformPropertyResetter

Resets the saved properties of a given transform.

## Contents

* [Inheritance]
* [Namespace]
* [Syntax]
* [Fields]
  * [initialLocalPosition]
  * [initialLocalRotation]
  * [initialLocalScale]
  * [propertiesCached]
* [Properties]
  * [Target]
* [Methods]
  * [Awake()]
  * [CacheTransformData()]
  * [OnAfterTargetChange()]
  * [ResetProperties()]

## Details

##### Inheritance

* System.Object
* TransformPropertyResetter

##### Namespace

* [Tilia.CameraRigs.SpatialSimulator]

##### Syntax

```
public class TransformPropertyResetter : MonoBehaviour
```

### Fields

#### initialLocalPosition

The initial local position of the [Target].

##### Declaration

```
protected Vector3 initialLocalPosition
```

#### initialLocalRotation

The initial local rotation of the [Target].

##### Declaration

```
protected Quaternion initialLocalRotation
```

#### initialLocalScale

The initial local scale of the [Target].

##### Declaration

```
protected Vector3 initialLocalScale
```

#### propertiesCached

Determines whether the properties have been cached.

##### Declaration

```
protected bool propertiesCached
```

### Properties

#### Target

The GameObject.transform to cache and reset.

##### Declaration

```
public GameObject Target { get; set; }
```

### Methods

#### Awake()

##### Declaration

```
protected virtual void Awake()
```

#### CacheTransformData()

Caches the initial state of the [Target] transform data.

##### Declaration

```
protected virtual void CacheTransformData()
```

#### OnAfterTargetChange()

Called after [Target] has been changed.

##### Declaration

```
protected virtual void OnAfterTargetChange()
```

#### ResetProperties()

Resets to the cached properties.

##### Declaration

```
public virtual void ResetProperties()
```

[Tilia.CameraRigs.SpatialSimulator]: README.md
[Target]: TransformPropertyResetter.md#Target
[Target]: TransformPropertyResetter.md#Target
[Target]: TransformPropertyResetter.md#Target
[Target]: TransformPropertyResetter.md#Target
[Target]: TransformPropertyResetter.md#Target
[Inheritance]: #Inheritance
[Namespace]: #Namespace
[Syntax]: #Syntax
[Fields]: #Fields
[initialLocalPosition]: #initialLocalPosition
[initialLocalRotation]: #initialLocalRotation
[initialLocalScale]: #initialLocalScale
[propertiesCached]: #propertiesCached
[Properties]: #Properties
[Target]: #Target
[Methods]: #Methods
[Awake()]: #Awake
[CacheTransformData()]: #CacheTransformData
[OnAfterTargetChange()]: #OnAfterTargetChange
[ResetProperties()]: #ResetProperties
