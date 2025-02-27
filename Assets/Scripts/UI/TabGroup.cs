using UnityEngine;
using System.Collections.Generic;

public class TabGroup : MonoBehaviour
{
    [SerializeField] private GameObject tabButtonPrefab;
    [SerializeField] private GameObject tabContentPrefab;
    
    [SerializeField] private Sprite baseImage;
    [SerializeField] private Sprite hoverImage;
    [SerializeField] private Sprite selectedImage;
    
    [SerializeField] private GameObject tabContentParent;
    private List<GameObject> tabContents;
    private List<TabButton> tabButtons;
    private TabButton selectedTab;

    private void Start()
    {
        tabContents = new List<GameObject>();
        tabButtons = new List<TabButton>();
        
        foreach (Transform child in tabContentParent.transform)
        {
            tabContents.Add(child.gameObject);
        }
        
        foreach (Transform child in transform)
        {
            tabButtons.Add(child.GetComponent<TabButton>());
        }
    }

    public void OnTabEnter(TabButton button)
    {
        ResetTabs();
        if (button != selectedTab) 
            button.backgroundImage.sprite = hoverImage;
    }

    public void OnTabExit(TabButton button)
    {
        ResetTabs();
    }

    public void OnTabSelected(TabButton button)
    {
        if (selectedTab != null)
            selectedTab.Deselect();
        
        selectedTab = button;
        selectedTab.Select();
        
        ResetTabs();
        button.backgroundImage.sprite = selectedImage;

        int index = button.transform.GetSiblingIndex();
        for (int i = 0; i < tabContents.Count; i++)
        {
            tabContents[i].SetActive(i == index);
        }
    }

    public void ResetTabs()
    {
        foreach (var button in tabButtons)
        {
            if (button != selectedTab)
                button.backgroundImage.sprite = baseImage;
        }
    }

    public void AddTab()
    {
        GameObject tabButton = Instantiate(tabButtonPrefab, transform);
        tabButtons.Add(tabButton.GetComponent<TabButton>());
        
        GameObject tabContent = Instantiate(tabContentPrefab, tabContentParent.transform);
        tabContents.Add(tabContent);
    }

    public void RemoveTab()
    {
        Destroy(tabButtons[^1].gameObject);
        tabButtons.Remove(tabButtons[^1]);
        
        Destroy(tabContents[^1]);
        tabContents.Remove(tabContents[^1]);
    }
}
