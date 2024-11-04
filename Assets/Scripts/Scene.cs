using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitcher : MonoBehaviour
{
    public void SwitchToMenu()
    {
        SceneManager.LoadScene("MenuUI");
    }

    public void SwitchToMain()
    {
        SceneManager.LoadScene("MainUI");
    }
}
