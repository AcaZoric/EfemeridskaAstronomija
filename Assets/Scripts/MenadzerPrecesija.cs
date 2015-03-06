using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class MenadzerPrecesija : MonoBehaviour
{

    public static MenadzerPrecesija menadzerSkripta;
    public Text LabelaGodina;
    public Text LabelaBrzina;
    public Slider SlajderGodine;
    public Slider Brzina;
    public Toggle Sporo;
    public Toggle SunceToggle;
    public GameObject Zemlja;
    public GameObject Sunce;
    public float brzina = 1f;
    public int RedniBrojGodine = 1;
    public Camera SporednaKamera;

    public GameObject Ekliptika;
    public GameObject Ekvator;
    public GameObject Zodiak;
    public GameObject SeverniPol;

    private bool PovecanPol = false;
    private float Brojac = 0f;
    void Start()
    {
        menadzerSkripta = this;
        RedniBrojGodine = 1;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
            Application.Quit();
        Brojac = Brojac + brzina;
        /*if (Brojac >= 100)
        {
            if (RedniBrojGodine >= 26000)
                RedniBrojGodine = 0;
            RedniBrojGodine+=500;
            SlajderGodine.value = RedniBrojGodine;
            Brojac = 0;
            Zemlja.transform.rotation = Quaternion.identity;
            Zemlja.transform.Rotate(new Vector3(0f, (float)(RedniBrojGodine * 0.013846), 0f));
        }
        else*/
        {
            if (RedniBrojGodine >= 26000)
                RedniBrojGodine = 0;
            Zemlja.transform.Rotate(new Vector3(0f, 0.07f, 0f) * brzina);
            SlajderGodine.value = SlajderGodine.value + (brzina * 5f);
        }
        Sunce.transform.Rotate(new Vector3(0f, 1820f, 0f) * brzina);
        LabelaGodina.text = Mathf.Abs(RedniBrojGodine - 1000) + ((RedniBrojGodine < 1000) ? " B.C." : " A.C.");
        SlajderGodine.value = RedniBrojGodine;

        if (Brzina.maxValue==5)
        {
            brzina=(Brzina.value*2f)/10f;
            LabelaBrzina.text = brzina + "";
        }
    }

    public void ToggleSporo(bool Ukljuceno)
    {
        SunceToggle.interactable = Ukljuceno;
        if (Ukljuceno == true)
        {
            Brzina.maxValue = 5f;
            Brzina.value = 1f;
        }
        else
        {
            Brzina.maxValue = 20f;
            SunceToggle.isOn = false;
        }
    }

    public void ToggleSunce(bool Ukljuceno)
    {
        Sunce.SetActive(Ukljuceno);
    }

    public void PovecajPol()
    {
        if (!PovecanPol)
        {
            SporednaKamera.rect = new Rect(0, 0, 1, 1);
            SporednaKamera.transform.localPosition = new Vector3(0, 0, 0);
            PovecanPol = true;
        }
        else
        {
            SporednaKamera.rect = new Rect(0.5f, 0.5f, 1, 1);
            SporednaKamera.transform.localPosition = new Vector3(0.83f, 0, 0.83f);
            PovecanPol = false;
        }
    }

    public void Eklipticka(bool Ukljuceno)
    {
        Ekliptika.SetActive(Ukljuceno);
    }

    public void Ekvatorijalna(bool Ukljuceno)
    {
        Ekvator.SetActive(Ukljuceno);
    }

    public void Zodiakova(bool Ukljuceno)
    {
        Zodiak.SetActive(Ukljuceno);
    }

    public void Mapa(bool Ukljuceno)
    {
        SporednaKamera.enabled = Ukljuceno;
        SeverniPol.SetActive(Ukljuceno);
    }
}
