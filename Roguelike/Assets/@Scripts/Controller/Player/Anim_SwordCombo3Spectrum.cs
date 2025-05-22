using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.InputSystem.LowLevel;

public class Anim_SwordCombo3Spectrum : MonoBehaviour
{

    public GameObject[] Combo3Spectrum;
    public Transform tr;
    
    public float s1Pos = 1.2f;
    public float s2Pos = 2.4f;
    public float s3Pos = 1.8f;
    public float s4Pos = 2.4f;
    public float s5Pos = 2f;
    public float s6Pos = 2.2f;
    public float s7Pos = 2;

    private void Start()
    {
        tr =GetComponent<Transform>();
    }
    public void Spect1()
    {
        Vector3 rightOffset = tr.position + new Vector3(s1Pos, 0, 0);
        Vector3 leftOffset = tr.position + new Vector3(-s1Pos, 0, 0);
        if (tr.localScale.x == 1)
        {
            Instantiate(Combo3Spectrum[0],rightOffset, Quaternion.identity);
        }
        else if (tr.localScale.x == -1)
        {
            Instantiate(Combo3Spectrum[0], leftOffset, Quaternion.identity);
        }
    }
    public void Spect2()
    {
        Vector3 rightOffset = tr.position + new Vector3(s2Pos, 0, 0);
        Vector3 leftOffset = tr.position + new Vector3(-s2Pos, 0, 0);
        if (tr.localScale.x == 1)
        {
            Instantiate(Combo3Spectrum[1], rightOffset, Quaternion.identity);
        }
        else if (tr.localScale.x == -1)
        {
            Instantiate(Combo3Spectrum[1],leftOffset, Quaternion.identity);
        }
    }
    public void Spect3()
    {
        Vector3 rightOffset = tr.position + new Vector3(s3Pos, 0, 0);
        Vector3 leftOffset = tr.position + new Vector3(-s3Pos, 0, 0);
        if (tr.localScale.x == 1)
        {
            Instantiate(Combo3Spectrum[2], rightOffset, Quaternion.identity);
        }
        else if (tr.localScale.x == -1)
        {
            Instantiate(Combo3Spectrum[2],leftOffset, Quaternion.identity);
        }
    }
    public void Spect4()
    {
        Vector3 rightOffset = tr.position + new Vector3(s4Pos, 0, 0);
        Vector3 leftOffset = tr.position + new Vector3(-s4Pos, 0, 0);
        if (tr.localScale.x == 1)
        {
            Instantiate(Combo3Spectrum[3], rightOffset, Quaternion.identity);
        }
        else if (tr.localScale.x == -1)
        {
            Instantiate(Combo3Spectrum[3], leftOffset, Quaternion.identity);
        }
    }
    public void Spect5()
    {
        Vector3 rightOffset = tr.position + new Vector3(s5Pos, 0, 0);
        Vector3 leftOffset = tr.position + new Vector3(-s5Pos, 0, 0);
        if (tr.localScale.x == 1)
        {
            Instantiate(Combo3Spectrum[4], rightOffset, Quaternion.identity);
        }
        else if (tr.localScale.x == -1)
        {
            Instantiate(Combo3Spectrum[4], leftOffset, Quaternion.identity);
        }
    }
    public void Spect6()
    {
        Vector3 rightOffset = tr.position + new Vector3(s6Pos, 0, 0);
        Vector3 leftOffset = tr.position + new Vector3(-s6Pos, 0, 0);
        if (tr.localScale.x == 1)
        {
            Instantiate(Combo3Spectrum[5], rightOffset, Quaternion.identity);
        }
        else if (tr.localScale.x == -1)
        {
            Instantiate(Combo3Spectrum[5], leftOffset, Quaternion.identity);
        }
    }
    public void Spect7()
    {
        Vector3 rightOffset = tr.position + new Vector3(s2Pos, 0.2f, 0);
        Vector3 leftOffset = tr.position + new Vector3(-s2Pos, 0.2f, 0);
        if (tr.localScale.x == 1)
        {
            Instantiate(Combo3Spectrum[6],rightOffset, Quaternion.identity);
        }
        else if (tr.localScale.x == -1)

        {
            Instantiate(Combo3Spectrum[6], leftOffset, Quaternion.identity);
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
