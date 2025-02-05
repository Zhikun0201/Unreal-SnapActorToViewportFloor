﻿// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class SimpleLevelTool : ModuleRules
{
	public SimpleLevelTool(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = ModuleRules.PCHUsageMode.UseExplicitOrSharedPCHs;


		PublicDependencyModuleNames.AddRange(
			new string[]
			{
				"Blutility", 
				"Core",
				"EditorFramework",
				"EditorScriptingUtilities",
				"EditorStyle",
				"UnrealEd",
			}
		);


		PrivateDependencyModuleNames.AddRange(
			new string[]
			{
				"CoreUObject",
				"Engine",
				"InputCore",
				"LevelEditor",
				"TypedElementFramework",
				"TypedElementRuntime",
				"Slate",
				"SlateCore",
			}
		);
	}
}