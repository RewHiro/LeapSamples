using UnityEngine;
using System.Collections;



public class HandControllerConfig : MonoBehaviour {


    [SerializeField, TooltipAttribute("回した回数")]
    float turn_num_ = 1.5f;

    [SerializeField, Range(0.0f, 3.14f * 2),TooltipAttribute("認識できる範囲(円弧)")]
    float min_arc_ = 3.14f * 2;

    [SerializeField, TooltipAttribute("認識できる範囲(半径)")]
    float min_radius_ = 5.0f;

    public float turnNum { get { return turn_num_; } }
    public float minArc { get { return min_arc_; } }
    public float minRadius { get { return min_radius_; } }
}
