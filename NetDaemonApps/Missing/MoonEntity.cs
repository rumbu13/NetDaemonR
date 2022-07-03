namespace NetDaemonApps;

public record MoonEntity : Entity<MoonEntity, EntityState<MoonAttributes>, MoonAttributes>
{
	public MoonEntity(IHaContext haContext, string entityId) : base(haContext, entityId)
	{
	}

	public MoonEntity(Entity entity) : base(entity)
	{
	}
}