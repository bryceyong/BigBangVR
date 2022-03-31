using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public int chapter = 0;
    public bool firstTime = true;
    public int grenadeCount = 0;
    public CanvasGroup uiElement;
    public GameObject canvas;
    // Start is called before the first frame update
    void Start()
    {
        chapter = 1;
    }

    // Update is called once per frame
    void Update()
    {

        if(chapter == 2 && firstTime)
        {
            transform.position = new Vector3(30.0f, 0.0f, 0f);
            firstTime = false;
            canvas.SetActive(true);
            FadeOut();
        }
        
    }

    // Start is called before the first frame update
    public void FadeOut()
    {
        StartCoroutine(FadeCanvasGroup(uiElement, uiElement.alpha, 0));
    }
    public IEnumerator FadeCanvasGroup(CanvasGroup cg, float start, float end, float lerpTime = 5.0f)
    {

        float _timeStartedLerping = Time.time;
        float _timeSinceStarted = Time.time -_timeStartedLerping;
        float percentageComplete = _timeSinceStarted / lerpTime;

        while(true)
        {
            _timeSinceStarted = Time.time - _timeStartedLerping;
            percentageComplete = _timeSinceStarted / lerpTime;
            float currentValue = Mathf.Lerp(start, end, percentageComplete);
            cg.alpha = currentValue;
            if(percentageComplete >= 1) break;
            yield return new WaitForEndOfFrame();
        }

        canvas.SetActive(false);
    }
}
