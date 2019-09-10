﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toolbox.Library
{
    public interface IEditorFormParameters
    {
        bool KeepOpen { get; }
        EventHandler OnSave { get; set; }
    }
}
