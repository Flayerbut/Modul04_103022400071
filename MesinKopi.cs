using System;
using System.Collections.Generic;
using System.Text;

namespace Modul4_103022400071
{
    class MesinKopi
    {
        enum State { OFF, STANDBY, BREWING, MAINTENANCE };
        private State state;

    public MesinKopi()
    {
        state = State.OFF;
    }
    
    public void UbahState (String input)
        {
            switch(state) 
            {
                case State.OFF:
                    if (input == "ON")
                    {
                        state = State.STANDBY;
                        Console.WriteLine("Mesin OFF berubah menjadi Standby");
                    }
                    break;

                case State.STANDBY:
                    if (input == "BREW")
                    {
                        Console.WriteLine("Mesin Standby berubah menjadi Brewing");
                        state = State.BREWING;
                    }
                case State.BREWING:
                    if (input == "OFF")
                    {
                        Console.WriteLine("Mesin Brewing berubah menjadi Standby");
                        state = State.OFF;
                    }
                    else
                    {
                        Console.WriteLine("Perubahan state tidak valid");
                    }
                    break;

                    case State.MAINTENANCE:
                    if (input == "OFF")
                    {
                        Console.WriteLine("Mesin Maintenance berubah menjadi Standby");
                        state = State.OFF;
                    }
                    else
                    {
                        Console.WriteLine("Perubahan state tidak valid");
                    }
            }
}
