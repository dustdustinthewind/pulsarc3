// GameObjectExtensions
using UnityEngine;

public static class GameObjectExtensions
{
	public static bool GetActive(this GameObject MPNMOONBMII)
	{
		return MPNMOONBMII.activeInHierarchy;
	}
}
