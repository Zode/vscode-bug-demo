using System;
using System.Collections.Generic;
using FlaxEngine;

namespace DemoPluginEditor;

/// <summary>
/// DemoActor Script.
/// </summary>
[ActorContextMenu("New/Demo/Demo")]
[ActorToolbox("Demo")]
public class DemoActor : Actor
{
    public override void OnDebugDraw()
    {
        DebugDraw.DrawLine(Vector3.Zero, Vector3.One * 100, Color.Red, 0.0f, false);
    }
}
