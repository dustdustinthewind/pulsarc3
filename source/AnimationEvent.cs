// AnimationEvent
using System;
using UnityEngine.Events;

[Serializable]
public class AnimationEvent
{
	public float timeout = 1f;

	public UnityEvent OnEvent;
}
