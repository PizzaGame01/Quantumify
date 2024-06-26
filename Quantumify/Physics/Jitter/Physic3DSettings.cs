﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Quantumify.Physics.Jitter;
public struct Physics3DSettings
{

    public Vector3 Gravity;
    public int MaxBodies;
    public int MaxContacts;
    public int MaxConstraints;
    public bool MultiThreaded;
    public bool UseFullEPASolver;

    /// <summary>
    /// Represents the settings for the physics engine.
    /// </summary>
    public Physics3DSettings()
    {
        this.Gravity = new Vector3(0, -9.81F, 0);
        this.MaxBodies = 32768;
        this.MaxContacts = 65536;
        this.MaxConstraints = 32768;
        this.MultiThreaded = true;
        this.UseFullEPASolver = false;
    }
}
