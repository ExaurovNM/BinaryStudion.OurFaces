namespace BinaryStudio.OurFaces.Common.Utility
{
    public interface IHashProvider
    {
        string ComputePasswordHash(string userName, string password);
    }
}
