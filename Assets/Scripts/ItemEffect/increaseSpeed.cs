using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CreatorKitCode;

public class increaseSpeed : UsableItem.UsageEffect
{
    public float boostDuration = 5.0f;
    public int agilityBoost = 10;
    public Sprite effectIcon;

    public override bool Use(CharacterData user)
    {
        StatSystem.StatModifier speedBoost = new StatSystem.StatModifier();
        speedBoost.ModifierMode = StatSystem.StatModifier.Mode.Absolute; //?
        speedBoost.Stats.agility = agilityBoost;

        user.Stats.AddTimedModifier(speedBoost, boostDuration, "SpeedBoost", effectIcon);
        return true;
    }
}
