using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class CharacterEditor : MonoBehaviour
{
    [SerializeField] private List<GameObject> playerElement;
    [SerializeField] private int currentElement;

    private void Start()
    {
        foreach (var _race in playerElement)
        {
            if (_race != playerElement.First())
            {
                _race.SetActive(false);
            }
        }
    }

    public void IncreaseElement()
    {
        playerElement[currentElement].SetActive(false);
        
        if (currentElement >= playerElement.Count - 1)
            currentElement = 0;
        else
            currentElement++;
        
        playerElement[currentElement].SetActive(true);
    }
    
    public void DecreaseElement()
    {
        playerElement[currentElement].SetActive(false);
        
        if (currentElement >= 0)
            currentElement = playerElement.Count;
        else
            currentElement--;
        
        playerElement[currentElement].SetActive(true);
    }
}
