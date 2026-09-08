using NUnit.Framework;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.Universal;
using UnityEngine.SceneManagement;

public class SectionTrigger : MonoBehaviour
{
    public GameObject map; //생성시킬 맵 오브젝트
    public Vector3 mapPosition; //맵의 위치를 저장할 변수
    public List<GameObject> mapCount = new();
    public Vector3 playerPosition;
    //public int mapIndex = 10;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    [SerializeField] private float yOffset;
    [SerializeField] private float xOffset;
    public static float zPos;
    public int scount = 0;


    void Start()
    {
        Vector3 playerPosition = transform.position;

        //MapInfo mapInfo = map.GetComponent<MapInfo>();
        mapPosition = playerPosition + new Vector3(xOffset, yOffset, 95);//mapPosition에 플레이어 위치랑 바닥위치 고려해서 삽입

        GameObject go = Instantiate(map, mapPosition, map.transform.rotation);
        mapCount.Add(go);
    }


    void OnTriggerEnter(Collider other)
    {

        if (other.CompareTag("Trigger"))
        {

            GameObject go = Instantiate(map, mapPosition + new Vector3(0, 0, 200), map.transform.rotation);

            mapCount.Add(go);
            if (mapCount.Count > 4)//3개이상 맵이 생성되면 이전맵 제거 
            {
                Destroy(mapCount[0]);//이전맵제거
                mapCount.RemoveAt(0);//이전인덱스제거
            }

            mapPosition = go.transform.position; //새로 생성된 맵의 위치를 저장



        }

    }
    private void Update()
    {
        Vector3 playerPosition = transform.position;
        zPos = playerPosition.z;
        //Debug.Log(zPos);
        bool t = SceneManage.infinityMap;
        Debug.Log(t);
        if (t == false)
        {
            if (zPos > 1000 )
            {
                // Managers.Instance.Fade.FadeOut(() =>
                //{

                SceneManager.LoadScene("kyg_win");


                // });
            }
           

        }
        else
        {

        }

    }
}