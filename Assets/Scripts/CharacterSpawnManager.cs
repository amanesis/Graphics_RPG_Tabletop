// CharacterSpawnManager.cs

using UnityEngine;

public class CharacterSpawnManager : MonoBehaviour
{
    public GameObject characterSpawnPoint; // Assign the character spawn point GameObject in the Inspector

    private void Start()
    {
        SpawnSelectedCharacter();
    }

    private void SpawnSelectedCharacter()
    {
        if (CharacterSelectionMenu.SelectedCharacter != null && characterSpawnPoint != null)
        {
            Vector3 spawnPosition = new Vector3(142.050064f, 0.699999988f, 430.99176f);

            // Optionally, apply a small random offset within a radius around the spawn position
            float spawnRadius = 10f;
            Vector2 randomOffset = Random.insideUnitCircle * spawnRadius;
            spawnPosition += new Vector3(randomOffset.x, 0f, randomOffset.y);

            GameObject character = Instantiate(CharacterSelectionMenu.SelectedCharacter, spawnPosition, Quaternion.identity);
        }
        else
        {
            Debug.LogError("No selected character or character spawn point found!");
        }
    }
}
