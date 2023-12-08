using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3_CreateARealWordsC_Class_
{
    public class RealWorldClassTelevsion
    {
        public bool isOn; //TV's private variables
        public int volume;
        public int channel;

        public RealWorldClassTelevsion() //programmes constructor
        {
            isOn = false;
            volume = 10;
            channel = 1;
        }

        public void TurnOn() //the public method to turn the TV on
        {
            if (!isOn)
            {
                Console.WriteLine("Television turning on."); //if the TV is on, display TV turning on
                isOn = true;
            }
            else
            {
                Console.WriteLine("The television is already on."); //display that the TV is already on
            }
        }

        
        public void TurnOff() //method for turning the TV off
        {
            if (isOn)
            {
                Console.WriteLine("Turning the television off."); //display TV turning off
                isOn = false;
            }
            else
            {
                Console.WriteLine("The television is already off."); //display the TV is already off
            }
        }

        
        public void ChangeVolume(int newVolume) //method to change the TV's volume
        {
            if (isOn)
            {
                if (newVolume >= 0 && newVolume <= 100)
                {
                    volume = newVolume;
                    Console.WriteLine($"Changed the volume to {volume}.");
                }
                else
                {
                    Console.WriteLine("Invalid volume level. Volume should be between 0 and 100."); //to showcase the range of the volume (0-100), otherwise display invalid volume
                }
            }
            else
            {
                Console.WriteLine("Cannot change volume. The television is off."); //display that the volume cannot change with the Tv being off
            }
        }

        
        public void ChangeChannel(int newChannel) //method to change the channels
        {
            if (isOn)
            {
                if (newChannel > 0)
                {
                    channel = newChannel;
                    Console.WriteLine($"Changed the channel to {channel}.");
                }
                else
                {
                    Console.WriteLine("Invalid channel number. Channel number should be greater than 0."); //display that your channel is invalid because there is no channels smaller than zero
                }
            }
            else
            {
                Console.WriteLine("Cannot change channel. The television is off."); //display that you cannot change the channel when the TV is off
            }
        }

        
        public void DisplayTVInfo() //method to show the TV's information
        {
            Console.WriteLine($"Television is {(isOn ? "on" : "off")}, Volume: {volume}, Channel: {channel}");
        }
    }


}
