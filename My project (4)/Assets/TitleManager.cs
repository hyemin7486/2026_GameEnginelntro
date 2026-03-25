using UnityEngine;
using UnityEngine.SceneManagement;
public class TitleManager : MonoBehaviour
{
    public GameObject helpPanel;

    public void GameStar()
    {
        SceneManager.LoadScene("PlayScene_Door1");
    }

    public void GoTitle()
    {
        SceneManager.LoadScene("TitleScene");
    }

    public void OpenHelp()
    {
        helpPanel.SetActive(true);
    }

    public void CloseHelp()
    {
        helpPanel.SetActive(false);
    }
}
