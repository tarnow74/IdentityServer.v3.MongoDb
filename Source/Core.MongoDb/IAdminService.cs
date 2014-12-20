using Thinktecture.IdentityServer.Core.Models;

namespace IdentityServer.Core.MongoDb
{
    public interface IAdminService
    {
        void CreateDatabase(bool createExpires = true);
        void Save(Scope scope);
        void Save(Client client);
        void RemoveDatabase();
    }
}