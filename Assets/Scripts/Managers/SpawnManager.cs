
using UnityEngine;
using Unity.Mathematics;
using DG.Tweening;
using System.Collections;
public class SpawnManager : MonoBehaviour
{
    [SerializeField] private Transform[] enemySpawnOffsets;
    [SerializeField] private PlayerController player;
    [SerializeField] private float sqrLen;
    [SerializeField] private float sqrDistance;
    [SerializeField] private GameObject[] enermy;
    private int randomEnermy;
    private int randomEnermyPos;
    private GameObject hi;
    Vector3 prevPosition;

    public Transform cam;
    public Transform cameraOffset;
    Vector3 rotationVector = new Vector3(0, 180, 0);
    //[SerializeField] private float spawnPerDistance;
    [Space]

    [Header("Test")]
    [SerializeField] private Vector3 moveVector;
    public float timer = 2;



    private void Start()
    {
        prevPosition = player.transform.position;
        StartCoroutine(DelayStart());
    }

    IEnumerator DelayStart()
    {
        yield return new WaitForSeconds(2f);
        cam.DOMove(cameraOffset.position, 2f).OnComplete(() =>
        {
            player.Init();
        });
        cam.DORotateQuaternion(cameraOffset.rotation, 2f);
    }


    private void OnEnd()
    {

    }

    private void Update()
    {

        moveVector = player.transform.position - prevPosition;//Vector3.Distance(prevPosition, player.position);
        sqrLen = moveVector.sqrMagnitude;
        if (sqrLen> sqrDistance)//distance 10 넣었을때 다른이유
        {
            Debug.Log("Spawn!");
            //moveVector = 0f;
            
            randomEnermy = UnityEngine.Random.Range(0, 2);
            randomEnermyPos = UnityEngine.Random.Range(0, 3);
            hi = Instantiate(enermy[randomEnermy], enemySpawnOffsets[randomEnermyPos].position, enermy[randomEnermy].transform.rotation);
            prevPosition = player.transform.position;

        }

        
    }
}
