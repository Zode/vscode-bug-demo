using System;
using System.Collections.Generic;
using FlaxEngine;

namespace Game;

/// <summary>
/// DemoRotator Script.
/// </summary>
public class DemoRotator : Script
{
    /// <inheritdoc/>
    public override void OnUpdate()
    {
        Actor.Orientation = Quaternion.Euler(new Vector3(Time.GameTime * 100.0f, 0.0f, 0.0f));
    }
}
