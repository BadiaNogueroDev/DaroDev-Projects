using UnityEngine;

[CreateAssetMenu(menuName = "Character Customization/Create Character Asset")]
public class UnisexCharacterSO : ScriptableObject
{
    [Header("Unisex")]
    public Mesh [] Cape;
    public Mesh [] Belt;
    public Mesh [] PauldronL;
    public Mesh [] PauldronR;
    public Mesh [] Eyebrows;
    public Mesh [] ElbowsL;
    public Mesh [] ElbowsR;
    public Mesh [] KneeL;
    public Mesh [] KneeR;
}
