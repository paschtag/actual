using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ShowData : MonoBehaviour
{
    public Text Speed;
    public Text Size;
    public Text Score;



    private void Awake()
    {
        Speed.text = KeepData.speed;
        Size.text = KeepData.slider.ToString();
        Score.text = KeepData.PlayerName + ", " + KeepData.PlayerScore.ToString();
    }


}
