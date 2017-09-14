// Fill out your copyright notice in the Description page of Project Settings.

using UnrealBuildTool;
using System.Collections.Generic;

public class Room_Escape_TutorialTarget : TargetRules
{
	public Room_Escape_TutorialTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;

		ExtraModuleNames.AddRange( new string[] { "Room_Escape_Tutorial" } );
	}
}
