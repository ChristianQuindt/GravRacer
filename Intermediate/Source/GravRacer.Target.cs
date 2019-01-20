using UnrealBuildTool;

public class GravRacerTarget : TargetRules
{
	public GravRacerTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;
		ExtraModuleNames.Add("GravRacer");
	}
}
