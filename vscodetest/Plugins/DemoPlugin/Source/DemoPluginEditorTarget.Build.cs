using Flax.Build;

public class DemoPluginEditorTarget : GameProjectEditorTarget
{
    /// <inheritdoc />
    public override void Init()
    {
        base.Init();

        // Reference the modules for editor
        Modules.Add("DemoPlugin");
        Modules.Add("DemoPluginEditor");
    }
}
