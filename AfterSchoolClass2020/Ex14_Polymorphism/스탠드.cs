﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex14_Polymorphism
{
    class 스탠드
    {
        private 전구 light;

        public void InstallLight(전구 light)
        {
            this.light = light;
        }

        public void On()
        {
            if (light != null)
                light.TurnOn();
            else
                Console.WriteLine("전구가 없습니다.");
        }

        public void Off()
        {
            if (light != null)
                light.TurnOff();
            else
                Console.WriteLine("전구가 없습니다.");
        }
    }
}
