using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class AnimationEvent : UnityEvent<string>
{

}
public class WeaponAnimationEvents : MonoBehaviour
{
    private AnimationEvent weaponAnimationEvent = new AnimationEvent();

    public AnimationEvent WeaponAnimationEvent { get => weaponAnimationEvent; set => weaponAnimationEvent = value; }

    public void OnAnimationEvent(string eventName)
    {
        WeaponAnimationEvent.Invoke(eventName);
    }
}
