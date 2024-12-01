using UnityEngine;
using UnityEngine.UI;

public class GameScripts : MonoBehaviour
{
    [SerializeField] int Score;
    private static int money;
    private static int rate = 1;
    public int [] CostInt;

    public Text moneyText;
    public Text[] CostText;

    public void OnClickButton()
    {
        Score++;
    }

    public void Click()
    {
        money += rate;
    }

    public void UpgradeClick()
    {
        if (money >= 15)
        {
            money -= 15;
            rate += 1;
        }
    }

    public void Update()
    {
        moneyText.text = "$" + money;
    }

    public void OnClickBuyLevel()
    {
        if(Score>= CostInt[0])
        {
            Score -= CostInt[0];
        }

    }

}