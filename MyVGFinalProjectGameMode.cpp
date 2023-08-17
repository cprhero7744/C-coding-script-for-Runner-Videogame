// Copyright Epic Games, Inc. All Rights Reserved.

#include "MyVGFinalProjectGameMode.h"
#include "MyVGFinalProjectCharacter.h"
#include "UObject/ConstructorHelpers.h"

AMyVGFinalProjectGameMode::AMyVGFinalProjectGameMode()
{
	// set default pawn class to our Blueprinted character
	static ConstructorHelpers::FClassFinder<APawn> PlayerPawnBPClass(TEXT("/Game/ThirdPersonCPP/Blueprints/ThirdPersonCharacter"));
	if (PlayerPawnBPClass.Class != NULL)
	{
		DefaultPawnClass = PlayerPawnBPClass.Class;
	}
}
