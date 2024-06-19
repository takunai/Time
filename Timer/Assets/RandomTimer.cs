using UnityEngine;
using TMPro;

public class RandomTimer : MonoBehaviour
{
    public TMP_Text displayText;
    private int randomTime;

    void Start()
    {
        GenerateRandomTime();
    }

    void GenerateRandomTime()
    {
        randomTime = Random.Range(5, 11); // 5〜10のランダムな数値を生成
        displayText.text = randomTime + "秒ピッタリで止めろ！";
    }
}