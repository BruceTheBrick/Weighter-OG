using Weighter.Core;
using Plugin.Firebase.Core.Platforms.iOS;

namespace Weighter.Platforms
{
    public class CrossFirebaseInitService : ICrossFirebaseInitService
    {
        public void Initialize()
        {
            CrossFirebase.Initialize();
        }
    }
}