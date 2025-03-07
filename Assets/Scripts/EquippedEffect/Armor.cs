using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CreatorKitCode;

public class Armor : EquipmentItem.EquippedEffect
{
     public StatSystem.StatModifier Modifier;
     public override void Equipped(CharacterData user)
     {
          user.Stats.AddModifier(Modifier);
     }
     
     
     public override void Removed(CharacterData user)
     {
          user.Stats.RemoveModifier(Modifier);
     }
}
