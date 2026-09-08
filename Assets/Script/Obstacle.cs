using JetBrains.Annotations;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    public Vector3 playerPos;
    public Vector3 obstacle;
    [SerializeField] private float distance;
    [SerializeField] private GameObject[] enermy;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        float playerZ = transform.position.z;
        int i = Random.Range(0, 2);
        Instantiate(enermy[i], playerPos + new Vector3(0, 0, distance), Quaternion.identity);
        

}

    // Update is called once per frame
    void Update()
    {
       
    }
}
