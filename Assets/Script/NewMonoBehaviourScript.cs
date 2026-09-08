using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Cursor.visible = true; // 커서를 보이게 함
        Cursor.lockState = CursorLockMode.None; // 커서 고정을 해제하여 자유롭게 움직이도록 함
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
