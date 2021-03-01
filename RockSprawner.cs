using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RockSprawner : MonoBehaviour
{
    [SerializeField]
    GameObject prefabRock;
    [SerializeField]
    Sprite rock1;
    [SerializeField]
    Sprite rock2;
    [SerializeField]
    Sprite rock3;

    const float SpawnDelay = 1;
    Timer spawnTimer;

    const int SpawnBorderSize = 100;
    int SpawnX;
    int SpawnY;

    // Start is called before the first frame update
    void Start()
    {
        SpawnX = Screen.width / 2;
        SpawnY = Screen.height / 2;

        spawnTimer = gameObject.AddComponent<Timer>();
        spawnTimer.Duration = SpawnDelay;
        spawnTimer.Run();


    }

    // Update is called once per frame
    void Update()
    {
        if (GameObject.FindGameObjectsWithTag("Rocker").Length < 3 & spawnTimer.Finished)
        {
            SpawnRock();

            spawnTimer.Duration = SpawnDelay;
            spawnTimer.Run();
        }
        
    }

    void SpawnRock()
    {
        Vector3 location = new Vector3(SpawnX, SpawnY,-Camera.main.transform.position.z);
        Vector3 worldLocation = Camera.main.ScreenToWorldPoint(location);
        GameObject rock = Instantiate(prefabRock) as GameObject;
        rock.transform.position = worldLocation;

        SpriteRenderer spriterenderer = rock.GetComponent<SpriteRenderer>();

        int spritenumber = Random.Range(0, 3);

        if (spritenumber == 0)
        {
            spriterenderer.sprite = rock1;

        }

        else if (spritenumber == 1)
        {
            spriterenderer.sprite = rock2;

        }

        else if (spritenumber == 2)
        {
            spriterenderer.sprite = rock3;

        }



    }
}
