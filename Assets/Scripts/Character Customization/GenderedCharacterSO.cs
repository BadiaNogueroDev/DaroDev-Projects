using UnityEngine;

[CreateAssetMenu(menuName = "Character Customization/Create Gendered Character Asset")]
public class GenderedCharacterSO : ScriptableObject
{
    public Mesh [] Hair;
    public Mesh [] Head;
    public Mesh [] FacialHair;
    public Mesh [] Torso;
    public Mesh [] Legs;
    public Mesh [] ForearmL;
    public Mesh [] ForearmR;
    public Mesh [] ArmL;
    public Mesh [] ArmR;
    public Mesh [] HandL;
    public Mesh [] HandR;
    public Mesh [] CalfL;
    public Mesh [] CalfR;
    public Mesh [] FeetL;
    public Mesh [] FeetR;
}