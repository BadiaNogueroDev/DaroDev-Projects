using UnityEngine;

[System.Serializable]
public class CharacterCustomizerData
{
    public int Gender;
    public int Hair;
    public int Head;
    public int FacialHair;
    public int Torso;
    public int Legs;
    public int Forearm;
    public int Arm;
    public int Hand;
    public int Calf;
    public int Feet;
    public int Cape;
    public int Belt;
    public int Pauldron;
    public int Eyebrows;
    public int Elbows;
    public int Knee;

    public CharacterCustomizerData(CharacterCustomizer character)
    {
        Gender = character.GenderIndex;
        Hair = character.HairIndex;
        Head = character.HeadIndex;
        FacialHair = character.FacialHairIndex;
        Torso = character.TorsoIndex;
        Legs = character.LegsIndex;
        Forearm = character.ForearmIndex;
        Arm = character.ArmIndex;
        Hand = character.HandIndex;
        Calf = character.CalfIndex;
        Feet = character.FeetIndex;
        Cape = character.CapeIndex;
        Belt = character.BeltIndex;
        Pauldron = character.PauldromIndex;
        Eyebrows = character.EyebrowsIndex;
        Elbows = character.ElbowsIndex;
        Knee = character.KneeIndex;
    }
}
