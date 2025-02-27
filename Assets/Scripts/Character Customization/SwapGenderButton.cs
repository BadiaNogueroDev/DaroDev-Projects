using UnityEngine;
using UnityEngine.UI;

public class SwapGenderButton : MonoBehaviour
{
    private CharacterCustomizer characterCustomizer;
    [SerializeField] private Button femaleButton;
    [SerializeField] private Button maleButton;
    
    void Start()
    {
        characterCustomizer = FindFirstObjectByType<CharacterCustomizer>();
        femaleButton.onClick.AddListener(characterCustomizer.SetFemale);
        maleButton.onClick.AddListener(characterCustomizer.SetMale);
    }
}
