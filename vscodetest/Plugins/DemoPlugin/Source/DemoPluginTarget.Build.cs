using Flax.Build;

public class DemoPluginTarget : GameProjectTarget
{
    /// <inheritdoc />
    public override void Init()
    {
        base.Init();

        // Reference the modules for game
        Modules.Add("DemoPlugin");
    }
}
