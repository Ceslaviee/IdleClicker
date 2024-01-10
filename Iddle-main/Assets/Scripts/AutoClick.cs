using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class AutoClick : MonoBehaviour
{ 
    public ScoreManager gerescore;
    public ScoreManager scoreArgent;
    public int clickPower;
    public int puissance;
    public int Prix;
    public int Prix1;
    public int PrixConstell0;
    public int PrixConstell1;
    public int PrixConstell2;
    public int PrixConstell3;
    public int PrixConstell4;
    public int PrixConstell5;
    public int PrixConstell6;
    public int Quantite;
    public int Quantite1;
    public int Obtention0;
    public int Obtention1;
    public int Obtention2;
    public int Obtention3;
    public int Obtention4;
    public int Obtention5;
    public int Obtention6;
    public int etoile;
    public int galaxie;
    public int trou;
    public TextMeshProUGUI textPrix;
    public TextMeshProUGUI textPrix1;
    public TextMeshProUGUI textQuantite;
    public TextMeshProUGUI textQuantite1;
    public GameObject MonCanvas;
    public GameObject MonAutreCanvas;
    public GameObject MortEtoile0;
    public GameObject MortEtoile1;
    public GameObject MortEtoile2;
    public GameObject MortEtoile3;
    public GameObject MortEtoile4;
    public GameObject MortEtoile5;
    public GameObject MortEtoile6;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(autoClick());
        MonCanvas.SetActive(true);
        MonAutreCanvas.SetActive(false);
        MortEtoile0.SetActive(false);
        MortEtoile1.SetActive(false);
        MortEtoile2.SetActive(false);
        MortEtoile3.SetActive(false);
        MortEtoile4.SetActive(false);
        MortEtoile5.SetActive(false);
        MortEtoile6.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PremierUpgrade()
    {
        if (scoreArgent.score >= Prix)
        {
            clickPower += 2;
            scoreArgent.score -= Prix;
            scoreArgent.score1 -= Prix;
            Prix = Prix + (Prix * 83/100);
            textPrix.text = Prix.ToString("00");
            
        }

    }
    public void PremierUpgrade1()
    {
        if (scoreArgent.score >= Prix1)
        {
            clickPower += 20;
            scoreArgent.score -= Prix1;
            scoreArgent.score1 -= Prix1;
            Prix1 = Prix1 + (Prix1 * 74 / 100);
            textPrix1.text = Prix1.ToString("00");
        }
    }
    public void Constell0()
    {
        if (scoreArgent.score >= PrixConstell0 && Obtention0 == 0)
        {
            clickPower += 1000;
            scoreArgent.score -= PrixConstell0;
            scoreArgent.score1 -= PrixConstell0;
            MortEtoile0.SetActive(true);
            Obtention0 = 1;
        }
    }
    public void Constell1()
    {
        if (scoreArgent.score >= PrixConstell1 && Obtention1 == 0)
        {
            clickPower += 25;
            scoreArgent.score -= PrixConstell1;
            scoreArgent.score1 -= PrixConstell1;
            MortEtoile1.SetActive(true);
            Obtention1 = 1;
        }
    }
    public void Constell2()
    {
        if (scoreArgent.score >= PrixConstell2 && Obtention2 == 0)
        {
            clickPower += 75;
            scoreArgent.score -= PrixConstell2;
            scoreArgent.score1 -= PrixConstell2;
            MortEtoile2.SetActive(true);
            Obtention2 = 1;
        }
    }
    public void Constell3()
    {
        if (scoreArgent.score >= PrixConstell3 && Obtention3 == 0)
        {
            clickPower += 150;
            scoreArgent.score -= PrixConstell3;
            scoreArgent.score1 -= PrixConstell3;
            MortEtoile3.SetActive(true);
            Obtention3 = 1;

        }
    }
    public void Constell4()
    {
        if (scoreArgent.score >= PrixConstell4 && Obtention4 == 0)
        {
            clickPower += 250;
            scoreArgent.score -= PrixConstell4;
            scoreArgent.score1 -= PrixConstell4;
            MortEtoile4.SetActive(true);
            Obtention4 = 1;
        }
    }
    public void Constell5()
    {
        if (scoreArgent.score >= PrixConstell5 && Obtention5 == 0)
        {
            clickPower += 1000;
            scoreArgent.score -= PrixConstell5;
            scoreArgent.score1 -= PrixConstell5;
            MortEtoile5.SetActive(true);
            Obtention5 = 1;

        }
    }
    public void Constell6()
    {
        if (scoreArgent.score >= PrixConstell6 && Obtention6 == 0)
        {
            clickPower += 5000;
            scoreArgent.score -= PrixConstell6;
            scoreArgent.score1 -= PrixConstell6;
            MortEtoile6.SetActive(true);
            Obtention6 = 1;

        }
    }
    public void ChangementScene()
    {
        MonCanvas.SetActive(true);
        MonAutreCanvas.SetActive(false);
    }

    public void AutreChangementScene()
    {
        MonCanvas.SetActive(false);
        MonAutreCanvas.SetActive(true);
    }
    public void UpgradeAutoClick()
    {
        clickPower += puissance;
    }
    public IEnumerator autoClick()
    {
        while (true)
        {
            gerescore.RiseScore(clickPower);
            gerescore.RiseScoreAutre(clickPower);
            yield return new WaitForSeconds(0.48f);
        }
        
    }

}
