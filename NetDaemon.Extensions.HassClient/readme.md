## Overview

Extensions used to perform *CRUD* (create, retrieve, update, delete) operations on various Home Assistant registries.

Supported registries:
- Areas
- Counters
- Devices
- Device Automations
- Device Conditions
- Device Triggers
- Entities
- Images
- Input booleans
- Input buttons
- Input date & time
- Input numbers
- Input selects
- Persons
- Shopping list
- Tags
- Timers
- Users
- Zones

## Setup

No special setup is required, just add `NetDaemon.Extensions.HassClient` namespace to your *using clauses* and
inject `IHomeAssistantConnection` in your application constructor

```csharp
  public MyApp(IHomeAssistantConnection connection)
  
```

## Usage

Most of the operations are available as a `[Operation][Item]Async`, e.g `CreatePersonAsync`, 
`UpdateImageAsync`, 'DeleteAreaAsync'. List of parameters of each operation is self documented.

```csharp

var persons = await connection.GetPersonsAsync();
await connection.UpdateAreaAsync("living_room", name: "Living Room");
var input = 
    await connection.CreateInputNumberAsync(name: "My Input Number", min:0, max:100, mode: HassInputNumberMode.Slider);
input = connection.UpdateInputNumberAsync(input.Id, unitOfmeasurement: "MHz");

await connection.DeleteInputNumberAsync(input.Id);

```










