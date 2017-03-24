﻿using System;
using System.Text;
using System.Threading.Tasks;
using LogicAndTrick.Oy;

namespace Sledge.Common.Settings
{
    public class SettingKey
    {
        public string Name { get; private set; }
        public string Description { get; private set; }
        public Type Type { get; private set; }

        public SettingKey(string name, string description, Type type)
        {
            Name = name;
            Description = description;
            Type = type;
        }
    }
}
