

using UnrealBuildTool;
using System.Collections.Generic;

public class LearnAuraEditorTarget : TargetRules
{
	public LearnAuraEditorTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Editor;
		DefaultBuildSettings = BuildSettingsVersion.V5;

		ExtraModuleNames.AddRange( new string[] { "LearnAura" } );
	}
}
