using UnrealBuildTool;

public class DormPlatformerTarget : TargetRules
{
	public DormPlatformerTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;
		ExtraModuleNames.Add("DormPlatformer");
	}
}
