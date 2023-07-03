using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuUtama : MonoBehaviour
{
    public GameObject PanelUtama;
    public GameObject PanelSetting;
    public GameObject PanelStage;
    public GameObject AboutUs;
    public GameObject HowToPlay;

    // Start is called before the first frame update
    void Start()
    {
        PanelUtama.SetActive(true);
        PanelSetting.SetActive(false);
        PanelStage.SetActive(false);
        AboutUs.SetActive(false);
        HowToPlay.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Play(string scenename)
    {
        SceneManager.LoadScene(scenename);
    }
}
