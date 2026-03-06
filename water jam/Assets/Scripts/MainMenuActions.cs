using UnityEngine;

public class MainMenuActions : MonoBehaviour
{
    public void QuitGame()
    {
        Application.Quit();

        // Makes Quit work in the editor too (optional)
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#endif
    }
}