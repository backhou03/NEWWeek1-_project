using UnityEngine;
using TMPro;
public class TextCont : MonoBehaviour
{
    public TextMeshProUGUI text1;

    void Start()
    {
        SetResult(SectionTrigger.zPos);
    }
    public void SetResult(float distance)
    {
        if(SceneManage.infinityMap == false)
        {
            text1.text = "Distance : " + distance.ToString("0") + "m";
        }
        else
        {
            text1.text = "Distance : " + distance.ToString("0") + "m";
        }
        
      
    }

}
