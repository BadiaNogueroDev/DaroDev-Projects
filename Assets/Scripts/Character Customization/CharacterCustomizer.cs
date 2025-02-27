using System.Linq;
using UnityEngine;

public class CharacterCustomizer : MonoBehaviour
{
    [SerializeField] private UnisexCharacterSO unisexCharacterSO;
    [SerializeField] private GenderedCharacterSO maleCharacterSO;
    [SerializeField] private GenderedCharacterSO femaleCharacterSO;
    private GenderedCharacterSO currentGenderedCharacterSO;
    
    [Header("Unisex")]
    public SkinnedMeshRenderer Cape;
    public SkinnedMeshRenderer Belt;
    public SkinnedMeshRenderer Eyebrows;
    public SkinnedMeshRenderer PauldronL;
    public SkinnedMeshRenderer PauldronR;
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
    
    private void Start()
    {
        currentGenderedCharacterSO = PlayerPrefs.GetInt("Gender", 0) == 0 ? maleCharacterSO : femaleCharacterSO;
        CreateRandomGenderedCharacter();
        CreateRandomUnisexCharacter();
    }

    public void CreateRandomUnisexCharacter()
    {
        int RandomPauldrom = Random.Range(0, unisexCharacterSO.PauldronL.Length);
        int RandomElbows = Random.Range(0, unisexCharacterSO.ElbowsL.Length);
        int RandomKnee = Random.Range(0, unisexCharacterSO.KneeL.Length);
        
        Cape.sharedMesh = unisexCharacterSO.Cape[Random.Range(0, unisexCharacterSO.Cape.Length)];
        Belt.sharedMesh = unisexCharacterSO.Belt[Random.Range(0, unisexCharacterSO.Belt.Length)];
        Eyebrows.sharedMesh = unisexCharacterSO.Eyebrows[Random.Range(0, unisexCharacterSO.Eyebrows.Length)];
        
        PauldronL.sharedMesh = unisexCharacterSO.PauldronL[RandomPauldrom];
        PauldronR.sharedMesh = unisexCharacterSO.PauldronR[RandomPauldrom];
        ElbowsL.sharedMesh = unisexCharacterSO.ElbowsL[RandomElbows];
        ElbowsR.sharedMesh = unisexCharacterSO.ElbowsR[RandomElbows];
        KneeL.sharedMesh = unisexCharacterSO.KneeL[RandomKnee];
        KneeR.sharedMesh = unisexCharacterSO.KneeR[RandomKnee];
    }

    public void CreateRandomGenderedCharacter()
    {
        int RandomForearm = Random.Range(0, currentGenderedCharacterSO.ForearmL.Length);
        int RandomArm = Random.Range(0, currentGenderedCharacterSO.ArmL.Length);
        int RandomHand = Random.Range(0, currentGenderedCharacterSO.HandL.Length);
        int RandomCalf = Random.Range(0, currentGenderedCharacterSO.CalfL.Length);
        int RandomFeet = Random.Range(0, currentGenderedCharacterSO.FeetL.Length);

        FacialHair.sharedMesh = !currentGenderedCharacterSO.FacialHair.Any() ? null : currentGenderedCharacterSO.FacialHair[Random.Range(0, currentGenderedCharacterSO.FacialHair.Length)];
        
        Hair.sharedMesh = currentGenderedCharacterSO.Hair[Random.Range(0, currentGenderedCharacterSO.Hair.Length)];
        Head.sharedMesh = currentGenderedCharacterSO.Head[Random.Range(0, currentGenderedCharacterSO.Head.Length)];
        Torso.sharedMesh = currentGenderedCharacterSO.Torso[Random.Range(0, currentGenderedCharacterSO.Torso.Length)];
        Legs.sharedMesh = currentGenderedCharacterSO.Legs[Random.Range(0, currentGenderedCharacterSO.Legs.Length)];
        
        ForearmL.sharedMesh = currentGenderedCharacterSO.ForearmL[RandomForearm];
        ForearmR.sharedMesh = currentGenderedCharacterSO.ForearmR[RandomForearm];
        ArmL.sharedMesh = currentGenderedCharacterSO.ArmL[RandomArm];
        ArmR.sharedMesh = currentGenderedCharacterSO.ArmR[RandomArm];
        HandL.sharedMesh = currentGenderedCharacterSO.HandL[RandomHand];
        HandR.sharedMesh = currentGenderedCharacterSO.HandR[RandomHand];
        CalfL.sharedMesh = currentGenderedCharacterSO.CalfL[RandomCalf];
        CalfR.sharedMesh = currentGenderedCharacterSO.CalfR[RandomCalf];
        FeetL.sharedMesh = currentGenderedCharacterSO.FeetL[RandomFeet];
        FeetR.sharedMesh = currentGenderedCharacterSO.FeetR[RandomFeet];
    }

    public void SwapGender()
    {
        currentGenderedCharacterSO = currentGenderedCharacterSO == maleCharacterSO ? femaleCharacterSO : maleCharacterSO;
        CreateRandomGenderedCharacter();
    }

    public void SetFemale()
    {
        if (currentGenderedCharacterSO != maleCharacterSO) return;
        currentGenderedCharacterSO = femaleCharacterSO;
        CreateRandomGenderedCharacter();
        PlayerPrefs.SetInt("Gender", 1);
    }

    public void SetMale()
    {
        if (currentGenderedCharacterSO != femaleCharacterSO) return;
        currentGenderedCharacterSO = maleCharacterSO;
        CreateRandomGenderedCharacter();
        PlayerPrefs.SetInt("Gender", 0);
    }

    public GenderedCharacterSO GetCurrentSO()
    {
        return currentGenderedCharacterSO;
    }
    
    public UnisexCharacterSO GetUnisexSO()
    {
        return unisexCharacterSO;
    }

    public void LoadCharacter()
    {
        
    }
}