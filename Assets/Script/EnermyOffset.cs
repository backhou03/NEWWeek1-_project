using JetBrains.Annotations;
using UnityEngine;

public class EnermyOffset : MonoBehaviour
{
    [SerializeField]private GameObject player;
    public Vector3 playerPos;
    public int p;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        playerPos = player.transform.position;
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
