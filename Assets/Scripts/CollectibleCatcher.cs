using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CollectibleCatcher : MonoBehaviour
{
    public GameObject sphere;
    public ParticleSystem particles;

    private Vector3 origin;

    void Start()
    {
        origin = this.transform.position;
    }

    void Update()
    {
        this.transform.position = new Vector3(origin.x, origin.y + Mathf.Cos(Time.time) / 3, origin.z);
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject == sphere)
        {
            GameData.collectedCount += 1;
            if (GameData.collectedCount % 4 == 0)
            {
                SceneManager.LoadScene("Menu");
            }
            Destroy(this.gameObject);
            Instantiate(particles, transform.position, transform.rotation);
        }
    }
}
