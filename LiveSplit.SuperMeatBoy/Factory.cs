﻿using LiveSplit.Model;
using LiveSplit.UI.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LiveSplit.UI.Components
{
    public class Factory : IComponentFactory
    {
        public string ComponentName
        {
            get { return "Super Meat Boy Auto Splitter"; }
        }

        public IComponent Create(LiveSplitState state)
        {
            return new Component();
        }

        public string UpdateName
        {
            get { return ComponentName; }
        }

        public string XMLURL
        {
#if RELEASE_CANDIDATE
#else
            get { return "http://livesplit.org/update/Components/update.LiveSplit.SuperMeatBoy.xml"; }
#endif
        }

        public string UpdateURL
        {
#if RELEASE_CANDIDATE
#else
            get { return "http://livesplit.org/update/"; }
#endif
        }

        public Version Version
        {
            get { return Version.Parse("1.0.0"); }
        }
    }
}
