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
    public int Prix2;
    public int Prix3;
    public int PrixConstell0;
    public int PrixConstell1;
    public int PrixConstell2;
    public int PrixConstell3;
    public int PrixConstell4;
    public int PrixConstell5;
    public int PrixConstell6;
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
    public TextMeshProUGUI textPrix2;
    public TextMeshProUGUI textPrix3;
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
    public GameObject Constellation0;
    public GameObject Constellation1;
    public GameObject Constellation2;
    public GameObject Constellation3;
    public GameObject Constellation4;
    public GameObject Constellation5;
    public GameObject Constellation6;
    public GameObject ByeText0;
    public GameObject ByeText1;
    public GameObject ByeText2;
    public GameObject ByeText3;
    public GameObject ByeText4;
    public GameObject ByeText5;
    public GameObject ByeText6;


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
            clickPower += 3;
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
            clickPower += 90;
            scoreArgent.score -= Prix1;
            scoreArgent.score1 -= Prix1;
            Prix1 = Prix1 + (Prix1 * 74 / 100);
            textPrix1.text = Prix1.ToString("00");
        }
    }
    public void PremierUpgrade2()
    {
        if (scoreArgent.score >= Prix2)
        {
            clickPower += 360;
            scoreArgent.score -= Prix2;
            scoreArgent.score1 -= Prix2;
            Prix2 = Prix2 + (Prix2 * 74 / 100);
            textPrix2.text = Prix2.ToString("00");
        }
    }
    public void PremierUpgrade3()
    {
        if (scoreArgent.score >= Prix3)
        {
            clickPower += 2090;
            scoreArgent.score -= Prix3;
            scoreArgent.score1 -= Prix3;
            Prix3 = Prix3 + (Prix3 * 67 / 100);
            textPrix3.text = Prix3.ToString("00");
        }
    }
    public void Constell0()
    {
        if (scoreArgent.score >= PrixConstell0 && Obtention0 == 0)
        {
            clickPower += 1200;
            scoreArgent.score -= PrixConstell0;
            scoreArgent.score1 -= PrixConstell0;
            MortEtoile0.SetActive(true);
            Obtention0 = 1;
            Destroy(Constellation0);
            Destroy(ByeText0);
            // #je pense que je peut enlever la condition obtention mais je veux pas tout casser# //
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
            Destroy(Constellation1);
            Destroy(ByeText1);
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
            Destroy(Constellation2);
            Destroy(ByeText2);
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
            Destroy(Constellation3);
            Destroy(ByeText3);

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
            Destroy(Constellation4);
            Destroy(ByeText4);
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
            Destroy(Constellation5);
            Destroy(ByeText5);
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
            Destroy(Constellation6);
            Destroy(ByeText6);

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
