using UnityEngine;

public class GeneralNPC : MonoBehaviour
{
    public static GeneralNPC Instance { get; private set; }
    public int textLosyash = 0;
    public int textBonny = 0;

    private void Awake()
    {
        Instance = this;
    }
}







