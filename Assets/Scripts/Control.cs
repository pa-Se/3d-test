using UnityEngine;
using UnityEngine.SceneManagement;

public class Control : MonoBehaviour
{
    Scene currentScene;
    string sceneName;

    void start()
    {
        currentScene = SceneManager.GetActiveScene();
        sceneName = currentScene.name;

        if (sceneName == "Menue")
        {
            SceneManager.LoadScene("GameScene");
        }

        if (sceneName == "GameScene")
        {
            SceneManager.LoadScene("PauseGame");
        }


    }
}
