﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Events.Abnormality
{
    public enum AbnormalityTriggerType
    {
        Added = 0,
        Removed = 1,
        Refreshed = 2,
        MissingDuringFight = 3
    }
}