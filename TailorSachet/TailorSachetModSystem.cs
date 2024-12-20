using Vintagestory.API.Client;
using Vintagestory.API.Common;
using Vintagestory.API.Config;
using Vintagestory.API.Server;

namespace TailorSachet
{
    public class TailorSachetModSystem : ModSystem
    {
        // Called on server and client
        // Useful for registering block/entity classes on both sides
        public override void Start(ICoreAPI api)
        {
            api.Logger.Notification("Hello from the TailorSachet mod: " + api.Side);
            
        }

        public override void StartServerSide(ICoreServerAPI api)
        {
            api.Logger.Notification("Hello from the TailorSachet mod server side: " + Lang.Get("tailorsachet:hello"));
        }

        public override void StartClientSide(ICoreClientAPI api)
        {
            api.Logger.Notification("Hello from the TailorSachet mod client side: " + Lang.Get("tailorsachet:hello"));
        }
    }
}
