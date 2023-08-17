// Fill out your copyright notice in the Description page of Project Settings.

#pragma once

#include "CoreMinimal.h"
#include "GameFramework/Character.h"
#include "CyberAngelRunnerCharacter.generated.h"

UCLASS()
class MYVGFINALPROJECT_API ACyberAngelRunnerCharacter : public ACharacter
{
    GENERATED_BODY()

        UPROPERTY(VisibleAnywhere)
        class UCameraComponent* SideViewCamera; // Corrected variable name

public:
    // Sets default values for this character's properties
    ACyberAngelRunnerCharacter();

protected:
    // Called when the game starts or when spawned
    virtual void BeginPlay() override;

public:
    // Called every frame
    virtual void Tick(float DeltaTime) override;

    // Called to bind functionality to input
    virtual void SetupPlayerInputComponent(class UInputComponent* PlayerInputComponent) override;

protected:
    void MoveRight(float value);

public:
    class UCameraComponent* GetSideViewCameraComponent() const
    {
        return SideViewCamera;
    }

    void RestartLevel();

    UFUNCTION()
        void OnOverlapBegin(UPrimitiveComponent* OverlappedComp,
            AActor* OtherActor, UPrimitiveComponent* OtherComp,
            int32 OtherBodyIndex, bool bFromSweep, const FHitResult& SweepResult);

private:
    float zPosition;
    FVector tempPos = FVector();

    bool CanMove;
};
