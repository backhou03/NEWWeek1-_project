using UnityEngine;
using UnityEngine.SceneManagement;
public class chaserTime : MonoBehaviour
{
    [SerializeField] private float timer;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        PlayerController cont = GameObject.Find("Player").GetComponent<PlayerController>();
        
        
        if (timer > 0)
        {
            timer -= Time.deltaTime;
        }
        else
        {
            
            timer -= 0;
            if (cont != null)
            {
                int count = cont.comboCnt;
                if (count == 0)
                {
                    Destroy(gameObject);
                    SceneManager.LoadScene("kyg_gameover");
                }
            }
        }
    }
}
