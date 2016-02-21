using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace SunnyDays
{
    class SunEnforcer : MonoBehaviour
    {
        void Update()
        {
            if (WeatherController.Instance.IsRaining)
            {
                WeatherController.Instance.debugToggleRain();
            }
        }
    }
}
