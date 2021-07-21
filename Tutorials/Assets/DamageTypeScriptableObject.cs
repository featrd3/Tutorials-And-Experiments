using UnityEngine;

[CreateAssetMenu(fileName = "Data", menuName = "ScriptableObjects/DamageTypeScriptableObject", order = 1)]
public class DamageTypeScriptableObject : ScriptableObject
{
    public string damageName;

    public Color colour;
}
