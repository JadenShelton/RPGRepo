using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CreatorKitCode;

public class AddHealthEffect : UsableItem.UsageEffect
{
    public int HealthIncrease = 10;
    public override bool Use(CharacterData user)
    {
        user.Stats.ChangeHealth(HealthIncrease);
        return true;
    }
}

