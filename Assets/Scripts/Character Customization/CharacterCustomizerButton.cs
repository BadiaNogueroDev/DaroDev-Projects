using UnityEngine;
using UnityEngine.UI;

public class CharacterCustomizerButton : MonoBehaviour
{
    public enum BODY_PART { Hair, Head, FacialHair, Torso, Legs, Forearms, Arms, Hands, Calf, Feet, Cape, Belt, Pauldroms, Eyebrows, Elbows, Knees}
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
            case BODY_PART.Hair: characterCustomizer.SetHair(IncreaseElement(characterCustomizer.GetGenderedSO().Hair));
                break;
            case BODY_PART.Head: characterCustomizer.SetHead(IncreaseElement(characterCustomizer.GetGenderedSO().Head));
                break;
            case BODY_PART.FacialHair: characterCustomizer.SetFacialHair(IncreaseElement(characterCustomizer.GetGenderedSO().FacialHair));
                break;
            case BODY_PART.Torso: characterCustomizer.SetTorso(IncreaseElement(characterCustomizer.GetGenderedSO().Torso));
                break;
            case BODY_PART.Legs: characterCustomizer.SetLegs(IncreaseElement(characterCustomizer.GetGenderedSO().Legs));
                break;
            case BODY_PART.Forearms: characterCustomizer.SetForearms(IncreaseElement(characterCustomizer.GetGenderedSO().ForearmL));
                break;
            case BODY_PART.Arms: characterCustomizer.SetArms(IncreaseElement(characterCustomizer.GetGenderedSO().ArmL));
                break;
            case BODY_PART.Hands: characterCustomizer.SetHands(IncreaseElement(characterCustomizer.GetGenderedSO().HandL));
                break;
            case BODY_PART.Calf: characterCustomizer.SetCalf(IncreaseElement(characterCustomizer.GetGenderedSO().CalfL));
                break;
            case BODY_PART.Feet: characterCustomizer.SetFeet(IncreaseElement(characterCustomizer.GetGenderedSO().FeetL));
                break;
            case BODY_PART.Cape: characterCustomizer.SetCape(IncreaseElement(characterCustomizer.GetUnisexSO().Cape));
                break;
            case BODY_PART.Belt: characterCustomizer.SetBelt(IncreaseElement(characterCustomizer.GetUnisexSO().Belt));
                break;
            case BODY_PART.Pauldroms: characterCustomizer.SetPauldroms(IncreaseElement(characterCustomizer.GetUnisexSO().PauldronL));
                break;
            case BODY_PART.Eyebrows: characterCustomizer.SetEyebrows(IncreaseElement(characterCustomizer.GetUnisexSO().Eyebrows));
                break;
            case BODY_PART.Elbows: characterCustomizer.SetElbows(IncreaseElement(characterCustomizer.GetUnisexSO().ElbowsL));
                break;
            case BODY_PART.Knees: characterCustomizer.SetKnees(IncreaseElement(characterCustomizer.GetUnisexSO().KneeL));
                break;
        }
    }
    
    public void DecreaseAction()
    {
        switch (bodyPart)
        {
            case BODY_PART.Hair: characterCustomizer.SetHair(DecreaseElement(characterCustomizer.GetGenderedSO().Hair));
                break;
            case BODY_PART.Head: characterCustomizer.SetHead(DecreaseElement(characterCustomizer.GetGenderedSO().Head));
                break;
            case BODY_PART.FacialHair: characterCustomizer.SetFacialHair(DecreaseElement(characterCustomizer.GetGenderedSO().FacialHair));
                break;
            case BODY_PART.Torso: characterCustomizer.SetTorso(DecreaseElement(characterCustomizer.GetGenderedSO().Torso));
                break;
            case BODY_PART.Legs: characterCustomizer.SetLegs(DecreaseElement(characterCustomizer.GetGenderedSO().Legs));
                break;
            case BODY_PART.Forearms: characterCustomizer.SetForearms(DecreaseElement(characterCustomizer.GetGenderedSO().ForearmL));
                break;
            case BODY_PART.Arms: characterCustomizer.SetArms(DecreaseElement(characterCustomizer.GetGenderedSO().ArmL));
                break;
            case BODY_PART.Hands: characterCustomizer.SetHands(DecreaseElement(characterCustomizer.GetGenderedSO().HandL));
                break;
            case BODY_PART.Calf: characterCustomizer.SetCalf(DecreaseElement(characterCustomizer.GetGenderedSO().CalfL));
                break;
            case BODY_PART.Feet: characterCustomizer.SetFeet(DecreaseElement(characterCustomizer.GetGenderedSO().FeetL));
                break;
            case BODY_PART.Cape: characterCustomizer.SetCape(DecreaseElement(characterCustomizer.GetUnisexSO().Cape));
                break;
            case BODY_PART.Belt: characterCustomizer.SetBelt(DecreaseElement(characterCustomizer.GetUnisexSO().Belt));
                break;
            case BODY_PART.Pauldroms: characterCustomizer.SetPauldroms(DecreaseElement(characterCustomizer.GetUnisexSO().PauldronL));
                break;
            case BODY_PART.Eyebrows: characterCustomizer.SetEyebrows(DecreaseElement(characterCustomizer.GetUnisexSO().Eyebrows));
                break;
            case BODY_PART.Elbows: characterCustomizer.SetElbows(DecreaseElement(characterCustomizer.GetUnisexSO().ElbowsL));
                break;
            case BODY_PART.Knees: characterCustomizer.SetKnees(DecreaseElement(characterCustomizer.GetUnisexSO().KneeL));
                break;
        }
    }
    
    private int IncreaseElement(Mesh [] mesh)
    {
        index++;
        if (index >= mesh.Length)
            index = 0;
        
        return index;
    }
    
    private int DecreaseElement(Mesh [] mesh)
    {
        index--;
        if (index < 0)
            index = mesh.Length - 1;
        
        return index;
    }
}