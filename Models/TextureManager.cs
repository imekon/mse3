using System.Collections.Generic;

namespace mse.Models
{
    public class TextureManager
    {
        private List<Texture> _textures;

        public TextureManager()
        {
            _textures = new List<Texture>();    
        }

        public Texture FindTexture(string name)
        {
            foreach (var texture in _textures)
            {
                if (texture.Name == name)
                    return texture;
            }

            return null;
        }

        private static TextureManager textureManager;

        public static void CreateInstance()
        {
            textureManager = new TextureManager();
        }

        public static TextureManager GetInstance()
        {
            return textureManager;
        }
    }
}