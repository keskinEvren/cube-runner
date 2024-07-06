using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Selection : MonoBehaviour
{

    public List<GameObject> characters = new List<GameObject>();
    public TextMeshProUGUI characterName;
    public Button selectButton;
    public static int currentIndex = 0;
    // Start is called before the first frame update
    void Start()
    {
        UpdateCharacterDisplay();
        selectButton.onClick.AddListener(OnSelectButtonClicked);
    }

    // Update is called once per frame
    void UpdateCharacterDisplay()
    {
        foreach(var character in characters)
        {
            character.SetActive(false);
        }
        characters[currentIndex].SetActive(true);
        characterName.text = characters[currentIndex].name;
    }

    public void onRightButtonClicled()
    {
        currentIndex = (currentIndex + 1) % characters.Count;
        UpdateCharacterDisplay();
    }

    public void onLeftButtonClicled()
    {
        currentIndex = (currentIndex - 1) % characters.Count;
        UpdateCharacterDisplay();   
    }

    void OnSelectButtonClicked()
    {
        SceneManager.LoadScene(1);
        PlayerPrefs.SetInt("CharacterSelected", currentIndex);
        PlayerPrefs.Save();
    }
}
