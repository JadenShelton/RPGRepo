using System.Collections;
using System.Collections.Generic;
using CreatorKitCode;
using UnityEngine;

public class IncreaseStrengthEffect : UsableItem.UsageEffect
{
    public float Duration = 10.0f;
    public int StrengthChange = 5;
    public int agilityBoost = 50;
    public Sprite EffectSprite;
    
    public override bool Use(CharacterData user)
    {
        StatSystem.StatModifier modifier = new StatSystem.StatModifier();
        modifier.ModifierMode = StatSystem.StatModifier.Mode.Absolute;
        modifier.Stats.strength = StrengthChange;

        StatSystem.StatModifier speedBoost = new StatSystem.StatModifier();
        speedBoost.ModifierMode = StatSystem.StatModifier.Mode.Absolute; //?
        speedBoost.Stats.agility = agilityBoost;

        VFXManager.PlayVFX(VFXType.Stronger, user.transform.position);

        user.Stats.AddTimedModifier(speedBoost, Duration, "SpeedBoost", EffectSprite);
        user.Stats.AddTimedModifier(modifier, Duration, "StrengthAdd", EffectSprite);
        
        return true;
    }
}