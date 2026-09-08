using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManage : MonoBehaviour
{
    public static bool infinityMap = false;
    public void start()
    {

    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void Restart()
    {
        Managers.Instance.Fade.FadeOut(() =>
        {
            infinityMap = false;
            SceneManager.LoadSceneAsync("kyg_game");
            GameObject.Find("Player").GetComponent<PlayerController>().InitInput();

        });
    }
    public void Menu()
    {
        Managers.Instance.Fade.FadeOut(() =>
        {
            SceneManager.LoadSceneAsync("kyg_Lobby");
        });
    }
    public void WinMenu()
    {

      SceneManager.LoadSceneAsync("kyg_Lobby");

    }

    public void Infinity()
    {
        infinityMap = true;
        Debug.Log(infinityMap);
        SceneManager.LoadSceneAsync("kyg_game");

    }

}
