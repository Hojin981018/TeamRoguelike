using UnityEngine;
using UnityEngine.InputSystem.LowLevel;

public class Anim_SwordCombo3Spectrum : MonoBehaviour
{

    public GameObject[] Combo3Spectrum;
    public Transform tr;
    private void Start()
    {
        tr =GetComponent<Transform>();
    }
    public void Spect1()
    {
        if (tr.localScale.x == 1)
        {
            Instantiate(Combo3Spectrum[0], new Vector3(tr.position.x + 1.2f, 0, 0), Quaternion.identity);
        }
        else if (tr.localScale.x == -1)
        {
            Instantiate(Combo3Spectrum[0], new Vector3(tr.position.x - 1.2f, 0, 0), Quaternion.identity);
        }
    }
    public void Spect2()
    {
        if (tr.localScale.x == 1)
        {
            Instantiate(Combo3Spectrum[1], new Vector3(tr.position.x + 2.4f, 0, 0), Quaternion.identity);
        }
        else if (tr.localScale.x == -1)
        {
            Instantiate(Combo3Spectrum[1], new Vector3(tr.position.x - 2.4f, 0, 0), Quaternion.identity);
        }
    }
    public void Spect3()
    {
        if (tr.localScale.x == 1)
        {
            Instantiate(Combo3Spectrum[2], new Vector3(tr.position.x + 1.8f, 0, 0), Quaternion.identity);
        }
        else if (tr.localScale.x == -1)
        {
            Instantiate(Combo3Spectrum[2], new Vector3(tr.position.x - 1.8f, 0, 0), Quaternion.identity);
        }
    }
    public void Spect4()
    {
        if (tr.localScale.x == 1)
        {
            Instantiate(Combo3Spectrum[3], new Vector3(tr.position.x + 2.4f, 0, 0), Quaternion.identity);
        }
        else if (tr.localScale.x == -1)
        {
            Instantiate(Combo3Spectrum[3], new Vector3(tr.position.x - 2.4f, 0, 0), Quaternion.identity);
        }
    }
    public void Spect5()
    {
        if (tr.localScale.x == 1)
        {
            Instantiate(Combo3Spectrum[4], new Vector3(tr.position.x + 2, 0, 0), Quaternion.identity);
        }
        else if (tr.localScale.x == -1)
        {
            Instantiate(Combo3Spectrum[4], new Vector3(tr.position.x - 2, 0, 0), Quaternion.identity);
        }
    }
    public void Spect6()
    {
        if (tr.localScale.x == 1)
        {
            Instantiate(Combo3Spectrum[5], new Vector3(tr.position.x + 2.2f, 0, 0), Quaternion.identity);
        }
        else if (tr.localScale.x == -1)
        {
            Instantiate(Combo3Spectrum[5], new Vector3(tr.position.x - 2.2f, 0, 0), Quaternion.identity);
        }
    }
    public void Spect7()
    {
        if (tr.localScale.x == 1)
        {
            Instantiate(Combo3Spectrum[6], new Vector3(tr.position.x + 2, tr.position.y+0.2f, 0), Quaternion.identity);
        }
        else if (tr.localScale.x == -1)
        {
            Instantiate(Combo3Spectrum[6], new Vector3(tr.position.x - 2, tr.position.y+0.2f, 0), Quaternion.identity);
        }
    }
    public void TransformLerp()
    {
        // 캐릭터 스워드 콤보3 애니메이션 재생 후 위치 보간
        if (tr.localScale.x == 1)
        {
            tr.position += new Vector3(0.28f, 0, 0); 
        }
        else if (tr.localScale.x == -1)
        {
            tr.position += new Vector3(-0.28f, 0, 0); 
        }
    }
}
