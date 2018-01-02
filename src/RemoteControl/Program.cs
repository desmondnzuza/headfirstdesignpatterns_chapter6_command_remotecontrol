using System;
using RemoteControl.Appliances;
using RemoteControl.Commands;
using RemoteControl.Controllers;

namespace RemoteControl
{
    class Program
    {
        static void Main(string[] args)
        {
            var remoteControl = new Controllers.RemoteControl();

            var livingRoonLight = new Light("Living Room");
            var kitchenLight = new Light("Kitchen");
            var ceilingFan = new CeilingFan("Living Room");
            var garageDoor = new GarageDoor();
            var stereo = new Stereo("Living Room");

            var livingRoomLightOn = new LightOnCommand(livingRoonLight);
            var livingRoomLightOff = new LightOffCommand(livingRoonLight);
            var kitchenLightOn = new LightOnCommand(kitchenLight);
            var kitchenLightOff = new LightOffCommand(kitchenLight);

            var ceilingFanOn = new CeilingFanOnCommand(ceilingFan);
            var ceilingFanOff = new CeilingFanOffCommand(ceilingFan);

            var garageDoorUp = new GarageDoorUpCommand(garageDoor);
            var garageDoorDown = new GarageDoorDownCommand(garageDoor);

            var stereoOnWithCd = new StereoOnWithCdCommand(stereo);
            var stereoOff = new StereoOffCommand(stereo);

            remoteControl.SetCommand(0, livingRoomLightOn, livingRoomLightOff);
            remoteControl.SetCommand(1, kitchenLightOn, kitchenLightOff);
            remoteControl.SetCommand(2, ceilingFanOn, ceilingFanOff);
            remoteControl.SetCommand(3, stereoOnWithCd, stereoOff);

            Console.WriteLine(remoteControl);

            remoteControl.OnButtonWasPressed(0);
            remoteControl.OffButtonWasPressed(0);
            remoteControl.OnButtonWasPressed(1);
            remoteControl.OffButtonWasPressed(1);
            remoteControl.OnButtonWasPressed(2);
            remoteControl.OffButtonWasPressed(2);
            remoteControl.OnButtonWasPressed(3);
            remoteControl.OffButtonWasPressed(3);

            Console.ReadLine();
        }
    }
}
