using UnityEngine;

public class CharacterCustomiser : MonoBehaviour
{
    public CharacterAssetSO characterAssetSO;
    
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
    
    [Header("Female")]
    public SkinnedMeshRenderer F_Hair;
    public SkinnedMeshRenderer F_Head;
    public SkinnedMeshRenderer F_Torso;
    public SkinnedMeshRenderer F_Legs;
    public SkinnedMeshRenderer [] F_Forearm;
    public SkinnedMeshRenderer [] F_Arm;
    public SkinnedMeshRenderer [] F_Hand;
    public SkinnedMeshRenderer [] F_Calf;
    public SkinnedMeshRenderer [] F_Feet;
    
    [Header("Male")]
    public SkinnedMeshRenderer M_Hair;
    public SkinnedMeshRenderer M_Head;
    public SkinnedMeshRenderer M_FacialHair;
    public SkinnedMeshRenderer M_Torso;
    public SkinnedMeshRenderer M_Legs;
    public SkinnedMeshRenderer [] M_Forearm;
    public SkinnedMeshRenderer [] M_Arm;
    public SkinnedMeshRenderer [] M_Hand;
    public SkinnedMeshRenderer [] M_Calf;
    public SkinnedMeshRenderer [] M_Feet;
    
    public void CreateRandomUnisexCharacter()
    {
        Cape.sharedMesh = characterAssetSO.Cape[Random.Range(0, characterAssetSO.Cape.Length)];
        Belt.sharedMesh = characterAssetSO.Belt[Random.Range(0, characterAssetSO.Belt.Length)];
        Eyebrows.sharedMesh = characterAssetSO.Eyebrows[Random.Range(0, characterAssetSO.Eyebrows.Length)];
        PauldromL.sharedMesh = characterAssetSO.PauldronL[Random.Range(0, characterAssetSO.PauldronL.Length)];
        PauldromR.sharedMesh = characterAssetSO.PauldronR[Random.Range(0, characterAssetSO.PauldronR.Length)];
        ElbowsL.sharedMesh = characterAssetSO.ElbowsL[Random.Range(0, characterAssetSO.ElbowsL.Length)];
        ElbowsR.sharedMesh = characterAssetSO.ElbowsR[Random.Range(0, characterAssetSO.ElbowsR.Length)];
        KneeL.sharedMesh = characterAssetSO.KneeL[Random.Range(0, characterAssetSO.KneeL.Length)];
        KneeR.sharedMesh = characterAssetSO.KneeR[Random.Range(0, characterAssetSO.KneeR.Length)];
    }

    public void CreateRandomFemaleCharacter()
    {
        F_Hair.sharedMesh = characterAssetSO.F_Hair[Random.Range(0, characterAssetSO.F_Hair.Length)];
        F_Head.sharedMesh = characterAssetSO.F_Head[Random.Range(0, characterAssetSO.F_Head.Length)];
        F_Torso.sharedMesh = characterAssetSO.F_Torso[Random.Range(0, characterAssetSO.F_Torso.Length)];
        F_Legs.sharedMesh = characterAssetSO.F_Legs[Random.Range(0, characterAssetSO.F_Legs.Length)];
        
    }

    public void CreateRandomMaleCharacter()
    {
        M_Hair.sharedMesh = characterAssetSO.M_Hair[Random.Range(0, characterAssetSO.M_Hair.Length)];
        M_Head.sharedMesh = characterAssetSO.M_Head[Random.Range(0, characterAssetSO.M_Head.Length)];
        M_FacialHair.sharedMesh = characterAssetSO.M_FacialHair[Random.Range(0, characterAssetSO.M_FacialHair.Length)];
        M_Torso.sharedMesh = characterAssetSO.M_Torso[Random.Range(0, characterAssetSO.M_Torso.Length)];
        M_Legs.sharedMesh = characterAssetSO.M_Legs[Random.Range(0, characterAssetSO.M_Legs.Length)];

        int ForearmRandom = Random.Range(0, characterAssetSO.M_Forearm.Length);
        int ArmRandom = Random.Range(0, characterAssetSO.M_Arm.Length);
        int HandRandom = Random.Range(0, characterAssetSO.M_Hand.Length);
        int CalfRandom = Random.Range(0, characterAssetSO.M_Calf.Length);
        int FeetRandom = Random.Range(0, characterAssetSO.M_Feet.Length);
    }
}