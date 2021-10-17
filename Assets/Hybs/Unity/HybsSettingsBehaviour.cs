using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Hybs;
using Hybs.Realtime;

namespace Hybs.Unity
{
    public class HybsSettingsBehaviour : MonoBehaviour
    {
        public Region region = Region.JP;
        public Environment environment = Environment.Playground;
        [TextArea(0, 32)]
        public string credential = "";
    }
}