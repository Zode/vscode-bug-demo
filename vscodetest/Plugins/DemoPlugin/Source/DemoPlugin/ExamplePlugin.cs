using System;
using FlaxEngine;

namespace DemoPlugin
{
    /// <summary>
    /// The sample game plugin.
    /// </summary>
    /// <seealso cref="FlaxEngine.GamePlugin" />
    public class DemoPlugin : GamePlugin
    {
        /// <inheritdoc />
        public DemoPlugin()
        {
            _description = new PluginDescription
            {
                Name = "DemoPlugin",
                Category = "Other",
                Author = "",
                AuthorUrl = null,
                HomepageUrl = null,
                RepositoryUrl = "https://github.com/FlaxEngine/DemoPlugin",
                Description = "This is an example plugin project.",
                Version = new Version(1, 0, 0),
                IsAlpha = false,
                IsBeta = false,
            };
        }

        /// <inheritdoc />
        public override void Initialize()
        {
            base.Initialize();

            Debug.Log("Hello from plugin code!");
        }

        /// <inheritdoc />
        public override void Deinitialize()
        {
            // Use it to cleanup data

            base.Deinitialize();
        }
    }
}
