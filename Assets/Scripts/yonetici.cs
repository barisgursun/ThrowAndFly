using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class yonetici : MonoBehaviour
{
    public GameObject kup1;
    public GameObject kup2;
    public GameObject kup3;
    public GameObject silindir1;
    public GameObject silindir2;
    public GameObject silindir3;
    

    List<GameObject> kupler;
    List<GameObject> silindirler;

    Transform top;



    // Start is called before the first frame update
    void Start()
    {
        kupler = new List<GameObject>();
        silindirler = new List<GameObject>();

        uretme(kup1, 25, kupler);
        uretme(kup2, 25, kupler);
        uretme(kup3, 25, kupler);
        uretme(silindir1, 25, silindirler);
        uretme(silindir2, 25, silindirler);
        uretme(silindir3, 25, silindirler);

        InvokeRepeating("kup_uret", 1.0f, 0.5f);
        InvokeRepeating("silindir_uret", 1.0f, 0.5f);

        top = GameObject.Find("ball").transform;

    }

    void kup_uret()
    {
        int rast = Random.Range(0, kupler.Count);

        if (kupler[rast].activeSelf == false)
        {
            kupler[rast].SetActive(true);

            int rastgele = Random.Range(0, 10);

            if (rastgele == 0)
            {
                kupler[rast].transform.position = new Vector3(-14f, -4f, top.position.z + 115f);
            }
            if (rastgele == 1)
            {
                kupler[rast].transform.position = new Vector3(-8f, -4f, top.position.z + 35f);
            }
            if (rastgele == 2)
            {
                kupler[rast].transform.position = new Vector3(15f, -4f, top.position.z + 45f);
            }
            if (rastgele == 3)
            {
                kupler[rast].transform.position = new Vector3(20f, -4.4f, top.position.z + 55f);
            }
            if (rastgele == 4)
            {
                kupler[rast].transform.position = new Vector3(4f, -4.4f, top.position.z + 65f);
            }
            if (rastgele == 5)
            {
                kupler[rast].transform.position = new Vector3(18f, -4.4f, top.position.z + 75f);
            }
            if (rastgele == 6)
            {
                kupler[rast].transform.position = new Vector3(0f, -4.4f, top.position.z + 85f);
            }
            if (rastgele == 7)
            {
                kupler[rast].transform.position = new Vector3(-10f, -4.4f, top.position.z + 95f);
            }
            if (rastgele == 8)
            {
                kupler[rast].transform.position = new Vector3(-12f, -4.4f, top.position.z + 100f);
            }
            if (rastgele == 9)
            {
                kupler[rast].transform.position = new Vector3(7f, -4.4f, top.position.z + 110f);
            }


        }
        else
        {
            foreach (GameObject kup in kupler)
            {
                if (kup.activeSelf == false)
                {
                    kup.SetActive(true);
                    int rastgele2 = Random.Range(0, 10);

                    if (rastgele2 == 0)
                    {
                        kup.transform.position = new Vector3(-14f, -4f, top.position.z + 115f);
                    }
                    if (rastgele2 == 1)
                    {
                        kup.transform.position = new Vector3(-8f, -4f, top.position.z + 35f);
                    }
                    if (rastgele2 == 2)
                    {
                        kup.transform.position = new Vector3(15f, -4f, top.position.z + 45f);
                    }
                    if (rastgele2 == 3)
                    {
                        kup.transform.position = new Vector3(20f, -4.4f, top.position.z + 55f);
                    }
                    if (rastgele2 == 4)
                    {
                        kup.transform.position = new Vector3(4f, -4.4f, top.position.z + 65f);
                    }
                    if (rastgele2 == 5)
                    {
                        kup.transform.position = new Vector3(18f, -4.4f, top.position.z + 75f);
                    }
                    if (rastgele2 == 6)
                    {
                        kup.transform.position = new Vector3(0f, -4.4f, top.position.z + 85f);
                    }
                    if (rastgele2 == 7)
                    {
                        kup.transform.position = new Vector3(-10f, -4.4f, top.position.z + 95f);
                    }
                    if (rastgele2 == 8)
                    {
                        kup.transform.position = new Vector3(-12f, -4.4f, top.position.z + 100f);
                    }
                    if (rastgele2 == 9)
                    {
                        kup.transform.position = new Vector3(7f, -4.4f, top.position.z + 110f);
                    }
                    return;
                }
            }
        }
    }

    void silindir_uret()

    {
        int rast2 = Random.Range(0, silindirler.Count);

        if (silindirler[rast2].activeSelf == false)
        {
            silindirler[rast2].SetActive(true);

            int rastgele3 = Random.Range(0, 10);

            if (rastgele3 == 0)
            {
                silindirler[rast2].transform.position = new Vector3(-10f, -3f, top.position.z + 30f);
            }
            if (rastgele3 == 1)
            {
                silindirler[rast2].transform.position = new Vector3(-5f, -3f, top.position.z + 40f);
            }
            if (rastgele3 == 2)
            {
                silindirler[rast2].transform.position = new Vector3(-20f, -3f, top.position.z + 50f);
            }
            if (rastgele3 == 3)
            {
                silindirler[rast2].transform.position = new Vector3(-15f, -3f, top.position.z + 60f);
            }
            if (rastgele3 == 4)
            {
                silindirler[rast2].transform.position = new Vector3(0f, -3f, top.position.z + 70f);
            }
            if (rastgele3 == 5)
            {
                silindirler[rast2].transform.position = new Vector3(5f, -3f, top.position.z + 80f);
            }
            if (rastgele3 == 6)
            {
                silindirler[rast2].transform.position = new Vector3(15f, -3f, top.position.z + 90f);
            }
            if (rastgele3 == 7)
            {
                silindirler[rast2].transform.position = new Vector3(20f, -3f, top.position.z + 100f);
            }
            if (rastgele3 == 8)
            {
                silindirler[rast2].transform.position = new Vector3(25f, -3f, top.position.z + 15f);
            }
            if (rastgele3 == 9)
            {
                silindirler[rast2].transform.position = new Vector3(-25f, -3f, top.position.z + 25f);
            }
        }
        else
        {
            foreach (GameObject silindir in silindirler)
            {
                if (silindir.activeSelf == false)
                {
                    silindir.SetActive(true);

                    int rastgele4 = Random.Range(0, 5);

                    if (rastgele4 == 0)
                    {
                        silindir.transform.position = new Vector3(-10f, -3f, top.position.z + 30f);
                    }
                    if (rastgele4 == 1)
                    {
                        silindir.transform.position = new Vector3(-5f, -3f, top.position.z + 40f);
                    }
                    if (rastgele4 == 2)
                    {
                        silindir.transform.position = new Vector3(-20f, -3f, top.position.z + 50f);
                    }
                    if (rastgele4 == 3)
                    {
                        silindir.transform.position = new Vector3(-15f, -3f, top.position.z + 60f);
                    }
                    if (rastgele4 == 4)
                    {
                        silindir.transform.position = new Vector3(0f, -3f, top.position.z + 70f);
                    }
                    if (rastgele4 == 5)
                    {
                        silindir.transform.position = new Vector3(5f, -3f, top.position.z + 80f);
                    }
                    if (rastgele4 == 6)
                    {
                        silindir.transform.position = new Vector3(15f, -3f, top.position.z + 90f);
                    }
                    if (rastgele4 == 7)
                    {
                        silindir.transform.position = new Vector3(20f, -3f, top.position.z + 100f);
                    }
                    if (rastgele4 == 8)
                    {
                        silindir.transform.position = new Vector3(25f, -3f, top.position.z + 15f);
                    }
                    if (rastgele4 == 9)
                    {
                        silindir.transform.position = new Vector3(-25f, -3f, top.position.z + 25f);
                    }
                    return;
                }
            }
        }
    }
    void uretme(GameObject nesne, int miktar, List<GameObject> liste)
    {
        for (int i = 0; i < miktar; i++)
        {
            GameObject yeni_nesne = Instantiate(nesne);
            yeni_nesne.SetActive(false);
            liste.Add(yeni_nesne);
        }

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void replayA()
    {
        SceneManager.LoadScene("Scenes/game");
        Time.timeScale = 1.0f;
    }

    public void exitG()
    {
        Application.Quit();
    }
}
