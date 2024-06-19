using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ShowTimerText : MonoBehaviour
{
    public TMP_Text m_txtTimer;
    public GameTimer m_gameTimer;
    private void Update()
    {
        m_txtTimer.text = string.Format("{0:D2}:{1:D2}:{2:D2}",
            (int)m_gameTimer.CurrentTime / 60,
            (int)m_gameTimer.CurrentTime % 60,
            (int)(m_gameTimer.CurrentTime * 100) % 60
            );
    }
}