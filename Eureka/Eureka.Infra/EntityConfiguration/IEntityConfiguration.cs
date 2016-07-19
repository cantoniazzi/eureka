using System.Data.Entity.ModelConfiguration.Configuration;

namespace Eureka.Infra.EntityConfiguration
{
    public interface IEntityConfiguration
    {
        void AddConfiguration(ConfigurationRegistrar registrar);
    }
}