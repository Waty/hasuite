using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.DirectX;
using Microsoft.DirectX.Direct3D;
using Microsoft.DirectX.AudioVideoPlayback;
using System.Drawing;

namespace HaCreator.MapSimulator
{
    public class TextureS
    {
        private Texture texture;
        private Size size;

        public TextureS(Device device, Bitmap data)
        {
            texture = Texture.FromBitmap(device, data, Usage.Dynamic, Pool.Default);
            size = data.Size;
        }

        public Texture Texture { get { return texture; } }
        public int Width { get { return size.Width; } }
        public int Height { get { return size.Height; } }
    }
}
