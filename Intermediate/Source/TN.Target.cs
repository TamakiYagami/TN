using UnrealBuildTool;

public class TNTarget : TargetRules
{
	public TNTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.V2;
		Type = TargetType.Game;
		ExtraModuleNames.Add("TN");
	}
}
