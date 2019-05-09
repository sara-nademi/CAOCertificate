namespace Infra.SecurityManagement
{
    public interface IResource
    {
        string Key { get; }

        string Title { get; }

        string Comment { get; }

        byte AccepatableAccessRight { get; }

        ResourceTypes ResourceType { get; }
    }
}