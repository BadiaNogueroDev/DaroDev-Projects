using UnityEngine;
using UnityEngine.Serialization;

public class CharacterCustomiser : MonoBehaviour
{
    public UnisexCharacterSO unisexUnisexCharacterSO;
    public GenderedCharacterSO maleCharacterSO;
    public GenderedCharacterSO femaleCharacterSO;
    
    [Header("Unisex")]
    public SkinnedMeshRenderer Cape;
    public SkinnedMeshRenderer Belt;
    public SkinnedMeshRenderer Eyebrows;
    public SkinnedMeshRenderer PauldromL;
    public SkinnedMeshRenderer PauldromR;
    public SkinnedMeshRenderer ElbowsL;
    public SkinnedMeshRenderer ElbowsR;
    public SkinnedMeshRenderer KneeL;
    public SkinnedMeshRenderer KneeR;
    
    [Header("Gendered")]
    public SkinnedMeshRenderer Hair;
    public SkinnedMeshRenderer Head;
    public SkinnedMeshRenderer FacialHair;
    public SkinnedMeshRenderer Torso;
    public SkinnedMeshRenderer Legs;
    public SkinnedMeshRenderer ForearmL;
    public SkinnedMeshRenderer ForearmR;
    public SkinnedMeshRenderer ArmL;
    public SkinnedMeshRenderer ArmR;
    public SkinnedMeshRenderer HandL;
    public SkinnedMeshRenderer HandR;
    public SkinnedMeshRenderer CalfL;
    public SkinnedMeshRenderer CalfR;
    public SkinnedMeshRenderer FeetL; 
    public SkinnedMeshRenderer FeetR;
    
    public void CreateRandomUnisexCharacter()
    {
        int RandomPauldrom = Random.Range(0, unisexUnisexCharacterSO.PauldronL.Length);
        int RandomElbows = Random.Range(0, unisexUnisexCharacterSO.ElbowsL.Length);
        int RandomKnee = Random.Range(0, unisexUnisexCharacterSO.KneeL.Length);
        
        Cape.sharedMesh = unisexUnisexCharacterSO.Cape[Random.Range(0, unisexUnisexCharacterSO.Cape.Length)];
        Belt.sharedMesh = unisexUnisexCharacterSO.Belt[Random.Range(0, unisexUnisexCharacterSO.Belt.Length)];
        Eyebrows.sharedMesh = unisexUnisexCharacterSO.Eyebrows[Random.Range(0, unisexUnisexCharacterSO.Eyebrows.Length)];
        
        PauldromL.sharedMesh = unisexUnisexCharacterSO.PauldronL[RandomPauldrom];
        PauldromR.sharedMesh = unisexUnisexCharacterSO.PauldronR[RandomPauldrom];
        ElbowsL.sharedMesh = unisexUnisexCharacterSO.ElbowsL[RandomElbows];
        ElbowsR.sharedMesh = unisexUnisexCharacterSO.ElbowsR[RandomElbows];
        KneeL.sharedMesh = unisexUnisexCharacterSO.KneeL[RandomKnee];
        KneeR.sharedMesh = unisexUnisexCharacterSO.KneeR[RandomKnee];
    }

    public void CreateRandomMaleCharacter()
    {
        int RandomMaleForearm = Random.Range(0, maleCharacterSO.ForearmL.Length);
        int RandomMaleArm = Random.Range(0, maleCharacterSO.ArmL.Length);
        int RandomMaleHand = Random.Range(0, maleCharacterSO.HandL.Length);
        int RandomMaleCalf = Random.Range(0, maleCharacterSO.CalfL.Length);
        int RandomMaleFeet = Random.Range(0, maleCharacterSO.FeetL.Length);
        
        Hair.sharedMesh = maleCharacterSO.Hair[Random.Range(0, maleCharacterSO.Hair.Length)];
        Head.sharedMesh = maleCharacterSO.Head[Random.Range(0, maleCharacterSO.Head.Length)];
        FacialHair.sharedMesh = maleCharacterSO.FacialHair[Random.Range(0, maleCharacterSO.FacialHair.Length)];
        Torso.sharedMesh = maleCharacterSO.Torso[Random.Range(0, maleCharacterSO.Torso.Length)];
        Legs.sharedMesh = maleCharacterSO.Legs[Random.Range(0, maleCharacterSO.Legs.Length)];
        
        ForearmL.sharedMesh = maleCharacterSO.ForearmL[RandomMaleForearm];
        ForearmR.sharedMesh = maleCharacterSO.ForearmR[RandomMaleForearm];
        ArmL.sharedMesh = maleCharacterSO.ArmL[RandomMaleArm];
        ArmR.sharedMesh = maleCharacterSO.ArmR[RandomMaleArm];
        HandL.sharedMesh = maleCharacterSO.HandL[RandomMaleHand];
        HandR.sharedMesh = maleCharacterSO.HandR[RandomMaleHand];
        CalfL.sharedMesh = maleCharacterSO.CalfL[RandomMaleCalf];
        CalfR.sharedMesh = maleCharacterSO.CalfR[RandomMaleCalf];
        FeetL.sharedMesh = maleCharacterSO.FeetL[RandomMaleFeet];
        FeetR.sharedMesh = maleCharacterSO.FeetR[RandomMaleFeet];
    }

    public void CreateRandomFemaleCharacter()
    {
        int RandomFemaleForearm = Random.Range(0, femaleCharacterSO.ForearmL.Length);
        int RandomFemaleArm = Random.Range(0, femaleCharacterSO.ArmL.Length);
        int RandomFemaleHand = Random.Range(0, femaleCharacterSO.HandL.Length);
        int RandomFemaleCalf = Random.Range(0, femaleCharacterSO.CalfL.Length);
        int RandomFemaleFeet = Random.Range(0, femaleCharacterSO.FeetL.Length);

        FacialHair.sharedMesh = null;
        Hair.sharedMesh = femaleCharacterSO.Hair[Random.Range(0, femaleCharacterSO.Hair.Length)];
        Head.sharedMesh = femaleCharacterSO.Head[Random.Range(0, femaleCharacterSO.Head.Length)];
        Torso.sharedMesh = femaleCharacterSO.Torso[Random.Range(0, femaleCharacterSO.Torso.Length)];
        Legs.sharedMesh = femaleCharacterSO.Legs[Random.Range(0, femaleCharacterSO.Legs.Length)];
        
        ForearmL.sharedMesh = femaleCharacterSO.ForearmL[RandomFemaleForearm];
        ForearmR.sharedMesh = femaleCharacterSO.ForearmR[RandomFemaleForearm];
        ArmL.sharedMesh = femaleCharacterSO.ArmL[RandomFemaleArm];
        ArmR.sharedMesh = femaleCharacterSO.ArmR[RandomFemaleArm];
        HandL.sharedMesh = femaleCharacterSO.HandL[RandomFemaleHand];
        HandR.sharedMesh = femaleCharacterSO.HandR[RandomFemaleHand];
        CalfL.sharedMesh = femaleCharacterSO.CalfL[RandomFemaleCalf];
        CalfR.sharedMesh = femaleCharacterSO.CalfR[RandomFemaleCalf];
        FeetL.sharedMesh = femaleCharacterSO.FeetL[RandomFemaleFeet];
        FeetR.sharedMesh = femaleCharacterSO.FeetR[RandomFemaleFeet];
    }
}