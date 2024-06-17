﻿using Quantumify.Nodes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using Box2D.NetStandard.Dynamics.Bodies;
using Quantumify.Nodes.Nodes2D;

namespace Test;

public class Floor : RigidBody2D {
    public Floor() : base(bodyType:BodyType.Static) {
        Size = new Vector3(128*5, 128, 0);
        Color = Raylib_cs.Color.Blue;
        //AddComponent(new Collision2D(this,BodyType.Static));
    }
}
