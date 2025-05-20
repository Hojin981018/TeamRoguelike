using UnityEngine;

public class Define 
{
    public const string Horizontal = "Horizontal";
    public readonly static int isWalkHash = Animator.StringToHash("isWalk");
    public readonly static int isRunHash = Animator.StringToHash("isRun");
    public readonly static int isAttackHash = Animator.StringToHash("isAttack");
    public readonly static int isSkillHash = Animator.StringToHash("isSkill");
    public readonly static int ComboCountHash = Animator.StringToHash("ComboStack");
    public readonly static int HurtHash = Animator.StringToHash("Hurt");
}
