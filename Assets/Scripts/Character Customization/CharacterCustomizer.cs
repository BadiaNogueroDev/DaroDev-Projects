using System;
using System.Linq;
using UnityEngine;
using Random = UnityEngine.Random;

public class CharacterCustomizer : MonoBehaviour
{
    public event Action <CharacterCustomizer> OnBodyPartChanged = delegate {};
    
    [SerializeField] private UnisexCharacterSO unisexCharacterSO;
    [SerializeField] private GenderedCharacterSO maleCharacterSO;
    [SerializeField] private GenderedCharacterSO femaleCharacterSO;
    private GenderedCharacterSO currentGenderedCharacterSO;
    
    [Header("Unisex Elements")]
    public SkinnedMeshRenderer Cape;
    public SkinnedMeshRenderer Belt;
    public SkinnedMeshRenderer Eyebrows;
    public SkinnedMeshRenderer PauldronL;
    public SkinnedMeshRenderer PauldronR;
    public SkinnedMeshRenderer ElbowsL;
    public SkinnedMeshRenderer ElbowsR;
    public SkinnedMeshRenderer KneeL;
    public SkinnedMeshRenderer KneeR;
    
    [Header("Gendered Elements")]
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

    public int GenderIndex;
    public int CapeIndex;
    public int BeltIndex;
    public int EyebrowsIndex;
    public int PauldromIndex;
    public int ElbowsIndex;
    public int KneeIndex;
    public int FacialHairIndex;
    public int HairIndex;
    public int HeadIndex;
    public int TorsoIndex;
    public int LegsIndex;
    public int ForearmIndex;
    public int ArmIndex;
    public int HandIndex;
    public int CalfIndex;
    public int FeetIndex;
    
    private void Start()
    {
        LoadCharacter();
        currentGenderedCharacterSO = GenderIndex == 0 ? maleCharacterSO : femaleCharacterSO;
        SetCharacter();
    }

    public void SetRandomIndexValues()
    {
        FacialHairIndex = Random.Range(0, currentGenderedCharacterSO.FacialHair.Length);
        HairIndex = Random.Range(0, currentGenderedCharacterSO.Hair.Length);
        HeadIndex = Random.Range(0, currentGenderedCharacterSO.Head.Length);
        TorsoIndex = Random.Range(0, currentGenderedCharacterSO.Torso.Length);
        LegsIndex = Random.Range(0, currentGenderedCharacterSO.Legs.Length);
        ForearmIndex = Random.Range(0, currentGenderedCharacterSO.ForearmL.Length);
        ArmIndex = Random.Range(0, currentGenderedCharacterSO.ArmL.Length);
        HandIndex = Random.Range(0, currentGenderedCharacterSO.HandL.Length);
        CalfIndex = Random.Range(0, currentGenderedCharacterSO.CalfL.Length);
        FeetIndex = Random.Range(0, currentGenderedCharacterSO.FeetL.Length);
        CapeIndex = Random.Range(0, unisexCharacterSO.Cape.Length);
        BeltIndex = Random.Range(0, unisexCharacterSO.Belt.Length);
        EyebrowsIndex = Random.Range(0, unisexCharacterSO.Eyebrows.Length);
        PauldromIndex = Random.Range(0, unisexCharacterSO.PauldronL.Length);
        ElbowsIndex = Random.Range(0, unisexCharacterSO.ElbowsL.Length);
        KneeIndex = Random.Range(0, unisexCharacterSO.KneeL.Length);
    }

    public void SetCharacter()
    {
        FacialHair.sharedMesh = !currentGenderedCharacterSO.FacialHair.Any() ? null : currentGenderedCharacterSO.FacialHair[FacialHairIndex];
        Hair.sharedMesh = currentGenderedCharacterSO.Hair[HairIndex];
        Head.sharedMesh = currentGenderedCharacterSO.Head[HeadIndex];
        Torso.sharedMesh = currentGenderedCharacterSO.Torso[TorsoIndex];
        Legs.sharedMesh = currentGenderedCharacterSO.Legs[LegsIndex];
        ForearmL.sharedMesh = currentGenderedCharacterSO.ForearmL[ForearmIndex];
        ForearmR.sharedMesh = currentGenderedCharacterSO.ForearmR[ForearmIndex];
        ArmL.sharedMesh = currentGenderedCharacterSO.ArmL[ArmIndex];
        ArmR.sharedMesh = currentGenderedCharacterSO.ArmR[ArmIndex];
        HandL.sharedMesh = currentGenderedCharacterSO.HandL[HandIndex];
        HandR.sharedMesh = currentGenderedCharacterSO.HandR[HandIndex];
        CalfL.sharedMesh = currentGenderedCharacterSO.CalfL[CalfIndex];
        CalfR.sharedMesh = currentGenderedCharacterSO.CalfR[CalfIndex];
        FeetL.sharedMesh = currentGenderedCharacterSO.FeetL[FeetIndex];
        FeetR.sharedMesh = currentGenderedCharacterSO.FeetR[FeetIndex];
        Cape.sharedMesh = unisexCharacterSO.Cape[CapeIndex];
        Belt.sharedMesh = unisexCharacterSO.Belt[BeltIndex];
        Eyebrows.sharedMesh = unisexCharacterSO.Eyebrows[EyebrowsIndex];
        PauldronL.sharedMesh = unisexCharacterSO.PauldronL[PauldromIndex];
        PauldronR.sharedMesh = unisexCharacterSO.PauldronR[PauldromIndex];
        ElbowsL.sharedMesh = unisexCharacterSO.ElbowsL[ElbowsIndex];
        ElbowsR.sharedMesh = unisexCharacterSO.ElbowsR[ElbowsIndex];
        KneeL.sharedMesh = unisexCharacterSO.KneeL[KneeIndex];
        KneeR.sharedMesh = unisexCharacterSO.KneeR[KneeIndex];
    }
    
