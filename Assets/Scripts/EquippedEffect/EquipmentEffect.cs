using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CreatorKitCode;

public class EquipmentEffect : EquipmentItem.EquippedEffect
{
     public int defenseChange = 30;
     public override void Equipped(CharacterData user)
     {
          // StatSystem.StatModifier myStatModifier = new StatSystem.StatModifier();
          // myStatModifier.Stats.Agility = 5;
          // user.AddModifier(myStatModifier);
          // appliedModifier = myStatModifier;
          //user.Stats.ChangeHealth(HealthAmount);
          
          StatSystem.StatModifier modifier = new StatSystem.StatModifier();
          modifier.ModifierMode = StatSystem.StatModifier.Mode.Absolute;
          modifier.Stats.defense = defenseChange;
          //user.AddModifier(modifier);
     }
     
     public override void Removed(CharacterData user)
     {
          StatSystem.StatModifier modifier = new StatSystem.StatModifier();
          modifier.ModifierMode = StatSystem.StatModifier.Mode.Absolute;
          modifier.Stats.defense = -defenseChange;
          //user.AddModifier(modifier);
     }
}
