using System;
using System.Collections.Generic;
using NetDaemon.HassModel;
using NetDaemon.HassModel.Entities;
using NetDaemon.HassModel.Entities.Core;
using System.Text.Json.Serialization;

namespace NetDaemonApps
{
	public interface IEntities
	{
		AlarmControlPanelEntities AlarmControlPanel { get; }

		BinarySensorEntities BinarySensor { get; }

		ButtonEntities Button { get; }

		CalendarEntities Calendar { get; }

		CameraEntities Camera { get; }

		ClimateEntities Climate { get; }

		CounterEntities Counter { get; }

		CoverEntities Cover { get; }

		DeviceTrackerEntities DeviceTracker { get; }

		InputBooleanEntities InputBoolean { get; }

		InputButtonEntities InputButton { get; }

		InputDatetimeEntities InputDatetime { get; }

		InputNumberEntities InputNumber { get; }

		InputSelectEntities InputSelect { get; }

		InputTextEntities InputText { get; }

		LightEntities Light { get; }

		MediaPlayerEntities MediaPlayer { get; }

		NumberEntities Number { get; }

		PersonEntities Person { get; }

		ProximityEntities Proximity { get; }

		RemoteEntities Remote { get; }

		SelectEntities Select { get; }

		SensorEntities Sensor { get; }

		SunEntities Sun { get; }

		SwitchEntities Switch { get; }

		TimerEntities Timer { get; }

		UpdateEntities Update { get; }

		VacuumEntities Vacuum { get; }

		WeatherEntities Weather { get; }

		ZoneEntities Zone { get; }
	}

	public partial class Entities : IEntities
	{
		private readonly IHaContext _haContext;
		public Entities(IHaContext haContext)
		{
			_haContext = haContext;
		}

		public AlarmControlPanelEntities AlarmControlPanel => new(_haContext);
		public BinarySensorEntities BinarySensor => new(_haContext);
		public ButtonEntities Button => new(_haContext);
		public CalendarEntities Calendar => new(_haContext);
		public CameraEntities Camera => new(_haContext);
		public ClimateEntities Climate => new(_haContext);
		public CounterEntities Counter => new(_haContext);
		public CoverEntities Cover => new(_haContext);
		public DeviceTrackerEntities DeviceTracker => new(_haContext);
		public InputBooleanEntities InputBoolean => new(_haContext);
		public InputButtonEntities InputButton => new(_haContext);
		public InputDatetimeEntities InputDatetime => new(_haContext);
		public InputNumberEntities InputNumber => new(_haContext);
		public InputSelectEntities InputSelect => new(_haContext);
		public InputTextEntities InputText => new(_haContext);
		public LightEntities Light => new(_haContext);
		public MediaPlayerEntities MediaPlayer => new(_haContext);
		public NumberEntities Number => new(_haContext);
		public PersonEntities Person => new(_haContext);
		public ProximityEntities Proximity => new(_haContext);
		public RemoteEntities Remote => new(_haContext);
		public SelectEntities Select => new(_haContext);
		public SensorEntities Sensor => new(_haContext);
		public SunEntities Sun => new(_haContext);
		public SwitchEntities Switch => new(_haContext);
		public TimerEntities Timer => new(_haContext);
		public UpdateEntities Update => new(_haContext);
		public VacuumEntities Vacuum => new(_haContext);
		public WeatherEntities Weather => new(_haContext);
		public ZoneEntities Zone => new(_haContext);
	}

	public partial class AlarmControlPanelEntities
	{
		private readonly IHaContext _haContext;
		public AlarmControlPanelEntities(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Fire</summary>
		public AlarmControlPanelEntity Fire => new(_haContext, "alarm_control_panel.fire");
		///<summary>Intrusion</summary>
		public AlarmControlPanelEntity Intrusion => new(_haContext, "alarm_control_panel.intrusion");
		///<summary>Water Leak</summary>
		public AlarmControlPanelEntity WaterLeak => new(_haContext, "alarm_control_panel.water_leak");
	}

	public partial class BinarySensorEntities
	{
		private readonly IHaContext _haContext;
		public BinarySensorEntities(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Agriculture Watering</summary>
		public BinarySensorEntity AgriculturaWatering => new(_haContext, "binary_sensor.agricultura_watering");
		///<summary>Attic Ladder contact</summary>
		public BinarySensorEntity AtticLadderContact => new(_haContext, "binary_sensor.attic_ladder_contact");
		///<summary>Attic Ladder Contact Heat</summary>
		public BinarySensorEntity AtticLadderContactHeat => new(_haContext, "binary_sensor.attic_ladder_contact_heat");
		///<summary>Attic Ladder Contact Temperature Rising</summary>
		public BinarySensorEntity AtticLadderContactTemperatureRising => new(_haContext, "binary_sensor.attic_ladder_contact_temperature_rising");
		///<summary>Attic Ladder Moving</summary>
		public BinarySensorEntity AtticLadderMoving => new(_haContext, "binary_sensor.attic_ladder_moving");
		///<summary>Attic Occupancy</summary>
		public BinarySensorEntity AtticOccupancy => new(_haContext, "binary_sensor.attic_occupancy");
		///<summary>Bathroom Door Contact</summary>
		public BinarySensorEntity BathroomDoorContact => new(_haContext, "binary_sensor.bathroom_door_contact");
		///<summary>Bathroom Door Contact Heat</summary>
		public BinarySensorEntity BathroomDoorContactHeat => new(_haContext, "binary_sensor.bathroom_door_contact_heat");
		///<summary>Bathroom Door Contact Temperature Rising</summary>
		public BinarySensorEntity BathroomDoorContactTemperatureRising => new(_haContext, "binary_sensor.bathroom_door_contact_temperature_rising");
		///<summary>Bathroom Door Moving</summary>
		public BinarySensorEntity BathroomDoorMoving => new(_haContext, "binary_sensor.bathroom_door_moving");
		///<summary>Bathroom Motion Sensor Battery Low</summary>
		public BinarySensorEntity BathroomMotionSensorBatteryLow => new(_haContext, "binary_sensor.bathroom_motion_sensor_battery_low");
		///<summary>Bathroom Motion Sensor Motion</summary>
		public BinarySensorEntity BathroomMotionSensorMotion => new(_haContext, "binary_sensor.bathroom_motion_sensor_motion");
		///<summary>Bathroom Motion Sensor Tamper</summary>
		public BinarySensorEntity BathroomMotionSensorTamper => new(_haContext, "binary_sensor.bathroom_motion_sensor_tamper");
		///<summary>Bathroom Occupancy</summary>
		public BinarySensorEntity BathroomOccupancy => new(_haContext, "binary_sensor.bathroom_occupancy");
		///<summary>Bathroom Water Leak Sensor battery low</summary>
		public BinarySensorEntity BathroomWaterLeakSensorBatteryLow => new(_haContext, "binary_sensor.bathroom_water_leak_sensor_battery_low");
		///<summary>Bathroom Water Leak Sensor Heat</summary>
		public BinarySensorEntity BathroomWaterLeakSensorHeat => new(_haContext, "binary_sensor.bathroom_water_leak_sensor_heat");
		///<summary>Bathroom Water Leak Sensor Temperature Rising</summary>
		public BinarySensorEntity BathroomWaterLeakSensorTemperatureRising => new(_haContext, "binary_sensor.bathroom_water_leak_sensor_temperature_rising");
		///<summary>Bathroom Water Leak Sensor Water Leak</summary>
		public BinarySensorEntity BathroomWaterLeakSensorWaterLeak => new(_haContext, "binary_sensor.bathroom_water_leak_sensor_water_leak");
		///<summary>Bathroom Weather Sensor Heat</summary>
		public BinarySensorEntity BathroomWeatherSensorHeat => new(_haContext, "binary_sensor.bathroom_weather_sensor_heat");
		///<summary>Bathroom Weather Sensor Temperature Rising</summary>
		public BinarySensorEntity BathroomWeatherSensorTemperatureRising => new(_haContext, "binary_sensor.bathroom_weather_sensor_temperature_rising");
		///<summary>Bedroom AC Heat</summary>
		public BinarySensorEntity BedroomAcHeat => new(_haContext, "binary_sensor.bedroom_ac_heat");
		///<summary>Badroom AC Temperature Rising</summary>
		public BinarySensorEntity BedroomAcTemperatureRising => new(_haContext, "binary_sensor.bedroom_ac_temperature_rising");
		///<summary>Bedroom Bed Nico Vibration Sensor vibration</summary>
		public BinarySensorEntity BedroomBedNicoVibrationSensorVibration => new(_haContext, "binary_sensor.bedroom_bed_nico_vibration_sensor_vibration");
		///<summary>Bedroom Bed Razvan Vibration Sensor vibration</summary>
		public BinarySensorEntity BedroomBedRazvanVibrationSensorVibration => new(_haContext, "binary_sensor.bedroom_bed_razvan_vibration_sensor_vibration");
		///<summary>Bedroom Dimmer update available</summary>
		public BinarySensorEntity BedroomDimmerUpdateAvailable => new(_haContext, "binary_sensor.bedroom_dimmer_update_available");
		///<summary>Bedroom Door contact</summary>
		public BinarySensorEntity BedroomDoorContact => new(_haContext, "binary_sensor.bedroom_door_contact");
		///<summary>Bedroom Door Contact Heat</summary>
		public BinarySensorEntity BedroomDoorContactHeat => new(_haContext, "binary_sensor.bedroom_door_contact_heat");
		///<summary>Bedroom Door Contact Temperature Rising</summary>
		public BinarySensorEntity BedroomDoorContactTemperatureRising => new(_haContext, "binary_sensor.bedroom_door_contact_temperature_rising");
		///<summary>Bedroom Door Moving</summary>
		public BinarySensorEntity BedroomDoorMoving => new(_haContext, "binary_sensor.bedroom_door_moving");
		///<summary>Bedroom Heat</summary>
		public BinarySensorEntity BedroomHeat => new(_haContext, "binary_sensor.bedroom_heat");
		///<summary>Bedroom Motion Sensor Heat</summary>
		public BinarySensorEntity BedroomMotionSensorHeat => new(_haContext, "binary_sensor.bedroom_motion_sensor_heat");
		///<summary>Bedroom Motion Sensor Motion</summary>
		public BinarySensorEntity BedroomMotionSensorMotion => new(_haContext, "binary_sensor.bedroom_motion_sensor_motion");
		///<summary>Bedroom Motion Sensor Temperature Rising</summary>
		public BinarySensorEntity BedroomMotionSensorTemperatureRising => new(_haContext, "binary_sensor.bedroom_motion_sensor_temperature_rising");
		///<summary>Bedroom Occupancy</summary>
		public BinarySensorEntity BedroomOccupancy => new(_haContext, "binary_sensor.bedroom_occupancy");
		///<summary>Bedroom Outlet update available</summary>
		public BinarySensorEntity BedroomOutletUpdateAvailable => new(_haContext, "binary_sensor.bedroom_outlet_update_available");
		///<summary>Child Room AC Heat</summary>
		public BinarySensorEntity ChildRoomAcHeat => new(_haContext, "binary_sensor.child_room_ac_heat");
		///<summary>Child Room AC Temperature Rising</summary>
		public BinarySensorEntity ChildRoomAcTemperatureRising => new(_haContext, "binary_sensor.child_room_ac_temperature_rising");
		///<summary>Child Room Bed Vibration Sensor vibration</summary>
		public BinarySensorEntity ChildRoomBedVibrationSensorVibration => new(_haContext, "binary_sensor.child_room_bed_vibration_sensor_vibration");
		///<summary>Child Room Chair Vibration Sensor vibration</summary>
		public BinarySensorEntity ChildRoomChairVibrationSensorVibration => new(_haContext, "binary_sensor.child_room_chair_vibration_sensor_vibration");
		///<summary>Child Room Door contact</summary>
		public BinarySensorEntity ChildRoomDoorContact => new(_haContext, "binary_sensor.child_room_door_contact");
		///<summary>Child Room Door Contact Heat</summary>
		public BinarySensorEntity ChildRoomDoorContactHeat => new(_haContext, "binary_sensor.child_room_door_contact_heat");
		///<summary>Child Room Door Contact Temperature Rising</summary>
		public BinarySensorEntity ChildRoomDoorContactTemperatureRising => new(_haContext, "binary_sensor.child_room_door_contact_temperature_rising");
		///<summary>Child Room Door Moving</summary>
		public BinarySensorEntity ChildRoomDoorMoving => new(_haContext, "binary_sensor.child_room_door_moving");
		///<summary>Child Room Heat</summary>
		public BinarySensorEntity ChildRoomHeat => new(_haContext, "binary_sensor.child_room_heat");
		///<summary>Child Room Motion Sensor Heat</summary>
		public BinarySensorEntity ChildRoomMotionSensorHeat => new(_haContext, "binary_sensor.child_room_motion_sensor_heat");
		///<summary>Child Room Motion Sensor Motion</summary>
		public BinarySensorEntity ChildRoomMotionSensorMotion => new(_haContext, "binary_sensor.child_room_motion_sensor_motion");
		///<summary>Child Room Motion Sensor Temperature Rising</summary>
		public BinarySensorEntity ChildRoomMotionSensorTemperatureRising => new(_haContext, "binary_sensor.child_room_motion_sensor_temperature_rising");
		///<summary>Child Room Occupancy</summary>
		public BinarySensorEntity ChildRoomOccupancy => new(_haContext, "binary_sensor.child_room_occupancy");
		///<summary>Trees Watering</summary>
		public BinarySensorEntity CopaciWatering => new(_haContext, "binary_sensor.copaci_watering");
		///<summary>Dressing Door contact</summary>
		public BinarySensorEntity DressingDoorContact => new(_haContext, "binary_sensor.dressing_door_contact");
		///<summary>Dressing Door Contact Heat</summary>
		public BinarySensorEntity DressingDoorContactHeat => new(_haContext, "binary_sensor.dressing_door_contact_heat");
		///<summary>Dressing Door Contact Temperature Rising</summary>
		public BinarySensorEntity DressingDoorContactTemperatureRising => new(_haContext, "binary_sensor.dressing_door_contact_temperature_rising");
		///<summary>Dressing Door Moving</summary>
		public BinarySensorEntity DressingDoorMoving => new(_haContext, "binary_sensor.dressing_door_moving");
		///<summary>Dressing Occupancy</summary>
		public BinarySensorEntity DressingOccupancy => new(_haContext, "binary_sensor.dressing_occupancy");
		///<summary>Entry Camera Motion</summary>
		public BinarySensorEntity EntryCameraMotion => new(_haContext, "binary_sensor.entry_camera_motion");
		///<summary>Entry Camera Tamper</summary>
		public BinarySensorEntity EntryCameraTamper => new(_haContext, "binary_sensor.entry_camera_tamper");
		///<summary>Entry Camera Video Loss</summary>
		public BinarySensorEntity EntryCameraVideoLoss => new(_haContext, "binary_sensor.entry_camera_video_loss");
		///<summary>Entry Hall Door Contact</summary>
		public BinarySensorEntity EntryHallDoorContact => new(_haContext, "binary_sensor.entry_hall_door_contact");
		///<summary>Entry Hall Door Contact Heat</summary>
		public BinarySensorEntity EntryHallDoorContactHeat => new(_haContext, "binary_sensor.entry_hall_door_contact_heat");
		///<summary>Entry Hall Door Contact Temperature Rising</summary>
		public BinarySensorEntity EntryHallDoorContactTemperatureRising => new(_haContext, "binary_sensor.entry_hall_door_contact_temperature_rising");
		///<summary>Entry Hall Door Moving</summary>
		public BinarySensorEntity EntryHallDoorMoving => new(_haContext, "binary_sensor.entry_hall_door_moving");
		///<summary>Entry Hall Motion Sensor Heat</summary>
		public BinarySensorEntity EntryHallMotionSensorHeat => new(_haContext, "binary_sensor.entry_hall_motion_sensor_heat");
		///<summary>Entry Hall Motion Sensor Motion</summary>
		public BinarySensorEntity EntryHallMotionSensorMotion => new(_haContext, "binary_sensor.entry_hall_motion_sensor_motion");
		///<summary>Entry Hall Motion Sensor Temperature Rising</summary>
		public BinarySensorEntity EntryHallMotionSensorTemperatureRising => new(_haContext, "binary_sensor.entry_hall_motion_sensor_temperature_rising");
		///<summary>Entry Hall Occupancy</summary>
		public BinarySensorEntity EntryHallOccupancy => new(_haContext, "binary_sensor.entry_hall_occupancy");
		///<summary>Entry Occupancy</summary>
		public BinarySensorEntity EntryOccupancy => new(_haContext, "binary_sensor.entry_occupancy");
		///<summary>ESPresense Bedroom</summary>
		public BinarySensorEntity EspresenseBedroom => new(_haContext, "binary_sensor.espresense_bedroom");
		///<summary>ESPresense Child Room</summary>
		public BinarySensorEntity EspresenseChildRoom => new(_haContext, "binary_sensor.espresense_child_room");
		///<summary>ESPresense Kitchen</summary>
		public BinarySensorEntity EspresenseKitchen => new(_haContext, "binary_sensor.espresense_kitchen");
		///<summary>ESPresense Living Room</summary>
		public BinarySensorEntity EspresenseLivingRoom => new(_haContext, "binary_sensor.espresense_living_room");
		///<summary>ESPresense Living Room 2</summary>
		public BinarySensorEntity EspresenseLivingRoom2 => new(_haContext, "binary_sensor.espresense_living_room_2");
		///<summary>ESPresense Office</summary>
		public BinarySensorEntity EspresenseOffice => new(_haContext, "binary_sensor.espresense_office");
		///<summary>ESPresense Shed</summary>
		public BinarySensorEntity EspresenseShed => new(_haContext, "binary_sensor.espresense_shed");
		///<summary>ESPresense Tech Room</summary>
		public BinarySensorEntity EspresenseTechRoom => new(_haContext, "binary_sensor.espresense_tech_room");
		///<summary>Flowers Watering</summary>
		public BinarySensorEntity FloriWatering => new(_haContext, "binary_sensor.flori_watering");
		///<summary>Garage Camera Left Motion</summary>
		public BinarySensorEntity GarageCameraLeftMotion => new(_haContext, "binary_sensor.garage_camera_left_motion");
		///<summary>Garage Camera Left Tamper</summary>
		public BinarySensorEntity GarageCameraLeftTamper => new(_haContext, "binary_sensor.garage_camera_left_tamper");
		///<summary>Garage Camera Left Video Loss</summary>
		public BinarySensorEntity GarageCameraLeftVideoLoss => new(_haContext, "binary_sensor.garage_camera_left_video_loss");
		///<summary>Garage Camera Right Motion</summary>
		public BinarySensorEntity GarageCameraRightMotion => new(_haContext, "binary_sensor.garage_camera_right_motion");
		///<summary>Garage Camera Right Tamper</summary>
		public BinarySensorEntity GarageCameraRightTamper => new(_haContext, "binary_sensor.garage_camera_right_tamper");
		///<summary>Garage Camera Right Video Loss</summary>
		public BinarySensorEntity GarageCameraRightVideoLoss => new(_haContext, "binary_sensor.garage_camera_right_video_loss");
		///<summary>Garrage Occupancy</summary>
		public BinarySensorEntity GarrageOccupancy => new(_haContext, "binary_sensor.garrage_occupancy");
		///<summary>Gazebo Camera Motion</summary>
		public BinarySensorEntity GazeboCameraMotion => new(_haContext, "binary_sensor.gazebo_camera_motion");
		///<summary>Gazebo Camera Tamper</summary>
		public BinarySensorEntity GazeboCameraTamper => new(_haContext, "binary_sensor.gazebo_camera_tamper");
		///<summary>Gazebo Camera Video Loss</summary>
		public BinarySensorEntity GazeboCameraVideoLoss => new(_haContext, "binary_sensor.gazebo_camera_video_loss");
		///<summary>Gazebo Dimmer update available</summary>
		public BinarySensorEntity GazeboDimmerUpdateAvailable => new(_haContext, "binary_sensor.gazebo_dimmer_update_available");
		///<summary>Gazebo - Ocupat</summary>
		public BinarySensorEntity GazeboOccupancy => new(_haContext, "binary_sensor.gazebo_occupancy");
		///<summary>Gazebo Outlet update available</summary>
		public BinarySensorEntity GazeboOutletUpdateAvailable => new(_haContext, "binary_sensor.gazebo_outlet_update_available");
		///<summary>Lawn Watering</summary>
		public BinarySensorEntity GazonMareWatering => new(_haContext, "binary_sensor.gazon_mare_watering");
		///<summary>Small Lawn Watering</summary>
		public BinarySensorEntity GazonMicWatering => new(_haContext, "binary_sensor.gazon_mic_watering");
		///<summary>Home Assistant Versions Update Available</summary>
		public BinarySensorEntity HaVersionsUpdateAvailable => new(_haContext, "binary_sensor.ha_versions_update_available");
		///<summary>Hall Motion Sensor Heat</summary>
		public BinarySensorEntity HallMotionSensorHeat => new(_haContext, "binary_sensor.hall_motion_sensor_heat");
		///<summary>Hall Motion Sensor Motion</summary>
		public BinarySensorEntity HallMotionSensorMotion => new(_haContext, "binary_sensor.hall_motion_sensor_motion");
		///<summary>Hall Motion Sensor Temperature Rising</summary>
		public BinarySensorEntity HallMotionSensorTemperatureRising => new(_haContext, "binary_sensor.hall_motion_sensor_temperature_rising");
		///<summary>Hall Occupancy</summary>
		public BinarySensorEntity HallOccupancy => new(_haContext, "binary_sensor.hall_occupancy");
		///<summary>House Occupancy</summary>
		public BinarySensorEntity HouseOccupancy => new(_haContext, "binary_sensor.house_occupancy");
		///<summary>Kitchen Button update available</summary>
		public BinarySensorEntity KitchenButtonUpdateAvailable => new(_haContext, "binary_sensor.kitchen_button_update_available");
		///<summary>Kitchen Coffee Maker Remote Start</summary>
		public BinarySensorEntity KitchenCoffeeMakerRemoteStart => new(_haContext, "binary_sensor.kitchen_coffee_maker_remote_start");
		///<summary>Kitchen Dimmer update available</summary>
		public BinarySensorEntity KitchenDimmerUpdateAvailable => new(_haContext, "binary_sensor.kitchen_dimmer_update_available");
		///<summary>Kitchen Fridge Door Open</summary>
		public BinarySensorEntity KitchenFridgeDoorOpen => new(_haContext, "binary_sensor.kitchen_fridge_door_open");
		///<summary>Kitchen Heat</summary>
		public BinarySensorEntity KitchenHeat => new(_haContext, "binary_sensor.kitchen_heat");
		///<summary>Kitchen Heat Detector Battery Low</summary>
		public BinarySensorEntity KitchenHeatDetectorBatteryLow => new(_haContext, "binary_sensor.kitchen_heat_detector_battery_low");
		///<summary>Kitchen Heat Detector Fault</summary>
		public BinarySensorEntity KitchenHeatDetectorFault => new(_haContext, "binary_sensor.kitchen_heat_detector_fault");
		///<summary>Kitchen Heat Detector Heat</summary>
		public BinarySensorEntity KitchenHeatDetectorHeat => new(_haContext, "binary_sensor.kitchen_heat_detector_heat");
		///<summary>Kitchen Heat Detector Test</summary>
		public BinarySensorEntity KitchenHeatDetectorTest => new(_haContext, "binary_sensor.kitchen_heat_detector_test");
		///<summary>Kitchen Motion Sensor Heat</summary>
		public BinarySensorEntity KitchenMotionSensorHeat => new(_haContext, "binary_sensor.kitchen_motion_sensor_heat");
		///<summary>Kitchen Motion Sensor Motion</summary>
		public BinarySensorEntity KitchenMotionSensorMotion => new(_haContext, "binary_sensor.kitchen_motion_sensor_motion");
		///<summary>Kitchen Motion Sensor Temperature Rising</summary>
		public BinarySensorEntity KitchenMotionSensorTemperatureRising => new(_haContext, "binary_sensor.kitchen_motion_sensor_temperature_rising");
		///<summary>Kitchen Occupancy</summary>
		public BinarySensorEntity KitchenOccupancy => new(_haContext, "binary_sensor.kitchen_occupancy");
		///<summary>Kitchen Outlet Right update available</summary>
		public BinarySensorEntity KitchenOutletRightUpdateAvailable => new(_haContext, "binary_sensor.kitchen_outlet_right_update_available");
		///<summary>Kitchen Smoke Detector Battery Low</summary>
		public BinarySensorEntity KitchenSmokeDetectorBatteryLow => new(_haContext, "binary_sensor.kitchen_smoke_detector_battery_low");
		///<summary>Kitchen Smoke Detector Fault</summary>
		public BinarySensorEntity KitchenSmokeDetectorFault => new(_haContext, "binary_sensor.kitchen_smoke_detector_fault");
		///<summary>Kitchen Smoke Detector Heat</summary>
		public BinarySensorEntity KitchenSmokeDetectorHeat => new(_haContext, "binary_sensor.kitchen_smoke_detector_heat");
		///<summary>Kitchen Smoke Detector Smoke</summary>
		public BinarySensorEntity KitchenSmokeDetectorSmoke => new(_haContext, "binary_sensor.kitchen_smoke_detector_smoke");
		///<summary>Kitchen Smoke Detector Test</summary>
		public BinarySensorEntity KitchenSmokeDetectorTest => new(_haContext, "binary_sensor.kitchen_smoke_detector_test");
		///<summary>Kitchen Smoke Detector Update Available</summary>
		public BinarySensorEntity KitchenSmokeDetectorUpdateAvailable => new(_haContext, "binary_sensor.kitchen_smoke_detector_update_available");
		///<summary>Kitchen Smoke Detector Temperature Rising</summary>
		public BinarySensorEntity KitchenSmokeTemperatureRising => new(_haContext, "binary_sensor.kitchen_smoke_temperature_rising");
		///<summary>Kitchen Water Leak Sensor Battery Low</summary>
		public BinarySensorEntity KitchenWaterLeakSensorBatteryLow => new(_haContext, "binary_sensor.kitchen_water_leak_sensor_battery_low");
		///<summary>Kitchen Water Leak Sensor Water Leak</summary>
		public BinarySensorEntity KitchenWaterLeakSensorWaterLeak => new(_haContext, "binary_sensor.kitchen_water_leak_sensor_water_leak");
		///<summary>Lawn Camera Left Motion</summary>
		public BinarySensorEntity LawnCameraLeftMotion => new(_haContext, "binary_sensor.lawn_camera_left_motion");
		///<summary>Lawn Camera Left Tamper</summary>
		public BinarySensorEntity LawnCameraLeftTamper => new(_haContext, "binary_sensor.lawn_camera_left_tamper");
		///<summary>Lawn Camera Left Video Loss</summary>
		public BinarySensorEntity LawnCameraLeftVideoLoss => new(_haContext, "binary_sensor.lawn_camera_left_video_loss");
		///<summary>Lawn Camera Right Motion</summary>
		public BinarySensorEntity LawnCameraRightMotion => new(_haContext, "binary_sensor.lawn_camera_right_motion");
		///<summary>Lawn Camera Right Tamper</summary>
		public BinarySensorEntity LawnCameraRightTamper => new(_haContext, "binary_sensor.lawn_camera_right_tamper");
		///<summary>Lawn Camera Right Video Loss</summary>
		public BinarySensorEntity LawnCameraRightVideoLoss => new(_haContext, "binary_sensor.lawn_camera_right_video_loss");
		///<summary>Lawn Occupancy</summary>
		public BinarySensorEntity LawnOccupancy => new(_haContext, "binary_sensor.lawn_occupancy");
		///<summary>Living Room AC Heat</summary>
		public BinarySensorEntity LivingRoomAcHeat => new(_haContext, "binary_sensor.living_room_ac_heat");
		///<summary>Living Room AC Temperature Rising</summary>
		public BinarySensorEntity LivingRoomAcTemperatureRising => new(_haContext, "binary_sensor.living_room_ac_temperature_rising");
		///<summary>Living Room Door Contact</summary>
		public BinarySensorEntity LivingRoomDoorContact => new(_haContext, "binary_sensor.living_room_door_contact");
		///<summary>Living Room Door Contact Heat</summary>
		public BinarySensorEntity LivingRoomDoorContactHeat => new(_haContext, "binary_sensor.living_room_door_contact_heat");
		///<summary>Living Room Door Contact Temperature Rising</summary>
		public BinarySensorEntity LivingRoomDoorContactTemperatureRising => new(_haContext, "binary_sensor.living_room_door_contact_temperature_rising");
		///<summary>Living Room Door Moving</summary>
		public BinarySensorEntity LivingRoomDoorMoving => new(_haContext, "binary_sensor.living_room_door_moving");
		///<summary>Living Room Heat</summary>
		public BinarySensorEntity LivingRoomHeat => new(_haContext, "binary_sensor.living_room_heat");
		///<summary>Living Room Motion Sensor Heat</summary>
		public BinarySensorEntity LivingRoomMotionSensorHeat => new(_haContext, "binary_sensor.living_room_motion_sensor_heat");
		///<summary>Living Room Motion Sensor Temperature Rising</summary>
		public BinarySensorEntity LivingRoomMotionSensorTemperatureRising => new(_haContext, "binary_sensor.living_room_motion_sensor_temperature_rising");
		///<summary>Living Room Motion Sensor Motion</summary>
		public BinarySensorEntity LivingRoomMotionSesnorMotion => new(_haContext, "binary_sensor.living_room_motion_sesnor_motion");
		///<summary>Living Room Occupancy</summary>
		public BinarySensorEntity LivingRoomOccupancy => new(_haContext, "binary_sensor.living_room_occupancy");
		///<summary>Living Room Tablet Is Charging</summary>
		public BinarySensorEntity LivingRoomTabletIsCharging => new(_haContext, "binary_sensor.living_room_tablet_is_charging");
		///<summary>Living Room Vacuum Mop Attached</summary>
		public BinarySensorEntity LivingRoomVacuumMopAttached => new(_haContext, "binary_sensor.living_room_vacuum_mop_attached");
		///<summary>Living Room Vacuum Water Box Attached</summary>
		public BinarySensorEntity LivingRoomVacuumWaterBoxAttached => new(_haContext, "binary_sensor.living_room_vacuum_water_box_attached");
		///<summary>Nico Phone Phone App Inactive</summary>
		public BinarySensorEntity NicoPhoneAppInactive => new(_haContext, "binary_sensor.nico_phone_app_inactive");
		///<summary>Nico Phone Bluetooth State</summary>
		public BinarySensorEntity NicoPhoneBluetoothState => new(_haContext, "binary_sensor.nico_phone_bluetooth_state");
		///<summary>Nico Phone Device Locked</summary>
		public BinarySensorEntity NicoPhoneDeviceLocked => new(_haContext, "binary_sensor.nico_phone_device_locked");
		///<summary>Nico Phone Device Secure</summary>
		public BinarySensorEntity NicoPhoneDeviceSecure => new(_haContext, "binary_sensor.nico_phone_device_secure");
		///<summary>Nico Phone Doze Mode</summary>
		public BinarySensorEntity NicoPhoneDozeMode => new(_haContext, "binary_sensor.nico_phone_doze_mode");
		///<summary>Nico Phone Headphones</summary>
		public BinarySensorEntity NicoPhoneHeadphones => new(_haContext, "binary_sensor.nico_phone_headphones");
		///<summary>Nico Phone Hig Accuracy Mode</summary>
		public BinarySensorEntity NicoPhoneHighAccuracyMode => new(_haContext, "binary_sensor.nico_phone_high_accuracy_mode");
		///<summary>Nico Phone Interactive</summary>
		public BinarySensorEntity NicoPhoneInteractive => new(_haContext, "binary_sensor.nico_phone_interactive");
		///<summary>nico_phone Is Charging</summary>
		public BinarySensorEntity NicoPhoneIsCharging => new(_haContext, "binary_sensor.nico_phone_is_charging");
		///<summary>Nico Phone Keyguard Locked</summary>
		public BinarySensorEntity NicoPhoneKeyguardLocked => new(_haContext, "binary_sensor.nico_phone_keyguard_locked");
		///<summary>Nico Phone Keyguard Secure</summary>
		public BinarySensorEntity NicoPhoneKeyguardSecure => new(_haContext, "binary_sensor.nico_phone_keyguard_secure");
		///<summary>Nico Phone Mic Muted</summary>
		public BinarySensorEntity NicoPhoneMicMuted => new(_haContext, "binary_sensor.nico_phone_mic_muted");
		///<summary>Nico Phone Mobile Data</summary>
		public BinarySensorEntity NicoPhoneMobileData => new(_haContext, "binary_sensor.nico_phone_mobile_data");
		///<summary>Nico Phone Mobile Data Roaming</summary>
		public BinarySensorEntity NicoPhoneMobileDataRoaming => new(_haContext, "binary_sensor.nico_phone_mobile_data_roaming");
		///<summary>Nico Phone Music Active</summary>
		public BinarySensorEntity NicoPhoneMusicActive => new(_haContext, "binary_sensor.nico_phone_music_active");
		///<summary>Nico Phone Power Save</summary>
		public BinarySensorEntity NicoPhonePowerSave => new(_haContext, "binary_sensor.nico_phone_power_save");
		///<summary>Nico Phone Speakerphone</summary>
		public BinarySensorEntity NicoPhoneSpeakerphone => new(_haContext, "binary_sensor.nico_phone_speakerphone");
		///<summary>Nico Phone WiFi State</summary>
		public BinarySensorEntity NicoPhoneWifiState => new(_haContext, "binary_sensor.nico_phone_wifi_state");
		///<summary>Nico Phone Work Profile</summary>
		public BinarySensorEntity NicoPhoneWorkProfile => new(_haContext, "binary_sensor.nico_phone_work_profile");
		///<summary>Office AC Heat</summary>
		public BinarySensorEntity OfficeAcHeat => new(_haContext, "binary_sensor.office_ac_heat");
		///<summary>Office AC Temperature Rising</summary>
		public BinarySensorEntity OfficeAcTemperatureRising => new(_haContext, "binary_sensor.office_ac_temperature_rising");
		///<summary>Office Chair Vibration Sensor vibration</summary>
		public BinarySensorEntity OfficeChairVibrationSensorVibration => new(_haContext, "binary_sensor.office_chair_vibration_sensor_vibration");
		///<summary>Office Dimmer update available</summary>
		public BinarySensorEntity OfficeDimmerUpdateAvailable => new(_haContext, "binary_sensor.office_dimmer_update_available");
		///<summary>Office Door contact</summary>
		public BinarySensorEntity OfficeDoorContact => new(_haContext, "binary_sensor.office_door_contact");
		///<summary>Office Door Contact Heat</summary>
		public BinarySensorEntity OfficeDoorContactHeat => new(_haContext, "binary_sensor.office_door_contact_heat");
		///<summary>Office Door Contact Temperature Rising</summary>
		public BinarySensorEntity OfficeDoorContactTemperatureRising => new(_haContext, "binary_sensor.office_door_contact_temperature_rising");
		///<summary>Office Door Moving</summary>
		public BinarySensorEntity OfficeDoorMoving => new(_haContext, "binary_sensor.office_door_moving");
		///<summary>Office Heat</summary>
		public BinarySensorEntity OfficeHeat => new(_haContext, "binary_sensor.office_heat");
		///<summary>Office Motion Sensor Heat</summary>
		public BinarySensorEntity OfficeMotionSensorHeat => new(_haContext, "binary_sensor.office_motion_sensor_heat");
		///<summary>Office Motion Sensor Motion</summary>
		public BinarySensorEntity OfficeMotionSensorMotion => new(_haContext, "binary_sensor.office_motion_sensor_motion");
		///<summary>Office Motion Sensor Temperature Rising</summary>
		public BinarySensorEntity OfficeMotionSensorTemperatureRising => new(_haContext, "binary_sensor.office_motion_sensor_temperature_rising");
		///<summary>Office Occupancy</summary>
		public BinarySensorEntity OfficeOccupancy => new(_haContext, "binary_sensor.office_occupancy");
		///<summary>Office PC Network Wired</summary>
		public BinarySensorEntity OfficePcNetworkWired => new(_haContext, "binary_sensor.office_pc_network_wired");
		///<summary>Lawn Pump Watering</summary>
		public BinarySensorEntity PompaWatering => new(_haContext, "binary_sensor.pompa_watering");
		///<summary>Tech Room Proxmox Docker Running</summary>
		public BinarySensorEntity ProxmoxDockerRunning => new(_haContext, "binary_sensor.proxmox_docker_running");
		///<summary>HA OS</summary>
		public BinarySensorEntity ProxmoxHaosRunning => new(_haContext, "binary_sensor.proxmox_haos_running");
		///<summary>rares_phone App Inactive</summary>
		public BinarySensorEntity RaresPhoneAppInactive => new(_haContext, "binary_sensor.rares_phone_app_inactive");
		///<summary>rares_phone Bluetooth State</summary>
		public BinarySensorEntity RaresPhoneBluetoothState => new(_haContext, "binary_sensor.rares_phone_bluetooth_state");
		///<summary>rares_phone Device Locked</summary>
		public BinarySensorEntity RaresPhoneDeviceLocked => new(_haContext, "binary_sensor.rares_phone_device_locked");
		///<summary>rares_phone Device Secure</summary>
		public BinarySensorEntity RaresPhoneDeviceSecure => new(_haContext, "binary_sensor.rares_phone_device_secure");
		///<summary>rares_phone Doze Mode</summary>
		public BinarySensorEntity RaresPhoneDozeMode => new(_haContext, "binary_sensor.rares_phone_doze_mode");
		///<summary>rares_phone Headphones</summary>
		public BinarySensorEntity RaresPhoneHeadphones => new(_haContext, "binary_sensor.rares_phone_headphones");
		///<summary>rares_phone High Accuracy Mode</summary>
		public BinarySensorEntity RaresPhoneHighAccuracyMode => new(_haContext, "binary_sensor.rares_phone_high_accuracy_mode");
		///<summary>rares_phone Interactive</summary>
		public BinarySensorEntity RaresPhoneInteractive => new(_haContext, "binary_sensor.rares_phone_interactive");
		///<summary>rares_phone Is Charging</summary>
		public BinarySensorEntity RaresPhoneIsCharging => new(_haContext, "binary_sensor.rares_phone_is_charging");
		///<summary>rares_phone Keyguard Locked</summary>
		public BinarySensorEntity RaresPhoneKeyguardLocked => new(_haContext, "binary_sensor.rares_phone_keyguard_locked");
		///<summary>rares_phone Keyguard Secure</summary>
		public BinarySensorEntity RaresPhoneKeyguardSecure => new(_haContext, "binary_sensor.rares_phone_keyguard_secure");
		///<summary>rares_phone Mic Muted</summary>
		public BinarySensorEntity RaresPhoneMicMuted => new(_haContext, "binary_sensor.rares_phone_mic_muted");
		///<summary>rares_phone Mobile Data</summary>
		public BinarySensorEntity RaresPhoneMobileData => new(_haContext, "binary_sensor.rares_phone_mobile_data");
		///<summary>rares_phone Mobile Data Roaming</summary>
		public BinarySensorEntity RaresPhoneMobileDataRoaming => new(_haContext, "binary_sensor.rares_phone_mobile_data_roaming");
		///<summary>rares_phone Music Active</summary>
		public BinarySensorEntity RaresPhoneMusicActive => new(_haContext, "binary_sensor.rares_phone_music_active");
		///<summary>rares_phone Power Save</summary>
		public BinarySensorEntity RaresPhonePowerSave => new(_haContext, "binary_sensor.rares_phone_power_save");
		///<summary>rares_phone Speakerphone</summary>
		public BinarySensorEntity RaresPhoneSpeakerphone => new(_haContext, "binary_sensor.rares_phone_speakerphone");
		///<summary>rares_phone WiFi State</summary>
		public BinarySensorEntity RaresPhoneWifiState => new(_haContext, "binary_sensor.rares_phone_wifi_state");
		///<summary>rares_phone Work Profile</summary>
		public BinarySensorEntity RaresPhoneWorkProfile => new(_haContext, "binary_sensor.rares_phone_work_profile");
		///<summary>razvan phone App Inactive</summary>
		public BinarySensorEntity RazvanPhoneAppInactive => new(_haContext, "binary_sensor.razvan_phone_app_inactive");
		///<summary>razvan phone Bluetooth State</summary>
		public BinarySensorEntity RazvanPhoneBluetoothState => new(_haContext, "binary_sensor.razvan_phone_bluetooth_state");
		///<summary>razvan phone Device Locked</summary>
		public BinarySensorEntity RazvanPhoneDeviceLocked => new(_haContext, "binary_sensor.razvan_phone_device_locked");
		///<summary>razvan phone Device Secure</summary>
		public BinarySensorEntity RazvanPhoneDeviceSecure => new(_haContext, "binary_sensor.razvan_phone_device_secure");
		///<summary>razvan phone Doze Mode</summary>
		public BinarySensorEntity RazvanPhoneDozeMode => new(_haContext, "binary_sensor.razvan_phone_doze_mode");
		///<summary>razvan phone Headphones</summary>
		public BinarySensorEntity RazvanPhoneHeadphones => new(_haContext, "binary_sensor.razvan_phone_headphones");
		///<summary>razvan phone High Accuracy Mode</summary>
		public BinarySensorEntity RazvanPhoneHighAccuracyMode => new(_haContext, "binary_sensor.razvan_phone_high_accuracy_mode");
		///<summary>razvan phone Interactive</summary>
		public BinarySensorEntity RazvanPhoneInteractive => new(_haContext, "binary_sensor.razvan_phone_interactive");
		///<summary>razvan phone Is Charging</summary>
		public BinarySensorEntity RazvanPhoneIsCharging => new(_haContext, "binary_sensor.razvan_phone_is_charging");
		///<summary>razvan phone Keyguard Locked</summary>
		public BinarySensorEntity RazvanPhoneKeyguardLocked => new(_haContext, "binary_sensor.razvan_phone_keyguard_locked");
		///<summary>razvan phone Keyguard Secure</summary>
		public BinarySensorEntity RazvanPhoneKeyguardSecure => new(_haContext, "binary_sensor.razvan_phone_keyguard_secure");
		///<summary>razvan phone Mic Muted</summary>
		public BinarySensorEntity RazvanPhoneMicMuted => new(_haContext, "binary_sensor.razvan_phone_mic_muted");
		///<summary>razvan phone Mobile Data</summary>
		public BinarySensorEntity RazvanPhoneMobileData => new(_haContext, "binary_sensor.razvan_phone_mobile_data");
		///<summary>razvan phone Mobile Data Roaming</summary>
		public BinarySensorEntity RazvanPhoneMobileDataRoaming => new(_haContext, "binary_sensor.razvan_phone_mobile_data_roaming");
		///<summary>razvan phone Music Active</summary>
		public BinarySensorEntity RazvanPhoneMusicActive => new(_haContext, "binary_sensor.razvan_phone_music_active");
		///<summary>razvan phone Power Save</summary>
		public BinarySensorEntity RazvanPhonePowerSave => new(_haContext, "binary_sensor.razvan_phone_power_save");
		///<summary>razvan phone Speakerphone</summary>
		public BinarySensorEntity RazvanPhoneSpeakerphone => new(_haContext, "binary_sensor.razvan_phone_speakerphone");
		///<summary>razvan phone WiFi State</summary>
		public BinarySensorEntity RazvanPhoneWifiState => new(_haContext, "binary_sensor.razvan_phone_wifi_state");
		///<summary>razvan phone Work Profile</summary>
		public BinarySensorEntity RazvanPhoneWorkProfile => new(_haContext, "binary_sensor.razvan_phone_work_profile");
		///<summary>Rumbu Hydrawise Status</summary>
		public BinarySensorEntity RumbuHydrawiseStatus => new(_haContext, "binary_sensor.rumbu_hydrawise_status");
		///<summary>File editor: Running</summary>
		public BinarySensorEntity ServiceFileEditorRunning => new(_haContext, "binary_sensor.service_file_editor_running");
		///<summary>File editor: Update Available</summary>
		public BinarySensorEntity ServiceFileEditorUpdateAvailable => new(_haContext, "binary_sensor.service_file_editor_update_available");
		///<summary>Home Assistant Operating System: Update Available</summary>
		public BinarySensorEntity ServiceHaOsUpdateAvailable => new(_haContext, "binary_sensor.service_ha_os_update_available");
		///<summary>MariaDB: Running</summary>
		public BinarySensorEntity ServiceMariadbRunning => new(_haContext, "binary_sensor.service_mariadb_running");
		///<summary>MariaDB: Update Available</summary>
		public BinarySensorEntity ServiceMariadbUpdateAvailable => new(_haContext, "binary_sensor.service_mariadb_update_available");
		///<summary>Mosquitto broker: Running</summary>
		public BinarySensorEntity ServiceMosquittoRunning => new(_haContext, "binary_sensor.service_mosquitto_running");
		///<summary>Mosquitto broker: Update Available</summary>
		public BinarySensorEntity ServiceMosquittoUpdateAvailable => new(_haContext, "binary_sensor.service_mosquitto_update_available");
		///<summary>NetDaemon V3 - beta: Running</summary>
		public BinarySensorEntity ServiceNetdaemonRunning => new(_haContext, "binary_sensor.service_netdaemon_running");
		///<summary>NetDaemon V3 - beta: Update Available</summary>
		public BinarySensorEntity ServiceNetdaemonUpdateAvailable => new(_haContext, "binary_sensor.service_netdaemon_update_available");
		///<summary>RPC Shutdown: Running</summary>
		public BinarySensorEntity ServiceRpcShutdownRunning => new(_haContext, "binary_sensor.service_rpc_shutdown_running");
		///<summary>RPC Shutdown: Update Available</summary>
		public BinarySensorEntity ServiceRpcShutdownUpdateAvailable => new(_haContext, "binary_sensor.service_rpc_shutdown_update_available");
		///<summary>Samba share: Running</summary>
		public BinarySensorEntity ServiceSambaRunning => new(_haContext, "binary_sensor.service_samba_running");
		///<summary>Samba share: Update Available</summary>
		public BinarySensorEntity ServiceSambaUpdateAvailable => new(_haContext, "binary_sensor.service_samba_update_available");
		///<summary>Terminal & SSH: Running</summary>
		public BinarySensorEntity ServiceTerminalSshRunning => new(_haContext, "binary_sensor.service_terminal_ssh_running");
		///<summary>Terminal & SSH: Update Available</summary>
		public BinarySensorEntity ServiceTerminalSshUpdateAvailable => new(_haContext, "binary_sensor.service_terminal_ssh_update_available");
		///<summary>Shed Dryer Child Lock</summary>
		public BinarySensorEntity ShedDryerChildLock => new(_haContext, "binary_sensor.shed_dryer_child_lock");
		///<summary>Shed Dryer Dry Completed</summary>
		public BinarySensorEntity ShedDryerDryCompleted => new(_haContext, "binary_sensor.shed_dryer_dry_completed");
		///<summary>Shed Dryer Error State</summary>
		public BinarySensorEntity ShedDryerErrorState => new(_haContext, "binary_sensor.shed_dryer_error_state");
		///<summary>Shed Dryer Remote Start</summary>
		public BinarySensorEntity ShedDryerRemoteStart => new(_haContext, "binary_sensor.shed_dryer_remote_start");
		///<summary>Shed Dryer Standby</summary>
		public BinarySensorEntity ShedDryerStandby => new(_haContext, "binary_sensor.shed_dryer_standby");
		///<summary>Shed Motion Sensor Battery Low</summary>
		public BinarySensorEntity ShedMotionSensorBatteryLow => new(_haContext, "binary_sensor.shed_motion_sensor_battery_low");
		///<summary>Shed Motion Sensor Motion</summary>
		public BinarySensorEntity ShedMotionSensorMotion => new(_haContext, "binary_sensor.shed_motion_sensor_motion");
		///<summary>Shed Motion Sensor Tamper</summary>
		public BinarySensorEntity ShedMotionSensorTamper => new(_haContext, "binary_sensor.shed_motion_sensor_tamper");
		///<summary>Shed Occupancy</summary>
		public BinarySensorEntity ShedOccupancy => new(_haContext, "binary_sensor.shed_occupancy");
		///<summary>Shed Outlet update available</summary>
		public BinarySensorEntity ShedOutletUpdateAvailable => new(_haContext, "binary_sensor.shed_outlet_update_available");
		///<summary>Shed Weather Sensor Heat</summary>
		public BinarySensorEntity ShedWeatherSensorHeat => new(_haContext, "binary_sensor.shed_weather_sensor_heat");
		///<summary>Shed Weather Sensor Temperature Rising</summary>
		public BinarySensorEntity ShedWeatherSensorTemperatureRising => new(_haContext, "binary_sensor.shed_weather_sensor_temperature_rising");
		///<summary>Shower Door Contact</summary>
		public BinarySensorEntity ShowerDoorContact => new(_haContext, "binary_sensor.shower_door_contact");
		///<summary>Shower Door Contact Heat</summary>
		public BinarySensorEntity ShowerDoorContactHeat => new(_haContext, "binary_sensor.shower_door_contact_heat");
		///<summary>Shower Door Contact Temperature Rising</summary>
		public BinarySensorEntity ShowerDoorContactTemperatureRising => new(_haContext, "binary_sensor.shower_door_contact_temperature_rising");
		///<summary>Shower Door Moving</summary>
		public BinarySensorEntity ShowerDoorMoving => new(_haContext, "binary_sensor.shower_door_moving");
		///<summary>Shower Motion battery low</summary>
		public BinarySensorEntity ShowerMotionBatteryLow => new(_haContext, "binary_sensor.shower_motion_battery_low");
		///<summary>Shower Motion Sensor Motion</summary>
		public BinarySensorEntity ShowerMotionSensorMotion => new(_haContext, "binary_sensor.shower_motion_sensor_motion");
		///<summary>Shower Motion Sensor Tamper</summary>
		public BinarySensorEntity ShowerMotionSensorTamper => new(_haContext, "binary_sensor.shower_motion_sensor_tamper");
		///<summary>Shower Occupancy</summary>
		public BinarySensorEntity ShowerOccupancy => new(_haContext, "binary_sensor.shower_occupancy");
		///<summary>Shower Water Leak Sensor Battery Low</summary>
		public BinarySensorEntity ShowerWaterLeakSensorBatteryLow => new(_haContext, "binary_sensor.shower_water_leak_sensor_battery_low");
		///<summary>Shower Water Leak Sensor Heat</summary>
		public BinarySensorEntity ShowerWaterLeakSensorHeat => new(_haContext, "binary_sensor.shower_water_leak_sensor_heat");
		///<summary>Shower Water Leak Sensor Temperature Rising</summary>
		public BinarySensorEntity ShowerWaterLeakSensorTemperatureRising => new(_haContext, "binary_sensor.shower_water_leak_sensor_temperature_rising");
		///<summary>Shower Water Leak Sensor Water Leak</summary>
		public BinarySensorEntity ShowerWaterLeakSensorWaterLeak => new(_haContext, "binary_sensor.shower_water_leak_sensor_water_leak");
		///<summary>Shower Weather Sensor Heat</summary>
		public BinarySensorEntity ShowerWeatherSensorHeat => new(_haContext, "binary_sensor.shower_weather_sensor_heat");
		///<summary>Shower Weather Sensor Temperature Rising</summary>
		public BinarySensorEntity ShowerWeatherSensorTemperatureRising => new(_haContext, "binary_sensor.shower_weather_sensor_temperature_rising");
		///<summary>Stairs Motion Sensor Down Battery Low</summary>
		public BinarySensorEntity StairsMotionSensorDownBatteryLow => new(_haContext, "binary_sensor.stairs_motion_sensor_down_battery_low");
		///<summary>Stairs Motion Sensor Down Motion</summary>
		public BinarySensorEntity StairsMotionSensorDownMotion => new(_haContext, "binary_sensor.stairs_motion_sensor_down_motion");
		///<summary>Stairs Motion Sensor Down Tamper</summary>
		public BinarySensorEntity StairsMotionSensorDownTamper => new(_haContext, "binary_sensor.stairs_motion_sensor_down_tamper");
		///<summary>Stairs Motion Sensor Up Motion</summary>
		public BinarySensorEntity StairsMotionSensorUpMotion => new(_haContext, "binary_sensor.stairs_motion_sensor_up_motion");
		///<summary>Stairs Motion Sensor Up Tamper</summary>
		public BinarySensorEntity StairsMotionSensorUpTamper => new(_haContext, "binary_sensor.stairs_motion_sensor_up_tamper");
		///<summary>Stairs Motion Up battery low</summary>
		public BinarySensorEntity StairsMotionUpBatteryLow => new(_haContext, "binary_sensor.stairs_motion_up_battery_low");
		///<summary>Stairs Occupancy</summary>
		public BinarySensorEntity StairsOccupancy => new(_haContext, "binary_sensor.stairs_occupancy");
		///<summary>Stairs Vibration vibration</summary>
		public BinarySensorEntity StairsVibrationVibration => new(_haContext, "binary_sensor.stairs_vibration_vibration");
		///<summary>Tech Room Door Contact</summary>
		public BinarySensorEntity TechRoomDoorContact => new(_haContext, "binary_sensor.tech_room_door_contact");
		///<summary>Tech Room Door Contact Heat</summary>
		public BinarySensorEntity TechRoomDoorContactHeat => new(_haContext, "binary_sensor.tech_room_door_contact_heat");
		///<summary>Tech Room Door Contact Temperature Rising</summary>
		public BinarySensorEntity TechRoomDoorContactTemperatureRising => new(_haContext, "binary_sensor.tech_room_door_contact_temperature_rising");
		///<summary>Tech Room Door Moving</summary>
		public BinarySensorEntity TechRoomDoorMoving => new(_haContext, "binary_sensor.tech_room_door_moving");
		///<summary>Tech Room Meter Cloud</summary>
		public BinarySensorEntity TechRoomMeterCloud => new(_haContext, "binary_sensor.tech_room_meter_cloud");
		///<summary>Tech Room Meter Firmware Update</summary>
		public BinarySensorEntity TechRoomMeterFirmwareUpdate => new(_haContext, "binary_sensor.tech_room_meter_firmware_update");
		///<summary>Tech Room Meter Overpowering</summary>
		public BinarySensorEntity TechRoomMeterOverpowering => new(_haContext, "binary_sensor.tech_room_meter_overpowering");
		///<summary>Tech Room Occupancy</summary>
		public BinarySensorEntity TechRoomOccupancy => new(_haContext, "binary_sensor.tech_room_occupancy");
		///<summary>Tech Room Washer Child Lock</summary>
		public BinarySensorEntity TechRoomWasherChildLock => new(_haContext, "binary_sensor.tech_room_washer_child_lock");
		///<summary>Tech Room Washer Door Lock</summary>
		public BinarySensorEntity TechRoomWasherDoorLock => new(_haContext, "binary_sensor.tech_room_washer_door_lock");
		///<summary>Tech Room Washer Error State</summary>
		public BinarySensorEntity TechRoomWasherErrorState => new(_haContext, "binary_sensor.tech_room_washer_error_state");
		///<summary>Tech Room Washer Remote Start</summary>
		public BinarySensorEntity TechRoomWasherRemoteStart => new(_haContext, "binary_sensor.tech_room_washer_remote_start");
		///<summary>Tech Room Washer Standby</summary>
		public BinarySensorEntity TechRoomWasherStandby => new(_haContext, "binary_sensor.tech_room_washer_standby");
		///<summary>Tech Room Washer Wash Completed</summary>
		public BinarySensorEntity TechRoomWasherWashCompleted => new(_haContext, "binary_sensor.tech_room_washer_wash_completed");
		///<summary>Tech Room Water Leak Sensor Battery Low</summary>
		public BinarySensorEntity TechRoomWaterLeakSensorBatteryLow => new(_haContext, "binary_sensor.tech_room_water_leak_sensor_battery_low");
		///<summary>Tech Room Water Leak Sensor Heat</summary>
		public BinarySensorEntity TechRoomWaterLeakSensorHeat => new(_haContext, "binary_sensor.tech_room_water_leak_sensor_heat");
		///<summary>Tech Room Water Leak Sensor Temperature Rising</summary>
		public BinarySensorEntity TechRoomWaterLeakSensorTemperatureRising => new(_haContext, "binary_sensor.tech_room_water_leak_sensor_temperature_rising");
		///<summary>Tech Room Water Leak Sensor Water Leak</summary>
		public BinarySensorEntity TechRoomWaterLeakSensorWaterLeak => new(_haContext, "binary_sensor.tech_room_water_leak_sensor_water_leak");
		///<summary>Tech Room Weather Sensor Heat</summary>
		public BinarySensorEntity TechRoomWeatherSensorHeat => new(_haContext, "binary_sensor.tech_room_weather_sensor_heat");
		///<summary>Tech Room Weather Sensor Temperature Rising</summary>
		public BinarySensorEntity TechRoomWeatherSensorTemperatureRising => new(_haContext, "binary_sensor.tech_room_weather_sensor_temperature_rising");
		///<summary>Terrace Camera Motion</summary>
		public BinarySensorEntity TerraceCameraMotion => new(_haContext, "binary_sensor.terrace_camera_motion");
		///<summary>Terrace Camera Tamper</summary>
		public BinarySensorEntity TerraceCameraTamper => new(_haContext, "binary_sensor.terrace_camera_tamper");
		///<summary>Terrace Camera Video Loss</summary>
		public BinarySensorEntity TerraceCameraVideoLoss => new(_haContext, "binary_sensor.terrace_camera_video_loss");
		///<summary>Terrace Occupancy</summary>
		public BinarySensorEntity TerraceOccupancy => new(_haContext, "binary_sensor.terrace_occupancy");
		///<summary>Terrace Weather Sensor Heat</summary>
		public BinarySensorEntity TerraceWeatherSensorHeat => new(_haContext, "binary_sensor.terrace_weather_sensor_heat");
		///<summary>Terrace Weather Sensor Temperature Rising</summary>
		public BinarySensorEntity TerraceWeatherSensorTemperatureRising => new(_haContext, "binary_sensor.terrace_weather_sensor_temperature_rising");
		///<summary>This is a lost cause entity</summary>
		public BinarySensorEntity ThisIsJustATest => new(_haContext, "binary_sensor.this_is_just_a_test");
		///<summary>TOD Afterdark</summary>
		public BinarySensorEntity TodAfterdark => new(_haContext, "binary_sensor.tod_afterdark");
		///<summary>TOD Afternoon</summary>
		public BinarySensorEntity TodAfternoon => new(_haContext, "binary_sensor.tod_afternoon");
		///<summary>TOD Daylight</summary>
		public BinarySensorEntity TodDaylight => new(_haContext, "binary_sensor.tod_daylight");
		///<summary>TOD Evening</summary>
		public BinarySensorEntity TodEvening => new(_haContext, "binary_sensor.tod_evening");
		///<summary>TOD Midnight</summary>
		public BinarySensorEntity TodMidnight => new(_haContext, "binary_sensor.tod_midnight");
		///<summary>TOD Morning</summary>
		public BinarySensorEntity TodMorning => new(_haContext, "binary_sensor.tod_morning");
		///<summary>TOD Nico Sleeping</summary>
		public BinarySensorEntity TodNicoSleeping => new(_haContext, "binary_sensor.tod_nico_sleeping");
		///<summary>TOD Nico Working</summary>
		public BinarySensorEntity TodNicoWorking => new(_haContext, "binary_sensor.tod_nico_working");
		///<summary>TOD Night</summary>
		public BinarySensorEntity TodNight => new(_haContext, "binary_sensor.tod_night");
		///<summary>TOD Noon</summary>
		public BinarySensorEntity TodNoon => new(_haContext, "binary_sensor.tod_noon");
		///<summary>TOD Rareș Schooling</summary>
		public BinarySensorEntity TodRaresSchooling => new(_haContext, "binary_sensor.tod_rares_schooling");
		///<summary>TOD Rareș Sleeping</summary>
		public BinarySensorEntity TodRaresSleeping => new(_haContext, "binary_sensor.tod_rares_sleeping");
		///<summary>TOD Răzvan Sleeping</summary>
		public BinarySensorEntity TodRazvanSleeping => new(_haContext, "binary_sensor.tod_razvan_sleeping");
		///<summary>TOD Răzvan Sleeping Free</summary>
		public BinarySensorEntity TodRazvanSleepingFree => new(_haContext, "binary_sensor.tod_razvan_sleeping_free");
		///<summary>TOD Răzvan Working</summary>
		public BinarySensorEntity TodRazvanWorking => new(_haContext, "binary_sensor.tod_razvan_working");
		///<summary>Roses Watering</summary>
		public BinarySensorEntity TrandafiriWatering => new(_haContext, "binary_sensor.trandafiri_watering");
		///<summary>Tuja Watering </summary>
		public BinarySensorEntity TuiaWatering => new(_haContext, "binary_sensor.tuia_watering");
		///<summary>Shed Dryer Door Lock</summary>
		public BinarySensorEntity UscatorDoorLock => new(_haContext, "binary_sensor.uscator_door_lock");
		///<summary>WINSRV Network #0 - Wired</summary>
		public BinarySensorEntity WinsrvNetwork0Wired => new(_haContext, "binary_sensor.winsrv_network_0_wired");
		///<summary>Workday Today</summary>
		public BinarySensorEntity WorkdayToday => new(_haContext, "binary_sensor.workday_today");
		///<summary>Workday Tomorrow</summary>
		public BinarySensorEntity WorkdayTomorrow => new(_haContext, "binary_sensor.workday_tomorrow");
		///<summary>Raspberries Watering</summary>
		public BinarySensorEntity ZmeuraWatering => new(_haContext, "binary_sensor.zmeura_watering");
	}

	public partial class ButtonEntities
	{
		private readonly IHaContext _haContext;
		public ButtonEntities(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>ESPresense Bedroom Restart</summary>
		public ButtonEntity EspresenseBedroomRestart => new(_haContext, "button.espresense_bedroom_restart");
		///<summary>ESPresense Child Room Restart</summary>
		public ButtonEntity EspresenseChildRoomRestart => new(_haContext, "button.espresense_child_room_restart");
		///<summary>ESPresense Kitchen Restart</summary>
		public ButtonEntity EspresenseKitchenRestart => new(_haContext, "button.espresense_kitchen_restart");
		///<summary>ESPresense Living Room 2 Restart</summary>
		public ButtonEntity EspresenseLivingRoom2Restart => new(_haContext, "button.espresense_living_room_2_restart");
		///<summary>ESPresense Living Room Restart</summary>
		public ButtonEntity EspresenseLivingRoomRestart => new(_haContext, "button.espresense_living_room_restart");
		///<summary>ESPresense Office Restart</summary>
		public ButtonEntity EspresenseOfficeRestart => new(_haContext, "button.espresense_office_restart");
		///<summary>ESPresense Shed Restart</summary>
		public ButtonEntity EspresenseShedRestart => new(_haContext, "button.espresense_shed_restart");
		///<summary>ESPresense Tech Room Restart</summary>
		public ButtonEntity EspresenseTechRoomRestart => new(_haContext, "button.espresense_tech_room_restart");
		///<summary>Tech Room Meter OTA Update</summary>
		public ButtonEntity TechRoomMeterOtaUpdate => new(_haContext, "button.tech_room_meter_ota_update");
		///<summary>Tech Room Meter OTA Update Beta</summary>
		public ButtonEntity TechRoomMeterOtaUpdateBeta => new(_haContext, "button.tech_room_meter_ota_update_beta");
		///<summary>Tech Room Meter Reboot</summary>
		public ButtonEntity TechRoomMeterReboot => new(_haContext, "button.tech_room_meter_reboot");
	}

	public partial class CalendarEntities
	{
		private readonly IHaContext _haContext;
		public CalendarEntities(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Garbage Collection</summary>
		public CalendarEntity GarbageCollection => new(_haContext, "calendar.garbage_collection");
		///<summary>Calendar</summary>
		public CalendarEntity Personal => new(_haContext, "calendar.personal");
		///<summary>Zile de naștere</summary>
		public CalendarEntity ZileDeNastere => new(_haContext, "calendar.zile_de_nastere");
	}

	public partial class CameraEntities
	{
		private readonly IHaContext _haContext;
		public CameraEntities(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Entry Doorbell Camera</summary>
		public CameraEntity Doorbell => new(_haContext, "camera.doorbell");
		///<summary>Entry Camera</summary>
		public CameraEntity Entry => new(_haContext, "camera.entry");
		///<summary>Garage Left Camera</summary>
		public CameraEntity GarageLeft => new(_haContext, "camera.garage_left");
		///<summary>Garage Right Camera</summary>
		public CameraEntity GarageRight => new(_haContext, "camera.garage_right");
		///<summary>Gazebo Camera</summary>
		public CameraEntity Gazebo => new(_haContext, "camera.gazebo");
		///<summary>Lawn Left Camera</summary>
		public CameraEntity LawnLeft => new(_haContext, "camera.lawn_left");
		///<summary>Lawn Right Camera</summary>
		public CameraEntity LawnRight => new(_haContext, "camera.lawn_right");
		///<summary>Office PC Screenshot Display 1</summary>
		public CameraEntity OfficePcScreenshotDisplay1 => new(_haContext, "camera.office_pc_screenshot_display1");
		///<summary>Office PC Screenshot Display 2</summary>
		public CameraEntity OfficePcScreenshotDisplay2 => new(_haContext, "camera.office_pc_screenshot_display2");
		///<summary>Terrace Camera</summary>
		public CameraEntity Terrace => new(_haContext, "camera.terrace");
		///<summary>WINSRV Screen #0</summary>
		public CameraEntity WinsrvScreen0 => new(_haContext, "camera.winsrv_screen_0");
	}

	public partial class ClimateEntities
	{
		private readonly IHaContext _haContext;
		public ClimateEntities(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Bedroom AC</summary>
		public ClimateEntity BedroomAc => new(_haContext, "climate.bedroom_ac");
		///<summary>Child Room AC</summary>
		public ClimateEntity ChildRoomAc => new(_haContext, "climate.child_room_ac");
		///<summary>Kitchen Fridge Freezer</summary>
		public ClimateEntity KitchenFridgeFreezer => new(_haContext, "climate.kitchen_fridge_freezer");
		///<summary>Kitchen Fridge</summary>
		public ClimateEntity KitchenFridgeFridge => new(_haContext, "climate.kitchen_fridge_fridge");
		///<summary>Living Room AC</summary>
		public ClimateEntity LivingRoomAc => new(_haContext, "climate.living_room_ac");
		///<summary>Office AC</summary>
		public ClimateEntity OfficeAc => new(_haContext, "climate.office_ac");
	}

	public partial class CounterEntities
	{
		private readonly IHaContext _haContext;
		public CounterEntities(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>BLE Stats Counter</summary>
		public CounterEntity BleStatsCounter => new(_haContext, "counter.ble_stats_counter");
	}

	public partial class CoverEntities
	{
		private readonly IHaContext _haContext;
		public CoverEntities(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Bedroom Cover Door</summary>
		public CoverEntity BedroomCoverDoor => new(_haContext, "cover.bedroom_cover_door");
		///<summary>Bedroom Cover Window</summary>
		public CoverEntity BedroomCoverWindow => new(_haContext, "cover.bedroom_cover_window");
		///<summary>Child Room Cover</summary>
		public CoverEntity ChildRoomCover => new(_haContext, "cover.child_room_cover");
		///<summary>Office Cover</summary>
		public CoverEntity OfficeCover => new(_haContext, "cover.office_cover");
	}

	public partial class DeviceTrackerEntities
	{
		private readonly IHaContext _haContext;
		public DeviceTrackerEntities(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Bedroom AC</summary>
		public DeviceTrackerEntity BedroomAc => new(_haContext, "device_tracker.bedroom_ac");
		///<summary>Bedroom TV</summary>
		public DeviceTrackerEntity BedroomTv => new(_haContext, "device_tracker.bedroom_tv");
		///<summary>Child Room AC Connected</summary>
		public DeviceTrackerEntity ChildRoomAc => new(_haContext, "device_tracker.child_room_ac");
		///<summary>Child Room Bluray</summary>
		public DeviceTrackerEntity ChildRoomBluray => new(_haContext, "device_tracker.child_room_bluray");
		///<summary>Child Room PC</summary>
		public DeviceTrackerEntity ChildRoomPc => new(_haContext, "device_tracker.child_room_pc");
		///<summary>Child Room Repeater</summary>
		public DeviceTrackerEntity ChildRoomRepeater => new(_haContext, "device_tracker.child_room_repeater");
		///<summary>Child Room TV</summary>
		public DeviceTrackerEntity ChildRoomTv => new(_haContext, "device_tracker.child_room_tv");
		///<summary>Dalian Golden Hualu Digital Technology 3B:45:73</summary>
		public DeviceTrackerEntity DalianGoldenHualuDigitalTechnology3b4573 => new(_haContext, "device_tracker.dalian_golden_hualu_digital_technology_3b_45_73");
		///<summary>Entry Doorbell</summary>
		public DeviceTrackerEntity EntryDoorbell => new(_haContext, "device_tracker.entry_doorbell");
		///<summary>Entry Hall Intercom</summary>
		public DeviceTrackerEntity EntryHallIntercom => new(_haContext, "device_tracker.entry_hall_intercom");
		///<summary>Espresense Bedroom</summary>
		public DeviceTrackerEntity EspresenseBedroom => new(_haContext, "device_tracker.espresense_bedroom");
		///<summary>Espresense Child Room</summary>
		public DeviceTrackerEntity EspresenseChildRoom => new(_haContext, "device_tracker.espresense_child_room");
		///<summary>m5kitchen</summary>
		public DeviceTrackerEntity EspresenseKitchen => new(_haContext, "device_tracker.espresense_kitchen");
		///<summary>m5living</summary>
		public DeviceTrackerEntity EspresenseLivingRoom => new(_haContext, "device_tracker.espresense_living_room");
		///<summary>Espresense Office</summary>
		public DeviceTrackerEntity EspresenseOffice => new(_haContext, "device_tracker.espresense_office");
		///<summary>m5shed</summary>
		public DeviceTrackerEntity EspresenseShed => new(_haContext, "device_tracker.espresense_shed");
		///<summary>m5techroom</summary>
		public DeviceTrackerEntity EspresenseTechRoom => new(_haContext, "device_tracker.espresense_tech_room");
		///<summary>Guest Cristina Phone</summary>
		public DeviceTrackerEntity GuestCristinaPhone => new(_haContext, "device_tracker.guest_cristina_phone");
		///<summary>Guest Laura Phone</summary>
		public DeviceTrackerEntity GuestLauraPhone => new(_haContext, "device_tracker.guest_laura_phone");
		///<summary>Luca Phone</summary>
		public DeviceTrackerEntity GuestLucaPhone => new(_haContext, "device_tracker.guest_luca_phone");
		///<summary>Guest Relu Phone</summary>
		public DeviceTrackerEntity GuestReluPhone => new(_haContext, "device_tracker.guest_relu_phone");
		///<summary>HUAWEI_P30_lite-7826d9f7d</summary>
		public DeviceTrackerEntity HuaweiP30Lite7826d9f7d2 => new(_haContext, "device_tracker.huawei_p30_lite_7826d9f7d_2");
		///<summary>Kitchen Coffee Machine</summary>
		public DeviceTrackerEntity KitchenCoffeeMachine => new(_haContext, "device_tracker.kitchen_coffee_machine");
		///<summary>Kitchen Fridge</summary>
		public DeviceTrackerEntity KitchenFridge => new(_haContext, "device_tracker.kitchen_fridge");
		///<summary>Kotchen Router</summary>
		public DeviceTrackerEntity KitchenRouter => new(_haContext, "device_tracker.kitchen_router");
		///<summary>Kitchen Washer</summary>
		public DeviceTrackerEntity KitchenWasher => new(_haContext, "device_tracker.kitchen_washer");
		///<summary>Lawn Irrigation</summary>
		public DeviceTrackerEntity LawnIrrigation => new(_haContext, "device_tracker.lawn_irrigation");
		///<summary>Living Room AC Connected</summary>
		public DeviceTrackerEntity LivingRoomAc => new(_haContext, "device_tracker.living_room_ac");
		///<summary>Living Room Google Home Mini Connected</summary>
		public DeviceTrackerEntity LivingRoomGoogleHomeMini => new(_haContext, "device_tracker.living_room_google_home_mini");
		///<summary>Living Room Receiver</summary>
		public DeviceTrackerEntity LivingRoomReceiver => new(_haContext, "device_tracker.living_room_receiver");
		///<summary>Living Room Repeater Connected</summary>
		public DeviceTrackerEntity LivingRoomRepeater => new(_haContext, "device_tracker.living_room_repeater");
		///<summary>Living Room Tablet</summary>
		public DeviceTrackerEntity LivingRoomTablet => new(_haContext, "device_tracker.living_room_tablet");
		///<summary>Living Room Tablet</summary>
		public DeviceTrackerEntity LivingRoomTabletNmap => new(_haContext, "device_tracker.living_room_tablet_nmap");
		///<summary>Living Room TV Connected</summary>
		public DeviceTrackerEntity LivingRoomTv => new(_haContext, "device_tracker.living_room_tv");
		///<summary>m5living2</summary>
		public DeviceTrackerEntity M5living2 => new(_haContext, "device_tracker.m5living2");
		///<summary>Nico Phone</summary>
		public DeviceTrackerEntity NicoPhone => new(_haContext, "device_tracker.nico_phone");
		///<summary>Nico Phone</summary>
		public DeviceTrackerEntity NicoPhoneNmap => new(_haContext, "device_tracker.nico_phone_nmap");
		///<summary>Nmap Tracker 5E:8B:DB:AE:85:37</summary>
		public DeviceTrackerEntity NmapTracker5e8bDbAe8537 => new(_haContext, "device_tracker.nmap_tracker_5e_8b_db_ae_85_37");
		///<summary>Nmap Tracker 8A:89:EB:83:70:C1</summary>
		public DeviceTrackerEntity NmapTracker8a89Eb8370C1 => new(_haContext, "device_tracker.nmap_tracker_8a_89_eb_83_70_c1");
		///<summary>Nmap Tracker A2:D6:7F:5F:9C:0A</summary>
		public DeviceTrackerEntity NmapTrackerA2D67f5f9c0a => new(_haContext, "device_tracker.nmap_tracker_a2_d6_7f_5f_9c_0a");
		///<summary>Nmap Tracker CE:8B:BA:31:39:CA</summary>
		public DeviceTrackerEntity NmapTrackerCe8bBa3139Ca => new(_haContext, "device_tracker.nmap_tracker_ce_8b_ba_31_39_ca");
		///<summary>Office AC Connected</summary>
		public DeviceTrackerEntity OfficeAc => new(_haContext, "device_tracker.office_ac");
		///<summary>Office PC</summary>
		public DeviceTrackerEntity OfficePc => new(_haContext, "device_tracker.office_pc");
		///<summary>Office Printer</summary>
		public DeviceTrackerEntity OfficePrinter => new(_haContext, "device_tracker.office_printer");
		///<summary>Office Remote Connected</summary>
		public DeviceTrackerEntity OfficeRemote => new(_haContext, "device_tracker.office_remote");
		///<summary>Office Router</summary>
		public DeviceTrackerEntity OfficeRouter => new(_haContext, "device_tracker.office_router");
		///<summary>QCA4002</summary>
		public DeviceTrackerEntity Qca4002 => new(_haContext, "device_tracker.qca4002");
		///<summary>Rares Phone</summary>
		public DeviceTrackerEntity RaresPhone => new(_haContext, "device_tracker.rares_phone");
		///<summary>Rares Phone</summary>
		public DeviceTrackerEntity RaresPhoneNmap => new(_haContext, "device_tracker.rares_phone_nmap");
		///<summary>Razvan Laptop</summary>
		public DeviceTrackerEntity RazvanLaptop => new(_haContext, "device_tracker.razvan_laptop");
		///<summary>Razvan Phone</summary>
		public DeviceTrackerEntity RazvanPhone => new(_haContext, "device_tracker.razvan_phone");
		///<summary>Razvan Phone</summary>
		public DeviceTrackerEntity RazvanPhoneNmap => new(_haContext, "device_tracker.razvan_phone_nmap");
		///<summary>Razvan Watch</summary>
		public DeviceTrackerEntity RazvanWatch => new(_haContext, "device_tracker.razvan_watch");
		///<summary>Tech Room Debian</summary>
		public DeviceTrackerEntity TechRoomDebian => new(_haContext, "device_tracker.tech_room_debian");
		///<summary>Tech Room DVR</summary>
		public DeviceTrackerEntity TechRoomDvr => new(_haContext, "device_tracker.tech_room_dvr");
		///<summary>Tech Room Meter Connected</summary>
		public DeviceTrackerEntity TechRoomMeter => new(_haContext, "device_tracker.tech_room_meter");
		///<summary>Tech Room Proxmox</summary>
		public DeviceTrackerEntity TechRoomProxmox => new(_haContext, "device_tracker.tech_room_proxmox");
		///<summary>Windows Server</summary>
		public DeviceTrackerEntity TechRoomWindowsServer => new(_haContext, "device_tracker.tech_room_windows_server");
		///<summary>Terrace Router</summary>
		public DeviceTrackerEntity TerraceRouter => new(_haContext, "device_tracker.terrace_router");
		///<summary>Unknown</summary>
		public DeviceTrackerEntity Unknown2 => new(_haContext, "device_tracker.unknown_2");
		///<summary>Living Room Vacuum Connected</summary>
		public DeviceTrackerEntity Vacuum => new(_haContext, "device_tracker.vacuum");
	}

	public partial class InputBooleanEntities
	{
		private readonly IHaContext _haContext;
		public InputBooleanEntities(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Alarm Automatic</summary>
		public InputBooleanEntity AlarmAutomatic => new(_haContext, "input_boolean.alarm_automatic");
		///<summary>Alarm Automatic Flow</summary>
		public InputBooleanEntity AlarmAutomaticFlow => new(_haContext, "input_boolean.alarm_automatic_flow");
		///<summary>Alarm Light Effects</summary>
		public InputBooleanEntity AlarmLightEffects => new(_haContext, "input_boolean.alarm_light_effects");
		///<summary>Alarm Notification Effects</summary>
		public InputBooleanEntity AlarmNotificationsEffects => new(_haContext, "input_boolean.alarm_notifications_effects");
		///<summary>Alarm Panic</summary>
		public InputBooleanEntity AlarmPanic => new(_haContext, "input_boolean.alarm_panic");
		///<summary>Alarm Panic Nico</summary>
		public InputBooleanEntity AlarmPanicNico => new(_haContext, "input_boolean.alarm_panic_nico");
		///<summary>Alarm Panic Rareş</summary>
		public InputBooleanEntity AlarmPanicRares => new(_haContext, "input_boolean.alarm_panic_rares");
		///<summary>Alarm Panic Răzvan</summary>
		public InputBooleanEntity AlarmPanicRazvan => new(_haContext, "input_boolean.alarm_panic_razvan");
		///<summary>Alarm Silent Activation</summary>
		public InputBooleanEntity AlarmSilentActivation => new(_haContext, "input_boolean.alarm_silent_activation");
		///<summary>Alarm Siren Effects</summary>
		public InputBooleanEntity AlarmSirenEffects => new(_haContext, "input_boolean.alarm_siren_effects");
		///<summary>Alarm Sound Effects</summary>
		public InputBooleanEntity AlarmSoundEffects => new(_haContext, "input_boolean.alarm_sound_effects");
		///<summary>Alarm Speech Effects</summary>
		public InputBooleanEntity AlarmSpeechEffects => new(_haContext, "input_boolean.alarm_speech_effects");
		///<summary>Bedroom AC Automation</summary>
		public InputBooleanEntity BedroomAcAutomation => new(_haContext, "input_boolean.bedroom_ac_automation");
		///<summary>Bedroom RGB Automation</summary>
		public InputBooleanEntity BedroomRgbAutomation => new(_haContext, "input_boolean.bedroom_rgb_automation");
		///<summary>BLE Stats Toggle</summary>
		public InputBooleanEntity BleStatsToggle => new(_haContext, "input_boolean.ble_stats_toggle");
		///<summary>Child Room AC Automation</summary>
		public InputBooleanEntity ChildRoomAcAutomation => new(_haContext, "input_boolean.child_room_ac_automation");
		///<summary>Child Room RGB Automation</summary>
		public InputBooleanEntity ChildRoomRgbAutomation => new(_haContext, "input_boolean.child_room_rgb_automation");
		///<summary>Guest Mode</summary>
		public InputBooleanEntity GuestMode => new(_haContext, "input_boolean.guest_mode");
		///<summary>Kitchen Light Automation</summary>
		public InputBooleanEntity KitchenLightAutomation => new(_haContext, "input_boolean.kitchen_light_automation");
		///<summary>Living Room AC Automation</summary>
		public InputBooleanEntity LivingRoomAcAutomation => new(_haContext, "input_boolean.living_room_ac_automation");
		///<summary>Living Room RGB Automation</summary>
		public InputBooleanEntity LivingRoomRgbAutomation => new(_haContext, "input_boolean.living_room_rgb_automation");
		///<summary>netdaemon_net_daemon_apps_automations_climate_app_climate_app</summary>
		public InputBooleanEntity NetdaemonNetDaemonAppsAutomationsClimateAppClimateApp => new(_haContext, "input_boolean.netdaemon_net_daemon_apps_automations_climate_app_climate_app");
		///<summary>netdaemon_net_daemon_apps_automations_cover_app_cover_app</summary>
		public InputBooleanEntity NetdaemonNetDaemonAppsAutomationsCoverAppCoverApp => new(_haContext, "input_boolean.netdaemon_net_daemon_apps_automations_cover_app_cover_app");
		///<summary>netdaemon_net_daemon_apps_automations_light_app_light_app</summary>
		public InputBooleanEntity NetdaemonNetDaemonAppsAutomationsLightAppLightApp => new(_haContext, "input_boolean.netdaemon_net_daemon_apps_automations_light_app_light_app");
		///<summary>netdaemon_net_daemon_apps_automations_presence_app_presence_app</summary>
		public InputBooleanEntity NetdaemonNetDaemonAppsAutomationsPresenceAppPresenceApp => new(_haContext, "input_boolean.netdaemon_net_daemon_apps_automations_presence_app_presence_app");
		///<summary>netdaemon_net_daemon_apps_automations_state_app_state_app</summary>
		public InputBooleanEntity NetdaemonNetDaemonAppsAutomationsStateAppStateApp => new(_haContext, "input_boolean.netdaemon_net_daemon_apps_automations_state_app_state_app");
		///<summary>Office AC Automation</summary>
		public InputBooleanEntity OfficeAcAutomation => new(_haContext, "input_boolean.office_ac_automation");
		///<summary>Office Light Automation</summary>
		public InputBooleanEntity OfficeLightAutomation => new(_haContext, "input_boolean.office_light_automation");
		///<summary>Test Toggle 1</summary>
		public InputBooleanEntity Test1 => new(_haContext, "input_boolean.test_1");
		///<summary>Test Toggle 2</summary>
		public InputBooleanEntity Test2 => new(_haContext, "input_boolean.test_2");
	}

	public partial class InputButtonEntities
	{
		private readonly IHaContext _haContext;
		public InputButtonEntities(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Bedroom Cover Door Close</summary>
		public InputButtonEntity BedroomCoverDoorClose => new(_haContext, "input_button.bedroom_cover_door_close");
		///<summary>Bedroom Cover Door Open</summary>
		public InputButtonEntity BedroomCoverDoorOpen => new(_haContext, "input_button.bedroom_cover_door_open");
		///<summary>Bedroom Cover Door Reset</summary>
		public InputButtonEntity BedroomCoverDoorReset => new(_haContext, "input_button.bedroom_cover_door_reset");
		///<summary>Bedroom Cover Door Stop</summary>
		public InputButtonEntity BedroomCoverDoorStop => new(_haContext, "input_button.bedroom_cover_door_stop");
		///<summary>Bedroom Cover Window Close</summary>
		public InputButtonEntity BedroomCoverWindowClose => new(_haContext, "input_button.bedroom_cover_window_close");
		///<summary>Bedroom Cover Window Open</summary>
		public InputButtonEntity BedroomCoverWindowOpen => new(_haContext, "input_button.bedroom_cover_window_open");
		///<summary>Bedroom Cover Window Reset</summary>
		public InputButtonEntity BedroomCoverWindowReset => new(_haContext, "input_button.bedroom_cover_window_reset");
		///<summary>Bedroom Cover Window Stop</summary>
		public InputButtonEntity BedroomCoverWindowStop => new(_haContext, "input_button.bedroom_cover_window_stop");
		///<summary>Child Room Cover Close</summary>
		public InputButtonEntity ChildRoomCoverClose => new(_haContext, "input_button.child_room_cover_close");
		///<summary>Child Room Cover Open</summary>
		public InputButtonEntity ChildRoomCoverOpen => new(_haContext, "input_button.child_room_cover_open");
		///<summary>Child Room Cover Reset</summary>
		public InputButtonEntity ChildRoomCoverReset => new(_haContext, "input_button.child_room_cover_reset");
		///<summary>Child Room Cover Stop</summary>
		public InputButtonEntity ChildRoomCoverStop => new(_haContext, "input_button.child_room_cover_stop");
		///<summary>Office Cover Close</summary>
		public InputButtonEntity OfficeCoverClose => new(_haContext, "input_button.office_cover_close");
		///<summary>Office Cover Open</summary>
		public InputButtonEntity OfficeCoverOpen => new(_haContext, "input_button.office_cover_open");
		///<summary>Office Cover Reset</summary>
		public InputButtonEntity OfficeCoverReset => new(_haContext, "input_button.office_cover_reset");
		///<summary>Office Cover Stop</summary>
		public InputButtonEntity OfficeCoverStop => new(_haContext, "input_button.office_cover_stop");
	}

	public partial class InputDatetimeEntities
	{
		private readonly IHaContext _haContext;
		public InputDatetimeEntities(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Test DateTime</summary>
		public InputDatetimeEntity TestDatetime => new(_haContext, "input_datetime.test_datetime");
	}

	public partial class InputNumberEntities
	{
		private readonly IHaContext _haContext;
		public InputNumberEntities(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Bedroom AC Automation Temperature</summary>
		public InputNumberEntity BedroomAcAutomationTemperature => new(_haContext, "input_number.bedroom_ac_automation_temperature");
		///<summary>Bedroom Cover Door Close Duration</summary>
		public InputNumberEntity BedroomCoverDoorCloseDuration => new(_haContext, "input_number.bedroom_cover_door_close_duration");
		///<summary>Bedroom Cover Door Open Duration</summary>
		public InputNumberEntity BedroomCoverDoorOpenDuration => new(_haContext, "input_number.bedroom_cover_door_open_duration");
		///<summary>Bedroom Cover Door Percent</summary>
		public InputNumberEntity BedroomCoverDoorPercent => new(_haContext, "input_number.bedroom_cover_door_percent");
		///<summary>Bedroom Cover Door Slider</summary>
		public InputNumberEntity BedroomCoverDoorSlider => new(_haContext, "input_number.bedroom_cover_door_slider");
		///<summary>Bedroom Cover Window Close Duration</summary>
		public InputNumberEntity BedroomCoverWindowCloseDuration => new(_haContext, "input_number.bedroom_cover_window_close_duration");
		///<summary>Bedroom Cover Window Open Duration</summary>
		public InputNumberEntity BedroomCoverWindowOpenDuration => new(_haContext, "input_number.bedroom_cover_window_open_duration");
		///<summary>Bedroom Cover Window Percent</summary>
		public InputNumberEntity BedroomCoverWindowPercent => new(_haContext, "input_number.bedroom_cover_window_percent");
		///<summary>Bedroom Cover Window Slider</summary>
		public InputNumberEntity BedroomCoverWindowSlider => new(_haContext, "input_number.bedroom_cover_window_slider");
		///<summary>Bedroom RGB Automation Ambient Brightness</summary>
		public InputNumberEntity BedroomRgbAutomationAmbientBrightness => new(_haContext, "input_number.bedroom_rgb_automation_ambient_brightness");
		///<summary>Bedroom RGB Automation Full Brightness</summary>
		public InputNumberEntity BedroomRgbAutomationFullBrightness => new(_haContext, "input_number.bedroom_rgb_automation_full_brightness");
		///<summary>Bedroom RGB Automation Lux Threshold</summary>
		public InputNumberEntity BedroomRgbAutomationLuxThreshold => new(_haContext, "input_number.bedroom_rgb_automation_lux_threshold");
		///<summary>Child Room AC Automation Temperature</summary>
		public InputNumberEntity ChildRoomAcAutomationTemperature => new(_haContext, "input_number.child_room_ac_automation_temperature");
		///<summary>Child Room Cover Close Duration</summary>
		public InputNumberEntity ChildRoomCoverCloseDuration => new(_haContext, "input_number.child_room_cover_close_duration");
		///<summary>Child Room Cover Open Duration</summary>
		public InputNumberEntity ChildRoomCoverOpenDuration => new(_haContext, "input_number.child_room_cover_open_duration");
		///<summary>Child Room Cover Percent</summary>
		public InputNumberEntity ChildRoomCoverPercent => new(_haContext, "input_number.child_room_cover_percent");
		///<summary>Child Room Cover Slider</summary>
		public InputNumberEntity ChildRoomCoverSlider => new(_haContext, "input_number.child_room_cover_slider");
		///<summary>Child Room RGB Automation Ambient Brightness</summary>
		public InputNumberEntity ChildRoomRgbAutomationAmbientBrightness => new(_haContext, "input_number.child_room_rgb_automation_ambient_brightness");
		///<summary>Child Room RGB Automation Full Brightness</summary>
		public InputNumberEntity ChildRoomRgbAutomationFullBrightness => new(_haContext, "input_number.child_room_rgb_automation_full_brightness");
		///<summary>Child Room RGB Automation Lux Threshold</summary>
		public InputNumberEntity ChildRoomRgbAutomationLuxThreshold => new(_haContext, "input_number.child_room_rgb_automation_lux_threshold");
		///<summary>Kitchen Light Automation Lux Threshold</summary>
		public InputNumberEntity KitchenLightAutomationLuxThreshold => new(_haContext, "input_number.kitchen_light_automation_lux_threshold");
		///<summary>Living Room AC Automation Temperature</summary>
		public InputNumberEntity LivingRoomAcAutomationTemperature => new(_haContext, "input_number.living_room_ac_automation_temperature");
		///<summary>Living Room RGB Automation Ambient Brightness</summary>
		public InputNumberEntity LivingRoomRgbAutomationAmbientBrightness => new(_haContext, "input_number.living_room_rgb_automation_ambient_brightness");
		///<summary>Living Room RGB Automation Full Brightness</summary>
		public InputNumberEntity LivingRoomRgbAutomationFullBrightness => new(_haContext, "input_number.living_room_rgb_automation_full_brightness");
		///<summary>Living Room RGB Automation Lux Threshold</summary>
		public InputNumberEntity LivingRoomRgbAutomationLuxThreshold => new(_haContext, "input_number.living_room_rgb_automation_lux_threshold");
		///<summary>Office AC Automation Temperature</summary>
		public InputNumberEntity OfficeAcAutomationTemperature => new(_haContext, "input_number.office_ac_automation_temperature");
		///<summary>Office Cover Close Duration</summary>
		public InputNumberEntity OfficeCoverCloseDuration => new(_haContext, "input_number.office_cover_close_duration");
		///<summary>Office Cover Open Duration</summary>
		public InputNumberEntity OfficeCoverOpenDuration => new(_haContext, "input_number.office_cover_open_duration");
		///<summary>Office Cover Percent</summary>
		public InputNumberEntity OfficeCoverPercent => new(_haContext, "input_number.office_cover_percent");
		///<summary>Office Cover Slider</summary>
		public InputNumberEntity OfficeCoverSlider => new(_haContext, "input_number.office_cover_slider");
		///<summary>Office Light Automation Lux Threshold</summary>
		public InputNumberEntity OfficeLightAutomationLuxThreshold => new(_haContext, "input_number.office_light_automation_lux_threshold");
		///<summary>State Arrived Threshold</summary>
		public InputNumberEntity StateArrivedThreshold => new(_haContext, "input_number.state_arrived_threshold");
		///<summary>State Awake Threshold</summary>
		public InputNumberEntity StateAwakeThreshold => new(_haContext, "input_number.state_awake_threshold");
		///<summary>State Coming Threshold</summary>
		public InputNumberEntity StateComingThreshold => new(_haContext, "input_number.state_coming_threshold");
		///<summary>State Left Threshold</summary>
		public InputNumberEntity StateLeftThreshold => new(_haContext, "input_number.state_left_threshold");
		///<summary>State Sleep Threshold</summary>
		public InputNumberEntity StateSleepThreshold => new(_haContext, "input_number.state_sleep_threshold");
		///<summary>State Vacation Threshold</summary>
		public InputNumberEntity StateVacationThreshold => new(_haContext, "input_number.state_vacation_threshold");
		///<summary>Test Number 1</summary>
		public InputNumberEntity Test1 => new(_haContext, "input_number.test_1");
		///<summary>Test Number 2</summary>
		public InputNumberEntity Test2 => new(_haContext, "input_number.test_2");
	}

	public partial class InputSelectEntities
	{
		private readonly IHaContext _haContext;
		public InputSelectEntities(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Bedroom Cover Door State</summary>
		public InputSelectEntity BedroomCoverDoorState => new(_haContext, "input_select.bedroom_cover_door_state");
		///<summary>Bedroom Cover Window State</summary>
		public InputSelectEntity BedroomCoverWindowState => new(_haContext, "input_select.bedroom_cover_window_state");
		///<summary>Bedroom RGB Automation Mode</summary>
		public InputSelectEntity BedroomRgbAutomationMode => new(_haContext, "input_select.bedroom_rgb_automation_mode");
		///<summary>BLE Stats Beacon</summary>
		public InputSelectEntity BleStatsBeacon => new(_haContext, "input_select.ble_stats_beacon");
		///<summary>Child Room Cover State</summary>
		public InputSelectEntity ChildRoomCoverState => new(_haContext, "input_select.child_room_cover_state");
		///<summary>Child Room RGB Automation Mode</summary>
		public InputSelectEntity ChildRoomRgbAutomationMode => new(_haContext, "input_select.child_room_rgb_automation_mode");
		///<summary>House State</summary>
		public InputSelectEntity HouseState => new(_haContext, "input_select.house_state");
		///<summary>Living Room RGB Automation Mode</summary>
		public InputSelectEntity LivingRoomRgbAutomationMode => new(_haContext, "input_select.living_room_rgb_automation_mode");
		///<summary>Nico State</summary>
		public InputSelectEntity NicoState => new(_haContext, "input_select.nico_state");
		///<summary>Office Cover State</summary>
		public InputSelectEntity OfficeCoverState => new(_haContext, "input_select.office_cover_state");
		///<summary>Rares State</summary>
		public InputSelectEntity RaresState => new(_haContext, "input_select.rares_state");
		///<summary>Razvan State</summary>
		public InputSelectEntity RazvanState => new(_haContext, "input_select.razvan_state");
		///<summary>Tag1 Name</summary>
		public InputSelectEntity Tag1Name => new(_haContext, "input_select.tag1_name");
		///<summary>Tag2 Name</summary>
		public InputSelectEntity Tag2Name => new(_haContext, "input_select.tag2_name");
		///<summary>Tag3 Name</summary>
		public InputSelectEntity Tag3Name => new(_haContext, "input_select.tag3_name");
		///<summary>Tag4 Name</summary>
		public InputSelectEntity Tag4Name => new(_haContext, "input_select.tag4_name");
	}

	public partial class InputTextEntities
	{
		private readonly IHaContext _haContext;
		public InputTextEntities(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Alarm Fire Armed Text</summary>
		public InputTextEntity AlarmFireArmedText => new(_haContext, "input_text.alarm_fire_armed_text");
		///<summary>Alarm Fire Disarmed Text</summary>
		public InputTextEntity AlarmFireDisarmedText => new(_haContext, "input_text.alarm_fire_disarmed_text");
		///<summary>Alarm Fire Triggered Text</summary>
		public InputTextEntity AlarmFireTriggeredText => new(_haContext, "input_text.alarm_fire_triggered_text");
		///<summary>Alarm Intrusion Armed Away Text</summary>
		public InputTextEntity AlarmIntrusionArmedAwayText => new(_haContext, "input_text.alarm_intrusion_armed_away_text");
		///<summary>Alarm Intrusion Armed Home Text</summary>
		public InputTextEntity AlarmIntrusionArmedHomeText => new(_haContext, "input_text.alarm_intrusion_armed_home_text");
		///<summary>Alarm Intrusion Armed Night Text</summary>
		public InputTextEntity AlarmIntrusionArmedNightText => new(_haContext, "input_text.alarm_intrusion_armed_night_text");
		///<summary>Alarm Intrusion Arming Text</summary>
		public InputTextEntity AlarmIntrusionArmingText => new(_haContext, "input_text.alarm_intrusion_arming_text");
		///<summary>Alarm Intrusion Disarmed Text</summary>
		public InputTextEntity AlarmIntrusionDisarmedText => new(_haContext, "input_text.alarm_intrusion_disarmed_text");
		///<summary>Alarm Intrusion Pending Text</summary>
		public InputTextEntity AlarmIntrusionPendingText => new(_haContext, "input_text.alarm_intrusion_pending_text");
		///<summary>Alarm Intrusion Triggered Text</summary>
		public InputTextEntity AlarmIntrusionTriggeredText => new(_haContext, "input_text.alarm_intrusion_triggered_text");
		///<summary>Alarm Panic Nico Text</summary>
		public InputTextEntity AlarmPanicNicoText => new(_haContext, "input_text.alarm_panic_nico_text");
		///<summary>Alarm Panic Rareş Text</summary>
		public InputTextEntity AlarmPanicRaresText => new(_haContext, "input_text.alarm_panic_rares_text");
		///<summary>Alarm Panic Răzvan Text</summary>
		public InputTextEntity AlarmPanicRazvanText => new(_haContext, "input_text.alarm_panic_razvan_text");
		///<summary>Alarm Panic Text</summary>
		public InputTextEntity AlarmPanicText => new(_haContext, "input_text.alarm_panic_text");
		///<summary>Alarm Water Leak Armed Text</summary>
		public InputTextEntity AlarmWaterLeakArmedText => new(_haContext, "input_text.alarm_water_leak_armed_text");
		///<summary>Alarm Water Leak Disarmed Text</summary>
		public InputTextEntity AlarmWaterLeakDisarmedText => new(_haContext, "input_text.alarm_water_leak_disarmed_text");
		///<summary>Alarm Water Leak Triggered Text</summary>
		public InputTextEntity AlarmWaterLeakTriggeredText => new(_haContext, "input_text.alarm_water_leak_triggered_text");
		///<summary>Bedroom Cover Door Close Command</summary>
		public InputTextEntity BedroomCoverDoorCloseCommand => new(_haContext, "input_text.bedroom_cover_door_close_command");
		///<summary>Bedroom Cover Door Open Command</summary>
		public InputTextEntity BedroomCoverDoorOpenCommand => new(_haContext, "input_text.bedroom_cover_door_open_command");
		///<summary>Bedroom Cover Window Close Command</summary>
		public InputTextEntity BedroomCoverWindowCloseCommand => new(_haContext, "input_text.bedroom_cover_window_close_command");
		///<summary>Bedroom Cover Window Open Command</summary>
		public InputTextEntity BedroomCoverWindowOpenCommand => new(_haContext, "input_text.bedroom_cover_window_open_command");
		///<summary>BLE Stats Name</summary>
		public InputTextEntity BleStatsName => new(_haContext, "input_text.ble_stats_name");
		///<summary>Child Room Cover Close Command</summary>
		public InputTextEntity ChildRoomCoverCloseCommand => new(_haContext, "input_text.child_room_cover_close_command");
		///<summary>Child Room Cover Open Command</summary>
		public InputTextEntity ChildRoomCoverOpenCommand => new(_haContext, "input_text.child_room_cover_open_command");
		///<summary>Office Cover Close Command</summary>
		public InputTextEntity OfficeCoverCloseCommand => new(_haContext, "input_text.office_cover_close_command");
		///<summary>Office Cover Open Command</summary>
		public InputTextEntity OfficeCoverOpenCommand => new(_haContext, "input_text.office_cover_open_command");
		///<summary>Tag1 Address</summary>
		public InputTextEntity Tag1Address => new(_haContext, "input_text.tag1_address");
		///<summary>Tag2 Address</summary>
		public InputTextEntity Tag2Address => new(_haContext, "input_text.tag2_address");
		///<summary>Tag3 Address</summary>
		public InputTextEntity Tag3Address => new(_haContext, "input_text.tag3_address");
		///<summary>Tag4 Address</summary>
		public InputTextEntity Tag4Address => new(_haContext, "input_text.tag4_address");
		///<summary>Test Text</summary>
		public InputTextEntity TestText => new(_haContext, "input_text.test_text");
	}

	public partial class LightEntities
	{
		private readonly IHaContext _haContext;
		public LightEntities(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Bedroom RGB</summary>
		public LightEntity BedroomRgb => new(_haContext, "light.bedroom_rgb");
		///<summary>Child Room RGB</summary>
		public LightEntity ChildRoomRgb => new(_haContext, "light.child_room_rgb");
		///<summary>Kitchen Light</summary>
		public LightEntity KitchenSwitch => new(_haContext, "light.kitchen_switch");
		///<summary>Living Room RGB</summary>
		public LightEntity LivingRoomRgb => new(_haContext, "light.living_room_rgb");
		///<summary>Office Light</summary>
		public LightEntity OfficeSwitch => new(_haContext, "light.office_switch");
	}

	public partial class MediaPlayerEntities
	{
		private readonly IHaContext _haContext;
		public MediaPlayerEntities(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Bedroom TV</summary>
		public MediaPlayerEntity BedroomTv => new(_haContext, "media_player.bedroom_tv");
		///<summary>Child Room TV</summary>
		public MediaPlayerEntity ChildRoomTv => new(_haContext, "media_player.child_room_tv");
		///<summary>Emby Adi Vaida Phone</summary>
		public MediaPlayerEntity EmbyAdiVaidaPhone => new(_haContext, "media_player.emby_adi_vaida_phone");
		///<summary>TV Adi Vaida</summary>
		public MediaPlayerEntity EmbyAdiVaidaTv => new(_haContext, "media_player.emby_adi_vaida_tv");
		///<summary>Emby Chrome Windows</summary>
		public MediaPlayerEntity EmbyChromeWindows => new(_haContext, "media_player.emby_chrome_windows");
		///<summary>Emby Chrome Windows</summary>
		public MediaPlayerEntity EmbyChromeWindows2 => new(_haContext, "media_player.emby_chrome_windows_2");
		///<summary>Emby Chromecast</summary>
		public MediaPlayerEntity EmbyChromecast3 => new(_haContext, "media_player.emby_chromecast_3");
		///<summary>Emby Cristina Phone</summary>
		public MediaPlayerEntity EmbyCristinaPhone => new(_haContext, "media_player.emby_cristina_phone");
		///<summary>Emby DESKTOP-CUJ9HF0</summary>
		public MediaPlayerEntity EmbyDesktopCuj9hf0 => new(_haContext, "media_player.emby_desktop_cuj9hf0");
		///<summary>Emby doar teo are voie</summary>
		public MediaPlayerEntity EmbyDoarTeoAreVoie => new(_haContext, "media_player.emby_doar_teo_are_voie");
		///<summary>Emby Emby Server DLNA</summary>
		public MediaPlayerEntity EmbyEmbyServerDlna => new(_haContext, "media_player.emby_emby_server_dlna");
		///<summary>Emby Firefox Windows</summary>
		public MediaPlayerEntity EmbyFirefoxWindows => new(_haContext, "media_player.emby_firefox_windows");
		///<summary>Emby HomeAssistant</summary>
		public MediaPlayerEntity EmbyHomeassistant => new(_haContext, "media_player.emby_homeassistant");
		///<summary>Emby LG Smart TV (50NANO753PR)</summary>
		public MediaPlayerEntity EmbyLgSmartTv50nano753pr => new(_haContext, "media_player.emby_lg_smart_tv_50nano753pr");
		///<summary>Emby Network Device</summary>
		public MediaPlayerEntity EmbyLgWebosTvSk8500pl => new(_haContext, "media_player.emby_lg_webos_tv_sk8500pl");
		///<summary>Emby Living Room TV</summary>
		public MediaPlayerEntity EmbyLivingRoomTv => new(_haContext, "media_player.emby_living_room_tv");
		///<summary>Emby [TV][LG]55LA740S-ZB</summary>
		public MediaPlayerEntity EmbyNetworkDevice => new(_haContext, "media_player.emby_network_device");
		///<summary>Emby Network Device</summary>
		public MediaPlayerEntity EmbyNetworkDevice2 => new(_haContext, "media_player.emby_network_device_2");
		///<summary>Emby [LG] webOS TV UJ620V</summary>
		public MediaPlayerEntity EmbyNetworkDevice3 => new(_haContext, "media_player.emby_network_device_3");
		///<summary>Emby BD-S681</summary>
		public MediaPlayerEntity EmbyNetworkDevice4 => new(_haContext, "media_player.emby_network_device_4");
		///<summary>Emby BD-S681</summary>
		public MediaPlayerEntity EmbyNetworkDevice5 => new(_haContext, "media_player.emby_network_device_5");
		///<summary>Emby Razvan Phone</summary>
		public MediaPlayerEntity EmbyRazvanPhone => new(_haContext, "media_player.emby_razvan_phone");
		///<summary>Emby Relu TV</summary>
		public MediaPlayerEntity EmbyReluTv => new(_haContext, "media_player.emby_relu_tv");
		///<summary>Emby Network Device</summary>
		public MediaPlayerEntity EmbyRxV4853f5c22 => new(_haContext, "media_player.emby_rx_v485_3f5c22");
		///<summary>Living Room Google Mini</summary>
		public MediaPlayerEntity LivingRoom => new(_haContext, "media_player.living_room");
		///<summary>Living Room TV</summary>
		public MediaPlayerEntity LivingRoomTv => new(_haContext, "media_player.living_room_tv");
		///<summary>Living Room Receiver</summary>
		public MediaPlayerEntity LivingroomReceiver => new(_haContext, "media_player.livingroom_receiver");
	}

	public partial class NumberEntities
	{
		private readonly IHaContext _haContext;
		public NumberEntities(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>ESPresense Bedroom Absorption</summary>
		public NumberEntity EspresenseBedroomAbsorption => new(_haContext, "number.espresense_bedroom_absorption");
		///<summary>ESPresense Bedroom Max Distance</summary>
		public NumberEntity EspresenseBedroomMaxDistance => new(_haContext, "number.espresense_bedroom_max_distance");
		///<summary>ESPresense Child Room Absorption</summary>
		public NumberEntity EspresenseChildRoomAbsorption => new(_haContext, "number.espresense_child_room_absorption");
		///<summary>ESPresense Child Room Max Distance</summary>
		public NumberEntity EspresenseChildRoomMaxDistance => new(_haContext, "number.espresense_child_room_max_distance");
		///<summary>ESPresense Kitchen Absorption</summary>
		public NumberEntity EspresenseKitchenAbsorption => new(_haContext, "number.espresense_kitchen_absorption");
		///<summary>ESPresense Kitchen Max Distance</summary>
		public NumberEntity EspresenseKitchenMaxDistance => new(_haContext, "number.espresense_kitchen_max_distance");
		///<summary>ESPresense Living Room 2 Absorption</summary>
		public NumberEntity EspresenseLivingRoom2Absorption => new(_haContext, "number.espresense_living_room_2_absorption");
		///<summary>ESPresense Living Room 2 Max Distance</summary>
		public NumberEntity EspresenseLivingRoom2MaxDistance => new(_haContext, "number.espresense_living_room_2_max_distance");
		///<summary>ESPresense Living Room Absorption</summary>
		public NumberEntity EspresenseLivingRoomAbsorption => new(_haContext, "number.espresense_living_room_absorption");
		///<summary>ESPresense Living Room Max Distance</summary>
		public NumberEntity EspresenseLivingRoomMaxDistance => new(_haContext, "number.espresense_living_room_max_distance");
		///<summary>ESPresense Office Absorption</summary>
		public NumberEntity EspresenseOfficeAbsorption => new(_haContext, "number.espresense_office_absorption");
		///<summary>ESPresense Office Max Distance</summary>
		public NumberEntity EspresenseOfficeMaxDistance => new(_haContext, "number.espresense_office_max_distance");
		///<summary>ESPresense Shed Absorption</summary>
		public NumberEntity EspresenseShedAbsorption => new(_haContext, "number.espresense_shed_absorption");
		///<summary>ESPresense Shed Max Distance</summary>
		public NumberEntity EspresenseShedMaxDistance => new(_haContext, "number.espresense_shed_max_distance");
		///<summary>ESPresense Tech Room Absorption</summary>
		public NumberEntity EspresenseTechRoomAbsorption => new(_haContext, "number.espresense_tech_room_absorption");
		///<summary>ESPresense Tech Room Max Distance</summary>
		public NumberEntity EspresenseTechRoomMaxDistance => new(_haContext, "number.espresense_tech_room_max_distance");
		///<summary>Kitchen Heat Detector max duration</summary>
		public NumberEntity KitchenHeatDetectorMaxDuration => new(_haContext, "number.kitchen_heat_detector_max_duration");
		///<summary>Kitchen Smoke Detector Max Duration</summary>
		public NumberEntity KitchenSmokeDetectorMaxDuration => new(_haContext, "number.kitchen_smoke_detector_max_duration");
		///<summary>Living Room Receiver Tone Control Bass</summary>
		public NumberEntity LivingRoomReceiverToneControlBass => new(_haContext, "number.living_room_receiver_tone_control_bass");
		///<summary>Living Room Receiver Tone Control Treble</summary>
		public NumberEntity LivingRoomReceiverToneControlTreble => new(_haContext, "number.living_room_receiver_tone_control_treble");
		///<summary>Living Room Vacuum Bin Fill</summary>
		public NumberEntity LivingRoomVacuumBinFill => new(_haContext, "number.living_room_vacuum_bin_fill");
		///<summary>Living Room Receiver Dialogue Level</summary>
		public NumberEntity LivingroomRecieverDialogueLevel => new(_haContext, "number.livingroom_reciever_dialogue_level");
	}

	public partial class PersonEntities
	{
		private readonly IHaContext _haContext;
		public PersonEntities(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Guest Cristina</summary>
		public PersonEntity GuestCristina => new(_haContext, "person.guest_cristina");
		///<summary>Incognito</summary>
		public PersonEntity GuestIncognito => new(_haContext, "person.guest_incognito");
		///<summary>Guest Laura</summary>
		public PersonEntity GuestLaura => new(_haContext, "person.guest_laura");
		///<summary>Guest Luca</summary>
		public PersonEntity GuestLuca => new(_haContext, "person.guest_luca");
		///<summary>Guest Relu</summary>
		public PersonEntity GuestRelu => new(_haContext, "person.guest_relu");
		///<summary>Nico</summary>
		public PersonEntity Nico => new(_haContext, "person.nico");
		///<summary>Rareş</summary>
		public PersonEntity Rares => new(_haContext, "person.rares");
		///<summary>Răzvan</summary>
		public PersonEntity Razvan => new(_haContext, "person.razvan");
	}

	public partial class ProximityEntities
	{
		private readonly IHaContext _haContext;
		public ProximityEntities(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Anyone Proximity</summary>
		public ProximityEntity HomeAnyone => new(_haContext, "proximity.home_anyone");
		///<summary>Nico Proximity</summary>
		public ProximityEntity HomeNico => new(_haContext, "proximity.home_nico");
		///<summary>Rares Proximity</summary>
		public ProximityEntity HomeRares => new(_haContext, "proximity.home_rares");
		///<summary>Razvan Proximity</summary>
		public ProximityEntity HomeRazvan => new(_haContext, "proximity.home_razvan");
	}

	public partial class RemoteEntities
	{
		private readonly IHaContext _haContext;
		public RemoteEntities(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Office Remote</summary>
		public RemoteEntity OfficeRemote => new(_haContext, "remote.office_remote");
	}

	public partial class SelectEntities
	{
		private readonly IHaContext _haContext;
		public SelectEntities(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Bedroom Bed Nico Vibration Sensor sensitivity</summary>
		public SelectEntity BedroomBedNicoVibrationSensorSensitivity => new(_haContext, "select.bedroom_bed_nico_vibration_sensor_sensitivity");
		///<summary>Bedroom Bed Razvan Vibration Sensor sensitivity</summary>
		public SelectEntity BedroomBedRazvanVibrationSensorSensitivity => new(_haContext, "select.bedroom_bed_razvan_vibration_sensor_sensitivity");
		///<summary>Bedroom Outlet power on behavior</summary>
		public SelectEntity BedroomOutletPowerOnBehavior => new(_haContext, "select.bedroom_outlet_power_on_behavior");
		///<summary>Child Room Bed Vibration Sensor sensitivity</summary>
		public SelectEntity ChildRoomBedVibrationSensorSensitivity => new(_haContext, "select.child_room_bed_vibration_sensor_sensitivity");
		///<summary>Child Room Chair Vibration Sensor sensitivity</summary>
		public SelectEntity ChildRoomChairVibrationSensorSensitivity => new(_haContext, "select.child_room_chair_vibration_sensor_sensitivity");
		///<summary>Gazebo Outlet power on behavior</summary>
		public SelectEntity GazeboOutletPowerOnBehavior => new(_haContext, "select.gazebo_outlet_power_on_behavior");
		///<summary>Kitchen Outlet Right power on behavior</summary>
		public SelectEntity KitchenOutletRightPowerOnBehavior => new(_haContext, "select.kitchen_outlet_right_power_on_behavior");
		///<summary>Living Room Receiver Sleep Timer</summary>
		public SelectEntity LivingRoomReceiverSleepTimer => new(_haContext, "select.living_room_receiver_sleep_timer");
		///<summary>Living Room Receiver Surround Decoder Device</summary>
		public SelectEntity LivingRoomReceiverSurroundDecoderDevice => new(_haContext, "select.living_room_receiver_surround_decoder_device");
		///<summary>Living Room Receiver Tone Control Mode</summary>
		public SelectEntity LivingRoomRecieverToneControlMode => new(_haContext, "select.living_room_reciever_tone_control_mode");
		///<summary>Living Room Receiver Link Audio Delay</summary>
		public SelectEntity LivingroomReceiverLinkAudioDelay => new(_haContext, "select.livingroom_receiver_link_audio_delay");
		///<summary>Living Room Receiver Link Control</summary>
		public SelectEntity LivingroomRecieverLinkControl => new(_haContext, "select.livingroom_reciever_link_control");
		///<summary>Office Chair Vibration Sensor sensitivity</summary>
		public SelectEntity OfficeChairVibrationSensorSensitivity => new(_haContext, "select.office_chair_vibration_sensor_sensitivity");
		///<summary>Office Switch operation mode</summary>
		public SelectEntity OfficeSwitchOperationMode => new(_haContext, "select.office_switch_operation_mode");
		///<summary>Shed Outlet power on behavior</summary>
		public SelectEntity ShedOutletPowerOnBehavior => new(_haContext, "select.shed_outlet_power_on_behavior");
		///<summary>Stairs Vibration Sensor Sensitivity</summary>
		public SelectEntity StairsVibrationSensorSensitivity => new(_haContext, "select.stairs_vibration_sensor_sensitivity");
	}

	public partial class SensorEntities
	{
		private readonly IHaContext _haContext;
		public SensorEntities(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Child Room Bed Vibration Sensor voltage</summary>
		public NumericSensorEntity E0x00158d000323246dVoltage => new(_haContext, "sensor.0x00158d000323246d_voltage");
		///<summary>Agriculture Watering Time</summary>
		public NumericSensorEntity AgriculturaWateringTime => new(_haContext, "sensor.agricultura_watering_time");
		///<summary>Attic Ladder Contact Battery</summary>
		public NumericSensorEntity AtticLadderContactBattery => new(_haContext, "sensor.attic_ladder_contact_battery");
		///<summary>Attic Ladder Contact Linkquality</summary>
		public NumericSensorEntity AtticLadderContactLinkquality => new(_haContext, "sensor.attic_ladder_contact_linkquality");
		///<summary>Attic Ladder Contact Temperature</summary>
		public NumericSensorEntity AtticLadderContactTemperature => new(_haContext, "sensor.attic_ladder_contact_temperature");
		///<summary>Attic Ladder Contact Voltage</summary>
		public NumericSensorEntity AtticLadderContactVoltage => new(_haContext, "sensor.attic_ladder_contact_voltage");
		///<summary>Bathroom Door Contact Battery</summary>
		public NumericSensorEntity BathroomDoorContactBattery => new(_haContext, "sensor.bathroom_door_contact_battery");
		///<summary>Bathroom Door Contact Link Quality</summary>
		public NumericSensorEntity BathroomDoorContactLinkquality => new(_haContext, "sensor.bathroom_door_contact_linkquality");
		///<summary>Bathroom Door Contact Temperature</summary>
		public NumericSensorEntity BathroomDoorContactTemperature => new(_haContext, "sensor.bathroom_door_contact_temperature");
		///<summary>Bathroom Door Contact Voltage</summary>
		public NumericSensorEntity BathroomDoorContactVoltage => new(_haContext, "sensor.bathroom_door_contact_voltage");
		///<summary>Bathroom Motion Sensor Battery</summary>
		public NumericSensorEntity BathroomMotionSensorBattery => new(_haContext, "sensor.bathroom_motion_sensor_battery");
		///<summary>Bathroom Motion Sensor Link Quality</summary>
		public NumericSensorEntity BathroomMotionSensorLinkquality => new(_haContext, "sensor.bathroom_motion_sensor_linkquality");
		///<summary>Bathroom Motion Sensor Voltage</summary>
		public NumericSensorEntity BathroomMotionSensorVoltage => new(_haContext, "sensor.bathroom_motion_sensor_voltage");
		///<summary>Bathroom Water Leak Sensor battery</summary>
		public NumericSensorEntity BathroomWaterLeakSensorBattery => new(_haContext, "sensor.bathroom_water_leak_sensor_battery");
		///<summary>Bathroom Water Leak Sensor linkquality</summary>
		public NumericSensorEntity BathroomWaterLeakSensorLinkquality => new(_haContext, "sensor.bathroom_water_leak_sensor_linkquality");
		///<summary>Bathroom Water Leak Sensor Temperature</summary>
		public NumericSensorEntity BathroomWaterLeakSensorTemperature => new(_haContext, "sensor.bathroom_water_leak_sensor_temperature");
		///<summary>Bathroom Water Leak Sensor voltage</summary>
		public NumericSensorEntity BathroomWaterLeakSensorVoltage => new(_haContext, "sensor.bathroom_water_leak_sensor_voltage");
		///<summary>Bathroom Weather Sensor battery</summary>
		public NumericSensorEntity BathroomWeatherSensorBattery => new(_haContext, "sensor.bathroom_weather_sensor_battery");
		///<summary>Bathroom Weather Sensor humidity</summary>
		public NumericSensorEntity BathroomWeatherSensorHumidity => new(_haContext, "sensor.bathroom_weather_sensor_humidity");
		///<summary>Bathroom Weather Sensor linkquality</summary>
		public NumericSensorEntity BathroomWeatherSensorLinkquality => new(_haContext, "sensor.bathroom_weather_sensor_linkquality");
		///<summary>Bathroom Weather Sensor pressure</summary>
		public NumericSensorEntity BathroomWeatherSensorPressure => new(_haContext, "sensor.bathroom_weather_sensor_pressure");
		///<summary>Bathroom Weather Sensor temperature</summary>
		public NumericSensorEntity BathroomWeatherSensorTemperature => new(_haContext, "sensor.bathroom_weather_sensor_temperature");
		///<summary>Bathroom Weather Sensor voltage</summary>
		public NumericSensorEntity BathroomWeatherSensorVoltage => new(_haContext, "sensor.bathroom_weather_sensor_voltage");
		///<summary>Bedroom Bed Nico Vibration Sensor angle x</summary>
		public NumericSensorEntity BedroomBedNicoVibrationSensorAngleX => new(_haContext, "sensor.bedroom_bed_nico_vibration_sensor_angle_x");
		///<summary>Bedroom Bed Nico Vibration Sensor angle y</summary>
		public NumericSensorEntity BedroomBedNicoVibrationSensorAngleY => new(_haContext, "sensor.bedroom_bed_nico_vibration_sensor_angle_y");
		///<summary>Bedroom Bed Nico Vibration Sensor angle z</summary>
		public NumericSensorEntity BedroomBedNicoVibrationSensorAngleZ => new(_haContext, "sensor.bedroom_bed_nico_vibration_sensor_angle_z");
		///<summary>Bedroom Bed Nico Vibration Sensor battery</summary>
		public NumericSensorEntity BedroomBedNicoVibrationSensorBattery => new(_haContext, "sensor.bedroom_bed_nico_vibration_sensor_battery");
		///<summary>Bedroom Bed Nico Vibration Sensor linkquality</summary>
		public NumericSensorEntity BedroomBedNicoVibrationSensorLinkquality => new(_haContext, "sensor.bedroom_bed_nico_vibration_sensor_linkquality");
		///<summary>Bedroom Bed Nico Vibration Sensor device temperature</summary>
		public NumericSensorEntity BedroomBedNicoVibrationSensorTemperature => new(_haContext, "sensor.bedroom_bed_nico_vibration_sensor_temperature");
		///<summary>Bedroom Bed Razvan Vibration Sensor angle x</summary>
		public NumericSensorEntity BedroomBedRazvanVibrationSensorAngleX => new(_haContext, "sensor.bedroom_bed_razvan_vibration_sensor_angle_x");
		///<summary>Bedroom Bed Razvan Vibration Sensor angle y</summary>
		public NumericSensorEntity BedroomBedRazvanVibrationSensorAngleY => new(_haContext, "sensor.bedroom_bed_razvan_vibration_sensor_angle_y");
		///<summary>Bedroom Bed Razvan Vibration Sensor angle z</summary>
		public NumericSensorEntity BedroomBedRazvanVibrationSensorAngleZ => new(_haContext, "sensor.bedroom_bed_razvan_vibration_sensor_angle_z");
		///<summary>Bedroom Bed Razvan Vibration Sensor battery</summary>
		public NumericSensorEntity BedroomBedRazvanVibrationSensorBattery => new(_haContext, "sensor.bedroom_bed_razvan_vibration_sensor_battery");
		///<summary>Bedroom Bed Razvan Vibration Sensor linkquality</summary>
		public NumericSensorEntity BedroomBedRazvanVibrationSensorLinkquality => new(_haContext, "sensor.bedroom_bed_razvan_vibration_sensor_linkquality");
		///<summary>Bedroom Bed Razvan Vibration Sensor device temperature</summary>
		public NumericSensorEntity BedroomBedRazvanVibrationSensorTemperature => new(_haContext, "sensor.bedroom_bed_razvan_vibration_sensor_temperature");
		///<summary>Bedroom Bed Razvan Vibration Sensor voltage</summary>
		public NumericSensorEntity BedroomBedRazvanVibrationSensorVoltage => new(_haContext, "sensor.bedroom_bed_razvan_vibration_sensor_voltage");
		///<summary>Bedroom Dimmer battery</summary>
		public NumericSensorEntity BedroomDimmerBattery => new(_haContext, "sensor.bedroom_dimmer_battery");
		///<summary>Bedroom Dimmer linkquality</summary>
		public NumericSensorEntity BedroomDimmerLinkquality => new(_haContext, "sensor.bedroom_dimmer_linkquality");
		///<summary>Bedroom Door Contact Battery</summary>
		public NumericSensorEntity BedroomDoorContactBattery => new(_haContext, "sensor.bedroom_door_contact_battery");
		///<summary>Bedroom Door Contact Linkquality</summary>
		public NumericSensorEntity BedroomDoorContactLinkquality => new(_haContext, "sensor.bedroom_door_contact_linkquality");
		///<summary>Bedroom Door Contact Temperature</summary>
		public NumericSensorEntity BedroomDoorContactTemperature => new(_haContext, "sensor.bedroom_door_contact_temperature");
		///<summary>Bedroom Door Contact Voltage</summary>
		public NumericSensorEntity BedroomDoorContactVoltage => new(_haContext, "sensor.bedroom_door_contact_voltage");
		///<summary>Bedroom Motion Sensor Battery</summary>
		public NumericSensorEntity BedroomMotionSensorBattery => new(_haContext, "sensor.bedroom_motion_sensor_battery");
		///<summary>Bedroom Motion Sensor Illuminance</summary>
		public NumericSensorEntity BedroomMotionSensorIlluminanceLux => new(_haContext, "sensor.bedroom_motion_sensor_illuminance_lux");
		///<summary>Bedroom Motion Sensor Linkquality</summary>
		public NumericSensorEntity BedroomMotionSensorLinkquality => new(_haContext, "sensor.bedroom_motion_sensor_linkquality");
		///<summary>Bedroom Motion Sensor Temperature</summary>
		public NumericSensorEntity BedroomMotionSensorTemperature => new(_haContext, "sensor.bedroom_motion_sensor_temperature");
		///<summary>Bedroom Motion Sensor Voltage</summary>
		public NumericSensorEntity BedroomMotionSensorVoltage => new(_haContext, "sensor.bedroom_motion_sensor_voltage");
		///<summary>Bedroom Outlet linkquality</summary>
		public NumericSensorEntity BedroomOutletLinkquality => new(_haContext, "sensor.bedroom_outlet_linkquality");
		///<summary>Bedroom RGB linkquality</summary>
		public NumericSensorEntity BedroomRgbLinkquality => new(_haContext, "sensor.bedroom_rgb_linkquality");
		///<summary>Child Room Bed Vibration Sensor angle x</summary>
		public NumericSensorEntity ChildRoomBedVibrationSensorAngleX => new(_haContext, "sensor.child_room_bed_vibration_sensor_angle_x");
		///<summary>Child Room Bed Vibration Sensor angle y</summary>
		public NumericSensorEntity ChildRoomBedVibrationSensorAngleY => new(_haContext, "sensor.child_room_bed_vibration_sensor_angle_y");
		///<summary>Child Room Bed Vibration Sensor angle z</summary>
		public NumericSensorEntity ChildRoomBedVibrationSensorAngleZ => new(_haContext, "sensor.child_room_bed_vibration_sensor_angle_z");
		///<summary>Child Room Bed Vibration Sensor battery</summary>
		public NumericSensorEntity ChildRoomBedVibrationSensorBattery => new(_haContext, "sensor.child_room_bed_vibration_sensor_battery");
		///<summary>Child Room Bed Vibration Sensor linkquality</summary>
		public NumericSensorEntity ChildRoomBedVibrationSensorLinkquality => new(_haContext, "sensor.child_room_bed_vibration_sensor_linkquality");
		///<summary>Child Room Bed Vibration Sensor Temperature</summary>
		public NumericSensorEntity ChildRoomBedVibrationSensorTemperature => new(_haContext, "sensor.child_room_bed_vibration_sensor_temperature");
		///<summary>Child Room Chair Vibration Sensor angle x</summary>
		public NumericSensorEntity ChildRoomChairVibrationSensorAngleX => new(_haContext, "sensor.child_room_chair_vibration_sensor_angle_x");
		///<summary>Child Room Chair Vibration Sensor angle y</summary>
		public NumericSensorEntity ChildRoomChairVibrationSensorAngleY => new(_haContext, "sensor.child_room_chair_vibration_sensor_angle_y");
		///<summary>Child Room Chair Vibration Sensor angle z</summary>
		public NumericSensorEntity ChildRoomChairVibrationSensorAngleZ => new(_haContext, "sensor.child_room_chair_vibration_sensor_angle_z");
		///<summary>Child Room Chair Vibration Sensor battery</summary>
		public NumericSensorEntity ChildRoomChairVibrationSensorBattery => new(_haContext, "sensor.child_room_chair_vibration_sensor_battery");
		///<summary>Child Room Chair Vibration Sensor linkquality</summary>
		public NumericSensorEntity ChildRoomChairVibrationSensorLinkquality => new(_haContext, "sensor.child_room_chair_vibration_sensor_linkquality");
		///<summary>Child Room Chair Vibration Sensor device temperature</summary>
		public NumericSensorEntity ChildRoomChairVibrationSensorTemperature => new(_haContext, "sensor.child_room_chair_vibration_sensor_temperature");
		///<summary>Child Room Chair Vibration Sensor voltage</summary>
		public NumericSensorEntity ChildRoomChairVibrationSensorVoltage => new(_haContext, "sensor.child_room_chair_vibration_sensor_voltage");
		///<summary>Child Room Door Contact Battery</summary>
		public NumericSensorEntity ChildRoomDoorContactBattery => new(_haContext, "sensor.child_room_door_contact_battery");
		///<summary>Child Room Door Contact Linkquality</summary>
		public NumericSensorEntity ChildRoomDoorContactLinkquality => new(_haContext, "sensor.child_room_door_contact_linkquality");
		///<summary>Child Room Door Contact Temperature</summary>
		public NumericSensorEntity ChildRoomDoorContactTemperature => new(_haContext, "sensor.child_room_door_contact_temperature");
		///<summary>Child Room Door Contact Voltage</summary>
		public NumericSensorEntity ChildRoomDoorContactVoltage => new(_haContext, "sensor.child_room_door_contact_voltage");
		///<summary>Child Room Motion Sensor Battery</summary>
		public NumericSensorEntity ChildRoomMotionSensorBattery => new(_haContext, "sensor.child_room_motion_sensor_battery");
		///<summary>Child Room Motion Sensor Illuminance</summary>
		public NumericSensorEntity ChildRoomMotionSensorIlluminanceLux => new(_haContext, "sensor.child_room_motion_sensor_illuminance_lux");
		///<summary>Child Room Motion Sensor Linkquality</summary>
		public NumericSensorEntity ChildRoomMotionSensorLinkquality => new(_haContext, "sensor.child_room_motion_sensor_linkquality");
		///<summary>Child Room Motion Sensor Temperature</summary>
		public NumericSensorEntity ChildRoomMotionSensorTemperature => new(_haContext, "sensor.child_room_motion_sensor_temperature");
		///<summary>Child Room Motion Sensor Voltage</summary>
		public NumericSensorEntity ChildRoomMotionSensorVoltage => new(_haContext, "sensor.child_room_motion_sensor_voltage");
		///<summary>Child Room RGB linkquality</summary>
		public NumericSensorEntity ChildRoomRgbLinkquality => new(_haContext, "sensor.child_room_rgb_linkquality");
		///<summary>Trees Watering Time</summary>
		public NumericSensorEntity CopaciWateringTime => new(_haContext, "sensor.copaci_watering_time");
		///<summary>HA Disk Free</summary>
		public NumericSensorEntity DiskFree => new(_haContext, "sensor.disk_free");
		///<summary>HA Disk Use</summary>
		public NumericSensorEntity DiskUse => new(_haContext, "sensor.disk_use");
		///<summary>HA Disk Use Percent</summary>
		public NumericSensorEntity DiskUsePercent => new(_haContext, "sensor.disk_use_percent");
		///<summary>Dressing Door Contact Battery</summary>
		public NumericSensorEntity DressingDoorContactBattery => new(_haContext, "sensor.dressing_door_contact_battery");
		///<summary>Dressing Door Contact Linkquality</summary>
		public NumericSensorEntity DressingDoorContactLinkquality => new(_haContext, "sensor.dressing_door_contact_linkquality");
		///<summary>Dressing Door Contact Temperature</summary>
		public NumericSensorEntity DressingDoorContactTemperature => new(_haContext, "sensor.dressing_door_contact_temperature");
		///<summary>Dressing Door Contact Voltage</summary>
		public NumericSensorEntity DressingDoorContactVoltage => new(_haContext, "sensor.dressing_door_contact_voltage");
		///<summary>Entry Hall Door Contact Battery</summary>
		public NumericSensorEntity EntryHallDoorContactBattery => new(_haContext, "sensor.entry_hall_door_contact_battery");
		///<summary>Entry Hall Door Contact Linkquality</summary>
		public NumericSensorEntity EntryHallDoorContactLinkquality => new(_haContext, "sensor.entry_hall_door_contact_linkquality");
		///<summary>Entry Hall Door Contact Temperature</summary>
		public NumericSensorEntity EntryHallDoorContactTemperature => new(_haContext, "sensor.entry_hall_door_contact_temperature");
		///<summary>Entry Hall Door Contact Voltage</summary>
		public NumericSensorEntity EntryHallDoorContactVoltage => new(_haContext, "sensor.entry_hall_door_contact_voltage");
		///<summary>Entry Hall Motion Sensor Battery</summary>
		public NumericSensorEntity EntryHallMotionSensorBattery => new(_haContext, "sensor.entry_hall_motion_sensor_battery");
		///<summary>Entry Hall Motion Sensor Illuminance</summary>
		public NumericSensorEntity EntryHallMotionSensorIlluminanceLux => new(_haContext, "sensor.entry_hall_motion_sensor_illuminance_lux");
		///<summary>Entry Hall Motion Sensor Linkquality</summary>
		public NumericSensorEntity EntryHallMotionSensorLinkquality => new(_haContext, "sensor.entry_hall_motion_sensor_linkquality");
		///<summary>Entry Hall Motion Sensor Temperature</summary>
		public NumericSensorEntity EntryHallMotionSensorTemperature => new(_haContext, "sensor.entry_hall_motion_sensor_temperature");
		///<summary>Entry Hall Motion Sensor Voltage</summary>
		public NumericSensorEntity EntryHallMotionSensorVoltage => new(_haContext, "sensor.entry_hall_motion_sensor_voltage");
		///<summary>ESPresense Bedroom Free Mem</summary>
		public NumericSensorEntity EspresenseBedroomFreeMem => new(_haContext, "sensor.espresense_bedroom_free_mem");
		///<summary>ESPresense Bedroom Uptime</summary>
		public NumericSensorEntity EspresenseBedroomUptime => new(_haContext, "sensor.espresense_bedroom_uptime");
		///<summary>ESPresense Child Room Free Mem</summary>
		public NumericSensorEntity EspresenseChildRoomFreeMem => new(_haContext, "sensor.espresense_child_room_free_mem");
		///<summary>ESPresense Child Room Uptime</summary>
		public NumericSensorEntity EspresenseChildRoomUptime => new(_haContext, "sensor.espresense_child_room_uptime");
		///<summary>ESPresense Kitchen Free Mem</summary>
		public NumericSensorEntity EspresenseKitchenFreeMem => new(_haContext, "sensor.espresense_kitchen_free_mem");
		///<summary>ESPresense Kitchen Uptime</summary>
		public NumericSensorEntity EspresenseKitchenUptime => new(_haContext, "sensor.espresense_kitchen_uptime");
		///<summary>ESPresense Living Room 2 Free Mem</summary>
		public NumericSensorEntity EspresenseLivingRoom2FreeMem => new(_haContext, "sensor.espresense_living_room_2_free_mem");
		///<summary>ESPresense Living Room 2 Uptime</summary>
		public NumericSensorEntity EspresenseLivingRoom2Uptime => new(_haContext, "sensor.espresense_living_room_2_uptime");
		///<summary>ESPresense Living Room Free Mem</summary>
		public NumericSensorEntity EspresenseLivingRoomFreeMem => new(_haContext, "sensor.espresense_living_room_free_mem");
		///<summary>ESPresense Living Room Uptime</summary>
		public NumericSensorEntity EspresenseLivingRoomUptime => new(_haContext, "sensor.espresense_living_room_uptime");
		///<summary>ESPresense Office Free Mem</summary>
		public NumericSensorEntity EspresenseOfficeFreeMem => new(_haContext, "sensor.espresense_office_free_mem");
		///<summary>ESPresense Office Uptime</summary>
		public NumericSensorEntity EspresenseOfficeUptime => new(_haContext, "sensor.espresense_office_uptime");
		///<summary>ESPresense Shed Free Mem</summary>
		public NumericSensorEntity EspresenseShedFreeMem => new(_haContext, "sensor.espresense_shed_free_mem");
		///<summary>ESPresense Shed Uptime</summary>
		public NumericSensorEntity EspresenseShedUptime => new(_haContext, "sensor.espresense_shed_uptime");
		///<summary>ESPresense Tech Room Free Mem</summary>
		public NumericSensorEntity EspresenseTechRoomFreeMem => new(_haContext, "sensor.espresense_tech_room_free_mem");
		///<summary>ESPresense Tech Room Uptime</summary>
		public NumericSensorEntity EspresenseTechRoomUptime => new(_haContext, "sensor.espresense_tech_room_uptime");
		///<summary>Flowers Watering Time</summary>
		public NumericSensorEntity FloriWateringTime => new(_haContext, "sensor.flori_watering_time");
		///<summary>Gazebo Dimmer battery</summary>
		public NumericSensorEntity GazeboDimmerBattery => new(_haContext, "sensor.gazebo_dimmer_battery");
		///<summary>Gazebo Dimmer linkquality</summary>
		public NumericSensorEntity GazeboDimmerLinkquality => new(_haContext, "sensor.gazebo_dimmer_linkquality");
		///<summary>Gazebo Outlet linkquality</summary>
		public NumericSensorEntity GazeboOutletLinkquality => new(_haContext, "sensor.gazebo_outlet_linkquality");
		///<summary>Lawn Watering Time</summary>
		public NumericSensorEntity GazonMareWateringTime => new(_haContext, "sensor.gazon_mare_watering_time");
		///<summary>Small Lawn Watering Time</summary>
		public NumericSensorEntity GazonMicWateringTime => new(_haContext, "sensor.gazon_mic_watering_time");
		///<summary>Hall Motion Sensor Battery</summary>
		public NumericSensorEntity HallMotionSensorBattery => new(_haContext, "sensor.hall_motion_sensor_battery");
		///<summary>Hall Motion Sensor Illuminance</summary>
		public NumericSensorEntity HallMotionSensorIlluminanceLux => new(_haContext, "sensor.hall_motion_sensor_illuminance_lux");
		///<summary>Hall Motion Sensor Linkquality</summary>
		public NumericSensorEntity HallMotionSensorLinkquality => new(_haContext, "sensor.hall_motion_sensor_linkquality");
		///<summary>Hall Motion Sensor Temperature</summary>
		public NumericSensorEntity HallMotionSensorTemperature => new(_haContext, "sensor.hall_motion_sensor_temperature");
		///<summary>Hall Motion Sensor Voltage</summary>
		public NumericSensorEntity HallMotionSensorVoltage => new(_haContext, "sensor.hall_motion_sensor_voltage");
		///<summary>Illuminance</summary>
		public NumericSensorEntity Illuminance => new(_haContext, "sensor.illuminance");
		///<summary>Kitchen Button battery</summary>
		public NumericSensorEntity KitchenButtonBattery => new(_haContext, "sensor.kitchen_button_battery");
		///<summary>Kitchen Button linkquality</summary>
		public NumericSensorEntity KitchenButtonLinkquality => new(_haContext, "sensor.kitchen_button_linkquality");
		///<summary>Kitchen Coffee Maker Duration</summary>
		public NumericSensorEntity KitchenCoffeeMakerDuration => new(_haContext, "sensor.kitchen_coffee_maker_duration");
		///<summary>Kitchen Coffee Maker Program Progress</summary>
		public NumericSensorEntity KitchenCoffeeMakerProgramProgress => new(_haContext, "sensor.kitchen_coffee_maker_program_progress");
		///<summary>Kitchen Dimmer battery</summary>
		public NumericSensorEntity KitchenDimmerBattery => new(_haContext, "sensor.kitchen_dimmer_battery");
		///<summary>Kitchen Dimmer linkquality</summary>
		public NumericSensorEntity KitchenDimmerLinkquality => new(_haContext, "sensor.kitchen_dimmer_linkquality");
		///<summary>Kitchen Fridge Freezer Temperature</summary>
		public NumericSensorEntity KitchenFridgeFreezerTemp => new(_haContext, "sensor.kitchen_fridge_freezer_temp");
		///<summary>Kitchen Fridge Temperature</summary>
		public NumericSensorEntity KitchenFridgeFridgeTemp => new(_haContext, "sensor.kitchen_fridge_fridge_temp");
		///<summary>Kitchen Heat Detector battery</summary>
		public NumericSensorEntity KitchenHeatDetectorBattery => new(_haContext, "sensor.kitchen_heat_detector_battery");
		///<summary>Kitchen Heat Detector Linkquality</summary>
		public NumericSensorEntity KitchenHeatDetectorLinkquality => new(_haContext, "sensor.kitchen_heat_detector_linkquality");
		///<summary>Kitchen Heat Detector max duration</summary>
		public NumericSensorEntity KitchenHeatDetectorMaxDuration => new(_haContext, "sensor.kitchen_heat_detector_max_duration");
		///<summary>Kitchen Heat Detector Temperature</summary>
		public NumericSensorEntity KitchenHeatDetectorTemperature => new(_haContext, "sensor.kitchen_heat_detector_temperature");
		///<summary>Kitchen Motion Sensor Battery</summary>
		public NumericSensorEntity KitchenMotionSensorBattery => new(_haContext, "sensor.kitchen_motion_sensor_battery");
		///<summary>Kitchen Motion Sensor Illuminance</summary>
		public NumericSensorEntity KitchenMotionSensorIlluminanceLux => new(_haContext, "sensor.kitchen_motion_sensor_illuminance_lux");
		///<summary>Kitchen Motion Sensor Linkquality</summary>
		public NumericSensorEntity KitchenMotionSensorLinkquality => new(_haContext, "sensor.kitchen_motion_sensor_linkquality");
		///<summary>Kitchen Motion Sensor Temperature</summary>
		public NumericSensorEntity KitchenMotionSensorTemperature => new(_haContext, "sensor.kitchen_motion_sensor_temperature");
		///<summary>Kitchen Motion Sensor Voltage</summary>
		public NumericSensorEntity KitchenMotionSensorVoltage => new(_haContext, "sensor.kitchen_motion_sensor_voltage");
		///<summary>Kitchen Outlet linkquality</summary>
		public NumericSensorEntity KitchenOutletLinkquality => new(_haContext, "sensor.kitchen_outlet_linkquality");
		///<summary>Kitchen Outlet Right linkquality</summary>
		public NumericSensorEntity KitchenOutletRightLinkquality => new(_haContext, "sensor.kitchen_outlet_right_linkquality");
		///<summary>Kitchen Smoke Detector Battery</summary>
		public NumericSensorEntity KitchenSmokeDetectorBattery => new(_haContext, "sensor.kitchen_smoke_detector_battery");
		///<summary>Kitchen Smoke Detector Linkquality</summary>
		public NumericSensorEntity KitchenSmokeDetectorLinkquality => new(_haContext, "sensor.kitchen_smoke_detector_linkquality");
		///<summary>Kitchen Smoke Detector Max Duration</summary>
		public NumericSensorEntity KitchenSmokeDetectorMaxDuration => new(_haContext, "sensor.kitchen_smoke_detector_max_duration");
		///<summary>Kitchen Smoke Detector Temperature</summary>
		public NumericSensorEntity KitchenSmokeDetectorTemperature => new(_haContext, "sensor.kitchen_smoke_detector_temperature");
		///<summary>Kitchen Switch linkquality</summary>
		public NumericSensorEntity KitchenSwitchLinkquality => new(_haContext, "sensor.kitchen_switch_linkquality");
		///<summary>Kitchen Water Leak Sensor Battery</summary>
		public NumericSensorEntity KitchenWaterLeakSensorBattery => new(_haContext, "sensor.kitchen_water_leak_sensor_battery");
		///<summary>Kitchen Water Leak Sensor Linkquality</summary>
		public NumericSensorEntity KitchenWaterLeakSensorLinkquality => new(_haContext, "sensor.kitchen_water_leak_sensor_linkquality");
		///<summary>Kitchen Water Leak Sensor Temperature</summary>
		public NumericSensorEntity KitchenWaterLeakSensorTemperature => new(_haContext, "sensor.kitchen_water_leak_sensor_temperature");
		///<summary>Kitchen Water Leak Sensor Voltage</summary>
		public NumericSensorEntity KitchenWaterLeakSensorVoltage => new(_haContext, "sensor.kitchen_water_leak_sensor_voltage");
		///<summary>Living Room Door Contact battery</summary>
		public NumericSensorEntity LivingRoomDoorContactBattery => new(_haContext, "sensor.living_room_door_contact_battery");
		///<summary>Living Room Door Contact linkquality</summary>
		public NumericSensorEntity LivingRoomDoorContactLinkquality => new(_haContext, "sensor.living_room_door_contact_linkquality");
		///<summary>Living Room Door Contact Temperature</summary>
		public NumericSensorEntity LivingRoomDoorContactTemperature => new(_haContext, "sensor.living_room_door_contact_temperature");
		///<summary>Living Room Door Contact Voltage</summary>
		public NumericSensorEntity LivingRoomDoorContactVoltage => new(_haContext, "sensor.living_room_door_contact_voltage");
		///<summary>Living Room Motion Sensor Battery</summary>
		public NumericSensorEntity LivingRoomMotionSensorBattery => new(_haContext, "sensor.living_room_motion_sensor_battery");
		///<summary>Living Room Motion Sensor Illuminance</summary>
		public NumericSensorEntity LivingRoomMotionSensorIlluminanceLux => new(_haContext, "sensor.living_room_motion_sensor_illuminance_lux");
		///<summary>Living Room Motion Sensor Linkquality</summary>
		public NumericSensorEntity LivingRoomMotionSensorLinkquality => new(_haContext, "sensor.living_room_motion_sensor_linkquality");
		///<summary>Living Room Motion Sensor Temperature</summary>
		public NumericSensorEntity LivingRoomMotionSensorTemperature => new(_haContext, "sensor.living_room_motion_sensor_temperature");
		///<summary>Living Room Motion Sensor Voltage</summary>
		public NumericSensorEntity LivingRoomMotionSensorVoltage => new(_haContext, "sensor.living_room_motion_sensor_voltage");
		///<summary>Living Room RGB linkquality</summary>
		public NumericSensorEntity LivingRoomRgbLinkquality => new(_haContext, "sensor.living_room_rgb_linkquality");
		///<summary>Living Room Tablet Battery level</summary>
		public NumericSensorEntity LivingRoomTabletBatteryLevel => new(_haContext, "sensor.living_room_tablet_battery_level");
		///<summary>Living Room Tablet Battery Temperature</summary>
		public NumericSensorEntity LivingRoomTabletBatteryTemperature => new(_haContext, "sensor.living_room_tablet_battery_temperature");
		///<summary>Living Room Vacuum Current Clean Area</summary>
		public NumericSensorEntity LivingRoomVacuumCurrentCleanArea => new(_haContext, "sensor.living_room_vacuum_current_clean_area");
		///<summary>Living Room Vacuum Current Clean Duration</summary>
		public NumericSensorEntity LivingRoomVacuumCurrentCleanDuration => new(_haContext, "sensor.living_room_vacuum_current_clean_duration");
		///<summary>Living Room Vacuum Filter Left</summary>
		public NumericSensorEntity LivingRoomVacuumFilterLeft => new(_haContext, "sensor.living_room_vacuum_filter_left");
		///<summary>Living Room Vacuum Last Clean Area</summary>
		public NumericSensorEntity LivingRoomVacuumLastCleanArea => new(_haContext, "sensor.living_room_vacuum_last_clean_area");
		///<summary>Living Room Vacuum Last Clean Duration</summary>
		public NumericSensorEntity LivingRoomVacuumLastCleanDuration => new(_haContext, "sensor.living_room_vacuum_last_clean_duration");
		///<summary>Living Room Vacuum Main Brush Left</summary>
		public NumericSensorEntity LivingRoomVacuumMainBrushLeft => new(_haContext, "sensor.living_room_vacuum_main_brush_left");
		///<summary>Living Room Vacuum Sensor Dirty Left</summary>
		public NumericSensorEntity LivingRoomVacuumSensorDirtyLeft => new(_haContext, "sensor.living_room_vacuum_sensor_dirty_left");
		///<summary>Living Room Vacuum Side Brush Left</summary>
		public NumericSensorEntity LivingRoomVacuumSideBrushLeft => new(_haContext, "sensor.living_room_vacuum_side_brush_left");
		///<summary>Living Room Vacuum Total Clean Area</summary>
		public NumericSensorEntity LivingRoomVacuumTotalCleanArea => new(_haContext, "sensor.living_room_vacuum_total_clean_area");
		///<summary>Living Room Vacuum Total Clean Count</summary>
		public NumericSensorEntity LivingRoomVacuumTotalCleanCount => new(_haContext, "sensor.living_room_vacuum_total_clean_count");
		///<summary>Living Room Vacuum Total Duration</summary>
		public NumericSensorEntity LivingRoomVacuumTotalDuration => new(_haContext, "sensor.living_room_vacuum_total_duration");
		///<summary>HA Memory Free</summary>
		public NumericSensorEntity MemoryFree => new(_haContext, "sensor.memory_free");
		///<summary>HA Memory Use</summary>
		public NumericSensorEntity MemoryUse => new(_haContext, "sensor.memory_use");
		///<summary>HA Memory Use Percent</summary>
		public NumericSensorEntity MemoryUsePercent => new(_haContext, "sensor.memory_use_percent");
		///<summary>nico_phone App Memory</summary>
		public NumericSensorEntity NicoPhoneAppMemory => new(_haContext, "sensor.nico_phone_app_memory");
		///<summary>nico_phone App Rx GB</summary>
		public NumericSensorEntity NicoPhoneAppRxGb => new(_haContext, "sensor.nico_phone_app_rx_gb");
		///<summary>nico_phone App Tx GB</summary>
		public NumericSensorEntity NicoPhoneAppTxGb => new(_haContext, "sensor.nico_phone_app_tx_gb");
		///<summary>Nico Phone Battery Level</summary>
		public NumericSensorEntity NicoPhoneBatteryLevel => new(_haContext, "sensor.nico_phone_battery_level");
		///<summary>Nico Phone Battery Temperature</summary>
		public NumericSensorEntity NicoPhoneBatteryTemperature => new(_haContext, "sensor.nico_phone_battery_temperature");
		///<summary>Nico Phone Bluetooth Connection</summary>
		public NumericSensorEntity NicoPhoneBluetoothConnection => new(_haContext, "sensor.nico_phone_bluetooth_connection");
		///<summary>nico_phone External Storage</summary>
		public NumericSensorEntity NicoPhoneExternalStorage => new(_haContext, "sensor.nico_phone_external_storage");
		///<summary>nico_phone Internal Storage</summary>
		public NumericSensorEntity NicoPhoneInternalStorage => new(_haContext, "sensor.nico_phone_internal_storage");
		///<summary>Nico Phone light Sensor</summary>
		public NumericSensorEntity NicoPhoneLightSensor => new(_haContext, "sensor.nico_phone_light_sensor");
		///<summary>nico_phone Mobile Rx GB</summary>
		public NumericSensorEntity NicoPhoneMobileRxGb => new(_haContext, "sensor.nico_phone_mobile_rx_gb");
		///<summary>nico_phone Mobile Tx GB</summary>
		public NumericSensorEntity NicoPhoneMobileTxGb => new(_haContext, "sensor.nico_phone_mobile_tx_gb");
		///<summary>Nico Phone Pressure Sensor</summary>
		public NumericSensorEntity NicoPhonePressureSensor => new(_haContext, "sensor.nico_phone_pressure_sensor");
		///<summary>nico_phone Total Rx GB</summary>
		public NumericSensorEntity NicoPhoneTotalRxGb => new(_haContext, "sensor.nico_phone_total_rx_gb");
		///<summary>nico_phone Total Tx GB</summary>
		public NumericSensorEntity NicoPhoneTotalTxGb => new(_haContext, "sensor.nico_phone_total_tx_gb");
		///<summary>nico_phone WiFi Frequency</summary>
		public NumericSensorEntity NicoPhoneWifiFrequency => new(_haContext, "sensor.nico_phone_wifi_frequency");
		///<summary>nico_phone WiFi Link Speed</summary>
		public NumericSensorEntity NicoPhoneWifiLinkSpeed => new(_haContext, "sensor.nico_phone_wifi_link_speed");
		///<summary>nico_phone WiFi Signal Strength</summary>
		public NumericSensorEntity NicoPhoneWifiSignalStrength => new(_haContext, "sensor.nico_phone_wifi_signal_strength");
		///<summary>Office PC Storage H Used Space</summary>
		public NumericSensorEntity OffciePcStorageHUsedSpace => new(_haContext, "sensor.offcie_pc_storage_h_used_space");
		///<summary>Office Chair Vibration Sensor angle x</summary>
		public NumericSensorEntity OfficeChairVibrationSensorAngleX => new(_haContext, "sensor.office_chair_vibration_sensor_angle_x");
		///<summary>Office Chair Vibration Sensor angle y</summary>
		public NumericSensorEntity OfficeChairVibrationSensorAngleY => new(_haContext, "sensor.office_chair_vibration_sensor_angle_y");
		///<summary>Office Chair Vibration Sensor angle z</summary>
		public NumericSensorEntity OfficeChairVibrationSensorAngleZ => new(_haContext, "sensor.office_chair_vibration_sensor_angle_z");
		///<summary>Office Chair Vibration Sensor battery</summary>
		public NumericSensorEntity OfficeChairVibrationSensorBattery => new(_haContext, "sensor.office_chair_vibration_sensor_battery");
		///<summary>Office Chair Vibration Sensor device temperature</summary>
		public NumericSensorEntity OfficeChairVibrationSensorDeviceTemperature => new(_haContext, "sensor.office_chair_vibration_sensor_device_temperature");
		///<summary>Office Chair Vibration Sensor linkquality</summary>
		public NumericSensorEntity OfficeChairVibrationSensorLinkquality => new(_haContext, "sensor.office_chair_vibration_sensor_linkquality");
		///<summary>Office Chair Vibration Sensor voltage</summary>
		public NumericSensorEntity OfficeChairVibrationSensorVoltage => new(_haContext, "sensor.office_chair_vibration_sensor_voltage");
		///<summary>Office Dimmer battery</summary>
		public NumericSensorEntity OfficeDimmerBattery => new(_haContext, "sensor.office_dimmer_battery");
		///<summary>Office Door Contact Battery</summary>
		public NumericSensorEntity OfficeDoorContactBattery => new(_haContext, "sensor.office_door_contact_battery");
		///<summary>Office Door device temperature</summary>
		public NumericSensorEntity OfficeDoorDeviceTemperature => new(_haContext, "sensor.office_door_device_temperature");
		///<summary>Office Door linkquality</summary>
		public NumericSensorEntity OfficeDoorLinkquality => new(_haContext, "sensor.office_door_linkquality");
		///<summary>Office Door voltage</summary>
		public NumericSensorEntity OfficeDoorVoltage => new(_haContext, "sensor.office_door_voltage");
		///<summary>Office Motion Sensor Battery</summary>
		public NumericSensorEntity OfficeMotionSensorBattery => new(_haContext, "sensor.office_motion_sensor_battery");
		///<summary>Office Motion Sensor Illuminance</summary>
		public NumericSensorEntity OfficeMotionSensorIlluminanceLux => new(_haContext, "sensor.office_motion_sensor_illuminance_lux");
		///<summary>Office Motion Sensor linkquality</summary>
		public NumericSensorEntity OfficeMotionSensorLinkquality => new(_haContext, "sensor.office_motion_sensor_linkquality");
		///<summary>Office Motion Sensor Temperature</summary>
		public NumericSensorEntity OfficeMotionSensorTemperature => new(_haContext, "sensor.office_motion_sensor_temperature");
		///<summary>Office Motion Sensor Voltage</summary>
		public NumericSensorEntity OfficeMotionSensorVoltage => new(_haContext, "sensor.office_motion_sensor_voltage");
		///<summary>Office PC CPU Usage</summary>
		public NumericSensorEntity OfficePcCpuUsage => new(_haContext, "sensor.office_pc_cpu_usage");
		///<summary>Office PC Memory Available</summary>
		public NumericSensorEntity OfficePcMemoryAvailable => new(_haContext, "sensor.office_pc_memory_available");
		///<summary>Office PC Memory Total</summary>
		public NumericSensorEntity OfficePcMemoryTotal => new(_haContext, "sensor.office_pc_memory_total");
		///<summary>Office PC Memory Usage</summary>
		public NumericSensorEntity OfficePcMemoryUsage => new(_haContext, "sensor.office_pc_memory_usage");
		///<summary>Office PC Memory Used</summary>
		public NumericSensorEntity OfficePcMemoryUsed => new(_haContext, "sensor.office_pc_memory_used");
		///<summary>Office PC Network BPS received</summary>
		public NumericSensorEntity OfficePcNetworkBpsReceived => new(_haContext, "sensor.office_pc_network_bps_received");
		///<summary>Office PC Network BPS sent</summary>
		public NumericSensorEntity OfficePcNetworkBpsSent => new(_haContext, "sensor.office_pc_network_bps_sent");
		///<summary>Office PC Network Bytes Received</summary>
		public NumericSensorEntity OfficePcNetworkBytesReceived => new(_haContext, "sensor.office_pc_network_bytes_received");
		///<summary>Office PC Network Bytes Sent</summary>
		public NumericSensorEntity OfficePcNetworkBytesSent => new(_haContext, "sensor.office_pc_network_bytes_sent");
		///<summary>Office PC Network Speed</summary>
		public NumericSensorEntity OfficePcNetworkSpeed => new(_haContext, "sensor.office_pc_network_speed");
		///<summary>Office PC Storage C Available Free Space</summary>
		public NumericSensorEntity OfficePcStorageCAvailableFreeSpace => new(_haContext, "sensor.office_pc_storage_c_available_free_space");
		///<summary>Office PC Storage C Total</summary>
		public NumericSensorEntity OfficePcStorageCTotal => new(_haContext, "sensor.office_pc_storage_c_total");
		///<summary>Office PC Storage C Total Free Space</summary>
		public NumericSensorEntity OfficePcStorageCTotalFreeSpace => new(_haContext, "sensor.office_pc_storage_c_total_free_space");
		///<summary>Office PC Storage C Usage</summary>
		public NumericSensorEntity OfficePcStorageCUsage => new(_haContext, "sensor.office_pc_storage_c_usage");
		///<summary>Office PC Storage C Used Space</summary>
		public NumericSensorEntity OfficePcStorageCUsedSpace => new(_haContext, "sensor.office_pc_storage_c_used_space");
		///<summary>Office PC Storage D Available Free Space</summary>
		public NumericSensorEntity OfficePcStorageDAvailableFreeSpace => new(_haContext, "sensor.office_pc_storage_d_available_free_space");
		///<summary>Office PC Storage D Total</summary>
		public NumericSensorEntity OfficePcStorageDTotal => new(_haContext, "sensor.office_pc_storage_d_total");
		///<summary>Office PC Storage D Total Free Space</summary>
		public NumericSensorEntity OfficePcStorageDTotalFreeSpace => new(_haContext, "sensor.office_pc_storage_d_total_free_space");
		///<summary>Office PC Storage D Usage</summary>
		public NumericSensorEntity OfficePcStorageDUsage => new(_haContext, "sensor.office_pc_storage_d_usage");
		///<summary>Office PC Storage D Used Space</summary>
		public NumericSensorEntity OfficePcStorageDUsedSpace => new(_haContext, "sensor.office_pc_storage_d_used_space");
		///<summary>Office PC Storage E Available Free Space</summary>
		public NumericSensorEntity OfficePcStorageEAvailableFreeSpace => new(_haContext, "sensor.office_pc_storage_e_available_free_space");
		///<summary>Office PC Storage E Total</summary>
		public NumericSensorEntity OfficePcStorageETotal => new(_haContext, "sensor.office_pc_storage_e_total");
		///<summary>Office PC Storage E Total Free Space</summary>
		public NumericSensorEntity OfficePcStorageETotalFreeSpace => new(_haContext, "sensor.office_pc_storage_e_total_free_space");
		///<summary>Office PC Storage E Usage</summary>
		public NumericSensorEntity OfficePcStorageEUsage => new(_haContext, "sensor.office_pc_storage_e_usage");
		///<summary>Office PC Storage E Used Space</summary>
		public NumericSensorEntity OfficePcStorageEUsedSpace => new(_haContext, "sensor.office_pc_storage_e_used_space");
		///<summary>Office PC Storage F Available Free Space</summary>
		public NumericSensorEntity OfficePcStorageFAvailableFreeSpace => new(_haContext, "sensor.office_pc_storage_f_available_free_space");
		///<summary>Office PC Storage F Total</summary>
		public NumericSensorEntity OfficePcStorageFTotal => new(_haContext, "sensor.office_pc_storage_f_total");
		///<summary>Office PC Storage F Total Free Space</summary>
		public NumericSensorEntity OfficePcStorageFTotalFreeSpace => new(_haContext, "sensor.office_pc_storage_f_total_free_space");
		///<summary>Office PC Storage F Usage</summary>
		public NumericSensorEntity OfficePcStorageFUsage => new(_haContext, "sensor.office_pc_storage_f_usage");
		///<summary>Office PC Storage F Used Space</summary>
		public NumericSensorEntity OfficePcStorageFUsedSpace => new(_haContext, "sensor.office_pc_storage_f_used_space");
		///<summary>Office PC Storage G Available Free Space</summary>
		public NumericSensorEntity OfficePcStorageGAvailableFreeSpace => new(_haContext, "sensor.office_pc_storage_g_available_free_space");
		///<summary>Office PC Storage G Total Free Space</summary>
		public NumericSensorEntity OfficePcStorageGTotalFreeSpace => new(_haContext, "sensor.office_pc_storage_g_total_free_space");
		///<summary>Office PC Storage G Total</summary>
		public NumericSensorEntity OfficePcStorageGTotalStorage => new(_haContext, "sensor.office_pc_storage_g_total_storage");
		///<summary>Office PC Storage G Usage</summary>
		public NumericSensorEntity OfficePcStorageGUsage => new(_haContext, "sensor.office_pc_storage_g_usage");
		///<summary>Office PC Storage G Used Space</summary>
		public NumericSensorEntity OfficePcStorageGUsedSpace => new(_haContext, "sensor.office_pc_storage_g_used_space");
		///<summary>Office PC Storage H Available Free Space</summary>
		public NumericSensorEntity OfficePcStorageHAvailableFreeSpace => new(_haContext, "sensor.office_pc_storage_h_available_free_space");
		///<summary>Office PC Storage H Total</summary>
		public NumericSensorEntity OfficePcStorageHTotal => new(_haContext, "sensor.office_pc_storage_h_total");
		///<summary>Office PC Storage H Total Free Space</summary>
		public NumericSensorEntity OfficePcStorageHTotalFreeSpace => new(_haContext, "sensor.office_pc_storage_h_total_free_space");
		///<summary>Office PC Storage H Usage</summary>
		public NumericSensorEntity OfficePcStorageHUsage => new(_haContext, "sensor.office_pc_storage_h_usage");
		///<summary>Office PC User Idle</summary>
		public NumericSensorEntity OfficePcUserIdle => new(_haContext, "sensor.office_pc_user_idle");
		///<summary>Office Printer Black Cartridge</summary>
		public NumericSensorEntity OfficePrinterBlackCartridge => new(_haContext, "sensor.office_printer_black_cartridge");
		///<summary>Office Printer Cyan Cartridge</summary>
		public NumericSensorEntity OfficePrinterCyanCartridge => new(_haContext, "sensor.office_printer_cyan_cartridge");
		///<summary>Office Printer Magenta Cartridge</summary>
		public NumericSensorEntity OfficePrinterMagentaCartridge => new(_haContext, "sensor.office_printer_magenta_cartridge");
		///<summary>Office Printer Yellow Cartridge</summary>
		public NumericSensorEntity OfficePrinterYellowCartridge => new(_haContext, "sensor.office_printer_yellow_cartridge");
		///<summary>Office Remote Temperature</summary>
		public NumericSensorEntity OfficeRemoteTemperature => new(_haContext, "sensor.office_remote_temperature");
		///<summary>Lawn Pump Watering Time</summary>
		public NumericSensorEntity PompaWateringTime => new(_haContext, "sensor.pompa_watering_time");
		///<summary>HA Processor Use</summary>
		public NumericSensorEntity ProcessorUse => new(_haContext, "sensor.processor_use");
		///<summary>rares_phone App Memory</summary>
		public NumericSensorEntity RaresPhoneAppMemory => new(_haContext, "sensor.rares_phone_app_memory");
		///<summary>rares_phone App Rx GB</summary>
		public NumericSensorEntity RaresPhoneAppRxGb => new(_haContext, "sensor.rares_phone_app_rx_gb");
		///<summary>rares_phone App Tx GB</summary>
		public NumericSensorEntity RaresPhoneAppTxGb => new(_haContext, "sensor.rares_phone_app_tx_gb");
		///<summary>rares_phone Battery Level</summary>
		public NumericSensorEntity RaresPhoneBatteryLevel => new(_haContext, "sensor.rares_phone_battery_level");
		///<summary>rares_phone Battery Temperature</summary>
		public NumericSensorEntity RaresPhoneBatteryTemperature => new(_haContext, "sensor.rares_phone_battery_temperature");
		///<summary>rares_phone Bluetooth Connection</summary>
		public NumericSensorEntity RaresPhoneBluetoothConnection => new(_haContext, "sensor.rares_phone_bluetooth_connection");
		///<summary>rares_phone External Storage</summary>
		public NumericSensorEntity RaresPhoneExternalStorage => new(_haContext, "sensor.rares_phone_external_storage");
		///<summary>rares_phone Internal Storage</summary>
		public NumericSensorEntity RaresPhoneInternalStorage => new(_haContext, "sensor.rares_phone_internal_storage");
		///<summary>rares_phone Light Sensor</summary>
		public NumericSensorEntity RaresPhoneLightSensor => new(_haContext, "sensor.rares_phone_light_sensor");
		///<summary>rares_phone Mobile Rx GB</summary>
		public NumericSensorEntity RaresPhoneMobileRxGb => new(_haContext, "sensor.rares_phone_mobile_rx_gb");
		///<summary>rares_phone Mobile Tx GB</summary>
		public NumericSensorEntity RaresPhoneMobileTxGb => new(_haContext, "sensor.rares_phone_mobile_tx_gb");
		///<summary>rares_phone Total Rx GB</summary>
		public NumericSensorEntity RaresPhoneTotalRxGb => new(_haContext, "sensor.rares_phone_total_rx_gb");
		///<summary>rares_phone Total Tx GB</summary>
		public NumericSensorEntity RaresPhoneTotalTxGb => new(_haContext, "sensor.rares_phone_total_tx_gb");
		///<summary>rares_phone WiFi Frequency</summary>
		public NumericSensorEntity RaresPhoneWifiFrequency => new(_haContext, "sensor.rares_phone_wifi_frequency");
		///<summary>rares_phone WiFi Link Speed</summary>
		public NumericSensorEntity RaresPhoneWifiLinkSpeed => new(_haContext, "sensor.rares_phone_wifi_link_speed");
		///<summary>rares_phone WiFi Signal Strength</summary>
		public NumericSensorEntity RaresPhoneWifiSignalStrength => new(_haContext, "sensor.rares_phone_wifi_signal_strength");
		///<summary>razvan phone App Memory</summary>
		public NumericSensorEntity RazvanPhoneAppMemory => new(_haContext, "sensor.razvan_phone_app_memory");
		///<summary>razvan phone App Rx GB</summary>
		public NumericSensorEntity RazvanPhoneAppRxGb => new(_haContext, "sensor.razvan_phone_app_rx_gb");
		///<summary>razvan phone App Tx GB</summary>
		public NumericSensorEntity RazvanPhoneAppTxGb => new(_haContext, "sensor.razvan_phone_app_tx_gb");
		///<summary>razvan phone Battery Level</summary>
		public NumericSensorEntity RazvanPhoneBatteryLevel => new(_haContext, "sensor.razvan_phone_battery_level");
		///<summary>razvan phone Battery Temperature</summary>
		public NumericSensorEntity RazvanPhoneBatteryTemperature => new(_haContext, "sensor.razvan_phone_battery_temperature");
		///<summary>razvan phone Bluetooth Connection</summary>
		public NumericSensorEntity RazvanPhoneBluetoothConnection => new(_haContext, "sensor.razvan_phone_bluetooth_connection");
		///<summary>razvan phone External Storage</summary>
		public NumericSensorEntity RazvanPhoneExternalStorage => new(_haContext, "sensor.razvan_phone_external_storage");
		///<summary>razvan phone High Accuracy Update Interval</summary>
		public NumericSensorEntity RazvanPhoneHighAccuracyUpdateInterval => new(_haContext, "sensor.razvan_phone_high_accuracy_update_interval");
		///<summary>razvan phone Internal Storage</summary>
		public NumericSensorEntity RazvanPhoneInternalStorage => new(_haContext, "sensor.razvan_phone_internal_storage");
		///<summary>razvan phone Light Sensor</summary>
		public NumericSensorEntity RazvanPhoneLightSensor => new(_haContext, "sensor.razvan_phone_light_sensor");
		///<summary>razvan phone Mobile Rx GB</summary>
		public NumericSensorEntity RazvanPhoneMobileRxGb => new(_haContext, "sensor.razvan_phone_mobile_rx_gb");
		///<summary>razvan phone Mobile Tx GB</summary>
		public NumericSensorEntity RazvanPhoneMobileTxGb => new(_haContext, "sensor.razvan_phone_mobile_tx_gb");
		///<summary>razvan phone Pressure Sensor</summary>
		public NumericSensorEntity RazvanPhonePressureSensor => new(_haContext, "sensor.razvan_phone_pressure_sensor");
		///<summary>razvan phone Sleep Confidence</summary>
		public NumericSensorEntity RazvanPhoneSleepConfidence => new(_haContext, "sensor.razvan_phone_sleep_confidence");
		///<summary>razvan phone Sleep Segment</summary>
		public NumericSensorEntity RazvanPhoneSleepSegment => new(_haContext, "sensor.razvan_phone_sleep_segment");
		///<summary>razvan phone Steps Sensor</summary>
		public NumericSensorEntity RazvanPhoneStepsSensor => new(_haContext, "sensor.razvan_phone_steps_sensor");
		///<summary>razvan phone Total Rx GB</summary>
		public NumericSensorEntity RazvanPhoneTotalRxGb => new(_haContext, "sensor.razvan_phone_total_rx_gb");
		///<summary>razvan phone Total Tx GB</summary>
		public NumericSensorEntity RazvanPhoneTotalTxGb => new(_haContext, "sensor.razvan_phone_total_tx_gb");
		///<summary>razvan phone WiFi Frequency</summary>
		public NumericSensorEntity RazvanPhoneWifiFrequency => new(_haContext, "sensor.razvan_phone_wifi_frequency");
		///<summary>razvan phone WiFi Link Speed</summary>
		public NumericSensorEntity RazvanPhoneWifiLinkSpeed => new(_haContext, "sensor.razvan_phone_wifi_link_speed");
		///<summary>razvan phone WiFi Signal Strength</summary>
		public NumericSensorEntity RazvanPhoneWifiSignalStrength => new(_haContext, "sensor.razvan_phone_wifi_signal_strength");
		///<summary>File editor: CPU Percent</summary>
		public NumericSensorEntity ServiceFileEditorCpuPercent => new(_haContext, "sensor.service_file_editor_cpu_percent");
		///<summary>File editor: Memory Percent</summary>
		public NumericSensorEntity ServiceFileEditorMemoryPercent => new(_haContext, "sensor.service_file_editor_memory_percent");
		///<summary>hacs</summary>
		public NumericSensorEntity ServiceHacs => new(_haContext, "sensor.service_hacs");
		///<summary>MariaDB: CPU Percent</summary>
		public NumericSensorEntity ServiceMariadbCpuPercent => new(_haContext, "sensor.service_mariadb_cpu_percent");
		///<summary>MariaDB: Memory Percent</summary>
		public NumericSensorEntity ServiceMariadbMemoryPercent => new(_haContext, "sensor.service_mariadb_memory_percent");
		///<summary>Mosquitto broker: CPU Percent</summary>
		public NumericSensorEntity ServiceMosquittoCpuPercent => new(_haContext, "sensor.service_mosquitto_cpu_percent");
		///<summary>Mosquitto broker: Memory Percent</summary>
		public NumericSensorEntity ServiceMosquittoMemoryPercent => new(_haContext, "sensor.service_mosquitto_memory_percent");
		///<summary>NetDaemon V3 - beta: CPU Percent</summary>
		public NumericSensorEntity ServiceNetdaemonCpuPercent => new(_haContext, "sensor.service_netdaemon_cpu_percent");
		///<summary>NetDaemon V3 - beta: Memory Percent</summary>
		public NumericSensorEntity ServiceNetdaemonMemoryPercent => new(_haContext, "sensor.service_netdaemon_memory_percent");
		///<summary>RPC Shutdown: CPU Percent</summary>
		public NumericSensorEntity ServiceRpcShutdownCpuPercent => new(_haContext, "sensor.service_rpc_shutdown_cpu_percent");
		///<summary>RPC Shutdown: Memory Percent</summary>
		public NumericSensorEntity ServiceRpcShutdownMemoryPercent => new(_haContext, "sensor.service_rpc_shutdown_memory_percent");
		///<summary>Samba share: CPU Percent</summary>
		public NumericSensorEntity ServiceSambaCpuPercent => new(_haContext, "sensor.service_samba_cpu_percent");
		///<summary>Samba share: Memory Percent</summary>
		public NumericSensorEntity ServiceSambaMemoryPercent => new(_haContext, "sensor.service_samba_memory_percent");
		///<summary>SpeedTest Download</summary>
		public NumericSensorEntity ServiceSpeedTestDownload => new(_haContext, "sensor.service_speed_test_download");
		///<summary>SpeedTest Ping</summary>
		public NumericSensorEntity ServiceSpeedTestPing => new(_haContext, "sensor.service_speed_test_ping");
		///<summary>SpeedTest Upload</summary>
		public NumericSensorEntity ServiceSpeedTestUpload => new(_haContext, "sensor.service_speed_test_upload");
		///<summary>Terminal & SSH: CPU Percent</summary>
		public NumericSensorEntity ServiceTerminalSshCpuPercent => new(_haContext, "sensor.service_terminal_ssh_cpu_percent");
		///<summary>Terminal & SSH: Memory Percent</summary>
		public NumericSensorEntity ServiceTerminalSshMemoryPercent => new(_haContext, "sensor.service_terminal_ssh_memory_percent");
		///<summary>Shed Motion Sensor Battery</summary>
		public NumericSensorEntity ShedMotionSensorBattery => new(_haContext, "sensor.shed_motion_sensor_battery");
		///<summary>Shed Motion Sensor Linkquality</summary>
		public NumericSensorEntity ShedMotionSensorLinkquality => new(_haContext, "sensor.shed_motion_sensor_linkquality");
		///<summary>Shed Motion Sensor Voltage</summary>
		public NumericSensorEntity ShedMotionSensorVoltage => new(_haContext, "sensor.shed_motion_sensor_voltage");
		///<summary>Shed Outlet linkquality</summary>
		public NumericSensorEntity ShedOutletLinkquality => new(_haContext, "sensor.shed_outlet_linkquality");
		///<summary>Shed Weather Sensor Battery</summary>
		public NumericSensorEntity ShedWeatherSensorBattery => new(_haContext, "sensor.shed_weather_sensor_battery");
		///<summary>Shed Weather Sensor Humidity</summary>
		public NumericSensorEntity ShedWeatherSensorHumidity => new(_haContext, "sensor.shed_weather_sensor_humidity");
		///<summary>Shed Weather Sensor Linkquality</summary>
		public NumericSensorEntity ShedWeatherSensorLinkquality => new(_haContext, "sensor.shed_weather_sensor_linkquality");
		///<summary>Shed Weather Sensor Pressure</summary>
		public NumericSensorEntity ShedWeatherSensorPressure => new(_haContext, "sensor.shed_weather_sensor_pressure");
		///<summary>Shed Weather Sensor Temperature</summary>
		public NumericSensorEntity ShedWeatherSensorTemperature => new(_haContext, "sensor.shed_weather_sensor_temperature");
		///<summary>Shed Weather Sensor Voltage</summary>
		public NumericSensorEntity ShedWeatherSensorVoltage => new(_haContext, "sensor.shed_weather_sensor_voltage");
		///<summary>Shower Door Contact Battery</summary>
		public NumericSensorEntity ShowerDoorContactBattery => new(_haContext, "sensor.shower_door_contact_battery");
		///<summary>Shower Door Contact Linkquality</summary>
		public NumericSensorEntity ShowerDoorContactLinkquality => new(_haContext, "sensor.shower_door_contact_linkquality");
		///<summary>Shower Door Contact Temperature</summary>
		public NumericSensorEntity ShowerDoorContactTemperature => new(_haContext, "sensor.shower_door_contact_temperature");
		///<summary>Shower Door Contact Voltage</summary>
		public NumericSensorEntity ShowerDoorContactVoltage => new(_haContext, "sensor.shower_door_contact_voltage");
		///<summary>Shower Motion Sensor Battery</summary>
		public NumericSensorEntity ShowerMotionSensorBattery => new(_haContext, "sensor.shower_motion_sensor_battery");
		///<summary>Shower Motion Sensor Linkquality</summary>
		public NumericSensorEntity ShowerMotionSensorLinkquality => new(_haContext, "sensor.shower_motion_sensor_linkquality");
		///<summary>Shower Motion voltage</summary>
		public NumericSensorEntity ShowerMotionVoltage => new(_haContext, "sensor.shower_motion_voltage");
		///<summary>Shower Water Leak Sensor Battery</summary>
		public NumericSensorEntity ShowerWaterLeakSensorBattery => new(_haContext, "sensor.shower_water_leak_sensor_battery");
		///<summary>Shower Water Leak Sensor Linquality</summary>
		public NumericSensorEntity ShowerWaterLeakSensorLinkquality => new(_haContext, "sensor.shower_water_leak_sensor_linkquality");
		///<summary>Shower Water Leak Sensor Temperature</summary>
		public NumericSensorEntity ShowerWaterLeakSensorTemperature => new(_haContext, "sensor.shower_water_leak_sensor_temperature");
		///<summary>Shower Water Leak Sensor Voltage</summary>
		public NumericSensorEntity ShowerWaterLeakSensorVoltage => new(_haContext, "sensor.shower_water_leak_sensor_voltage");
		///<summary>Shower Weather Sensor Battery</summary>
		public NumericSensorEntity ShowerWeatherSensorBattery => new(_haContext, "sensor.shower_weather_sensor_battery");
		///<summary>Shower Weather Sensor Humidity</summary>
		public NumericSensorEntity ShowerWeatherSensorHumidity => new(_haContext, "sensor.shower_weather_sensor_humidity");
		///<summary>Shower Weather Sensor Linkquality</summary>
		public NumericSensorEntity ShowerWeatherSensorLinkquality => new(_haContext, "sensor.shower_weather_sensor_linkquality");
		///<summary>Shower Weather Sensor Pressure</summary>
		public NumericSensorEntity ShowerWeatherSensorPressure => new(_haContext, "sensor.shower_weather_sensor_pressure");
		///<summary>Shower Weather Sensor Temperature</summary>
		public NumericSensorEntity ShowerWeatherSensorTemperature => new(_haContext, "sensor.shower_weather_sensor_temperature");
		///<summary>Shower Weather Sensor Voltage</summary>
		public NumericSensorEntity ShowerWeatherSensorVoltage => new(_haContext, "sensor.shower_weather_sensor_voltage");
		///<summary>Stairs Motion Sensor Down Battery</summary>
		public NumericSensorEntity StairsMotionSensorDownBattery => new(_haContext, "sensor.stairs_motion_sensor_down_battery");
		///<summary>Stairs Motion Sensor Down Linkquality</summary>
		public NumericSensorEntity StairsMotionSensorDownLinkquality => new(_haContext, "sensor.stairs_motion_sensor_down_linkquality");
		///<summary>Stairs Motion Sensor Down Voltage</summary>
		public NumericSensorEntity StairsMotionSensorDownVoltage => new(_haContext, "sensor.stairs_motion_sensor_down_voltage");
		///<summary>Stairs Motion Sensor Up Battery</summary>
		public NumericSensorEntity StairsMotionSensorUpBattery => new(_haContext, "sensor.stairs_motion_sensor_up_battery");
		///<summary>Stairs Motion Sensor Up Linkquality</summary>
		public NumericSensorEntity StairsMotionSensorUpLinkquality => new(_haContext, "sensor.stairs_motion_sensor_up_linkquality");
		///<summary>Stairs Motion Up voltage</summary>
		public NumericSensorEntity StairsMotionUpVoltage => new(_haContext, "sensor.stairs_motion_up_voltage");
		///<summary>Stairs Vibration Sensor Angle X</summary>
		public NumericSensorEntity StairsVibrationSensorAngleX => new(_haContext, "sensor.stairs_vibration_sensor_angle_x");
		///<summary>Stairs Vibration Sensor Angle Y</summary>
		public NumericSensorEntity StairsVibrationSensorAngleY => new(_haContext, "sensor.stairs_vibration_sensor_angle_y");
		///<summary>Stairs Vibration Sensor Angle Z</summary>
		public NumericSensorEntity StairsVibrationSensorAngleZ => new(_haContext, "sensor.stairs_vibration_sensor_angle_z");
		///<summary>Stairs Vibration Sensor Battery</summary>
		public NumericSensorEntity StairsVibrationSensorBattery => new(_haContext, "sensor.stairs_vibration_sensor_battery");
		///<summary>Stairs Vibration Sensor Linkquality</summary>
		public NumericSensorEntity StairsVibrationSensorLinkquality => new(_haContext, "sensor.stairs_vibration_sensor_linkquality");
		///<summary>Stairs Vibration Sensor Temperature</summary>
		public NumericSensorEntity StairsVibrationSensorTemperature => new(_haContext, "sensor.stairs_vibration_sensor_temperature");
		///<summary>Stairs Vibration Sensor Voltage</summary>
		public NumericSensorEntity StairsVibrationSensorVoltage => new(_haContext, "sensor.stairs_vibration_sensor_voltage");
		///<summary>Statistics Energy Cost Daily</summary>
		public NumericSensorEntity StatisticsEnergyCostDaily => new(_haContext, "sensor.statistics_energy_cost_daily");
		///<summary>Statistics Energy Cost Hourly</summary>
		public NumericSensorEntity StatisticsEnergyCostHourly => new(_haContext, "sensor.statistics_energy_cost_hourly");
		///<summary>Statistics Energy Cost Monthly</summary>
		public NumericSensorEntity StatisticsEnergyCostMonthly => new(_haContext, "sensor.statistics_energy_cost_monthly");
		///<summary>Statistics Energy Cost Quarterly</summary>
		public NumericSensorEntity StatisticsEnergyCostQuarterly => new(_haContext, "sensor.statistics_energy_cost_quarterly");
		///<summary>Statistics Energy Cost Weekly</summary>
		public NumericSensorEntity StatisticsEnergyCostWeekly => new(_haContext, "sensor.statistics_energy_cost_weekly");
		///<summary>Statistics Energy Cost Yearly</summary>
		public NumericSensorEntity StatisticsEnergyCostYearly => new(_haContext, "sensor.statistics_energy_cost_yearly");
		///<summary>Statistics Energy Daily</summary>
		public NumericSensorEntity StatisticsEnergyDaily => new(_haContext, "sensor.statistics_energy_daily");
		///<summary>Statistics Energy Hourly</summary>
		public NumericSensorEntity StatisticsEnergyHourly => new(_haContext, "sensor.statistics_energy_hourly");
		///<summary>Statistics Energy Monthly</summary>
		public NumericSensorEntity StatisticsEnergyMonthly => new(_haContext, "sensor.statistics_energy_monthly");
		///<summary>Statistics Energy Quarterly</summary>
		public NumericSensorEntity StatisticsEnergyQuarterly => new(_haContext, "sensor.statistics_energy_quarterly");
		///<summary>Statistics Energy Weekly</summary>
		public NumericSensorEntity StatisticsEnergyWeekly => new(_haContext, "sensor.statistics_energy_weekly");
		///<summary>Statistics Energy Yearly</summary>
		public NumericSensorEntity StatisticsEnergyYearly => new(_haContext, "sensor.statistics_energy_yearly");
		///<summary>Tech Room Door Contact Battery</summary>
		public NumericSensorEntity TechRoomDoorContactBattery => new(_haContext, "sensor.tech_room_door_contact_battery");
		///<summary>Tech Room Door Contact Linkquality</summary>
		public NumericSensorEntity TechRoomDoorContactLinkquality => new(_haContext, "sensor.tech_room_door_contact_linkquality");
		///<summary>Tech Room Door Contact Temperature</summary>
		public NumericSensorEntity TechRoomDoorContactTemperature => new(_haContext, "sensor.tech_room_door_contact_temperature");
		///<summary>Tech Room Door Contact Voltage</summary>
		public NumericSensorEntity TechRoomDoorContactVoltage => new(_haContext, "sensor.tech_room_door_contact_voltage");
		///<summary>Tech Room Meter Energy</summary>
		public NumericSensorEntity TechRoomMeterEnergy => new(_haContext, "sensor.tech_room_meter_energy");
		///<summary>sensor Cost</summary>
		public NumericSensorEntity TechRoomMeterEnergyCost => new(_haContext, "sensor.tech_room_meter_energy_cost");
		///<summary>Tech Room Meter Power</summary>
		public NumericSensorEntity TechRoomMeterPower => new(_haContext, "sensor.tech_room_meter_power");
		///<summary>Tech Room Meter Power Factor</summary>
		public NumericSensorEntity TechRoomMeterPowerFactor => new(_haContext, "sensor.tech_room_meter_power_factor");
		///<summary>Tech Room Meter RSSI</summary>
		public NumericSensorEntity TechRoomMeterRssi => new(_haContext, "sensor.tech_room_meter_rssi");
		///<summary>Tech Room Meter Voltage</summary>
		public NumericSensorEntity TechRoomMeterVoltage => new(_haContext, "sensor.tech_room_meter_voltage");
		///<summary>Tech Room UPS Battery Capacity</summary>
		public NumericSensorEntity TechRoomUpsBatteryCapacity => new(_haContext, "sensor.tech_room_ups_battery_capacity");
		///<summary>Tech Room UPS Battery Runtime Remaining</summary>
		public NumericSensorEntity TechRoomUpsBatteryRuntimeRemaining => new(_haContext, "sensor.tech_room_ups_battery_runtime_remaining");
		///<summary>Tech Room UPS Battery Time On</summary>
		public NumericSensorEntity TechRoomUpsBatteryTimeOn => new(_haContext, "sensor.tech_room_ups_battery_time_on");
		///<summary>Tech Room UPS Input Frequency</summary>
		public NumericSensorEntity TechRoomUpsInputFrequency => new(_haContext, "sensor.tech_room_ups_input_frequency");
		///<summary>Tech Room UPS Input Voltage</summary>
		public NumericSensorEntity TechRoomUpsInputVoltage => new(_haContext, "sensor.tech_room_ups_input_voltage");
		///<summary>Tech Room UPS Output Load</summary>
		public NumericSensorEntity TechRoomUpsOutputLoad => new(_haContext, "sensor.tech_room_ups_output_load");
		///<summary>Tech Room UPS Output Voltage</summary>
		public NumericSensorEntity TechRoomUpsOutputVoltage => new(_haContext, "sensor.tech_room_ups_output_voltage");
		///<summary>Tech Room Water Leak Sensor battery</summary>
		public NumericSensorEntity TechRoomWaterLeakSensorBattery => new(_haContext, "sensor.tech_room_water_leak_sensor_battery");
		///<summary>Tech Room Water Leak Sensor Linkquality</summary>
		public NumericSensorEntity TechRoomWaterLeakSensorLinkquality => new(_haContext, "sensor.tech_room_water_leak_sensor_linkquality");
		///<summary>Tech Room Water Leak Sensor Temperature</summary>
		public NumericSensorEntity TechRoomWaterLeakSensorTemperature => new(_haContext, "sensor.tech_room_water_leak_sensor_temperature");
		///<summary>Tech Room Water Leak Sensor Voltage</summary>
		public NumericSensorEntity TechRoomWaterLeakSensorVoltage => new(_haContext, "sensor.tech_room_water_leak_sensor_voltage");
		///<summary>Tech Room Weather Sensor Linkquality</summary>
		public NumericSensorEntity TechRoomWeatherLinkquality => new(_haContext, "sensor.tech_room_weather_linkquality");
		///<summary>Tech Room Weather Sensor battery</summary>
		public NumericSensorEntity TechRoomWeatherSensorBattery => new(_haContext, "sensor.tech_room_weather_sensor_battery");
		///<summary>Tech Room Weather Sensor Humidity</summary>
		public NumericSensorEntity TechRoomWeatherSensorHumidity => new(_haContext, "sensor.tech_room_weather_sensor_humidity");
		///<summary>Tech Room Weather Sensor Pressure</summary>
		public NumericSensorEntity TechRoomWeatherSensorPressure => new(_haContext, "sensor.tech_room_weather_sensor_pressure");
		///<summary>Tech Room Weather Sensor Temperature</summary>
		public NumericSensorEntity TechRoomWeatherSensorTemperature => new(_haContext, "sensor.tech_room_weather_sensor_temperature");
		///<summary>Tech Room Weather Sensor Voltage</summary>
		public NumericSensorEntity TechRoomWeatherSensorVoltage => new(_haContext, "sensor.tech_room_weather_sensor_voltage");
		///<summary>Terrace Weather Sensor Battery</summary>
		public NumericSensorEntity TerraceWeatherSensorBattery => new(_haContext, "sensor.terrace_weather_sensor_battery");
		///<summary>Terrace Weather Sensor Humidity</summary>
		public NumericSensorEntity TerraceWeatherSensorHumidity => new(_haContext, "sensor.terrace_weather_sensor_humidity");
		///<summary>Terrace Weather Sensor Linkquality</summary>
		public NumericSensorEntity TerraceWeatherSensorLinkquality => new(_haContext, "sensor.terrace_weather_sensor_linkquality");
		///<summary>Terrace Weather Sensor Pressure</summary>
		public NumericSensorEntity TerraceWeatherSensorPressure => new(_haContext, "sensor.terrace_weather_sensor_pressure");
		///<summary>Terrace Weather Sensor Temperature</summary>
		public NumericSensorEntity TerraceWeatherSensorTemperature => new(_haContext, "sensor.terrace_weather_sensor_temperature");
		///<summary>Terrace Weather Sensor Voltage</summary>
		public NumericSensorEntity TerraceWeatherSensorVoltage => new(_haContext, "sensor.terrace_weather_sensor_voltage");
		///<summary>Roses Watering Time</summary>
		public NumericSensorEntity TrandafiriWateringTime => new(_haContext, "sensor.trandafiri_watering_time");
		///<summary>Tuja Watering Time</summary>
		public NumericSensorEntity TuiaWateringTime => new(_haContext, "sensor.tuia_watering_time");
		///<summary>WinSrv CPU Usage</summary>
		public NumericSensorEntity WinsrvCpuUsage => new(_haContext, "sensor.winsrv_cpu_usage");
		///<summary>WinSrv Memory Available</summary>
		public NumericSensorEntity WinsrvMemoryAvailable => new(_haContext, "sensor.winsrv_memory_available");
		///<summary>WinSrv Memory Total</summary>
		public NumericSensorEntity WinsrvMemoryTotal => new(_haContext, "sensor.winsrv_memory_total");
		///<summary>WinSrv Memory Usage</summary>
		public NumericSensorEntity WinsrvMemoryUsage => new(_haContext, "sensor.winsrv_memory_usage");
		///<summary>WinSrv Memory Used</summary>
		public NumericSensorEntity WinsrvMemoryUsed => new(_haContext, "sensor.winsrv_memory_used");
		///<summary>WINSRV Network #0 - BPS Received</summary>
		public NumericSensorEntity WinsrvNetwork0BpsReceived => new(_haContext, "sensor.winsrv_network_0_bps_received");
		///<summary>WINSRV Network #0 - BPS Sent</summary>
		public NumericSensorEntity WinsrvNetwork0BpsSent => new(_haContext, "sensor.winsrv_network_0_bps_sent");
		///<summary>WINSRV Network #0 - Bytes Received</summary>
		public NumericSensorEntity WinsrvNetwork0BytesReceived => new(_haContext, "sensor.winsrv_network_0_bytes_received");
		///<summary>WINSRV Network #0 - Bytes Sent</summary>
		public NumericSensorEntity WinsrvNetwork0BytesSent => new(_haContext, "sensor.winsrv_network_0_bytes_sent");
		///<summary>WINSRV Network #0 - Speed</summary>
		public NumericSensorEntity WinsrvNetwork0Speed => new(_haContext, "sensor.winsrv_network_0_speed");
		///<summary>WINSRV Storage C - Available Free Space</summary>
		public NumericSensorEntity WinsrvStorageCAvailableFreeSpace => new(_haContext, "sensor.winsrv_storage_c_available_free_space");
		///<summary>WINSRV Storage C - Total Free Space</summary>
		public NumericSensorEntity WinsrvStorageCTotalFreeSpace => new(_haContext, "sensor.winsrv_storage_c_total_free_space");
		///<summary>WINSRV Storage C - Total Storage</summary>
		public NumericSensorEntity WinsrvStorageCTotalStorage => new(_haContext, "sensor.winsrv_storage_c_total_storage");
		///<summary>WINSRV Storage C - Usage</summary>
		public NumericSensorEntity WinsrvStorageCUsage => new(_haContext, "sensor.winsrv_storage_c_usage");
		///<summary>WINSRV Storage C - Used Space</summary>
		public NumericSensorEntity WinsrvStorageCUsedSpace => new(_haContext, "sensor.winsrv_storage_c_used_space");
		///<summary>WINSRV Storage E - Available Free Space</summary>
		public NumericSensorEntity WinsrvStorageEAvailableFreeSpace => new(_haContext, "sensor.winsrv_storage_e_available_free_space");
		///<summary>WINSRV Storage E - Total Free Space</summary>
		public NumericSensorEntity WinsrvStorageETotalFreeSpace => new(_haContext, "sensor.winsrv_storage_e_total_free_space");
		///<summary>WINSRV Storage E - Total Storage</summary>
		public NumericSensorEntity WinsrvStorageETotalStorage => new(_haContext, "sensor.winsrv_storage_e_total_storage");
		///<summary>WINSRV Storage E - Usage</summary>
		public NumericSensorEntity WinsrvStorageEUsage => new(_haContext, "sensor.winsrv_storage_e_usage");
		///<summary>WINSRV Storage E - Used Space</summary>
		public NumericSensorEntity WinsrvStorageEUsedSpace => new(_haContext, "sensor.winsrv_storage_e_used_space");
		///<summary>WINSRV Storage H - Available Free Space</summary>
		public NumericSensorEntity WinsrvStorageHAvailableFreeSpace => new(_haContext, "sensor.winsrv_storage_h_available_free_space");
		///<summary>WINSRV Storage H - Total Free Space</summary>
		public NumericSensorEntity WinsrvStorageHTotalFreeSpace => new(_haContext, "sensor.winsrv_storage_h_total_free_space");
		///<summary>WINSRV Storage H - Total Storage</summary>
		public NumericSensorEntity WinsrvStorageHTotalStorage => new(_haContext, "sensor.winsrv_storage_h_total_storage");
		///<summary>WINSRV Storage H - Usage</summary>
		public NumericSensorEntity WinsrvStorageHUsage => new(_haContext, "sensor.winsrv_storage_h_usage");
		///<summary>WINSRV Storage H - Used Space</summary>
		public NumericSensorEntity WinsrvStorageHUsedSpace => new(_haContext, "sensor.winsrv_storage_h_used_space");
		///<summary>WINSRV System Idle Time</summary>
		public NumericSensorEntity WinsrvSystemIdleTime => new(_haContext, "sensor.winsrv_system_idle_time");
		///<summary>Raspberries Watering Time</summary>
		public NumericSensorEntity ZmeuraWateringTime => new(_haContext, "sensor.zmeura_watering_time");
		///<summary>Agriculture Watering Next Cycle</summary>
		public SensorEntity AgriculturaNextCycle => new(_haContext, "sensor.agricultura_next_cycle");
		///<summary>Bathroom Water Leak Sensor power outage count</summary>
		public SensorEntity BathroomWaterLeakSensorPowerOutageCount => new(_haContext, "sensor.bathroom_water_leak_sensor_power_outage_count");
		///<summary>Bedroom Bed Nico Vibration Sensor action</summary>
		public SensorEntity BedroomBedNicoVibrationSensorAction => new(_haContext, "sensor.bedroom_bed_nico_vibration_sensor_action");
		///<summary>Bedroom Bed Nico Vibration Sensor sensitivity</summary>
		public SensorEntity BedroomBedNicoVibrationSensorSensitivity => new(_haContext, "sensor.bedroom_bed_nico_vibration_sensor_sensitivity");
		///<summary>Bedroom Bed Nico Vibration Sensor strength</summary>
		public SensorEntity BedroomBedNicoVibrationSensorStrength => new(_haContext, "sensor.bedroom_bed_nico_vibration_sensor_strength");
		///<summary>Bedroom Bed Razvan Vibration Sensor action</summary>
		public SensorEntity BedroomBedRazvanVibrationSensorAction => new(_haContext, "sensor.bedroom_bed_razvan_vibration_sensor_action");
		///<summary>Bedroom Bed Razvan Vibration Sensor sensitivity</summary>
		public SensorEntity BedroomBedRazvanVibrationSensorSensitivity => new(_haContext, "sensor.bedroom_bed_razvan_vibration_sensor_sensitivity");
		///<summary>Bedroom Bed Razvan Vibration Sensor strength</summary>
		public SensorEntity BedroomBedRazvanVibrationSensorStrength => new(_haContext, "sensor.bedroom_bed_razvan_vibration_sensor_strength");
		///<summary>Bedroom Dimmer Action</summary>
		public SensorEntity BedroomDimmerAction => new(_haContext, "sensor.bedroom_dimmer_action");
		///<summary>Bedroom Dimmer update state</summary>
		public SensorEntity BedroomDimmerUpdateState => new(_haContext, "sensor.bedroom_dimmer_update_state");
		///<summary>Bedroom Outlet power on behavior</summary>
		public SensorEntity BedroomOutletPowerOnBehavior => new(_haContext, "sensor.bedroom_outlet_power_on_behavior");
		///<summary>Bedroom Outlet update state</summary>
		public SensorEntity BedroomOutletUpdateState => new(_haContext, "sensor.bedroom_outlet_update_state");
		///<summary>BLE Beacon 0xc0eaa0c52882</summary>
		public SensorEntity BleBeaconC0eaa0c52882 => new(_haContext, "sensor.ble_beacon_c0eaa0c52882");
		///<summary>Child Room Bed Vibration Sensor action</summary>
		public SensorEntity ChildRoomBedVibrationSensorAction => new(_haContext, "sensor.child_room_bed_vibration_sensor_action");
		///<summary>Child Room Bed Vibration Sensor sensitivity</summary>
		public SensorEntity ChildRoomBedVibrationSensorSensitivity => new(_haContext, "sensor.child_room_bed_vibration_sensor_sensitivity");
		///<summary>Child Room Bed Vibration Sensor strength</summary>
		public SensorEntity ChildRoomBedVibrationSensorStrength => new(_haContext, "sensor.child_room_bed_vibration_sensor_strength");
		///<summary>Child Room Chair Vibration Sensor action</summary>
		public SensorEntity ChildRoomChairVibrationSensorAction => new(_haContext, "sensor.child_room_chair_vibration_sensor_action");
		///<summary>Child Room Chair Vibration Sensor sensitivity</summary>
		public SensorEntity ChildRoomChairVibrationSensorSensitivity => new(_haContext, "sensor.child_room_chair_vibration_sensor_sensitivity");
		///<summary>Child Room Chair Vibration Sensor strength</summary>
		public SensorEntity ChildRoomChairVibrationSensorStrength => new(_haContext, "sensor.child_room_chair_vibration_sensor_strength");
		///<summary>Trees Watering Next Cycle</summary>
		public SensorEntity CopaciNextCycle => new(_haContext, "sensor.copaci_next_cycle");
		///<summary>Statistics Device Trackers Total</summary>
		public SensorEntity DeviceTrackersTotal2 => new(_haContext, "sensor.device_trackers_total_2");
		///<summary>Flowers Watering Next Cycle</summary>
		public SensorEntity FloriNextCycle => new(_haContext, "sensor.flori_next_cycle");
		///<summary>Garage Dry Garbage</summary>
		public SensorEntity GarageDryGarbage => new(_haContext, "sensor.garage_dry_garbage");
		///<summary>Garage Glass Garbage</summary>
		public SensorEntity GarageGlassGarbage => new(_haContext, "sensor.garage_glass_garbage");
		///<summary>Garage Wet Garbage</summary>
		public SensorEntity GarageWetGarbage => new(_haContext, "sensor.garage_wet_garbage");
		///<summary>Gazebo Dimmer action</summary>
		public SensorEntity GazeboDimmerAction => new(_haContext, "sensor.gazebo_dimmer_action");
		///<summary>Gazebo Dimmer update state</summary>
		public SensorEntity GazeboDimmerUpdateState => new(_haContext, "sensor.gazebo_dimmer_update_state");
		///<summary>Gazebo Outlet power on behavior</summary>
		public SensorEntity GazeboOutletPowerOnBehavior => new(_haContext, "sensor.gazebo_outlet_power_on_behavior");
		///<summary>Gazebo Outlet update state</summary>
		public SensorEntity GazeboOutletUpdateState => new(_haContext, "sensor.gazebo_outlet_update_state");
		///<summary>Lawn Watering Next Cycle</summary>
		public SensorEntity GazonMareNextCycle => new(_haContext, "sensor.gazon_mare_next_cycle");
		///<summary>Small Lawn Watering Next Cycle</summary>
		public SensorEntity GazonMicNextCycle => new(_haContext, "sensor.gazon_mic_next_cycle");
		///<summary>Current Version</summary>
		public SensorEntity HaCurrentVersion => new(_haContext, "sensor.ha_current_version");
		///<summary>Home Assistant Versions</summary>
		public SensorEntity HaVersions => new(_haContext, "sensor.ha_versions");
		///<summary>Kitchen Button action</summary>
		public SensorEntity KitchenButtonAction => new(_haContext, "sensor.kitchen_button_action");
		///<summary>Kitchen Button update state</summary>
		public SensorEntity KitchenButtonUpdateState => new(_haContext, "sensor.kitchen_button_update_state");
		///<summary>Kitchen Coffee Maker Operation State</summary>
		public SensorEntity KitchenCoffeeMakerOperationState => new(_haContext, "sensor.kitchen_coffee_maker_operation_state");
		///<summary>Kitchen Coffee Maker Remaining Program Time</summary>
		public SensorEntity KitchenCoffeeMakerRemainingProgramTime => new(_haContext, "sensor.kitchen_coffee_maker_remaining_program_time");
		///<summary>Kitchen Dimmer action</summary>
		public SensorEntity KitchenDimmerAction => new(_haContext, "sensor.kitchen_dimmer_action");
		///<summary>Kitchen Dimmer update state</summary>
		public SensorEntity KitchenDimmerUpdateState => new(_haContext, "sensor.kitchen_dimmer_update_state");
		///<summary>Kitchen Fridge</summary>
		public SensorEntity KitchenFridge => new(_haContext, "sensor.kitchen_fridge");
		///<summary>Kitchen Heat Detector Reliability</summary>
		public SensorEntity KitchenHeatDetectorReliability => new(_haContext, "sensor.kitchen_heat_detector_reliability");
		///<summary>Kitchen Outlet Right power on behavior</summary>
		public SensorEntity KitchenOutletRightPowerOnBehavior => new(_haContext, "sensor.kitchen_outlet_right_power_on_behavior");
		///<summary>Kitchen Outlet Right update state</summary>
		public SensorEntity KitchenOutletRightUpdateState => new(_haContext, "sensor.kitchen_outlet_right_update_state");
		///<summary>Kitchen Smoke Detector Reliability</summary>
		public SensorEntity KitchenSmokeDetectorReliability => new(_haContext, "sensor.kitchen_smoke_detector_reliability");
		///<summary>Kitchen Smoke Detector Update State</summary>
		public SensorEntity KitchenSmokeDetectorUpdateState => new(_haContext, "sensor.kitchen_smoke_detector_update_state");
		///<summary>Kitchen Water Leak Sensor Power Outage Count</summary>
		public SensorEntity KitchenWaterLeakSensorPowerOutageCount => new(_haContext, "sensor.kitchen_water_leak_sensor_power_outage_count");
		///<summary>Living Room Tablet Battery State</summary>
		public SensorEntity KlivingRoomTabletBatteryState => new(_haContext, "sensor.kliving_room_tablet_battery_state");
		///<summary>Living Room Tablet Battery Health</summary>
		public SensorEntity LivingRoomTabletBatteryHealth => new(_haContext, "sensor.living_room_tablet_battery_health");
		///<summary>Living Room Tablet Charger Type</summary>
		public SensorEntity LivingRoomTabletChargerType => new(_haContext, "sensor.living_room_tablet_charger_type");
		///<summary>Livi g Room Vacuum DND End</summary>
		public SensorEntity LivingRoomVacuumDndEnd => new(_haContext, "sensor.living_room_vacuum_dnd_end");
		///<summary>Living Room Vacuum DND Start</summary>
		public SensorEntity LivingRoomVacuumDndStart => new(_haContext, "sensor.living_room_vacuum_dnd_start");
		///<summary>Living Room Vacuum Last Clean End</summary>
		public SensorEntity LivingRoomVacuumLastCleanEnd => new(_haContext, "sensor.living_room_vacuum_last_clean_end");
		///<summary>Living Room Vacuum Last Clean Start</summary>
		public SensorEntity LivingRoomVacuumLastCleanStart => new(_haContext, "sensor.living_room_vacuum_last_clean_start");
		///<summary>Serviciu - Adresă locală</summary>
		public SensorEntity LocalIp => new(_haContext, "sensor.local_ip");
		///<summary>Moon</summary>
		public SensorEntity Moon => new(_haContext, "sensor.moon");
		///<summary>nico_phone App Importance</summary>
		public SensorEntity NicoPhoneAppImportance => new(_haContext, "sensor.nico_phone_app_importance");
		///<summary>nico_phone App Standby Bucket</summary>
		public SensorEntity NicoPhoneAppStandbyBucket => new(_haContext, "sensor.nico_phone_app_standby_bucket");
		///<summary>Nico Phone Audio Mode</summary>
		public SensorEntity NicoPhoneAudioMode => new(_haContext, "sensor.nico_phone_audio_mode");
		///<summary>Nico Phone Battery Health</summary>
		public SensorEntity NicoPhoneBatteryHealth => new(_haContext, "sensor.nico_phone_battery_health");
		///<summary>nico_phone Battery State</summary>
		public SensorEntity NicoPhoneBatteryState => new(_haContext, "sensor.nico_phone_battery_state");
		///<summary>nico_phone BLE Transmitter</summary>
		public SensorEntity NicoPhoneBleTransmitter => new(_haContext, "sensor.nico_phone_ble_transmitter");
		///<summary>Nico Phone Charger Type</summary>
		public SensorEntity NicoPhoneChargerType => new(_haContext, "sensor.nico_phone_charger_type");
		///<summary>nico_phone Current Time Zone</summary>
		public SensorEntity NicoPhoneCurrentTimeZone => new(_haContext, "sensor.nico_phone_current_time_zone");
		///<summary>nico_phone Current Version</summary>
		public SensorEntity NicoPhoneCurrentVersion => new(_haContext, "sensor.nico_phone_current_version");
		///<summary>nico_phone Do Not Disturb Sensor</summary>
		public SensorEntity NicoPhoneDoNotDisturbSensor => new(_haContext, "sensor.nico_phone_do_not_disturb_sensor");
		///<summary>Nico Phone Geocoded Location</summary>
		public SensorEntity NicoPhoneGeocodedLocation => new(_haContext, "sensor.nico_phone_geocoded_location");
		///<summary>nico_phone Last Reboot</summary>
		public SensorEntity NicoPhoneLastReboot => new(_haContext, "sensor.nico_phone_last_reboot");
		///<summary>nico_phone Last Update Trigger</summary>
		public SensorEntity NicoPhoneLastUpdateTrigger => new(_haContext, "sensor.nico_phone_last_update_trigger");
		///<summary>nico_phone Network Type</summary>
		public SensorEntity NicoPhoneNetworkType => new(_haContext, "sensor.nico_phone_network_type");
		///<summary>Nico Phone Next Alarm</summary>
		public SensorEntity NicoPhoneNextAlarm => new(_haContext, "sensor.nico_phone_next_alarm");
		///<summary>nico_phone Proximity Sensor</summary>
		public SensorEntity NicoPhoneProximitySensor => new(_haContext, "sensor.nico_phone_proximity_sensor");
		///<summary>nico_phone Public IP Address</summary>
		public SensorEntity NicoPhonePublicIpAddress => new(_haContext, "sensor.nico_phone_public_ip_address");
		///<summary>Nico Phone Ringer Mode</summary>
		public SensorEntity NicoPhoneRingerMode => new(_haContext, "sensor.nico_phone_ringer_mode");
		///<summary>nico_phone Volume Level Accessibility</summary>
		public SensorEntity NicoPhoneVolumeLevelAccessibility => new(_haContext, "sensor.nico_phone_volume_level_accessibility");
		///<summary>nico_phone Volume Level Alarm</summary>
		public SensorEntity NicoPhoneVolumeLevelAlarm => new(_haContext, "sensor.nico_phone_volume_level_alarm");
		///<summary>nico_phone Volume Level Call</summary>
		public SensorEntity NicoPhoneVolumeLevelCall => new(_haContext, "sensor.nico_phone_volume_level_call");
		///<summary>nico_phone Volume Level DTMF</summary>
		public SensorEntity NicoPhoneVolumeLevelDtmf => new(_haContext, "sensor.nico_phone_volume_level_dtmf");
		///<summary>nico_phone Volume Level Music</summary>
		public SensorEntity NicoPhoneVolumeLevelMusic => new(_haContext, "sensor.nico_phone_volume_level_music");
		///<summary>nico_phone Volume Level Notification</summary>
		public SensorEntity NicoPhoneVolumeLevelNotification => new(_haContext, "sensor.nico_phone_volume_level_notification");
		///<summary>nico_phone Volume Level Ringer</summary>
		public SensorEntity NicoPhoneVolumeLevelRinger => new(_haContext, "sensor.nico_phone_volume_level_ringer");
		///<summary>nico_phone Volume Level System</summary>
		public SensorEntity NicoPhoneVolumeLevelSystem => new(_haContext, "sensor.nico_phone_volume_level_system");
		///<summary>nico_phone WiFi BSSID</summary>
		public SensorEntity NicoPhoneWifiBssid => new(_haContext, "sensor.nico_phone_wifi_bssid");
		///<summary>nico_phone WiFi Connection</summary>
		public SensorEntity NicoPhoneWifiConnection => new(_haContext, "sensor.nico_phone_wifi_connection");
		///<summary>nico_phone WiFi IP Address</summary>
		public SensorEntity NicoPhoneWifiIpAddress => new(_haContext, "sensor.nico_phone_wifi_ip_address");
		///<summary>Office Chair Vibration Sensor action</summary>
		public SensorEntity OfficeChairVibrationSensorAction => new(_haContext, "sensor.office_chair_vibration_sensor_action");
		///<summary>Office Chair Vibration Sensor strength</summary>
		public SensorEntity OfficeChairVibrationSensorStrength => new(_haContext, "sensor.office_chair_vibration_sensor_strength");
		///<summary>Office Dimmer action</summary>
		public SensorEntity OfficeDimmerAction => new(_haContext, "sensor.office_dimmer_action");
		///<summary>Office PC Network IP v4</summary>
		public SensorEntity OfficePcNetworkIpv4 => new(_haContext, "sensor.office_pc_network_ipv4");
		///<summary>Office PC Network IP v6</summary>
		public SensorEntity OfficePcNetworkIpv6 => new(_haContext, "sensor.office_pc_network_ipv6");
		///<summary>Office PC Screen Display 1 Height</summary>
		public SensorEntity OfficePcScreenDisplay1Height => new(_haContext, "sensor.office_pc_screen_display1_height");
		///<summary>Office PC Screen Display 1 Width</summary>
		public SensorEntity OfficePcScreenDisplay1Width => new(_haContext, "sensor.office_pc_screen_display1_width");
		///<summary>Office PC Screen Display 2 Height</summary>
		public SensorEntity OfficePcScreenDisplay2Height => new(_haContext, "sensor.office_pc_screen_display2_height");
		///<summary>Office PC Screen Display 2 Width</summary>
		public SensorEntity OfficePcScreenDisplay2Width => new(_haContext, "sensor.office_pc_screen_display2_width");
		///<summary>Office PC Storage C Format</summary>
		public SensorEntity OfficePcStorageCFormat => new(_haContext, "sensor.office_pc_storage_c_format");
		///<summary>Office PC Storage C label</summary>
		public SensorEntity OfficePcStorageCLabel => new(_haContext, "sensor.office_pc_storage_c_label");
		///<summary>Office PC Storage D Format</summary>
		public SensorEntity OfficePcStorageDFormat => new(_haContext, "sensor.office_pc_storage_d_format");
		///<summary>Office PC Storage D Label</summary>
		public SensorEntity OfficePcStorageDLabel => new(_haContext, "sensor.office_pc_storage_d_label");
		///<summary>Office PC Storage E Format</summary>
		public SensorEntity OfficePcStorageEFormat => new(_haContext, "sensor.office_pc_storage_e_format");
		///<summary>Office PC Storage E Label</summary>
		public SensorEntity OfficePcStorageELabel => new(_haContext, "sensor.office_pc_storage_e_label");
		///<summary>Office PC Storage F Format</summary>
		public SensorEntity OfficePcStorageFFormat => new(_haContext, "sensor.office_pc_storage_f_format");
		///<summary>Office PC Storage E Label</summary>
		public SensorEntity OfficePcStorageFLabel => new(_haContext, "sensor.office_pc_storage_f_label");
		///<summary>Office PC Storage G Format</summary>
		public SensorEntity OfficePcStorageGFormat => new(_haContext, "sensor.office_pc_storage_g_format");
		///<summary>Office PC Storage G Label</summary>
		public SensorEntity OfficePcStorageGLabel => new(_haContext, "sensor.office_pc_storage_g_label");
		///<summary>Office PC Storage H Format</summary>
		public SensorEntity OfficePcStorageHFormat => new(_haContext, "sensor.office_pc_storage_h_format");
		///<summary>Office PC Storage H Label</summary>
		public SensorEntity OfficePcStorageHLabel => new(_haContext, "sensor.office_pc_storage_h_label");
		///<summary>Office PC Time Boot</summary>
		public SensorEntity OfficePcTimeBoot => new(_haContext, "sensor.office_pc_time_boot");
		///<summary>Office PC Time Uptime</summary>
		public SensorEntity OfficePcTimeUptime => new(_haContext, "sensor.office_pc_time_uptime");
		///<summary>Office PC User Name</summary>
		public SensorEntity OfficePcUserName => new(_haContext, "sensor.office_pc_user_name");
		///<summary>Office Printer</summary>
		public SensorEntity OfficePrinter => new(_haContext, "sensor.office_printer");
		///<summary>Office Printer Uptime</summary>
		public SensorEntity OfficePrinterUptime => new(_haContext, "sensor.office_printer_uptime");
		///<summary>Office Switch action</summary>
		public SensorEntity OfficeSwitchAction => new(_haContext, "sensor.office_switch_action");
		///<summary>Lawn Pump Watering Next Cycle</summary>
		public SensorEntity PompaNextCycle => new(_haContext, "sensor.pompa_next_cycle");
		///<summary>rares_phone App Importance</summary>
		public SensorEntity RaresPhoneAppImportance => new(_haContext, "sensor.rares_phone_app_importance");
		///<summary>rares_phone App Standby Bucket</summary>
		public SensorEntity RaresPhoneAppStandbyBucket => new(_haContext, "sensor.rares_phone_app_standby_bucket");
		///<summary>rares_phone Audio Mode</summary>
		public SensorEntity RaresPhoneAudioMode => new(_haContext, "sensor.rares_phone_audio_mode");
		///<summary>Stare baterie</summary>
		public SensorEntity RaresPhoneBatteryHealth => new(_haContext, "sensor.rares_phone_battery_health");
		///<summary>Stare baterie</summary>
		public SensorEntity RaresPhoneBatteryState => new(_haContext, "sensor.rares_phone_battery_state");
		///<summary>Tip încărcător</summary>
		public SensorEntity RaresPhoneChargerType => new(_haContext, "sensor.rares_phone_charger_type");
		///<summary>rares_phone Current Time Zone</summary>
		public SensorEntity RaresPhoneCurrentTimeZone => new(_haContext, "sensor.rares_phone_current_time_zone");
		///<summary>rares_phone Current Version</summary>
		public SensorEntity RaresPhoneCurrentVersion => new(_haContext, "sensor.rares_phone_current_version");
		///<summary>rares_phone Do Not Disturb Sensor</summary>
		public SensorEntity RaresPhoneDoNotDisturbSensor => new(_haContext, "sensor.rares_phone_do_not_disturb_sensor");
		///<summary>rares_phone Geocoded Location</summary>
		public SensorEntity RaresPhoneGeocodedLocation => new(_haContext, "sensor.rares_phone_geocoded_location");
		///<summary>rares_phone Last Reboot</summary>
		public SensorEntity RaresPhoneLastReboot => new(_haContext, "sensor.rares_phone_last_reboot");
		///<summary>rares_phone Last Update Trigger</summary>
		public SensorEntity RaresPhoneLastUpdateTrigger => new(_haContext, "sensor.rares_phone_last_update_trigger");
		///<summary>rares_phone Network Type</summary>
		public SensorEntity RaresPhoneNetworkType => new(_haContext, "sensor.rares_phone_network_type");
		///<summary>rares_phone Next Alarm</summary>
		public SensorEntity RaresPhoneNextAlarm => new(_haContext, "sensor.rares_phone_next_alarm");
		///<summary>rares_phone Proximity Sensor</summary>
		public SensorEntity RaresPhoneProximitySensor => new(_haContext, "sensor.rares_phone_proximity_sensor");
		///<summary>rares_phone Public IP Address</summary>
		public SensorEntity RaresPhonePublicIpAddress => new(_haContext, "sensor.rares_phone_public_ip_address");
		///<summary>rares_phone Ringer Mode</summary>
		public SensorEntity RaresPhoneRingerMode => new(_haContext, "sensor.rares_phone_ringer_mode");
		///<summary>rares_phone Volume Level Accessibility</summary>
		public SensorEntity RaresPhoneVolumeLevelAccessibility => new(_haContext, "sensor.rares_phone_volume_level_accessibility");
		///<summary>rares_phone Volume Level Alarm</summary>
		public SensorEntity RaresPhoneVolumeLevelAlarm => new(_haContext, "sensor.rares_phone_volume_level_alarm");
		///<summary>rares_phone Volume Level Call</summary>
		public SensorEntity RaresPhoneVolumeLevelCall => new(_haContext, "sensor.rares_phone_volume_level_call");
		///<summary>rares_phone Volume Level DTMF</summary>
		public SensorEntity RaresPhoneVolumeLevelDtmf => new(_haContext, "sensor.rares_phone_volume_level_dtmf");
		///<summary>rares_phone Volume Level Music</summary>
		public SensorEntity RaresPhoneVolumeLevelMusic => new(_haContext, "sensor.rares_phone_volume_level_music");
		///<summary>rares_phone Volume Level Notification</summary>
		public SensorEntity RaresPhoneVolumeLevelNotification => new(_haContext, "sensor.rares_phone_volume_level_notification");
		///<summary>rares_phone Volume Level Ringer</summary>
		public SensorEntity RaresPhoneVolumeLevelRinger => new(_haContext, "sensor.rares_phone_volume_level_ringer");
		///<summary>rares_phone Volume Level System</summary>
		public SensorEntity RaresPhoneVolumeLevelSystem => new(_haContext, "sensor.rares_phone_volume_level_system");
		///<summary>rares_phone WiFi BSSID</summary>
		public SensorEntity RaresPhoneWifiBssid => new(_haContext, "sensor.rares_phone_wifi_bssid");
		///<summary>rares_phone WiFi Connection</summary>
		public SensorEntity RaresPhoneWifiConnection => new(_haContext, "sensor.rares_phone_wifi_connection");
		///<summary>rares_phone WiFi IP Address</summary>
		public SensorEntity RaresPhoneWifiIpAddress => new(_haContext, "sensor.rares_phone_wifi_ip_address");
		///<summary>razvan phone App Importance</summary>
		public SensorEntity RazvanPhoneAppImportance => new(_haContext, "sensor.razvan_phone_app_importance");
		///<summary>razvan phone App Standby Bucket</summary>
		public SensorEntity RazvanPhoneAppStandbyBucket => new(_haContext, "sensor.razvan_phone_app_standby_bucket");
		///<summary>razvan phone Audio Mode</summary>
		public SensorEntity RazvanPhoneAudioMode => new(_haContext, "sensor.razvan_phone_audio_mode");
		///<summary>razvan phone Battery Health</summary>
		public SensorEntity RazvanPhoneBatteryHealth => new(_haContext, "sensor.razvan_phone_battery_health");
		///<summary>razvan phone Battery State</summary>
		public SensorEntity RazvanPhoneBatteryState => new(_haContext, "sensor.razvan_phone_battery_state");
		///<summary>razvan phone BLE Transmitter</summary>
		public SensorEntity RazvanPhoneBleTransmitter => new(_haContext, "sensor.razvan_phone_ble_transmitter");
		///<summary>razvan phone Charger Type</summary>
		public SensorEntity RazvanPhoneChargerType => new(_haContext, "sensor.razvan_phone_charger_type");
		///<summary>razvan phone Current Time Zone</summary>
		public SensorEntity RazvanPhoneCurrentTimeZone => new(_haContext, "sensor.razvan_phone_current_time_zone");
		///<summary>razvan phone Current Version</summary>
		public SensorEntity RazvanPhoneCurrentVersion => new(_haContext, "sensor.razvan_phone_current_version");
		///<summary>razvan phone Detected Activity</summary>
		public SensorEntity RazvanPhoneDetectedActivity => new(_haContext, "sensor.razvan_phone_detected_activity");
		///<summary>razvan phone Do Not Disturb Sensor</summary>
		public SensorEntity RazvanPhoneDoNotDisturbSensor => new(_haContext, "sensor.razvan_phone_do_not_disturb_sensor");
		///<summary>razvan phone Geocoded Location</summary>
		public SensorEntity RazvanPhoneGeocodedLocation => new(_haContext, "sensor.razvan_phone_geocoded_location");
		///<summary>razvan phone Last Reboot</summary>
		public SensorEntity RazvanPhoneLastReboot => new(_haContext, "sensor.razvan_phone_last_reboot");
		///<summary>razvan phone Last Update Trigger</summary>
		public SensorEntity RazvanPhoneLastUpdateTrigger => new(_haContext, "sensor.razvan_phone_last_update_trigger");
		///<summary>razvan phone Network Type</summary>
		public SensorEntity RazvanPhoneNetworkType => new(_haContext, "sensor.razvan_phone_network_type");
		///<summary>razvan phone Next Alarm</summary>
		public SensorEntity RazvanPhoneNextAlarm => new(_haContext, "sensor.razvan_phone_next_alarm");
		///<summary>razvan phone Proximity Sensor</summary>
		public SensorEntity RazvanPhoneProximitySensor => new(_haContext, "sensor.razvan_phone_proximity_sensor");
		///<summary>razvan phone Public IP Address</summary>
		public SensorEntity RazvanPhonePublicIpAddress => new(_haContext, "sensor.razvan_phone_public_ip_address");
		///<summary>razvan phone Ringer Mode</summary>
		public SensorEntity RazvanPhoneRingerMode => new(_haContext, "sensor.razvan_phone_ringer_mode");
		///<summary>razvan phone Volume Level Accessibility</summary>
		public SensorEntity RazvanPhoneVolumeLevelAccessibility => new(_haContext, "sensor.razvan_phone_volume_level_accessibility");
		///<summary>razvan phone Volume Level Alarm</summary>
		public SensorEntity RazvanPhoneVolumeLevelAlarm => new(_haContext, "sensor.razvan_phone_volume_level_alarm");
		///<summary>razvan phone Volume Level Call</summary>
		public SensorEntity RazvanPhoneVolumeLevelCall => new(_haContext, "sensor.razvan_phone_volume_level_call");
		///<summary>razvan phone Volume Level DTMF</summary>
		public SensorEntity RazvanPhoneVolumeLevelDtmf => new(_haContext, "sensor.razvan_phone_volume_level_dtmf");
		///<summary>razvan phone Volume Level Music</summary>
		public SensorEntity RazvanPhoneVolumeLevelMusic => new(_haContext, "sensor.razvan_phone_volume_level_music");
		///<summary>razvan phone Volume Level Notification</summary>
		public SensorEntity RazvanPhoneVolumeLevelNotification => new(_haContext, "sensor.razvan_phone_volume_level_notification");
		///<summary>razvan phone Volume Level Ringer</summary>
		public SensorEntity RazvanPhoneVolumeLevelRinger => new(_haContext, "sensor.razvan_phone_volume_level_ringer");
		///<summary>razvan phone Volume Level System</summary>
		public SensorEntity RazvanPhoneVolumeLevelSystem => new(_haContext, "sensor.razvan_phone_volume_level_system");
		///<summary>razvan phone WiFi BSSID</summary>
		public SensorEntity RazvanPhoneWifiBssid => new(_haContext, "sensor.razvan_phone_wifi_bssid");
		///<summary>razvan phone WiFi Connection</summary>
		public SensorEntity RazvanPhoneWifiConnection => new(_haContext, "sensor.razvan_phone_wifi_connection");
		///<summary>razvan phone WiFi IP Address</summary>
		public SensorEntity RazvanPhoneWifiIpAddress => new(_haContext, "sensor.razvan_phone_wifi_ip_address");
		///<summary>Season</summary>
		public SensorEntity Season => new(_haContext, "sensor.season");
		///<summary>rumbu13.go.ro</summary>
		public SensorEntity ServiceDnsExternalIp => new(_haContext, "sensor.service_dns_external_ip");
		///<summary>File editor: Newest Version</summary>
		public SensorEntity ServiceFileEditorNewestVersion => new(_haContext, "sensor.service_file_editor_newest_version");
		///<summary>File editor: Version</summary>
		public SensorEntity ServiceFileEditorVersion => new(_haContext, "sensor.service_file_editor_version");
		///<summary>Home Assistant Operating System: Newest Version</summary>
		public SensorEntity ServiceHaOsNewestVersion => new(_haContext, "sensor.service_ha_os_newest_version");
		///<summary>Home Assistant Operating System: Version</summary>
		public SensorEntity ServiceHaOsVersion => new(_haContext, "sensor.service_ha_os_version");
		///<summary>MariaDB: Newest Version</summary>
		public SensorEntity ServiceMariadbNewestVersion => new(_haContext, "sensor.service_mariadb_newest_version");
		///<summary>MariaDB: Version</summary>
		public SensorEntity ServiceMariadbVersion => new(_haContext, "sensor.service_mariadb_version");
		///<summary>Mosquitto broker: Newest Version</summary>
		public SensorEntity ServiceMosquittoNewestVersion => new(_haContext, "sensor.service_mosquitto_newest_version");
		///<summary>Mosquitto broker: Version</summary>
		public SensorEntity ServiceMosquittoVersion => new(_haContext, "sensor.service_mosquitto_version");
		///<summary>NetDaemon V3 - beta: Newest Version</summary>
		public SensorEntity ServiceNetdaemonNewestVersion => new(_haContext, "sensor.service_netdaemon_newest_version");
		///<summary>NetDaemon V3 - beta: Version</summary>
		public SensorEntity ServiceNetdaemonVersion => new(_haContext, "sensor.service_netdaemon_version");
		///<summary>RPC Shutdown: Newest Version</summary>
		public SensorEntity ServiceRpcShutdownNewestVersion => new(_haContext, "sensor.service_rpc_shutdown_newest_version");
		///<summary>RPC Shutdown: Version</summary>
		public SensorEntity ServiceRpcShutdownVersion => new(_haContext, "sensor.service_rpc_shutdown_version");
		///<summary>Samba share: Newest Version</summary>
		public SensorEntity ServiceSambaNewestVersion => new(_haContext, "sensor.service_samba_newest_version");
		///<summary>Samba share: Version</summary>
		public SensorEntity ServiceSambaVersion => new(_haContext, "sensor.service_samba_version");
		///<summary>Terminal & SSH: Newest Version</summary>
		public SensorEntity ServiceTerminalSshNewestVersion => new(_haContext, "sensor.service_terminal_ssh_newest_version");
		///<summary>Terminal & SSH: Version</summary>
		public SensorEntity ServiceTerminalSshVersion => new(_haContext, "sensor.service_terminal_ssh_version");
		///<summary>Shed Dryer</summary>
		public SensorEntity ShedDryer => new(_haContext, "sensor.shed_dryer");
		///<summary>Shed Dryer Countdown Time</summary>
		public SensorEntity ShedDryerCountdownTime => new(_haContext, "sensor.shed_dryer_countdown_time");
		///<summary>Shed Dryer Current Course</summary>
		public SensorEntity ShedDryerCurrentCourse => new(_haContext, "sensor.shed_dryer_current_course");
		///<summary>Shed Dryer Dry Level</summary>
		public SensorEntity ShedDryerDryLevel => new(_haContext, "sensor.shed_dryer_dry_level");
		///<summary>Shed Dryer Error Message</summary>
		public SensorEntity ShedDryerErrorMessage => new(_haContext, "sensor.shed_dryer_error_message");
		///<summary>Shed Dryer Initial Time</summary>
		public SensorEntity ShedDryerInitialTime => new(_haContext, "sensor.shed_dryer_initial_time");
		///<summary>Shed Dryer Process State</summary>
		public SensorEntity ShedDryerProcessState => new(_haContext, "sensor.shed_dryer_process_state");
		///<summary>Shed Dryer Remaining Time</summary>
		public SensorEntity ShedDryerRemainingTime => new(_haContext, "sensor.shed_dryer_remaining_time");
		///<summary>Shed Dryer Run State</summary>
		public SensorEntity ShedDryerRunState => new(_haContext, "sensor.shed_dryer_run_state");
		///<summary>Shed Outlet power on behavior</summary>
		public SensorEntity ShedOutletPowerOnBehavior => new(_haContext, "sensor.shed_outlet_power_on_behavior");
		///<summary>Shed Outlet update state</summary>
		public SensorEntity ShedOutletUpdateState => new(_haContext, "sensor.shed_outlet_update_state");
		///<summary>Shower Water Leak Sensor Power Outage Count</summary>
		public SensorEntity ShowerWaterLeakSensorPowerOutageCount => new(_haContext, "sensor.shower_water_leak_sensor_power_outage_count");
		///<summary>Smart Tag Beacon 1</summary>
		public SensorEntity SmartTagBeacon1 => new(_haContext, "sensor.smart_tag_beacon_1");
		///<summary>Smart Tag Beacon 2</summary>
		public SensorEntity SmartTagBeacon2 => new(_haContext, "sensor.smart_tag_beacon_2");
		///<summary>Smart Tag Beacon 3</summary>
		public SensorEntity SmartTagBeacon3 => new(_haContext, "sensor.smart_tag_beacon_3");
		///<summary>Smart Tag Beacon 4</summary>
		public SensorEntity SmartTagBeacon4 => new(_haContext, "sensor.smart_tag_beacon_4");
		///<summary>Stairs Vibration Sensor Action</summary>
		public SensorEntity StairsVibrationSensorAction => new(_haContext, "sensor.stairs_vibration_sensor_action");
		///<summary>Stairs Vibration Sensor Sensitivity</summary>
		public SensorEntity StairsVibrationSensorSensitivity => new(_haContext, "sensor.stairs_vibration_sensor_sensitivity");
		///<summary>Stairs Vibration Sensor Strength</summary>
		public SensorEntity StairsVibrationSensorStrength => new(_haContext, "sensor.stairs_vibration_sensor_strength");
		///<summary>Statistics Baterries Charging</summary>
		public SensorEntity StatisticsBaterriesCharging => new(_haContext, "sensor.statistics_baterries_charging");
		///<summary>Statistics Baterries Charging Total</summary>
		public SensorEntity StatisticsBaterriesChargingTotal => new(_haContext, "sensor.statistics_baterries_charging_total");
		///<summary>Statistics Baterries Charging Unavailable</summary>
		public SensorEntity StatisticsBaterriesChargingUnavailable => new(_haContext, "sensor.statistics_baterries_charging_unavailable");
		///<summary>Statistics Baterries Low Detected</summary>
		public SensorEntity StatisticsBaterriesLowDetected => new(_haContext, "sensor.statistics_baterries_low_detected");
		///<summary>Statistics Baterries Low Total</summary>
		public SensorEntity StatisticsBaterriesLowTotal => new(_haContext, "sensor.statistics_baterries_low_total");
		///<summary>Statistics Baterries Low Unavailable</summary>
		public SensorEntity StatisticsBaterriesLowUnavailable => new(_haContext, "sensor.statistics_baterries_low_unavailable");
		///<summary>Statistics Baterries Not Charging</summary>
		public SensorEntity StatisticsBaterriesNotCharging => new(_haContext, "sensor.statistics_baterries_not_charging");
		///<summary>Statistics Baterries Not Low</summary>
		public SensorEntity StatisticsBaterriesNotLow => new(_haContext, "sensor.statistics_baterries_not_low");
		///<summary>Statistics Baterries Total</summary>
		public SensorEntity StatisticsBaterriesTotal => new(_haContext, "sensor.statistics_baterries_total");
		///<summary>Statistics Baterries Unavailable</summary>
		public SensorEntity StatisticsBaterriesUnavailable => new(_haContext, "sensor.statistics_baterries_unavailable");
		///<summary>Statistics Binary Sensors Off</summary>
		public SensorEntity StatisticsBinarySensorsOff => new(_haContext, "sensor.statistics_binary_sensors_off");
		///<summary>Statistics Binary Sensors On</summary>
		public SensorEntity StatisticsBinarySensorsOn => new(_haContext, "sensor.statistics_binary_sensors_on");
		///<summary>Statistics Binary Sensors Total</summary>
		public SensorEntity StatisticsBinarySensorsTotal => new(_haContext, "sensor.statistics_binary_sensors_total");
		///<summary>Statistics Binary Sensors Unavailable</summary>
		public SensorEntity StatisticsBinarySensorsUnavailable => new(_haContext, "sensor.statistics_binary_sensors_unavailable");
		///<summary>Statistics Cameras Total</summary>
		public SensorEntity StatisticsCamerasTotal => new(_haContext, "sensor.statistics_cameras_total");
		///<summary>Statistics Cameras Unavailable</summary>
		public SensorEntity StatisticsCamerasUnavailable => new(_haContext, "sensor.statistics_cameras_unavailable");
		///<summary>Statistics Climates Off</summary>
		public SensorEntity StatisticsClimatesOff => new(_haContext, "sensor.statistics_climates_off");
		///<summary>Statistics Climates On</summary>
		public SensorEntity StatisticsClimatesOn => new(_haContext, "sensor.statistics_climates_on");
		///<summary>Statistics Climates Total</summary>
		public SensorEntity StatisticsClimatesTotal => new(_haContext, "sensor.statistics_climates_total");
		///<summary>Statistics Climates Unavailable</summary>
		public SensorEntity StatisticsClimatesUnavailable => new(_haContext, "sensor.statistics_climates_unavailable");
		///<summary>Statistics Connectivity Connected</summary>
		public SensorEntity StatisticsConnectivityConnected => new(_haContext, "sensor.statistics_connectivity_connected");
		///<summary>Statistics Connectivity Disconnected</summary>
		public SensorEntity StatisticsConnectivityDisconnected => new(_haContext, "sensor.statistics_connectivity_disconnected");
		///<summary>Statistics Connectivity Total</summary>
		public SensorEntity StatisticsConnectivityTotal => new(_haContext, "sensor.statistics_connectivity_total");
		///<summary>Statistics Connectivity Unavailable</summary>
		public SensorEntity StatisticsConnectivityUnavailable => new(_haContext, "sensor.statistics_connectivity_unavailable");
		///<summary>Statistics Device Trackers Away</summary>
		public SensorEntity StatisticsDeviceTrackersAway => new(_haContext, "sensor.statistics_device_trackers_away");
		///<summary>Statistics Device Trackers Home</summary>
		public SensorEntity StatisticsDeviceTrackersHome => new(_haContext, "sensor.statistics_device_trackers_home");
		///<summary>Statistics Device Trackers Unavailable</summary>
		public SensorEntity StatisticsDeviceTrackersUnavailable => new(_haContext, "sensor.statistics_device_trackers_unavailable");
		///<summary>Statistics Doors Closed</summary>
		public SensorEntity StatisticsDoorsClosed => new(_haContext, "sensor.statistics_doors_closed");
		///<summary>Statistics Doors Open</summary>
		public SensorEntity StatisticsDoorsOpen => new(_haContext, "sensor.statistics_doors_open");
		///<summary>Statistics Doors Total</summary>
		public SensorEntity StatisticsDoorsTotal => new(_haContext, "sensor.statistics_doors_total");
		///<summary>Statistics Doors Unavailable</summary>
		public SensorEntity StatisticsDoorsUnavailable => new(_haContext, "sensor.statistics_doors_unavailable");
		///<summary>Statistics Durations Available</summary>
		public SensorEntity StatisticsDurationsAvailable => new(_haContext, "sensor.statistics_durations_available");
		///<summary>Statistics Durations Total</summary>
		public SensorEntity StatisticsDurationsTotal => new(_haContext, "sensor.statistics_durations_total");
		///<summary>Statistics Durations Unavailable</summary>
		public SensorEntity StatisticsDurationsUnavailable => new(_haContext, "sensor.statistics_durations_unavailable");
		///<summary>Statistics Family Away</summary>
		public SensorEntity StatisticsFamilyAway => new(_haContext, "sensor.statistics_family_away");
		///<summary>Statistics Family Home</summary>
		public SensorEntity StatisticsFamilyHome => new(_haContext, "sensor.statistics_family_home");
		///<summary>Statistics Family Total</summary>
		public SensorEntity StatisticsFamilyTotal => new(_haContext, "sensor.statistics_family_total");
		///<summary>Statistics Family Unavailable</summary>
		public SensorEntity StatisticsFamilyUnavailable => new(_haContext, "sensor.statistics_family_unavailable");
		///<summary>Statistics Guests Away</summary>
		public SensorEntity StatisticsGuestsAway => new(_haContext, "sensor.statistics_guests_away");
		///<summary>Statistics Guests Home</summary>
		public SensorEntity StatisticsGuestsHome => new(_haContext, "sensor.statistics_guests_home");
		///<summary>Statistics Guests Total</summary>
		public SensorEntity StatisticsGuestsTotal => new(_haContext, "sensor.statistics_guests_total");
		///<summary>Statistics Guests Unavailable</summary>
		public SensorEntity StatisticsGuestsUnavailable => new(_haContext, "sensor.statistics_guests_unavailable");
		///<summary>Statistics Heats Clear</summary>
		public SensorEntity StatisticsHeatsClear => new(_haContext, "sensor.statistics_heats_clear");
		///<summary>Statistics Heats Detected</summary>
		public SensorEntity StatisticsHeatsDetected => new(_haContext, "sensor.statistics_heats_detected");
		///<summary>Statistics Heats Total</summary>
		public SensorEntity StatisticsHeatsTotal => new(_haContext, "sensor.statistics_heats_total");
		///<summary>Statistics Heats Unavailable</summary>
		public SensorEntity StatisticsHeatsUnavailable => new(_haContext, "sensor.statistics_heats_unavailable");
		///<summary>Statistics Lights Off</summary>
		public SensorEntity StatisticsLightsOff => new(_haContext, "sensor.statistics_lights_off");
		///<summary>Statistics Lights On</summary>
		public SensorEntity StatisticsLightsOn => new(_haContext, "sensor.statistics_lights_on");
		///<summary>Statistics Lights Total</summary>
		public SensorEntity StatisticsLightsTotal => new(_haContext, "sensor.statistics_lights_total");
		///<summary>Statistics Lights Unavailable</summary>
		public SensorEntity StatisticsLightsUnavailable => new(_haContext, "sensor.statistics_lights_unavailable");
		///<summary>Statistics Media Players Idle</summary>
		public SensorEntity StatisticsMediaPlayersIdle => new(_haContext, "sensor.statistics_media_players_idle");
		///<summary>Statistics Media Players Off</summary>
		public SensorEntity StatisticsMediaPlayersOff => new(_haContext, "sensor.statistics_media_players_off");
		///<summary>Statistics Media Players Total</summary>
		public SensorEntity StatisticsMediaPlayersTotal => new(_haContext, "sensor.statistics_media_players_total");
		///<summary>Statistics Media Players Unavailable</summary>
		public SensorEntity StatisticsMediaPlayersUnavailable => new(_haContext, "sensor.statistics_media_players_unavailable");
		///<summary>Statistics Motions Cleared</summary>
		public SensorEntity StatisticsMotionsCleared => new(_haContext, "sensor.statistics_motions_cleared");
		///<summary>Statistics Motions Detected</summary>
		public SensorEntity StatisticsMotionsDetected => new(_haContext, "sensor.statistics_motions_detected");
		///<summary>Statistics Motions Total</summary>
		public SensorEntity StatisticsMotionsTotal => new(_haContext, "sensor.statistics_motions_total");
		///<summary>Statistics Motions Unavailable</summary>
		public SensorEntity StatisticsMotionsUnavailable => new(_haContext, "sensor.statistics_motions_unavailable");
		///<summary>Statistics Movings Cleared</summary>
		public SensorEntity StatisticsMovingsCleared => new(_haContext, "sensor.statistics_movings_cleared");
		///<summary>Statistics Movings Detected</summary>
		public SensorEntity StatisticsMovingsDetected => new(_haContext, "sensor.statistics_movings_detected");
		///<summary>Statistics Movings Total</summary>
		public SensorEntity StatisticsMovingsTotal => new(_haContext, "sensor.statistics_movings_total");
		///<summary>Statistics Movings Unavailable</summary>
		public SensorEntity StatisticsMovingsUnavailable => new(_haContext, "sensor.statistics_movings_unavailable");
		///<summary>Statistics Occupancies Cleared</summary>
		public SensorEntity StatisticsOccupanciesCleared => new(_haContext, "sensor.statistics_occupancies_cleared");
		///<summary>Statistics Occupancies Detected</summary>
		public SensorEntity StatisticsOccupanciesDetected => new(_haContext, "sensor.statistics_occupancies_detected");
		///<summary>Statistics Occupancies Total</summary>
		public SensorEntity StatisticsOccupanciesTotal => new(_haContext, "sensor.statistics_occupancies_total");
		///<summary>Statistics Occupancies Unavailable</summary>
		public SensorEntity StatisticsOccupanciesUnavailable => new(_haContext, "sensor.statistics_occupancies_unavailable");
		///<summary>Statistics Openings Closed</summary>
		public SensorEntity StatisticsOpeningsClosed => new(_haContext, "sensor.statistics_openings_closed");
		///<summary>Statistics Openings Detected</summary>
		public SensorEntity StatisticsOpeningsDetected => new(_haContext, "sensor.statistics_openings_detected");
		///<summary>Statistics Openings Total</summary>
		public SensorEntity StatisticsOpeningsTotal => new(_haContext, "sensor.statistics_openings_total");
		///<summary>Statistics Openings Unavailable</summary>
		public SensorEntity StatisticsOpeninsUnavailable => new(_haContext, "sensor.statistics_openins_unavailable");
		///<summary>Statistics Persons Away</summary>
		public SensorEntity StatisticsPersonsAway => new(_haContext, "sensor.statistics_persons_away");
		///<summary>Statistics Persons Home</summary>
		public SensorEntity StatisticsPersonsHome => new(_haContext, "sensor.statistics_persons_home");
		///<summary>Statistics Persons Total</summary>
		public SensorEntity StatisticsPersonsTotal => new(_haContext, "sensor.statistics_persons_total");
		///<summary>Statistics Persons Unavailable</summary>
		public SensorEntity StatisticsPersonsUnavailable => new(_haContext, "sensor.statistics_persons_unavailable");
		///<summary>Statistics Plugs Plugged In</summary>
		public SensorEntity StatisticsPlugsPluggedIn => new(_haContext, "sensor.statistics_plugs_plugged_in");
		///<summary>Statistics Plugs Total</summary>
		public SensorEntity StatisticsPlugsTotal => new(_haContext, "sensor.statistics_plugs_total");
		///<summary>Statistics Plugs Unavailable</summary>
		public SensorEntity StatisticsPlugsUnavailable => new(_haContext, "sensor.statistics_plugs_unavailable");
		///<summary>Statistics Plugs Unplugged</summary>
		public SensorEntity StatisticsPlugsUnplugged => new(_haContext, "sensor.statistics_plugs_unplugged");
		///<summary>Statistics Problems Detected</summary>
		public SensorEntity StatisticsProblemsDetected => new(_haContext, "sensor.statistics_problems_detected");
		///<summary>Statistics Problems Solved</summary>
		public SensorEntity StatisticsProblemsSolved => new(_haContext, "sensor.statistics_problems_solved");
		///<summary>Statistics Problems Total</summary>
		public SensorEntity StatisticsProblemsTotal => new(_haContext, "sensor.statistics_problems_total");
		///<summary>Statistics Problems Unavailable</summary>
		public SensorEntity StatisticsProblemsUnavailable => new(_haContext, "sensor.statistics_problems_unavailable");
		///<summary>Statistics Proximities Away</summary>
		public SensorEntity StatisticsProximitiesAway => new(_haContext, "sensor.statistics_proximities_away");
		///<summary>Statistics Proximities Home</summary>
		public SensorEntity StatisticsProximitiesHome => new(_haContext, "sensor.statistics_proximities_home");
		///<summary>Statistics Proximities Total</summary>
		public SensorEntity StatisticsProximitiesTotal => new(_haContext, "sensor.statistics_proximities_total");
		///<summary>Statistics Proximities Unavailable</summary>
		public SensorEntity StatisticsProximitiesUnavailable => new(_haContext, "sensor.statistics_proximities_unavailable");
		///<summary>Statistics Runnings Off</summary>
		public SensorEntity StatisticsRunningsOff => new(_haContext, "sensor.statistics_runnings_off");
		///<summary>Statistics Runnings On</summary>
		public SensorEntity StatisticsRunningsOn => new(_haContext, "sensor.statistics_runnings_on");
		///<summary>Statistics Runnings Total</summary>
		public SensorEntity StatisticsRunningsTotal => new(_haContext, "sensor.statistics_runnings_total");
		///<summary>Statistics Runnings Unavailable</summary>
		public SensorEntity StatisticsRunningsUnavailable => new(_haContext, "sensor.statistics_runnings_unavailable");
		///<summary>Statistics Sensors Available</summary>
		public SensorEntity StatisticsSensorsAvailable => new(_haContext, "sensor.statistics_sensors_available");
		///<summary>Statistics Sensors Total</summary>
		public SensorEntity StatisticsSensorsTotal => new(_haContext, "sensor.statistics_sensors_total");
		///<summary>Statistics Sensors Unavailable</summary>
		public SensorEntity StatisticsSensorsUnavailable => new(_haContext, "sensor.statistics_sensors_unavailable");
		///<summary>Statistics Smokes Cleared</summary>
		public SensorEntity StatisticsSmokesCleared => new(_haContext, "sensor.statistics_smokes_cleared");
		///<summary>Statistics Smokes Detected</summary>
		public SensorEntity StatisticsSmokesDetected => new(_haContext, "sensor.statistics_smokes_detected");
		///<summary>Statistics Smokes Total</summary>
		public SensorEntity StatisticsSmokesTotal => new(_haContext, "sensor.statistics_smokes_total");
		///<summary>Statistics Smokes Unavailable</summary>
		public SensorEntity StatisticsSmokesUnavailable => new(_haContext, "sensor.statistics_smokes_unavailable");
		///<summary>Statistics Switches Off</summary>
		public SensorEntity StatisticsSwitchesOff => new(_haContext, "sensor.statistics_switches_off");
		///<summary>Statistics Switches On</summary>
		public SensorEntity StatisticsSwitchesOn => new(_haContext, "sensor.statistics_switches_on");
		///<summary>Statistics Switches Total</summary>
		public SensorEntity StatisticsSwitchesTotal => new(_haContext, "sensor.statistics_switches_total");
		///<summary>Statistics Switches Unavailable</summary>
		public SensorEntity StatisticsSwitchesUnavailable => new(_haContext, "sensor.statistics_switches_unavailable");
		///<summary>Statistics Tampers Cleared</summary>
		public SensorEntity StatisticsTampersCleared => new(_haContext, "sensor.statistics_tampers_cleared");
		///<summary>Statistics Tampers Detected</summary>
		public SensorEntity StatisticsTampersDetected => new(_haContext, "sensor.statistics_tampers_detected");
		///<summary>Statistics Tampers Total</summary>
		public SensorEntity StatisticsTampersTotal => new(_haContext, "sensor.statistics_tampers_total");
		///<summary>Statistics Tampers Unavailable</summary>
		public SensorEntity StatisticsTampersUnavailable => new(_haContext, "sensor.statistics_tampers_unavailable");
		///<summary>Statistics Updates Detected</summary>
		public SensorEntity StatisticsUpdatesDetected => new(_haContext, "sensor.statistics_updates_detected");
		///<summary>Statistics Updates Total</summary>
		public SensorEntity StatisticsUpdatesTotal => new(_haContext, "sensor.statistics_updates_total");
		///<summary>Statistics Updates Unavailable</summary>
		public SensorEntity StatisticsUpdatesUnavailable => new(_haContext, "sensor.statistics_updates_unavailable");
		///<summary>Statistics Updates Up To Date</summary>
		public SensorEntity StatisticsUpdatesUpToDate => new(_haContext, "sensor.statistics_updates_up_to_date");
		///<summary>Statistics Vacuums Off</summary>
		public SensorEntity StatisticsVacuumsOff => new(_haContext, "sensor.statistics_vacuums_off");
		///<summary>Statistics Vacuums On</summary>
		public SensorEntity StatisticsVacuumsOn => new(_haContext, "sensor.statistics_vacuums_on");
		///<summary>Statistics Vacuums Total</summary>
		public SensorEntity StatisticsVacuumsTotal => new(_haContext, "sensor.statistics_vacuums_total");
		///<summary>Statistics Vacuums Unavailable</summary>
		public SensorEntity StatisticsVacuumsUnavailable => new(_haContext, "sensor.statistics_vacuums_unavailable");
		///<summary>Statistics Vibrations Cleared</summary>
		public SensorEntity StatisticsVibrationsCleared => new(_haContext, "sensor.statistics_vibrations_cleared");
		///<summary>Statistics Vibrations Detected</summary>
		public SensorEntity StatisticsVibrationsDetected => new(_haContext, "sensor.statistics_vibrations_detected");
		///<summary>Statistics Vibrations Total</summary>
		public SensorEntity StatisticsVibrationsTotal => new(_haContext, "sensor.statistics_vibrations_total");
		///<summary>Statistics Vibrations Unavailable</summary>
		public SensorEntity StatisticsVibrationsUnavailable => new(_haContext, "sensor.statistics_vibrations_unavailable");
		///<summary>Statistics Water Leaks Cleared</summary>
		public SensorEntity StatisticsWaterLeaksCleared => new(_haContext, "sensor.statistics_water_leaks_cleared");
		///<summary>Statistics Water Leaks Detected</summary>
		public SensorEntity StatisticsWaterLeaksDetected => new(_haContext, "sensor.statistics_water_leaks_detected");
		///<summary>Statistics Water Leaks Total</summary>
		public SensorEntity StatisticsWaterLeaksTotal => new(_haContext, "sensor.statistics_water_leaks_total");
		///<summary>Statistics Water Leaks Unavailable</summary>
		public SensorEntity StatisticsWaterLeaksUnavailable => new(_haContext, "sensor.statistics_water_leaks_unavailable");
		///<summary>Tech Room Meter Uptime</summary>
		public SensorEntity TechRoomMeterUptime => new(_haContext, "sensor.tech_room_meter_uptime");
		///<summary>Tech Room UPS Battery Needs Replacing</summary>
		public SensorEntity TechRoomUpsBatteryNeedsReplacing => new(_haContext, "sensor.tech_room_ups_battery_needs_replacing");
		///<summary>Tech Room UPS Battery Status</summary>
		public SensorEntity TechRoomUpsBatteryStatus => new(_haContext, "sensor.tech_room_ups_battery_status");
		///<summary>Tech Room UPS Input Fail Cause</summary>
		public SensorEntity TechRoomUpsInputFailCause => new(_haContext, "sensor.tech_room_ups_input_fail_cause");
		///<summary>Tech Room UPS Input Status</summary>
		public SensorEntity TechRoomUpsInputStatus => new(_haContext, "sensor.tech_room_ups_input_status");
		///<summary>Tech Room UPS Output Frequency</summary>
		public SensorEntity TechRoomUpsOutputFrequency => new(_haContext, "sensor.tech_room_ups_output_frequency");
		///<summary>Tech Room UPS Output Status</summary>
		public SensorEntity TechRoomUpsOutputStatus => new(_haContext, "sensor.tech_room_ups_output_status");
		///<summary>Tech Room Washer</summary>
		public SensorEntity TechRoomWasher => new(_haContext, "sensor.tech_room_washer");
		///<summary>Tech Room Washer Countdown Time</summary>
		public SensorEntity TechRoomWasherCountdownTime => new(_haContext, "sensor.tech_room_washer_countdown_time");
		///<summary>Tech Room Washer Current Course</summary>
		public SensorEntity TechRoomWasherCurrentCourse => new(_haContext, "sensor.tech_room_washer_current_course");
		///<summary>Tech Room Washer Error Message</summary>
		public SensorEntity TechRoomWasherErrorMessage => new(_haContext, "sensor.tech_room_washer_error_message");
		///<summary>Tech Room Washer Initial Time</summary>
		public SensorEntity TechRoomWasherInitialTime => new(_haContext, "sensor.tech_room_washer_initial_time");
		///<summary>Tech Room Washer Pre State</summary>
		public SensorEntity TechRoomWasherPreState => new(_haContext, "sensor.tech_room_washer_pre_state");
		///<summary>Tech Room Washer Remaining Time</summary>
		public SensorEntity TechRoomWasherRemainingTime => new(_haContext, "sensor.tech_room_washer_remaining_time");
		///<summary>Tech Room Washer Run State</summary>
		public SensorEntity TechRoomWasherRunState => new(_haContext, "sensor.tech_room_washer_run_state");
		///<summary>Tech Room Washer Spin Speed</summary>
		public SensorEntity TechRoomWasherSpinSpeed => new(_haContext, "sensor.tech_room_washer_spin_speed");
		///<summary>Tech Room Washer Tub Clean Counter</summary>
		public SensorEntity TechRoomWasherTubCleanCounter => new(_haContext, "sensor.tech_room_washer_tub_clean_counter");
		///<summary>Tech Room Washer Water Temperature</summary>
		public SensorEntity TechRoomWasherWaterTemp => new(_haContext, "sensor.tech_room_washer_water_temp");
		///<summary>Tech Room Water Leak Sensor Power Outage Count</summary>
		public SensorEntity TechRoomWaterLeakSensorPowerOutageCount => new(_haContext, "sensor.tech_room_water_leak_sensor_power_outage_count");
		///<summary>Roses Watering Next Cycle</summary>
		public SensorEntity TrandafiriNextCycle => new(_haContext, "sensor.trandafiri_next_cycle");
		///<summary>Tuja Watering Next Cycle</summary>
		public SensorEntity TuiaNextCycle => new(_haContext, "sensor.tuia_next_cycle");
		///<summary>Uptime</summary>
		public SensorEntity Uptime => new(_haContext, "sensor.uptime");
		///<summary>WINSRV Current Username</summary>
		public SensorEntity WinsrvCurrentUsername => new(_haContext, "sensor.winsrv_current_username");
		///<summary>WINSRV Network #0 - IPv4</summary>
		public SensorEntity WinsrvNetwork0Ipv4 => new(_haContext, "sensor.winsrv_network_0_ipv4");
		///<summary>WINSRV Network #0 - IPv6</summary>
		public SensorEntity WinsrvNetwork0Ipv6 => new(_haContext, "sensor.winsrv_network_0_ipv6");
		///<summary>WINSRV Screen #0 - Height</summary>
		public SensorEntity WinsrvScreen0Height => new(_haContext, "sensor.winsrv_screen_0_height");
		///<summary>WINSRV Screen #0 - Width</summary>
		public SensorEntity WinsrvScreen0Width => new(_haContext, "sensor.winsrv_screen_0_width");
		///<summary>WINSRV Storage C - Format</summary>
		public SensorEntity WinsrvStorageCFormat => new(_haContext, "sensor.winsrv_storage_c_format");
		///<summary>WINSRV Storage C - Label</summary>
		public SensorEntity WinsrvStorageCLabel => new(_haContext, "sensor.winsrv_storage_c_label");
		///<summary>WINSRV Storage E - Format</summary>
		public SensorEntity WinsrvStorageEFormat => new(_haContext, "sensor.winsrv_storage_e_format");
		///<summary>WINSRV Storage E - Label</summary>
		public SensorEntity WinsrvStorageELabel => new(_haContext, "sensor.winsrv_storage_e_label");
		///<summary>WINSRV Storage H - Format</summary>
		public SensorEntity WinsrvStorageHFormat => new(_haContext, "sensor.winsrv_storage_h_format");
		///<summary>WINSRV Storage H - Label</summary>
		public SensorEntity WinsrvStorageHLabel => new(_haContext, "sensor.winsrv_storage_h_label");
		///<summary>WINSRV System Boot Time</summary>
		public SensorEntity WinsrvSystemBootTime => new(_haContext, "sensor.winsrv_system_boot_time");
		///<summary>WINSRV System Uptime</summary>
		public SensorEntity WinsrvSystemUptime => new(_haContext, "sensor.winsrv_system_uptime");
		///<summary>Raspberries Watering Mext Cycle</summary>
		public SensorEntity ZmeuraNextCycle => new(_haContext, "sensor.zmeura_next_cycle");
	}

	public partial class SunEntities
	{
		private readonly IHaContext _haContext;
		public SunEntities(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Sun</summary>
		public SunEntity Sun => new(_haContext, "sun.sun");
	}

	public partial class SwitchEntities
	{
		private readonly IHaContext _haContext;
		public SwitchEntities(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Agriculture Watering Auto</summary>
		public SwitchEntity AgriculturaAutomaticWatering => new(_haContext, "switch.agricultura_automatic_watering");
		///<summary>Agriculture Watering Manual</summary>
		public SwitchEntity AgriculturaManualWatering => new(_haContext, "switch.agricultura_manual_watering");
		///<summary>Bedroom AC Fresh Air</summary>
		public SwitchEntity BedroomAcFreshAir => new(_haContext, "switch.bedroom_ac_fresh_air");
		///<summary>Bedroom AC Panel Light</summary>
		public SwitchEntity BedroomAcPanelLight => new(_haContext, "switch.bedroom_ac_panel_light");
		///<summary>Bedroom AC Quiet</summary>
		public SwitchEntity BedroomAcQuiet => new(_haContext, "switch.bedroom_ac_quiet");
		///<summary>Bedroom AC XFan</summary>
		public SwitchEntity BedroomAcXfan => new(_haContext, "switch.bedroom_ac_xfan");
		///<summary>Bedroom Outlet</summary>
		public SwitchEntity BedroomOutlet => new(_haContext, "switch.bedroom_outlet");
		///<summary>Child Room AC Fresh Air</summary>
		public SwitchEntity ChildRoomAcFreshAir => new(_haContext, "switch.child_room_ac_fresh_air");
		///<summary>Child Room AC Panel Light</summary>
		public SwitchEntity ChildRoomAcPanelLight => new(_haContext, "switch.child_room_ac_panel_light");
		///<summary>Child Room AC Quiet</summary>
		public SwitchEntity ChildRoomAcQuiet => new(_haContext, "switch.child_room_ac_quiet");
		///<summary>Child Room AC XFan</summary>
		public SwitchEntity ChildRoomAcXfan => new(_haContext, "switch.child_room_ac_xfan");
		///<summary>Trees Watering Auto</summary>
		public SwitchEntity CopaciAutomaticWatering => new(_haContext, "switch.copaci_automatic_watering");
		///<summary>Trees Watering Manual</summary>
		public SwitchEntity CopaciManualWatering => new(_haContext, "switch.copaci_manual_watering");
		///<summary>ESPresense Bedroom Active Scan</summary>
		public SwitchEntity EspresenseBedroomActiveScan => new(_haContext, "switch.espresense_bedroom_active_scan");
		///<summary>ESPresense Bedroom Arduino OTA</summary>
		public SwitchEntity EspresenseBedroomArduinoOta => new(_haContext, "switch.espresense_bedroom_arduino_ota");
		///<summary>ESPresense Bedroom Auto Update</summary>
		public SwitchEntity EspresenseBedroomAutoUpdate => new(_haContext, "switch.espresense_bedroom_auto_update");
		///<summary>ESPresense Bedroom Prerelease</summary>
		public SwitchEntity EspresenseBedroomPrerelease => new(_haContext, "switch.espresense_bedroom_prerelease");
		///<summary>ESPresense Bedroom Status LED</summary>
		public SwitchEntity EspresenseBedroomStatusLed => new(_haContext, "switch.espresense_bedroom_status_led");
		///<summary>ESPresense Child Room Active Scan</summary>
		public SwitchEntity EspresenseChildRoomActiveScan => new(_haContext, "switch.espresense_child_room_active_scan");
		///<summary>ESPresense Child Room Arduino OTA</summary>
		public SwitchEntity EspresenseChildRoomArduinoOta => new(_haContext, "switch.espresense_child_room_arduino_ota");
		///<summary>ESPresense Child Room Auto Update</summary>
		public SwitchEntity EspresenseChildRoomAutoUpdate => new(_haContext, "switch.espresense_child_room_auto_update");
		///<summary>ESPresense Child Room Prerelease</summary>
		public SwitchEntity EspresenseChildRoomPrerelease => new(_haContext, "switch.espresense_child_room_prerelease");
		///<summary>ESPresense Child Room Status LED</summary>
		public SwitchEntity EspresenseChildRoomStatusLed => new(_haContext, "switch.espresense_child_room_status_led");
		///<summary>ESPresense Kitchen Active Scan</summary>
		public SwitchEntity EspresenseKitchenActiveScan => new(_haContext, "switch.espresense_kitchen_active_scan");
		///<summary>ESPresense Kitchen Arduino OTA</summary>
		public SwitchEntity EspresenseKitchenArduinoOta => new(_haContext, "switch.espresense_kitchen_arduino_ota");
		///<summary>ESPresense Kitchen Auto Update</summary>
		public SwitchEntity EspresenseKitchenAutoUpdate => new(_haContext, "switch.espresense_kitchen_auto_update");
		///<summary>ESPresense Kitchen Prerelease</summary>
		public SwitchEntity EspresenseKitchenPrerelease => new(_haContext, "switch.espresense_kitchen_prerelease");
		///<summary>ESPresense Kitchen Status LED</summary>
		public SwitchEntity EspresenseKitchenStatusLed => new(_haContext, "switch.espresense_kitchen_status_led");
		///<summary>ESPresense Living Room 2 Active Scan</summary>
		public SwitchEntity EspresenseLivingRoom2ActiveScan => new(_haContext, "switch.espresense_living_room_2_active_scan");
		///<summary>ESPresense Living Room 2 Arduino OTA</summary>
		public SwitchEntity EspresenseLivingRoom2ArduinoOta => new(_haContext, "switch.espresense_living_room_2_arduino_ota");
		///<summary>ESPresense Living Room 2 Auto Update</summary>
		public SwitchEntity EspresenseLivingRoom2AutoUpdate => new(_haContext, "switch.espresense_living_room_2_auto_update");
		///<summary>ESPresense Living Room 2 Prerelease</summary>
		public SwitchEntity EspresenseLivingRoom2Prerelease => new(_haContext, "switch.espresense_living_room_2_prerelease");
		///<summary>ESPresense Living Room 2 Status LED</summary>
		public SwitchEntity EspresenseLivingRoom2StatusLed => new(_haContext, "switch.espresense_living_room_2_status_led");
		///<summary>ESPresense Living Room Active Scan</summary>
		public SwitchEntity EspresenseLivingRoomActiveScan => new(_haContext, "switch.espresense_living_room_active_scan");
		///<summary>ESPresense Living Room Arduino OTA</summary>
		public SwitchEntity EspresenseLivingRoomArduinoOta => new(_haContext, "switch.espresense_living_room_arduino_ota");
		///<summary>ESPresense Living Room Auto Update</summary>
		public SwitchEntity EspresenseLivingRoomAutoUpdate => new(_haContext, "switch.espresense_living_room_auto_update");
		///<summary>ESPresense Living Room Prerelease</summary>
		public SwitchEntity EspresenseLivingRoomPrerelease => new(_haContext, "switch.espresense_living_room_prerelease");
		///<summary>ESPresense Living Room Status LED</summary>
		public SwitchEntity EspresenseLivingRoomStatusLed => new(_haContext, "switch.espresense_living_room_status_led");
		///<summary>ESPresense Office Active Scan</summary>
		public SwitchEntity EspresenseOfficeActiveScan => new(_haContext, "switch.espresense_office_active_scan");
		///<summary>ESPresense Office Arduino OTA</summary>
		public SwitchEntity EspresenseOfficeArduinoOta => new(_haContext, "switch.espresense_office_arduino_ota");
		///<summary>ESPresense Office Auto Update</summary>
		public SwitchEntity EspresenseOfficeAutoUpdate => new(_haContext, "switch.espresense_office_auto_update");
		///<summary>ESPresense Office Prerelease</summary>
		public SwitchEntity EspresenseOfficePrerelease => new(_haContext, "switch.espresense_office_prerelease");
		///<summary>ESPresense Office Status LED</summary>
		public SwitchEntity EspresenseOfficeStatusLed => new(_haContext, "switch.espresense_office_status_led");
		///<summary>ESPresense Shed Active Scan</summary>
		public SwitchEntity EspresenseShedActiveScan => new(_haContext, "switch.espresense_shed_active_scan");
		///<summary>ESPresense Shed Arduino OTA</summary>
		public SwitchEntity EspresenseShedArduinoOta => new(_haContext, "switch.espresense_shed_arduino_ota");
		///<summary>ESPresense Shed Auto Update</summary>
		public SwitchEntity EspresenseShedAutoUpdate => new(_haContext, "switch.espresense_shed_auto_update");
		///<summary>ESPresense Shed Prerelease</summary>
		public SwitchEntity EspresenseShedPrerelease => new(_haContext, "switch.espresense_shed_prerelease");
		///<summary>ESPresense Shed Status LED</summary>
		public SwitchEntity EspresenseShedStatusLed => new(_haContext, "switch.espresense_shed_status_led");
		///<summary>ESPresense Tech Room Active Scan</summary>
		public SwitchEntity EspresenseTechRoomActiveScan => new(_haContext, "switch.espresense_tech_room_active_scan");
		///<summary>ESPresense Tech Room Arduino OTA</summary>
		public SwitchEntity EspresenseTechRoomArduinoOta => new(_haContext, "switch.espresense_tech_room_arduino_ota");
		///<summary>ESPresense Tech Room Auto Update</summary>
		public SwitchEntity EspresenseTechRoomAutoUpdate => new(_haContext, "switch.espresense_tech_room_auto_update");
		///<summary>ESPresense Tech Room Prerelease</summary>
		public SwitchEntity EspresenseTechRoomPrerelease => new(_haContext, "switch.espresense_tech_room_prerelease");
		///<summary>ESPresense Tech Room Status LED</summary>
		public SwitchEntity EspresenseTechRoomStatusLed => new(_haContext, "switch.espresense_tech_room_status_led");
		///<summary>Flowers Watering Auto</summary>
		public SwitchEntity FloriAutomaticWatering => new(_haContext, "switch.flori_automatic_watering");
		///<summary>Flowers Watering Manual</summary>
		public SwitchEntity FloriManualWatering => new(_haContext, "switch.flori_manual_watering");
		///<summary>Gazebo Outlet</summary>
		public SwitchEntity GazeboOutlet => new(_haContext, "switch.gazebo_outlet");
		///<summary>Lawn Watering Auto</summary>
		public SwitchEntity GazonMareAutomaticWatering => new(_haContext, "switch.gazon_mare_automatic_watering");
		///<summary>Lawn Watering Manual</summary>
		public SwitchEntity GazonMareManualWatering => new(_haContext, "switch.gazon_mare_manual_watering");
		///<summary>Small Lawn Watering Auto</summary>
		public SwitchEntity GazonMicAutomaticWatering => new(_haContext, "switch.gazon_mic_automatic_watering");
		///<summary>Small Lawn Watering Manual</summary>
		public SwitchEntity GazonMicManualWatering => new(_haContext, "switch.gazon_mic_manual_watering");
		///<summary>Kitchen Coffee Maker Power</summary>
		public SwitchEntity KitchenCoffeeMakerPower => new(_haContext, "switch.kitchen_coffee_maker_power");
		///<summary>Kitchen Coffee Maker Program Americano</summary>
		public SwitchEntity KitchenCoffeeMakerProgramAmericano => new(_haContext, "switch.kitchen_coffee_maker_program_americano");
		///<summary>Kitchen Coffee Maker Program CaffeLatte</summary>
		public SwitchEntity KitchenCoffeeMakerProgramCaffelatte => new(_haContext, "switch.kitchen_coffee_maker_program_caffelatte");
		///<summary>Kitchen Coffee Maker Program Cappuccino</summary>
		public SwitchEntity KitchenCoffeeMakerProgramCappuccino => new(_haContext, "switch.kitchen_coffee_maker_program_cappuccino");
		///<summary>Kitchen Coffee Maker Program Coffee</summary>
		public SwitchEntity KitchenCoffeeMakerProgramCoffee => new(_haContext, "switch.kitchen_coffee_maker_program_coffee");
		///<summary>Kitchen Coffee Maker Program Cortado</summary>
		public SwitchEntity KitchenCoffeeMakerProgramCortado => new(_haContext, "switch.kitchen_coffee_maker_program_cortado");
		///<summary>Kitchen Coffee Maker Program Espresso</summary>
		public SwitchEntity KitchenCoffeeMakerProgramEspresso => new(_haContext, "switch.kitchen_coffee_maker_program_espresso");
		///<summary>Kitchen Coffee Maker Program EspressoDoppio</summary>
		public SwitchEntity KitchenCoffeeMakerProgramEspressodoppio => new(_haContext, "switch.kitchen_coffee_maker_program_espressodoppio");
		///<summary>Kitchen Coffee Maker Program EspressoMacchiato</summary>
		public SwitchEntity KitchenCoffeeMakerProgramEspressomacchiato => new(_haContext, "switch.kitchen_coffee_maker_program_espressomacchiato");
		///<summary>Kitchen Coffee Maker Program FlatWhite</summary>
		public SwitchEntity KitchenCoffeeMakerProgramFlatwhite => new(_haContext, "switch.kitchen_coffee_maker_program_flatwhite");
		///<summary>Kitchen Coffee Maker Program Galao</summary>
		public SwitchEntity KitchenCoffeeMakerProgramGalao => new(_haContext, "switch.kitchen_coffee_maker_program_galao");
		///<summary>Kitchen Coffee Maker Program LatteMacchiato</summary>
		public SwitchEntity KitchenCoffeeMakerProgramLattemacchiato => new(_haContext, "switch.kitchen_coffee_maker_program_lattemacchiato");
		///<summary>Kitchen Coffee Maker Program MilkFroth</summary>
		public SwitchEntity KitchenCoffeeMakerProgramMilkfroth => new(_haContext, "switch.kitchen_coffee_maker_program_milkfroth");
		///<summary>Kitchen Coffee Maker Program Ristretto</summary>
		public SwitchEntity KitchenCoffeeMakerProgramRistretto => new(_haContext, "switch.kitchen_coffee_maker_program_ristretto");
		///<summary>Kitchen Coffee Maker Program WarmMilk</summary>
		public SwitchEntity KitchenCoffeeMakerProgramWarmmilk => new(_haContext, "switch.kitchen_coffee_maker_program_warmmilk");
		///<summary>Kitchen Fridge Ice Plus</summary>
		public SwitchEntity KitchenFridgeIcePlus => new(_haContext, "switch.kitchen_fridge_ice_plus");
		///<summary>Kitchen Heat Detector alarm</summary>
		public SwitchEntity KitchenHeatDetectorAlarm => new(_haContext, "switch.kitchen_heat_detector_alarm");
		///<summary>Kitchen Outlet</summary>
		public SwitchEntity KitchenOutlet => new(_haContext, "switch.kitchen_outlet");
		///<summary>Kitchen Outlet Right</summary>
		public SwitchEntity KitchenOutletRight => new(_haContext, "switch.kitchen_outlet_right");
		///<summary>Kitchen Smoke Detector Alarm</summary>
		public SwitchEntity KitchenSmokeDetectorAlarm => new(_haContext, "switch.kitchen_smoke_detector_alarm");
		///<summary>Kitchen Switch left</summary>
		public SwitchEntity KitchenSwitchLeft => new(_haContext, "switch.kitchen_switch_left");
		///<summary>Living Room AC Fresh Air</summary>
		public SwitchEntity LivingRoomAcFreshAir => new(_haContext, "switch.living_room_ac_fresh_air");
		///<summary>Living Room AC Panel Light</summary>
		public SwitchEntity LivingRoomAcPanelLight => new(_haContext, "switch.living_room_ac_panel_light");
		///<summary>Living Room AC Quiet</summary>
		public SwitchEntity LivingRoomAcQuiet => new(_haContext, "switch.living_room_ac_quiet");
		///<summary>Living Room AC XFan</summary>
		public SwitchEntity LivingRoomAcXfan => new(_haContext, "switch.living_room_ac_xfan");
		///<summary>Enhancer</summary>
		public SwitchEntity LivingroomMediaplayerZone1Enhancer => new(_haContext, "switch.livingroom_mediaplayer_zone1_enhancer");
		///<summary>Office AC Fresh Air</summary>
		public SwitchEntity OfficeAcFreshAir => new(_haContext, "switch.office_ac_fresh_air");
		///<summary>Office AC Panel Light</summary>
		public SwitchEntity OfficeAcPanelLight => new(_haContext, "switch.office_ac_panel_light");
		///<summary>Office AC Quiet</summary>
		public SwitchEntity OfficeAcQuiet => new(_haContext, "switch.office_ac_quiet");
		///<summary>Office AC XFan</summary>
		public SwitchEntity OfficeAcXfan => new(_haContext, "switch.office_ac_xfan");
		///<summary>Office Switch</summary>
		public SwitchEntity OfficeSwitch => new(_haContext, "switch.office_switch");
		///<summary>Office Switch flip_indicator_light</summary>
		public SwitchEntity OfficeSwitchFlipIndicatorLight => new(_haContext, "switch.office_switch_flip_indicator_light");
		///<summary>Office Switch power_outage_memory</summary>
		public SwitchEntity OfficeSwitchPowerOutageMemory => new(_haContext, "switch.office_switch_power_outage_memory");
		///<summary>Lawn Pump Watering Auto</summary>
		public SwitchEntity PompaAutomaticWatering => new(_haContext, "switch.pompa_automatic_watering");
		///<summary>Lawn Pump Watering Manual</summary>
		public SwitchEntity PompaManualWatering => new(_haContext, "switch.pompa_manual_watering");
		///<summary>Shed Dryer Power Off</summary>
		public SwitchEntity ShedDryerPowerOff => new(_haContext, "switch.shed_dryer_power_off");
		///<summary>Shed Outlet</summary>
		public SwitchEntity ShedOutlet => new(_haContext, "switch.shed_outlet");
		///<summary>Tech Room Meter</summary>
		public SwitchEntity TechRoomMeter => new(_haContext, "switch.tech_room_meter");
		///<summary>Tech Room Washer Power Off</summary>
		public SwitchEntity TechRoomWasherPowerOff => new(_haContext, "switch.tech_room_washer_power_off");
		///<summary>Roses Watering Auto</summary>
		public SwitchEntity TrandafiriAutomaticWatering => new(_haContext, "switch.trandafiri_automatic_watering");
		///<summary>Roses Watering Manual</summary>
		public SwitchEntity TrandafiriManualWatering => new(_haContext, "switch.trandafiri_manual_watering");
		///<summary>Tuja Watering Auto</summary>
		public SwitchEntity TuiaAutomaticWatering => new(_haContext, "switch.tuia_automatic_watering");
		///<summary>Tuja Watering Manual</summary>
		public SwitchEntity TuiaManualWatering => new(_haContext, "switch.tuia_manual_watering");
		///<summary>Raspberries Watering Auto</summary>
		public SwitchEntity ZmeuraAutomaticWatering => new(_haContext, "switch.zmeura_automatic_watering");
		///<summary>Raspberries Watering Manual</summary>
		public SwitchEntity ZmeuraManualWatering => new(_haContext, "switch.zmeura_manual_watering");
	}

	public partial class TimerEntities
	{
		private readonly IHaContext _haContext;
		public TimerEntities(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Test</summary>
		public TimerEntity Test => new(_haContext, "timer.test");
	}

	public partial class UpdateEntities
	{
		private readonly IHaContext _haContext;
		public UpdateEntities(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Let's Encrypt: Update</summary>
		public UpdateEntity LetSEncryptUpdate => new(_haContext, "update.let_s_encrypt_update");
		///<summary>NGINX Home Assistant SSL proxy: Update</summary>
		public UpdateEntity NginxHomeAssistantSslProxyUpdate => new(_haContext, "update.nginx_home_assistant_ssl_proxy_update");
		///<summary>File editor: Update</summary>
		public UpdateEntity ServiceFileEditorUpdate => new(_haContext, "update.service_file_editor_update");
		///<summary>Home Assistant Core: Update</summary>
		public UpdateEntity ServiceHaCoreUpdate => new(_haContext, "update.service_ha_core_update");
		///<summary>Home Assistant Operating System: Update</summary>
		public UpdateEntity ServiceHaOsUpdate => new(_haContext, "update.service_ha_os_update");
		///<summary>Home Assistant Supervisor: Update</summary>
		public UpdateEntity ServiceHaSupervisorUpdate => new(_haContext, "update.service_ha_supervisor_update");
		///<summary>MariaDB: Update</summary>
		public UpdateEntity ServiceMariadbUpdate => new(_haContext, "update.service_mariadb_update");
		///<summary>Mosquitto broker: Update</summary>
		public UpdateEntity ServiceMosquittoUpdate => new(_haContext, "update.service_mosquitto_update");
		///<summary>NetDaemon V3 - beta: Update</summary>
		public UpdateEntity ServiceNetdaemonUpdate => new(_haContext, "update.service_netdaemon_update");
		///<summary>RPC Shutdown: Update</summary>
		public UpdateEntity ServiceRpcShutdownUpdate => new(_haContext, "update.service_rpc_shutdown_update");
		///<summary>Samba share: Update</summary>
		public UpdateEntity ServiceSambaUpdate => new(_haContext, "update.service_samba_update");
		///<summary>Terminal & SSH: Update</summary>
		public UpdateEntity ServiceTerminallSshUpdate => new(_haContext, "update.service_terminall_ssh_update");
	}

	public partial class VacuumEntities
	{
		private readonly IHaContext _haContext;
		public VacuumEntities(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Living Room Vacuum</summary>
		public VacuumEntity LivingRoomVacuum => new(_haContext, "vacuum.living_room_vacuum");
	}

	public partial class WeatherEntities
	{
		private readonly IHaContext _haContext;
		public WeatherEntities(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Casa del Mar</summary>
		public WeatherEntity Home => new(_haContext, "weather.home");
		///<summary>Casa del Mar Hourly</summary>
		public WeatherEntity HomeHourly => new(_haContext, "weather.home_hourly");
	}

	public partial class ZoneEntities
	{
		private readonly IHaContext _haContext;
		public ZoneEntities(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Casa del Mar</summary>
		public ZoneEntity Home => new(_haContext, "zone.home");
		///<summary>Luxor</summary>
		public ZoneEntity Luxor => new(_haContext, "zone.luxor");
		///<summary>Marius</summary>
		public ZoneEntity Marius => new(_haContext, "zone.marius");
		///<summary>Relu</summary>
		public ZoneEntity Relu => new(_haContext, "zone.relu");
		///<summary>Școală</summary>
		public ZoneEntity SchoolRares => new(_haContext, "zone.school_rares");
		///<summary>DSP</summary>
		public ZoneEntity WorkNico => new(_haContext, "zone.work_nico");
		///<summary>Mazars</summary>
		public ZoneEntity WorkRazvan => new(_haContext, "zone.work_razvan");
	}

	public partial record AlarmControlPanelEntity : Entity<AlarmControlPanelEntity, EntityState<AlarmControlPanelAttributes>, AlarmControlPanelAttributes>
	{
		public AlarmControlPanelEntity(IHaContext haContext, string entityId) : base(haContext, entityId)
		{
		}

		public AlarmControlPanelEntity(Entity entity) : base(entity)
		{
		}
	}

	public record AlarmControlPanelAttributes
	{
		[JsonPropertyName("changed_by")]
		public object? ChangedBy { get; init; }

		[JsonPropertyName("code_arm_required")]
		public bool? CodeArmRequired { get; init; }

		[JsonPropertyName("code_format")]
		public object? CodeFormat { get; init; }

		[JsonPropertyName("friendly_name")]
		public string? FriendlyName { get; init; }

		[JsonPropertyName("supported_features")]
		public double? SupportedFeatures { get; init; }
	}

	public partial record BinarySensorEntity : Entity<BinarySensorEntity, EntityState<BinarySensorAttributes>, BinarySensorAttributes>
	{
		public BinarySensorEntity(IHaContext haContext, string entityId) : base(haContext, entityId)
		{
		}

		public BinarySensorEntity(Entity entity) : base(entity)
		{
		}
	}

	public record BinarySensorAttributes
	{
		[JsonPropertyName("action")]
		public object? Action { get; init; }

		[JsonPropertyName("adverts")]
		public double? Adverts { get; init; }

		[JsonPropertyName("after")]
		public string? After { get; init; }

		[JsonPropertyName("alarm")]
		public object? Alarm { get; init; }

		[JsonPropertyName("angle")]
		public double? Angle { get; init; }

		[JsonPropertyName("angle_x")]
		public double? AngleX { get; init; }

		[JsonPropertyName("angle_x_absolute")]
		public double? AngleXAbsolute { get; init; }

		[JsonPropertyName("angle_y")]
		public double? AngleY { get; init; }

		[JsonPropertyName("angle_y_absolute")]
		public double? AngleYAbsolute { get; init; }

		[JsonPropertyName("angle_z")]
		public double? AngleZ { get; init; }

		[JsonPropertyName("assumed_state")]
		public bool? AssumedState { get; init; }

		[JsonPropertyName("attribution")]
		public string? Attribution { get; init; }

		[JsonPropertyName("battery")]
		public double? Battery { get; init; }

		[JsonPropertyName("battery_low")]
		public bool? BatteryLow { get; init; }

		[JsonPropertyName("before")]
		public string? Before { get; init; }

		[JsonPropertyName("beta_version")]
		public string? BetaVersion { get; init; }

		[JsonPropertyName("contact")]
		public bool? Contact { get; init; }

		[JsonPropertyName("current_firmware")]
		public string? CurrentFirmware { get; init; }

		[JsonPropertyName("days_offset")]
		public double? DaysOffset { get; init; }

		[JsonPropertyName("device_class")]
		public string? DeviceClass { get; init; }

		[JsonPropertyName("device_temperature")]
		public double? DeviceTemperature { get; init; }

		[JsonPropertyName("enrolled")]
		public bool? Enrolled { get; init; }

		[JsonPropertyName("entity_id")]
		public object? EntityId { get; init; }

		[JsonPropertyName("excludes")]
		public object? Excludes { get; init; }

		[JsonPropertyName("fault")]
		public bool? Fault { get; init; }

		[JsonPropertyName("firm")]
		public string? Firm { get; init; }

		[JsonPropertyName("freeHeap")]
		public double? FreeHeap { get; init; }

		[JsonPropertyName("friendly_name")]
		public string? FriendlyName { get; init; }

		[JsonPropertyName("gradient")]
		public double? Gradient { get; init; }

		[JsonPropertyName("ias_cie_address")]
		public string? IasCieAddress { get; init; }

		[JsonPropertyName("icon")]
		public string? Icon { get; init; }

		[JsonPropertyName("identifier")]
		public double? Identifier { get; init; }

		[JsonPropertyName("ignoring_battery_optimizations")]
		public bool? IgnoringBatteryOptimizations { get; init; }

		[JsonPropertyName("illuminance")]
		public double? Illuminance { get; init; }

		[JsonPropertyName("illuminance_lux")]
		public double? IlluminanceLux { get; init; }

		[JsonPropertyName("installed_version")]
		public string? InstalledVersion { get; init; }

		[JsonPropertyName("invert")]
		public bool? Invert { get; init; }

		[JsonPropertyName("ip")]
		public string? Ip { get; init; }

		[JsonPropertyName("last_tripped_time")]
		public string? LastTrippedTime { get; init; }

		[JsonPropertyName("latest_stable_version")]
		public string? LatestStableVersion { get; init; }

		[JsonPropertyName("linkquality")]
		public double? Linkquality { get; init; }

		[JsonPropertyName("maxAllocHeap")]
		public double? MaxAllocHeap { get; init; }

		[JsonPropertyName("max_duration")]
		public double? MaxDuration { get; init; }

		[JsonPropertyName("memFrag")]
		public double? MemFrag { get; init; }

		[JsonPropertyName("min_gradient")]
		public double? MinGradient { get; init; }

		[JsonPropertyName("next_update")]
		public string? NextUpdate { get; init; }

		[JsonPropertyName("occupancy")]
		public bool? Occupancy { get; init; }

		[JsonPropertyName("power_on_behavior")]
		public string? PowerOnBehavior { get; init; }

		[JsonPropertyName("power_outage_count")]
		public object? PowerOutageCount { get; init; }

		[JsonPropertyName("reliability")]
		public string? Reliability { get; init; }

		[JsonPropertyName("reportHighWater")]
		public double? ReportHighWater { get; init; }

		[JsonPropertyName("resetReason")]
		public string? ResetReason { get; init; }

		[JsonPropertyName("restored")]
		public bool? Restored { get; init; }

		[JsonPropertyName("restore_reports")]
		public bool? RestoreReports { get; init; }

		[JsonPropertyName("rssi")]
		public double? Rssi { get; init; }

		[JsonPropertyName("sample_count")]
		public double? SampleCount { get; init; }

		[JsonPropertyName("sample_duration")]
		public double? SampleDuration { get; init; }

		[JsonPropertyName("scanHighWater")]
		public double? ScanHighWater { get; init; }

		[JsonPropertyName("seen")]
		public double? Seen { get; init; }

		[JsonPropertyName("sensitivity")]
		public string? Sensitivity { get; init; }

		[JsonPropertyName("smoke")]
		public bool? Smoke { get; init; }

		[JsonPropertyName("strength")]
		public double? Strength { get; init; }

		[JsonPropertyName("supervision_reports")]
		public bool? SupervisionReports { get; init; }

		[JsonPropertyName("supported_features")]
		public double? SupportedFeatures { get; init; }

		[JsonPropertyName("tamper")]
		public bool? Tamper { get; init; }

		[JsonPropertyName("temperature")]
		public double? Temperature { get; init; }

		[JsonPropertyName("test")]
		public bool? Test { get; init; }

		[JsonPropertyName("update")]
		public object? Update { get; init; }

		[JsonPropertyName("update_available")]
		public object? UpdateAvailable { get; init; }

		[JsonPropertyName("uptime")]
		public double? Uptime { get; init; }

		[JsonPropertyName("ver")]
		public string? Ver { get; init; }

		[JsonPropertyName("vibration")]
		public bool? Vibration { get; init; }

		[JsonPropertyName("voltage")]
		public double? Voltage { get; init; }

		[JsonPropertyName("water_leak")]
		public bool? WaterLeak { get; init; }

		[JsonPropertyName("workdays")]
		public object? Workdays { get; init; }

		[JsonPropertyName("zone_id")]
		public double? ZoneId { get; init; }
	}

	public partial record ButtonEntity : Entity<ButtonEntity, EntityState<ButtonAttributes>, ButtonAttributes>
	{
		public ButtonEntity(IHaContext haContext, string entityId) : base(haContext, entityId)
		{
		}

		public ButtonEntity(Entity entity) : base(entity)
		{
		}
	}

	public record ButtonAttributes
	{
		[JsonPropertyName("device_class")]
		public string? DeviceClass { get; init; }

		[JsonPropertyName("friendly_name")]
		public string? FriendlyName { get; init; }
	}

	public partial record CalendarEntity : Entity<CalendarEntity, EntityState<CalendarAttributes>, CalendarAttributes>
	{
		public CalendarEntity(IHaContext haContext, string entityId) : base(haContext, entityId)
		{
		}

		public CalendarEntity(Entity entity) : base(entity)
		{
		}
	}

	public record CalendarAttributes
	{
		[JsonPropertyName("all_day")]
		public bool? AllDay { get; init; }

		[JsonPropertyName("description")]
		public string? Description { get; init; }

		[JsonPropertyName("end_time")]
		public string? EndTime { get; init; }

		[JsonPropertyName("friendly_name")]
		public string? FriendlyName { get; init; }

		[JsonPropertyName("location")]
		public string? Location { get; init; }

		[JsonPropertyName("message")]
		public string? Message { get; init; }

		[JsonPropertyName("offset_reached")]
		public bool? OffsetReached { get; init; }

		[JsonPropertyName("start_time")]
		public string? StartTime { get; init; }
	}

	public partial record CameraEntity : Entity<CameraEntity, EntityState<CameraAttributes>, CameraAttributes>
	{
		public CameraEntity(IHaContext haContext, string entityId) : base(haContext, entityId)
		{
		}

		public CameraEntity(Entity entity) : base(entity)
		{
		}
	}

	public record CameraAttributes
	{
		[JsonPropertyName("access_token")]
		public string? AccessToken { get; init; }

		[JsonPropertyName("entity_picture")]
		public string? EntityPicture { get; init; }

		[JsonPropertyName("friendly_name")]
		public string? FriendlyName { get; init; }

		[JsonPropertyName("frontend_stream_type")]
		public string? FrontendStreamType { get; init; }

		[JsonPropertyName("supported_features")]
		public double? SupportedFeatures { get; init; }
	}

	public partial record ClimateEntity : Entity<ClimateEntity, EntityState<ClimateAttributes>, ClimateAttributes>
	{
		public ClimateEntity(IHaContext haContext, string entityId) : base(haContext, entityId)
		{
		}

		public ClimateEntity(Entity entity) : base(entity)
		{
		}
	}

	public record ClimateAttributes
	{
		[JsonPropertyName("current_temperature")]
		public double? CurrentTemperature { get; init; }

		[JsonPropertyName("fan_mode")]
		public string? FanMode { get; init; }

		[JsonPropertyName("fan_modes")]
		public object? FanModes { get; init; }

		[JsonPropertyName("friendly_name")]
		public string? FriendlyName { get; init; }

		[JsonPropertyName("hvac_modes")]
		public object? HvacModes { get; init; }

		[JsonPropertyName("icon")]
		public string? Icon { get; init; }

		[JsonPropertyName("max_temp")]
		public double? MaxTemp { get; init; }

		[JsonPropertyName("min_temp")]
		public double? MinTemp { get; init; }

		[JsonPropertyName("preset_mode")]
		public string? PresetMode { get; init; }

		[JsonPropertyName("preset_modes")]
		public object? PresetModes { get; init; }

		[JsonPropertyName("supported_features")]
		public double? SupportedFeatures { get; init; }

		[JsonPropertyName("swing_mode")]
		public string? SwingMode { get; init; }

		[JsonPropertyName("swing_modes")]
		public object? SwingModes { get; init; }

		[JsonPropertyName("target_temp_step")]
		public double? TargetTempStep { get; init; }

		[JsonPropertyName("temperature")]
		public double? Temperature { get; init; }
	}

	public partial record CounterEntity : Entity<CounterEntity, EntityState<CounterAttributes>, CounterAttributes>
	{
		public CounterEntity(IHaContext haContext, string entityId) : base(haContext, entityId)
		{
		}

		public CounterEntity(Entity entity) : base(entity)
		{
		}
	}

	public record CounterAttributes
	{
		[JsonPropertyName("editable")]
		public bool? Editable { get; init; }

		[JsonPropertyName("friendly_name")]
		public string? FriendlyName { get; init; }

		[JsonPropertyName("icon")]
		public string? Icon { get; init; }

		[JsonPropertyName("initial")]
		public double? Initial { get; init; }

		[JsonPropertyName("step")]
		public double? Step { get; init; }
	}

	public partial record CoverEntity : Entity<CoverEntity, EntityState<CoverAttributes>, CoverAttributes>
	{
		public CoverEntity(IHaContext haContext, string entityId) : base(haContext, entityId)
		{
		}

		public CoverEntity(Entity entity) : base(entity)
		{
		}
	}

	public record CoverAttributes
	{
		[JsonPropertyName("current_position")]
		public double? CurrentPosition { get; init; }

		[JsonPropertyName("device_class")]
		public string? DeviceClass { get; init; }

		[JsonPropertyName("friendly_name")]
		public string? FriendlyName { get; init; }

		[JsonPropertyName("icon")]
		public string? Icon { get; init; }

		[JsonPropertyName("supported_features")]
		public double? SupportedFeatures { get; init; }
	}

	public partial record DeviceTrackerEntity : Entity<DeviceTrackerEntity, EntityState<DeviceTrackerAttributes>, DeviceTrackerAttributes>
	{
		public DeviceTrackerEntity(IHaContext haContext, string entityId) : base(haContext, entityId)
		{
		}

		public DeviceTrackerEntity(Entity entity) : base(entity)
		{
		}
	}

	public record DeviceTrackerAttributes
	{
		[JsonPropertyName("altitude")]
		public double? Altitude { get; init; }

		[JsonPropertyName("course")]
		public double? Course { get; init; }

		[JsonPropertyName("friendly_name")]
		public string? FriendlyName { get; init; }

		[JsonPropertyName("gps_accuracy")]
		public double? GpsAccuracy { get; init; }

		[JsonPropertyName("host_name")]
		public string? HostName { get; init; }

		[JsonPropertyName("icon")]
		public string? Icon { get; init; }

		[JsonPropertyName("ip")]
		public string? Ip { get; init; }

		[JsonPropertyName("last_time_reachable")]
		public string? LastTimeReachable { get; init; }

		[JsonPropertyName("latitude")]
		public double? Latitude { get; init; }

		[JsonPropertyName("longitude")]
		public double? Longitude { get; init; }

		[JsonPropertyName("mac")]
		public string? Mac { get; init; }

		[JsonPropertyName("reason")]
		public string? Reason { get; init; }

		[JsonPropertyName("source_type")]
		public string? SourceType { get; init; }

		[JsonPropertyName("speed")]
		public double? Speed { get; init; }

		[JsonPropertyName("vertical_accuracy")]
		public double? VerticalAccuracy { get; init; }
	}

	public partial record InputBooleanEntity : Entity<InputBooleanEntity, EntityState<InputBooleanAttributes>, InputBooleanAttributes>
	{
		public InputBooleanEntity(IHaContext haContext, string entityId) : base(haContext, entityId)
		{
		}

		public InputBooleanEntity(Entity entity) : base(entity)
		{
		}
	}

	public record InputBooleanAttributes
	{
		[JsonPropertyName("editable")]
		public bool? Editable { get; init; }

		[JsonPropertyName("friendly_name")]
		public string? FriendlyName { get; init; }

		[JsonPropertyName("icon")]
		public string? Icon { get; init; }
	}

	public partial record InputButtonEntity : Entity<InputButtonEntity, EntityState<InputButtonAttributes>, InputButtonAttributes>
	{
		public InputButtonEntity(IHaContext haContext, string entityId) : base(haContext, entityId)
		{
		}

		public InputButtonEntity(Entity entity) : base(entity)
		{
		}
	}

	public record InputButtonAttributes
	{
		[JsonPropertyName("editable")]
		public bool? Editable { get; init; }

		[JsonPropertyName("friendly_name")]
		public string? FriendlyName { get; init; }

		[JsonPropertyName("icon")]
		public string? Icon { get; init; }
	}

	public partial record InputDatetimeEntity : Entity<InputDatetimeEntity, EntityState<InputDatetimeAttributes>, InputDatetimeAttributes>
	{
		public InputDatetimeEntity(IHaContext haContext, string entityId) : base(haContext, entityId)
		{
		}

		public InputDatetimeEntity(Entity entity) : base(entity)
		{
		}
	}

	public record InputDatetimeAttributes
	{
		[JsonPropertyName("day")]
		public double? Day { get; init; }

		[JsonPropertyName("editable")]
		public bool? Editable { get; init; }

		[JsonPropertyName("friendly_name")]
		public string? FriendlyName { get; init; }

		[JsonPropertyName("has_date")]
		public bool? HasDate { get; init; }

		[JsonPropertyName("has_time")]
		public bool? HasTime { get; init; }

		[JsonPropertyName("month")]
		public double? Month { get; init; }

		[JsonPropertyName("timestamp")]
		public double? Timestamp { get; init; }

		[JsonPropertyName("year")]
		public double? Year { get; init; }
	}

	public partial record InputNumberEntity : NumericEntity<InputNumberEntity, NumericEntityState<InputNumberAttributes>, InputNumberAttributes>
	{
		public InputNumberEntity(IHaContext haContext, string entityId) : base(haContext, entityId)
		{
		}

		public InputNumberEntity(Entity entity) : base(entity)
		{
		}
	}

	public record InputNumberAttributes
	{
		[JsonPropertyName("editable")]
		public bool? Editable { get; init; }

		[JsonPropertyName("friendly_name")]
		public string? FriendlyName { get; init; }

		[JsonPropertyName("icon")]
		public string? Icon { get; init; }

		[JsonPropertyName("initial")]
		public object? Initial { get; init; }

		[JsonPropertyName("max")]
		public double? Max { get; init; }

		[JsonPropertyName("min")]
		public double? Min { get; init; }

		[JsonPropertyName("mode")]
		public string? Mode { get; init; }

		[JsonPropertyName("step")]
		public double? Step { get; init; }

		[JsonPropertyName("unit_of_measurement")]
		public string? UnitOfMeasurement { get; init; }
	}

	public partial record InputSelectEntity : Entity<InputSelectEntity, EntityState<InputSelectAttributes>, InputSelectAttributes>
	{
		public InputSelectEntity(IHaContext haContext, string entityId) : base(haContext, entityId)
		{
		}

		public InputSelectEntity(Entity entity) : base(entity)
		{
		}
	}

	public record InputSelectAttributes
	{
		[JsonPropertyName("editable")]
		public bool? Editable { get; init; }

		[JsonPropertyName("friendly_name")]
		public string? FriendlyName { get; init; }

		[JsonPropertyName("icon")]
		public string? Icon { get; init; }

		[JsonPropertyName("options")]
		public object? Options { get; init; }
	}

	public partial record InputTextEntity : Entity<InputTextEntity, EntityState<InputTextAttributes>, InputTextAttributes>
	{
		public InputTextEntity(IHaContext haContext, string entityId) : base(haContext, entityId)
		{
		}

		public InputTextEntity(Entity entity) : base(entity)
		{
		}
	}

	public record InputTextAttributes
	{
		[JsonPropertyName("editable")]
		public bool? Editable { get; init; }

		[JsonPropertyName("friendly_name")]
		public string? FriendlyName { get; init; }

		[JsonPropertyName("icon")]
		public string? Icon { get; init; }

		[JsonPropertyName("max")]
		public double? Max { get; init; }

		[JsonPropertyName("min")]
		public double? Min { get; init; }

		[JsonPropertyName("mode")]
		public string? Mode { get; init; }

		[JsonPropertyName("pattern")]
		public object? Pattern { get; init; }
	}

	public partial record LightEntity : Entity<LightEntity, EntityState<LightAttributes>, LightAttributes>
	{
		public LightEntity(IHaContext haContext, string entityId) : base(haContext, entityId)
		{
		}

		public LightEntity(Entity entity) : base(entity)
		{
		}
	}

	public record LightAttributes : LightAttributesBase
	{
		[JsonPropertyName("color")]
		public object? Color { get; init; }

		[JsonPropertyName("linkquality")]
		public double? Linkquality { get; init; }
	}

	public partial record MediaPlayerEntity : Entity<MediaPlayerEntity, EntityState<MediaPlayerAttributes>, MediaPlayerAttributes>
	{
		public MediaPlayerEntity(IHaContext haContext, string entityId) : base(haContext, entityId)
		{
		}

		public MediaPlayerEntity(Entity entity) : base(entity)
		{
		}
	}

	public record MediaPlayerAttributes
	{
		[JsonPropertyName("app_name")]
		public string? AppName { get; init; }

		[JsonPropertyName("assumed_state")]
		public bool? AssumedState { get; init; }

		[JsonPropertyName("device_class")]
		public string? DeviceClass { get; init; }

		[JsonPropertyName("friendly_name")]
		public string? FriendlyName { get; init; }

		[JsonPropertyName("group_members")]
		public object? GroupMembers { get; init; }

		[JsonPropertyName("icon")]
		public string? Icon { get; init; }

		[JsonPropertyName("restored")]
		public bool? Restored { get; init; }

		[JsonPropertyName("sound_mode_list")]
		public object? SoundModeList { get; init; }

		[JsonPropertyName("source_list")]
		public object? SourceList { get; init; }

		[JsonPropertyName("supported_features")]
		public double? SupportedFeatures { get; init; }
	}

	public partial record NumberEntity : NumericEntity<NumberEntity, NumericEntityState<NumberAttributes>, NumberAttributes>
	{
		public NumberEntity(IHaContext haContext, string entityId) : base(haContext, entityId)
		{
		}

		public NumberEntity(Entity entity) : base(entity)
		{
		}
	}

	public record NumberAttributes
	{
		[JsonPropertyName("alarm")]
		public object? Alarm { get; init; }

		[JsonPropertyName("battery")]
		public double? Battery { get; init; }

		[JsonPropertyName("battery_low")]
		public bool? BatteryLow { get; init; }

		[JsonPropertyName("current_firmware")]
		public string? CurrentFirmware { get; init; }

		[JsonPropertyName("enrolled")]
		public bool? Enrolled { get; init; }

		[JsonPropertyName("fault")]
		public bool? Fault { get; init; }

		[JsonPropertyName("friendly_name")]
		public string? FriendlyName { get; init; }

		[JsonPropertyName("ias_cie_address")]
		public string? IasCieAddress { get; init; }

		[JsonPropertyName("icon")]
		public string? Icon { get; init; }

		[JsonPropertyName("linkquality")]
		public double? Linkquality { get; init; }

		[JsonPropertyName("max")]
		public double? Max { get; init; }

		[JsonPropertyName("max_duration")]
		public double? MaxDuration { get; init; }

		[JsonPropertyName("min")]
		public double? Min { get; init; }

		[JsonPropertyName("mode")]
		public string? Mode { get; init; }

		[JsonPropertyName("reliability")]
		public string? Reliability { get; init; }

		[JsonPropertyName("restored")]
		public bool? Restored { get; init; }

		[JsonPropertyName("restore_reports")]
		public bool? RestoreReports { get; init; }

		[JsonPropertyName("smoke")]
		public bool? Smoke { get; init; }

		[JsonPropertyName("step")]
		public double? Step { get; init; }

		[JsonPropertyName("supervision_reports")]
		public bool? SupervisionReports { get; init; }

		[JsonPropertyName("supported_features")]
		public double? SupportedFeatures { get; init; }

		[JsonPropertyName("temperature")]
		public double? Temperature { get; init; }

		[JsonPropertyName("test")]
		public bool? Test { get; init; }

		[JsonPropertyName("unit_of_measurement")]
		public string? UnitOfMeasurement { get; init; }

		[JsonPropertyName("update")]
		public object? Update { get; init; }

		[JsonPropertyName("update_available")]
		public object? UpdateAvailable { get; init; }

		[JsonPropertyName("voltage")]
		public double? Voltage { get; init; }

		[JsonPropertyName("zone_id")]
		public double? ZoneId { get; init; }
	}

	public partial record PersonEntity : Entity<PersonEntity, EntityState<PersonAttributes>, PersonAttributes>
	{
		public PersonEntity(IHaContext haContext, string entityId) : base(haContext, entityId)
		{
		}

		public PersonEntity(Entity entity) : base(entity)
		{
		}
	}

	public record PersonAttributes
	{
		[JsonPropertyName("editable")]
		public bool? Editable { get; init; }

		[JsonPropertyName("entity_picture")]
		public string? EntityPicture { get; init; }

		[JsonPropertyName("friendly_name")]
		public string? FriendlyName { get; init; }

		[JsonPropertyName("gps_accuracy")]
		public double? GpsAccuracy { get; init; }

		[JsonPropertyName("id")]
		public string? Id { get; init; }

		[JsonPropertyName("latitude")]
		public double? Latitude { get; init; }

		[JsonPropertyName("longitude")]
		public double? Longitude { get; init; }

		[JsonPropertyName("source")]
		public string? Source { get; init; }

		[JsonPropertyName("user_id")]
		public string? UserId { get; init; }
	}

	public partial record ProximityEntity : Entity<ProximityEntity, EntityState<ProximityAttributes>, ProximityAttributes>
	{
		public ProximityEntity(IHaContext haContext, string entityId) : base(haContext, entityId)
		{
		}

		public ProximityEntity(Entity entity) : base(entity)
		{
		}
	}

	public record ProximityAttributes
	{
		[JsonPropertyName("dir_of_travel")]
		public string? DirOfTravel { get; init; }

		[JsonPropertyName("friendly_name")]
		public string? FriendlyName { get; init; }

		[JsonPropertyName("nearest")]
		public string? Nearest { get; init; }

		[JsonPropertyName("unit_of_measurement")]
		public string? UnitOfMeasurement { get; init; }
	}

	public partial record RemoteEntity : Entity<RemoteEntity, EntityState<RemoteAttributes>, RemoteAttributes>
	{
		public RemoteEntity(IHaContext haContext, string entityId) : base(haContext, entityId)
		{
		}

		public RemoteEntity(Entity entity) : base(entity)
		{
		}
	}

	public record RemoteAttributes
	{
		[JsonPropertyName("friendly_name")]
		public string? FriendlyName { get; init; }

		[JsonPropertyName("supported_features")]
		public double? SupportedFeatures { get; init; }
	}

	public partial record SelectEntity : Entity<SelectEntity, EntityState<SelectAttributes>, SelectAttributes>
	{
		public SelectEntity(IHaContext haContext, string entityId) : base(haContext, entityId)
		{
		}

		public SelectEntity(Entity entity) : base(entity)
		{
		}
	}

	public record SelectAttributes
	{
		[JsonPropertyName("action")]
		public object? Action { get; init; }

		[JsonPropertyName("angle")]
		public double? Angle { get; init; }

		[JsonPropertyName("angle_x")]
		public double? AngleX { get; init; }

		[JsonPropertyName("angle_x_absolute")]
		public double? AngleXAbsolute { get; init; }

		[JsonPropertyName("angle_y")]
		public double? AngleY { get; init; }

		[JsonPropertyName("angle_y_absolute")]
		public double? AngleYAbsolute { get; init; }

		[JsonPropertyName("angle_z")]
		public double? AngleZ { get; init; }

		[JsonPropertyName("battery")]
		public double? Battery { get; init; }

		[JsonPropertyName("device_class")]
		public string? DeviceClass { get; init; }

		[JsonPropertyName("device_temperature")]
		public double? DeviceTemperature { get; init; }

		[JsonPropertyName("flip_indicator_light")]
		public string? FlipIndicatorLight { get; init; }

		[JsonPropertyName("friendly_name")]
		public string? FriendlyName { get; init; }

		[JsonPropertyName("icon")]
		public string? Icon { get; init; }

		[JsonPropertyName("illuminance")]
		public double? Illuminance { get; init; }

		[JsonPropertyName("illuminance_lux")]
		public double? IlluminanceLux { get; init; }

		[JsonPropertyName("linkquality")]
		public double? Linkquality { get; init; }

		[JsonPropertyName("operation_mode")]
		public object? OperationMode { get; init; }

		[JsonPropertyName("options")]
		public object? Options { get; init; }

		[JsonPropertyName("power_on_behavior")]
		public string? PowerOnBehavior { get; init; }

		[JsonPropertyName("power_outage_count")]
		public double? PowerOutageCount { get; init; }

		[JsonPropertyName("power_outage_memory")]
		public object? PowerOutageMemory { get; init; }

		[JsonPropertyName("sensitivity")]
		public string? Sensitivity { get; init; }

		[JsonPropertyName("strength")]
		public double? Strength { get; init; }

		[JsonPropertyName("update")]
		public object? Update { get; init; }

		[JsonPropertyName("update_available")]
		public object? UpdateAvailable { get; init; }

		[JsonPropertyName("vibration")]
		public bool? Vibration { get; init; }

		[JsonPropertyName("voltage")]
		public double? Voltage { get; init; }
	}

	public partial record NumericSensorEntity : NumericEntity<NumericSensorEntity, NumericEntityState<NumericSensorAttributes>, NumericSensorAttributes>
	{
		public NumericSensorEntity(IHaContext haContext, string entityId) : base(haContext, entityId)
		{
		}

		public NumericSensorEntity(Entity entity) : base(entity)
		{
		}
	}

	public record NumericSensorAttributes
	{
		[JsonPropertyName("action")]
		public object? Action { get; init; }

		[JsonPropertyName("alarm")]
		public object? Alarm { get; init; }

		[JsonPropertyName("angle")]
		public double? Angle { get; init; }

		[JsonPropertyName("angle_x")]
		public double? AngleX { get; init; }

		[JsonPropertyName("angle_x_absolute")]
		public double? AngleXAbsolute { get; init; }

		[JsonPropertyName("angle_y")]
		public double? AngleY { get; init; }

		[JsonPropertyName("angle_y_absolute")]
		public double? AngleYAbsolute { get; init; }

		[JsonPropertyName("angle_z")]
		public double? AngleZ { get; init; }

		[JsonPropertyName("attribution")]
		public string? Attribution { get; init; }

		[JsonPropertyName("battery")]
		public double? Battery { get; init; }

		[JsonPropertyName("battery_low")]
		public bool? BatteryLow { get; init; }

		[JsonPropertyName("brightness")]
		public double? Brightness { get; init; }

		[JsonPropertyName("bytes_received")]
		public double? BytesReceived { get; init; }

		[JsonPropertyName("bytes_sent")]
		public double? BytesSent { get; init; }

		[JsonPropertyName("color")]
		public object? Color { get; init; }

		[JsonPropertyName("color_mode")]
		public string? ColorMode { get; init; }

		[JsonPropertyName("color_temp")]
		public double? ColorTemp { get; init; }

		[JsonPropertyName("connected_not_paired_devices")]
		public object? ConnectedNotPairedDevices { get; init; }

		[JsonPropertyName("connected_paired_devices")]
		public object? ConnectedPairedDevices { get; init; }

		[JsonPropertyName("contact")]
		public bool? Contact { get; init; }

		[JsonPropertyName("cron pattern")]
		public string? Cronpattern { get; init; }

		[JsonPropertyName("current_firmware")]
		public string? CurrentFirmware { get; init; }

		[JsonPropertyName("device_class")]
		public string? DeviceClass { get; init; }

		[JsonPropertyName("device_temperature")]
		public double? DeviceTemperature { get; init; }

		[JsonPropertyName("end")]
		public double? End { get; init; }

		[JsonPropertyName("enrolled")]
		public bool? Enrolled { get; init; }

		[JsonPropertyName("fault")]
		public bool? Fault { get; init; }

		[JsonPropertyName("free_external_storage")]
		public string? FreeExternalStorage { get; init; }

		[JsonPropertyName("Free internal storage")]
		public string? Freeinternalstorage { get; init; }

		[JsonPropertyName("free_memory")]
		public double? FreeMemory { get; init; }

		[JsonPropertyName("friendly_name")]
		public string? FriendlyName { get; init; }

		[JsonPropertyName("humidity")]
		public double? Humidity { get; init; }

		[JsonPropertyName("ias_cie_address")]
		public string? IasCieAddress { get; init; }

		[JsonPropertyName("icon")]
		public string? Icon { get; init; }

		[JsonPropertyName("identifier")]
		public double? Identifier { get; init; }

		[JsonPropertyName("illuminance")]
		public double? Illuminance { get; init; }

		[JsonPropertyName("illuminance_lux")]
		public double? IlluminanceLux { get; init; }

		[JsonPropertyName("last_period")]
		public string? LastPeriod { get; init; }

		[JsonPropertyName("last_reset")]
		public string? LastReset { get; init; }

		[JsonPropertyName("light")]
		public double? Light { get; init; }

		[JsonPropertyName("linkquality")]
		public double? Linkquality { get; init; }

		[JsonPropertyName("marker_high_level")]
		public double? MarkerHighLevel { get; init; }

		[JsonPropertyName("marker_low_level")]
		public double? MarkerLowLevel { get; init; }

		[JsonPropertyName("marker_type")]
		public string? MarkerType { get; init; }

		[JsonPropertyName("max_duration")]
		public double? MaxDuration { get; init; }

		[JsonPropertyName("meter_period")]
		public string? MeterPeriod { get; init; }

		[JsonPropertyName("motion")]
		public double? Motion { get; init; }

		[JsonPropertyName("occupancy")]
		public bool? Occupancy { get; init; }

		[JsonPropertyName("paired_devices")]
		public object? PairedDevices { get; init; }

		[JsonPropertyName("power_on_behavior")]
		public string? PowerOnBehavior { get; init; }

		[JsonPropertyName("power_outage_count")]
		public object? PowerOutageCount { get; init; }

		[JsonPropertyName("pressure")]
		public double? Pressure { get; init; }

		[JsonPropertyName("reliability")]
		public string? Reliability { get; init; }

		[JsonPropertyName("repositories")]
		public object? Repositories { get; init; }

		[JsonPropertyName("restore_reports")]
		public bool? RestoreReports { get; init; }

		[JsonPropertyName("sensitivity")]
		public string? Sensitivity { get; init; }

		[JsonPropertyName("server_country")]
		public string? ServerCountry { get; init; }

		[JsonPropertyName("server_id")]
		public string? ServerId { get; init; }

		[JsonPropertyName("server_name")]
		public string? ServerName { get; init; }

		[JsonPropertyName("smoke")]
		public bool? Smoke { get; init; }

		[JsonPropertyName("source")]
		public string? Source { get; init; }

		[JsonPropertyName("start")]
		public double? Start { get; init; }

		[JsonPropertyName("state_bottom_left")]
		public string? StateBottomLeft { get; init; }

		[JsonPropertyName("state_bottom_right")]
		public string? StateBottomRight { get; init; }

		[JsonPropertyName("state_class")]
		public string? StateClass { get; init; }

		[JsonPropertyName("state_left")]
		public string? StateLeft { get; init; }

		[JsonPropertyName("state_left_left")]
		public string? StateLeftLeft { get; init; }

		[JsonPropertyName("state_right")]
		public string? StateRight { get; init; }

		[JsonPropertyName("status")]
		public string? Status { get; init; }

		[JsonPropertyName("strength")]
		public double? Strength { get; init; }

		[JsonPropertyName("supervision_reports")]
		public bool? SupervisionReports { get; init; }

		[JsonPropertyName("tamper")]
		public bool? Tamper { get; init; }

		[JsonPropertyName("temperature")]
		public double? Temperature { get; init; }

		[JsonPropertyName("test")]
		public bool? Test { get; init; }

		[JsonPropertyName("timestamp")]
		public double? Timestamp { get; init; }

		[JsonPropertyName("total_external_storage")]
		public string? TotalExternalStorage { get; init; }

		[JsonPropertyName("Total internal storage")]
		public string? Totalinternalstorage { get; init; }

		[JsonPropertyName("total_memory")]
		public double? TotalMemory { get; init; }

		[JsonPropertyName("unit_of_measurement")]
		public string? UnitOfMeasurement { get; init; }

		[JsonPropertyName("update")]
		public object? Update { get; init; }

		[JsonPropertyName("update_available")]
		public object? UpdateAvailable { get; init; }

		[JsonPropertyName("vibration")]
		public bool? Vibration { get; init; }

		[JsonPropertyName("voltage")]
		public double? Voltage { get; init; }

		[JsonPropertyName("water_leak")]
		public bool? WaterLeak { get; init; }

		[JsonPropertyName("zone_id")]
		public double? ZoneId { get; init; }
	}

	public partial record SensorEntity : Entity<SensorEntity, EntityState<SensorAttributes>, SensorAttributes>
	{
		public SensorEntity(IHaContext haContext, string entityId) : base(haContext, entityId)
		{
		}

		public SensorEntity(Entity entity) : base(entity)
		{
		}
	}

	public record SensorAttributes
	{
		[JsonPropertyName("action")]
		public object? Action { get; init; }

		[JsonPropertyName("administrative_area")]
		public string? AdministrativeArea { get; init; }

		[JsonPropertyName("Advertise mode")]
		public string? Advertisemode { get; init; }

		[JsonPropertyName("alarm")]
		public object? Alarm { get; init; }

		[JsonPropertyName("angle")]
		public double? Angle { get; init; }

		[JsonPropertyName("angle_x")]
		public double? AngleX { get; init; }

		[JsonPropertyName("angle_x_absolute")]
		public double? AngleXAbsolute { get; init; }

		[JsonPropertyName("angle_y")]
		public double? AngleY { get; init; }

		[JsonPropertyName("angle_y_absolute")]
		public double? AngleYAbsolute { get; init; }

		[JsonPropertyName("angle_z")]
		public double? AngleZ { get; init; }

		[JsonPropertyName("anti_crease")]
		public string? AntiCrease { get; init; }

		[JsonPropertyName("assumed_state")]
		public bool? AssumedState { get; init; }

		[JsonPropertyName("attribution")]
		public string? Attribution { get; init; }

		[JsonPropertyName("audio")]
		public string? Audio { get; init; }

		[JsonPropertyName("battery")]
		public double? Battery { get; init; }

		[JsonPropertyName("battery_low")]
		public bool? BatteryLow { get; init; }

		[JsonPropertyName("board")]
		public string? Board { get; init; }

		[JsonPropertyName("channel")]
		public string? Channel { get; init; }

		[JsonPropertyName("child_lock")]
		public string? ChildLock { get; init; }

		[JsonPropertyName("cli")]
		public string? Cli { get; init; }

		[JsonPropertyName("command_set")]
		public string? CommandSet { get; init; }

		[JsonPropertyName("country")]
		public string? Country { get; init; }

		[JsonPropertyName("crease_care")]
		public string? CreaseCare { get; init; }

		[JsonPropertyName("current_course")]
		public string? CurrentCourse { get; init; }

		[JsonPropertyName("current_firmware")]
		public string? CurrentFirmware { get; init; }

		[JsonPropertyName("damp_dry_beep")]
		public string? DampDryBeep { get; init; }

		[JsonPropertyName("days")]
		public double? Days { get; init; }

		[JsonPropertyName("device_class")]
		public string? DeviceClass { get; init; }

		[JsonPropertyName("device_temperature")]
		public double? DeviceTemperature { get; init; }

		[JsonPropertyName("distance")]
		public double? Distance { get; init; }

		[JsonPropertyName("dns")]
		public string? Dns { get; init; }

		[JsonPropertyName("door_lock")]
		public string? DoorLock { get; init; }

		[JsonPropertyName("door_open")]
		public string? DoorOpen { get; init; }

		[JsonPropertyName("dry_level")]
		public string? DryLevel { get; init; }

		[JsonPropertyName("eco_hybrid")]
		public string? EcoHybrid { get; init; }

		[JsonPropertyName("enrolled")]
		public bool? Enrolled { get; init; }

		[JsonPropertyName("error_message")]
		public string? ErrorMessage { get; init; }

		[JsonPropertyName("error_state")]
		public string? ErrorState { get; init; }

		[JsonPropertyName("express_freeze")]
		public string? ExpressFreeze { get; init; }

		[JsonPropertyName("fault")]
		public bool? Fault { get; init; }

		[JsonPropertyName("flip_indicator_light")]
		public string? FlipIndicatorLight { get; init; }

		[JsonPropertyName("freezer_temp")]
		public string? FreezerTemp { get; init; }

		[JsonPropertyName("fridge_temp")]
		public string? FridgeTemp { get; init; }

		[JsonPropertyName("friendly_name")]
		public string? FriendlyName { get; init; }

		[JsonPropertyName("hand_iron")]
		public string? HandIron { get; init; }

		[JsonPropertyName("ias_cie_address")]
		public string? IasCieAddress { get; init; }

		[JsonPropertyName("icon")]
		public string? Icon { get; init; }

		[JsonPropertyName("id")]
		public string? Id { get; init; }

		[JsonPropertyName("identifier")]
		public double? Identifier { get; init; }

		[JsonPropertyName("illuminance")]
		public double? Illuminance { get; init; }

		[JsonPropertyName("illuminance_lux")]
		public double? IlluminanceLux { get; init; }

		[JsonPropertyName("image")]
		public string? Image { get; init; }

		[JsonPropertyName("in_daylight_time")]
		public bool? InDaylightTime { get; init; }

		[JsonPropertyName("info")]
		public string? Info { get; init; }

		[JsonPropertyName("initial_time")]
		public string? InitialTime { get; init; }

		[JsonPropertyName("is_hidden")]
		public bool? IsHidden { get; init; }

		[JsonPropertyName("iso_country_code")]
		public string? IsoCountryCode { get; init; }

		[JsonPropertyName("last_collection")]
		public object? LastCollection { get; init; }

		[JsonPropertyName("last_updated")]
		public string? LastUpdated { get; init; }

		[JsonPropertyName("latitude")]
		public double? Latitude { get; init; }

		[JsonPropertyName("linkquality")]
		public double? Linkquality { get; init; }

		[JsonPropertyName("locality")]
		public string? Locality { get; init; }

		[JsonPropertyName("Local Time")]
		public string? LocalTime { get; init; }

		[JsonPropertyName("location")]
		public string? Location { get; init; }

		[JsonPropertyName("longitude")]
		public double? Longitude { get; init; }

		[JsonPropertyName("mac")]
		public string? Mac { get; init; }

		[JsonPropertyName("max_duration")]
		public double? MaxDuration { get; init; }

		[JsonPropertyName("Measured power")]
		public double? Measuredpower { get; init; }

		[JsonPropertyName("medic_rinse")]
		public string? MedicRinse { get; init; }

		[JsonPropertyName("multicast")]
		public string? Multicast { get; init; }

		[JsonPropertyName("nearest")]
		public string? Nearest { get; init; }

		[JsonPropertyName("next_date")]
		public string? NextDate { get; init; }

		[JsonPropertyName("observer")]
		public string? Observer { get; init; }

		[JsonPropertyName("operation_mode")]
		public object? OperationMode { get; init; }

		[JsonPropertyName("os")]
		public string? Os { get; init; }

		[JsonPropertyName("postal_code")]
		public string? PostalCode { get; init; }

		[JsonPropertyName("power_on_behavior")]
		public string? PowerOnBehavior { get; init; }

		[JsonPropertyName("power_outage_count")]
		public double? PowerOutageCount { get; init; }

		[JsonPropertyName("power_outage_memory")]
		public object? PowerOutageMemory { get; init; }

		[JsonPropertyName("pre_state")]
		public string? PreState { get; init; }

		[JsonPropertyName("pre_wash")]
		public string? PreWash { get; init; }

		[JsonPropertyName("process_state")]
		public string? ProcessState { get; init; }

		[JsonPropertyName("Querytype")]
		public string? Querytype { get; init; }

		[JsonPropertyName("reliability")]
		public string? Reliability { get; init; }

		[JsonPropertyName("remain_time")]
		public string? RemainTime { get; init; }

		[JsonPropertyName("remote_start")]
		public string? RemoteStart { get; init; }

		[JsonPropertyName("reservation")]
		public string? Reservation { get; init; }

		[JsonPropertyName("reserve_time")]
		public string? ReserveTime { get; init; }

		[JsonPropertyName("Resolver")]
		public string? Resolver { get; init; }

		[JsonPropertyName("restore_reports")]
		public bool? RestoreReports { get; init; }

		[JsonPropertyName("rssi_bedroom")]
		public double? RssiBedroom { get; init; }

		[JsonPropertyName("rssi_child_room")]
		public double? RssiChildRoom { get; init; }

		[JsonPropertyName("rssi_kitchen")]
		public object? RssiKitchen { get; init; }

		[JsonPropertyName("rssi_living_room")]
		public object? RssiLivingRoom { get; init; }

		[JsonPropertyName("rssi_living_room_2")]
		public object? RssiLivingRoom2 { get; init; }

		[JsonPropertyName("rssi_office")]
		public double? RssiOffice { get; init; }

		[JsonPropertyName("rssi_shed")]
		public object? RssiShed { get; init; }

		[JsonPropertyName("rssi_tech_room")]
		public object? RssiTechRoom { get; init; }

		[JsonPropertyName("run_completed")]
		public string? RunCompleted { get; init; }

		[JsonPropertyName("run_state")]
		public string? RunState { get; init; }

		[JsonPropertyName("sensitivity")]
		public string? Sensitivity { get; init; }

		[JsonPropertyName("serial")]
		public object? Serial { get; init; }

		[JsonPropertyName("smoke")]
		public bool? Smoke { get; init; }

		[JsonPropertyName("source")]
		public string? Source { get; init; }

		[JsonPropertyName("spin_speed")]
		public string? SpinSpeed { get; init; }

		[JsonPropertyName("standby")]
		public string? Standby { get; init; }

		[JsonPropertyName("state_message")]
		public string? StateMessage { get; init; }

		[JsonPropertyName("state_reason")]
		public object? StateReason { get; init; }

		[JsonPropertyName("still")]
		public double? Still { get; init; }

		[JsonPropertyName("strength")]
		public double? Strength { get; init; }

		[JsonPropertyName("sub_administrative_area")]
		public string? SubAdministrativeArea { get; init; }

		[JsonPropertyName("sub_locality")]
		public string? SubLocality { get; init; }

		[JsonPropertyName("sub_thoroughfare")]
		public string? SubThoroughfare { get; init; }

		[JsonPropertyName("supervision_reports")]
		public bool? SupervisionReports { get; init; }

		[JsonPropertyName("supervisor")]
		public string? Supervisor { get; init; }

		[JsonPropertyName("supported_features")]
		public double? SupportedFeatures { get; init; }

		[JsonPropertyName("Supports transmitter")]
		public bool? Supportstransmitter { get; init; }

		[JsonPropertyName("tamper")]
		public bool? Tamper { get; init; }

		[JsonPropertyName("temperature")]
		public double? Temperature { get; init; }

		[JsonPropertyName("temp_unit")]
		public string? TempUnit { get; init; }

		[JsonPropertyName("test")]
		public bool? Test { get; init; }

		[JsonPropertyName("thoroughfare")]
		public string? Thoroughfare { get; init; }

		[JsonPropertyName("Time in Milliseconds")]
		public double? TimeinMilliseconds { get; init; }

		[JsonPropertyName("time_zone_id")]
		public string? TimeZoneId { get; init; }

		[JsonPropertyName("time_zone_short")]
		public string? TimeZoneShort { get; init; }

		[JsonPropertyName("Transmitting power")]
		public string? Transmittingpower { get; init; }

		[JsonPropertyName("tubclean_count")]
		public string? TubcleanCount { get; init; }

		[JsonPropertyName("turbo_wash")]
		public string? TurboWash { get; init; }

		[JsonPropertyName("update")]
		public object? Update { get; init; }

		[JsonPropertyName("update_available")]
		public object? UpdateAvailable { get; init; }

		[JsonPropertyName("uri_supported")]
		public object? UriSupported { get; init; }

		[JsonPropertyName("uses_daylight_time")]
		public bool? UsesDaylightTime { get; init; }

		[JsonPropertyName("utc_offset")]
		public double? UtcOffset { get; init; }

		[JsonPropertyName("vibration")]
		public bool? Vibration { get; init; }

		[JsonPropertyName("voltage")]
		public double? Voltage { get; init; }

		[JsonPropertyName("water_leak")]
		public bool? WaterLeak { get; init; }

		[JsonPropertyName("water_temp")]
		public string? WaterTemp { get; init; }

		[JsonPropertyName("zone_id")]
		public double? ZoneId { get; init; }
	}

	public partial record SunEntity : Entity<SunEntity, EntityState<SunAttributes>, SunAttributes>
	{
		public SunEntity(IHaContext haContext, string entityId) : base(haContext, entityId)
		{
		}

		public SunEntity(Entity entity) : base(entity)
		{
		}
	}

	public record SunAttributes
	{
		[JsonPropertyName("azimuth")]
		public double? Azimuth { get; init; }

		[JsonPropertyName("elevation")]
		public double? Elevation { get; init; }

		[JsonPropertyName("friendly_name")]
		public string? FriendlyName { get; init; }

		[JsonPropertyName("next_dawn")]
		public string? NextDawn { get; init; }

		[JsonPropertyName("next_dusk")]
		public string? NextDusk { get; init; }

		[JsonPropertyName("next_midnight")]
		public string? NextMidnight { get; init; }

		[JsonPropertyName("next_noon")]
		public string? NextNoon { get; init; }

		[JsonPropertyName("next_rising")]
		public string? NextRising { get; init; }

		[JsonPropertyName("next_setting")]
		public string? NextSetting { get; init; }

		[JsonPropertyName("rising")]
		public bool? Rising { get; init; }
	}

	public partial record SwitchEntity : Entity<SwitchEntity, EntityState<SwitchAttributes>, SwitchAttributes>
	{
		public SwitchEntity(IHaContext haContext, string entityId) : base(haContext, entityId)
		{
		}

		public SwitchEntity(Entity entity) : base(entity)
		{
		}
	}

	public record SwitchAttributes
	{
		[JsonPropertyName("action")]
		public object? Action { get; init; }

		[JsonPropertyName("alarm")]
		public object? Alarm { get; init; }

		[JsonPropertyName("attribution")]
		public string? Attribution { get; init; }

		[JsonPropertyName("battery")]
		public double? Battery { get; init; }

		[JsonPropertyName("battery_low")]
		public bool? BatteryLow { get; init; }

		[JsonPropertyName("current_firmware")]
		public string? CurrentFirmware { get; init; }

		[JsonPropertyName("device_class")]
		public string? DeviceClass { get; init; }

		[JsonPropertyName("device_temperature")]
		public double? DeviceTemperature { get; init; }

		[JsonPropertyName("enrolled")]
		public bool? Enrolled { get; init; }

		[JsonPropertyName("fault")]
		public bool? Fault { get; init; }

		[JsonPropertyName("flip_indicator_light")]
		public string? FlipIndicatorLight { get; init; }

		[JsonPropertyName("friendly_name")]
		public string? FriendlyName { get; init; }

		[JsonPropertyName("ias_cie_address")]
		public string? IasCieAddress { get; init; }

		[JsonPropertyName("icon")]
		public string? Icon { get; init; }

		[JsonPropertyName("identifier")]
		public double? Identifier { get; init; }

		[JsonPropertyName("illuminance")]
		public double? Illuminance { get; init; }

		[JsonPropertyName("illuminance_lux")]
		public double? IlluminanceLux { get; init; }

		[JsonPropertyName("linkquality")]
		public double? Linkquality { get; init; }

		[JsonPropertyName("max_duration")]
		public double? MaxDuration { get; init; }

		[JsonPropertyName("operation_mode")]
		public object? OperationMode { get; init; }

		[JsonPropertyName("power_on_behavior")]
		public string? PowerOnBehavior { get; init; }

		[JsonPropertyName("power_outage_count")]
		public double? PowerOutageCount { get; init; }

		[JsonPropertyName("power_outage_memory")]
		public object? PowerOutageMemory { get; init; }

		[JsonPropertyName("reliability")]
		public string? Reliability { get; init; }

		[JsonPropertyName("restored")]
		public bool? Restored { get; init; }

		[JsonPropertyName("restore_reports")]
		public bool? RestoreReports { get; init; }

		[JsonPropertyName("smoke")]
		public bool? Smoke { get; init; }

		[JsonPropertyName("state_bottom_left")]
		public string? StateBottomLeft { get; init; }

		[JsonPropertyName("state_bottom_right")]
		public string? StateBottomRight { get; init; }

		[JsonPropertyName("state_left")]
		public string? StateLeft { get; init; }

		[JsonPropertyName("state_left_left")]
		public string? StateLeftLeft { get; init; }

		[JsonPropertyName("state_right")]
		public string? StateRight { get; init; }

		[JsonPropertyName("supervision_reports")]
		public bool? SupervisionReports { get; init; }

		[JsonPropertyName("supported_features")]
		public double? SupportedFeatures { get; init; }

		[JsonPropertyName("temperature")]
		public double? Temperature { get; init; }

		[JsonPropertyName("test")]
		public bool? Test { get; init; }

		[JsonPropertyName("update")]
		public object? Update { get; init; }

		[JsonPropertyName("update_available")]
		public object? UpdateAvailable { get; init; }

		[JsonPropertyName("voltage")]
		public double? Voltage { get; init; }

		[JsonPropertyName("zone_id")]
		public double? ZoneId { get; init; }
	}

	public partial record TimerEntity : Entity<TimerEntity, EntityState<TimerAttributes>, TimerAttributes>
	{
		public TimerEntity(IHaContext haContext, string entityId) : base(haContext, entityId)
		{
		}

		public TimerEntity(Entity entity) : base(entity)
		{
		}
	}

	public record TimerAttributes
	{
		[JsonPropertyName("duration")]
		public string? Duration { get; init; }

		[JsonPropertyName("editable")]
		public bool? Editable { get; init; }

		[JsonPropertyName("friendly_name")]
		public string? FriendlyName { get; init; }
	}

	public partial record UpdateEntity : Entity<UpdateEntity, EntityState<UpdateAttributes>, UpdateAttributes>
	{
		public UpdateEntity(IHaContext haContext, string entityId) : base(haContext, entityId)
		{
		}

		public UpdateEntity(Entity entity) : base(entity)
		{
		}
	}

	public record UpdateAttributes
	{
		[JsonPropertyName("auto_update")]
		public bool? AutoUpdate { get; init; }

		[JsonPropertyName("entity_picture")]
		public string? EntityPicture { get; init; }

		[JsonPropertyName("friendly_name")]
		public string? FriendlyName { get; init; }

		[JsonPropertyName("in_progress")]
		public bool? InProgress { get; init; }

		[JsonPropertyName("installed_version")]
		public string? InstalledVersion { get; init; }

		[JsonPropertyName("latest_version")]
		public string? LatestVersion { get; init; }

		[JsonPropertyName("release_summary")]
		public string? ReleaseSummary { get; init; }

		[JsonPropertyName("release_url")]
		public string? ReleaseUrl { get; init; }

		[JsonPropertyName("skipped_version")]
		public object? SkippedVersion { get; init; }

		[JsonPropertyName("supported_features")]
		public double? SupportedFeatures { get; init; }

		[JsonPropertyName("title")]
		public string? Title { get; init; }
	}

	public partial record VacuumEntity : Entity<VacuumEntity, EntityState<VacuumAttributes>, VacuumAttributes>
	{
		public VacuumEntity(IHaContext haContext, string entityId) : base(haContext, entityId)
		{
		}

		public VacuumEntity(Entity entity) : base(entity)
		{
		}
	}

	public record VacuumAttributes
	{
		[JsonPropertyName("battery_icon")]
		public string? BatteryIcon { get; init; }

		[JsonPropertyName("battery_level")]
		public double? BatteryLevel { get; init; }

		[JsonPropertyName("fan_speed")]
		public string? FanSpeed { get; init; }

		[JsonPropertyName("fan_speed_list")]
		public object? FanSpeedList { get; init; }

		[JsonPropertyName("friendly_name")]
		public string? FriendlyName { get; init; }

		[JsonPropertyName("status")]
		public string? Status { get; init; }

		[JsonPropertyName("supported_features")]
		public double? SupportedFeatures { get; init; }
	}

	public partial record WeatherEntity : Entity<WeatherEntity, EntityState<WeatherAttributes>, WeatherAttributes>
	{
		public WeatherEntity(IHaContext haContext, string entityId) : base(haContext, entityId)
		{
		}

		public WeatherEntity(Entity entity) : base(entity)
		{
		}
	}

	public record WeatherAttributes
	{
		[JsonPropertyName("attribution")]
		public string? Attribution { get; init; }

		[JsonPropertyName("forecast")]
		public object? Forecast { get; init; }

		[JsonPropertyName("friendly_name")]
		public string? FriendlyName { get; init; }

		[JsonPropertyName("humidity")]
		public double? Humidity { get; init; }

		[JsonPropertyName("pressure")]
		public double? Pressure { get; init; }

		[JsonPropertyName("temperature")]
		public double? Temperature { get; init; }

		[JsonPropertyName("wind_bearing")]
		public double? WindBearing { get; init; }

		[JsonPropertyName("wind_speed")]
		public double? WindSpeed { get; init; }
	}

	public partial record ZoneEntity : Entity<ZoneEntity, EntityState<ZoneAttributes>, ZoneAttributes>
	{
		public ZoneEntity(IHaContext haContext, string entityId) : base(haContext, entityId)
		{
		}

		public ZoneEntity(Entity entity) : base(entity)
		{
		}
	}

	public record ZoneAttributes
	{
		[JsonPropertyName("editable")]
		public bool? Editable { get; init; }

		[JsonPropertyName("friendly_name")]
		public string? FriendlyName { get; init; }

		[JsonPropertyName("icon")]
		public string? Icon { get; init; }

		[JsonPropertyName("latitude")]
		public double? Latitude { get; init; }

		[JsonPropertyName("longitude")]
		public double? Longitude { get; init; }

		[JsonPropertyName("passive")]
		public bool? Passive { get; init; }

		[JsonPropertyName("persons")]
		public object? Persons { get; init; }

		[JsonPropertyName("radius")]
		public double? Radius { get; init; }
	}

	public interface IServices
	{
		AlarmControlPanelServices AlarmControlPanel { get; }

		AutomationServices Automation { get; }

		BrowserModServices BrowserMod { get; }

		ButtonServices Button { get; }

		CameraServices Camera { get; }

		CastServices Cast { get; }

		ClimateServices Climate { get; }

		CloudServices Cloud { get; }

		CounterServices Counter { get; }

		CoverServices Cover { get; }

		DeviceTrackerServices DeviceTracker { get; }

		FanServices Fan { get; }

		FrontendServices Frontend { get; }

		GarbageCollectionServices GarbageCollection { get; }

		GoogleServices Google { get; }

		GroupServices Group { get; }

		HassioServices Hassio { get; }

		HomeassistantServices Homeassistant { get; }

		HumidifierServices Humidifier { get; }

		InputBooleanServices InputBoolean { get; }

		InputButtonServices InputButton { get; }

		InputDatetimeServices InputDatetime { get; }

		InputNumberServices InputNumber { get; }

		InputSelectServices InputSelect { get; }

		InputTextServices InputText { get; }

		LightServices Light { get; }

		LockServices Lock { get; }

		LogbookServices Logbook { get; }

		MediaPlayerServices MediaPlayer { get; }

		MqttServices Mqtt { get; }

		NotifyServices Notify { get; }

		NumberServices Number { get; }

		PersistentNotificationServices PersistentNotification { get; }

		PersonServices Person { get; }

		RecorderServices Recorder { get; }

		RemoteServices Remote { get; }

		RestCommandServices RestCommand { get; }

		SceneServices Scene { get; }

		ScriptServices Script { get; }

		SelectServices Select { get; }

		ShoppingListServices ShoppingList { get; }

		SirenServices Siren { get; }

		SmartthinqSensorsServices SmartthinqSensors { get; }

		SpeedtestdotnetServices Speedtestdotnet { get; }

		SwitchServices Switch { get; }

		SystemLogServices SystemLog { get; }

		TemplateServices Template { get; }

		TimerServices Timer { get; }

		TrendServices Trend { get; }

		TtsServices Tts { get; }

		UpdateServices Update { get; }

		UtilityMeterServices UtilityMeter { get; }

		VacuumServices Vacuum { get; }

		WakeOnLanServices WakeOnLan { get; }

		WebostvServices Webostv { get; }

		XiaomiMiioServices XiaomiMiio { get; }

		ZoneServices Zone { get; }
	}

	public class Services : IServices
	{
		private readonly IHaContext _haContext;
		public Services(IHaContext haContext)
		{
			_haContext = haContext;
		}

		public AlarmControlPanelServices AlarmControlPanel => new(_haContext);
		public AutomationServices Automation => new(_haContext);
		public BrowserModServices BrowserMod => new(_haContext);
		public ButtonServices Button => new(_haContext);
		public CameraServices Camera => new(_haContext);
		public CastServices Cast => new(_haContext);
		public ClimateServices Climate => new(_haContext);
		public CloudServices Cloud => new(_haContext);
		public CounterServices Counter => new(_haContext);
		public CoverServices Cover => new(_haContext);
		public DeviceTrackerServices DeviceTracker => new(_haContext);
		public FanServices Fan => new(_haContext);
		public FrontendServices Frontend => new(_haContext);
		public GarbageCollectionServices GarbageCollection => new(_haContext);
		public GoogleServices Google => new(_haContext);
		public GroupServices Group => new(_haContext);
		public HassioServices Hassio => new(_haContext);
		public HomeassistantServices Homeassistant => new(_haContext);
		public HumidifierServices Humidifier => new(_haContext);
		public InputBooleanServices InputBoolean => new(_haContext);
		public InputButtonServices InputButton => new(_haContext);
		public InputDatetimeServices InputDatetime => new(_haContext);
		public InputNumberServices InputNumber => new(_haContext);
		public InputSelectServices InputSelect => new(_haContext);
		public InputTextServices InputText => new(_haContext);
		public LightServices Light => new(_haContext);
		public LockServices Lock => new(_haContext);
		public LogbookServices Logbook => new(_haContext);
		public MediaPlayerServices MediaPlayer => new(_haContext);
		public MqttServices Mqtt => new(_haContext);
		public NotifyServices Notify => new(_haContext);
		public NumberServices Number => new(_haContext);
		public PersistentNotificationServices PersistentNotification => new(_haContext);
		public PersonServices Person => new(_haContext);
		public RecorderServices Recorder => new(_haContext);
		public RemoteServices Remote => new(_haContext);
		public RestCommandServices RestCommand => new(_haContext);
		public SceneServices Scene => new(_haContext);
		public ScriptServices Script => new(_haContext);
		public SelectServices Select => new(_haContext);
		public ShoppingListServices ShoppingList => new(_haContext);
		public SirenServices Siren => new(_haContext);
		public SmartthinqSensorsServices SmartthinqSensors => new(_haContext);
		public SpeedtestdotnetServices Speedtestdotnet => new(_haContext);
		public SwitchServices Switch => new(_haContext);
		public SystemLogServices SystemLog => new(_haContext);
		public TemplateServices Template => new(_haContext);
		public TimerServices Timer => new(_haContext);
		public TrendServices Trend => new(_haContext);
		public TtsServices Tts => new(_haContext);
		public UpdateServices Update => new(_haContext);
		public UtilityMeterServices UtilityMeter => new(_haContext);
		public VacuumServices Vacuum => new(_haContext);
		public WakeOnLanServices WakeOnLan => new(_haContext);
		public WebostvServices Webostv => new(_haContext);
		public XiaomiMiioServices XiaomiMiio => new(_haContext);
		public ZoneServices Zone => new(_haContext);
	}

	public class AlarmControlPanelServices
	{
		private readonly IHaContext _haContext;
		public AlarmControlPanelServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Send the alarm the command for arm away.</summary>
		///<param name="target">The target for this service call</param>
		public void AlarmArmAway(ServiceTarget target, AlarmControlPanelAlarmArmAwayParameters data)
		{
			_haContext.CallService("alarm_control_panel", "alarm_arm_away", target, data);
		}

		///<summary>Send the alarm the command for arm away.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="code">An optional code to arm away the alarm control panel with. eg: 1234</param>
		public void AlarmArmAway(ServiceTarget target, string? @code = null)
		{
			_haContext.CallService("alarm_control_panel", "alarm_arm_away", target, new AlarmControlPanelAlarmArmAwayParameters{Code = @code});
		}

		///<summary>Send arm custom bypass command.</summary>
		///<param name="target">The target for this service call</param>
		public void AlarmArmCustomBypass(ServiceTarget target, AlarmControlPanelAlarmArmCustomBypassParameters data)
		{
			_haContext.CallService("alarm_control_panel", "alarm_arm_custom_bypass", target, data);
		}

		///<summary>Send arm custom bypass command.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="code">An optional code to arm custom bypass the alarm control panel with. eg: 1234</param>
		public void AlarmArmCustomBypass(ServiceTarget target, string? @code = null)
		{
			_haContext.CallService("alarm_control_panel", "alarm_arm_custom_bypass", target, new AlarmControlPanelAlarmArmCustomBypassParameters{Code = @code});
		}

		///<summary>Send the alarm the command for arm home.</summary>
		///<param name="target">The target for this service call</param>
		public void AlarmArmHome(ServiceTarget target, AlarmControlPanelAlarmArmHomeParameters data)
		{
			_haContext.CallService("alarm_control_panel", "alarm_arm_home", target, data);
		}

		///<summary>Send the alarm the command for arm home.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="code">An optional code to arm home the alarm control panel with. eg: 1234</param>
		public void AlarmArmHome(ServiceTarget target, string? @code = null)
		{
			_haContext.CallService("alarm_control_panel", "alarm_arm_home", target, new AlarmControlPanelAlarmArmHomeParameters{Code = @code});
		}

		///<summary>Send the alarm the command for arm night.</summary>
		///<param name="target">The target for this service call</param>
		public void AlarmArmNight(ServiceTarget target, AlarmControlPanelAlarmArmNightParameters data)
		{
			_haContext.CallService("alarm_control_panel", "alarm_arm_night", target, data);
		}

		///<summary>Send the alarm the command for arm night.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="code">An optional code to arm night the alarm control panel with. eg: 1234</param>
		public void AlarmArmNight(ServiceTarget target, string? @code = null)
		{
			_haContext.CallService("alarm_control_panel", "alarm_arm_night", target, new AlarmControlPanelAlarmArmNightParameters{Code = @code});
		}

		///<summary>Send the alarm the command for arm vacation.</summary>
		///<param name="target">The target for this service call</param>
		public void AlarmArmVacation(ServiceTarget target, AlarmControlPanelAlarmArmVacationParameters data)
		{
			_haContext.CallService("alarm_control_panel", "alarm_arm_vacation", target, data);
		}

		///<summary>Send the alarm the command for arm vacation.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="code">An optional code to arm vacation the alarm control panel with. eg: 1234</param>
		public void AlarmArmVacation(ServiceTarget target, string? @code = null)
		{
			_haContext.CallService("alarm_control_panel", "alarm_arm_vacation", target, new AlarmControlPanelAlarmArmVacationParameters{Code = @code});
		}

		///<summary>Send the alarm the command for disarm.</summary>
		///<param name="target">The target for this service call</param>
		public void AlarmDisarm(ServiceTarget target, AlarmControlPanelAlarmDisarmParameters data)
		{
			_haContext.CallService("alarm_control_panel", "alarm_disarm", target, data);
		}

		///<summary>Send the alarm the command for disarm.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="code">An optional code to disarm the alarm control panel with. eg: 1234</param>
		public void AlarmDisarm(ServiceTarget target, string? @code = null)
		{
			_haContext.CallService("alarm_control_panel", "alarm_disarm", target, new AlarmControlPanelAlarmDisarmParameters{Code = @code});
		}

		///<summary>Send the alarm the command for trigger.</summary>
		///<param name="target">The target for this service call</param>
		public void AlarmTrigger(ServiceTarget target, AlarmControlPanelAlarmTriggerParameters data)
		{
			_haContext.CallService("alarm_control_panel", "alarm_trigger", target, data);
		}

		///<summary>Send the alarm the command for trigger.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="code">An optional code to trigger the alarm control panel with. eg: 1234</param>
		public void AlarmTrigger(ServiceTarget target, string? @code = null)
		{
			_haContext.CallService("alarm_control_panel", "alarm_trigger", target, new AlarmControlPanelAlarmTriggerParameters{Code = @code});
		}
	}

	public record AlarmControlPanelAlarmArmAwayParameters
	{
		///<summary>An optional code to arm away the alarm control panel with. eg: 1234</summary>
		[JsonPropertyName("code")]
		public string? Code { get; init; }
	}

	public record AlarmControlPanelAlarmArmCustomBypassParameters
	{
		///<summary>An optional code to arm custom bypass the alarm control panel with. eg: 1234</summary>
		[JsonPropertyName("code")]
		public string? Code { get; init; }
	}

	public record AlarmControlPanelAlarmArmHomeParameters
	{
		///<summary>An optional code to arm home the alarm control panel with. eg: 1234</summary>
		[JsonPropertyName("code")]
		public string? Code { get; init; }
	}

	public record AlarmControlPanelAlarmArmNightParameters
	{
		///<summary>An optional code to arm night the alarm control panel with. eg: 1234</summary>
		[JsonPropertyName("code")]
		public string? Code { get; init; }
	}

	public record AlarmControlPanelAlarmArmVacationParameters
	{
		///<summary>An optional code to arm vacation the alarm control panel with. eg: 1234</summary>
		[JsonPropertyName("code")]
		public string? Code { get; init; }
	}

	public record AlarmControlPanelAlarmDisarmParameters
	{
		///<summary>An optional code to disarm the alarm control panel with. eg: 1234</summary>
		[JsonPropertyName("code")]
		public string? Code { get; init; }
	}

	public record AlarmControlPanelAlarmTriggerParameters
	{
		///<summary>An optional code to trigger the alarm control panel with. eg: 1234</summary>
		[JsonPropertyName("code")]
		public string? Code { get; init; }
	}

	public class AutomationServices
	{
		private readonly IHaContext _haContext;
		public AutomationServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Reload the automation configuration.</summary>
		public void Reload()
		{
			_haContext.CallService("automation", "reload", null);
		}

		///<summary>Toggle (enable / disable) an automation.</summary>
		///<param name="target">The target for this service call</param>
		public void Toggle(ServiceTarget target)
		{
			_haContext.CallService("automation", "toggle", target);
		}

		///<summary>Trigger the actions of an automation.</summary>
		///<param name="target">The target for this service call</param>
		public void Trigger(ServiceTarget target, AutomationTriggerParameters data)
		{
			_haContext.CallService("automation", "trigger", target, data);
		}

		///<summary>Trigger the actions of an automation.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="skipCondition">Whether or not the conditions will be skipped.</param>
		public void Trigger(ServiceTarget target, bool? @skipCondition = null)
		{
			_haContext.CallService("automation", "trigger", target, new AutomationTriggerParameters{SkipCondition = @skipCondition});
		}

		///<summary>Disable an automation.</summary>
		///<param name="target">The target for this service call</param>
		public void TurnOff(ServiceTarget target, AutomationTurnOffParameters data)
		{
			_haContext.CallService("automation", "turn_off", target, data);
		}

		///<summary>Disable an automation.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="stopActions">Stop currently running actions.</param>
		public void TurnOff(ServiceTarget target, bool? @stopActions = null)
		{
			_haContext.CallService("automation", "turn_off", target, new AutomationTurnOffParameters{StopActions = @stopActions});
		}

		///<summary>Enable an automation.</summary>
		///<param name="target">The target for this service call</param>
		public void TurnOn(ServiceTarget target)
		{
			_haContext.CallService("automation", "turn_on", target);
		}
	}

	public record AutomationTriggerParameters
	{
		///<summary>Whether or not the conditions will be skipped.</summary>
		[JsonPropertyName("skip_condition")]
		public bool? SkipCondition { get; init; }
	}

	public record AutomationTurnOffParameters
	{
		///<summary>Stop currently running actions.</summary>
		[JsonPropertyName("stop_actions")]
		public bool? StopActions { get; init; }
	}

	public class BrowserModServices
	{
		private readonly IHaContext _haContext;
		public BrowserModServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Cover screen in black until the mouse is moved or a key is pressed.</summary>
		public void Blackout(BrowserModBlackoutParameters data)
		{
			_haContext.CallService("browser_mod", "blackout", null, data);
		}

		///<summary>Cover screen in black until the mouse is moved or a key is pressed.</summary>
		///<param name="time">(optional) The blackout will turn on automatically after the specified number of seconds. It works kind of like a screensaver and will keep turning on until blackout is called again with time: -1. eg: 20</param>
		///<param name="deviceID">(optional) List of receiving browsers eg: ["99980b13-dabc9563", "office_computer"]</param>
		public void Blackout(object? @time = null, object? @deviceID = null)
		{
			_haContext.CallService("browser_mod", "blackout", null, new BrowserModBlackoutParameters{Time = @time, DeviceID = @deviceID});
		}

		public void CallService()
		{
			_haContext.CallService("browser_mod", "call_service", null);
		}

		public void CleanDevices()
		{
			_haContext.CallService("browser_mod", "clean_devices", null);
		}

		///<summary>Close all popups on all browsers.</summary>
		public void ClosePopup(BrowserModClosePopupParameters data)
		{
			_haContext.CallService("browser_mod", "close_popup", null, data);
		}

		///<summary>Close all popups on all browsers.</summary>
		///<param name="deviceID">(optional) List of receiving browsers eg: ["99980b13-dabc9563", "office_computer"]</param>
		public void ClosePopup(object? @deviceID = null)
		{
			_haContext.CallService("browser_mod", "close_popup", null, new BrowserModClosePopupParameters{DeviceID = @deviceID});
		}

		///<summary>Send a command to a browser.</summary>
		public void Command(BrowserModCommandParameters data)
		{
			_haContext.CallService("browser_mod", "command", null, data);
		}

		///<summary>Send a command to a browser.</summary>
		///<param name="command">Command to send eg: navigate</param>
		///<param name="deviceID">(optional) List of receiving browsers eg: ["99980b13-dabc9563", "office_computer"]</param>
		public void Command(object? @command = null, object? @deviceID = null)
		{
			_haContext.CallService("browser_mod", "command", null, new BrowserModCommandParameters{Command = @command, DeviceID = @deviceID});
		}

		///<summary>Send several commands to a browser</summary>
		public void Commands(BrowserModCommandsParameters data)
		{
			_haContext.CallService("browser_mod", "commands", null, data);
		}

		///<summary>Send several commands to a browser</summary>
		///<param name="commands">List of commands to send</param>
		///<param name="deviceID">(optional) List of receiving browsers eg: ["99980b13-dabc9563", "office_computer"]</param>
		public void Commands(object? @commands = null, object? @deviceID = null)
		{
			_haContext.CallService("browser_mod", "commands", null, new BrowserModCommandsParameters{Commands = @commands, DeviceID = @deviceID});
		}

		///<summary>On all browsers, show a popup, and a javascript alert with the current device ID.</summary>
		public void Debug(BrowserModDebugParameters data)
		{
			_haContext.CallService("browser_mod", "debug", null, data);
		}

		///<summary>On all browsers, show a popup, and a javascript alert with the current device ID.</summary>
		///<param name="deviceID">(optional) List of receiving browsers eg: ["99980b13-dabc9563", "office_computer"]</param>
		public void Debug(object? @deviceID = null)
		{
			_haContext.CallService("browser_mod", "debug", null, new BrowserModDebugParameters{DeviceID = @deviceID});
		}

		///<summary>Do nothing for a while</summary>
		public void Delay(BrowserModDelayParameters data)
		{
			_haContext.CallService("browser_mod", "delay", null, data);
		}

		///<summary>Do nothing for a while</summary>
		///<param name="seconds">Number of seconds to delay eg: 5</param>
		///<param name="deviceID">(optional) List of receiving browsers eg: ["99980b13-dabc9563", "office_computer"]</param>
		public void Delay(object? @seconds = null, object? @deviceID = null)
		{
			_haContext.CallService("browser_mod", "delay", null, new BrowserModDelayParameters{Seconds = @seconds, DeviceID = @deviceID});
		}

		///<summary>Refresh the lovelace configuration.</summary>
		public void LovelaceReload(BrowserModLovelaceReloadParameters data)
		{
			_haContext.CallService("browser_mod", "lovelace_reload", null, data);
		}

		///<summary>Refresh the lovelace configuration.</summary>
		///<param name="deviceID">(optional) List of receiving browsers eg: ["99980b13-dabc9563", "office_computer"]</param>
		public void LovelaceReload(object? @deviceID = null)
		{
			_haContext.CallService("browser_mod", "lovelace_reload", null, new BrowserModLovelaceReloadParameters{DeviceID = @deviceID});
		}

		///<summary>Open the more info dialog of an entity on a browser.</summary>
		public void MoreInfo(BrowserModMoreInfoParameters data)
		{
			_haContext.CallService("browser_mod", "more_info", null, data);
		}

		///<summary>Open the more info dialog of an entity on a browser.</summary>
		///<param name="entityId">Entity to show more info for eg: camera.front_door</param>
		///<param name="deviceID">(optional) List of receiving browsers eg: ["99980b13-dabc9563", "office_computer"]</param>
		///<param name="large">(optional) Set to true to make wider eg: true</param>
		public void MoreInfo(object? @entityId = null, object? @deviceID = null, object? @large = null)
		{
			_haContext.CallService("browser_mod", "more_info", null, new BrowserModMoreInfoParameters{EntityId = @entityId, DeviceID = @deviceID, Large = @large});
		}

		///<summary>Navigate to a path on a browser.</summary>
		public void Navigate(BrowserModNavigateParameters data)
		{
			_haContext.CallService("browser_mod", "navigate", null, data);
		}

		///<summary>Navigate to a path on a browser.</summary>
		///<param name="navigationPath">Path to navigate to eg: /lovelace/1</param>
		///<param name="deviceID">(optional) List of receiving browsers eg: ["99980b13-dabc9563", "office_computer"]</param>
		public void Navigate(object? @navigationPath = null, object? @deviceID = null)
		{
			_haContext.CallService("browser_mod", "navigate", null, new BrowserModNavigateParameters{NavigationPath = @navigationPath, DeviceID = @deviceID});
		}

		///<summary>Remove a blackout from a browser.</summary>
		public void NoBlackout(BrowserModNoBlackoutParameters data)
		{
			_haContext.CallService("browser_mod", "no_blackout", null, data);
		}

		///<summary>Remove a blackout from a browser.</summary>
		///<param name="brightness">(optional) On a Fully Kiosk Browser Plus set the screen brightness from 0 - 255.</param>
		///<param name="deviceID">(optional) List of receiving browsers eg: ["99980b13-dabc9563", "office_computer"]</param>
		public void NoBlackout(object? @brightness = null, object? @deviceID = null)
		{
			_haContext.CallService("browser_mod", "no_blackout", null, new BrowserModNoBlackoutParameters{Brightness = @brightness, DeviceID = @deviceID});
		}

		///<summary>Pop up a card on a browser.</summary>
		public void Popup(BrowserModPopupParameters data)
		{
			_haContext.CallService("browser_mod", "popup", null, data);
		}

		///<summary>Pop up a card on a browser.</summary>
		///<param name="title">Name to show in popup bar eg: Popup example</param>
		///<param name="card">YAML config for card to show</param>
		///<param name="deviceID">(optional) List of receiving browsers eg: ["99980b13-dabc9563", "office_computer"]</param>
		///<param name="large">(optional) Set to true to make wider eg: true</param>
		///<param name="hideHeader">(optional) Hide header title and close button eg: true</param>
		///<param name="autoClose">(optional) Close popup when mouse is moved or key is pressed. Also hides header eg: true</param>
		///<param name="time">(optional) When mouse isn't moved or keys aren't pressed for this amount of seconds, reopen. Only usable with auto_close. See blackout eg: 20</param>
		public void Popup(object? @title = null, object? @card = null, object? @deviceID = null, object? @large = null, object? @hideHeader = null, object? @autoClose = null, object? @time = null)
		{
			_haContext.CallService("browser_mod", "popup", null, new BrowserModPopupParameters{Title = @title, Card = @card, DeviceID = @deviceID, Large = @large, HideHeader = @hideHeader, AutoClose = @autoClose, Time = @time});
		}

		///<summary>On all browsers, change the theme.</summary>
		public void SetTheme(BrowserModSetThemeParameters data)
		{
			_haContext.CallService("browser_mod", "set_theme", null, data);
		}

		///<summary>On all browsers, change the theme.</summary>
		///<param name="theme">Theme to change to eg: {theme: "clear_light"}</param>
		///<param name="deviceID">(optional) List of receiving browsers eg: ["99980b13-dabc9563", "office_computer"]</param>
		public void SetTheme(object? @theme = null, object? @deviceID = null)
		{
			_haContext.CallService("browser_mod", "set_theme", null, new BrowserModSetThemeParameters{Theme = @theme, DeviceID = @deviceID});
		}

		///<summary>Show a toast message in the bottom left on all browsers.</summary>
		public void Toast(BrowserModToastParameters data)
		{
			_haContext.CallService("browser_mod", "toast", null, data);
		}

		///<summary>Show a toast message in the bottom left on all browsers.</summary>
		///<param name="message">Message to show eg: Short message</param>
		///<param name="deviceID">(optional) List of receiving browsers eg: ["99980b13-dabc9563", "office_computer"]</param>
		///<param name="duration">(optional) Time in milliseconds to show message for. Set to 0 for persistent display. eg: 10000</param>
		public void Toast(object? @message = null, object? @deviceID = null, object? @duration = null)
		{
			_haContext.CallService("browser_mod", "toast", null, new BrowserModToastParameters{Message = @message, DeviceID = @deviceID, Duration = @duration});
		}

		///<summary>Forces the browser to reload the page. Same as clicking your browser's refresh button. Note: This is not guaranteed to clear the frontend cache.</summary>
		public void WindowReload(BrowserModWindowReloadParameters data)
		{
			_haContext.CallService("browser_mod", "window_reload", null, data);
		}

		///<summary>Forces the browser to reload the page. Same as clicking your browser's refresh button. Note: This is not guaranteed to clear the frontend cache.</summary>
		///<param name="deviceID">(optional) List of receiving browsers eg: ["99980b13-dabc9563", "office_computer"]</param>
		public void WindowReload(object? @deviceID = null)
		{
			_haContext.CallService("browser_mod", "window_reload", null, new BrowserModWindowReloadParameters{DeviceID = @deviceID});
		}
	}

	public record BrowserModBlackoutParameters
	{
		///<summary>(optional) The blackout will turn on automatically after the specified number of seconds. It works kind of like a screensaver and will keep turning on until blackout is called again with time: -1. eg: 20</summary>
		[JsonPropertyName("time")]
		public object? Time { get; init; }

		///<summary>(optional) List of receiving browsers eg: ["99980b13-dabc9563", "office_computer"]</summary>
		[JsonPropertyName("deviceID")]
		public object? DeviceID { get; init; }
	}

	public record BrowserModClosePopupParameters
	{
		///<summary>(optional) List of receiving browsers eg: ["99980b13-dabc9563", "office_computer"]</summary>
		[JsonPropertyName("deviceID")]
		public object? DeviceID { get; init; }
	}

	public record BrowserModCommandParameters
	{
		///<summary>Command to send eg: navigate</summary>
		[JsonPropertyName("command")]
		public object? Command { get; init; }

		///<summary>(optional) List of receiving browsers eg: ["99980b13-dabc9563", "office_computer"]</summary>
		[JsonPropertyName("deviceID")]
		public object? DeviceID { get; init; }
	}

	public record BrowserModCommandsParameters
	{
		///<summary>List of commands to send</summary>
		[JsonPropertyName("commands")]
		public object? Commands { get; init; }

		///<summary>(optional) List of receiving browsers eg: ["99980b13-dabc9563", "office_computer"]</summary>
		[JsonPropertyName("deviceID")]
		public object? DeviceID { get; init; }
	}

	public record BrowserModDebugParameters
	{
		///<summary>(optional) List of receiving browsers eg: ["99980b13-dabc9563", "office_computer"]</summary>
		[JsonPropertyName("deviceID")]
		public object? DeviceID { get; init; }
	}

	public record BrowserModDelayParameters
	{
		///<summary>Number of seconds to delay eg: 5</summary>
		[JsonPropertyName("seconds")]
		public object? Seconds { get; init; }

		///<summary>(optional) List of receiving browsers eg: ["99980b13-dabc9563", "office_computer"]</summary>
		[JsonPropertyName("deviceID")]
		public object? DeviceID { get; init; }
	}

	public record BrowserModLovelaceReloadParameters
	{
		///<summary>(optional) List of receiving browsers eg: ["99980b13-dabc9563", "office_computer"]</summary>
		[JsonPropertyName("deviceID")]
		public object? DeviceID { get; init; }
	}

	public record BrowserModMoreInfoParameters
	{
		///<summary>Entity to show more info for eg: camera.front_door</summary>
		[JsonPropertyName("entity_id")]
		public object? EntityId { get; init; }

		///<summary>(optional) List of receiving browsers eg: ["99980b13-dabc9563", "office_computer"]</summary>
		[JsonPropertyName("deviceID")]
		public object? DeviceID { get; init; }

		///<summary>(optional) Set to true to make wider eg: true</summary>
		[JsonPropertyName("large")]
		public object? Large { get; init; }
	}

	public record BrowserModNavigateParameters
	{
		///<summary>Path to navigate to eg: /lovelace/1</summary>
		[JsonPropertyName("navigation_path")]
		public object? NavigationPath { get; init; }

		///<summary>(optional) List of receiving browsers eg: ["99980b13-dabc9563", "office_computer"]</summary>
		[JsonPropertyName("deviceID")]
		public object? DeviceID { get; init; }
	}

	public record BrowserModNoBlackoutParameters
	{
		///<summary>(optional) On a Fully Kiosk Browser Plus set the screen brightness from 0 - 255.</summary>
		[JsonPropertyName("brightness")]
		public object? Brightness { get; init; }

		///<summary>(optional) List of receiving browsers eg: ["99980b13-dabc9563", "office_computer"]</summary>
		[JsonPropertyName("deviceID")]
		public object? DeviceID { get; init; }
	}

	public record BrowserModPopupParameters
	{
		///<summary>Name to show in popup bar eg: Popup example</summary>
		[JsonPropertyName("title")]
		public object? Title { get; init; }

		///<summary>YAML config for card to show</summary>
		[JsonPropertyName("card")]
		public object? Card { get; init; }

		///<summary>(optional) List of receiving browsers eg: ["99980b13-dabc9563", "office_computer"]</summary>
		[JsonPropertyName("deviceID")]
		public object? DeviceID { get; init; }

		///<summary>(optional) Set to true to make wider eg: true</summary>
		[JsonPropertyName("large")]
		public object? Large { get; init; }

		///<summary>(optional) Hide header title and close button eg: true</summary>
		[JsonPropertyName("hide_header")]
		public object? HideHeader { get; init; }

		///<summary>(optional) Close popup when mouse is moved or key is pressed. Also hides header eg: true</summary>
		[JsonPropertyName("auto_close")]
		public object? AutoClose { get; init; }

		///<summary>(optional) When mouse isn't moved or keys aren't pressed for this amount of seconds, reopen. Only usable with auto_close. See blackout eg: 20</summary>
		[JsonPropertyName("time")]
		public object? Time { get; init; }
	}

	public record BrowserModSetThemeParameters
	{
		///<summary>Theme to change to eg: {theme: "clear_light"}</summary>
		[JsonPropertyName("theme")]
		public object? Theme { get; init; }

		///<summary>(optional) List of receiving browsers eg: ["99980b13-dabc9563", "office_computer"]</summary>
		[JsonPropertyName("deviceID")]
		public object? DeviceID { get; init; }
	}

	public record BrowserModToastParameters
	{
		///<summary>Message to show eg: Short message</summary>
		[JsonPropertyName("message")]
		public object? Message { get; init; }

		///<summary>(optional) List of receiving browsers eg: ["99980b13-dabc9563", "office_computer"]</summary>
		[JsonPropertyName("deviceID")]
		public object? DeviceID { get; init; }

		///<summary>(optional) Time in milliseconds to show message for. Set to 0 for persistent display. eg: 10000</summary>
		[JsonPropertyName("duration")]
		public object? Duration { get; init; }
	}

	public record BrowserModWindowReloadParameters
	{
		///<summary>(optional) List of receiving browsers eg: ["99980b13-dabc9563", "office_computer"]</summary>
		[JsonPropertyName("deviceID")]
		public object? DeviceID { get; init; }
	}

	public class ButtonServices
	{
		private readonly IHaContext _haContext;
		public ButtonServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Press the button entity.</summary>
		///<param name="target">The target for this service call</param>
		public void Press(ServiceTarget target)
		{
			_haContext.CallService("button", "press", target);
		}
	}

	public class CameraServices
	{
		private readonly IHaContext _haContext;
		public CameraServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Disable the motion detection in a camera.</summary>
		///<param name="target">The target for this service call</param>
		public void DisableMotionDetection(ServiceTarget target)
		{
			_haContext.CallService("camera", "disable_motion_detection", target);
		}

		///<summary>Enable the motion detection in a camera.</summary>
		///<param name="target">The target for this service call</param>
		public void EnableMotionDetection(ServiceTarget target)
		{
			_haContext.CallService("camera", "enable_motion_detection", target);
		}

		///<summary>Play camera stream on supported media player.</summary>
		///<param name="target">The target for this service call</param>
		public void PlayStream(ServiceTarget target, CameraPlayStreamParameters data)
		{
			_haContext.CallService("camera", "play_stream", target, data);
		}

		///<summary>Play camera stream on supported media player.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="mediaPlayer">Name(s) of media player to stream to.</param>
		///<param name="format">Stream format supported by media player.</param>
		public void PlayStream(ServiceTarget target, string @mediaPlayer, object? @format = null)
		{
			_haContext.CallService("camera", "play_stream", target, new CameraPlayStreamParameters{MediaPlayer = @mediaPlayer, Format = @format});
		}

		///<summary>Record live camera feed.</summary>
		///<param name="target">The target for this service call</param>
		public void Record(ServiceTarget target, CameraRecordParameters data)
		{
			_haContext.CallService("camera", "record", target, data);
		}

		///<summary>Record live camera feed.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="filename">Template of a Filename. Variable is entity_id. Must be mp4. eg: /tmp/snapshot_{{ entity_id.name }}.mp4</param>
		///<param name="duration">Target recording length.</param>
		///<param name="lookback">Target lookback period to include in addition to duration. Only available if there is currently an active HLS stream.</param>
		public void Record(ServiceTarget target, string @filename, long? @duration = null, long? @lookback = null)
		{
			_haContext.CallService("camera", "record", target, new CameraRecordParameters{Filename = @filename, Duration = @duration, Lookback = @lookback});
		}

		///<summary>Take a snapshot from a camera.</summary>
		///<param name="target">The target for this service call</param>
		public void Snapshot(ServiceTarget target, CameraSnapshotParameters data)
		{
			_haContext.CallService("camera", "snapshot", target, data);
		}

		///<summary>Take a snapshot from a camera.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="filename">Template of a Filename. Variable is entity_id. eg: /tmp/snapshot_{{ entity_id.name }}.jpg</param>
		public void Snapshot(ServiceTarget target, string @filename)
		{
			_haContext.CallService("camera", "snapshot", target, new CameraSnapshotParameters{Filename = @filename});
		}

		///<summary>Turn off camera.</summary>
		///<param name="target">The target for this service call</param>
		public void TurnOff(ServiceTarget target)
		{
			_haContext.CallService("camera", "turn_off", target);
		}

		///<summary>Turn on camera.</summary>
		///<param name="target">The target for this service call</param>
		public void TurnOn(ServiceTarget target)
		{
			_haContext.CallService("camera", "turn_on", target);
		}
	}

	public record CameraPlayStreamParameters
	{
		///<summary>Name(s) of media player to stream to.</summary>
		[JsonPropertyName("media_player")]
		public string? MediaPlayer { get; init; }

		///<summary>Stream format supported by media player.</summary>
		[JsonPropertyName("format")]
		public object? Format { get; init; }
	}

	public record CameraRecordParameters
	{
		///<summary>Template of a Filename. Variable is entity_id. Must be mp4. eg: /tmp/snapshot_{{ entity_id.name }}.mp4</summary>
		[JsonPropertyName("filename")]
		public string? Filename { get; init; }

		///<summary>Target recording length.</summary>
		[JsonPropertyName("duration")]
		public long? Duration { get; init; }

		///<summary>Target lookback period to include in addition to duration. Only available if there is currently an active HLS stream.</summary>
		[JsonPropertyName("lookback")]
		public long? Lookback { get; init; }
	}

	public record CameraSnapshotParameters
	{
		///<summary>Template of a Filename. Variable is entity_id. eg: /tmp/snapshot_{{ entity_id.name }}.jpg</summary>
		[JsonPropertyName("filename")]
		public string? Filename { get; init; }
	}

	public class CastServices
	{
		private readonly IHaContext _haContext;
		public CastServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Show a Lovelace view on a Chromecast.</summary>
		public void ShowLovelaceView(CastShowLovelaceViewParameters data)
		{
			_haContext.CallService("cast", "show_lovelace_view", null, data);
		}

		///<summary>Show a Lovelace view on a Chromecast.</summary>
		///<param name="entityId">Media Player entity to show the Lovelace view on.</param>
		///<param name="dashboardPath">The URL path of the Lovelace dashboard to show. eg: lovelace-cast</param>
		///<param name="viewPath">The path of the Lovelace view to show. eg: downstairs</param>
		public void ShowLovelaceView(string @entityId, string @dashboardPath, string? @viewPath = null)
		{
			_haContext.CallService("cast", "show_lovelace_view", null, new CastShowLovelaceViewParameters{EntityId = @entityId, DashboardPath = @dashboardPath, ViewPath = @viewPath});
		}
	}

	public record CastShowLovelaceViewParameters
	{
		///<summary>Media Player entity to show the Lovelace view on.</summary>
		[JsonPropertyName("entity_id")]
		public string? EntityId { get; init; }

		///<summary>The URL path of the Lovelace dashboard to show. eg: lovelace-cast</summary>
		[JsonPropertyName("dashboard_path")]
		public string? DashboardPath { get; init; }

		///<summary>The path of the Lovelace view to show. eg: downstairs</summary>
		[JsonPropertyName("view_path")]
		public string? ViewPath { get; init; }
	}

	public class ClimateServices
	{
		private readonly IHaContext _haContext;
		public ClimateServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Turn auxiliary heater on/off for climate device.</summary>
		///<param name="target">The target for this service call</param>
		public void SetAuxHeat(ServiceTarget target, ClimateSetAuxHeatParameters data)
		{
			_haContext.CallService("climate", "set_aux_heat", target, data);
		}

		///<summary>Turn auxiliary heater on/off for climate device.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="auxHeat">New value of auxiliary heater.</param>
		public void SetAuxHeat(ServiceTarget target, bool @auxHeat)
		{
			_haContext.CallService("climate", "set_aux_heat", target, new ClimateSetAuxHeatParameters{AuxHeat = @auxHeat});
		}

		///<summary>Set fan operation for climate device.</summary>
		///<param name="target">The target for this service call</param>
		public void SetFanMode(ServiceTarget target, ClimateSetFanModeParameters data)
		{
			_haContext.CallService("climate", "set_fan_mode", target, data);
		}

		///<summary>Set fan operation for climate device.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="fanMode">New value of fan mode. eg: low</param>
		public void SetFanMode(ServiceTarget target, string @fanMode)
		{
			_haContext.CallService("climate", "set_fan_mode", target, new ClimateSetFanModeParameters{FanMode = @fanMode});
		}

		///<summary>Set target humidity of climate device.</summary>
		///<param name="target">The target for this service call</param>
		public void SetHumidity(ServiceTarget target, ClimateSetHumidityParameters data)
		{
			_haContext.CallService("climate", "set_humidity", target, data);
		}

		///<summary>Set target humidity of climate device.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="humidity">New target humidity for climate device.</param>
		public void SetHumidity(ServiceTarget target, long @humidity)
		{
			_haContext.CallService("climate", "set_humidity", target, new ClimateSetHumidityParameters{Humidity = @humidity});
		}

		///<summary>Set HVAC operation mode for climate device.</summary>
		///<param name="target">The target for this service call</param>
		public void SetHvacMode(ServiceTarget target, ClimateSetHvacModeParameters data)
		{
			_haContext.CallService("climate", "set_hvac_mode", target, data);
		}

		///<summary>Set HVAC operation mode for climate device.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="hvacMode">New value of operation mode.</param>
		public void SetHvacMode(ServiceTarget target, object? @hvacMode = null)
		{
			_haContext.CallService("climate", "set_hvac_mode", target, new ClimateSetHvacModeParameters{HvacMode = @hvacMode});
		}

		///<summary>Set preset mode for climate device.</summary>
		///<param name="target">The target for this service call</param>
		public void SetPresetMode(ServiceTarget target, ClimateSetPresetModeParameters data)
		{
			_haContext.CallService("climate", "set_preset_mode", target, data);
		}

		///<summary>Set preset mode for climate device.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="presetMode">New value of preset mode. eg: away</param>
		public void SetPresetMode(ServiceTarget target, string @presetMode)
		{
			_haContext.CallService("climate", "set_preset_mode", target, new ClimateSetPresetModeParameters{PresetMode = @presetMode});
		}

		///<summary>Set swing operation for climate device.</summary>
		///<param name="target">The target for this service call</param>
		public void SetSwingMode(ServiceTarget target, ClimateSetSwingModeParameters data)
		{
			_haContext.CallService("climate", "set_swing_mode", target, data);
		}

		///<summary>Set swing operation for climate device.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="swingMode">New value of swing mode. eg: horizontal</param>
		public void SetSwingMode(ServiceTarget target, string @swingMode)
		{
			_haContext.CallService("climate", "set_swing_mode", target, new ClimateSetSwingModeParameters{SwingMode = @swingMode});
		}

		///<summary>Set target temperature of climate device.</summary>
		///<param name="target">The target for this service call</param>
		public void SetTemperature(ServiceTarget target, ClimateSetTemperatureParameters data)
		{
			_haContext.CallService("climate", "set_temperature", target, data);
		}

		///<summary>Set target temperature of climate device.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="temperature">New target temperature for HVAC.</param>
		///<param name="targetTempHigh">New target high temperature for HVAC.</param>
		///<param name="targetTempLow">New target low temperature for HVAC.</param>
		///<param name="hvacMode">HVAC operation mode to set temperature to.</param>
		public void SetTemperature(ServiceTarget target, double? @temperature = null, double? @targetTempHigh = null, double? @targetTempLow = null, object? @hvacMode = null)
		{
			_haContext.CallService("climate", "set_temperature", target, new ClimateSetTemperatureParameters{Temperature = @temperature, TargetTempHigh = @targetTempHigh, TargetTempLow = @targetTempLow, HvacMode = @hvacMode});
		}

		///<summary>Turn climate device off.</summary>
		///<param name="target">The target for this service call</param>
		public void TurnOff(ServiceTarget target)
		{
			_haContext.CallService("climate", "turn_off", target);
		}

		///<summary>Turn climate device on.</summary>
		///<param name="target">The target for this service call</param>
		public void TurnOn(ServiceTarget target)
		{
			_haContext.CallService("climate", "turn_on", target);
		}
	}

	public record ClimateSetAuxHeatParameters
	{
		///<summary>New value of auxiliary heater.</summary>
		[JsonPropertyName("aux_heat")]
		public bool? AuxHeat { get; init; }
	}

	public record ClimateSetFanModeParameters
	{
		///<summary>New value of fan mode. eg: low</summary>
		[JsonPropertyName("fan_mode")]
		public string? FanMode { get; init; }
	}

	public record ClimateSetHumidityParameters
	{
		///<summary>New target humidity for climate device.</summary>
		[JsonPropertyName("humidity")]
		public long? Humidity { get; init; }
	}

	public record ClimateSetHvacModeParameters
	{
		///<summary>New value of operation mode.</summary>
		[JsonPropertyName("hvac_mode")]
		public object? HvacMode { get; init; }
	}

	public record ClimateSetPresetModeParameters
	{
		///<summary>New value of preset mode. eg: away</summary>
		[JsonPropertyName("preset_mode")]
		public string? PresetMode { get; init; }
	}

	public record ClimateSetSwingModeParameters
	{
		///<summary>New value of swing mode. eg: horizontal</summary>
		[JsonPropertyName("swing_mode")]
		public string? SwingMode { get; init; }
	}

	public record ClimateSetTemperatureParameters
	{
		///<summary>New target temperature for HVAC.</summary>
		[JsonPropertyName("temperature")]
		public double? Temperature { get; init; }

		///<summary>New target high temperature for HVAC.</summary>
		[JsonPropertyName("target_temp_high")]
		public double? TargetTempHigh { get; init; }

		///<summary>New target low temperature for HVAC.</summary>
		[JsonPropertyName("target_temp_low")]
		public double? TargetTempLow { get; init; }

		///<summary>HVAC operation mode to set temperature to.</summary>
		[JsonPropertyName("hvac_mode")]
		public object? HvacMode { get; init; }
	}

	public class CloudServices
	{
		private readonly IHaContext _haContext;
		public CloudServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Make instance UI available outside over NabuCasa cloud</summary>
		public void RemoteConnect()
		{
			_haContext.CallService("cloud", "remote_connect", null);
		}

		///<summary>Disconnect UI from NabuCasa cloud</summary>
		public void RemoteDisconnect()
		{
			_haContext.CallService("cloud", "remote_disconnect", null);
		}
	}

	public class CounterServices
	{
		private readonly IHaContext _haContext;
		public CounterServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Change counter parameters.</summary>
		///<param name="target">The target for this service call</param>
		public void Configure(ServiceTarget target, CounterConfigureParameters data)
		{
			_haContext.CallService("counter", "configure", target, data);
		}

		///<summary>Change counter parameters.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="minimum">New minimum value for the counter or None to remove minimum.</param>
		///<param name="maximum">New maximum value for the counter or None to remove maximum.</param>
		///<param name="step">New value for step.</param>
		///<param name="initial">New value for initial.</param>
		///<param name="value">New state value.</param>
		public void Configure(ServiceTarget target, long? @minimum = null, long? @maximum = null, long? @step = null, long? @initial = null, long? @value = null)
		{
			_haContext.CallService("counter", "configure", target, new CounterConfigureParameters{Minimum = @minimum, Maximum = @maximum, Step = @step, Initial = @initial, Value = @value});
		}

		///<summary>Decrement a counter.</summary>
		///<param name="target">The target for this service call</param>
		public void Decrement(ServiceTarget target)
		{
			_haContext.CallService("counter", "decrement", target);
		}

		///<summary>Increment a counter.</summary>
		///<param name="target">The target for this service call</param>
		public void Increment(ServiceTarget target)
		{
			_haContext.CallService("counter", "increment", target);
		}

		///<summary>Reset a counter.</summary>
		///<param name="target">The target for this service call</param>
		public void Reset(ServiceTarget target)
		{
			_haContext.CallService("counter", "reset", target);
		}
	}

	public record CounterConfigureParameters
	{
		///<summary>New minimum value for the counter or None to remove minimum.</summary>
		[JsonPropertyName("minimum")]
		public long? Minimum { get; init; }

		///<summary>New maximum value for the counter or None to remove maximum.</summary>
		[JsonPropertyName("maximum")]
		public long? Maximum { get; init; }

		///<summary>New value for step.</summary>
		[JsonPropertyName("step")]
		public long? Step { get; init; }

		///<summary>New value for initial.</summary>
		[JsonPropertyName("initial")]
		public long? Initial { get; init; }

		///<summary>New state value.</summary>
		[JsonPropertyName("value")]
		public long? Value { get; init; }
	}

	public class CoverServices
	{
		private readonly IHaContext _haContext;
		public CoverServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Close all or specified cover.</summary>
		///<param name="target">The target for this service call</param>
		public void CloseCover(ServiceTarget target)
		{
			_haContext.CallService("cover", "close_cover", target);
		}

		///<summary>Close all or specified cover tilt.</summary>
		///<param name="target">The target for this service call</param>
		public void CloseCoverTilt(ServiceTarget target)
		{
			_haContext.CallService("cover", "close_cover_tilt", target);
		}

		///<summary>Open all or specified cover.</summary>
		///<param name="target">The target for this service call</param>
		public void OpenCover(ServiceTarget target)
		{
			_haContext.CallService("cover", "open_cover", target);
		}

		///<summary>Open all or specified cover tilt.</summary>
		///<param name="target">The target for this service call</param>
		public void OpenCoverTilt(ServiceTarget target)
		{
			_haContext.CallService("cover", "open_cover_tilt", target);
		}

		///<summary>Move to specific position all or specified cover.</summary>
		///<param name="target">The target for this service call</param>
		public void SetCoverPosition(ServiceTarget target, CoverSetCoverPositionParameters data)
		{
			_haContext.CallService("cover", "set_cover_position", target, data);
		}

		///<summary>Move to specific position all or specified cover.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="position">Position of the cover</param>
		public void SetCoverPosition(ServiceTarget target, long @position)
		{
			_haContext.CallService("cover", "set_cover_position", target, new CoverSetCoverPositionParameters{Position = @position});
		}

		///<summary>Move to specific position all or specified cover tilt.</summary>
		///<param name="target">The target for this service call</param>
		public void SetCoverTiltPosition(ServiceTarget target, CoverSetCoverTiltPositionParameters data)
		{
			_haContext.CallService("cover", "set_cover_tilt_position", target, data);
		}

		///<summary>Move to specific position all or specified cover tilt.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="tiltPosition">Tilt position of the cover.</param>
		public void SetCoverTiltPosition(ServiceTarget target, long @tiltPosition)
		{
			_haContext.CallService("cover", "set_cover_tilt_position", target, new CoverSetCoverTiltPositionParameters{TiltPosition = @tiltPosition});
		}

		///<summary>Stop all or specified cover.</summary>
		///<param name="target">The target for this service call</param>
		public void StopCover(ServiceTarget target)
		{
			_haContext.CallService("cover", "stop_cover", target);
		}

		///<summary>Stop all or specified cover.</summary>
		///<param name="target">The target for this service call</param>
		public void StopCoverTilt(ServiceTarget target)
		{
			_haContext.CallService("cover", "stop_cover_tilt", target);
		}

		///<summary>Toggle a cover open/closed.</summary>
		///<param name="target">The target for this service call</param>
		public void Toggle(ServiceTarget target)
		{
			_haContext.CallService("cover", "toggle", target);
		}

		///<summary>Toggle a cover tilt open/closed.</summary>
		///<param name="target">The target for this service call</param>
		public void ToggleCoverTilt(ServiceTarget target)
		{
			_haContext.CallService("cover", "toggle_cover_tilt", target);
		}
	}

	public record CoverSetCoverPositionParameters
	{
		///<summary>Position of the cover</summary>
		[JsonPropertyName("position")]
		public long? Position { get; init; }
	}

	public record CoverSetCoverTiltPositionParameters
	{
		///<summary>Tilt position of the cover.</summary>
		[JsonPropertyName("tilt_position")]
		public long? TiltPosition { get; init; }
	}

	public class DeviceTrackerServices
	{
		private readonly IHaContext _haContext;
		public DeviceTrackerServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Control tracked device.</summary>
		public void See(DeviceTrackerSeeParameters data)
		{
			_haContext.CallService("device_tracker", "see", null, data);
		}

		///<summary>Control tracked device.</summary>
		///<param name="mac">MAC address of device eg: FF:FF:FF:FF:FF:FF</param>
		///<param name="devId">Id of device (find id in known_devices.yaml). eg: phonedave</param>
		///<param name="hostName">Hostname of device eg: Dave</param>
		///<param name="locationName">Name of location where device is located (not_home is away). eg: home</param>
		///<param name="gps">GPS coordinates where device is located (latitude, longitude). eg: [51.509802, -0.086692]</param>
		///<param name="gpsAccuracy">Accuracy of GPS coordinates.</param>
		///<param name="battery">Battery level of device.</param>
		public void See(string? @mac = null, string? @devId = null, string? @hostName = null, string? @locationName = null, object? @gps = null, long? @gpsAccuracy = null, long? @battery = null)
		{
			_haContext.CallService("device_tracker", "see", null, new DeviceTrackerSeeParameters{Mac = @mac, DevId = @devId, HostName = @hostName, LocationName = @locationName, Gps = @gps, GpsAccuracy = @gpsAccuracy, Battery = @battery});
		}
	}

	public record DeviceTrackerSeeParameters
	{
		///<summary>MAC address of device eg: FF:FF:FF:FF:FF:FF</summary>
		[JsonPropertyName("mac")]
		public string? Mac { get; init; }

		///<summary>Id of device (find id in known_devices.yaml). eg: phonedave</summary>
		[JsonPropertyName("dev_id")]
		public string? DevId { get; init; }

		///<summary>Hostname of device eg: Dave</summary>
		[JsonPropertyName("host_name")]
		public string? HostName { get; init; }

		///<summary>Name of location where device is located (not_home is away). eg: home</summary>
		[JsonPropertyName("location_name")]
		public string? LocationName { get; init; }

		///<summary>GPS coordinates where device is located (latitude, longitude). eg: [51.509802, -0.086692]</summary>
		[JsonPropertyName("gps")]
		public object? Gps { get; init; }

		///<summary>Accuracy of GPS coordinates.</summary>
		[JsonPropertyName("gps_accuracy")]
		public long? GpsAccuracy { get; init; }

		///<summary>Battery level of device.</summary>
		[JsonPropertyName("battery")]
		public long? Battery { get; init; }
	}

	public class FanServices
	{
		private readonly IHaContext _haContext;
		public FanServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Decrease the speed of the fan by one speed or a percentage_step.</summary>
		///<param name="target">The target for this service call</param>
		public void DecreaseSpeed(ServiceTarget target, FanDecreaseSpeedParameters data)
		{
			_haContext.CallService("fan", "decrease_speed", target, data);
		}

		///<summary>Decrease the speed of the fan by one speed or a percentage_step.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="percentageStep">Decrease speed by a percentage.</param>
		public void DecreaseSpeed(ServiceTarget target, long? @percentageStep = null)
		{
			_haContext.CallService("fan", "decrease_speed", target, new FanDecreaseSpeedParameters{PercentageStep = @percentageStep});
		}

		///<summary>Increase the speed of the fan by one speed or a percentage_step.</summary>
		///<param name="target">The target for this service call</param>
		public void IncreaseSpeed(ServiceTarget target, FanIncreaseSpeedParameters data)
		{
			_haContext.CallService("fan", "increase_speed", target, data);
		}

		///<summary>Increase the speed of the fan by one speed or a percentage_step.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="percentageStep">Increase speed by a percentage.</param>
		public void IncreaseSpeed(ServiceTarget target, long? @percentageStep = null)
		{
			_haContext.CallService("fan", "increase_speed", target, new FanIncreaseSpeedParameters{PercentageStep = @percentageStep});
		}

		///<summary>Oscillate the fan.</summary>
		///<param name="target">The target for this service call</param>
		public void Oscillate(ServiceTarget target, FanOscillateParameters data)
		{
			_haContext.CallService("fan", "oscillate", target, data);
		}

		///<summary>Oscillate the fan.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="oscillating">Flag to turn on/off oscillation.</param>
		public void Oscillate(ServiceTarget target, bool @oscillating)
		{
			_haContext.CallService("fan", "oscillate", target, new FanOscillateParameters{Oscillating = @oscillating});
		}

		///<summary>Set the fan rotation.</summary>
		///<param name="target">The target for this service call</param>
		public void SetDirection(ServiceTarget target, FanSetDirectionParameters data)
		{
			_haContext.CallService("fan", "set_direction", target, data);
		}

		///<summary>Set the fan rotation.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="direction">The direction to rotate.</param>
		public void SetDirection(ServiceTarget target, object @direction)
		{
			_haContext.CallService("fan", "set_direction", target, new FanSetDirectionParameters{Direction = @direction});
		}

		///<summary>Set fan speed percentage.</summary>
		///<param name="target">The target for this service call</param>
		public void SetPercentage(ServiceTarget target, FanSetPercentageParameters data)
		{
			_haContext.CallService("fan", "set_percentage", target, data);
		}

		///<summary>Set fan speed percentage.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="percentage">Percentage speed setting.</param>
		public void SetPercentage(ServiceTarget target, long @percentage)
		{
			_haContext.CallService("fan", "set_percentage", target, new FanSetPercentageParameters{Percentage = @percentage});
		}

		///<summary>Set preset mode for a fan device.</summary>
		///<param name="target">The target for this service call</param>
		public void SetPresetMode(ServiceTarget target, FanSetPresetModeParameters data)
		{
			_haContext.CallService("fan", "set_preset_mode", target, data);
		}

		///<summary>Set preset mode for a fan device.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="presetMode">New value of preset mode. eg: auto</param>
		public void SetPresetMode(ServiceTarget target, string @presetMode)
		{
			_haContext.CallService("fan", "set_preset_mode", target, new FanSetPresetModeParameters{PresetMode = @presetMode});
		}

		///<summary>Toggle the fan on/off.</summary>
		///<param name="target">The target for this service call</param>
		public void Toggle(ServiceTarget target)
		{
			_haContext.CallService("fan", "toggle", target);
		}

		///<summary>Turn fan off.</summary>
		///<param name="target">The target for this service call</param>
		public void TurnOff(ServiceTarget target)
		{
			_haContext.CallService("fan", "turn_off", target);
		}

		///<summary>Turn fan on.</summary>
		///<param name="target">The target for this service call</param>
		public void TurnOn(ServiceTarget target, FanTurnOnParameters data)
		{
			_haContext.CallService("fan", "turn_on", target, data);
		}

		///<summary>Turn fan on.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="speed">Speed setting. eg: high</param>
		///<param name="percentage">Percentage speed setting.</param>
		///<param name="presetMode">Preset mode setting. eg: auto</param>
		public void TurnOn(ServiceTarget target, string? @speed = null, long? @percentage = null, string? @presetMode = null)
		{
			_haContext.CallService("fan", "turn_on", target, new FanTurnOnParameters{Speed = @speed, Percentage = @percentage, PresetMode = @presetMode});
		}
	}

	public record FanDecreaseSpeedParameters
	{
		///<summary>Decrease speed by a percentage.</summary>
		[JsonPropertyName("percentage_step")]
		public long? PercentageStep { get; init; }
	}

	public record FanIncreaseSpeedParameters
	{
		///<summary>Increase speed by a percentage.</summary>
		[JsonPropertyName("percentage_step")]
		public long? PercentageStep { get; init; }
	}

	public record FanOscillateParameters
	{
		///<summary>Flag to turn on/off oscillation.</summary>
		[JsonPropertyName("oscillating")]
		public bool? Oscillating { get; init; }
	}

	public record FanSetDirectionParameters
	{
		///<summary>The direction to rotate.</summary>
		[JsonPropertyName("direction")]
		public object? Direction { get; init; }
	}

	public record FanSetPercentageParameters
	{
		///<summary>Percentage speed setting.</summary>
		[JsonPropertyName("percentage")]
		public long? Percentage { get; init; }
	}

	public record FanSetPresetModeParameters
	{
		///<summary>New value of preset mode. eg: auto</summary>
		[JsonPropertyName("preset_mode")]
		public string? PresetMode { get; init; }
	}

	public record FanTurnOnParameters
	{
		///<summary>Speed setting. eg: high</summary>
		[JsonPropertyName("speed")]
		public string? Speed { get; init; }

		///<summary>Percentage speed setting.</summary>
		[JsonPropertyName("percentage")]
		public long? Percentage { get; init; }

		///<summary>Preset mode setting. eg: auto</summary>
		[JsonPropertyName("preset_mode")]
		public string? PresetMode { get; init; }
	}

	public class FrontendServices
	{
		private readonly IHaContext _haContext;
		public FrontendServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Reload themes from YAML configuration.</summary>
		public void ReloadThemes()
		{
			_haContext.CallService("frontend", "reload_themes", null);
		}

		///<summary>Set a theme unless the client selected per-device theme.</summary>
		public void SetTheme(FrontendSetThemeParameters data)
		{
			_haContext.CallService("frontend", "set_theme", null, data);
		}

		///<summary>Set a theme unless the client selected per-device theme.</summary>
		///<param name="name">Name of a predefined theme eg: default</param>
		///<param name="mode">The mode the theme is for.</param>
		public void SetTheme(object @name, object? @mode = null)
		{
			_haContext.CallService("frontend", "set_theme", null, new FrontendSetThemeParameters{Name = @name, Mode = @mode});
		}
	}

	public record FrontendSetThemeParameters
	{
		///<summary>Name of a predefined theme eg: default</summary>
		[JsonPropertyName("name")]
		public object? Name { get; init; }

		///<summary>The mode the theme is for.</summary>
		[JsonPropertyName("mode")]
		public object? Mode { get; init; }
	}

	public class GarbageCollectionServices
	{
		private readonly IHaContext _haContext;
		public GarbageCollectionServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Manually add collection date.</summary>
		///<param name="target">The target for this service call</param>
		public void AddDate(ServiceTarget target, GarbageCollectionAddDateParameters data)
		{
			_haContext.CallService("garbage_collection", "add_date", target, data);
		}

		///<summary>Manually add collection date.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="entityId">The garbage_collection sensor entity_id eg: sensor.general_waste</param>
		///<param name="date">Collection date to add eg: "2020-08-16"</param>
		public void AddDate(ServiceTarget target, object? @entityId = null, object? @date = null)
		{
			_haContext.CallService("garbage_collection", "add_date", target, new GarbageCollectionAddDateParameters{EntityId = @entityId, Date = @date});
		}

		///<summary>Set the last_collection attribute to the current date and time.</summary>
		///<param name="target">The target for this service call</param>
		public void CollectGarbage(ServiceTarget target, GarbageCollectionCollectGarbageParameters data)
		{
			_haContext.CallService("garbage_collection", "collect_garbage", target, data);
		}

		///<summary>Set the last_collection attribute to the current date and time.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="entityId">The garbage_collection sensor entity_id eg: sensor.general_waste</param>
		///<param name="lastCollection">Date and time of the last collection (optional) eg: 2020-08-16 10:54:00</param>
		public void CollectGarbage(ServiceTarget target, object? @entityId = null, object? @lastCollection = null)
		{
			_haContext.CallService("garbage_collection", "collect_garbage", target, new GarbageCollectionCollectGarbageParameters{EntityId = @entityId, LastCollection = @lastCollection});
		}

		///<summary>Move the collection date by a number of days.</summary>
		///<param name="target">The target for this service call</param>
		public void OffsetDate(ServiceTarget target, GarbageCollectionOffsetDateParameters data)
		{
			_haContext.CallService("garbage_collection", "offset_date", target, data);
		}

		///<summary>Move the collection date by a number of days.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="entityId">The garbage_collection sensor entity_id eg: sensor.general_waste</param>
		///<param name="date">Collection date to move eg: "2020-08-16"</param>
		///<param name="offset">Nuber of days to move (negative number will move it back) eg: 1</param>
		public void OffsetDate(ServiceTarget target, object? @entityId = null, object? @date = null, object? @offset = null)
		{
			_haContext.CallService("garbage_collection", "offset_date", target, new GarbageCollectionOffsetDateParameters{EntityId = @entityId, Date = @date, Offset = @offset});
		}

		///<summary>Remove automatically calculated collection date.</summary>
		///<param name="target">The target for this service call</param>
		public void RemoveDate(ServiceTarget target, GarbageCollectionRemoveDateParameters data)
		{
			_haContext.CallService("garbage_collection", "remove_date", target, data);
		}

		///<summary>Remove automatically calculated collection date.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="entityId">The garbage_collection sensor entity_id eg: sensor.general_waste</param>
		///<param name="date">Collection date to remove eg: "2020-08-16"</param>
		public void RemoveDate(ServiceTarget target, object? @entityId = null, object? @date = null)
		{
			_haContext.CallService("garbage_collection", "remove_date", target, new GarbageCollectionRemoveDateParameters{EntityId = @entityId, Date = @date});
		}

		///<summary>Update the entity state and attributes. Used with the manual_update option, do defer the update after changing the automatically created schedule by automation trigered by the garbage_collection_loaded event.</summary>
		///<param name="target">The target for this service call</param>
		public void UpdateState(ServiceTarget target, GarbageCollectionUpdateStateParameters data)
		{
			_haContext.CallService("garbage_collection", "update_state", target, data);
		}

		///<summary>Update the entity state and attributes. Used with the manual_update option, do defer the update after changing the automatically created schedule by automation trigered by the garbage_collection_loaded event.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="entityId">The garbage_collection sensor entity_id eg: sensor.general_waste</param>
		public void UpdateState(ServiceTarget target, object? @entityId = null)
		{
			_haContext.CallService("garbage_collection", "update_state", target, new GarbageCollectionUpdateStateParameters{EntityId = @entityId});
		}
	}

	public record GarbageCollectionAddDateParameters
	{
		///<summary>The garbage_collection sensor entity_id eg: sensor.general_waste</summary>
		[JsonPropertyName("entity_id")]
		public object? EntityId { get; init; }

		///<summary>Collection date to add eg: "2020-08-16"</summary>
		[JsonPropertyName("date")]
		public object? Date { get; init; }
	}

	public record GarbageCollectionCollectGarbageParameters
	{
		///<summary>The garbage_collection sensor entity_id eg: sensor.general_waste</summary>
		[JsonPropertyName("entity_id")]
		public object? EntityId { get; init; }

		///<summary>Date and time of the last collection (optional) eg: 2020-08-16 10:54:00</summary>
		[JsonPropertyName("last_collection")]
		public object? LastCollection { get; init; }
	}

	public record GarbageCollectionOffsetDateParameters
	{
		///<summary>The garbage_collection sensor entity_id eg: sensor.general_waste</summary>
		[JsonPropertyName("entity_id")]
		public object? EntityId { get; init; }

		///<summary>Collection date to move eg: "2020-08-16"</summary>
		[JsonPropertyName("date")]
		public object? Date { get; init; }

		///<summary>Nuber of days to move (negative number will move it back) eg: 1</summary>
		[JsonPropertyName("offset")]
		public object? Offset { get; init; }
	}

	public record GarbageCollectionRemoveDateParameters
	{
		///<summary>The garbage_collection sensor entity_id eg: sensor.general_waste</summary>
		[JsonPropertyName("entity_id")]
		public object? EntityId { get; init; }

		///<summary>Collection date to remove eg: "2020-08-16"</summary>
		[JsonPropertyName("date")]
		public object? Date { get; init; }
	}

	public record GarbageCollectionUpdateStateParameters
	{
		///<summary>The garbage_collection sensor entity_id eg: sensor.general_waste</summary>
		[JsonPropertyName("entity_id")]
		public object? EntityId { get; init; }
	}

	public class GoogleServices
	{
		private readonly IHaContext _haContext;
		public GoogleServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Add a new calendar event.</summary>
		public void AddEvent(GoogleAddEventParameters data)
		{
			_haContext.CallService("google", "add_event", null, data);
		}

		///<summary>Add a new calendar event.</summary>
		///<param name="calendarId">The id of the calendar you want. eg: Your email</param>
		///<param name="summary">Acts as the title of the event. eg: Bowling</param>
		///<param name="description">The description of the event. Optional. eg: Birthday bowling</param>
		///<param name="startDateTime">The date and time the event should start. eg: 2019-03-22 20:00:00</param>
		///<param name="endDateTime">The date and time the event should end. eg: 2019-03-22 22:00:00</param>
		///<param name="startDate">The date the whole day event should start. eg: 2019-03-10</param>
		///<param name="endDate">The date the whole day event should end. eg: 2019-03-11</param>
		///<param name="in">Days or weeks that you want to create the event in. eg: "days": 2 or "weeks": 2</param>
		public void AddEvent(string @calendarId, string @summary, string? @description = null, string? @startDateTime = null, string? @endDateTime = null, string? @startDate = null, string? @endDate = null, object? @in = null)
		{
			_haContext.CallService("google", "add_event", null, new GoogleAddEventParameters{CalendarId = @calendarId, Summary = @summary, Description = @description, StartDateTime = @startDateTime, EndDateTime = @endDateTime, StartDate = @startDate, EndDate = @endDate, In = @in});
		}

		///<summary>Scan for new calendars.</summary>
		public void ScanForCalendars()
		{
			_haContext.CallService("google", "scan_for_calendars", null);
		}
	}

	public record GoogleAddEventParameters
	{
		///<summary>The id of the calendar you want. eg: Your email</summary>
		[JsonPropertyName("calendar_id")]
		public string? CalendarId { get; init; }

		///<summary>Acts as the title of the event. eg: Bowling</summary>
		[JsonPropertyName("summary")]
		public string? Summary { get; init; }

		///<summary>The description of the event. Optional. eg: Birthday bowling</summary>
		[JsonPropertyName("description")]
		public string? Description { get; init; }

		///<summary>The date and time the event should start. eg: 2019-03-22 20:00:00</summary>
		[JsonPropertyName("start_date_time")]
		public string? StartDateTime { get; init; }

		///<summary>The date and time the event should end. eg: 2019-03-22 22:00:00</summary>
		[JsonPropertyName("end_date_time")]
		public string? EndDateTime { get; init; }

		///<summary>The date the whole day event should start. eg: 2019-03-10</summary>
		[JsonPropertyName("start_date")]
		public string? StartDate { get; init; }

		///<summary>The date the whole day event should end. eg: 2019-03-11</summary>
		[JsonPropertyName("end_date")]
		public string? EndDate { get; init; }

		///<summary>Days or weeks that you want to create the event in. eg: "days": 2 or "weeks": 2</summary>
		[JsonPropertyName("in")]
		public object? In { get; init; }
	}

	public class GroupServices
	{
		private readonly IHaContext _haContext;
		public GroupServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Reload group configuration, entities, and notify services.</summary>
		public void Reload()
		{
			_haContext.CallService("group", "reload", null);
		}

		///<summary>Remove a user group.</summary>
		public void Remove(GroupRemoveParameters data)
		{
			_haContext.CallService("group", "remove", null, data);
		}

		///<summary>Remove a user group.</summary>
		///<param name="objectId">Group id and part of entity id. eg: test_group</param>
		public void Remove(object @objectId)
		{
			_haContext.CallService("group", "remove", null, new GroupRemoveParameters{ObjectId = @objectId});
		}

		///<summary>Create/Update a user group.</summary>
		public void Set(GroupSetParameters data)
		{
			_haContext.CallService("group", "set", null, data);
		}

		///<summary>Create/Update a user group.</summary>
		///<param name="objectId">Group id and part of entity id. eg: test_group</param>
		///<param name="name">Name of group eg: My test group</param>
		///<param name="icon">Name of icon for the group. eg: mdi:camera</param>
		///<param name="entities">List of all members in the group. Not compatible with 'delta'. eg: domain.entity_id1, domain.entity_id2</param>
		///<param name="addEntities">List of members that will change on group listening. eg: domain.entity_id1, domain.entity_id2</param>
		///<param name="all">Enable this option if the group should only turn on when all entities are on.</param>
		public void Set(string @objectId, string? @name = null, object? @icon = null, object? @entities = null, object? @addEntities = null, bool? @all = null)
		{
			_haContext.CallService("group", "set", null, new GroupSetParameters{ObjectId = @objectId, Name = @name, Icon = @icon, Entities = @entities, AddEntities = @addEntities, All = @all});
		}
	}

	public record GroupRemoveParameters
	{
		///<summary>Group id and part of entity id. eg: test_group</summary>
		[JsonPropertyName("object_id")]
		public object? ObjectId { get; init; }
	}

	public record GroupSetParameters
	{
		///<summary>Group id and part of entity id. eg: test_group</summary>
		[JsonPropertyName("object_id")]
		public string? ObjectId { get; init; }

		///<summary>Name of group eg: My test group</summary>
		[JsonPropertyName("name")]
		public string? Name { get; init; }

		///<summary>Name of icon for the group. eg: mdi:camera</summary>
		[JsonPropertyName("icon")]
		public object? Icon { get; init; }

		///<summary>List of all members in the group. Not compatible with 'delta'. eg: domain.entity_id1, domain.entity_id2</summary>
		[JsonPropertyName("entities")]
		public object? Entities { get; init; }

		///<summary>List of members that will change on group listening. eg: domain.entity_id1, domain.entity_id2</summary>
		[JsonPropertyName("add_entities")]
		public object? AddEntities { get; init; }

		///<summary>Enable this option if the group should only turn on when all entities are on.</summary>
		[JsonPropertyName("all")]
		public bool? All { get; init; }
	}

	public class HassioServices
	{
		private readonly IHaContext _haContext;
		public HassioServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Restart add-on.</summary>
		public void AddonRestart(HassioAddonRestartParameters data)
		{
			_haContext.CallService("hassio", "addon_restart", null, data);
		}

		///<summary>Restart add-on.</summary>
		///<param name="addon">The add-on slug. eg: core_ssh</param>
		public void AddonRestart(string @addon)
		{
			_haContext.CallService("hassio", "addon_restart", null, new HassioAddonRestartParameters{Addon = @addon});
		}

		///<summary>Start add-on.</summary>
		public void AddonStart(HassioAddonStartParameters data)
		{
			_haContext.CallService("hassio", "addon_start", null, data);
		}

		///<summary>Start add-on.</summary>
		///<param name="addon">The add-on slug. eg: core_ssh</param>
		public void AddonStart(string @addon)
		{
			_haContext.CallService("hassio", "addon_start", null, new HassioAddonStartParameters{Addon = @addon});
		}

		///<summary>Write data to add-on stdin.</summary>
		public void AddonStdin(HassioAddonStdinParameters data)
		{
			_haContext.CallService("hassio", "addon_stdin", null, data);
		}

		///<summary>Write data to add-on stdin.</summary>
		///<param name="addon">The add-on slug. eg: core_ssh</param>
		public void AddonStdin(string @addon)
		{
			_haContext.CallService("hassio", "addon_stdin", null, new HassioAddonStdinParameters{Addon = @addon});
		}

		///<summary>Stop add-on.</summary>
		public void AddonStop(HassioAddonStopParameters data)
		{
			_haContext.CallService("hassio", "addon_stop", null, data);
		}

		///<summary>Stop add-on.</summary>
		///<param name="addon">The add-on slug. eg: core_ssh</param>
		public void AddonStop(string @addon)
		{
			_haContext.CallService("hassio", "addon_stop", null, new HassioAddonStopParameters{Addon = @addon});
		}

		///<summary>Update add-on. This service should be used with caution since add-on updates can contain breaking changes. It is highly recommended that you review release notes/change logs before updating an add-on.</summary>
		public void AddonUpdate(HassioAddonUpdateParameters data)
		{
			_haContext.CallService("hassio", "addon_update", null, data);
		}

		///<summary>Update add-on. This service should be used with caution since add-on updates can contain breaking changes. It is highly recommended that you review release notes/change logs before updating an add-on.</summary>
		///<param name="addon">The add-on slug. eg: core_ssh</param>
		public void AddonUpdate(string @addon)
		{
			_haContext.CallService("hassio", "addon_update", null, new HassioAddonUpdateParameters{Addon = @addon});
		}

		///<summary>Create a full backup.</summary>
		public void BackupFull(HassioBackupFullParameters data)
		{
			_haContext.CallService("hassio", "backup_full", null, data);
		}

		///<summary>Create a full backup.</summary>
		///<param name="name">Optional (default = current date and time). eg: Backup 1</param>
		///<param name="password">Optional password. eg: password</param>
		///<param name="compressed">Use compressed archives</param>
		public void BackupFull(string? @name = null, string? @password = null, bool? @compressed = null)
		{
			_haContext.CallService("hassio", "backup_full", null, new HassioBackupFullParameters{Name = @name, Password = @password, Compressed = @compressed});
		}

		///<summary>Create a partial backup.</summary>
		public void BackupPartial(HassioBackupPartialParameters data)
		{
			_haContext.CallService("hassio", "backup_partial", null, data);
		}

		///<summary>Create a partial backup.</summary>
		///<param name="homeassistant">Backup Home Assistant settings</param>
		///<param name="addons">Optional list of add-on slugs. eg: ["core_ssh","core_samba","core_mosquitto"]</param>
		///<param name="folders">Optional list of directories. eg: ["homeassistant","share"]</param>
		///<param name="name">Optional (default = current date and time). eg: Partial backup 1</param>
		///<param name="password">Optional password. eg: password</param>
		///<param name="compressed">Use compressed archives</param>
		public void BackupPartial(bool? @homeassistant = null, object? @addons = null, object? @folders = null, string? @name = null, string? @password = null, bool? @compressed = null)
		{
			_haContext.CallService("hassio", "backup_partial", null, new HassioBackupPartialParameters{Homeassistant = @homeassistant, Addons = @addons, Folders = @folders, Name = @name, Password = @password, Compressed = @compressed});
		}

		///<summary>Reboot the host system.</summary>
		public void HostReboot()
		{
			_haContext.CallService("hassio", "host_reboot", null);
		}

		///<summary>Poweroff the host system.</summary>
		public void HostShutdown()
		{
			_haContext.CallService("hassio", "host_shutdown", null);
		}

		///<summary>Restore from full backup.</summary>
		public void RestoreFull(HassioRestoreFullParameters data)
		{
			_haContext.CallService("hassio", "restore_full", null, data);
		}

		///<summary>Restore from full backup.</summary>
		///<param name="slug">Slug of backup to restore from.</param>
		///<param name="password">Optional password. eg: password</param>
		public void RestoreFull(string @slug, string? @password = null)
		{
			_haContext.CallService("hassio", "restore_full", null, new HassioRestoreFullParameters{Slug = @slug, Password = @password});
		}

		///<summary>Restore from partial backup.</summary>
		public void RestorePartial(HassioRestorePartialParameters data)
		{
			_haContext.CallService("hassio", "restore_partial", null, data);
		}

		///<summary>Restore from partial backup.</summary>
		///<param name="slug">Slug of backup to restore from.</param>
		///<param name="homeassistant">Restore Home Assistant</param>
		///<param name="folders">Optional list of directories. eg: ["homeassistant","share"]</param>
		///<param name="addons">Optional list of add-on slugs. eg: ["core_ssh","core_samba","core_mosquitto"]</param>
		///<param name="password">Optional password. eg: password</param>
		public void RestorePartial(string @slug, bool? @homeassistant = null, object? @folders = null, object? @addons = null, string? @password = null)
		{
			_haContext.CallService("hassio", "restore_partial", null, new HassioRestorePartialParameters{Slug = @slug, Homeassistant = @homeassistant, Folders = @folders, Addons = @addons, Password = @password});
		}
	}

	public record HassioAddonRestartParameters
	{
		///<summary>The add-on slug. eg: core_ssh</summary>
		[JsonPropertyName("addon")]
		public string? Addon { get; init; }
	}

	public record HassioAddonStartParameters
	{
		///<summary>The add-on slug. eg: core_ssh</summary>
		[JsonPropertyName("addon")]
		public string? Addon { get; init; }
	}

	public record HassioAddonStdinParameters
	{
		///<summary>The add-on slug. eg: core_ssh</summary>
		[JsonPropertyName("addon")]
		public string? Addon { get; init; }
	}

	public record HassioAddonStopParameters
	{
		///<summary>The add-on slug. eg: core_ssh</summary>
		[JsonPropertyName("addon")]
		public string? Addon { get; init; }
	}

	public record HassioAddonUpdateParameters
	{
		///<summary>The add-on slug. eg: core_ssh</summary>
		[JsonPropertyName("addon")]
		public string? Addon { get; init; }
	}

	public record HassioBackupFullParameters
	{
		///<summary>Optional (default = current date and time). eg: Backup 1</summary>
		[JsonPropertyName("name")]
		public string? Name { get; init; }

		///<summary>Optional password. eg: password</summary>
		[JsonPropertyName("password")]
		public string? Password { get; init; }

		///<summary>Use compressed archives</summary>
		[JsonPropertyName("compressed")]
		public bool? Compressed { get; init; }
	}

	public record HassioBackupPartialParameters
	{
		///<summary>Backup Home Assistant settings</summary>
		[JsonPropertyName("homeassistant")]
		public bool? Homeassistant { get; init; }

		///<summary>Optional list of add-on slugs. eg: ["core_ssh","core_samba","core_mosquitto"]</summary>
		[JsonPropertyName("addons")]
		public object? Addons { get; init; }

		///<summary>Optional list of directories. eg: ["homeassistant","share"]</summary>
		[JsonPropertyName("folders")]
		public object? Folders { get; init; }

		///<summary>Optional (default = current date and time). eg: Partial backup 1</summary>
		[JsonPropertyName("name")]
		public string? Name { get; init; }

		///<summary>Optional password. eg: password</summary>
		[JsonPropertyName("password")]
		public string? Password { get; init; }

		///<summary>Use compressed archives</summary>
		[JsonPropertyName("compressed")]
		public bool? Compressed { get; init; }
	}

	public record HassioRestoreFullParameters
	{
		///<summary>Slug of backup to restore from.</summary>
		[JsonPropertyName("slug")]
		public string? Slug { get; init; }

		///<summary>Optional password. eg: password</summary>
		[JsonPropertyName("password")]
		public string? Password { get; init; }
	}

	public record HassioRestorePartialParameters
	{
		///<summary>Slug of backup to restore from.</summary>
		[JsonPropertyName("slug")]
		public string? Slug { get; init; }

		///<summary>Restore Home Assistant</summary>
		[JsonPropertyName("homeassistant")]
		public bool? Homeassistant { get; init; }

		///<summary>Optional list of directories. eg: ["homeassistant","share"]</summary>
		[JsonPropertyName("folders")]
		public object? Folders { get; init; }

		///<summary>Optional list of add-on slugs. eg: ["core_ssh","core_samba","core_mosquitto"]</summary>
		[JsonPropertyName("addons")]
		public object? Addons { get; init; }

		///<summary>Optional password. eg: password</summary>
		[JsonPropertyName("password")]
		public string? Password { get; init; }
	}

	public class HomeassistantServices
	{
		private readonly IHaContext _haContext;
		public HomeassistantServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Check the Home Assistant configuration files for errors. Errors will be displayed in the Home Assistant log.</summary>
		public void CheckConfig()
		{
			_haContext.CallService("homeassistant", "check_config", null);
		}

		///<summary>Reload a config entry that matches a target.</summary>
		///<param name="target">The target for this service call</param>
		public void ReloadConfigEntry(ServiceTarget target, HomeassistantReloadConfigEntryParameters data)
		{
			_haContext.CallService("homeassistant", "reload_config_entry", target, data);
		}

		///<summary>Reload a config entry that matches a target.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="entryId">A configuration entry id eg: 8955375327824e14ba89e4b29cc3ec9a</param>
		public void ReloadConfigEntry(ServiceTarget target, string? @entryId = null)
		{
			_haContext.CallService("homeassistant", "reload_config_entry", target, new HomeassistantReloadConfigEntryParameters{EntryId = @entryId});
		}

		///<summary>Reload the core configuration.</summary>
		public void ReloadCoreConfig()
		{
			_haContext.CallService("homeassistant", "reload_core_config", null);
		}

		///<summary>Restart the Home Assistant service.</summary>
		public void Restart()
		{
			_haContext.CallService("homeassistant", "restart", null);
		}

		///<summary>Save the persistent states (for entities derived from RestoreEntity) immediately. Maintain the normal periodic saving interval.</summary>
		public void SavePersistentStates()
		{
			_haContext.CallService("homeassistant", "save_persistent_states", null);
		}

		///<summary>Update the Home Assistant location.</summary>
		public void SetLocation(HomeassistantSetLocationParameters data)
		{
			_haContext.CallService("homeassistant", "set_location", null, data);
		}

		///<summary>Update the Home Assistant location.</summary>
		///<param name="latitude">Latitude of your location. eg: 32.87336</param>
		///<param name="longitude">Longitude of your location. eg: 117.22743</param>
		public void SetLocation(string @latitude, string @longitude)
		{
			_haContext.CallService("homeassistant", "set_location", null, new HomeassistantSetLocationParameters{Latitude = @latitude, Longitude = @longitude});
		}

		///<summary>Stop the Home Assistant service.</summary>
		public void Stop()
		{
			_haContext.CallService("homeassistant", "stop", null);
		}

		///<summary>Generic service to toggle devices on/off under any domain</summary>
		///<param name="target">The target for this service call</param>
		public void Toggle(ServiceTarget target)
		{
			_haContext.CallService("homeassistant", "toggle", target);
		}

		///<summary>Generic service to turn devices off under any domain.</summary>
		///<param name="target">The target for this service call</param>
		public void TurnOff(ServiceTarget target)
		{
			_haContext.CallService("homeassistant", "turn_off", target);
		}

		///<summary>Generic service to turn devices on under any domain.</summary>
		///<param name="target">The target for this service call</param>
		public void TurnOn(ServiceTarget target)
		{
			_haContext.CallService("homeassistant", "turn_on", target);
		}

		///<summary>Force one or more entities to update its data</summary>
		///<param name="target">The target for this service call</param>
		public void UpdateEntity(ServiceTarget target)
		{
			_haContext.CallService("homeassistant", "update_entity", target);
		}
	}

	public record HomeassistantReloadConfigEntryParameters
	{
		///<summary>A configuration entry id eg: 8955375327824e14ba89e4b29cc3ec9a</summary>
		[JsonPropertyName("entry_id")]
		public string? EntryId { get; init; }
	}

	public record HomeassistantSetLocationParameters
	{
		///<summary>Latitude of your location. eg: 32.87336</summary>
		[JsonPropertyName("latitude")]
		public string? Latitude { get; init; }

		///<summary>Longitude of your location. eg: 117.22743</summary>
		[JsonPropertyName("longitude")]
		public string? Longitude { get; init; }
	}

	public class HumidifierServices
	{
		private readonly IHaContext _haContext;
		public HumidifierServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Set target humidity of humidifier device.</summary>
		///<param name="target">The target for this service call</param>
		public void SetHumidity(ServiceTarget target, HumidifierSetHumidityParameters data)
		{
			_haContext.CallService("humidifier", "set_humidity", target, data);
		}

		///<summary>Set target humidity of humidifier device.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="humidity">New target humidity for humidifier device.</param>
		public void SetHumidity(ServiceTarget target, long @humidity)
		{
			_haContext.CallService("humidifier", "set_humidity", target, new HumidifierSetHumidityParameters{Humidity = @humidity});
		}

		///<summary>Set mode for humidifier device.</summary>
		///<param name="target">The target for this service call</param>
		public void SetMode(ServiceTarget target, HumidifierSetModeParameters data)
		{
			_haContext.CallService("humidifier", "set_mode", target, data);
		}

		///<summary>Set mode for humidifier device.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="mode">New mode eg: away</param>
		public void SetMode(ServiceTarget target, string @mode)
		{
			_haContext.CallService("humidifier", "set_mode", target, new HumidifierSetModeParameters{Mode = @mode});
		}

		///<summary>Toggles a humidifier device.</summary>
		///<param name="target">The target for this service call</param>
		public void Toggle(ServiceTarget target)
		{
			_haContext.CallService("humidifier", "toggle", target);
		}

		///<summary>Turn humidifier device off.</summary>
		///<param name="target">The target for this service call</param>
		public void TurnOff(ServiceTarget target)
		{
			_haContext.CallService("humidifier", "turn_off", target);
		}

		///<summary>Turn humidifier device on.</summary>
		///<param name="target">The target for this service call</param>
		public void TurnOn(ServiceTarget target)
		{
			_haContext.CallService("humidifier", "turn_on", target);
		}
	}

	public record HumidifierSetHumidityParameters
	{
		///<summary>New target humidity for humidifier device.</summary>
		[JsonPropertyName("humidity")]
		public long? Humidity { get; init; }
	}

	public record HumidifierSetModeParameters
	{
		///<summary>New mode eg: away</summary>
		[JsonPropertyName("mode")]
		public string? Mode { get; init; }
	}

	public class InputBooleanServices
	{
		private readonly IHaContext _haContext;
		public InputBooleanServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Reload the input_boolean configuration</summary>
		public void Reload()
		{
			_haContext.CallService("input_boolean", "reload", null);
		}

		///<summary>Toggle an input boolean</summary>
		///<param name="target">The target for this service call</param>
		public void Toggle(ServiceTarget target)
		{
			_haContext.CallService("input_boolean", "toggle", target);
		}

		///<summary>Turn off an input boolean</summary>
		///<param name="target">The target for this service call</param>
		public void TurnOff(ServiceTarget target)
		{
			_haContext.CallService("input_boolean", "turn_off", target);
		}

		///<summary>Turn on an input boolean</summary>
		///<param name="target">The target for this service call</param>
		public void TurnOn(ServiceTarget target)
		{
			_haContext.CallService("input_boolean", "turn_on", target);
		}
	}

	public class InputButtonServices
	{
		private readonly IHaContext _haContext;
		public InputButtonServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Press the input button entity.</summary>
		///<param name="target">The target for this service call</param>
		public void Press(ServiceTarget target)
		{
			_haContext.CallService("input_button", "press", target);
		}

		public void Reload()
		{
			_haContext.CallService("input_button", "reload", null);
		}
	}

	public class InputDatetimeServices
	{
		private readonly IHaContext _haContext;
		public InputDatetimeServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Reload the input_datetime configuration.</summary>
		public void Reload()
		{
			_haContext.CallService("input_datetime", "reload", null);
		}

		///<summary>This can be used to dynamically set the date and/or time.</summary>
		///<param name="target">The target for this service call</param>
		public void SetDatetime(ServiceTarget target, InputDatetimeSetDatetimeParameters data)
		{
			_haContext.CallService("input_datetime", "set_datetime", target, data);
		}

		///<summary>This can be used to dynamically set the date and/or time.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="date">The target date the entity should be set to. eg: "2019-04-20"</param>
		///<param name="time">The target time the entity should be set to. eg: "05:04:20"</param>
		///<param name="datetime">The target date & time the entity should be set to. eg: "2019-04-20 05:04:20"</param>
		///<param name="timestamp">The target date & time the entity should be set to as expressed by a UNIX timestamp.</param>
		public void SetDatetime(ServiceTarget target, string? @date = null, DateTime? @time = null, string? @datetime = null, long? @timestamp = null)
		{
			_haContext.CallService("input_datetime", "set_datetime", target, new InputDatetimeSetDatetimeParameters{Date = @date, Time = @time, Datetime = @datetime, Timestamp = @timestamp});
		}
	}

	public record InputDatetimeSetDatetimeParameters
	{
		///<summary>The target date the entity should be set to. eg: "2019-04-20"</summary>
		[JsonPropertyName("date")]
		public string? Date { get; init; }

		///<summary>The target time the entity should be set to. eg: "05:04:20"</summary>
		[JsonPropertyName("time")]
		public DateTime? Time { get; init; }

		///<summary>The target date & time the entity should be set to. eg: "2019-04-20 05:04:20"</summary>
		[JsonPropertyName("datetime")]
		public string? Datetime { get; init; }

		///<summary>The target date & time the entity should be set to as expressed by a UNIX timestamp.</summary>
		[JsonPropertyName("timestamp")]
		public long? Timestamp { get; init; }
	}

	public class InputNumberServices
	{
		private readonly IHaContext _haContext;
		public InputNumberServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Decrement the value of an input number entity by its stepping.</summary>
		///<param name="target">The target for this service call</param>
		public void Decrement(ServiceTarget target)
		{
			_haContext.CallService("input_number", "decrement", target);
		}

		///<summary>Increment the value of an input number entity by its stepping.</summary>
		///<param name="target">The target for this service call</param>
		public void Increment(ServiceTarget target)
		{
			_haContext.CallService("input_number", "increment", target);
		}

		///<summary>Reload the input_number configuration.</summary>
		public void Reload()
		{
			_haContext.CallService("input_number", "reload", null);
		}

		///<summary>Set the value of an input number entity.</summary>
		///<param name="target">The target for this service call</param>
		public void SetValue(ServiceTarget target, InputNumberSetValueParameters data)
		{
			_haContext.CallService("input_number", "set_value", target, data);
		}

		///<summary>Set the value of an input number entity.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="value">The target value the entity should be set to.</param>
		public void SetValue(ServiceTarget target, double @value)
		{
			_haContext.CallService("input_number", "set_value", target, new InputNumberSetValueParameters{Value = @value});
		}
	}

	public record InputNumberSetValueParameters
	{
		///<summary>The target value the entity should be set to.</summary>
		[JsonPropertyName("value")]
		public double? Value { get; init; }
	}

	public class InputSelectServices
	{
		private readonly IHaContext _haContext;
		public InputSelectServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Reload the input_select configuration.</summary>
		public void Reload()
		{
			_haContext.CallService("input_select", "reload", null);
		}

		///<summary>Select the first option of an input select entity.</summary>
		///<param name="target">The target for this service call</param>
		public void SelectFirst(ServiceTarget target)
		{
			_haContext.CallService("input_select", "select_first", target);
		}

		///<summary>Select the last option of an input select entity.</summary>
		///<param name="target">The target for this service call</param>
		public void SelectLast(ServiceTarget target)
		{
			_haContext.CallService("input_select", "select_last", target);
		}

		///<summary>Select the next options of an input select entity.</summary>
		///<param name="target">The target for this service call</param>
		public void SelectNext(ServiceTarget target, InputSelectSelectNextParameters data)
		{
			_haContext.CallService("input_select", "select_next", target, data);
		}

		///<summary>Select the next options of an input select entity.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="cycle">If the option should cycle from the last to the first.</param>
		public void SelectNext(ServiceTarget target, bool? @cycle = null)
		{
			_haContext.CallService("input_select", "select_next", target, new InputSelectSelectNextParameters{Cycle = @cycle});
		}

		///<summary>Select an option of an input select entity.</summary>
		///<param name="target">The target for this service call</param>
		public void SelectOption(ServiceTarget target, InputSelectSelectOptionParameters data)
		{
			_haContext.CallService("input_select", "select_option", target, data);
		}

		///<summary>Select an option of an input select entity.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="option">Option to be selected. eg: "Item A"</param>
		public void SelectOption(ServiceTarget target, string @option)
		{
			_haContext.CallService("input_select", "select_option", target, new InputSelectSelectOptionParameters{Option = @option});
		}

		///<summary>Select the previous options of an input select entity.</summary>
		///<param name="target">The target for this service call</param>
		public void SelectPrevious(ServiceTarget target, InputSelectSelectPreviousParameters data)
		{
			_haContext.CallService("input_select", "select_previous", target, data);
		}

		///<summary>Select the previous options of an input select entity.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="cycle">If the option should cycle from the first to the last.</param>
		public void SelectPrevious(ServiceTarget target, bool? @cycle = null)
		{
			_haContext.CallService("input_select", "select_previous", target, new InputSelectSelectPreviousParameters{Cycle = @cycle});
		}

		///<summary>Set the options of an input select entity.</summary>
		///<param name="target">The target for this service call</param>
		public void SetOptions(ServiceTarget target, InputSelectSetOptionsParameters data)
		{
			_haContext.CallService("input_select", "set_options", target, data);
		}

		///<summary>Set the options of an input select entity.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="options">Options for the input select entity. eg: ["Item A", "Item B", "Item C"]</param>
		public void SetOptions(ServiceTarget target, object @options)
		{
			_haContext.CallService("input_select", "set_options", target, new InputSelectSetOptionsParameters{Options = @options});
		}
	}

	public record InputSelectSelectNextParameters
	{
		///<summary>If the option should cycle from the last to the first.</summary>
		[JsonPropertyName("cycle")]
		public bool? Cycle { get; init; }
	}

	public record InputSelectSelectOptionParameters
	{
		///<summary>Option to be selected. eg: "Item A"</summary>
		[JsonPropertyName("option")]
		public string? Option { get; init; }
	}

	public record InputSelectSelectPreviousParameters
	{
		///<summary>If the option should cycle from the first to the last.</summary>
		[JsonPropertyName("cycle")]
		public bool? Cycle { get; init; }
	}

	public record InputSelectSetOptionsParameters
	{
		///<summary>Options for the input select entity. eg: ["Item A", "Item B", "Item C"]</summary>
		[JsonPropertyName("options")]
		public object? Options { get; init; }
	}

	public class InputTextServices
	{
		private readonly IHaContext _haContext;
		public InputTextServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Reload the input_text configuration.</summary>
		public void Reload()
		{
			_haContext.CallService("input_text", "reload", null);
		}

		///<summary>Set the value of an input text entity.</summary>
		///<param name="target">The target for this service call</param>
		public void SetValue(ServiceTarget target, InputTextSetValueParameters data)
		{
			_haContext.CallService("input_text", "set_value", target, data);
		}

		///<summary>Set the value of an input text entity.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="value">The target value the entity should be set to. eg: This is an example text</param>
		public void SetValue(ServiceTarget target, string @value)
		{
			_haContext.CallService("input_text", "set_value", target, new InputTextSetValueParameters{Value = @value});
		}
	}

	public record InputTextSetValueParameters
	{
		///<summary>The target value the entity should be set to. eg: This is an example text</summary>
		[JsonPropertyName("value")]
		public string? Value { get; init; }
	}

	public class LightServices
	{
		private readonly IHaContext _haContext;
		public LightServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Toggles one or more lights, from on to off, or, off to on, based on their current state. </summary>
		///<param name="target">The target for this service call</param>
		public void Toggle(ServiceTarget target, LightToggleParameters data)
		{
			_haContext.CallService("light", "toggle", target, data);
		}

		///<summary>Toggles one or more lights, from on to off, or, off to on, based on their current state. </summary>
		///<param name="target">The target for this service call</param>
		///<param name="transition">Duration it takes to get to next state.</param>
		///<param name="rgbColor">Color for the light in RGB-format. eg: [255, 100, 100]</param>
		///<param name="colorName">A human readable color name.</param>
		///<param name="hsColor">Color for the light in hue/sat format. Hue is 0-360 and Sat is 0-100. eg: [300, 70]</param>
		///<param name="xyColor">Color for the light in XY-format. eg: [0.52, 0.43]</param>
		///<param name="colorTemp">Color temperature for the light in mireds.</param>
		///<param name="kelvin">Color temperature for the light in Kelvin.</param>
		///<param name="whiteValue">Number indicating level of white.</param>
		///<param name="brightness">Number indicating brightness, where 0 turns the light off, 1 is the minimum brightness and 255 is the maximum brightness supported by the light.</param>
		///<param name="brightnessPct">Number indicating percentage of full brightness, where 0 turns the light off, 1 is the minimum brightness and 100 is the maximum brightness supported by the light.</param>
		///<param name="profile">Name of a light profile to use. eg: relax</param>
		///<param name="flash">If the light should flash.</param>
		///<param name="effect">Light effect.</param>
		public void Toggle(ServiceTarget target, long? @transition = null, object? @rgbColor = null, object? @colorName = null, object? @hsColor = null, object? @xyColor = null, object? @colorTemp = null, long? @kelvin = null, long? @whiteValue = null, long? @brightness = null, long? @brightnessPct = null, string? @profile = null, object? @flash = null, string? @effect = null)
		{
			_haContext.CallService("light", "toggle", target, new LightToggleParameters{Transition = @transition, RgbColor = @rgbColor, ColorName = @colorName, HsColor = @hsColor, XyColor = @xyColor, ColorTemp = @colorTemp, Kelvin = @kelvin, WhiteValue = @whiteValue, Brightness = @brightness, BrightnessPct = @brightnessPct, Profile = @profile, Flash = @flash, Effect = @effect});
		}

		///<summary>Turns off one or more lights.</summary>
		///<param name="target">The target for this service call</param>
		public void TurnOff(ServiceTarget target, LightTurnOffParameters data)
		{
			_haContext.CallService("light", "turn_off", target, data);
		}

		///<summary>Turns off one or more lights.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="transition">Duration it takes to get to next state.</param>
		///<param name="flash">If the light should flash.</param>
		public void TurnOff(ServiceTarget target, long? @transition = null, object? @flash = null)
		{
			_haContext.CallService("light", "turn_off", target, new LightTurnOffParameters{Transition = @transition, Flash = @flash});
		}

		///<summary>Turn on one or more lights and adjust properties of the light, even when they are turned on already. </summary>
		///<param name="target">The target for this service call</param>
		public void TurnOn(ServiceTarget target, LightTurnOnParameters data)
		{
			_haContext.CallService("light", "turn_on", target, data);
		}

		///<summary>Turn on one or more lights and adjust properties of the light, even when they are turned on already. </summary>
		///<param name="target">The target for this service call</param>
		///<param name="transition">Duration it takes to get to next state.</param>
		///<param name="rgbColor">The color for the light (based on RGB - red, green, blue).</param>
		///<param name="rgbwColor">A list containing four integers between 0 and 255 representing the RGBW (red, green, blue, white) color for the light. eg: [255, 100, 100, 50]</param>
		///<param name="rgbwwColor">A list containing five integers between 0 and 255 representing the RGBWW (red, green, blue, cold white, warm white) color for the light. eg: [255, 100, 100, 50, 70]</param>
		///<param name="colorName">A human readable color name.</param>
		///<param name="hsColor">Color for the light in hue/sat format. Hue is 0-360 and Sat is 0-100. eg: [300, 70]</param>
		///<param name="xyColor">Color for the light in XY-format. eg: [0.52, 0.43]</param>
		///<param name="colorTemp">Color temperature for the light in mireds.</param>
		///<param name="kelvin">Color temperature for the light in Kelvin.</param>
		///<param name="brightness">Number indicating brightness, where 0 turns the light off, 1 is the minimum brightness and 255 is the maximum brightness supported by the light.</param>
		///<param name="brightnessPct">Number indicating percentage of full brightness, where 0 turns the light off, 1 is the minimum brightness and 100 is the maximum brightness supported by the light.</param>
		///<param name="brightnessStep">Change brightness by an amount.</param>
		///<param name="brightnessStepPct">Change brightness by a percentage.</param>
		///<param name="white">Set the light to white mode and change its brightness, where 0 turns the light off, 1 is the minimum brightness and 255 is the maximum brightness supported by the light.</param>
		///<param name="profile">Name of a light profile to use. eg: relax</param>
		///<param name="flash">If the light should flash.</param>
		///<param name="effect">Light effect.</param>
		public void TurnOn(ServiceTarget target, long? @transition = null, object? @rgbColor = null, object? @rgbwColor = null, object? @rgbwwColor = null, object? @colorName = null, object? @hsColor = null, object? @xyColor = null, object? @colorTemp = null, long? @kelvin = null, long? @brightness = null, long? @brightnessPct = null, long? @brightnessStep = null, long? @brightnessStepPct = null, long? @white = null, string? @profile = null, object? @flash = null, string? @effect = null)
		{
			_haContext.CallService("light", "turn_on", target, new LightTurnOnParameters{Transition = @transition, RgbColor = @rgbColor, RgbwColor = @rgbwColor, RgbwwColor = @rgbwwColor, ColorName = @colorName, HsColor = @hsColor, XyColor = @xyColor, ColorTemp = @colorTemp, Kelvin = @kelvin, Brightness = @brightness, BrightnessPct = @brightnessPct, BrightnessStep = @brightnessStep, BrightnessStepPct = @brightnessStepPct, White = @white, Profile = @profile, Flash = @flash, Effect = @effect});
		}
	}

	public record LightToggleParameters
	{
		///<summary>Duration it takes to get to next state.</summary>
		[JsonPropertyName("transition")]
		public long? Transition { get; init; }

		///<summary>Color for the light in RGB-format. eg: [255, 100, 100]</summary>
		[JsonPropertyName("rgb_color")]
		public object? RgbColor { get; init; }

		///<summary>A human readable color name.</summary>
		[JsonPropertyName("color_name")]
		public object? ColorName { get; init; }

		///<summary>Color for the light in hue/sat format. Hue is 0-360 and Sat is 0-100. eg: [300, 70]</summary>
		[JsonPropertyName("hs_color")]
		public object? HsColor { get; init; }

		///<summary>Color for the light in XY-format. eg: [0.52, 0.43]</summary>
		[JsonPropertyName("xy_color")]
		public object? XyColor { get; init; }

		///<summary>Color temperature for the light in mireds.</summary>
		[JsonPropertyName("color_temp")]
		public object? ColorTemp { get; init; }

		///<summary>Color temperature for the light in Kelvin.</summary>
		[JsonPropertyName("kelvin")]
		public long? Kelvin { get; init; }

		///<summary>Number indicating level of white.</summary>
		[JsonPropertyName("white_value")]
		public long? WhiteValue { get; init; }

		///<summary>Number indicating brightness, where 0 turns the light off, 1 is the minimum brightness and 255 is the maximum brightness supported by the light.</summary>
		[JsonPropertyName("brightness")]
		public long? Brightness { get; init; }

		///<summary>Number indicating percentage of full brightness, where 0 turns the light off, 1 is the minimum brightness and 100 is the maximum brightness supported by the light.</summary>
		[JsonPropertyName("brightness_pct")]
		public long? BrightnessPct { get; init; }

		///<summary>Name of a light profile to use. eg: relax</summary>
		[JsonPropertyName("profile")]
		public string? Profile { get; init; }

		///<summary>If the light should flash.</summary>
		[JsonPropertyName("flash")]
		public object? Flash { get; init; }

		///<summary>Light effect.</summary>
		[JsonPropertyName("effect")]
		public string? Effect { get; init; }
	}

	public record LightTurnOffParameters
	{
		///<summary>Duration it takes to get to next state.</summary>
		[JsonPropertyName("transition")]
		public long? Transition { get; init; }

		///<summary>If the light should flash.</summary>
		[JsonPropertyName("flash")]
		public object? Flash { get; init; }
	}

	public record LightTurnOnParameters
	{
		///<summary>Duration it takes to get to next state.</summary>
		[JsonPropertyName("transition")]
		public long? Transition { get; init; }

		///<summary>The color for the light (based on RGB - red, green, blue).</summary>
		[JsonPropertyName("rgb_color")]
		public object? RgbColor { get; init; }

		///<summary>A list containing four integers between 0 and 255 representing the RGBW (red, green, blue, white) color for the light. eg: [255, 100, 100, 50]</summary>
		[JsonPropertyName("rgbw_color")]
		public object? RgbwColor { get; init; }

		///<summary>A list containing five integers between 0 and 255 representing the RGBWW (red, green, blue, cold white, warm white) color for the light. eg: [255, 100, 100, 50, 70]</summary>
		[JsonPropertyName("rgbww_color")]
		public object? RgbwwColor { get; init; }

		///<summary>A human readable color name.</summary>
		[JsonPropertyName("color_name")]
		public object? ColorName { get; init; }

		///<summary>Color for the light in hue/sat format. Hue is 0-360 and Sat is 0-100. eg: [300, 70]</summary>
		[JsonPropertyName("hs_color")]
		public object? HsColor { get; init; }

		///<summary>Color for the light in XY-format. eg: [0.52, 0.43]</summary>
		[JsonPropertyName("xy_color")]
		public object? XyColor { get; init; }

		///<summary>Color temperature for the light in mireds.</summary>
		[JsonPropertyName("color_temp")]
		public object? ColorTemp { get; init; }

		///<summary>Color temperature for the light in Kelvin.</summary>
		[JsonPropertyName("kelvin")]
		public long? Kelvin { get; init; }

		///<summary>Number indicating brightness, where 0 turns the light off, 1 is the minimum brightness and 255 is the maximum brightness supported by the light.</summary>
		[JsonPropertyName("brightness")]
		public long? Brightness { get; init; }

		///<summary>Number indicating percentage of full brightness, where 0 turns the light off, 1 is the minimum brightness and 100 is the maximum brightness supported by the light.</summary>
		[JsonPropertyName("brightness_pct")]
		public long? BrightnessPct { get; init; }

		///<summary>Change brightness by an amount.</summary>
		[JsonPropertyName("brightness_step")]
		public long? BrightnessStep { get; init; }

		///<summary>Change brightness by a percentage.</summary>
		[JsonPropertyName("brightness_step_pct")]
		public long? BrightnessStepPct { get; init; }

		///<summary>Set the light to white mode and change its brightness, where 0 turns the light off, 1 is the minimum brightness and 255 is the maximum brightness supported by the light.</summary>
		[JsonPropertyName("white")]
		public long? White { get; init; }

		///<summary>Name of a light profile to use. eg: relax</summary>
		[JsonPropertyName("profile")]
		public string? Profile { get; init; }

		///<summary>If the light should flash.</summary>
		[JsonPropertyName("flash")]
		public object? Flash { get; init; }

		///<summary>Light effect.</summary>
		[JsonPropertyName("effect")]
		public string? Effect { get; init; }
	}

	public class LockServices
	{
		private readonly IHaContext _haContext;
		public LockServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Lock all or specified locks.</summary>
		///<param name="target">The target for this service call</param>
		public void Lock(ServiceTarget target, LockLockParameters data)
		{
			_haContext.CallService("lock", "lock", target, data);
		}

		///<summary>Lock all or specified locks.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="code">An optional code to lock the lock with. eg: 1234</param>
		public void Lock(ServiceTarget target, string? @code = null)
		{
			_haContext.CallService("lock", "lock", target, new LockLockParameters{Code = @code});
		}

		///<summary>Open all or specified locks.</summary>
		///<param name="target">The target for this service call</param>
		public void Open(ServiceTarget target, LockOpenParameters data)
		{
			_haContext.CallService("lock", "open", target, data);
		}

		///<summary>Open all or specified locks.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="code">An optional code to open the lock with. eg: 1234</param>
		public void Open(ServiceTarget target, string? @code = null)
		{
			_haContext.CallService("lock", "open", target, new LockOpenParameters{Code = @code});
		}

		///<summary>Unlock all or specified locks.</summary>
		///<param name="target">The target for this service call</param>
		public void Unlock(ServiceTarget target, LockUnlockParameters data)
		{
			_haContext.CallService("lock", "unlock", target, data);
		}

		///<summary>Unlock all or specified locks.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="code">An optional code to unlock the lock with. eg: 1234</param>
		public void Unlock(ServiceTarget target, string? @code = null)
		{
			_haContext.CallService("lock", "unlock", target, new LockUnlockParameters{Code = @code});
		}
	}

	public record LockLockParameters
	{
		///<summary>An optional code to lock the lock with. eg: 1234</summary>
		[JsonPropertyName("code")]
		public string? Code { get; init; }
	}

	public record LockOpenParameters
	{
		///<summary>An optional code to open the lock with. eg: 1234</summary>
		[JsonPropertyName("code")]
		public string? Code { get; init; }
	}

	public record LockUnlockParameters
	{
		///<summary>An optional code to unlock the lock with. eg: 1234</summary>
		[JsonPropertyName("code")]
		public string? Code { get; init; }
	}

	public class LogbookServices
	{
		private readonly IHaContext _haContext;
		public LogbookServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Create a custom entry in your logbook.</summary>
		public void Log(LogbookLogParameters data)
		{
			_haContext.CallService("logbook", "log", null, data);
		}

		///<summary>Create a custom entry in your logbook.</summary>
		///<param name="name">Custom name for an entity, can be referenced with entity_id. eg: Kitchen</param>
		///<param name="message">Message of the custom logbook entry. eg: is being used</param>
		///<param name="entityId">Entity to reference in custom logbook entry.</param>
		///<param name="domain">Icon of domain to display in custom logbook entry. eg: light</param>
		public void Log(string @name, string @message, string? @entityId = null, string? @domain = null)
		{
			_haContext.CallService("logbook", "log", null, new LogbookLogParameters{Name = @name, Message = @message, EntityId = @entityId, Domain = @domain});
		}
	}

	public record LogbookLogParameters
	{
		///<summary>Custom name for an entity, can be referenced with entity_id. eg: Kitchen</summary>
		[JsonPropertyName("name")]
		public string? Name { get; init; }

		///<summary>Message of the custom logbook entry. eg: is being used</summary>
		[JsonPropertyName("message")]
		public string? Message { get; init; }

		///<summary>Entity to reference in custom logbook entry.</summary>
		[JsonPropertyName("entity_id")]
		public string? EntityId { get; init; }

		///<summary>Icon of domain to display in custom logbook entry. eg: light</summary>
		[JsonPropertyName("domain")]
		public string? Domain { get; init; }
	}

	public class MediaPlayerServices
	{
		private readonly IHaContext _haContext;
		public MediaPlayerServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Send the media player the command to clear players playlist.</summary>
		///<param name="target">The target for this service call</param>
		public void ClearPlaylist(ServiceTarget target)
		{
			_haContext.CallService("media_player", "clear_playlist", target);
		}

		///<summary>Group players together. Only works on platforms with support for player groups.</summary>
		///<param name="target">The target for this service call</param>
		public void Join(ServiceTarget target, MediaPlayerJoinParameters data)
		{
			_haContext.CallService("media_player", "join", target, data);
		}

		///<summary>Group players together. Only works on platforms with support for player groups.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="groupMembers">The players which will be synced with the target player. eg: ["media_player.multiroom_player2","media_player.multiroom_player3"]</param>
		public void Join(ServiceTarget target, object? @groupMembers = null)
		{
			_haContext.CallService("media_player", "join", target, new MediaPlayerJoinParameters{GroupMembers = @groupMembers});
		}

		///<summary>Send the media player the command for next track.</summary>
		///<param name="target">The target for this service call</param>
		public void MediaNextTrack(ServiceTarget target)
		{
			_haContext.CallService("media_player", "media_next_track", target);
		}

		///<summary>Send the media player the command for pause.</summary>
		///<param name="target">The target for this service call</param>
		public void MediaPause(ServiceTarget target)
		{
			_haContext.CallService("media_player", "media_pause", target);
		}

		///<summary>Send the media player the command for play.</summary>
		///<param name="target">The target for this service call</param>
		public void MediaPlay(ServiceTarget target)
		{
			_haContext.CallService("media_player", "media_play", target);
		}

		///<summary>Toggle media player play/pause state.</summary>
		///<param name="target">The target for this service call</param>
		public void MediaPlayPause(ServiceTarget target)
		{
			_haContext.CallService("media_player", "media_play_pause", target);
		}

		///<summary>Send the media player the command for previous track.</summary>
		///<param name="target">The target for this service call</param>
		public void MediaPreviousTrack(ServiceTarget target)
		{
			_haContext.CallService("media_player", "media_previous_track", target);
		}

		///<summary>Send the media player the command to seek in current playing media.</summary>
		///<param name="target">The target for this service call</param>
		public void MediaSeek(ServiceTarget target, MediaPlayerMediaSeekParameters data)
		{
			_haContext.CallService("media_player", "media_seek", target, data);
		}

		///<summary>Send the media player the command to seek in current playing media.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="seekPosition">Position to seek to. The format is platform dependent.</param>
		public void MediaSeek(ServiceTarget target, double @seekPosition)
		{
			_haContext.CallService("media_player", "media_seek", target, new MediaPlayerMediaSeekParameters{SeekPosition = @seekPosition});
		}

		///<summary>Send the media player the stop command.</summary>
		///<param name="target">The target for this service call</param>
		public void MediaStop(ServiceTarget target)
		{
			_haContext.CallService("media_player", "media_stop", target);
		}

		///<summary>Send the media player the command for playing media.</summary>
		///<param name="target">The target for this service call</param>
		public void PlayMedia(ServiceTarget target, MediaPlayerPlayMediaParameters data)
		{
			_haContext.CallService("media_player", "play_media", target, data);
		}

		///<summary>Send the media player the command for playing media.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="mediaContentId">The ID of the content to play. Platform dependent. eg: https://home-assistant.io/images/cast/splash.png</param>
		///<param name="mediaContentType">The type of the content to play. Like image, music, tvshow, video, episode, channel or playlist. eg: music</param>
		///<param name="enqueue">If the content should be played now or be added to the queue.</param>
		///<param name="announce">If the media should be played as an announcement. eg: true</param>
		public void PlayMedia(ServiceTarget target, string @mediaContentId, string @mediaContentType, object? @enqueue = null, bool? @announce = null)
		{
			_haContext.CallService("media_player", "play_media", target, new MediaPlayerPlayMediaParameters{MediaContentId = @mediaContentId, MediaContentType = @mediaContentType, Enqueue = @enqueue, Announce = @announce});
		}

		///<summary>Set repeat mode</summary>
		///<param name="target">The target for this service call</param>
		public void RepeatSet(ServiceTarget target, MediaPlayerRepeatSetParameters data)
		{
			_haContext.CallService("media_player", "repeat_set", target, data);
		}

		///<summary>Set repeat mode</summary>
		///<param name="target">The target for this service call</param>
		///<param name="repeat">Repeat mode to set.</param>
		public void RepeatSet(ServiceTarget target, object @repeat)
		{
			_haContext.CallService("media_player", "repeat_set", target, new MediaPlayerRepeatSetParameters{Repeat = @repeat});
		}

		///<summary>Send the media player the command to change sound mode.</summary>
		///<param name="target">The target for this service call</param>
		public void SelectSoundMode(ServiceTarget target, MediaPlayerSelectSoundModeParameters data)
		{
			_haContext.CallService("media_player", "select_sound_mode", target, data);
		}

		///<summary>Send the media player the command to change sound mode.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="soundMode">Name of the sound mode to switch to. eg: Music</param>
		public void SelectSoundMode(ServiceTarget target, string? @soundMode = null)
		{
			_haContext.CallService("media_player", "select_sound_mode", target, new MediaPlayerSelectSoundModeParameters{SoundMode = @soundMode});
		}

		///<summary>Send the media player the command to change input source.</summary>
		///<param name="target">The target for this service call</param>
		public void SelectSource(ServiceTarget target, MediaPlayerSelectSourceParameters data)
		{
			_haContext.CallService("media_player", "select_source", target, data);
		}

		///<summary>Send the media player the command to change input source.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="source">Name of the source to switch to. Platform dependent. eg: video1</param>
		public void SelectSource(ServiceTarget target, string @source)
		{
			_haContext.CallService("media_player", "select_source", target, new MediaPlayerSelectSourceParameters{Source = @source});
		}

		///<summary>Set shuffling state.</summary>
		///<param name="target">The target for this service call</param>
		public void ShuffleSet(ServiceTarget target, MediaPlayerShuffleSetParameters data)
		{
			_haContext.CallService("media_player", "shuffle_set", target, data);
		}

		///<summary>Set shuffling state.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="shuffle">True/false for enabling/disabling shuffle.</param>
		public void ShuffleSet(ServiceTarget target, bool @shuffle)
		{
			_haContext.CallService("media_player", "shuffle_set", target, new MediaPlayerShuffleSetParameters{Shuffle = @shuffle});
		}

		///<summary>Toggles a media player power state.</summary>
		///<param name="target">The target for this service call</param>
		public void Toggle(ServiceTarget target)
		{
			_haContext.CallService("media_player", "toggle", target);
		}

		///<summary>Turn a media player power off.</summary>
		///<param name="target">The target for this service call</param>
		public void TurnOff(ServiceTarget target)
		{
			_haContext.CallService("media_player", "turn_off", target);
		}

		///<summary>Turn a media player power on.</summary>
		///<param name="target">The target for this service call</param>
		public void TurnOn(ServiceTarget target)
		{
			_haContext.CallService("media_player", "turn_on", target);
		}

		///<summary>Unjoin the player from a group. Only works on platforms with support for player groups.</summary>
		///<param name="target">The target for this service call</param>
		public void Unjoin(ServiceTarget target)
		{
			_haContext.CallService("media_player", "unjoin", target);
		}

		///<summary>Turn a media player volume down.</summary>
		///<param name="target">The target for this service call</param>
		public void VolumeDown(ServiceTarget target)
		{
			_haContext.CallService("media_player", "volume_down", target);
		}

		///<summary>Mute a media player's volume.</summary>
		///<param name="target">The target for this service call</param>
		public void VolumeMute(ServiceTarget target, MediaPlayerVolumeMuteParameters data)
		{
			_haContext.CallService("media_player", "volume_mute", target, data);
		}

		///<summary>Mute a media player's volume.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="isVolumeMuted">True/false for mute/unmute.</param>
		public void VolumeMute(ServiceTarget target, bool @isVolumeMuted)
		{
			_haContext.CallService("media_player", "volume_mute", target, new MediaPlayerVolumeMuteParameters{IsVolumeMuted = @isVolumeMuted});
		}

		///<summary>Set a media player's volume level.</summary>
		///<param name="target">The target for this service call</param>
		public void VolumeSet(ServiceTarget target, MediaPlayerVolumeSetParameters data)
		{
			_haContext.CallService("media_player", "volume_set", target, data);
		}

		///<summary>Set a media player's volume level.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="volumeLevel">Volume level to set as float.</param>
		public void VolumeSet(ServiceTarget target, double @volumeLevel)
		{
			_haContext.CallService("media_player", "volume_set", target, new MediaPlayerVolumeSetParameters{VolumeLevel = @volumeLevel});
		}

		///<summary>Turn a media player volume up.</summary>
		///<param name="target">The target for this service call</param>
		public void VolumeUp(ServiceTarget target)
		{
			_haContext.CallService("media_player", "volume_up", target);
		}
	}

	public record MediaPlayerJoinParameters
	{
		///<summary>The players which will be synced with the target player. eg: ["media_player.multiroom_player2","media_player.multiroom_player3"]</summary>
		[JsonPropertyName("group_members")]
		public object? GroupMembers { get; init; }
	}

	public record MediaPlayerMediaSeekParameters
	{
		///<summary>Position to seek to. The format is platform dependent.</summary>
		[JsonPropertyName("seek_position")]
		public double? SeekPosition { get; init; }
	}

	public record MediaPlayerPlayMediaParameters
	{
		///<summary>The ID of the content to play. Platform dependent. eg: https://home-assistant.io/images/cast/splash.png</summary>
		[JsonPropertyName("media_content_id")]
		public string? MediaContentId { get; init; }

		///<summary>The type of the content to play. Like image, music, tvshow, video, episode, channel or playlist. eg: music</summary>
		[JsonPropertyName("media_content_type")]
		public string? MediaContentType { get; init; }

		///<summary>If the content should be played now or be added to the queue.</summary>
		[JsonPropertyName("enqueue")]
		public object? Enqueue { get; init; }

		///<summary>If the media should be played as an announcement. eg: true</summary>
		[JsonPropertyName("announce")]
		public bool? Announce { get; init; }
	}

	public record MediaPlayerRepeatSetParameters
	{
		///<summary>Repeat mode to set.</summary>
		[JsonPropertyName("repeat")]
		public object? Repeat { get; init; }
	}

	public record MediaPlayerSelectSoundModeParameters
	{
		///<summary>Name of the sound mode to switch to. eg: Music</summary>
		[JsonPropertyName("sound_mode")]
		public string? SoundMode { get; init; }
	}

	public record MediaPlayerSelectSourceParameters
	{
		///<summary>Name of the source to switch to. Platform dependent. eg: video1</summary>
		[JsonPropertyName("source")]
		public string? Source { get; init; }
	}

	public record MediaPlayerShuffleSetParameters
	{
		///<summary>True/false for enabling/disabling shuffle.</summary>
		[JsonPropertyName("shuffle")]
		public bool? Shuffle { get; init; }
	}

	public record MediaPlayerVolumeMuteParameters
	{
		///<summary>True/false for mute/unmute.</summary>
		[JsonPropertyName("is_volume_muted")]
		public bool? IsVolumeMuted { get; init; }
	}

	public record MediaPlayerVolumeSetParameters
	{
		///<summary>Volume level to set as float.</summary>
		[JsonPropertyName("volume_level")]
		public double? VolumeLevel { get; init; }
	}

	public class MqttServices
	{
		private readonly IHaContext _haContext;
		public MqttServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Dump messages on a topic selector to the 'mqtt_dump.txt' file in your configuration folder.</summary>
		public void Dump(MqttDumpParameters data)
		{
			_haContext.CallService("mqtt", "dump", null, data);
		}

		///<summary>Dump messages on a topic selector to the 'mqtt_dump.txt' file in your configuration folder.</summary>
		///<param name="topic">topic to listen to eg: OpenZWave/#</param>
		///<param name="duration">how long we should listen for messages in seconds</param>
		public void Dump(string? @topic = null, long? @duration = null)
		{
			_haContext.CallService("mqtt", "dump", null, new MqttDumpParameters{Topic = @topic, Duration = @duration});
		}

		///<summary>Publish a message to an MQTT topic.</summary>
		public void Publish(MqttPublishParameters data)
		{
			_haContext.CallService("mqtt", "publish", null, data);
		}

		///<summary>Publish a message to an MQTT topic.</summary>
		///<param name="topic">Topic to publish payload. eg: /homeassistant/hello</param>
		///<param name="payload">Payload to publish. eg: This is great</param>
		///<param name="payloadTemplate">Template to render as payload value. Ignored if payload given. eg: {{ states('sensor.temperature') }}</param>
		///<param name="qos">Quality of Service to use.</param>
		///<param name="retain">If message should have the retain flag set.</param>
		public void Publish(string @topic, string? @payload = null, object? @payloadTemplate = null, object? @qos = null, bool? @retain = null)
		{
			_haContext.CallService("mqtt", "publish", null, new MqttPublishParameters{Topic = @topic, Payload = @payload, PayloadTemplate = @payloadTemplate, Qos = @qos, Retain = @retain});
		}

		///<summary>Reload all MQTT entities from YAML.</summary>
		public void Reload()
		{
			_haContext.CallService("mqtt", "reload", null);
		}
	}

	public record MqttDumpParameters
	{
		///<summary>topic to listen to eg: OpenZWave/#</summary>
		[JsonPropertyName("topic")]
		public string? Topic { get; init; }

		///<summary>how long we should listen for messages in seconds</summary>
		[JsonPropertyName("duration")]
		public long? Duration { get; init; }
	}

	public record MqttPublishParameters
	{
		///<summary>Topic to publish payload. eg: /homeassistant/hello</summary>
		[JsonPropertyName("topic")]
		public string? Topic { get; init; }

		///<summary>Payload to publish. eg: This is great</summary>
		[JsonPropertyName("payload")]
		public string? Payload { get; init; }

		///<summary>Template to render as payload value. Ignored if payload given. eg: {{ states('sensor.temperature') }}</summary>
		[JsonPropertyName("payload_template")]
		public object? PayloadTemplate { get; init; }

		///<summary>Quality of Service to use.</summary>
		[JsonPropertyName("qos")]
		public object? Qos { get; init; }

		///<summary>If message should have the retain flag set.</summary>
		[JsonPropertyName("retain")]
		public bool? Retain { get; init; }
	}

	public class NotifyServices
	{
		private readonly IHaContext _haContext;
		public NotifyServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Sends a notification message using the homeassistant service.</summary>
		public void Homeassistant(NotifyHomeassistantParameters data)
		{
			_haContext.CallService("notify", "homeassistant", null, data);
		}

		///<summary>Sends a notification message using the homeassistant service.</summary>
		///<param name="message">Message body of the notification. eg: The garage door has been open for 10 minutes.</param>
		///<param name="title">Title for your notification. eg: Your Garage Door Friend</param>
		///<param name="target">An array of targets to send the notification to. Optional depending on the platform. eg: platform specific</param>
		///<param name="data">Extended information for notification. Optional depending on the platform. eg: platform specific</param>
		public void Homeassistant(string @message, string? @title = null, object? @target = null, object? @data = null)
		{
			_haContext.CallService("notify", "homeassistant", null, new NotifyHomeassistantParameters{Message = @message, Title = @title, Target = @target, Data = @data});
		}

		///<summary>Sends a notification message using the living_room_tv service.</summary>
		public void LivingRoomTv(NotifyLivingRoomTvParameters data)
		{
			_haContext.CallService("notify", "living_room_tv", null, data);
		}

		///<summary>Sends a notification message using the living_room_tv service.</summary>
		///<param name="message">Message body of the notification. eg: The garage door has been open for 10 minutes.</param>
		///<param name="title">Title for your notification. eg: Your Garage Door Friend</param>
		///<param name="target">An array of targets to send the notification to. Optional depending on the platform. eg: platform specific</param>
		///<param name="data">Extended information for notification. Optional depending on the platform. eg: platform specific</param>
		public void LivingRoomTv(string @message, string? @title = null, object? @target = null, object? @data = null)
		{
			_haContext.CallService("notify", "living_room_tv", null, new NotifyLivingRoomTvParameters{Message = @message, Title = @title, Target = @target, Data = @data});
		}

		///<summary>Sends a notification message using the mobile_app_kiosk_tablet integration.</summary>
		public void MobileAppKioskTablet(NotifyMobileAppKioskTabletParameters data)
		{
			_haContext.CallService("notify", "mobile_app_kiosk_tablet", null, data);
		}

		///<summary>Sends a notification message using the mobile_app_kiosk_tablet integration.</summary>
		///<param name="message">Message body of the notification. eg: The garage door has been open for 10 minutes.</param>
		///<param name="title">Title for your notification. eg: Your Garage Door Friend</param>
		///<param name="target">An array of targets to send the notification to. Optional depending on the platform. eg: platform specific</param>
		///<param name="data">Extended information for notification. Optional depending on the platform. eg: platform specific</param>
		public void MobileAppKioskTablet(string @message, string? @title = null, object? @target = null, object? @data = null)
		{
			_haContext.CallService("notify", "mobile_app_kiosk_tablet", null, new NotifyMobileAppKioskTabletParameters{Message = @message, Title = @title, Target = @target, Data = @data});
		}

		///<summary>Sends a notification message using the mobile_app_nico_phone integration.</summary>
		public void MobileAppNicoPhone(NotifyMobileAppNicoPhoneParameters data)
		{
			_haContext.CallService("notify", "mobile_app_nico_phone", null, data);
		}

		///<summary>Sends a notification message using the mobile_app_nico_phone integration.</summary>
		///<param name="message">Message body of the notification. eg: The garage door has been open for 10 minutes.</param>
		///<param name="title">Title for your notification. eg: Your Garage Door Friend</param>
		///<param name="target">An array of targets to send the notification to. Optional depending on the platform. eg: platform specific</param>
		///<param name="data">Extended information for notification. Optional depending on the platform. eg: platform specific</param>
		public void MobileAppNicoPhone(string @message, string? @title = null, object? @target = null, object? @data = null)
		{
			_haContext.CallService("notify", "mobile_app_nico_phone", null, new NotifyMobileAppNicoPhoneParameters{Message = @message, Title = @title, Target = @target, Data = @data});
		}

		///<summary>Sends a notification message using the mobile_app_rares_phone integration.</summary>
		public void MobileAppRaresPhone(NotifyMobileAppRaresPhoneParameters data)
		{
			_haContext.CallService("notify", "mobile_app_rares_phone", null, data);
		}

		///<summary>Sends a notification message using the mobile_app_rares_phone integration.</summary>
		///<param name="message">Message body of the notification. eg: The garage door has been open for 10 minutes.</param>
		///<param name="title">Title for your notification. eg: Your Garage Door Friend</param>
		///<param name="target">An array of targets to send the notification to. Optional depending on the platform. eg: platform specific</param>
		///<param name="data">Extended information for notification. Optional depending on the platform. eg: platform specific</param>
		public void MobileAppRaresPhone(string @message, string? @title = null, object? @target = null, object? @data = null)
		{
			_haContext.CallService("notify", "mobile_app_rares_phone", null, new NotifyMobileAppRaresPhoneParameters{Message = @message, Title = @title, Target = @target, Data = @data});
		}

		///<summary>Sends a notification message using the mobile_app_razvan_phone integration.</summary>
		public void MobileAppRazvanPhone(NotifyMobileAppRazvanPhoneParameters data)
		{
			_haContext.CallService("notify", "mobile_app_razvan_phone", null, data);
		}

		///<summary>Sends a notification message using the mobile_app_razvan_phone integration.</summary>
		///<param name="message">Message body of the notification. eg: The garage door has been open for 10 minutes.</param>
		///<param name="title">Title for your notification. eg: Your Garage Door Friend</param>
		///<param name="target">An array of targets to send the notification to. Optional depending on the platform. eg: platform specific</param>
		///<param name="data">Extended information for notification. Optional depending on the platform. eg: platform specific</param>
		public void MobileAppRazvanPhone(string @message, string? @title = null, object? @target = null, object? @data = null)
		{
			_haContext.CallService("notify", "mobile_app_razvan_phone", null, new NotifyMobileAppRazvanPhoneParameters{Message = @message, Title = @title, Target = @target, Data = @data});
		}

		///<summary>Sends a notification message using the notify service.</summary>
		public void Notify(NotifyNotifyParameters data)
		{
			_haContext.CallService("notify", "notify", null, data);
		}

		///<summary>Sends a notification message using the notify service.</summary>
		///<param name="message">Message body of the notification. eg: The garage door has been open for 10 minutes.</param>
		///<param name="title">Title for your notification. eg: Your Garage Door Friend</param>
		///<param name="target">An array of targets to send the notification to. Optional depending on the platform. eg: platform specific</param>
		///<param name="data">Extended information for notification. Optional depending on the platform. eg: platform specific</param>
		public void Notify(string @message, string? @title = null, object? @target = null, object? @data = null)
		{
			_haContext.CallService("notify", "notify", null, new NotifyNotifyParameters{Message = @message, Title = @title, Target = @target, Data = @data});
		}

		///<summary>Sends a notification that is visible in the front-end.</summary>
		public void PersistentNotification(NotifyPersistentNotificationParameters data)
		{
			_haContext.CallService("notify", "persistent_notification", null, data);
		}

		///<summary>Sends a notification that is visible in the front-end.</summary>
		///<param name="message">Message body of the notification. eg: The garage door has been open for 10 minutes.</param>
		///<param name="title">Title for your notification. eg: Your Garage Door Friend</param>
		public void PersistentNotification(string @message, string? @title = null)
		{
			_haContext.CallService("notify", "persistent_notification", null, new NotifyPersistentNotificationParameters{Message = @message, Title = @title});
		}

		///<summary>Sends a notification message using the rares_tv service.</summary>
		public void RaresTv(NotifyRaresTvParameters data)
		{
			_haContext.CallService("notify", "rares_tv", null, data);
		}

		///<summary>Sends a notification message using the rares_tv service.</summary>
		///<param name="message">Message body of the notification. eg: The garage door has been open for 10 minutes.</param>
		///<param name="title">Title for your notification. eg: Your Garage Door Friend</param>
		///<param name="target">An array of targets to send the notification to. Optional depending on the platform. eg: platform specific</param>
		///<param name="data">Extended information for notification. Optional depending on the platform. eg: platform specific</param>
		public void RaresTv(string @message, string? @title = null, object? @target = null, object? @data = null)
		{
			_haContext.CallService("notify", "rares_tv", null, new NotifyRaresTvParameters{Message = @message, Title = @title, Target = @target, Data = @data});
		}
	}

	public record NotifyHomeassistantParameters
	{
		///<summary>Message body of the notification. eg: The garage door has been open for 10 minutes.</summary>
		[JsonPropertyName("message")]
		public string? Message { get; init; }

		///<summary>Title for your notification. eg: Your Garage Door Friend</summary>
		[JsonPropertyName("title")]
		public string? Title { get; init; }

		///<summary>An array of targets to send the notification to. Optional depending on the platform. eg: platform specific</summary>
		[JsonPropertyName("target")]
		public object? Target { get; init; }

		///<summary>Extended information for notification. Optional depending on the platform. eg: platform specific</summary>
		[JsonPropertyName("data")]
		public object? Data { get; init; }
	}

	public record NotifyLivingRoomTvParameters
	{
		///<summary>Message body of the notification. eg: The garage door has been open for 10 minutes.</summary>
		[JsonPropertyName("message")]
		public string? Message { get; init; }

		///<summary>Title for your notification. eg: Your Garage Door Friend</summary>
		[JsonPropertyName("title")]
		public string? Title { get; init; }

		///<summary>An array of targets to send the notification to. Optional depending on the platform. eg: platform specific</summary>
		[JsonPropertyName("target")]
		public object? Target { get; init; }

		///<summary>Extended information for notification. Optional depending on the platform. eg: platform specific</summary>
		[JsonPropertyName("data")]
		public object? Data { get; init; }
	}

	public record NotifyMobileAppKioskTabletParameters
	{
		///<summary>Message body of the notification. eg: The garage door has been open for 10 minutes.</summary>
		[JsonPropertyName("message")]
		public string? Message { get; init; }

		///<summary>Title for your notification. eg: Your Garage Door Friend</summary>
		[JsonPropertyName("title")]
		public string? Title { get; init; }

		///<summary>An array of targets to send the notification to. Optional depending on the platform. eg: platform specific</summary>
		[JsonPropertyName("target")]
		public object? Target { get; init; }

		///<summary>Extended information for notification. Optional depending on the platform. eg: platform specific</summary>
		[JsonPropertyName("data")]
		public object? Data { get; init; }
	}

	public record NotifyMobileAppNicoPhoneParameters
	{
		///<summary>Message body of the notification. eg: The garage door has been open for 10 minutes.</summary>
		[JsonPropertyName("message")]
		public string? Message { get; init; }

		///<summary>Title for your notification. eg: Your Garage Door Friend</summary>
		[JsonPropertyName("title")]
		public string? Title { get; init; }

		///<summary>An array of targets to send the notification to. Optional depending on the platform. eg: platform specific</summary>
		[JsonPropertyName("target")]
		public object? Target { get; init; }

		///<summary>Extended information for notification. Optional depending on the platform. eg: platform specific</summary>
		[JsonPropertyName("data")]
		public object? Data { get; init; }
	}

	public record NotifyMobileAppRaresPhoneParameters
	{
		///<summary>Message body of the notification. eg: The garage door has been open for 10 minutes.</summary>
		[JsonPropertyName("message")]
		public string? Message { get; init; }

		///<summary>Title for your notification. eg: Your Garage Door Friend</summary>
		[JsonPropertyName("title")]
		public string? Title { get; init; }

		///<summary>An array of targets to send the notification to. Optional depending on the platform. eg: platform specific</summary>
		[JsonPropertyName("target")]
		public object? Target { get; init; }

		///<summary>Extended information for notification. Optional depending on the platform. eg: platform specific</summary>
		[JsonPropertyName("data")]
		public object? Data { get; init; }
	}

	public record NotifyMobileAppRazvanPhoneParameters
	{
		///<summary>Message body of the notification. eg: The garage door has been open for 10 minutes.</summary>
		[JsonPropertyName("message")]
		public string? Message { get; init; }

		///<summary>Title for your notification. eg: Your Garage Door Friend</summary>
		[JsonPropertyName("title")]
		public string? Title { get; init; }

		///<summary>An array of targets to send the notification to. Optional depending on the platform. eg: platform specific</summary>
		[JsonPropertyName("target")]
		public object? Target { get; init; }

		///<summary>Extended information for notification. Optional depending on the platform. eg: platform specific</summary>
		[JsonPropertyName("data")]
		public object? Data { get; init; }
	}

	public record NotifyNotifyParameters
	{
		///<summary>Message body of the notification. eg: The garage door has been open for 10 minutes.</summary>
		[JsonPropertyName("message")]
		public string? Message { get; init; }

		///<summary>Title for your notification. eg: Your Garage Door Friend</summary>
		[JsonPropertyName("title")]
		public string? Title { get; init; }

		///<summary>An array of targets to send the notification to. Optional depending on the platform. eg: platform specific</summary>
		[JsonPropertyName("target")]
		public object? Target { get; init; }

		///<summary>Extended information for notification. Optional depending on the platform. eg: platform specific</summary>
		[JsonPropertyName("data")]
		public object? Data { get; init; }
	}

	public record NotifyPersistentNotificationParameters
	{
		///<summary>Message body of the notification. eg: The garage door has been open for 10 minutes.</summary>
		[JsonPropertyName("message")]
		public string? Message { get; init; }

		///<summary>Title for your notification. eg: Your Garage Door Friend</summary>
		[JsonPropertyName("title")]
		public string? Title { get; init; }
	}

	public record NotifyRaresTvParameters
	{
		///<summary>Message body of the notification. eg: The garage door has been open for 10 minutes.</summary>
		[JsonPropertyName("message")]
		public string? Message { get; init; }

		///<summary>Title for your notification. eg: Your Garage Door Friend</summary>
		[JsonPropertyName("title")]
		public string? Title { get; init; }

		///<summary>An array of targets to send the notification to. Optional depending on the platform. eg: platform specific</summary>
		[JsonPropertyName("target")]
		public object? Target { get; init; }

		///<summary>Extended information for notification. Optional depending on the platform. eg: platform specific</summary>
		[JsonPropertyName("data")]
		public object? Data { get; init; }
	}

	public class NumberServices
	{
		private readonly IHaContext _haContext;
		public NumberServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Set the value of a Number entity.</summary>
		///<param name="target">The target for this service call</param>
		public void SetValue(ServiceTarget target, NumberSetValueParameters data)
		{
			_haContext.CallService("number", "set_value", target, data);
		}

		///<summary>Set the value of a Number entity.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="value">The target value the entity should be set to. eg: 42</param>
		public void SetValue(ServiceTarget target, string? @value = null)
		{
			_haContext.CallService("number", "set_value", target, new NumberSetValueParameters{Value = @value});
		}
	}

	public record NumberSetValueParameters
	{
		///<summary>The target value the entity should be set to. eg: 42</summary>
		[JsonPropertyName("value")]
		public string? Value { get; init; }
	}

	public class PersistentNotificationServices
	{
		private readonly IHaContext _haContext;
		public PersistentNotificationServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Show a notification in the frontend.</summary>
		public void Create(PersistentNotificationCreateParameters data)
		{
			_haContext.CallService("persistent_notification", "create", null, data);
		}

		///<summary>Show a notification in the frontend.</summary>
		///<param name="message">Message body of the notification. [Templates accepted] eg: Please check your configuration.yaml.</param>
		///<param name="title">Optional title for your notification. [Templates accepted] eg: Test notification</param>
		///<param name="notificationId">Target ID of the notification, will replace a notification with the same ID. eg: 1234</param>
		public void Create(string @message, string? @title = null, string? @notificationId = null)
		{
			_haContext.CallService("persistent_notification", "create", null, new PersistentNotificationCreateParameters{Message = @message, Title = @title, NotificationId = @notificationId});
		}

		///<summary>Remove a notification from the frontend.</summary>
		public void Dismiss(PersistentNotificationDismissParameters data)
		{
			_haContext.CallService("persistent_notification", "dismiss", null, data);
		}

		///<summary>Remove a notification from the frontend.</summary>
		///<param name="notificationId">Target ID of the notification, which should be removed. eg: 1234</param>
		public void Dismiss(string @notificationId)
		{
			_haContext.CallService("persistent_notification", "dismiss", null, new PersistentNotificationDismissParameters{NotificationId = @notificationId});
		}

		///<summary>Mark a notification read.</summary>
		public void MarkRead(PersistentNotificationMarkReadParameters data)
		{
			_haContext.CallService("persistent_notification", "mark_read", null, data);
		}

		///<summary>Mark a notification read.</summary>
		///<param name="notificationId">Target ID of the notification, which should be mark read. eg: 1234</param>
		public void MarkRead(string @notificationId)
		{
			_haContext.CallService("persistent_notification", "mark_read", null, new PersistentNotificationMarkReadParameters{NotificationId = @notificationId});
		}
	}

	public record PersistentNotificationCreateParameters
	{
		///<summary>Message body of the notification. [Templates accepted] eg: Please check your configuration.yaml.</summary>
		[JsonPropertyName("message")]
		public string? Message { get; init; }

		///<summary>Optional title for your notification. [Templates accepted] eg: Test notification</summary>
		[JsonPropertyName("title")]
		public string? Title { get; init; }

		///<summary>Target ID of the notification, will replace a notification with the same ID. eg: 1234</summary>
		[JsonPropertyName("notification_id")]
		public string? NotificationId { get; init; }
	}

	public record PersistentNotificationDismissParameters
	{
		///<summary>Target ID of the notification, which should be removed. eg: 1234</summary>
		[JsonPropertyName("notification_id")]
		public string? NotificationId { get; init; }
	}

	public record PersistentNotificationMarkReadParameters
	{
		///<summary>Target ID of the notification, which should be mark read. eg: 1234</summary>
		[JsonPropertyName("notification_id")]
		public string? NotificationId { get; init; }
	}

	public class PersonServices
	{
		private readonly IHaContext _haContext;
		public PersonServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Reload the person configuration.</summary>
		public void Reload()
		{
			_haContext.CallService("person", "reload", null);
		}
	}

	public class RecorderServices
	{
		private readonly IHaContext _haContext;
		public RecorderServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Stop the recording of events and state changes</summary>
		public void Disable()
		{
			_haContext.CallService("recorder", "disable", null);
		}

		///<summary>Start the recording of events and state changes</summary>
		public void Enable()
		{
			_haContext.CallService("recorder", "enable", null);
		}

		///<summary>Start purge task - to clean up old data from your database.</summary>
		public void Purge(RecorderPurgeParameters data)
		{
			_haContext.CallService("recorder", "purge", null, data);
		}

		///<summary>Start purge task - to clean up old data from your database.</summary>
		///<param name="keepDays">Number of history days to keep in database after purge.</param>
		///<param name="repack">Attempt to save disk space by rewriting the entire database file.</param>
		///<param name="applyFilter">Apply entity_id and event_type filter in addition to time based purge.</param>
		public void Purge(long? @keepDays = null, bool? @repack = null, bool? @applyFilter = null)
		{
			_haContext.CallService("recorder", "purge", null, new RecorderPurgeParameters{KeepDays = @keepDays, Repack = @repack, ApplyFilter = @applyFilter});
		}

		///<summary>Start purge task to remove specific entities from your database.</summary>
		///<param name="target">The target for this service call</param>
		public void PurgeEntities(ServiceTarget target, RecorderPurgeEntitiesParameters data)
		{
			_haContext.CallService("recorder", "purge_entities", target, data);
		}

		///<summary>Start purge task to remove specific entities from your database.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="domains">List the domains that need to be removed from the recorder database. eg: sun</param>
		///<param name="entityGlobs">List the glob patterns to select entities for removal from the recorder database. eg: domain*.object_id*</param>
		public void PurgeEntities(ServiceTarget target, object? @domains = null, object? @entityGlobs = null)
		{
			_haContext.CallService("recorder", "purge_entities", target, new RecorderPurgeEntitiesParameters{Domains = @domains, EntityGlobs = @entityGlobs});
		}
	}

	public record RecorderPurgeParameters
	{
		///<summary>Number of history days to keep in database after purge.</summary>
		[JsonPropertyName("keep_days")]
		public long? KeepDays { get; init; }

		///<summary>Attempt to save disk space by rewriting the entire database file.</summary>
		[JsonPropertyName("repack")]
		public bool? Repack { get; init; }

		///<summary>Apply entity_id and event_type filter in addition to time based purge.</summary>
		[JsonPropertyName("apply_filter")]
		public bool? ApplyFilter { get; init; }
	}

	public record RecorderPurgeEntitiesParameters
	{
		///<summary>List the domains that need to be removed from the recorder database. eg: sun</summary>
		[JsonPropertyName("domains")]
		public object? Domains { get; init; }

		///<summary>List the glob patterns to select entities for removal from the recorder database. eg: domain*.object_id*</summary>
		[JsonPropertyName("entity_globs")]
		public object? EntityGlobs { get; init; }
	}

	public class RemoteServices
	{
		private readonly IHaContext _haContext;
		public RemoteServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Deletes a command or a list of commands from the database.</summary>
		///<param name="target">The target for this service call</param>
		public void DeleteCommand(ServiceTarget target, RemoteDeleteCommandParameters data)
		{
			_haContext.CallService("remote", "delete_command", target, data);
		}

		///<summary>Deletes a command or a list of commands from the database.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="device">Name of the device from which commands will be deleted. eg: television</param>
		///<param name="command">A single command or a list of commands to delete. eg: Mute</param>
		public void DeleteCommand(ServiceTarget target, object @command, string? @device = null)
		{
			_haContext.CallService("remote", "delete_command", target, new RemoteDeleteCommandParameters{Device = @device, Command = @command});
		}

		///<summary>Learns a command or a list of commands from a device.</summary>
		///<param name="target">The target for this service call</param>
		public void LearnCommand(ServiceTarget target, RemoteLearnCommandParameters data)
		{
			_haContext.CallService("remote", "learn_command", target, data);
		}

		///<summary>Learns a command or a list of commands from a device.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="device">Device ID to learn command from. eg: television</param>
		///<param name="command">A single command or a list of commands to learn. eg: Turn on</param>
		///<param name="commandType">The type of command to be learned.</param>
		///<param name="alternative">If code must be stored as alternative (useful for discrete remotes).</param>
		///<param name="timeout">Timeout for the command to be learned.</param>
		public void LearnCommand(ServiceTarget target, string? @device = null, object? @command = null, object? @commandType = null, bool? @alternative = null, long? @timeout = null)
		{
			_haContext.CallService("remote", "learn_command", target, new RemoteLearnCommandParameters{Device = @device, Command = @command, CommandType = @commandType, Alternative = @alternative, Timeout = @timeout});
		}

		///<summary>Sends a command or a list of commands to a device.</summary>
		///<param name="target">The target for this service call</param>
		public void SendCommand(ServiceTarget target, RemoteSendCommandParameters data)
		{
			_haContext.CallService("remote", "send_command", target, data);
		}

		///<summary>Sends a command or a list of commands to a device.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="device">Device ID to send command to. eg: 32756745</param>
		///<param name="command">A single command or a list of commands to send. eg: Play</param>
		///<param name="numRepeats">The number of times you want to repeat the command(s).</param>
		///<param name="delaySecs">The time you want to wait in between repeated commands.</param>
		///<param name="holdSecs">The time you want to have it held before the release is send.</param>
		public void SendCommand(ServiceTarget target, object @command, string? @device = null, long? @numRepeats = null, double? @delaySecs = null, double? @holdSecs = null)
		{
			_haContext.CallService("remote", "send_command", target, new RemoteSendCommandParameters{Device = @device, Command = @command, NumRepeats = @numRepeats, DelaySecs = @delaySecs, HoldSecs = @holdSecs});
		}

		///<summary>Toggles a device.</summary>
		///<param name="target">The target for this service call</param>
		public void Toggle(ServiceTarget target)
		{
			_haContext.CallService("remote", "toggle", target);
		}

		///<summary>Sends the Power Off Command.</summary>
		///<param name="target">The target for this service call</param>
		public void TurnOff(ServiceTarget target)
		{
			_haContext.CallService("remote", "turn_off", target);
		}

		///<summary>Sends the Power On Command.</summary>
		///<param name="target">The target for this service call</param>
		public void TurnOn(ServiceTarget target, RemoteTurnOnParameters data)
		{
			_haContext.CallService("remote", "turn_on", target, data);
		}

		///<summary>Sends the Power On Command.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="activity">Activity ID or Activity Name to start. eg: BedroomTV</param>
		public void TurnOn(ServiceTarget target, string? @activity = null)
		{
			_haContext.CallService("remote", "turn_on", target, new RemoteTurnOnParameters{Activity = @activity});
		}
	}

	public record RemoteDeleteCommandParameters
	{
		///<summary>Name of the device from which commands will be deleted. eg: television</summary>
		[JsonPropertyName("device")]
		public string? Device { get; init; }

		///<summary>A single command or a list of commands to delete. eg: Mute</summary>
		[JsonPropertyName("command")]
		public object? Command { get; init; }
	}

	public record RemoteLearnCommandParameters
	{
		///<summary>Device ID to learn command from. eg: television</summary>
		[JsonPropertyName("device")]
		public string? Device { get; init; }

		///<summary>A single command or a list of commands to learn. eg: Turn on</summary>
		[JsonPropertyName("command")]
		public object? Command { get; init; }

		///<summary>The type of command to be learned.</summary>
		[JsonPropertyName("command_type")]
		public object? CommandType { get; init; }

		///<summary>If code must be stored as alternative (useful for discrete remotes).</summary>
		[JsonPropertyName("alternative")]
		public bool? Alternative { get; init; }

		///<summary>Timeout for the command to be learned.</summary>
		[JsonPropertyName("timeout")]
		public long? Timeout { get; init; }
	}

	public record RemoteSendCommandParameters
	{
		///<summary>Device ID to send command to. eg: 32756745</summary>
		[JsonPropertyName("device")]
		public string? Device { get; init; }

		///<summary>A single command or a list of commands to send. eg: Play</summary>
		[JsonPropertyName("command")]
		public object? Command { get; init; }

		///<summary>The number of times you want to repeat the command(s).</summary>
		[JsonPropertyName("num_repeats")]
		public long? NumRepeats { get; init; }

		///<summary>The time you want to wait in between repeated commands.</summary>
		[JsonPropertyName("delay_secs")]
		public double? DelaySecs { get; init; }

		///<summary>The time you want to have it held before the release is send.</summary>
		[JsonPropertyName("hold_secs")]
		public double? HoldSecs { get; init; }
	}

	public record RemoteTurnOnParameters
	{
		///<summary>Activity ID or Activity Name to start. eg: BedroomTV</summary>
		[JsonPropertyName("activity")]
		public string? Activity { get; init; }
	}

	public class RestCommandServices
	{
		private readonly IHaContext _haContext;
		public RestCommandServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		public void HydrawiseRun()
		{
			_haContext.CallService("rest_command", "hydrawise_run", null);
		}

		public void HydrawiseRunAll()
		{
			_haContext.CallService("rest_command", "hydrawise_run_all", null);
		}

		public void HydrawiseStop()
		{
			_haContext.CallService("rest_command", "hydrawise_stop", null);
		}

		public void HydrawiseStopAll()
		{
			_haContext.CallService("rest_command", "hydrawise_stop_all", null);
		}

		public void HydrawiseSuspend()
		{
			_haContext.CallService("rest_command", "hydrawise_suspend", null);
		}

		public void HydrawiseSuspendAll()
		{
			_haContext.CallService("rest_command", "hydrawise_suspend_all", null);
		}
	}

	public class SceneServices
	{
		private readonly IHaContext _haContext;
		public SceneServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Activate a scene with configuration.</summary>
		public void Apply(SceneApplyParameters data)
		{
			_haContext.CallService("scene", "apply", null, data);
		}

		///<summary>Activate a scene with configuration.</summary>
		///<param name="entities">The entities and the state that they need to be. eg: {"light.kitchen":"on","light.ceiling":{"state":"on","brightness":80}}</param>
		///<param name="transition">Transition duration it takes to bring devices to the state defined in the scene.</param>
		public void Apply(object @entities, long? @transition = null)
		{
			_haContext.CallService("scene", "apply", null, new SceneApplyParameters{Entities = @entities, Transition = @transition});
		}

		///<summary>Creates a new scene.</summary>
		public void Create(SceneCreateParameters data)
		{
			_haContext.CallService("scene", "create", null, data);
		}

		///<summary>Creates a new scene.</summary>
		///<param name="sceneId">The entity_id of the new scene. eg: all_lights</param>
		///<param name="entities">The entities to control with the scene. eg: {"light.tv_back_light":"on","light.ceiling":{"state":"on","brightness":200}}</param>
		///<param name="snapshotEntities">The entities of which a snapshot is to be taken eg: ["light.ceiling","light.kitchen"]</param>
		public void Create(string @sceneId, object? @entities = null, object? @snapshotEntities = null)
		{
			_haContext.CallService("scene", "create", null, new SceneCreateParameters{SceneId = @sceneId, Entities = @entities, SnapshotEntities = @snapshotEntities});
		}

		///<summary>Reload the scene configuration.</summary>
		public void Reload()
		{
			_haContext.CallService("scene", "reload", null);
		}

		///<summary>Activate a scene.</summary>
		///<param name="target">The target for this service call</param>
		public void TurnOn(ServiceTarget target, SceneTurnOnParameters data)
		{
			_haContext.CallService("scene", "turn_on", target, data);
		}

		///<summary>Activate a scene.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="transition">Transition duration it takes to bring devices to the state defined in the scene.</param>
		public void TurnOn(ServiceTarget target, long? @transition = null)
		{
			_haContext.CallService("scene", "turn_on", target, new SceneTurnOnParameters{Transition = @transition});
		}
	}

	public record SceneApplyParameters
	{
		///<summary>The entities and the state that they need to be. eg: {"light.kitchen":"on","light.ceiling":{"state":"on","brightness":80}}</summary>
		[JsonPropertyName("entities")]
		public object? Entities { get; init; }

		///<summary>Transition duration it takes to bring devices to the state defined in the scene.</summary>
		[JsonPropertyName("transition")]
		public long? Transition { get; init; }
	}

	public record SceneCreateParameters
	{
		///<summary>The entity_id of the new scene. eg: all_lights</summary>
		[JsonPropertyName("scene_id")]
		public string? SceneId { get; init; }

		///<summary>The entities to control with the scene. eg: {"light.tv_back_light":"on","light.ceiling":{"state":"on","brightness":200}}</summary>
		[JsonPropertyName("entities")]
		public object? Entities { get; init; }

		///<summary>The entities of which a snapshot is to be taken eg: ["light.ceiling","light.kitchen"]</summary>
		[JsonPropertyName("snapshot_entities")]
		public object? SnapshotEntities { get; init; }
	}

	public record SceneTurnOnParameters
	{
		///<summary>Transition duration it takes to bring devices to the state defined in the scene.</summary>
		[JsonPropertyName("transition")]
		public long? Transition { get; init; }
	}

	public class ScriptServices
	{
		private readonly IHaContext _haContext;
		public ScriptServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Reload all the available scripts</summary>
		public void Reload()
		{
			_haContext.CallService("script", "reload", null);
		}

		///<summary>Toggle script</summary>
		///<param name="target">The target for this service call</param>
		public void Toggle(ServiceTarget target)
		{
			_haContext.CallService("script", "toggle", target);
		}

		///<summary>Turn off script</summary>
		///<param name="target">The target for this service call</param>
		public void TurnOff(ServiceTarget target)
		{
			_haContext.CallService("script", "turn_off", target);
		}

		///<summary>Turn on script</summary>
		///<param name="target">The target for this service call</param>
		public void TurnOn(ServiceTarget target)
		{
			_haContext.CallService("script", "turn_on", target);
		}
	}

	public class SelectServices
	{
		private readonly IHaContext _haContext;
		public SelectServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Select an option of an select entity.</summary>
		///<param name="target">The target for this service call</param>
		public void SelectOption(ServiceTarget target, SelectSelectOptionParameters data)
		{
			_haContext.CallService("select", "select_option", target, data);
		}

		///<summary>Select an option of an select entity.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="option">Option to be selected. eg: "Item A"</param>
		public void SelectOption(ServiceTarget target, string @option)
		{
			_haContext.CallService("select", "select_option", target, new SelectSelectOptionParameters{Option = @option});
		}
	}

	public record SelectSelectOptionParameters
	{
		///<summary>Option to be selected. eg: "Item A"</summary>
		[JsonPropertyName("option")]
		public string? Option { get; init; }
	}

	public class ShoppingListServices
	{
		private readonly IHaContext _haContext;
		public ShoppingListServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Add an item to the shopping list.</summary>
		public void AddItem(ShoppingListAddItemParameters data)
		{
			_haContext.CallService("shopping_list", "add_item", null, data);
		}

		///<summary>Add an item to the shopping list.</summary>
		///<param name="name">The name of the item to add. eg: Beer</param>
		public void AddItem(string @name)
		{
			_haContext.CallService("shopping_list", "add_item", null, new ShoppingListAddItemParameters{Name = @name});
		}

		///<summary>Clear completed items from the shopping list.</summary>
		public void ClearCompletedItems()
		{
			_haContext.CallService("shopping_list", "clear_completed_items", null);
		}

		///<summary>Marks all items as completed in the shopping list. It does not remove the items.</summary>
		public void CompleteAll()
		{
			_haContext.CallService("shopping_list", "complete_all", null);
		}

		///<summary>Mark an item as completed in the shopping list.</summary>
		public void CompleteItem(ShoppingListCompleteItemParameters data)
		{
			_haContext.CallService("shopping_list", "complete_item", null, data);
		}

		///<summary>Mark an item as completed in the shopping list.</summary>
		///<param name="name">The name of the item to mark as completed (without removing). eg: Beer</param>
		public void CompleteItem(string @name)
		{
			_haContext.CallService("shopping_list", "complete_item", null, new ShoppingListCompleteItemParameters{Name = @name});
		}

		///<summary>Marks all items as incomplete in the shopping list.</summary>
		public void IncompleteAll()
		{
			_haContext.CallService("shopping_list", "incomplete_all", null);
		}

		///<summary>Marks an item as incomplete in the shopping list.</summary>
		public void IncompleteItem(ShoppingListIncompleteItemParameters data)
		{
			_haContext.CallService("shopping_list", "incomplete_item", null, data);
		}

		///<summary>Marks an item as incomplete in the shopping list.</summary>
		///<param name="name">The name of the item to mark as incomplete. eg: Beer</param>
		public void IncompleteItem(string @name)
		{
			_haContext.CallService("shopping_list", "incomplete_item", null, new ShoppingListIncompleteItemParameters{Name = @name});
		}
	}

	public record ShoppingListAddItemParameters
	{
		///<summary>The name of the item to add. eg: Beer</summary>
		[JsonPropertyName("name")]
		public string? Name { get; init; }
	}

	public record ShoppingListCompleteItemParameters
	{
		///<summary>The name of the item to mark as completed (without removing). eg: Beer</summary>
		[JsonPropertyName("name")]
		public string? Name { get; init; }
	}

	public record ShoppingListIncompleteItemParameters
	{
		///<summary>The name of the item to mark as incomplete. eg: Beer</summary>
		[JsonPropertyName("name")]
		public string? Name { get; init; }
	}

	public class SirenServices
	{
		private readonly IHaContext _haContext;
		public SirenServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Toggles a siren.</summary>
		///<param name="target">The target for this service call</param>
		public void Toggle(ServiceTarget target)
		{
			_haContext.CallService("siren", "toggle", target);
		}

		///<summary>Turn siren off.</summary>
		///<param name="target">The target for this service call</param>
		public void TurnOff(ServiceTarget target)
		{
			_haContext.CallService("siren", "turn_off", target);
		}

		///<summary>Turn siren on.</summary>
		///<param name="target">The target for this service call</param>
		public void TurnOn(ServiceTarget target, SirenTurnOnParameters data)
		{
			_haContext.CallService("siren", "turn_on", target, data);
		}

		///<summary>Turn siren on.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="tone">The tone to emit when turning the siren on. When `available_tones` property is a map, either the key or the value can be used. Must be supported by the integration. eg: fire</param>
		///<param name="volumeLevel">The volume level of the noise to emit when turning the siren on. Must be supported by the integration. eg: 0.5</param>
		///<param name="duration">The duration in seconds of the noise to emit when turning the siren on. Must be supported by the integration. eg: 15</param>
		public void TurnOn(ServiceTarget target, string? @tone = null, double? @volumeLevel = null, string? @duration = null)
		{
			_haContext.CallService("siren", "turn_on", target, new SirenTurnOnParameters{Tone = @tone, VolumeLevel = @volumeLevel, Duration = @duration});
		}
	}

	public record SirenTurnOnParameters
	{
		///<summary>The tone to emit when turning the siren on. When `available_tones` property is a map, either the key or the value can be used. Must be supported by the integration. eg: fire</summary>
		[JsonPropertyName("tone")]
		public string? Tone { get; init; }

		///<summary>The volume level of the noise to emit when turning the siren on. Must be supported by the integration. eg: 0.5</summary>
		[JsonPropertyName("volume_level")]
		public double? VolumeLevel { get; init; }

		///<summary>The duration in seconds of the noise to emit when turning the siren on. Must be supported by the integration. eg: 15</summary>
		[JsonPropertyName("duration")]
		public string? Duration { get; init; }
	}

	public class SmartthinqSensorsServices
	{
		private readonly IHaContext _haContext;
		public SmartthinqSensorsServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Send to ThinQ device the remote start command.</summary>
		///<param name="target">The target for this service call</param>
		public void RemoteStart(ServiceTarget target)
		{
			_haContext.CallService("smartthinq_sensors", "remote_start", target);
		}

		///<summary>Set fan operation for dehumidifier device.</summary>
		///<param name="target">The target for this service call</param>
		public void SetFanMode(ServiceTarget target, SmartthinqSensorsSetFanModeParameters data)
		{
			_haContext.CallService("smartthinq_sensors", "set_fan_mode", target, data);
		}

		///<summary>Set fan operation for dehumidifier device.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="fanMode">New value of fan mode. eg: low</param>
		public void SetFanMode(ServiceTarget target, string @fanMode)
		{
			_haContext.CallService("smartthinq_sensors", "set_fan_mode", target, new SmartthinqSensorsSetFanModeParameters{FanMode = @fanMode});
		}

		///<summary>Send to ThinQ device the wakeup command.</summary>
		///<param name="target">The target for this service call</param>
		public void WakeUp(ServiceTarget target)
		{
			_haContext.CallService("smartthinq_sensors", "wake_up", target);
		}
	}

	public record SmartthinqSensorsSetFanModeParameters
	{
		///<summary>New value of fan mode. eg: low</summary>
		[JsonPropertyName("fan_mode")]
		public string? FanMode { get; init; }
	}

	public class SpeedtestdotnetServices
	{
		private readonly IHaContext _haContext;
		public SpeedtestdotnetServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Immediately execute a speed test with Speedtest.net</summary>
		public void Speedtest()
		{
			_haContext.CallService("speedtestdotnet", "speedtest", null);
		}
	}

	public class SwitchServices
	{
		private readonly IHaContext _haContext;
		public SwitchServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Toggles a switch state</summary>
		///<param name="target">The target for this service call</param>
		public void Toggle(ServiceTarget target)
		{
			_haContext.CallService("switch", "toggle", target);
		}

		///<summary>Turn a switch off</summary>
		///<param name="target">The target for this service call</param>
		public void TurnOff(ServiceTarget target)
		{
			_haContext.CallService("switch", "turn_off", target);
		}

		///<summary>Turn a switch on</summary>
		///<param name="target">The target for this service call</param>
		public void TurnOn(ServiceTarget target)
		{
			_haContext.CallService("switch", "turn_on", target);
		}
	}

	public class SystemLogServices
	{
		private readonly IHaContext _haContext;
		public SystemLogServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Clear all log entries.</summary>
		public void Clear()
		{
			_haContext.CallService("system_log", "clear", null);
		}

		///<summary>Write log entry.</summary>
		public void Write(SystemLogWriteParameters data)
		{
			_haContext.CallService("system_log", "write", null, data);
		}

		///<summary>Write log entry.</summary>
		///<param name="message">Message to log. eg: Something went wrong</param>
		///<param name="level">Log level.</param>
		///<param name="logger">Logger name under which to log the message. Defaults to 'system_log.external'. eg: mycomponent.myplatform</param>
		public void Write(string @message, object? @level = null, string? @logger = null)
		{
			_haContext.CallService("system_log", "write", null, new SystemLogWriteParameters{Message = @message, Level = @level, Logger = @logger});
		}
	}

	public record SystemLogWriteParameters
	{
		///<summary>Message to log. eg: Something went wrong</summary>
		[JsonPropertyName("message")]
		public string? Message { get; init; }

		///<summary>Log level.</summary>
		[JsonPropertyName("level")]
		public object? Level { get; init; }

		///<summary>Logger name under which to log the message. Defaults to 'system_log.external'. eg: mycomponent.myplatform</summary>
		[JsonPropertyName("logger")]
		public string? Logger { get; init; }
	}

	public class TemplateServices
	{
		private readonly IHaContext _haContext;
		public TemplateServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Reload all template entities.</summary>
		public void Reload()
		{
			_haContext.CallService("template", "reload", null);
		}
	}

	public class TimerServices
	{
		private readonly IHaContext _haContext;
		public TimerServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Cancel a timer.</summary>
		///<param name="target">The target for this service call</param>
		public void Cancel(ServiceTarget target)
		{
			_haContext.CallService("timer", "cancel", target);
		}

		///<summary>Finish a timer.</summary>
		///<param name="target">The target for this service call</param>
		public void Finish(ServiceTarget target)
		{
			_haContext.CallService("timer", "finish", target);
		}

		///<summary>Pause a timer.</summary>
		///<param name="target">The target for this service call</param>
		public void Pause(ServiceTarget target)
		{
			_haContext.CallService("timer", "pause", target);
		}

		public void Reload()
		{
			_haContext.CallService("timer", "reload", null);
		}

		///<summary>Start a timer</summary>
		///<param name="target">The target for this service call</param>
		public void Start(ServiceTarget target, TimerStartParameters data)
		{
			_haContext.CallService("timer", "start", target, data);
		}

		///<summary>Start a timer</summary>
		///<param name="target">The target for this service call</param>
		///<param name="duration">Duration the timer requires to finish. [optional] eg: 00:01:00 or 60</param>
		public void Start(ServiceTarget target, string? @duration = null)
		{
			_haContext.CallService("timer", "start", target, new TimerStartParameters{Duration = @duration});
		}
	}

	public record TimerStartParameters
	{
		///<summary>Duration the timer requires to finish. [optional] eg: 00:01:00 or 60</summary>
		[JsonPropertyName("duration")]
		public string? Duration { get; init; }
	}

	public class TrendServices
	{
		private readonly IHaContext _haContext;
		public TrendServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Reload all trend entities.</summary>
		public void Reload()
		{
			_haContext.CallService("trend", "reload", null);
		}
	}

	public class TtsServices
	{
		private readonly IHaContext _haContext;
		public TtsServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Remove all text-to-speech cache files and RAM cache.</summary>
		public void ClearCache()
		{
			_haContext.CallService("tts", "clear_cache", null);
		}

		///<summary>Say something using text-to-speech on a media player with edge_tts.</summary>
		public void EdgeSay(TtsEdgeSayParameters data)
		{
			_haContext.CallService("tts", "edge_say", null, data);
		}

		///<summary>Say something using text-to-speech on a media player with edge_tts.</summary>
		///<param name="entityId">Name(s) of media player entities.</param>
		///<param name="message">Text to speak on devices. eg: My name is hanna</param>
		///<param name="cache">Control file cache of this message.</param>
		///<param name="language">Language to use for speech generation. eg: ru</param>
		///<param name="options">A dictionary containing platform-specific options. Optional depending on the platform. eg: platform specific</param>
		public void EdgeSay(string @entityId, string @message, bool? @cache = null, string? @language = null, object? @options = null)
		{
			_haContext.CallService("tts", "edge_say", null, new TtsEdgeSayParameters{EntityId = @entityId, Message = @message, Cache = @cache, Language = @language, Options = @options});
		}

		///<summary>Say something using text-to-speech on a media player with google_translate.</summary>
		public void GoogleTranslateSay(TtsGoogleTranslateSayParameters data)
		{
			_haContext.CallService("tts", "google_translate_say", null, data);
		}

		///<summary>Say something using text-to-speech on a media player with google_translate.</summary>
		///<param name="entityId">Name(s) of media player entities.</param>
		///<param name="message">Text to speak on devices. eg: My name is hanna</param>
		///<param name="cache">Control file cache of this message.</param>
		///<param name="language">Language to use for speech generation. eg: ru</param>
		///<param name="options">A dictionary containing platform-specific options. Optional depending on the platform. eg: platform specific</param>
		public void GoogleTranslateSay(string @entityId, string @message, bool? @cache = null, string? @language = null, object? @options = null)
		{
			_haContext.CallService("tts", "google_translate_say", null, new TtsGoogleTranslateSayParameters{EntityId = @entityId, Message = @message, Cache = @cache, Language = @language, Options = @options});
		}
	}

	public record TtsEdgeSayParameters
	{
		///<summary>Name(s) of media player entities.</summary>
		[JsonPropertyName("entity_id")]
		public string? EntityId { get; init; }

		///<summary>Text to speak on devices. eg: My name is hanna</summary>
		[JsonPropertyName("message")]
		public string? Message { get; init; }

		///<summary>Control file cache of this message.</summary>
		[JsonPropertyName("cache")]
		public bool? Cache { get; init; }

		///<summary>Language to use for speech generation. eg: ru</summary>
		[JsonPropertyName("language")]
		public string? Language { get; init; }

		///<summary>A dictionary containing platform-specific options. Optional depending on the platform. eg: platform specific</summary>
		[JsonPropertyName("options")]
		public object? Options { get; init; }
	}

	public record TtsGoogleTranslateSayParameters
	{
		///<summary>Name(s) of media player entities.</summary>
		[JsonPropertyName("entity_id")]
		public string? EntityId { get; init; }

		///<summary>Text to speak on devices. eg: My name is hanna</summary>
		[JsonPropertyName("message")]
		public string? Message { get; init; }

		///<summary>Control file cache of this message.</summary>
		[JsonPropertyName("cache")]
		public bool? Cache { get; init; }

		///<summary>Language to use for speech generation. eg: ru</summary>
		[JsonPropertyName("language")]
		public string? Language { get; init; }

		///<summary>A dictionary containing platform-specific options. Optional depending on the platform. eg: platform specific</summary>
		[JsonPropertyName("options")]
		public object? Options { get; init; }
	}

	public class UpdateServices
	{
		private readonly IHaContext _haContext;
		public UpdateServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Removes the skipped version marker from an update.</summary>
		///<param name="target">The target for this service call</param>
		public void ClearSkipped(ServiceTarget target)
		{
			_haContext.CallService("update", "clear_skipped", target);
		}

		///<summary>Install an update for this device or service</summary>
		///<param name="target">The target for this service call</param>
		public void Install(ServiceTarget target, UpdateInstallParameters data)
		{
			_haContext.CallService("update", "install", target, data);
		}

		///<summary>Install an update for this device or service</summary>
		///<param name="target">The target for this service call</param>
		///<param name="version">Version to install, if omitted, the latest version will be installed. eg: 1.0.0</param>
		///<param name="backup">Backup before installing the update, if supported by the integration.</param>
		public void Install(ServiceTarget target, string? @version = null, bool? @backup = null)
		{
			_haContext.CallService("update", "install", target, new UpdateInstallParameters{Version = @version, Backup = @backup});
		}

		///<summary>Mark currently available update as skipped.</summary>
		///<param name="target">The target for this service call</param>
		public void Skip(ServiceTarget target)
		{
			_haContext.CallService("update", "skip", target);
		}
	}

	public record UpdateInstallParameters
	{
		///<summary>Version to install, if omitted, the latest version will be installed. eg: 1.0.0</summary>
		[JsonPropertyName("version")]
		public string? Version { get; init; }

		///<summary>Backup before installing the update, if supported by the integration.</summary>
		[JsonPropertyName("backup")]
		public bool? Backup { get; init; }
	}

	public class UtilityMeterServices
	{
		private readonly IHaContext _haContext;
		public UtilityMeterServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Calibrates a utility meter sensor.</summary>
		///<param name="target">The target for this service call</param>
		public void Calibrate(ServiceTarget target, UtilityMeterCalibrateParameters data)
		{
			_haContext.CallService("utility_meter", "calibrate", target, data);
		}

		///<summary>Calibrates a utility meter sensor.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="value">Value to which set the meter eg: 100</param>
		public void Calibrate(ServiceTarget target, string @value)
		{
			_haContext.CallService("utility_meter", "calibrate", target, new UtilityMeterCalibrateParameters{Value = @value});
		}

		///<summary>Resets all counters of a utility meter.</summary>
		///<param name="target">The target for this service call</param>
		public void Reset(ServiceTarget target)
		{
			_haContext.CallService("utility_meter", "reset", target);
		}
	}

	public record UtilityMeterCalibrateParameters
	{
		///<summary>Value to which set the meter eg: 100</summary>
		[JsonPropertyName("value")]
		public string? Value { get; init; }
	}

	public class VacuumServices
	{
		private readonly IHaContext _haContext;
		public VacuumServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Tell the vacuum cleaner to do a spot clean-up.</summary>
		///<param name="target">The target for this service call</param>
		public void CleanSpot(ServiceTarget target)
		{
			_haContext.CallService("vacuum", "clean_spot", target);
		}

		///<summary>Locate the vacuum cleaner robot.</summary>
		///<param name="target">The target for this service call</param>
		public void Locate(ServiceTarget target)
		{
			_haContext.CallService("vacuum", "locate", target);
		}

		///<summary>Pause the cleaning task.</summary>
		///<param name="target">The target for this service call</param>
		public void Pause(ServiceTarget target)
		{
			_haContext.CallService("vacuum", "pause", target);
		}

		///<summary>Tell the vacuum cleaner to return to its dock.</summary>
		///<param name="target">The target for this service call</param>
		public void ReturnToBase(ServiceTarget target)
		{
			_haContext.CallService("vacuum", "return_to_base", target);
		}

		///<summary>Send a raw command to the vacuum cleaner.</summary>
		///<param name="target">The target for this service call</param>
		public void SendCommand(ServiceTarget target, VacuumSendCommandParameters data)
		{
			_haContext.CallService("vacuum", "send_command", target, data);
		}

		///<summary>Send a raw command to the vacuum cleaner.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="command">Command to execute. eg: set_dnd_timer</param>
		///<param name="params">Parameters for the command. eg: { "key": "value" }</param>
		public void SendCommand(ServiceTarget target, string @command, object? @params = null)
		{
			_haContext.CallService("vacuum", "send_command", target, new VacuumSendCommandParameters{Command = @command, Params = @params});
		}

		///<summary>Set the fan speed of the vacuum cleaner.</summary>
		///<param name="target">The target for this service call</param>
		public void SetFanSpeed(ServiceTarget target, VacuumSetFanSpeedParameters data)
		{
			_haContext.CallService("vacuum", "set_fan_speed", target, data);
		}

		///<summary>Set the fan speed of the vacuum cleaner.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="fanSpeed">Platform dependent vacuum cleaner fan speed, with speed steps, like 'medium' or by percentage, between 0 and 100. eg: low</param>
		public void SetFanSpeed(ServiceTarget target, string @fanSpeed)
		{
			_haContext.CallService("vacuum", "set_fan_speed", target, new VacuumSetFanSpeedParameters{FanSpeed = @fanSpeed});
		}

		///<summary>Start or resume the cleaning task.</summary>
		///<param name="target">The target for this service call</param>
		public void Start(ServiceTarget target)
		{
			_haContext.CallService("vacuum", "start", target);
		}

		///<summary>Start, pause, or resume the cleaning task.</summary>
		///<param name="target">The target for this service call</param>
		public void StartPause(ServiceTarget target)
		{
			_haContext.CallService("vacuum", "start_pause", target);
		}

		///<summary>Stop the current cleaning task.</summary>
		///<param name="target">The target for this service call</param>
		public void Stop(ServiceTarget target)
		{
			_haContext.CallService("vacuum", "stop", target);
		}

		public void Toggle()
		{
			_haContext.CallService("vacuum", "toggle", null);
		}

		///<summary>Stop the current cleaning task and return to home.</summary>
		///<param name="target">The target for this service call</param>
		public void TurnOff(ServiceTarget target)
		{
			_haContext.CallService("vacuum", "turn_off", target);
		}

		///<summary>Start a new cleaning task.</summary>
		///<param name="target">The target for this service call</param>
		public void TurnOn(ServiceTarget target)
		{
			_haContext.CallService("vacuum", "turn_on", target);
		}
	}

	public record VacuumSendCommandParameters
	{
		///<summary>Command to execute. eg: set_dnd_timer</summary>
		[JsonPropertyName("command")]
		public string? Command { get; init; }

		///<summary>Parameters for the command. eg: { "key": "value" }</summary>
		[JsonPropertyName("params")]
		public object? Params { get; init; }
	}

	public record VacuumSetFanSpeedParameters
	{
		///<summary>Platform dependent vacuum cleaner fan speed, with speed steps, like 'medium' or by percentage, between 0 and 100. eg: low</summary>
		[JsonPropertyName("fan_speed")]
		public string? FanSpeed { get; init; }
	}

	public class WakeOnLanServices
	{
		private readonly IHaContext _haContext;
		public WakeOnLanServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Send a 'magic packet' to wake up a device with 'Wake-On-LAN' capabilities.</summary>
		public void SendMagicPacket(WakeOnLanSendMagicPacketParameters data)
		{
			_haContext.CallService("wake_on_lan", "send_magic_packet", null, data);
		}

		///<summary>Send a 'magic packet' to wake up a device with 'Wake-On-LAN' capabilities.</summary>
		///<param name="mac">MAC address of the device to wake up. eg: aa:bb:cc:dd:ee:ff</param>
		///<param name="broadcastAddress">Broadcast IP where to send the magic packet. eg: 192.168.255.255</param>
		///<param name="broadcastPort">Port where to send the magic packet.</param>
		public void SendMagicPacket(string @mac, string? @broadcastAddress = null, long? @broadcastPort = null)
		{
			_haContext.CallService("wake_on_lan", "send_magic_packet", null, new WakeOnLanSendMagicPacketParameters{Mac = @mac, BroadcastAddress = @broadcastAddress, BroadcastPort = @broadcastPort});
		}
	}

	public record WakeOnLanSendMagicPacketParameters
	{
		///<summary>MAC address of the device to wake up. eg: aa:bb:cc:dd:ee:ff</summary>
		[JsonPropertyName("mac")]
		public string? Mac { get; init; }

		///<summary>Broadcast IP where to send the magic packet. eg: 192.168.255.255</summary>
		[JsonPropertyName("broadcast_address")]
		public string? BroadcastAddress { get; init; }

		///<summary>Port where to send the magic packet.</summary>
		[JsonPropertyName("broadcast_port")]
		public long? BroadcastPort { get; init; }
	}

	public class WebostvServices
	{
		private readonly IHaContext _haContext;
		public WebostvServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Send a button press command.</summary>
		public void Button(WebostvButtonParameters data)
		{
			_haContext.CallService("webostv", "button", null, data);
		}

		///<summary>Send a button press command.</summary>
		///<param name="entityId">Name(s) of the webostv entities where to run the API method.</param>
		///<param name="button">Name of the button to press.  Known possible values are LEFT, RIGHT, DOWN, UP, HOME, MENU, BACK, ENTER, DASH, INFO, ASTERISK, CC, EXIT, MUTE, RED, GREEN, BLUE, VOLUMEUP, VOLUMEDOWN, CHANNELUP, CHANNELDOWN, PLAY, PAUSE, 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 eg: LEFT</param>
		public void Button(string @entityId, string @button)
		{
			_haContext.CallService("webostv", "button", null, new WebostvButtonParameters{EntityId = @entityId, Button = @button});
		}

		///<summary>Send a command.</summary>
		public void Command(WebostvCommandParameters data)
		{
			_haContext.CallService("webostv", "command", null, data);
		}

		///<summary>Send a command.</summary>
		///<param name="entityId">Name(s) of the webostv entities where to run the API method.</param>
		///<param name="command">Endpoint of the command. eg: system.launcher/open</param>
		///<param name="payload">An optional payload to provide to the endpoint in the format of key value pair(s). eg: target: https://www.google.com</param>
		public void Command(string @entityId, string @command, object? @payload = null)
		{
			_haContext.CallService("webostv", "command", null, new WebostvCommandParameters{EntityId = @entityId, Command = @command, Payload = @payload});
		}

		///<summary>Send the TV the command to change sound output.</summary>
		public void SelectSoundOutput(WebostvSelectSoundOutputParameters data)
		{
			_haContext.CallService("webostv", "select_sound_output", null, data);
		}

		///<summary>Send the TV the command to change sound output.</summary>
		///<param name="entityId">Name(s) of the webostv entities to change sound output on.</param>
		///<param name="soundOutput">Name of the sound output to switch to. eg: external_speaker</param>
		public void SelectSoundOutput(string @entityId, string @soundOutput)
		{
			_haContext.CallService("webostv", "select_sound_output", null, new WebostvSelectSoundOutputParameters{EntityId = @entityId, SoundOutput = @soundOutput});
		}
	}

	public record WebostvButtonParameters
	{
		///<summary>Name(s) of the webostv entities where to run the API method.</summary>
		[JsonPropertyName("entity_id")]
		public string? EntityId { get; init; }

		///<summary>Name of the button to press.  Known possible values are LEFT, RIGHT, DOWN, UP, HOME, MENU, BACK, ENTER, DASH, INFO, ASTERISK, CC, EXIT, MUTE, RED, GREEN, BLUE, VOLUMEUP, VOLUMEDOWN, CHANNELUP, CHANNELDOWN, PLAY, PAUSE, 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 eg: LEFT</summary>
		[JsonPropertyName("button")]
		public string? Button { get; init; }
	}

	public record WebostvCommandParameters
	{
		///<summary>Name(s) of the webostv entities where to run the API method.</summary>
		[JsonPropertyName("entity_id")]
		public string? EntityId { get; init; }

		///<summary>Endpoint of the command. eg: system.launcher/open</summary>
		[JsonPropertyName("command")]
		public string? Command { get; init; }

		///<summary>An optional payload to provide to the endpoint in the format of key value pair(s). eg: target: https://www.google.com</summary>
		[JsonPropertyName("payload")]
		public object? Payload { get; init; }
	}

	public record WebostvSelectSoundOutputParameters
	{
		///<summary>Name(s) of the webostv entities to change sound output on.</summary>
		[JsonPropertyName("entity_id")]
		public string? EntityId { get; init; }

		///<summary>Name of the sound output to switch to. eg: external_speaker</summary>
		[JsonPropertyName("sound_output")]
		public string? SoundOutput { get; init; }
	}

	public class XiaomiMiioServices
	{
		private readonly IHaContext _haContext;
		public XiaomiMiioServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Start cleaning of the specified segment(s).</summary>
		///<param name="target">The target for this service call</param>
		public void VacuumCleanSegment(ServiceTarget target, XiaomiMiioVacuumCleanSegmentParameters data)
		{
			_haContext.CallService("xiaomi_miio", "vacuum_clean_segment", target, data);
		}

		///<summary>Start cleaning of the specified segment(s).</summary>
		///<param name="target">The target for this service call</param>
		///<param name="segments">Segments. eg: [1,2]</param>
		public void VacuumCleanSegment(ServiceTarget target, object? @segments = null)
		{
			_haContext.CallService("xiaomi_miio", "vacuum_clean_segment", target, new XiaomiMiioVacuumCleanSegmentParameters{Segments = @segments});
		}

		///<summary>Start the cleaning operation in the selected areas for the number of repeats indicated.</summary>
		///<param name="target">The target for this service call</param>
		public void VacuumCleanZone(ServiceTarget target, XiaomiMiioVacuumCleanZoneParameters data)
		{
			_haContext.CallService("xiaomi_miio", "vacuum_clean_zone", target, data);
		}

		///<summary>Start the cleaning operation in the selected areas for the number of repeats indicated.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="zone">Array of zones. Each zone is an array of 4 integer values. eg: [[23510,25311,25110,26362]]</param>
		///<param name="repeats">Number of cleaning repeats for each zone.</param>
		public void VacuumCleanZone(ServiceTarget target, object? @zone = null, long? @repeats = null)
		{
			_haContext.CallService("xiaomi_miio", "vacuum_clean_zone", target, new XiaomiMiioVacuumCleanZoneParameters{Zone = @zone, Repeats = @repeats});
		}

		///<summary>Go to the specified coordinates.</summary>
		///<param name="target">The target for this service call</param>
		public void VacuumGoto(ServiceTarget target, XiaomiMiioVacuumGotoParameters data)
		{
			_haContext.CallService("xiaomi_miio", "vacuum_goto", target, data);
		}

		///<summary>Go to the specified coordinates.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="xCoord">x-coordinate. eg: 27500</param>
		///<param name="yCoord">y-coordinate. eg: 32000</param>
		public void VacuumGoto(ServiceTarget target, string? @xCoord = null, string? @yCoord = null)
		{
			_haContext.CallService("xiaomi_miio", "vacuum_goto", target, new XiaomiMiioVacuumGotoParameters{XCoord = @xCoord, YCoord = @yCoord});
		}

		///<summary>Remote control the vacuum cleaner, make sure you first set it in remote control mode with `remote_control_start`.</summary>
		///<param name="target">The target for this service call</param>
		public void VacuumRemoteControlMove(ServiceTarget target, XiaomiMiioVacuumRemoteControlMoveParameters data)
		{
			_haContext.CallService("xiaomi_miio", "vacuum_remote_control_move", target, data);
		}

		///<summary>Remote control the vacuum cleaner, make sure you first set it in remote control mode with `remote_control_start`.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="velocity">Speed.</param>
		///<param name="rotation">Rotation, between -179 degrees and 179 degrees.</param>
		///<param name="duration">Duration of the movement.</param>
		public void VacuumRemoteControlMove(ServiceTarget target, double? @velocity = null, long? @rotation = null, long? @duration = null)
		{
			_haContext.CallService("xiaomi_miio", "vacuum_remote_control_move", target, new XiaomiMiioVacuumRemoteControlMoveParameters{Velocity = @velocity, Rotation = @rotation, Duration = @duration});
		}

		///<summary>Remote control the vacuum cleaner, only makes one move and then stops.</summary>
		///<param name="target">The target for this service call</param>
		public void VacuumRemoteControlMoveStep(ServiceTarget target, XiaomiMiioVacuumRemoteControlMoveStepParameters data)
		{
			_haContext.CallService("xiaomi_miio", "vacuum_remote_control_move_step", target, data);
		}

		///<summary>Remote control the vacuum cleaner, only makes one move and then stops.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="velocity">Speed.</param>
		///<param name="rotation">Rotation.</param>
		///<param name="duration">Duration of the movement.</param>
		public void VacuumRemoteControlMoveStep(ServiceTarget target, double? @velocity = null, long? @rotation = null, long? @duration = null)
		{
			_haContext.CallService("xiaomi_miio", "vacuum_remote_control_move_step", target, new XiaomiMiioVacuumRemoteControlMoveStepParameters{Velocity = @velocity, Rotation = @rotation, Duration = @duration});
		}

		///<summary>Start remote control of the vacuum cleaner. You can then move it with `remote_control_move`, when done call `remote_control_stop`.</summary>
		///<param name="target">The target for this service call</param>
		public void VacuumRemoteControlStart(ServiceTarget target)
		{
			_haContext.CallService("xiaomi_miio", "vacuum_remote_control_start", target);
		}

		///<summary>Stop remote control mode of the vacuum cleaner.</summary>
		///<param name="target">The target for this service call</param>
		public void VacuumRemoteControlStop(ServiceTarget target)
		{
			_haContext.CallService("xiaomi_miio", "vacuum_remote_control_stop", target);
		}
	}

	public record XiaomiMiioVacuumCleanSegmentParameters
	{
		///<summary>Segments. eg: [1,2]</summary>
		[JsonPropertyName("segments")]
		public object? Segments { get; init; }
	}

	public record XiaomiMiioVacuumCleanZoneParameters
	{
		///<summary>Array of zones. Each zone is an array of 4 integer values. eg: [[23510,25311,25110,26362]]</summary>
		[JsonPropertyName("zone")]
		public object? Zone { get; init; }

		///<summary>Number of cleaning repeats for each zone.</summary>
		[JsonPropertyName("repeats")]
		public long? Repeats { get; init; }
	}

	public record XiaomiMiioVacuumGotoParameters
	{
		///<summary>x-coordinate. eg: 27500</summary>
		[JsonPropertyName("x_coord")]
		public string? XCoord { get; init; }

		///<summary>y-coordinate. eg: 32000</summary>
		[JsonPropertyName("y_coord")]
		public string? YCoord { get; init; }
	}

	public record XiaomiMiioVacuumRemoteControlMoveParameters
	{
		///<summary>Speed.</summary>
		[JsonPropertyName("velocity")]
		public double? Velocity { get; init; }

		///<summary>Rotation, between -179 degrees and 179 degrees.</summary>
		[JsonPropertyName("rotation")]
		public long? Rotation { get; init; }

		///<summary>Duration of the movement.</summary>
		[JsonPropertyName("duration")]
		public long? Duration { get; init; }
	}

	public record XiaomiMiioVacuumRemoteControlMoveStepParameters
	{
		///<summary>Speed.</summary>
		[JsonPropertyName("velocity")]
		public double? Velocity { get; init; }

		///<summary>Rotation.</summary>
		[JsonPropertyName("rotation")]
		public long? Rotation { get; init; }

		///<summary>Duration of the movement.</summary>
		[JsonPropertyName("duration")]
		public long? Duration { get; init; }
	}

	public class ZoneServices
	{
		private readonly IHaContext _haContext;
		public ZoneServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Reload the YAML-based zone configuration.</summary>
		public void Reload()
		{
			_haContext.CallService("zone", "reload", null);
		}
	}

	public static class AlarmControlPanelEntityExtensionMethods
	{
		///<summary>Send the alarm the command for arm away.</summary>
		public static void AlarmArmAway(this AlarmControlPanelEntity target, AlarmControlPanelAlarmArmAwayParameters data)
		{
			target.CallService("alarm_arm_away", data);
		}

		///<summary>Send the alarm the command for arm away.</summary>
		public static void AlarmArmAway(this IEnumerable<AlarmControlPanelEntity> target, AlarmControlPanelAlarmArmAwayParameters data)
		{
			target.CallService("alarm_arm_away", data);
		}

		///<summary>Send the alarm the command for arm away.</summary>
		///<param name="target">The AlarmControlPanelEntity to call this service for</param>
		///<param name="code">An optional code to arm away the alarm control panel with. eg: 1234</param>
		public static void AlarmArmAway(this AlarmControlPanelEntity target, string? @code = null)
		{
			target.CallService("alarm_arm_away", new AlarmControlPanelAlarmArmAwayParameters{Code = @code});
		}

		///<summary>Send the alarm the command for arm away.</summary>
		///<param name="target">The IEnumerable<AlarmControlPanelEntity> to call this service for</param>
		///<param name="code">An optional code to arm away the alarm control panel with. eg: 1234</param>
		public static void AlarmArmAway(this IEnumerable<AlarmControlPanelEntity> target, string? @code = null)
		{
			target.CallService("alarm_arm_away", new AlarmControlPanelAlarmArmAwayParameters{Code = @code});
		}

		///<summary>Send arm custom bypass command.</summary>
		public static void AlarmArmCustomBypass(this AlarmControlPanelEntity target, AlarmControlPanelAlarmArmCustomBypassParameters data)
		{
			target.CallService("alarm_arm_custom_bypass", data);
		}

		///<summary>Send arm custom bypass command.</summary>
		public static void AlarmArmCustomBypass(this IEnumerable<AlarmControlPanelEntity> target, AlarmControlPanelAlarmArmCustomBypassParameters data)
		{
			target.CallService("alarm_arm_custom_bypass", data);
		}

		///<summary>Send arm custom bypass command.</summary>
		///<param name="target">The AlarmControlPanelEntity to call this service for</param>
		///<param name="code">An optional code to arm custom bypass the alarm control panel with. eg: 1234</param>
		public static void AlarmArmCustomBypass(this AlarmControlPanelEntity target, string? @code = null)
		{
			target.CallService("alarm_arm_custom_bypass", new AlarmControlPanelAlarmArmCustomBypassParameters{Code = @code});
		}

		///<summary>Send arm custom bypass command.</summary>
		///<param name="target">The IEnumerable<AlarmControlPanelEntity> to call this service for</param>
		///<param name="code">An optional code to arm custom bypass the alarm control panel with. eg: 1234</param>
		public static void AlarmArmCustomBypass(this IEnumerable<AlarmControlPanelEntity> target, string? @code = null)
		{
			target.CallService("alarm_arm_custom_bypass", new AlarmControlPanelAlarmArmCustomBypassParameters{Code = @code});
		}

		///<summary>Send the alarm the command for arm home.</summary>
		public static void AlarmArmHome(this AlarmControlPanelEntity target, AlarmControlPanelAlarmArmHomeParameters data)
		{
			target.CallService("alarm_arm_home", data);
		}

		///<summary>Send the alarm the command for arm home.</summary>
		public static void AlarmArmHome(this IEnumerable<AlarmControlPanelEntity> target, AlarmControlPanelAlarmArmHomeParameters data)
		{
			target.CallService("alarm_arm_home", data);
		}

		///<summary>Send the alarm the command for arm home.</summary>
		///<param name="target">The AlarmControlPanelEntity to call this service for</param>
		///<param name="code">An optional code to arm home the alarm control panel with. eg: 1234</param>
		public static void AlarmArmHome(this AlarmControlPanelEntity target, string? @code = null)
		{
			target.CallService("alarm_arm_home", new AlarmControlPanelAlarmArmHomeParameters{Code = @code});
		}

		///<summary>Send the alarm the command for arm home.</summary>
		///<param name="target">The IEnumerable<AlarmControlPanelEntity> to call this service for</param>
		///<param name="code">An optional code to arm home the alarm control panel with. eg: 1234</param>
		public static void AlarmArmHome(this IEnumerable<AlarmControlPanelEntity> target, string? @code = null)
		{
			target.CallService("alarm_arm_home", new AlarmControlPanelAlarmArmHomeParameters{Code = @code});
		}

		///<summary>Send the alarm the command for arm night.</summary>
		public static void AlarmArmNight(this AlarmControlPanelEntity target, AlarmControlPanelAlarmArmNightParameters data)
		{
			target.CallService("alarm_arm_night", data);
		}

		///<summary>Send the alarm the command for arm night.</summary>
		public static void AlarmArmNight(this IEnumerable<AlarmControlPanelEntity> target, AlarmControlPanelAlarmArmNightParameters data)
		{
			target.CallService("alarm_arm_night", data);
		}

		///<summary>Send the alarm the command for arm night.</summary>
		///<param name="target">The AlarmControlPanelEntity to call this service for</param>
		///<param name="code">An optional code to arm night the alarm control panel with. eg: 1234</param>
		public static void AlarmArmNight(this AlarmControlPanelEntity target, string? @code = null)
		{
			target.CallService("alarm_arm_night", new AlarmControlPanelAlarmArmNightParameters{Code = @code});
		}

		///<summary>Send the alarm the command for arm night.</summary>
		///<param name="target">The IEnumerable<AlarmControlPanelEntity> to call this service for</param>
		///<param name="code">An optional code to arm night the alarm control panel with. eg: 1234</param>
		public static void AlarmArmNight(this IEnumerable<AlarmControlPanelEntity> target, string? @code = null)
		{
			target.CallService("alarm_arm_night", new AlarmControlPanelAlarmArmNightParameters{Code = @code});
		}

		///<summary>Send the alarm the command for arm vacation.</summary>
		public static void AlarmArmVacation(this AlarmControlPanelEntity target, AlarmControlPanelAlarmArmVacationParameters data)
		{
			target.CallService("alarm_arm_vacation", data);
		}

		///<summary>Send the alarm the command for arm vacation.</summary>
		public static void AlarmArmVacation(this IEnumerable<AlarmControlPanelEntity> target, AlarmControlPanelAlarmArmVacationParameters data)
		{
			target.CallService("alarm_arm_vacation", data);
		}

		///<summary>Send the alarm the command for arm vacation.</summary>
		///<param name="target">The AlarmControlPanelEntity to call this service for</param>
		///<param name="code">An optional code to arm vacation the alarm control panel with. eg: 1234</param>
		public static void AlarmArmVacation(this AlarmControlPanelEntity target, string? @code = null)
		{
			target.CallService("alarm_arm_vacation", new AlarmControlPanelAlarmArmVacationParameters{Code = @code});
		}

		///<summary>Send the alarm the command for arm vacation.</summary>
		///<param name="target">The IEnumerable<AlarmControlPanelEntity> to call this service for</param>
		///<param name="code">An optional code to arm vacation the alarm control panel with. eg: 1234</param>
		public static void AlarmArmVacation(this IEnumerable<AlarmControlPanelEntity> target, string? @code = null)
		{
			target.CallService("alarm_arm_vacation", new AlarmControlPanelAlarmArmVacationParameters{Code = @code});
		}

		///<summary>Send the alarm the command for disarm.</summary>
		public static void AlarmDisarm(this AlarmControlPanelEntity target, AlarmControlPanelAlarmDisarmParameters data)
		{
			target.CallService("alarm_disarm", data);
		}

		///<summary>Send the alarm the command for disarm.</summary>
		public static void AlarmDisarm(this IEnumerable<AlarmControlPanelEntity> target, AlarmControlPanelAlarmDisarmParameters data)
		{
			target.CallService("alarm_disarm", data);
		}

		///<summary>Send the alarm the command for disarm.</summary>
		///<param name="target">The AlarmControlPanelEntity to call this service for</param>
		///<param name="code">An optional code to disarm the alarm control panel with. eg: 1234</param>
		public static void AlarmDisarm(this AlarmControlPanelEntity target, string? @code = null)
		{
			target.CallService("alarm_disarm", new AlarmControlPanelAlarmDisarmParameters{Code = @code});
		}

		///<summary>Send the alarm the command for disarm.</summary>
		///<param name="target">The IEnumerable<AlarmControlPanelEntity> to call this service for</param>
		///<param name="code">An optional code to disarm the alarm control panel with. eg: 1234</param>
		public static void AlarmDisarm(this IEnumerable<AlarmControlPanelEntity> target, string? @code = null)
		{
			target.CallService("alarm_disarm", new AlarmControlPanelAlarmDisarmParameters{Code = @code});
		}

		///<summary>Send the alarm the command for trigger.</summary>
		public static void AlarmTrigger(this AlarmControlPanelEntity target, AlarmControlPanelAlarmTriggerParameters data)
		{
			target.CallService("alarm_trigger", data);
		}

		///<summary>Send the alarm the command for trigger.</summary>
		public static void AlarmTrigger(this IEnumerable<AlarmControlPanelEntity> target, AlarmControlPanelAlarmTriggerParameters data)
		{
			target.CallService("alarm_trigger", data);
		}

		///<summary>Send the alarm the command for trigger.</summary>
		///<param name="target">The AlarmControlPanelEntity to call this service for</param>
		///<param name="code">An optional code to trigger the alarm control panel with. eg: 1234</param>
		public static void AlarmTrigger(this AlarmControlPanelEntity target, string? @code = null)
		{
			target.CallService("alarm_trigger", new AlarmControlPanelAlarmTriggerParameters{Code = @code});
		}

		///<summary>Send the alarm the command for trigger.</summary>
		///<param name="target">The IEnumerable<AlarmControlPanelEntity> to call this service for</param>
		///<param name="code">An optional code to trigger the alarm control panel with. eg: 1234</param>
		public static void AlarmTrigger(this IEnumerable<AlarmControlPanelEntity> target, string? @code = null)
		{
			target.CallService("alarm_trigger", new AlarmControlPanelAlarmTriggerParameters{Code = @code});
		}
	}

	public static class ButtonEntityExtensionMethods
	{
		///<summary>Press the button entity.</summary>
		public static void Press(this ButtonEntity target)
		{
			target.CallService("press");
		}

		///<summary>Press the button entity.</summary>
		public static void Press(this IEnumerable<ButtonEntity> target)
		{
			target.CallService("press");
		}
	}

	public static class CameraEntityExtensionMethods
	{
		///<summary>Disable the motion detection in a camera.</summary>
		public static void DisableMotionDetection(this CameraEntity target)
		{
			target.CallService("disable_motion_detection");
		}

		///<summary>Disable the motion detection in a camera.</summary>
		public static void DisableMotionDetection(this IEnumerable<CameraEntity> target)
		{
			target.CallService("disable_motion_detection");
		}

		///<summary>Enable the motion detection in a camera.</summary>
		public static void EnableMotionDetection(this CameraEntity target)
		{
			target.CallService("enable_motion_detection");
		}

		///<summary>Enable the motion detection in a camera.</summary>
		public static void EnableMotionDetection(this IEnumerable<CameraEntity> target)
		{
			target.CallService("enable_motion_detection");
		}

		///<summary>Play camera stream on supported media player.</summary>
		public static void PlayStream(this CameraEntity target, CameraPlayStreamParameters data)
		{
			target.CallService("play_stream", data);
		}

		///<summary>Play camera stream on supported media player.</summary>
		public static void PlayStream(this IEnumerable<CameraEntity> target, CameraPlayStreamParameters data)
		{
			target.CallService("play_stream", data);
		}

		///<summary>Play camera stream on supported media player.</summary>
		///<param name="target">The CameraEntity to call this service for</param>
		///<param name="mediaPlayer">Name(s) of media player to stream to.</param>
		///<param name="format">Stream format supported by media player.</param>
		public static void PlayStream(this CameraEntity target, string @mediaPlayer, object? @format = null)
		{
			target.CallService("play_stream", new CameraPlayStreamParameters{MediaPlayer = @mediaPlayer, Format = @format});
		}

		///<summary>Play camera stream on supported media player.</summary>
		///<param name="target">The IEnumerable<CameraEntity> to call this service for</param>
		///<param name="mediaPlayer">Name(s) of media player to stream to.</param>
		///<param name="format">Stream format supported by media player.</param>
		public static void PlayStream(this IEnumerable<CameraEntity> target, string @mediaPlayer, object? @format = null)
		{
			target.CallService("play_stream", new CameraPlayStreamParameters{MediaPlayer = @mediaPlayer, Format = @format});
		}

		///<summary>Record live camera feed.</summary>
		public static void Record(this CameraEntity target, CameraRecordParameters data)
		{
			target.CallService("record", data);
		}

		///<summary>Record live camera feed.</summary>
		public static void Record(this IEnumerable<CameraEntity> target, CameraRecordParameters data)
		{
			target.CallService("record", data);
		}

		///<summary>Record live camera feed.</summary>
		///<param name="target">The CameraEntity to call this service for</param>
		///<param name="filename">Template of a Filename. Variable is entity_id. Must be mp4. eg: /tmp/snapshot_{{ entity_id.name }}.mp4</param>
		///<param name="duration">Target recording length.</param>
		///<param name="lookback">Target lookback period to include in addition to duration. Only available if there is currently an active HLS stream.</param>
		public static void Record(this CameraEntity target, string @filename, long? @duration = null, long? @lookback = null)
		{
			target.CallService("record", new CameraRecordParameters{Filename = @filename, Duration = @duration, Lookback = @lookback});
		}

		///<summary>Record live camera feed.</summary>
		///<param name="target">The IEnumerable<CameraEntity> to call this service for</param>
		///<param name="filename">Template of a Filename. Variable is entity_id. Must be mp4. eg: /tmp/snapshot_{{ entity_id.name }}.mp4</param>
		///<param name="duration">Target recording length.</param>
		///<param name="lookback">Target lookback period to include in addition to duration. Only available if there is currently an active HLS stream.</param>
		public static void Record(this IEnumerable<CameraEntity> target, string @filename, long? @duration = null, long? @lookback = null)
		{
			target.CallService("record", new CameraRecordParameters{Filename = @filename, Duration = @duration, Lookback = @lookback});
		}

		///<summary>Take a snapshot from a camera.</summary>
		public static void Snapshot(this CameraEntity target, CameraSnapshotParameters data)
		{
			target.CallService("snapshot", data);
		}

		///<summary>Take a snapshot from a camera.</summary>
		public static void Snapshot(this IEnumerable<CameraEntity> target, CameraSnapshotParameters data)
		{
			target.CallService("snapshot", data);
		}

		///<summary>Take a snapshot from a camera.</summary>
		///<param name="target">The CameraEntity to call this service for</param>
		///<param name="filename">Template of a Filename. Variable is entity_id. eg: /tmp/snapshot_{{ entity_id.name }}.jpg</param>
		public static void Snapshot(this CameraEntity target, string @filename)
		{
			target.CallService("snapshot", new CameraSnapshotParameters{Filename = @filename});
		}

		///<summary>Take a snapshot from a camera.</summary>
		///<param name="target">The IEnumerable<CameraEntity> to call this service for</param>
		///<param name="filename">Template of a Filename. Variable is entity_id. eg: /tmp/snapshot_{{ entity_id.name }}.jpg</param>
		public static void Snapshot(this IEnumerable<CameraEntity> target, string @filename)
		{
			target.CallService("snapshot", new CameraSnapshotParameters{Filename = @filename});
		}

		///<summary>Turn off camera.</summary>
		public static void TurnOff(this CameraEntity target)
		{
			target.CallService("turn_off");
		}

		///<summary>Turn off camera.</summary>
		public static void TurnOff(this IEnumerable<CameraEntity> target)
		{
			target.CallService("turn_off");
		}

		///<summary>Turn on camera.</summary>
		public static void TurnOn(this CameraEntity target)
		{
			target.CallService("turn_on");
		}

		///<summary>Turn on camera.</summary>
		public static void TurnOn(this IEnumerable<CameraEntity> target)
		{
			target.CallService("turn_on");
		}
	}

	public static class ClimateEntityExtensionMethods
	{
		///<summary>Turn auxiliary heater on/off for climate device.</summary>
		public static void SetAuxHeat(this ClimateEntity target, ClimateSetAuxHeatParameters data)
		{
			target.CallService("set_aux_heat", data);
		}

		///<summary>Turn auxiliary heater on/off for climate device.</summary>
		public static void SetAuxHeat(this IEnumerable<ClimateEntity> target, ClimateSetAuxHeatParameters data)
		{
			target.CallService("set_aux_heat", data);
		}

		///<summary>Turn auxiliary heater on/off for climate device.</summary>
		///<param name="target">The ClimateEntity to call this service for</param>
		///<param name="auxHeat">New value of auxiliary heater.</param>
		public static void SetAuxHeat(this ClimateEntity target, bool @auxHeat)
		{
			target.CallService("set_aux_heat", new ClimateSetAuxHeatParameters{AuxHeat = @auxHeat});
		}

		///<summary>Turn auxiliary heater on/off for climate device.</summary>
		///<param name="target">The IEnumerable<ClimateEntity> to call this service for</param>
		///<param name="auxHeat">New value of auxiliary heater.</param>
		public static void SetAuxHeat(this IEnumerable<ClimateEntity> target, bool @auxHeat)
		{
			target.CallService("set_aux_heat", new ClimateSetAuxHeatParameters{AuxHeat = @auxHeat});
		}

		///<summary>Set fan operation for climate device.</summary>
		public static void SetFanMode(this ClimateEntity target, ClimateSetFanModeParameters data)
		{
			target.CallService("set_fan_mode", data);
		}

		///<summary>Set fan operation for climate device.</summary>
		public static void SetFanMode(this IEnumerable<ClimateEntity> target, ClimateSetFanModeParameters data)
		{
			target.CallService("set_fan_mode", data);
		}

		///<summary>Set fan operation for climate device.</summary>
		///<param name="target">The ClimateEntity to call this service for</param>
		///<param name="fanMode">New value of fan mode. eg: low</param>
		public static void SetFanMode(this ClimateEntity target, string @fanMode)
		{
			target.CallService("set_fan_mode", new ClimateSetFanModeParameters{FanMode = @fanMode});
		}

		///<summary>Set fan operation for climate device.</summary>
		///<param name="target">The IEnumerable<ClimateEntity> to call this service for</param>
		///<param name="fanMode">New value of fan mode. eg: low</param>
		public static void SetFanMode(this IEnumerable<ClimateEntity> target, string @fanMode)
		{
			target.CallService("set_fan_mode", new ClimateSetFanModeParameters{FanMode = @fanMode});
		}

		///<summary>Set target humidity of climate device.</summary>
		public static void SetHumidity(this ClimateEntity target, ClimateSetHumidityParameters data)
		{
			target.CallService("set_humidity", data);
		}

		///<summary>Set target humidity of climate device.</summary>
		public static void SetHumidity(this IEnumerable<ClimateEntity> target, ClimateSetHumidityParameters data)
		{
			target.CallService("set_humidity", data);
		}

		///<summary>Set target humidity of climate device.</summary>
		///<param name="target">The ClimateEntity to call this service for</param>
		///<param name="humidity">New target humidity for climate device.</param>
		public static void SetHumidity(this ClimateEntity target, long @humidity)
		{
			target.CallService("set_humidity", new ClimateSetHumidityParameters{Humidity = @humidity});
		}

		///<summary>Set target humidity of climate device.</summary>
		///<param name="target">The IEnumerable<ClimateEntity> to call this service for</param>
		///<param name="humidity">New target humidity for climate device.</param>
		public static void SetHumidity(this IEnumerable<ClimateEntity> target, long @humidity)
		{
			target.CallService("set_humidity", new ClimateSetHumidityParameters{Humidity = @humidity});
		}

		///<summary>Set HVAC operation mode for climate device.</summary>
		public static void SetHvacMode(this ClimateEntity target, ClimateSetHvacModeParameters data)
		{
			target.CallService("set_hvac_mode", data);
		}

		///<summary>Set HVAC operation mode for climate device.</summary>
		public static void SetHvacMode(this IEnumerable<ClimateEntity> target, ClimateSetHvacModeParameters data)
		{
			target.CallService("set_hvac_mode", data);
		}

		///<summary>Set HVAC operation mode for climate device.</summary>
		///<param name="target">The ClimateEntity to call this service for</param>
		///<param name="hvacMode">New value of operation mode.</param>
		public static void SetHvacMode(this ClimateEntity target, object? @hvacMode = null)
		{
			target.CallService("set_hvac_mode", new ClimateSetHvacModeParameters{HvacMode = @hvacMode});
		}

		///<summary>Set HVAC operation mode for climate device.</summary>
		///<param name="target">The IEnumerable<ClimateEntity> to call this service for</param>
		///<param name="hvacMode">New value of operation mode.</param>
		public static void SetHvacMode(this IEnumerable<ClimateEntity> target, object? @hvacMode = null)
		{
			target.CallService("set_hvac_mode", new ClimateSetHvacModeParameters{HvacMode = @hvacMode});
		}

		///<summary>Set preset mode for climate device.</summary>
		public static void SetPresetMode(this ClimateEntity target, ClimateSetPresetModeParameters data)
		{
			target.CallService("set_preset_mode", data);
		}

		///<summary>Set preset mode for climate device.</summary>
		public static void SetPresetMode(this IEnumerable<ClimateEntity> target, ClimateSetPresetModeParameters data)
		{
			target.CallService("set_preset_mode", data);
		}

		///<summary>Set preset mode for climate device.</summary>
		///<param name="target">The ClimateEntity to call this service for</param>
		///<param name="presetMode">New value of preset mode. eg: away</param>
		public static void SetPresetMode(this ClimateEntity target, string @presetMode)
		{
			target.CallService("set_preset_mode", new ClimateSetPresetModeParameters{PresetMode = @presetMode});
		}

		///<summary>Set preset mode for climate device.</summary>
		///<param name="target">The IEnumerable<ClimateEntity> to call this service for</param>
		///<param name="presetMode">New value of preset mode. eg: away</param>
		public static void SetPresetMode(this IEnumerable<ClimateEntity> target, string @presetMode)
		{
			target.CallService("set_preset_mode", new ClimateSetPresetModeParameters{PresetMode = @presetMode});
		}

		///<summary>Set swing operation for climate device.</summary>
		public static void SetSwingMode(this ClimateEntity target, ClimateSetSwingModeParameters data)
		{
			target.CallService("set_swing_mode", data);
		}

		///<summary>Set swing operation for climate device.</summary>
		public static void SetSwingMode(this IEnumerable<ClimateEntity> target, ClimateSetSwingModeParameters data)
		{
			target.CallService("set_swing_mode", data);
		}

		///<summary>Set swing operation for climate device.</summary>
		///<param name="target">The ClimateEntity to call this service for</param>
		///<param name="swingMode">New value of swing mode. eg: horizontal</param>
		public static void SetSwingMode(this ClimateEntity target, string @swingMode)
		{
			target.CallService("set_swing_mode", new ClimateSetSwingModeParameters{SwingMode = @swingMode});
		}

		///<summary>Set swing operation for climate device.</summary>
		///<param name="target">The IEnumerable<ClimateEntity> to call this service for</param>
		///<param name="swingMode">New value of swing mode. eg: horizontal</param>
		public static void SetSwingMode(this IEnumerable<ClimateEntity> target, string @swingMode)
		{
			target.CallService("set_swing_mode", new ClimateSetSwingModeParameters{SwingMode = @swingMode});
		}

		///<summary>Set target temperature of climate device.</summary>
		public static void SetTemperature(this ClimateEntity target, ClimateSetTemperatureParameters data)
		{
			target.CallService("set_temperature", data);
		}

		///<summary>Set target temperature of climate device.</summary>
		public static void SetTemperature(this IEnumerable<ClimateEntity> target, ClimateSetTemperatureParameters data)
		{
			target.CallService("set_temperature", data);
		}

		///<summary>Set target temperature of climate device.</summary>
		///<param name="target">The ClimateEntity to call this service for</param>
		///<param name="temperature">New target temperature for HVAC.</param>
		///<param name="targetTempHigh">New target high temperature for HVAC.</param>
		///<param name="targetTempLow">New target low temperature for HVAC.</param>
		///<param name="hvacMode">HVAC operation mode to set temperature to.</param>
		public static void SetTemperature(this ClimateEntity target, double? @temperature = null, double? @targetTempHigh = null, double? @targetTempLow = null, object? @hvacMode = null)
		{
			target.CallService("set_temperature", new ClimateSetTemperatureParameters{Temperature = @temperature, TargetTempHigh = @targetTempHigh, TargetTempLow = @targetTempLow, HvacMode = @hvacMode});
		}

		///<summary>Set target temperature of climate device.</summary>
		///<param name="target">The IEnumerable<ClimateEntity> to call this service for</param>
		///<param name="temperature">New target temperature for HVAC.</param>
		///<param name="targetTempHigh">New target high temperature for HVAC.</param>
		///<param name="targetTempLow">New target low temperature for HVAC.</param>
		///<param name="hvacMode">HVAC operation mode to set temperature to.</param>
		public static void SetTemperature(this IEnumerable<ClimateEntity> target, double? @temperature = null, double? @targetTempHigh = null, double? @targetTempLow = null, object? @hvacMode = null)
		{
			target.CallService("set_temperature", new ClimateSetTemperatureParameters{Temperature = @temperature, TargetTempHigh = @targetTempHigh, TargetTempLow = @targetTempLow, HvacMode = @hvacMode});
		}

		///<summary>Turn climate device off.</summary>
		public static void TurnOff(this ClimateEntity target)
		{
			target.CallService("turn_off");
		}

		///<summary>Turn climate device off.</summary>
		public static void TurnOff(this IEnumerable<ClimateEntity> target)
		{
			target.CallService("turn_off");
		}

		///<summary>Turn climate device on.</summary>
		public static void TurnOn(this ClimateEntity target)
		{
			target.CallService("turn_on");
		}

		///<summary>Turn climate device on.</summary>
		public static void TurnOn(this IEnumerable<ClimateEntity> target)
		{
			target.CallService("turn_on");
		}
	}

	public static class CounterEntityExtensionMethods
	{
		///<summary>Change counter parameters.</summary>
		public static void Configure(this CounterEntity target, CounterConfigureParameters data)
		{
			target.CallService("configure", data);
		}

		///<summary>Change counter parameters.</summary>
		public static void Configure(this IEnumerable<CounterEntity> target, CounterConfigureParameters data)
		{
			target.CallService("configure", data);
		}

		///<summary>Change counter parameters.</summary>
		///<param name="target">The CounterEntity to call this service for</param>
		///<param name="minimum">New minimum value for the counter or None to remove minimum.</param>
		///<param name="maximum">New maximum value for the counter or None to remove maximum.</param>
		///<param name="step">New value for step.</param>
		///<param name="initial">New value for initial.</param>
		///<param name="value">New state value.</param>
		public static void Configure(this CounterEntity target, long? @minimum = null, long? @maximum = null, long? @step = null, long? @initial = null, long? @value = null)
		{
			target.CallService("configure", new CounterConfigureParameters{Minimum = @minimum, Maximum = @maximum, Step = @step, Initial = @initial, Value = @value});
		}

		///<summary>Change counter parameters.</summary>
		///<param name="target">The IEnumerable<CounterEntity> to call this service for</param>
		///<param name="minimum">New minimum value for the counter or None to remove minimum.</param>
		///<param name="maximum">New maximum value for the counter or None to remove maximum.</param>
		///<param name="step">New value for step.</param>
		///<param name="initial">New value for initial.</param>
		///<param name="value">New state value.</param>
		public static void Configure(this IEnumerable<CounterEntity> target, long? @minimum = null, long? @maximum = null, long? @step = null, long? @initial = null, long? @value = null)
		{
			target.CallService("configure", new CounterConfigureParameters{Minimum = @minimum, Maximum = @maximum, Step = @step, Initial = @initial, Value = @value});
		}

		///<summary>Decrement a counter.</summary>
		public static void Decrement(this CounterEntity target)
		{
			target.CallService("decrement");
		}

		///<summary>Decrement a counter.</summary>
		public static void Decrement(this IEnumerable<CounterEntity> target)
		{
			target.CallService("decrement");
		}

		///<summary>Increment a counter.</summary>
		public static void Increment(this CounterEntity target)
		{
			target.CallService("increment");
		}

		///<summary>Increment a counter.</summary>
		public static void Increment(this IEnumerable<CounterEntity> target)
		{
			target.CallService("increment");
		}

		///<summary>Reset a counter.</summary>
		public static void Reset(this CounterEntity target)
		{
			target.CallService("reset");
		}

		///<summary>Reset a counter.</summary>
		public static void Reset(this IEnumerable<CounterEntity> target)
		{
			target.CallService("reset");
		}
	}

	public static class CoverEntityExtensionMethods
	{
		///<summary>Close all or specified cover.</summary>
		public static void CloseCover(this CoverEntity target)
		{
			target.CallService("close_cover");
		}

		///<summary>Close all or specified cover.</summary>
		public static void CloseCover(this IEnumerable<CoverEntity> target)
		{
			target.CallService("close_cover");
		}

		///<summary>Close all or specified cover tilt.</summary>
		public static void CloseCoverTilt(this CoverEntity target)
		{
			target.CallService("close_cover_tilt");
		}

		///<summary>Close all or specified cover tilt.</summary>
		public static void CloseCoverTilt(this IEnumerable<CoverEntity> target)
		{
			target.CallService("close_cover_tilt");
		}

		///<summary>Open all or specified cover.</summary>
		public static void OpenCover(this CoverEntity target)
		{
			target.CallService("open_cover");
		}

		///<summary>Open all or specified cover.</summary>
		public static void OpenCover(this IEnumerable<CoverEntity> target)
		{
			target.CallService("open_cover");
		}

		///<summary>Open all or specified cover tilt.</summary>
		public static void OpenCoverTilt(this CoverEntity target)
		{
			target.CallService("open_cover_tilt");
		}

		///<summary>Open all or specified cover tilt.</summary>
		public static void OpenCoverTilt(this IEnumerable<CoverEntity> target)
		{
			target.CallService("open_cover_tilt");
		}

		///<summary>Move to specific position all or specified cover.</summary>
		public static void SetCoverPosition(this CoverEntity target, CoverSetCoverPositionParameters data)
		{
			target.CallService("set_cover_position", data);
		}

		///<summary>Move to specific position all or specified cover.</summary>
		public static void SetCoverPosition(this IEnumerable<CoverEntity> target, CoverSetCoverPositionParameters data)
		{
			target.CallService("set_cover_position", data);
		}

		///<summary>Move to specific position all or specified cover.</summary>
		///<param name="target">The CoverEntity to call this service for</param>
		///<param name="position">Position of the cover</param>
		public static void SetCoverPosition(this CoverEntity target, long @position)
		{
			target.CallService("set_cover_position", new CoverSetCoverPositionParameters{Position = @position});
		}

		///<summary>Move to specific position all or specified cover.</summary>
		///<param name="target">The IEnumerable<CoverEntity> to call this service for</param>
		///<param name="position">Position of the cover</param>
		public static void SetCoverPosition(this IEnumerable<CoverEntity> target, long @position)
		{
			target.CallService("set_cover_position", new CoverSetCoverPositionParameters{Position = @position});
		}

		///<summary>Move to specific position all or specified cover tilt.</summary>
		public static void SetCoverTiltPosition(this CoverEntity target, CoverSetCoverTiltPositionParameters data)
		{
			target.CallService("set_cover_tilt_position", data);
		}

		///<summary>Move to specific position all or specified cover tilt.</summary>
		public static void SetCoverTiltPosition(this IEnumerable<CoverEntity> target, CoverSetCoverTiltPositionParameters data)
		{
			target.CallService("set_cover_tilt_position", data);
		}

		///<summary>Move to specific position all or specified cover tilt.</summary>
		///<param name="target">The CoverEntity to call this service for</param>
		///<param name="tiltPosition">Tilt position of the cover.</param>
		public static void SetCoverTiltPosition(this CoverEntity target, long @tiltPosition)
		{
			target.CallService("set_cover_tilt_position", new CoverSetCoverTiltPositionParameters{TiltPosition = @tiltPosition});
		}

		///<summary>Move to specific position all or specified cover tilt.</summary>
		///<param name="target">The IEnumerable<CoverEntity> to call this service for</param>
		///<param name="tiltPosition">Tilt position of the cover.</param>
		public static void SetCoverTiltPosition(this IEnumerable<CoverEntity> target, long @tiltPosition)
		{
			target.CallService("set_cover_tilt_position", new CoverSetCoverTiltPositionParameters{TiltPosition = @tiltPosition});
		}

		///<summary>Stop all or specified cover.</summary>
		public static void StopCover(this CoverEntity target)
		{
			target.CallService("stop_cover");
		}

		///<summary>Stop all or specified cover.</summary>
		public static void StopCover(this IEnumerable<CoverEntity> target)
		{
			target.CallService("stop_cover");
		}

		///<summary>Stop all or specified cover.</summary>
		public static void StopCoverTilt(this CoverEntity target)
		{
			target.CallService("stop_cover_tilt");
		}

		///<summary>Stop all or specified cover.</summary>
		public static void StopCoverTilt(this IEnumerable<CoverEntity> target)
		{
			target.CallService("stop_cover_tilt");
		}

		///<summary>Toggle a cover open/closed.</summary>
		public static void Toggle(this CoverEntity target)
		{
			target.CallService("toggle");
		}

		///<summary>Toggle a cover open/closed.</summary>
		public static void Toggle(this IEnumerable<CoverEntity> target)
		{
			target.CallService("toggle");
		}

		///<summary>Toggle a cover tilt open/closed.</summary>
		public static void ToggleCoverTilt(this CoverEntity target)
		{
			target.CallService("toggle_cover_tilt");
		}

		///<summary>Toggle a cover tilt open/closed.</summary>
		public static void ToggleCoverTilt(this IEnumerable<CoverEntity> target)
		{
			target.CallService("toggle_cover_tilt");
		}
	}

	public static class InputBooleanEntityExtensionMethods
	{
		///<summary>Toggle an input boolean</summary>
		public static void Toggle(this InputBooleanEntity target)
		{
			target.CallService("toggle");
		}

		///<summary>Toggle an input boolean</summary>
		public static void Toggle(this IEnumerable<InputBooleanEntity> target)
		{
			target.CallService("toggle");
		}

		///<summary>Turn off an input boolean</summary>
		public static void TurnOff(this InputBooleanEntity target)
		{
			target.CallService("turn_off");
		}

		///<summary>Turn off an input boolean</summary>
		public static void TurnOff(this IEnumerable<InputBooleanEntity> target)
		{
			target.CallService("turn_off");
		}

		///<summary>Turn on an input boolean</summary>
		public static void TurnOn(this InputBooleanEntity target)
		{
			target.CallService("turn_on");
		}

		///<summary>Turn on an input boolean</summary>
		public static void TurnOn(this IEnumerable<InputBooleanEntity> target)
		{
			target.CallService("turn_on");
		}
	}

	public static class InputButtonEntityExtensionMethods
	{
		///<summary>Press the input button entity.</summary>
		public static void Press(this InputButtonEntity target)
		{
			target.CallService("press");
		}

		///<summary>Press the input button entity.</summary>
		public static void Press(this IEnumerable<InputButtonEntity> target)
		{
			target.CallService("press");
		}
	}

	public static class InputDatetimeEntityExtensionMethods
	{
		///<summary>This can be used to dynamically set the date and/or time.</summary>
		public static void SetDatetime(this InputDatetimeEntity target, InputDatetimeSetDatetimeParameters data)
		{
			target.CallService("set_datetime", data);
		}

		///<summary>This can be used to dynamically set the date and/or time.</summary>
		public static void SetDatetime(this IEnumerable<InputDatetimeEntity> target, InputDatetimeSetDatetimeParameters data)
		{
			target.CallService("set_datetime", data);
		}

		///<summary>This can be used to dynamically set the date and/or time.</summary>
		///<param name="target">The InputDatetimeEntity to call this service for</param>
		///<param name="date">The target date the entity should be set to. eg: "2019-04-20"</param>
		///<param name="time">The target time the entity should be set to. eg: "05:04:20"</param>
		///<param name="datetime">The target date & time the entity should be set to. eg: "2019-04-20 05:04:20"</param>
		///<param name="timestamp">The target date & time the entity should be set to as expressed by a UNIX timestamp.</param>
		public static void SetDatetime(this InputDatetimeEntity target, string? @date = null, DateTime? @time = null, string? @datetime = null, long? @timestamp = null)
		{
			target.CallService("set_datetime", new InputDatetimeSetDatetimeParameters{Date = @date, Time = @time, Datetime = @datetime, Timestamp = @timestamp});
		}

		///<summary>This can be used to dynamically set the date and/or time.</summary>
		///<param name="target">The IEnumerable<InputDatetimeEntity> to call this service for</param>
		///<param name="date">The target date the entity should be set to. eg: "2019-04-20"</param>
		///<param name="time">The target time the entity should be set to. eg: "05:04:20"</param>
		///<param name="datetime">The target date & time the entity should be set to. eg: "2019-04-20 05:04:20"</param>
		///<param name="timestamp">The target date & time the entity should be set to as expressed by a UNIX timestamp.</param>
		public static void SetDatetime(this IEnumerable<InputDatetimeEntity> target, string? @date = null, DateTime? @time = null, string? @datetime = null, long? @timestamp = null)
		{
			target.CallService("set_datetime", new InputDatetimeSetDatetimeParameters{Date = @date, Time = @time, Datetime = @datetime, Timestamp = @timestamp});
		}
	}

	public static class InputNumberEntityExtensionMethods
	{
		///<summary>Decrement the value of an input number entity by its stepping.</summary>
		public static void Decrement(this InputNumberEntity target)
		{
			target.CallService("decrement");
		}

		///<summary>Decrement the value of an input number entity by its stepping.</summary>
		public static void Decrement(this IEnumerable<InputNumberEntity> target)
		{
			target.CallService("decrement");
		}

		///<summary>Increment the value of an input number entity by its stepping.</summary>
		public static void Increment(this InputNumberEntity target)
		{
			target.CallService("increment");
		}

		///<summary>Increment the value of an input number entity by its stepping.</summary>
		public static void Increment(this IEnumerable<InputNumberEntity> target)
		{
			target.CallService("increment");
		}

		///<summary>Set the value of an input number entity.</summary>
		public static void SetValue(this InputNumberEntity target, InputNumberSetValueParameters data)
		{
			target.CallService("set_value", data);
		}

		///<summary>Set the value of an input number entity.</summary>
		public static void SetValue(this IEnumerable<InputNumberEntity> target, InputNumberSetValueParameters data)
		{
			target.CallService("set_value", data);
		}

		///<summary>Set the value of an input number entity.</summary>
		///<param name="target">The InputNumberEntity to call this service for</param>
		///<param name="value">The target value the entity should be set to.</param>
		public static void SetValue(this InputNumberEntity target, double @value)
		{
			target.CallService("set_value", new InputNumberSetValueParameters{Value = @value});
		}

		///<summary>Set the value of an input number entity.</summary>
		///<param name="target">The IEnumerable<InputNumberEntity> to call this service for</param>
		///<param name="value">The target value the entity should be set to.</param>
		public static void SetValue(this IEnumerable<InputNumberEntity> target, double @value)
		{
			target.CallService("set_value", new InputNumberSetValueParameters{Value = @value});
		}
	}

	public static class InputSelectEntityExtensionMethods
	{
		///<summary>Select the first option of an input select entity.</summary>
		public static void SelectFirst(this InputSelectEntity target)
		{
			target.CallService("select_first");
		}

		///<summary>Select the first option of an input select entity.</summary>
		public static void SelectFirst(this IEnumerable<InputSelectEntity> target)
		{
			target.CallService("select_first");
		}

		///<summary>Select the last option of an input select entity.</summary>
		public static void SelectLast(this InputSelectEntity target)
		{
			target.CallService("select_last");
		}

		///<summary>Select the last option of an input select entity.</summary>
		public static void SelectLast(this IEnumerable<InputSelectEntity> target)
		{
			target.CallService("select_last");
		}

		///<summary>Select the next options of an input select entity.</summary>
		public static void SelectNext(this InputSelectEntity target, InputSelectSelectNextParameters data)
		{
			target.CallService("select_next", data);
		}

		///<summary>Select the next options of an input select entity.</summary>
		public static void SelectNext(this IEnumerable<InputSelectEntity> target, InputSelectSelectNextParameters data)
		{
			target.CallService("select_next", data);
		}

		///<summary>Select the next options of an input select entity.</summary>
		///<param name="target">The InputSelectEntity to call this service for</param>
		///<param name="cycle">If the option should cycle from the last to the first.</param>
		public static void SelectNext(this InputSelectEntity target, bool? @cycle = null)
		{
			target.CallService("select_next", new InputSelectSelectNextParameters{Cycle = @cycle});
		}

		///<summary>Select the next options of an input select entity.</summary>
		///<param name="target">The IEnumerable<InputSelectEntity> to call this service for</param>
		///<param name="cycle">If the option should cycle from the last to the first.</param>
		public static void SelectNext(this IEnumerable<InputSelectEntity> target, bool? @cycle = null)
		{
			target.CallService("select_next", new InputSelectSelectNextParameters{Cycle = @cycle});
		}

		///<summary>Select an option of an input select entity.</summary>
		public static void SelectOption(this InputSelectEntity target, InputSelectSelectOptionParameters data)
		{
			target.CallService("select_option", data);
		}

		///<summary>Select an option of an input select entity.</summary>
		public static void SelectOption(this IEnumerable<InputSelectEntity> target, InputSelectSelectOptionParameters data)
		{
			target.CallService("select_option", data);
		}

		///<summary>Select an option of an input select entity.</summary>
		///<param name="target">The InputSelectEntity to call this service for</param>
		///<param name="option">Option to be selected. eg: "Item A"</param>
		public static void SelectOption(this InputSelectEntity target, string @option)
		{
			target.CallService("select_option", new InputSelectSelectOptionParameters{Option = @option});
		}

		///<summary>Select an option of an input select entity.</summary>
		///<param name="target">The IEnumerable<InputSelectEntity> to call this service for</param>
		///<param name="option">Option to be selected. eg: "Item A"</param>
		public static void SelectOption(this IEnumerable<InputSelectEntity> target, string @option)
		{
			target.CallService("select_option", new InputSelectSelectOptionParameters{Option = @option});
		}

		///<summary>Select the previous options of an input select entity.</summary>
		public static void SelectPrevious(this InputSelectEntity target, InputSelectSelectPreviousParameters data)
		{
			target.CallService("select_previous", data);
		}

		///<summary>Select the previous options of an input select entity.</summary>
		public static void SelectPrevious(this IEnumerable<InputSelectEntity> target, InputSelectSelectPreviousParameters data)
		{
			target.CallService("select_previous", data);
		}

		///<summary>Select the previous options of an input select entity.</summary>
		///<param name="target">The InputSelectEntity to call this service for</param>
		///<param name="cycle">If the option should cycle from the first to the last.</param>
		public static void SelectPrevious(this InputSelectEntity target, bool? @cycle = null)
		{
			target.CallService("select_previous", new InputSelectSelectPreviousParameters{Cycle = @cycle});
		}

		///<summary>Select the previous options of an input select entity.</summary>
		///<param name="target">The IEnumerable<InputSelectEntity> to call this service for</param>
		///<param name="cycle">If the option should cycle from the first to the last.</param>
		public static void SelectPrevious(this IEnumerable<InputSelectEntity> target, bool? @cycle = null)
		{
			target.CallService("select_previous", new InputSelectSelectPreviousParameters{Cycle = @cycle});
		}

		///<summary>Set the options of an input select entity.</summary>
		public static void SetOptions(this InputSelectEntity target, InputSelectSetOptionsParameters data)
		{
			target.CallService("set_options", data);
		}

		///<summary>Set the options of an input select entity.</summary>
		public static void SetOptions(this IEnumerable<InputSelectEntity> target, InputSelectSetOptionsParameters data)
		{
			target.CallService("set_options", data);
		}

		///<summary>Set the options of an input select entity.</summary>
		///<param name="target">The InputSelectEntity to call this service for</param>
		///<param name="options">Options for the input select entity. eg: ["Item A", "Item B", "Item C"]</param>
		public static void SetOptions(this InputSelectEntity target, object @options)
		{
			target.CallService("set_options", new InputSelectSetOptionsParameters{Options = @options});
		}

		///<summary>Set the options of an input select entity.</summary>
		///<param name="target">The IEnumerable<InputSelectEntity> to call this service for</param>
		///<param name="options">Options for the input select entity. eg: ["Item A", "Item B", "Item C"]</param>
		public static void SetOptions(this IEnumerable<InputSelectEntity> target, object @options)
		{
			target.CallService("set_options", new InputSelectSetOptionsParameters{Options = @options});
		}
	}

	public static class InputTextEntityExtensionMethods
	{
		///<summary>Set the value of an input text entity.</summary>
		public static void SetValue(this InputTextEntity target, InputTextSetValueParameters data)
		{
			target.CallService("set_value", data);
		}

		///<summary>Set the value of an input text entity.</summary>
		public static void SetValue(this IEnumerable<InputTextEntity> target, InputTextSetValueParameters data)
		{
			target.CallService("set_value", data);
		}

		///<summary>Set the value of an input text entity.</summary>
		///<param name="target">The InputTextEntity to call this service for</param>
		///<param name="value">The target value the entity should be set to. eg: This is an example text</param>
		public static void SetValue(this InputTextEntity target, string @value)
		{
			target.CallService("set_value", new InputTextSetValueParameters{Value = @value});
		}

		///<summary>Set the value of an input text entity.</summary>
		///<param name="target">The IEnumerable<InputTextEntity> to call this service for</param>
		///<param name="value">The target value the entity should be set to. eg: This is an example text</param>
		public static void SetValue(this IEnumerable<InputTextEntity> target, string @value)
		{
			target.CallService("set_value", new InputTextSetValueParameters{Value = @value});
		}
	}

	public static class LightEntityExtensionMethods
	{
		///<summary>Toggles one or more lights, from on to off, or, off to on, based on their current state. </summary>
		public static void Toggle(this LightEntity target, LightToggleParameters data)
		{
			target.CallService("toggle", data);
		}

		///<summary>Toggles one or more lights, from on to off, or, off to on, based on their current state. </summary>
		public static void Toggle(this IEnumerable<LightEntity> target, LightToggleParameters data)
		{
			target.CallService("toggle", data);
		}

		///<summary>Toggles one or more lights, from on to off, or, off to on, based on their current state. </summary>
		///<param name="target">The LightEntity to call this service for</param>
		///<param name="transition">Duration it takes to get to next state.</param>
		///<param name="rgbColor">Color for the light in RGB-format. eg: [255, 100, 100]</param>
		///<param name="colorName">A human readable color name.</param>
		///<param name="hsColor">Color for the light in hue/sat format. Hue is 0-360 and Sat is 0-100. eg: [300, 70]</param>
		///<param name="xyColor">Color for the light in XY-format. eg: [0.52, 0.43]</param>
		///<param name="colorTemp">Color temperature for the light in mireds.</param>
		///<param name="kelvin">Color temperature for the light in Kelvin.</param>
		///<param name="whiteValue">Number indicating level of white.</param>
		///<param name="brightness">Number indicating brightness, where 0 turns the light off, 1 is the minimum brightness and 255 is the maximum brightness supported by the light.</param>
		///<param name="brightnessPct">Number indicating percentage of full brightness, where 0 turns the light off, 1 is the minimum brightness and 100 is the maximum brightness supported by the light.</param>
		///<param name="profile">Name of a light profile to use. eg: relax</param>
		///<param name="flash">If the light should flash.</param>
		///<param name="effect">Light effect.</param>
		public static void Toggle(this LightEntity target, long? @transition = null, object? @rgbColor = null, object? @colorName = null, object? @hsColor = null, object? @xyColor = null, object? @colorTemp = null, long? @kelvin = null, long? @whiteValue = null, long? @brightness = null, long? @brightnessPct = null, string? @profile = null, object? @flash = null, string? @effect = null)
		{
			target.CallService("toggle", new LightToggleParameters{Transition = @transition, RgbColor = @rgbColor, ColorName = @colorName, HsColor = @hsColor, XyColor = @xyColor, ColorTemp = @colorTemp, Kelvin = @kelvin, WhiteValue = @whiteValue, Brightness = @brightness, BrightnessPct = @brightnessPct, Profile = @profile, Flash = @flash, Effect = @effect});
		}

		///<summary>Toggles one or more lights, from on to off, or, off to on, based on their current state. </summary>
		///<param name="target">The IEnumerable<LightEntity> to call this service for</param>
		///<param name="transition">Duration it takes to get to next state.</param>
		///<param name="rgbColor">Color for the light in RGB-format. eg: [255, 100, 100]</param>
		///<param name="colorName">A human readable color name.</param>
		///<param name="hsColor">Color for the light in hue/sat format. Hue is 0-360 and Sat is 0-100. eg: [300, 70]</param>
		///<param name="xyColor">Color for the light in XY-format. eg: [0.52, 0.43]</param>
		///<param name="colorTemp">Color temperature for the light in mireds.</param>
		///<param name="kelvin">Color temperature for the light in Kelvin.</param>
		///<param name="whiteValue">Number indicating level of white.</param>
		///<param name="brightness">Number indicating brightness, where 0 turns the light off, 1 is the minimum brightness and 255 is the maximum brightness supported by the light.</param>
		///<param name="brightnessPct">Number indicating percentage of full brightness, where 0 turns the light off, 1 is the minimum brightness and 100 is the maximum brightness supported by the light.</param>
		///<param name="profile">Name of a light profile to use. eg: relax</param>
		///<param name="flash">If the light should flash.</param>
		///<param name="effect">Light effect.</param>
		public static void Toggle(this IEnumerable<LightEntity> target, long? @transition = null, object? @rgbColor = null, object? @colorName = null, object? @hsColor = null, object? @xyColor = null, object? @colorTemp = null, long? @kelvin = null, long? @whiteValue = null, long? @brightness = null, long? @brightnessPct = null, string? @profile = null, object? @flash = null, string? @effect = null)
		{
			target.CallService("toggle", new LightToggleParameters{Transition = @transition, RgbColor = @rgbColor, ColorName = @colorName, HsColor = @hsColor, XyColor = @xyColor, ColorTemp = @colorTemp, Kelvin = @kelvin, WhiteValue = @whiteValue, Brightness = @brightness, BrightnessPct = @brightnessPct, Profile = @profile, Flash = @flash, Effect = @effect});
		}

		///<summary>Turns off one or more lights.</summary>
		public static void TurnOff(this LightEntity target, LightTurnOffParameters data)
		{
			target.CallService("turn_off", data);
		}

		///<summary>Turns off one or more lights.</summary>
		public static void TurnOff(this IEnumerable<LightEntity> target, LightTurnOffParameters data)
		{
			target.CallService("turn_off", data);
		}

		///<summary>Turns off one or more lights.</summary>
		///<param name="target">The LightEntity to call this service for</param>
		///<param name="transition">Duration it takes to get to next state.</param>
		///<param name="flash">If the light should flash.</param>
		public static void TurnOff(this LightEntity target, long? @transition = null, object? @flash = null)
		{
			target.CallService("turn_off", new LightTurnOffParameters{Transition = @transition, Flash = @flash});
		}

		///<summary>Turns off one or more lights.</summary>
		///<param name="target">The IEnumerable<LightEntity> to call this service for</param>
		///<param name="transition">Duration it takes to get to next state.</param>
		///<param name="flash">If the light should flash.</param>
		public static void TurnOff(this IEnumerable<LightEntity> target, long? @transition = null, object? @flash = null)
		{
			target.CallService("turn_off", new LightTurnOffParameters{Transition = @transition, Flash = @flash});
		}

		///<summary>Turn on one or more lights and adjust properties of the light, even when they are turned on already. </summary>
		public static void TurnOn(this LightEntity target, LightTurnOnParameters data)
		{
			target.CallService("turn_on", data);
		}

		///<summary>Turn on one or more lights and adjust properties of the light, even when they are turned on already. </summary>
		public static void TurnOn(this IEnumerable<LightEntity> target, LightTurnOnParameters data)
		{
			target.CallService("turn_on", data);
		}

		///<summary>Turn on one or more lights and adjust properties of the light, even when they are turned on already. </summary>
		///<param name="target">The LightEntity to call this service for</param>
		///<param name="transition">Duration it takes to get to next state.</param>
		///<param name="rgbColor">The color for the light (based on RGB - red, green, blue).</param>
		///<param name="rgbwColor">A list containing four integers between 0 and 255 representing the RGBW (red, green, blue, white) color for the light. eg: [255, 100, 100, 50]</param>
		///<param name="rgbwwColor">A list containing five integers between 0 and 255 representing the RGBWW (red, green, blue, cold white, warm white) color for the light. eg: [255, 100, 100, 50, 70]</param>
		///<param name="colorName">A human readable color name.</param>
		///<param name="hsColor">Color for the light in hue/sat format. Hue is 0-360 and Sat is 0-100. eg: [300, 70]</param>
		///<param name="xyColor">Color for the light in XY-format. eg: [0.52, 0.43]</param>
		///<param name="colorTemp">Color temperature for the light in mireds.</param>
		///<param name="kelvin">Color temperature for the light in Kelvin.</param>
		///<param name="brightness">Number indicating brightness, where 0 turns the light off, 1 is the minimum brightness and 255 is the maximum brightness supported by the light.</param>
		///<param name="brightnessPct">Number indicating percentage of full brightness, where 0 turns the light off, 1 is the minimum brightness and 100 is the maximum brightness supported by the light.</param>
		///<param name="brightnessStep">Change brightness by an amount.</param>
		///<param name="brightnessStepPct">Change brightness by a percentage.</param>
		///<param name="white">Set the light to white mode and change its brightness, where 0 turns the light off, 1 is the minimum brightness and 255 is the maximum brightness supported by the light.</param>
		///<param name="profile">Name of a light profile to use. eg: relax</param>
		///<param name="flash">If the light should flash.</param>
		///<param name="effect">Light effect.</param>
		public static void TurnOn(this LightEntity target, long? @transition = null, object? @rgbColor = null, object? @rgbwColor = null, object? @rgbwwColor = null, object? @colorName = null, object? @hsColor = null, object? @xyColor = null, object? @colorTemp = null, long? @kelvin = null, long? @brightness = null, long? @brightnessPct = null, long? @brightnessStep = null, long? @brightnessStepPct = null, long? @white = null, string? @profile = null, object? @flash = null, string? @effect = null)
		{
			target.CallService("turn_on", new LightTurnOnParameters{Transition = @transition, RgbColor = @rgbColor, RgbwColor = @rgbwColor, RgbwwColor = @rgbwwColor, ColorName = @colorName, HsColor = @hsColor, XyColor = @xyColor, ColorTemp = @colorTemp, Kelvin = @kelvin, Brightness = @brightness, BrightnessPct = @brightnessPct, BrightnessStep = @brightnessStep, BrightnessStepPct = @brightnessStepPct, White = @white, Profile = @profile, Flash = @flash, Effect = @effect});
		}

		///<summary>Turn on one or more lights and adjust properties of the light, even when they are turned on already. </summary>
		///<param name="target">The IEnumerable<LightEntity> to call this service for</param>
		///<param name="transition">Duration it takes to get to next state.</param>
		///<param name="rgbColor">The color for the light (based on RGB - red, green, blue).</param>
		///<param name="rgbwColor">A list containing four integers between 0 and 255 representing the RGBW (red, green, blue, white) color for the light. eg: [255, 100, 100, 50]</param>
		///<param name="rgbwwColor">A list containing five integers between 0 and 255 representing the RGBWW (red, green, blue, cold white, warm white) color for the light. eg: [255, 100, 100, 50, 70]</param>
		///<param name="colorName">A human readable color name.</param>
		///<param name="hsColor">Color for the light in hue/sat format. Hue is 0-360 and Sat is 0-100. eg: [300, 70]</param>
		///<param name="xyColor">Color for the light in XY-format. eg: [0.52, 0.43]</param>
		///<param name="colorTemp">Color temperature for the light in mireds.</param>
		///<param name="kelvin">Color temperature for the light in Kelvin.</param>
		///<param name="brightness">Number indicating brightness, where 0 turns the light off, 1 is the minimum brightness and 255 is the maximum brightness supported by the light.</param>
		///<param name="brightnessPct">Number indicating percentage of full brightness, where 0 turns the light off, 1 is the minimum brightness and 100 is the maximum brightness supported by the light.</param>
		///<param name="brightnessStep">Change brightness by an amount.</param>
		///<param name="brightnessStepPct">Change brightness by a percentage.</param>
		///<param name="white">Set the light to white mode and change its brightness, where 0 turns the light off, 1 is the minimum brightness and 255 is the maximum brightness supported by the light.</param>
		///<param name="profile">Name of a light profile to use. eg: relax</param>
		///<param name="flash">If the light should flash.</param>
		///<param name="effect">Light effect.</param>
		public static void TurnOn(this IEnumerable<LightEntity> target, long? @transition = null, object? @rgbColor = null, object? @rgbwColor = null, object? @rgbwwColor = null, object? @colorName = null, object? @hsColor = null, object? @xyColor = null, object? @colorTemp = null, long? @kelvin = null, long? @brightness = null, long? @brightnessPct = null, long? @brightnessStep = null, long? @brightnessStepPct = null, long? @white = null, string? @profile = null, object? @flash = null, string? @effect = null)
		{
			target.CallService("turn_on", new LightTurnOnParameters{Transition = @transition, RgbColor = @rgbColor, RgbwColor = @rgbwColor, RgbwwColor = @rgbwwColor, ColorName = @colorName, HsColor = @hsColor, XyColor = @xyColor, ColorTemp = @colorTemp, Kelvin = @kelvin, Brightness = @brightness, BrightnessPct = @brightnessPct, BrightnessStep = @brightnessStep, BrightnessStepPct = @brightnessStepPct, White = @white, Profile = @profile, Flash = @flash, Effect = @effect});
		}
	}

	public static class MediaPlayerEntityExtensionMethods
	{
		///<summary>Send the media player the command to clear players playlist.</summary>
		public static void ClearPlaylist(this MediaPlayerEntity target)
		{
			target.CallService("clear_playlist");
		}

		///<summary>Send the media player the command to clear players playlist.</summary>
		public static void ClearPlaylist(this IEnumerable<MediaPlayerEntity> target)
		{
			target.CallService("clear_playlist");
		}

		///<summary>Group players together. Only works on platforms with support for player groups.</summary>
		public static void Join(this MediaPlayerEntity target, MediaPlayerJoinParameters data)
		{
			target.CallService("join", data);
		}

		///<summary>Group players together. Only works on platforms with support for player groups.</summary>
		public static void Join(this IEnumerable<MediaPlayerEntity> target, MediaPlayerJoinParameters data)
		{
			target.CallService("join", data);
		}

		///<summary>Group players together. Only works on platforms with support for player groups.</summary>
		///<param name="target">The MediaPlayerEntity to call this service for</param>
		///<param name="groupMembers">The players which will be synced with the target player. eg: ["media_player.multiroom_player2","media_player.multiroom_player3"]</param>
		public static void Join(this MediaPlayerEntity target, object? @groupMembers = null)
		{
			target.CallService("join", new MediaPlayerJoinParameters{GroupMembers = @groupMembers});
		}

		///<summary>Group players together. Only works on platforms with support for player groups.</summary>
		///<param name="target">The IEnumerable<MediaPlayerEntity> to call this service for</param>
		///<param name="groupMembers">The players which will be synced with the target player. eg: ["media_player.multiroom_player2","media_player.multiroom_player3"]</param>
		public static void Join(this IEnumerable<MediaPlayerEntity> target, object? @groupMembers = null)
		{
			target.CallService("join", new MediaPlayerJoinParameters{GroupMembers = @groupMembers});
		}

		///<summary>Send the media player the command for next track.</summary>
		public static void MediaNextTrack(this MediaPlayerEntity target)
		{
			target.CallService("media_next_track");
		}

		///<summary>Send the media player the command for next track.</summary>
		public static void MediaNextTrack(this IEnumerable<MediaPlayerEntity> target)
		{
			target.CallService("media_next_track");
		}

		///<summary>Send the media player the command for pause.</summary>
		public static void MediaPause(this MediaPlayerEntity target)
		{
			target.CallService("media_pause");
		}

		///<summary>Send the media player the command for pause.</summary>
		public static void MediaPause(this IEnumerable<MediaPlayerEntity> target)
		{
			target.CallService("media_pause");
		}

		///<summary>Send the media player the command for play.</summary>
		public static void MediaPlay(this MediaPlayerEntity target)
		{
			target.CallService("media_play");
		}

		///<summary>Send the media player the command for play.</summary>
		public static void MediaPlay(this IEnumerable<MediaPlayerEntity> target)
		{
			target.CallService("media_play");
		}

		///<summary>Toggle media player play/pause state.</summary>
		public static void MediaPlayPause(this MediaPlayerEntity target)
		{
			target.CallService("media_play_pause");
		}

		///<summary>Toggle media player play/pause state.</summary>
		public static void MediaPlayPause(this IEnumerable<MediaPlayerEntity> target)
		{
			target.CallService("media_play_pause");
		}

		///<summary>Send the media player the command for previous track.</summary>
		public static void MediaPreviousTrack(this MediaPlayerEntity target)
		{
			target.CallService("media_previous_track");
		}

		///<summary>Send the media player the command for previous track.</summary>
		public static void MediaPreviousTrack(this IEnumerable<MediaPlayerEntity> target)
		{
			target.CallService("media_previous_track");
		}

		///<summary>Send the media player the command to seek in current playing media.</summary>
		public static void MediaSeek(this MediaPlayerEntity target, MediaPlayerMediaSeekParameters data)
		{
			target.CallService("media_seek", data);
		}

		///<summary>Send the media player the command to seek in current playing media.</summary>
		public static void MediaSeek(this IEnumerable<MediaPlayerEntity> target, MediaPlayerMediaSeekParameters data)
		{
			target.CallService("media_seek", data);
		}

		///<summary>Send the media player the command to seek in current playing media.</summary>
		///<param name="target">The MediaPlayerEntity to call this service for</param>
		///<param name="seekPosition">Position to seek to. The format is platform dependent.</param>
		public static void MediaSeek(this MediaPlayerEntity target, double @seekPosition)
		{
			target.CallService("media_seek", new MediaPlayerMediaSeekParameters{SeekPosition = @seekPosition});
		}

		///<summary>Send the media player the command to seek in current playing media.</summary>
		///<param name="target">The IEnumerable<MediaPlayerEntity> to call this service for</param>
		///<param name="seekPosition">Position to seek to. The format is platform dependent.</param>
		public static void MediaSeek(this IEnumerable<MediaPlayerEntity> target, double @seekPosition)
		{
			target.CallService("media_seek", new MediaPlayerMediaSeekParameters{SeekPosition = @seekPosition});
		}

		///<summary>Send the media player the stop command.</summary>
		public static void MediaStop(this MediaPlayerEntity target)
		{
			target.CallService("media_stop");
		}

		///<summary>Send the media player the stop command.</summary>
		public static void MediaStop(this IEnumerable<MediaPlayerEntity> target)
		{
			target.CallService("media_stop");
		}

		///<summary>Send the media player the command for playing media.</summary>
		public static void PlayMedia(this MediaPlayerEntity target, MediaPlayerPlayMediaParameters data)
		{
			target.CallService("play_media", data);
		}

		///<summary>Send the media player the command for playing media.</summary>
		public static void PlayMedia(this IEnumerable<MediaPlayerEntity> target, MediaPlayerPlayMediaParameters data)
		{
			target.CallService("play_media", data);
		}

		///<summary>Send the media player the command for playing media.</summary>
		///<param name="target">The MediaPlayerEntity to call this service for</param>
		///<param name="mediaContentId">The ID of the content to play. Platform dependent. eg: https://home-assistant.io/images/cast/splash.png</param>
		///<param name="mediaContentType">The type of the content to play. Like image, music, tvshow, video, episode, channel or playlist. eg: music</param>
		///<param name="enqueue">If the content should be played now or be added to the queue.</param>
		///<param name="announce">If the media should be played as an announcement. eg: true</param>
		public static void PlayMedia(this MediaPlayerEntity target, string @mediaContentId, string @mediaContentType, object? @enqueue = null, bool? @announce = null)
		{
			target.CallService("play_media", new MediaPlayerPlayMediaParameters{MediaContentId = @mediaContentId, MediaContentType = @mediaContentType, Enqueue = @enqueue, Announce = @announce});
		}

		///<summary>Send the media player the command for playing media.</summary>
		///<param name="target">The IEnumerable<MediaPlayerEntity> to call this service for</param>
		///<param name="mediaContentId">The ID of the content to play. Platform dependent. eg: https://home-assistant.io/images/cast/splash.png</param>
		///<param name="mediaContentType">The type of the content to play. Like image, music, tvshow, video, episode, channel or playlist. eg: music</param>
		///<param name="enqueue">If the content should be played now or be added to the queue.</param>
		///<param name="announce">If the media should be played as an announcement. eg: true</param>
		public static void PlayMedia(this IEnumerable<MediaPlayerEntity> target, string @mediaContentId, string @mediaContentType, object? @enqueue = null, bool? @announce = null)
		{
			target.CallService("play_media", new MediaPlayerPlayMediaParameters{MediaContentId = @mediaContentId, MediaContentType = @mediaContentType, Enqueue = @enqueue, Announce = @announce});
		}

		///<summary>Set repeat mode</summary>
		public static void RepeatSet(this MediaPlayerEntity target, MediaPlayerRepeatSetParameters data)
		{
			target.CallService("repeat_set", data);
		}

		///<summary>Set repeat mode</summary>
		public static void RepeatSet(this IEnumerable<MediaPlayerEntity> target, MediaPlayerRepeatSetParameters data)
		{
			target.CallService("repeat_set", data);
		}

		///<summary>Set repeat mode</summary>
		///<param name="target">The MediaPlayerEntity to call this service for</param>
		///<param name="repeat">Repeat mode to set.</param>
		public static void RepeatSet(this MediaPlayerEntity target, object @repeat)
		{
			target.CallService("repeat_set", new MediaPlayerRepeatSetParameters{Repeat = @repeat});
		}

		///<summary>Set repeat mode</summary>
		///<param name="target">The IEnumerable<MediaPlayerEntity> to call this service for</param>
		///<param name="repeat">Repeat mode to set.</param>
		public static void RepeatSet(this IEnumerable<MediaPlayerEntity> target, object @repeat)
		{
			target.CallService("repeat_set", new MediaPlayerRepeatSetParameters{Repeat = @repeat});
		}

		///<summary>Send the media player the command to change sound mode.</summary>
		public static void SelectSoundMode(this MediaPlayerEntity target, MediaPlayerSelectSoundModeParameters data)
		{
			target.CallService("select_sound_mode", data);
		}

		///<summary>Send the media player the command to change sound mode.</summary>
		public static void SelectSoundMode(this IEnumerable<MediaPlayerEntity> target, MediaPlayerSelectSoundModeParameters data)
		{
			target.CallService("select_sound_mode", data);
		}

		///<summary>Send the media player the command to change sound mode.</summary>
		///<param name="target">The MediaPlayerEntity to call this service for</param>
		///<param name="soundMode">Name of the sound mode to switch to. eg: Music</param>
		public static void SelectSoundMode(this MediaPlayerEntity target, string? @soundMode = null)
		{
			target.CallService("select_sound_mode", new MediaPlayerSelectSoundModeParameters{SoundMode = @soundMode});
		}

		///<summary>Send the media player the command to change sound mode.</summary>
		///<param name="target">The IEnumerable<MediaPlayerEntity> to call this service for</param>
		///<param name="soundMode">Name of the sound mode to switch to. eg: Music</param>
		public static void SelectSoundMode(this IEnumerable<MediaPlayerEntity> target, string? @soundMode = null)
		{
			target.CallService("select_sound_mode", new MediaPlayerSelectSoundModeParameters{SoundMode = @soundMode});
		}

		///<summary>Send the media player the command to change input source.</summary>
		public static void SelectSource(this MediaPlayerEntity target, MediaPlayerSelectSourceParameters data)
		{
			target.CallService("select_source", data);
		}

		///<summary>Send the media player the command to change input source.</summary>
		public static void SelectSource(this IEnumerable<MediaPlayerEntity> target, MediaPlayerSelectSourceParameters data)
		{
			target.CallService("select_source", data);
		}

		///<summary>Send the media player the command to change input source.</summary>
		///<param name="target">The MediaPlayerEntity to call this service for</param>
		///<param name="source">Name of the source to switch to. Platform dependent. eg: video1</param>
		public static void SelectSource(this MediaPlayerEntity target, string @source)
		{
			target.CallService("select_source", new MediaPlayerSelectSourceParameters{Source = @source});
		}

		///<summary>Send the media player the command to change input source.</summary>
		///<param name="target">The IEnumerable<MediaPlayerEntity> to call this service for</param>
		///<param name="source">Name of the source to switch to. Platform dependent. eg: video1</param>
		public static void SelectSource(this IEnumerable<MediaPlayerEntity> target, string @source)
		{
			target.CallService("select_source", new MediaPlayerSelectSourceParameters{Source = @source});
		}

		///<summary>Set shuffling state.</summary>
		public static void ShuffleSet(this MediaPlayerEntity target, MediaPlayerShuffleSetParameters data)
		{
			target.CallService("shuffle_set", data);
		}

		///<summary>Set shuffling state.</summary>
		public static void ShuffleSet(this IEnumerable<MediaPlayerEntity> target, MediaPlayerShuffleSetParameters data)
		{
			target.CallService("shuffle_set", data);
		}

		///<summary>Set shuffling state.</summary>
		///<param name="target">The MediaPlayerEntity to call this service for</param>
		///<param name="shuffle">True/false for enabling/disabling shuffle.</param>
		public static void ShuffleSet(this MediaPlayerEntity target, bool @shuffle)
		{
			target.CallService("shuffle_set", new MediaPlayerShuffleSetParameters{Shuffle = @shuffle});
		}

		///<summary>Set shuffling state.</summary>
		///<param name="target">The IEnumerable<MediaPlayerEntity> to call this service for</param>
		///<param name="shuffle">True/false for enabling/disabling shuffle.</param>
		public static void ShuffleSet(this IEnumerable<MediaPlayerEntity> target, bool @shuffle)
		{
			target.CallService("shuffle_set", new MediaPlayerShuffleSetParameters{Shuffle = @shuffle});
		}

		///<summary>Toggles a media player power state.</summary>
		public static void Toggle(this MediaPlayerEntity target)
		{
			target.CallService("toggle");
		}

		///<summary>Toggles a media player power state.</summary>
		public static void Toggle(this IEnumerable<MediaPlayerEntity> target)
		{
			target.CallService("toggle");
		}

		///<summary>Turn a media player power off.</summary>
		public static void TurnOff(this MediaPlayerEntity target)
		{
			target.CallService("turn_off");
		}

		///<summary>Turn a media player power off.</summary>
		public static void TurnOff(this IEnumerable<MediaPlayerEntity> target)
		{
			target.CallService("turn_off");
		}

		///<summary>Turn a media player power on.</summary>
		public static void TurnOn(this MediaPlayerEntity target)
		{
			target.CallService("turn_on");
		}

		///<summary>Turn a media player power on.</summary>
		public static void TurnOn(this IEnumerable<MediaPlayerEntity> target)
		{
			target.CallService("turn_on");
		}

		///<summary>Unjoin the player from a group. Only works on platforms with support for player groups.</summary>
		public static void Unjoin(this MediaPlayerEntity target)
		{
			target.CallService("unjoin");
		}

		///<summary>Unjoin the player from a group. Only works on platforms with support for player groups.</summary>
		public static void Unjoin(this IEnumerable<MediaPlayerEntity> target)
		{
			target.CallService("unjoin");
		}

		///<summary>Turn a media player volume down.</summary>
		public static void VolumeDown(this MediaPlayerEntity target)
		{
			target.CallService("volume_down");
		}

		///<summary>Turn a media player volume down.</summary>
		public static void VolumeDown(this IEnumerable<MediaPlayerEntity> target)
		{
			target.CallService("volume_down");
		}

		///<summary>Mute a media player's volume.</summary>
		public static void VolumeMute(this MediaPlayerEntity target, MediaPlayerVolumeMuteParameters data)
		{
			target.CallService("volume_mute", data);
		}

		///<summary>Mute a media player's volume.</summary>
		public static void VolumeMute(this IEnumerable<MediaPlayerEntity> target, MediaPlayerVolumeMuteParameters data)
		{
			target.CallService("volume_mute", data);
		}

		///<summary>Mute a media player's volume.</summary>
		///<param name="target">The MediaPlayerEntity to call this service for</param>
		///<param name="isVolumeMuted">True/false for mute/unmute.</param>
		public static void VolumeMute(this MediaPlayerEntity target, bool @isVolumeMuted)
		{
			target.CallService("volume_mute", new MediaPlayerVolumeMuteParameters{IsVolumeMuted = @isVolumeMuted});
		}

		///<summary>Mute a media player's volume.</summary>
		///<param name="target">The IEnumerable<MediaPlayerEntity> to call this service for</param>
		///<param name="isVolumeMuted">True/false for mute/unmute.</param>
		public static void VolumeMute(this IEnumerable<MediaPlayerEntity> target, bool @isVolumeMuted)
		{
			target.CallService("volume_mute", new MediaPlayerVolumeMuteParameters{IsVolumeMuted = @isVolumeMuted});
		}

		///<summary>Set a media player's volume level.</summary>
		public static void VolumeSet(this MediaPlayerEntity target, MediaPlayerVolumeSetParameters data)
		{
			target.CallService("volume_set", data);
		}

		///<summary>Set a media player's volume level.</summary>
		public static void VolumeSet(this IEnumerable<MediaPlayerEntity> target, MediaPlayerVolumeSetParameters data)
		{
			target.CallService("volume_set", data);
		}

		///<summary>Set a media player's volume level.</summary>
		///<param name="target">The MediaPlayerEntity to call this service for</param>
		///<param name="volumeLevel">Volume level to set as float.</param>
		public static void VolumeSet(this MediaPlayerEntity target, double @volumeLevel)
		{
			target.CallService("volume_set", new MediaPlayerVolumeSetParameters{VolumeLevel = @volumeLevel});
		}

		///<summary>Set a media player's volume level.</summary>
		///<param name="target">The IEnumerable<MediaPlayerEntity> to call this service for</param>
		///<param name="volumeLevel">Volume level to set as float.</param>
		public static void VolumeSet(this IEnumerable<MediaPlayerEntity> target, double @volumeLevel)
		{
			target.CallService("volume_set", new MediaPlayerVolumeSetParameters{VolumeLevel = @volumeLevel});
		}

		///<summary>Turn a media player volume up.</summary>
		public static void VolumeUp(this MediaPlayerEntity target)
		{
			target.CallService("volume_up");
		}

		///<summary>Turn a media player volume up.</summary>
		public static void VolumeUp(this IEnumerable<MediaPlayerEntity> target)
		{
			target.CallService("volume_up");
		}
	}

	public static class NumberEntityExtensionMethods
	{
		///<summary>Set the value of a Number entity.</summary>
		public static void SetValue(this NumberEntity target, NumberSetValueParameters data)
		{
			target.CallService("set_value", data);
		}

		///<summary>Set the value of a Number entity.</summary>
		public static void SetValue(this IEnumerable<NumberEntity> target, NumberSetValueParameters data)
		{
			target.CallService("set_value", data);
		}

		///<summary>Set the value of a Number entity.</summary>
		///<param name="target">The NumberEntity to call this service for</param>
		///<param name="value">The target value the entity should be set to. eg: 42</param>
		public static void SetValue(this NumberEntity target, string? @value = null)
		{
			target.CallService("set_value", new NumberSetValueParameters{Value = @value});
		}

		///<summary>Set the value of a Number entity.</summary>
		///<param name="target">The IEnumerable<NumberEntity> to call this service for</param>
		///<param name="value">The target value the entity should be set to. eg: 42</param>
		public static void SetValue(this IEnumerable<NumberEntity> target, string? @value = null)
		{
			target.CallService("set_value", new NumberSetValueParameters{Value = @value});
		}
	}

	public static class RemoteEntityExtensionMethods
	{
		///<summary>Deletes a command or a list of commands from the database.</summary>
		public static void DeleteCommand(this RemoteEntity target, RemoteDeleteCommandParameters data)
		{
			target.CallService("delete_command", data);
		}

		///<summary>Deletes a command or a list of commands from the database.</summary>
		public static void DeleteCommand(this IEnumerable<RemoteEntity> target, RemoteDeleteCommandParameters data)
		{
			target.CallService("delete_command", data);
		}

		///<summary>Deletes a command or a list of commands from the database.</summary>
		///<param name="target">The RemoteEntity to call this service for</param>
		///<param name="device">Name of the device from which commands will be deleted. eg: television</param>
		///<param name="command">A single command or a list of commands to delete. eg: Mute</param>
		public static void DeleteCommand(this RemoteEntity target, object @command, string? @device = null)
		{
			target.CallService("delete_command", new RemoteDeleteCommandParameters{Device = @device, Command = @command});
		}

		///<summary>Deletes a command or a list of commands from the database.</summary>
		///<param name="target">The IEnumerable<RemoteEntity> to call this service for</param>
		///<param name="device">Name of the device from which commands will be deleted. eg: television</param>
		///<param name="command">A single command or a list of commands to delete. eg: Mute</param>
		public static void DeleteCommand(this IEnumerable<RemoteEntity> target, object @command, string? @device = null)
		{
			target.CallService("delete_command", new RemoteDeleteCommandParameters{Device = @device, Command = @command});
		}

		///<summary>Learns a command or a list of commands from a device.</summary>
		public static void LearnCommand(this RemoteEntity target, RemoteLearnCommandParameters data)
		{
			target.CallService("learn_command", data);
		}

		///<summary>Learns a command or a list of commands from a device.</summary>
		public static void LearnCommand(this IEnumerable<RemoteEntity> target, RemoteLearnCommandParameters data)
		{
			target.CallService("learn_command", data);
		}

		///<summary>Learns a command or a list of commands from a device.</summary>
		///<param name="target">The RemoteEntity to call this service for</param>
		///<param name="device">Device ID to learn command from. eg: television</param>
		///<param name="command">A single command or a list of commands to learn. eg: Turn on</param>
		///<param name="commandType">The type of command to be learned.</param>
		///<param name="alternative">If code must be stored as alternative (useful for discrete remotes).</param>
		///<param name="timeout">Timeout for the command to be learned.</param>
		public static void LearnCommand(this RemoteEntity target, string? @device = null, object? @command = null, object? @commandType = null, bool? @alternative = null, long? @timeout = null)
		{
			target.CallService("learn_command", new RemoteLearnCommandParameters{Device = @device, Command = @command, CommandType = @commandType, Alternative = @alternative, Timeout = @timeout});
		}

		///<summary>Learns a command or a list of commands from a device.</summary>
		///<param name="target">The IEnumerable<RemoteEntity> to call this service for</param>
		///<param name="device">Device ID to learn command from. eg: television</param>
		///<param name="command">A single command or a list of commands to learn. eg: Turn on</param>
		///<param name="commandType">The type of command to be learned.</param>
		///<param name="alternative">If code must be stored as alternative (useful for discrete remotes).</param>
		///<param name="timeout">Timeout for the command to be learned.</param>
		public static void LearnCommand(this IEnumerable<RemoteEntity> target, string? @device = null, object? @command = null, object? @commandType = null, bool? @alternative = null, long? @timeout = null)
		{
			target.CallService("learn_command", new RemoteLearnCommandParameters{Device = @device, Command = @command, CommandType = @commandType, Alternative = @alternative, Timeout = @timeout});
		}

		///<summary>Sends a command or a list of commands to a device.</summary>
		public static void SendCommand(this RemoteEntity target, RemoteSendCommandParameters data)
		{
			target.CallService("send_command", data);
		}

		///<summary>Sends a command or a list of commands to a device.</summary>
		public static void SendCommand(this IEnumerable<RemoteEntity> target, RemoteSendCommandParameters data)
		{
			target.CallService("send_command", data);
		}

		///<summary>Sends a command or a list of commands to a device.</summary>
		///<param name="target">The RemoteEntity to call this service for</param>
		///<param name="device">Device ID to send command to. eg: 32756745</param>
		///<param name="command">A single command or a list of commands to send. eg: Play</param>
		///<param name="numRepeats">The number of times you want to repeat the command(s).</param>
		///<param name="delaySecs">The time you want to wait in between repeated commands.</param>
		///<param name="holdSecs">The time you want to have it held before the release is send.</param>
		public static void SendCommand(this RemoteEntity target, object @command, string? @device = null, long? @numRepeats = null, double? @delaySecs = null, double? @holdSecs = null)
		{
			target.CallService("send_command", new RemoteSendCommandParameters{Device = @device, Command = @command, NumRepeats = @numRepeats, DelaySecs = @delaySecs, HoldSecs = @holdSecs});
		}

		///<summary>Sends a command or a list of commands to a device.</summary>
		///<param name="target">The IEnumerable<RemoteEntity> to call this service for</param>
		///<param name="device">Device ID to send command to. eg: 32756745</param>
		///<param name="command">A single command or a list of commands to send. eg: Play</param>
		///<param name="numRepeats">The number of times you want to repeat the command(s).</param>
		///<param name="delaySecs">The time you want to wait in between repeated commands.</param>
		///<param name="holdSecs">The time you want to have it held before the release is send.</param>
		public static void SendCommand(this IEnumerable<RemoteEntity> target, object @command, string? @device = null, long? @numRepeats = null, double? @delaySecs = null, double? @holdSecs = null)
		{
			target.CallService("send_command", new RemoteSendCommandParameters{Device = @device, Command = @command, NumRepeats = @numRepeats, DelaySecs = @delaySecs, HoldSecs = @holdSecs});
		}

		///<summary>Toggles a device.</summary>
		public static void Toggle(this RemoteEntity target)
		{
			target.CallService("toggle");
		}

		///<summary>Toggles a device.</summary>
		public static void Toggle(this IEnumerable<RemoteEntity> target)
		{
			target.CallService("toggle");
		}

		///<summary>Sends the Power Off Command.</summary>
		public static void TurnOff(this RemoteEntity target)
		{
			target.CallService("turn_off");
		}

		///<summary>Sends the Power Off Command.</summary>
		public static void TurnOff(this IEnumerable<RemoteEntity> target)
		{
			target.CallService("turn_off");
		}

		///<summary>Sends the Power On Command.</summary>
		public static void TurnOn(this RemoteEntity target, RemoteTurnOnParameters data)
		{
			target.CallService("turn_on", data);
		}

		///<summary>Sends the Power On Command.</summary>
		public static void TurnOn(this IEnumerable<RemoteEntity> target, RemoteTurnOnParameters data)
		{
			target.CallService("turn_on", data);
		}

		///<summary>Sends the Power On Command.</summary>
		///<param name="target">The RemoteEntity to call this service for</param>
		///<param name="activity">Activity ID or Activity Name to start. eg: BedroomTV</param>
		public static void TurnOn(this RemoteEntity target, string? @activity = null)
		{
			target.CallService("turn_on", new RemoteTurnOnParameters{Activity = @activity});
		}

		///<summary>Sends the Power On Command.</summary>
		///<param name="target">The IEnumerable<RemoteEntity> to call this service for</param>
		///<param name="activity">Activity ID or Activity Name to start. eg: BedroomTV</param>
		public static void TurnOn(this IEnumerable<RemoteEntity> target, string? @activity = null)
		{
			target.CallService("turn_on", new RemoteTurnOnParameters{Activity = @activity});
		}
	}

	public static class SelectEntityExtensionMethods
	{
		///<summary>Select an option of an select entity.</summary>
		public static void SelectOption(this SelectEntity target, SelectSelectOptionParameters data)
		{
			target.CallService("select_option", data);
		}

		///<summary>Select an option of an select entity.</summary>
		public static void SelectOption(this IEnumerable<SelectEntity> target, SelectSelectOptionParameters data)
		{
			target.CallService("select_option", data);
		}

		///<summary>Select an option of an select entity.</summary>
		///<param name="target">The SelectEntity to call this service for</param>
		///<param name="option">Option to be selected. eg: "Item A"</param>
		public static void SelectOption(this SelectEntity target, string @option)
		{
			target.CallService("select_option", new SelectSelectOptionParameters{Option = @option});
		}

		///<summary>Select an option of an select entity.</summary>
		///<param name="target">The IEnumerable<SelectEntity> to call this service for</param>
		///<param name="option">Option to be selected. eg: "Item A"</param>
		public static void SelectOption(this IEnumerable<SelectEntity> target, string @option)
		{
			target.CallService("select_option", new SelectSelectOptionParameters{Option = @option});
		}
	}

	public static class SmartthinqSensorsEntityExtensionMethods
	{
		///<summary>Send to ThinQ device the remote start command.</summary>
		public static void RemoteStart(this SensorEntity target)
		{
			target.CallService("remote_start");
		}

		///<summary>Send to ThinQ device the remote start command.</summary>
		public static void RemoteStart(this IEnumerable<SensorEntity> target)
		{
			target.CallService("remote_start");
		}

		///<summary>Set fan operation for dehumidifier device.</summary>
		public static void SetFanMode(this HumidifierEntity target, SmartthinqSensorsSetFanModeParameters data)
		{
			target.CallService("set_fan_mode", data);
		}

		///<summary>Set fan operation for dehumidifier device.</summary>
		public static void SetFanMode(this IEnumerable<HumidifierEntity> target, SmartthinqSensorsSetFanModeParameters data)
		{
			target.CallService("set_fan_mode", data);
		}

		///<summary>Set fan operation for dehumidifier device.</summary>
		///<param name="target">The HumidifierEntity to call this service for</param>
		///<param name="fanMode">New value of fan mode. eg: low</param>
		public static void SetFanMode(this HumidifierEntity target, string @fanMode)
		{
			target.CallService("set_fan_mode", new SmartthinqSensorsSetFanModeParameters{FanMode = @fanMode});
		}

		///<summary>Set fan operation for dehumidifier device.</summary>
		///<param name="target">The IEnumerable<HumidifierEntity> to call this service for</param>
		///<param name="fanMode">New value of fan mode. eg: low</param>
		public static void SetFanMode(this IEnumerable<HumidifierEntity> target, string @fanMode)
		{
			target.CallService("set_fan_mode", new SmartthinqSensorsSetFanModeParameters{FanMode = @fanMode});
		}

		///<summary>Send to ThinQ device the wakeup command.</summary>
		public static void WakeUp(this SensorEntity target)
		{
			target.CallService("wake_up");
		}

		///<summary>Send to ThinQ device the wakeup command.</summary>
		public static void WakeUp(this IEnumerable<SensorEntity> target)
		{
			target.CallService("wake_up");
		}
	}

	public static class SwitchEntityExtensionMethods
	{
		///<summary>Toggles a switch state</summary>
		public static void Toggle(this SwitchEntity target)
		{
			target.CallService("toggle");
		}

		///<summary>Toggles a switch state</summary>
		public static void Toggle(this IEnumerable<SwitchEntity> target)
		{
			target.CallService("toggle");
		}

		///<summary>Turn a switch off</summary>
		public static void TurnOff(this SwitchEntity target)
		{
			target.CallService("turn_off");
		}

		///<summary>Turn a switch off</summary>
		public static void TurnOff(this IEnumerable<SwitchEntity> target)
		{
			target.CallService("turn_off");
		}

		///<summary>Turn a switch on</summary>
		public static void TurnOn(this SwitchEntity target)
		{
			target.CallService("turn_on");
		}

		///<summary>Turn a switch on</summary>
		public static void TurnOn(this IEnumerable<SwitchEntity> target)
		{
			target.CallService("turn_on");
		}
	}

	public static class TimerEntityExtensionMethods
	{
		///<summary>Cancel a timer.</summary>
		public static void Cancel(this TimerEntity target)
		{
			target.CallService("cancel");
		}

		///<summary>Cancel a timer.</summary>
		public static void Cancel(this IEnumerable<TimerEntity> target)
		{
			target.CallService("cancel");
		}

		///<summary>Finish a timer.</summary>
		public static void Finish(this TimerEntity target)
		{
			target.CallService("finish");
		}

		///<summary>Finish a timer.</summary>
		public static void Finish(this IEnumerable<TimerEntity> target)
		{
			target.CallService("finish");
		}

		///<summary>Pause a timer.</summary>
		public static void Pause(this TimerEntity target)
		{
			target.CallService("pause");
		}

		///<summary>Pause a timer.</summary>
		public static void Pause(this IEnumerable<TimerEntity> target)
		{
			target.CallService("pause");
		}

		///<summary>Start a timer</summary>
		public static void Start(this TimerEntity target, TimerStartParameters data)
		{
			target.CallService("start", data);
		}

		///<summary>Start a timer</summary>
		public static void Start(this IEnumerable<TimerEntity> target, TimerStartParameters data)
		{
			target.CallService("start", data);
		}

		///<summary>Start a timer</summary>
		///<param name="target">The TimerEntity to call this service for</param>
		///<param name="duration">Duration the timer requires to finish. [optional] eg: 00:01:00 or 60</param>
		public static void Start(this TimerEntity target, string? @duration = null)
		{
			target.CallService("start", new TimerStartParameters{Duration = @duration});
		}

		///<summary>Start a timer</summary>
		///<param name="target">The IEnumerable<TimerEntity> to call this service for</param>
		///<param name="duration">Duration the timer requires to finish. [optional] eg: 00:01:00 or 60</param>
		public static void Start(this IEnumerable<TimerEntity> target, string? @duration = null)
		{
			target.CallService("start", new TimerStartParameters{Duration = @duration});
		}
	}

	public static class UpdateEntityExtensionMethods
	{
		///<summary>Removes the skipped version marker from an update.</summary>
		public static void ClearSkipped(this UpdateEntity target)
		{
			target.CallService("clear_skipped");
		}

		///<summary>Removes the skipped version marker from an update.</summary>
		public static void ClearSkipped(this IEnumerable<UpdateEntity> target)
		{
			target.CallService("clear_skipped");
		}

		///<summary>Install an update for this device or service</summary>
		public static void Install(this UpdateEntity target, UpdateInstallParameters data)
		{
			target.CallService("install", data);
		}

		///<summary>Install an update for this device or service</summary>
		public static void Install(this IEnumerable<UpdateEntity> target, UpdateInstallParameters data)
		{
			target.CallService("install", data);
		}

		///<summary>Install an update for this device or service</summary>
		///<param name="target">The UpdateEntity to call this service for</param>
		///<param name="version">Version to install, if omitted, the latest version will be installed. eg: 1.0.0</param>
		///<param name="backup">Backup before installing the update, if supported by the integration.</param>
		public static void Install(this UpdateEntity target, string? @version = null, bool? @backup = null)
		{
			target.CallService("install", new UpdateInstallParameters{Version = @version, Backup = @backup});
		}

		///<summary>Install an update for this device or service</summary>
		///<param name="target">The IEnumerable<UpdateEntity> to call this service for</param>
		///<param name="version">Version to install, if omitted, the latest version will be installed. eg: 1.0.0</param>
		///<param name="backup">Backup before installing the update, if supported by the integration.</param>
		public static void Install(this IEnumerable<UpdateEntity> target, string? @version = null, bool? @backup = null)
		{
			target.CallService("install", new UpdateInstallParameters{Version = @version, Backup = @backup});
		}

		///<summary>Mark currently available update as skipped.</summary>
		public static void Skip(this UpdateEntity target)
		{
			target.CallService("skip");
		}

		///<summary>Mark currently available update as skipped.</summary>
		public static void Skip(this IEnumerable<UpdateEntity> target)
		{
			target.CallService("skip");
		}
	}

	public static class UtilityMeterEntityExtensionMethods
	{
		///<summary>Calibrates a utility meter sensor.</summary>
		public static void Calibrate(this SensorEntity target, UtilityMeterCalibrateParameters data)
		{
			target.CallService("calibrate", data);
		}

		///<summary>Calibrates a utility meter sensor.</summary>
		public static void Calibrate(this IEnumerable<SensorEntity> target, UtilityMeterCalibrateParameters data)
		{
			target.CallService("calibrate", data);
		}

		///<summary>Calibrates a utility meter sensor.</summary>
		///<param name="target">The SensorEntity to call this service for</param>
		///<param name="value">Value to which set the meter eg: 100</param>
		public static void Calibrate(this SensorEntity target, string @value)
		{
			target.CallService("calibrate", new UtilityMeterCalibrateParameters{Value = @value});
		}

		///<summary>Calibrates a utility meter sensor.</summary>
		///<param name="target">The IEnumerable<SensorEntity> to call this service for</param>
		///<param name="value">Value to which set the meter eg: 100</param>
		public static void Calibrate(this IEnumerable<SensorEntity> target, string @value)
		{
			target.CallService("calibrate", new UtilityMeterCalibrateParameters{Value = @value});
		}

		///<summary>Resets all counters of a utility meter.</summary>
		public static void Reset(this SelectEntity target)
		{
			target.CallService("reset");
		}

		///<summary>Resets all counters of a utility meter.</summary>
		public static void Reset(this IEnumerable<SelectEntity> target)
		{
			target.CallService("reset");
		}
	}

	public static class VacuumEntityExtensionMethods
	{
		///<summary>Tell the vacuum cleaner to do a spot clean-up.</summary>
		public static void CleanSpot(this VacuumEntity target)
		{
			target.CallService("clean_spot");
		}

		///<summary>Tell the vacuum cleaner to do a spot clean-up.</summary>
		public static void CleanSpot(this IEnumerable<VacuumEntity> target)
		{
			target.CallService("clean_spot");
		}

		///<summary>Locate the vacuum cleaner robot.</summary>
		public static void Locate(this VacuumEntity target)
		{
			target.CallService("locate");
		}

		///<summary>Locate the vacuum cleaner robot.</summary>
		public static void Locate(this IEnumerable<VacuumEntity> target)
		{
			target.CallService("locate");
		}

		///<summary>Pause the cleaning task.</summary>
		public static void Pause(this VacuumEntity target)
		{
			target.CallService("pause");
		}

		///<summary>Pause the cleaning task.</summary>
		public static void Pause(this IEnumerable<VacuumEntity> target)
		{
			target.CallService("pause");
		}

		///<summary>Tell the vacuum cleaner to return to its dock.</summary>
		public static void ReturnToBase(this VacuumEntity target)
		{
			target.CallService("return_to_base");
		}

		///<summary>Tell the vacuum cleaner to return to its dock.</summary>
		public static void ReturnToBase(this IEnumerable<VacuumEntity> target)
		{
			target.CallService("return_to_base");
		}

		///<summary>Send a raw command to the vacuum cleaner.</summary>
		public static void SendCommand(this VacuumEntity target, VacuumSendCommandParameters data)
		{
			target.CallService("send_command", data);
		}

		///<summary>Send a raw command to the vacuum cleaner.</summary>
		public static void SendCommand(this IEnumerable<VacuumEntity> target, VacuumSendCommandParameters data)
		{
			target.CallService("send_command", data);
		}

		///<summary>Send a raw command to the vacuum cleaner.</summary>
		///<param name="target">The VacuumEntity to call this service for</param>
		///<param name="command">Command to execute. eg: set_dnd_timer</param>
		///<param name="params">Parameters for the command. eg: { "key": "value" }</param>
		public static void SendCommand(this VacuumEntity target, string @command, object? @params = null)
		{
			target.CallService("send_command", new VacuumSendCommandParameters{Command = @command, Params = @params});
		}

		///<summary>Send a raw command to the vacuum cleaner.</summary>
		///<param name="target">The IEnumerable<VacuumEntity> to call this service for</param>
		///<param name="command">Command to execute. eg: set_dnd_timer</param>
		///<param name="params">Parameters for the command. eg: { "key": "value" }</param>
		public static void SendCommand(this IEnumerable<VacuumEntity> target, string @command, object? @params = null)
		{
			target.CallService("send_command", new VacuumSendCommandParameters{Command = @command, Params = @params});
		}

		///<summary>Set the fan speed of the vacuum cleaner.</summary>
		public static void SetFanSpeed(this VacuumEntity target, VacuumSetFanSpeedParameters data)
		{
			target.CallService("set_fan_speed", data);
		}

		///<summary>Set the fan speed of the vacuum cleaner.</summary>
		public static void SetFanSpeed(this IEnumerable<VacuumEntity> target, VacuumSetFanSpeedParameters data)
		{
			target.CallService("set_fan_speed", data);
		}

		///<summary>Set the fan speed of the vacuum cleaner.</summary>
		///<param name="target">The VacuumEntity to call this service for</param>
		///<param name="fanSpeed">Platform dependent vacuum cleaner fan speed, with speed steps, like 'medium' or by percentage, between 0 and 100. eg: low</param>
		public static void SetFanSpeed(this VacuumEntity target, string @fanSpeed)
		{
			target.CallService("set_fan_speed", new VacuumSetFanSpeedParameters{FanSpeed = @fanSpeed});
		}

		///<summary>Set the fan speed of the vacuum cleaner.</summary>
		///<param name="target">The IEnumerable<VacuumEntity> to call this service for</param>
		///<param name="fanSpeed">Platform dependent vacuum cleaner fan speed, with speed steps, like 'medium' or by percentage, between 0 and 100. eg: low</param>
		public static void SetFanSpeed(this IEnumerable<VacuumEntity> target, string @fanSpeed)
		{
			target.CallService("set_fan_speed", new VacuumSetFanSpeedParameters{FanSpeed = @fanSpeed});
		}

		///<summary>Start or resume the cleaning task.</summary>
		public static void Start(this VacuumEntity target)
		{
			target.CallService("start");
		}

		///<summary>Start or resume the cleaning task.</summary>
		public static void Start(this IEnumerable<VacuumEntity> target)
		{
			target.CallService("start");
		}

		///<summary>Start, pause, or resume the cleaning task.</summary>
		public static void StartPause(this VacuumEntity target)
		{
			target.CallService("start_pause");
		}

		///<summary>Start, pause, or resume the cleaning task.</summary>
		public static void StartPause(this IEnumerable<VacuumEntity> target)
		{
			target.CallService("start_pause");
		}

		///<summary>Stop the current cleaning task.</summary>
		public static void Stop(this VacuumEntity target)
		{
			target.CallService("stop");
		}

		///<summary>Stop the current cleaning task.</summary>
		public static void Stop(this IEnumerable<VacuumEntity> target)
		{
			target.CallService("stop");
		}

		///<summary>Stop the current cleaning task and return to home.</summary>
		public static void TurnOff(this VacuumEntity target)
		{
			target.CallService("turn_off");
		}

		///<summary>Stop the current cleaning task and return to home.</summary>
		public static void TurnOff(this IEnumerable<VacuumEntity> target)
		{
			target.CallService("turn_off");
		}

		///<summary>Start a new cleaning task.</summary>
		public static void TurnOn(this VacuumEntity target)
		{
			target.CallService("turn_on");
		}

		///<summary>Start a new cleaning task.</summary>
		public static void TurnOn(this IEnumerable<VacuumEntity> target)
		{
			target.CallService("turn_on");
		}
	}

	public static class XiaomiMiioEntityExtensionMethods
	{
		///<summary>Start cleaning of the specified segment(s).</summary>
		public static void VacuumCleanSegment(this VacuumEntity target, XiaomiMiioVacuumCleanSegmentParameters data)
		{
			target.CallService("vacuum_clean_segment", data);
		}

		///<summary>Start cleaning of the specified segment(s).</summary>
		public static void VacuumCleanSegment(this IEnumerable<VacuumEntity> target, XiaomiMiioVacuumCleanSegmentParameters data)
		{
			target.CallService("vacuum_clean_segment", data);
		}

		///<summary>Start cleaning of the specified segment(s).</summary>
		///<param name="target">The VacuumEntity to call this service for</param>
		///<param name="segments">Segments. eg: [1,2]</param>
		public static void VacuumCleanSegment(this VacuumEntity target, object? @segments = null)
		{
			target.CallService("vacuum_clean_segment", new XiaomiMiioVacuumCleanSegmentParameters{Segments = @segments});
		}

		///<summary>Start cleaning of the specified segment(s).</summary>
		///<param name="target">The IEnumerable<VacuumEntity> to call this service for</param>
		///<param name="segments">Segments. eg: [1,2]</param>
		public static void VacuumCleanSegment(this IEnumerable<VacuumEntity> target, object? @segments = null)
		{
			target.CallService("vacuum_clean_segment", new XiaomiMiioVacuumCleanSegmentParameters{Segments = @segments});
		}

		///<summary>Start the cleaning operation in the selected areas for the number of repeats indicated.</summary>
		public static void VacuumCleanZone(this VacuumEntity target, XiaomiMiioVacuumCleanZoneParameters data)
		{
			target.CallService("vacuum_clean_zone", data);
		}

		///<summary>Start the cleaning operation in the selected areas for the number of repeats indicated.</summary>
		public static void VacuumCleanZone(this IEnumerable<VacuumEntity> target, XiaomiMiioVacuumCleanZoneParameters data)
		{
			target.CallService("vacuum_clean_zone", data);
		}

		///<summary>Start the cleaning operation in the selected areas for the number of repeats indicated.</summary>
		///<param name="target">The VacuumEntity to call this service for</param>
		///<param name="zone">Array of zones. Each zone is an array of 4 integer values. eg: [[23510,25311,25110,26362]]</param>
		///<param name="repeats">Number of cleaning repeats for each zone.</param>
		public static void VacuumCleanZone(this VacuumEntity target, object? @zone = null, long? @repeats = null)
		{
			target.CallService("vacuum_clean_zone", new XiaomiMiioVacuumCleanZoneParameters{Zone = @zone, Repeats = @repeats});
		}

		///<summary>Start the cleaning operation in the selected areas for the number of repeats indicated.</summary>
		///<param name="target">The IEnumerable<VacuumEntity> to call this service for</param>
		///<param name="zone">Array of zones. Each zone is an array of 4 integer values. eg: [[23510,25311,25110,26362]]</param>
		///<param name="repeats">Number of cleaning repeats for each zone.</param>
		public static void VacuumCleanZone(this IEnumerable<VacuumEntity> target, object? @zone = null, long? @repeats = null)
		{
			target.CallService("vacuum_clean_zone", new XiaomiMiioVacuumCleanZoneParameters{Zone = @zone, Repeats = @repeats});
		}

		///<summary>Go to the specified coordinates.</summary>
		public static void VacuumGoto(this VacuumEntity target, XiaomiMiioVacuumGotoParameters data)
		{
			target.CallService("vacuum_goto", data);
		}

		///<summary>Go to the specified coordinates.</summary>
		public static void VacuumGoto(this IEnumerable<VacuumEntity> target, XiaomiMiioVacuumGotoParameters data)
		{
			target.CallService("vacuum_goto", data);
		}

		///<summary>Go to the specified coordinates.</summary>
		///<param name="target">The VacuumEntity to call this service for</param>
		///<param name="xCoord">x-coordinate. eg: 27500</param>
		///<param name="yCoord">y-coordinate. eg: 32000</param>
		public static void VacuumGoto(this VacuumEntity target, string? @xCoord = null, string? @yCoord = null)
		{
			target.CallService("vacuum_goto", new XiaomiMiioVacuumGotoParameters{XCoord = @xCoord, YCoord = @yCoord});
		}

		///<summary>Go to the specified coordinates.</summary>
		///<param name="target">The IEnumerable<VacuumEntity> to call this service for</param>
		///<param name="xCoord">x-coordinate. eg: 27500</param>
		///<param name="yCoord">y-coordinate. eg: 32000</param>
		public static void VacuumGoto(this IEnumerable<VacuumEntity> target, string? @xCoord = null, string? @yCoord = null)
		{
			target.CallService("vacuum_goto", new XiaomiMiioVacuumGotoParameters{XCoord = @xCoord, YCoord = @yCoord});
		}

		///<summary>Remote control the vacuum cleaner, make sure you first set it in remote control mode with `remote_control_start`.</summary>
		public static void VacuumRemoteControlMove(this VacuumEntity target, XiaomiMiioVacuumRemoteControlMoveParameters data)
		{
			target.CallService("vacuum_remote_control_move", data);
		}

		///<summary>Remote control the vacuum cleaner, make sure you first set it in remote control mode with `remote_control_start`.</summary>
		public static void VacuumRemoteControlMove(this IEnumerable<VacuumEntity> target, XiaomiMiioVacuumRemoteControlMoveParameters data)
		{
			target.CallService("vacuum_remote_control_move", data);
		}

		///<summary>Remote control the vacuum cleaner, make sure you first set it in remote control mode with `remote_control_start`.</summary>
		///<param name="target">The VacuumEntity to call this service for</param>
		///<param name="velocity">Speed.</param>
		///<param name="rotation">Rotation, between -179 degrees and 179 degrees.</param>
		///<param name="duration">Duration of the movement.</param>
		public static void VacuumRemoteControlMove(this VacuumEntity target, double? @velocity = null, long? @rotation = null, long? @duration = null)
		{
			target.CallService("vacuum_remote_control_move", new XiaomiMiioVacuumRemoteControlMoveParameters{Velocity = @velocity, Rotation = @rotation, Duration = @duration});
		}

		///<summary>Remote control the vacuum cleaner, make sure you first set it in remote control mode with `remote_control_start`.</summary>
		///<param name="target">The IEnumerable<VacuumEntity> to call this service for</param>
		///<param name="velocity">Speed.</param>
		///<param name="rotation">Rotation, between -179 degrees and 179 degrees.</param>
		///<param name="duration">Duration of the movement.</param>
		public static void VacuumRemoteControlMove(this IEnumerable<VacuumEntity> target, double? @velocity = null, long? @rotation = null, long? @duration = null)
		{
			target.CallService("vacuum_remote_control_move", new XiaomiMiioVacuumRemoteControlMoveParameters{Velocity = @velocity, Rotation = @rotation, Duration = @duration});
		}

		///<summary>Remote control the vacuum cleaner, only makes one move and then stops.</summary>
		public static void VacuumRemoteControlMoveStep(this VacuumEntity target, XiaomiMiioVacuumRemoteControlMoveStepParameters data)
		{
			target.CallService("vacuum_remote_control_move_step", data);
		}

		///<summary>Remote control the vacuum cleaner, only makes one move and then stops.</summary>
		public static void VacuumRemoteControlMoveStep(this IEnumerable<VacuumEntity> target, XiaomiMiioVacuumRemoteControlMoveStepParameters data)
		{
			target.CallService("vacuum_remote_control_move_step", data);
		}

		///<summary>Remote control the vacuum cleaner, only makes one move and then stops.</summary>
		///<param name="target">The VacuumEntity to call this service for</param>
		///<param name="velocity">Speed.</param>
		///<param name="rotation">Rotation.</param>
		///<param name="duration">Duration of the movement.</param>
		public static void VacuumRemoteControlMoveStep(this VacuumEntity target, double? @velocity = null, long? @rotation = null, long? @duration = null)
		{
			target.CallService("vacuum_remote_control_move_step", new XiaomiMiioVacuumRemoteControlMoveStepParameters{Velocity = @velocity, Rotation = @rotation, Duration = @duration});
		}

		///<summary>Remote control the vacuum cleaner, only makes one move and then stops.</summary>
		///<param name="target">The IEnumerable<VacuumEntity> to call this service for</param>
		///<param name="velocity">Speed.</param>
		///<param name="rotation">Rotation.</param>
		///<param name="duration">Duration of the movement.</param>
		public static void VacuumRemoteControlMoveStep(this IEnumerable<VacuumEntity> target, double? @velocity = null, long? @rotation = null, long? @duration = null)
		{
			target.CallService("vacuum_remote_control_move_step", new XiaomiMiioVacuumRemoteControlMoveStepParameters{Velocity = @velocity, Rotation = @rotation, Duration = @duration});
		}

		///<summary>Start remote control of the vacuum cleaner. You can then move it with `remote_control_move`, when done call `remote_control_stop`.</summary>
		public static void VacuumRemoteControlStart(this VacuumEntity target)
		{
			target.CallService("vacuum_remote_control_start");
		}

		///<summary>Start remote control of the vacuum cleaner. You can then move it with `remote_control_move`, when done call `remote_control_stop`.</summary>
		public static void VacuumRemoteControlStart(this IEnumerable<VacuumEntity> target)
		{
			target.CallService("vacuum_remote_control_start");
		}

		///<summary>Stop remote control mode of the vacuum cleaner.</summary>
		public static void VacuumRemoteControlStop(this VacuumEntity target)
		{
			target.CallService("vacuum_remote_control_stop");
		}

		///<summary>Stop remote control mode of the vacuum cleaner.</summary>
		public static void VacuumRemoteControlStop(this IEnumerable<VacuumEntity> target)
		{
			target.CallService("vacuum_remote_control_stop");
		}
	}
}