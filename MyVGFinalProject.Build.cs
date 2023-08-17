// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class MyVGFinalProject : ModuleRules
{
	public MyVGFinalProject(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

		PublicDependencyModuleNames.AddRange(new string[] { "Core", "CoreUObject", "Engine", "InputCore", "HeadMountedDisplay" });
	}
}
