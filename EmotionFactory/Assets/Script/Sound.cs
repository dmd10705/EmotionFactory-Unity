using UnityEngine;

public class Sound : MonoBehaviour
{
    public float R = 3f;
    private float R2;
    public float pitch; //寫改成的pitch值
    void Start()
    {
        R2 = R;
        //------------
        //取得背景音樂
        //AudioSource source = GameObject.FindGameObjectWithTag("電視雜訊").GetComponent<AudioSource>();
        //source.Stop();  //暫停音樂
        //source.pitch = pitch;  //改變pitch
        //source.Play();  //開始音樂
        //------------
    }
    void Update()
    {
        R2 = R2 - Time.deltaTime;
        if (R2 <= 0)
        {
            //取得背景音樂
            AudioSource source = GameObject.FindGameObjectWithTag("電視雜訊").GetComponent<AudioSource>();
            source.Stop();  //暫停音樂
            source.pitch = pitch;  //改變pitch
            source.Play();  //開始音樂
            R2 = R;
            Debug.Log("當前frame與前一個frame的時間差為：" + Time.deltaTime + "秒");
        }
    }
    //--------------
    

   
    //--------------
}
