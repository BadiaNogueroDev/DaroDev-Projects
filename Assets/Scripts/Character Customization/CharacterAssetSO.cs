using UnityEngine;

[CreateAssetMenu(menuName = "Character Customization/Create Character Asset")]
public class CharacterAssetSO : ScriptableObject
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
    
    [Header("Female")]
    public Mesh [] F_Hair;
    public Mesh [] F_Head;
    public Mesh [] F_Torso;
    public Mesh [] F_Legs;
    public Mesh [] F_Forearm;
    public Mesh [] F_Arm;
    public Mesh [] F_Hand;
    public Mesh [] F_Calf;
    public Mesh [] F_Feet;
    
    [Header("Male")]
    public Mesh [] M_Hair;
    public Mesh [] M_Head;
    public Mesh [] M_FacialHair;
    public Mesh [] M_Torso;
    public Mesh [] M_Legs;
    public Mesh [] M_Forearm;
    public Mesh [] M_Arm;
    public Mesh [] M_Hand;
    public Mesh [] M_Calf;
    public Mesh [] M_Feet;
}
