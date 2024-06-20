using UnityEngine;
using TMPro;

public class RandomTimer : MonoBehaviour
{
    public TMP_Text displayText;
    public ParticleSystem successParticles; // パーティクルシステムを参照
    private int randomTime;
    private float currentTime;
    private bool timerRunning = false;

    void Start()
    {
        GenerateRandomTime();
    }

    void Update()
    {
        if (timerRunning)
        {
            currentTime += Time.deltaTime;
            displayText.text = currentTime.ToString("F2");

            if (Input.GetKeyDown(KeyCode.Space)) // スペースキーでタイマーを止める
            {
                StopTimer();
            }
        }
    }

    void GenerateRandomTime()
    {
        randomTime = Random.Range(5, 11); // 5〜10のランダムな数値を生成
        displayText.text = randomTime + "秒ピッタリで止めろ！";
    }

    public void StartTimer()
    {
        timerRunning = true;
        currentTime = 0;
    }

    public void StopTimer()
    {
        timerRunning = false;

        if (Mathf.Abs(currentTime - randomTime) < 0.1f) // 0.1秒以内の誤差で成功とみなす
        {
            displayText.text = "成功！";
            successParticles.Play(); // パーティクルを再生
        }
        else
        {
            displayText.text = "失敗！";
        }
    }
}