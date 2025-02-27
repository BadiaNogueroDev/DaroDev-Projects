using System;
using UnityEngine;
using UnityEngine.UI;

public class CharacterCustomizerButton : MonoBehaviour
{
    public enum BODY_PART { Hair, Head, FacialHair, Torso, Legs, ForearmL, ForearmR, ArmL, ArmR, HandL, HandR, CalfL, CalfR, FeetL, FeetR, Cape, Belt, PauldronL, PauldronR, Eyebrows, ElbowsL, ElbowsR, KneeL, KneeR}
    public BODY_PART bodyPart;
    
    private CharacterCustomizer characterCustomizer;
    
    [SerializeField] private Button increaseButton;
    [SerializeField] private Button decreaseButton;

    private int index;
    
    void Start()
    {
        characterCustomizer = FindFirstObjectByType<CharacterCustomizer>();
        increaseButton.onClick.AddListener(IncreaseAction);
        decreaseButton.onClick.AddListener(DecreaseAction);
    }

    public void IncreaseAction()
    {
        switch (bodyPart)
        {
            case BODY_PART.Hair: characterCustomizer.Hair.sharedMesh = IncreaseElement(characterCustomizer.GetCurrentSO().Hair, "Hair");
                break;
            case BODY_PART.Head: characterCustomizer.Head.sharedMesh = IncreaseElement(characterCustomizer.GetCurrentSO().Head, "Head");
                break;
            case BODY_PART.FacialHair: characterCustomizer.FacialHair.sharedMesh = IncreaseElement(characterCustomizer.GetCurrentSO().FacialHair, "FacialHair");
                break;
            case BODY_PART.Torso: characterCustomizer.Torso.sharedMesh = IncreaseElement(characterCustomizer.GetCurrentSO().Torso, "Torso");
                break;
            case BODY_PART.Legs: characterCustomizer.Legs.sharedMesh = IncreaseElement(characterCustomizer.GetCurrentSO().Legs, "Legs");
                break;
            case BODY_PART.ForearmL: characterCustomizer.ForearmL.sharedMesh = IncreaseElement(characterCustomizer.GetCurrentSO().ForearmL, "ForearmL");
                break;
            case BODY_PART.ForearmR: characterCustomizer.ForearmR.sharedMesh = IncreaseElement(characterCustomizer.GetCurrentSO().ForearmR, "ForearmR");
                break;
            case BODY_PART.ArmL: characterCustomizer.ArmL.sharedMesh = IncreaseElement(characterCustomizer.GetCurrentSO().ArmL, "ArmL");
                break;
            case BODY_PART.ArmR: characterCustomizer.ArmR.sharedMesh = IncreaseElement(characterCustomizer.GetCurrentSO().ArmR, "ArmR");
                break;
            case BODY_PART.HandL: characterCustomizer.HandL.sharedMesh = IncreaseElement(characterCustomizer.GetCurrentSO().HandL, "HandL");
                break;
            case BODY_PART.HandR: characterCustomizer.HandR.sharedMesh = IncreaseElement(characterCustomizer.GetCurrentSO().HandR, "HandR");
                break;
            case BODY_PART.CalfL: characterCustomizer.CalfL.sharedMesh = IncreaseElement(characterCustomizer.GetCurrentSO().CalfL, "CalfL");
                break;
            case BODY_PART.CalfR: characterCustomizer.CalfR.sharedMesh = IncreaseElement(characterCustomizer.GetCurrentSO().CalfR, "CalfR");
                break;
            case BODY_PART.FeetL: characterCustomizer.FeetL.sharedMesh = IncreaseElement(characterCustomizer.GetCurrentSO().FeetL, "FeetL");
                break;
            case BODY_PART.FeetR: characterCustomizer.FeetR.sharedMesh = IncreaseElement(characterCustomizer.GetCurrentSO().FeetR, "FeetR");
                break;
            case BODY_PART.Cape: characterCustomizer.Cape.sharedMesh = IncreaseElement(characterCustomizer.GetUnisexSO().Cape, "Cape");
                break;
            case BODY_PART.Belt: characterCustomizer.Belt.sharedMesh = IncreaseElement(characterCustomizer.GetUnisexSO().Belt, "Belt");
                break;
            case BODY_PART.PauldronL: characterCustomizer.PauldronL.sharedMesh = IncreaseElement(characterCustomizer.GetUnisexSO().PauldronL, "PauldronL");
                break;
            case BODY_PART.PauldronR: characterCustomizer.PauldronR.sharedMesh = IncreaseElement(characterCustomizer.GetUnisexSO().PauldronR, "PauldronR");
                break;
            case BODY_PART.Eyebrows: characterCustomizer.Eyebrows.sharedMesh = IncreaseElement(characterCustomizer.GetUnisexSO().Eyebrows, "Eyebrows");
                break;
            case BODY_PART.ElbowsL: characterCustomizer.ElbowsL.sharedMesh = IncreaseElement(characterCustomizer.GetUnisexSO().ElbowsL, "ElbowsL");
                break;
            case BODY_PART.ElbowsR: characterCustomizer.ElbowsR.sharedMesh = IncreaseElement(characterCustomizer.GetUnisexSO().ElbowsR, "ElbowsR");
                break;
            case BODY_PART.KneeL: characterCustomizer.KneeL.sharedMesh = IncreaseElement(characterCustomizer.GetUnisexSO().KneeL, "KneeL");
                break;
            case BODY_PART.KneeR: characterCustomizer.KneeR.sharedMesh = IncreaseElement(characterCustomizer.GetUnisexSO().KneeR, "KneeR");
                break;
        }
    }
    
