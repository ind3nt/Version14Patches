﻿using Exiled.API.Interfaces;

namespace _14_Patches
{
    public class Config : IConfig
    {
        public bool IsEnabled { get; set; } = true;

        public bool Debug { get; set; } = false;
    }
}
