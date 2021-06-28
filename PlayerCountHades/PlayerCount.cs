using System;
using Exiled.API.Enums;
using Exiled.API.Features;

namespace PlayerCountHades
{
    class PlayerCount : Plugin<Config>
    {
        private static readonly Lazy<PlayerCount> LazyInstance = new Lazy<PlayerCount>(valueFactory:() => new PlayerCount());

        public override PluginPriority Priority { get; } = PluginPriority.Lowest;

        public override void OnEnabled()
        {
            base.OnEnabled();
        }

        public override void OnDisabled()
        {
            base.OnDisabled();
        }
    }
}
