namespace BinaryStudio.OurFaces.Common.Utility
{
    public class HashProvider : IHashProvider
    {
        private readonly Hasher hasher;

        public HashProvider()
        {
            this.hasher = new Hasher();
        }

        public string ComputePasswordHash(string userName, string password)
        {
            string str = userName + password;
            return this.hasher.ComputeHash(str);
        }
    }
}