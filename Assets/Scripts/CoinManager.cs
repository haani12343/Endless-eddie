using UnityEngine;
using TMPro;
public class CoinManager : MonoBehaviour
{
    public static int coins = 0;
    public TextMeshProUGUI coinText;
    void Update()
    {
        coinText.text = "Coins: " + coins;

    }
}