    public GenderedCharacterSO GetGenderedSO() { return currentGenderedCharacterSO; }
    public UnisexCharacterSO GetUnisexSO() { return unisexCharacterSO; }
    
    public void SwapGender()
    {
        currentGenderedCharacterSO = currentGenderedCharacterSO == maleCharacterSO ? femaleCharacterSO : maleCharacterSO;
        GenderIndex = currentGenderedCharacterSO == maleCharacterSO ? 0 : 1;
        SetRandomIndexValues();
        SetCharacter();
    }

    public void SetCape(int value)
    {
        CapeIndex = value;
        OnBodyPartChanged(this);
    }

    public void SetBelt(int value)
    {
        BeltIndex = value;
        OnBodyPartChanged(this);
    }

    public void SetEyebrows(int value)
    {
        EyebrowsIndex = value;
        OnBodyPartChanged(this);
    }

    public void SetPauldroms(int value)
    {
        PauldromIndex = value;
        OnBodyPartChanged(this);
    }

    public void SetElbows(int value)
    {
        EyebrowsIndex = value;
        OnBodyPartChanged(this);
    }

    public void SetKnees(int value)
    {
        KneeIndex = value;
        OnBodyPartChanged(this);
    }

    public void SetFacialHair(int value)
    {
        FacialHairIndex = value;
        OnBodyPartChanged(this);
    }

    public void SetHair(int value)
    {
        HairIndex = value;
        OnBodyPartChanged(this);
    }

    public void SetHead(int value)
    {
        HeadIndex = value;
        OnBodyPartChanged(this);
    }

    public void SetTorso(int value)
    {
        TorsoIndex = value;
        OnBodyPartChanged(this);
    }

    public void SetLegs(int value)
    {
        LegsIndex = value;
        OnBodyPartChanged(this);
    }

    public void SetForearms(int value)
    {
        ForearmIndex = value;
        OnBodyPartChanged(this);
    }

    public void SetArms(int value)
    {
        ArmIndex = value;
        OnBodyPartChanged(this);
    }

    public void SetHands(int value)
    {
        HandIndex = value;
        OnBodyPartChanged(this);
    }

    public void SetCalf(int value)
    {
        CalfIndex = value;
        OnBodyPartChanged(this);
    }

    public void SetFeet(int value)
    {
        FeetIndex = value;
        OnBodyPartChanged(this);
    }
    
    //TEST
    private int IncreaseElement(Mesh [] mesh)
    {
        int index = 0;
        index++;
        if (index >= mesh.Length)
            index = 0;
        
        return index;
    }
    
    //TEST
    private int DecreaseElement(Mesh [] mesh)
    {
        int index = 0;
        index--;
        if (index < 0)
            index = mesh.Length - 1;
        
        return index;
    }
    
    public void SaveCharacter()
    {
        CharacterSaveSystem.SaveCharacter(this);
    }

    public void LoadCharacter()
    {
        CharacterCustomizerData data = CharacterSaveSystem.LoadCharacter();
        
        GenderIndex = data.Gender;
        CapeIndex = data.Cape;
        BeltIndex = data.Belt;
        EyebrowsIndex = data.Eyebrows;
        PauldromIndex = data.Pauldron;
        ElbowsIndex = data.Elbows;
        KneeIndex = data.Knee;
        FacialHairIndex = data.FacialHair;
        HairIndex = data.Hair;
        HeadIndex = data.Head;
        TorsoIndex = data.Torso;
        LegsIndex = data.Legs;
        ForearmIndex = data.Forearm;
        ArmIndex = data.Arm;
        HandIndex = data.Hand;
        CalfIndex = data.Calf;
        FeetIndex = data.Feet;
    }
}