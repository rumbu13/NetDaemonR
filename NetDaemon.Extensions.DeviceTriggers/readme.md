## Overview

Device triggers are a collection of events tied to a device. The main reasons to use device triggers instead 
of state changes are:
- there is no state change equivalent for a device trigger;
- there is no event fired corresponding to a device trigger;
- device triggers are faster than corresponding events or state changes if they exist;

## Setup

In order to use device triggers, add `NetDaemon.Extensions.DeviceTriggers` to your using list and
add the following line in `program.cs`:

```csharp
   .UseDeviceTriggers();
```

Next, inject `IDeviceTriggers` in tour application constructor:

```c
  public MyApp(IDeviceTriggers triggers)
  
```

## Usage

Once injected, `IDeviceTriggers` can be used like any other `IObservable`:

```csharp
triggers
  .Where(t => t.DeviceName == "Office Chair" && t.Subtype = "tilt")
  .Subscribe(_ => HandleOfficeChairTilt())
```

Of course, device name is not guaranteed to be unique. To be sure about the triggered device,
it is advisable to use the `device_id` instead. In order to find a `device_id` and the available triggers,
start in Home Assistant a new automation and choose any device trigger and a corresponding action. Switch to yaml mode 
and you should have all the necessary details to subscribe:

YAML:

```yaml
trigger:
  - platform: device
    domain: mqtt
    device_id: bb478a4241e01f54a0d753c23cce3737
    type: action
    subtype: brightness_move_up
    discovery_id: 0x2c1165fffea5dd3f action_brightness_move_up
```

C#:

```csharp
triggers
  .Where(t => t.DeviceId == "bb478a4241e01f54a0d753c23cce3737" && t.Subtype = "brightness_move_up")
  .Subscribe(_ => HandleBrightnessUp())
```







