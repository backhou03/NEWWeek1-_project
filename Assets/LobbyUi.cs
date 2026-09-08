using UnityEngine;
using UnityEngine.SceneManagement;

public class LobbyUi : MonoBehaviour
{
    public GameObject panel;
    public GameObject text;
    public GameObject button;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void Active()
    {
        panel.SetActive(true);
        text.SetActive(true);
        button.SetActive(true);

    }
    public void InActive()
    {
        panel.SetActive(false);
        text.SetActive(false);
        button.SetActive(false);
    }
    public void Quit()
    {
        Application.Quit();
    }
/*    public void Text()
    {
        text.SetActive(true);
    }
    public void Button()
    {
        button.SetActive(true);
    }*/
}
