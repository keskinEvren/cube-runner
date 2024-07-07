using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CharacterSpawner : MonoBehaviour
{
    public GameObject[] characters;
    int index = 0;

    // Start is called before the first frame update
    void Start()
    {
        // Retrieve the selected character index from PlayerPrefs
        index = PlayerPrefs.GetInt("CharacterSelected", 0);
        Debug.Log("Character index: " + index);

        if (index >= 0 && index < characters.Length)
        {
            GameObject selectedCharacter = characters[index];
            Instantiate(selectedCharacter, transform.position, Quaternion.identity);
        }
        else
        {
            Debug.LogError("Character index out of range");
        }
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(1);
        Time.timeScale = 1.0f;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
