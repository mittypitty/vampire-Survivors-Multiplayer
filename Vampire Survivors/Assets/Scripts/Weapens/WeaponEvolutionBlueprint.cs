using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName ="WeaponEvolutionBlueprint", menuName ="ScriptableObjects/WeaponEvolutionBlueprint")]
public class WeaponEvolutionBlueprint : ScriptableObject
{
    public WeaponScriptableObject baseWeaponData;
    public PassiveItemScriptableObject catalystPassiveItemData;
    public WeaponEvolutionBlueprint evolutionWeaponData;
    public GameObject evolvedWeapon;
}
