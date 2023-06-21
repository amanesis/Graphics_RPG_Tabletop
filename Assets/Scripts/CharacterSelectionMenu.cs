// CharacterSelectionMenu.cs

using UnityEngine;
using UnityEngine.SceneManagement;

public class CharacterSelectionMenu : MonoBehaviour
{
    public GameObject warriorPrefab;
    public GameObject magePrefab;
    public GameObject priestPrefab;
    public GameObject rangerPrefab;

    public static GameObject SelectedCharacter { get; private set; }

    public void SelectWarrior()
    {
        SpawnCharacter(warriorPrefab);
    }

    public void SelectMage()
    {
        SpawnCharacter(magePrefab);
    }

    public void SelectPriest()
    {
        SpawnCharacter(priestPrefab);
    }

    public void SelectRanger()
    {
        SpawnCharacter(rangerPrefab);
    }

    private void SpawnCharacter(GameObject characterPrefab)
    {
        if (characterPrefab != null)
        {
            SelectedCharacter = characterPrefab;
            SceneManager.LoadScene("Scene1");
        }
    }
}
