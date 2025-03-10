using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CreatorKitCode;

public class UseEffect : UsableItem.UsageEffect
{
    public float Duration = 10.0f;
    public int SpeedChange = 30;
    public Sprite EffectSprite;

    public override bool Use(CharacterData user)
    {
        StatSystem.StatModifier modifier = new StatSystem.StatModifier();
        modifier.ModifierMode = StatSystem.StatModifier.Mode.Percentage;
        modifier.Stats.agility = SpeedChange;
        
        VFXManager.PlayVFX(VFXType.Stronger, user.transform.position);
        
        user.Stats.AddTimedModifier(modifier, Duration, "SpeedUp", EffectSprite);
        
        return true;
    }
}
