using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{
    public GameObject enemyPrefab;
    public float SpawnTime;
    float counter = 0;
    //public float SpawnTime;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        counter += Time.deltaTime;
        if (counter >= SpawnTime)//if(counter��public�ϐ�[SpawnTime]�ɐݒ肳�ꂽ�l�ȏ�ɂȂ�����)
        {
            //int RandomX = Random.Range(-15, 15);
            //int RandomZ = Random.Range(30, 40);
            Instantiate(enemyPrefab, new Vector3(transform.position.x/* + RandomX*/, transform.position.y, transform.position.z/* + RandomZ*/), Quaternion.identity);
            counter = 0;
        }

    }
}
