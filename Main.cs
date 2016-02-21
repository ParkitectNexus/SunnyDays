using UnityEngine;

namespace SunnyDays
{
    public class Main : IMod
    {
        private GameObject _go;

        public void onEnabled()
        {
            _go = new GameObject("SunnyDays");

            _go.AddComponent<SunEnforcer>();
        }

        public void onDisabled()
        {
            Object.Destroy(_go);
        }

        public string Name { get { return "Sunny Days"; } }
        public string Description { get { return "Never again you'll see rain in your park"; } }
        public string Identifier { get; set; }
    }
}
