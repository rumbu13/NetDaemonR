## Overview

Device triggers are a collection of events tied to a device. The main reasons to use device triggers instead 
of state changes are:
- state changes are not reflecting the real action (e.g double-click is reported as two succesive state changes with
  the same value at a random interval)
- there is no state change equivalent for a device trigger;
- there is no event fired corresponding to a device trigger;
- even if events or state changes are defined, device triggers are faster

## Setup

In order to use device triggers, add `NetDaemon.Extensions.DeviceTriggers` to your using list and
add the following line in `program.cs`:

```csharp
   .UseDeviceTriggers();
```

Next, inject `IDeviceTriggers` in your application constructor:

```c
  public MyApp(IDeviceTriggers triggers)
  
```

## Usage

Once injected, `IDeviceTriggers` can be used like any other `IObservable`:

```csharp
triggers
  .Where(t => t.DeviceName == "Office Chair" && t.Subtype = "tilt")
  .Subscribe(_ => HandleOfficeChairTilt())

triggers
  .Where(t => t.DeviceName == "Living Room Cube")
  .Subscribe(t => Log.WriteDebug($"Don't {t.Subtype} The Cube, it's dangerous!" )
```

Of course, device name is not guaranteed to be unique. To be sure about the triggered device,
it is advisable to use the `DeviceId` instead. In order to find a `DeviceId` and the available triggers,
start to design in Home Assistant a new automation and choose any device trigger and a corresponding action. Switch 
to *yaml mode* and you should have all the necessary details to subscribe:

```yaml
trigger:
  - platform: device
    domain: mqtt
    device_id: bb478a4241e01f54a0d753c23cce3737
    type: action
    subtype: brightness_move_up
    discovery_id: 0x2c1165fffea5dd3f action_brightness_move_up
```

You don't need to filter the triggers by all the details, `DeviceId` and 'Subtype' are enough to identify the device
and the associated trigger in the corresponding C# code:

```csharp
triggers
  .Where(t => t.DeviceId == "bb478a4241e01f54a0d753c23cce3737" && t.Subtype = "brightness_move_up")
  .Subscribe(_ => HandleBrightnessUp())
```







