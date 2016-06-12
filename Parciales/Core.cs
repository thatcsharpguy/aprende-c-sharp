#define __ANDROID__
using System;

namespace Parciales
{
    public partial class Core
    {
        public Core()
        {
            #if __ANDROID__
            int camera = 0;
            string options = "";
            var photo = TakePhoto(camera, options);
            #elif __IOS__
            string camera = "";
            var photo = TakePhoto(camera);
            #endif

            int byteCount = photo.Length;
        }
    }
}

