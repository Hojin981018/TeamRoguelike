using UnityEngine;

[CreateAssetMenu(fileName = "SkillData", menuName = "Skill/AttackSkill")]
public class SkillData : ScriptableObject   
{
    [Header("스킬 ID")]
    public string skillID;
    [Header("데미지 (계산 공식은 추후 설정)")]
    public float damage;
    [Header("스킬 히트수")]
    public int hitCount;
    [Header("공격 범위 설정")]
    public Vector2 hitBoxSize;
    [Header("히트박스 생성 위치 설정")]
    public float rangeOffset;
    
}
