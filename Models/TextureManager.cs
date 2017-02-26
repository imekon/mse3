namespace mse.Models
{
    public class TextureManager
    {
        public TextureManager()
        {
            
        }

        public Texture FindTexture(string name)
        {
            return new Texture();
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