    public void DecreaseAction()
    {
        switch (bodyPart)
        {
            case BODY_PART.Hair: characterCustomizer.Hair.sharedMesh = DecreaseElement(characterCustomizer.GetCurrentSO().Hair, "Hair");
                break;
            case BODY_PART.Head: characterCustomizer.Head.sharedMesh = DecreaseElement(characterCustomizer.GetCurrentSO().Head, "Head");
                break;
            case BODY_PART.FacialHair: characterCustomizer.FacialHair.sharedMesh = DecreaseElement(characterCustomizer.GetCurrentSO().FacialHair, "FacialHair");
                break;
            case BODY_PART.Torso: characterCustomizer.Torso.sharedMesh = DecreaseElement(characterCustomizer.GetCurrentSO().Torso, "Torso");
                break;
            case BODY_PART.Legs: characterCustomizer.Legs.sharedMesh = DecreaseElement(characterCustomizer.GetCurrentSO().Legs, "Legs");
                break;
            case BODY_PART.ForearmL: characterCustomizer.ForearmL.sharedMesh = DecreaseElement(characterCustomizer.GetCurrentSO().ForearmL, "ForearmL");
                break;
            case BODY_PART.ForearmR: characterCustomizer.ForearmR.sharedMesh = DecreaseElement(characterCustomizer.GetCurrentSO().ForearmR, "ForearmR");
                break;
            case BODY_PART.ArmL: characterCustomizer.ArmL.sharedMesh = DecreaseElement(characterCustomizer.GetCurrentSO().ArmL, "ArmL");
                break;
            case BODY_PART.ArmR: characterCustomizer.ArmR.sharedMesh = DecreaseElement(characterCustomizer.GetCurrentSO().ArmR, "ArmR");
                break;
            case BODY_PART.HandL: characterCustomizer.HandL.sharedMesh = DecreaseElement(characterCustomizer.GetCurrentSO().HandL, "HandL");
                break;
            case BODY_PART.HandR: characterCustomizer.HandR.sharedMesh = DecreaseElement(characterCustomizer.GetCurrentSO().HandR, "HandR");
                break;
            case BODY_PART.CalfL: characterCustomizer.CalfL.sharedMesh = DecreaseElement(characterCustomizer.GetCurrentSO().CalfL, "CalfL");
                break;
            case BODY_PART.CalfR: characterCustomizer.CalfR.sharedMesh = DecreaseElement(characterCustomizer.GetCurrentSO().CalfR, "CalfR");
                break;
            case BODY_PART.FeetL: characterCustomizer.FeetL.sharedMesh = DecreaseElement(characterCustomizer.GetCurrentSO().FeetL, "FeetL");
                break;
            case BODY_PART.FeetR: characterCustomizer.FeetR.sharedMesh = DecreaseElement(characterCustomizer.GetCurrentSO().FeetR, "FeetR");
                break;
            case BODY_PART.Cape: characterCustomizer.Cape.sharedMesh = DecreaseElement(characterCustomizer.GetUnisexSO().Cape, "Cape");
                break;
            case BODY_PART.Belt: characterCustomizer.Belt.sharedMesh = DecreaseElement(characterCustomizer.GetUnisexSO().Belt, "Belt");
                break;
            case BODY_PART.PauldronL: characterCustomizer.PauldronL.sharedMesh = DecreaseElement(characterCustomizer.GetUnisexSO().PauldronL, "PauldronL");
                break;
            case BODY_PART.PauldronR: characterCustomizer.PauldronR.sharedMesh = DecreaseElement(characterCustomizer.GetUnisexSO().PauldronR, "PauldronR");
                break;
            case BODY_PART.Eyebrows: characterCustomizer.Eyebrows.sharedMesh = DecreaseElement(characterCustomizer.GetUnisexSO().Eyebrows, "Eyebrows");
                break;
            case BODY_PART.ElbowsL: characterCustomizer.ElbowsL.sharedMesh = DecreaseElement(characterCustomizer.GetUnisexSO().ElbowsL, "ElbowsL");
                break;
            case BODY_PART.ElbowsR: characterCustomizer.Cape.sharedMesh = DecreaseElement(characterCustomizer.GetUnisexSO().ElbowsR, "ElbowsR");
                break;
            case BODY_PART.KneeL: characterCustomizer.KneeL.sharedMesh = DecreaseElement(characterCustomizer.GetUnisexSO().KneeL, "KneeL");
                break;
            case BODY_PART.KneeR: characterCustomizer.KneeR.sharedMesh = DecreaseElement(characterCustomizer.GetUnisexSO().KneeR, "KneeR");
                break;
        }
    }
    
    private Mesh IncreaseElement(Mesh [] mesh, string name)
    {
        index++;
        if (index >= mesh.Length)
            index = 0;
        
        PlayerPrefs.SetInt(name, index);
        Debug.Log(name);
        return mesh[index];
    }
    
    private Mesh DecreaseElement(Mesh [] mesh, string name)
    {
        index--;
        if (index < 0)
            index = mesh.Length - 1;
        
        PlayerPrefs.SetInt(name, index);
        Debug.Log(name);
        return mesh[index];
    }
}