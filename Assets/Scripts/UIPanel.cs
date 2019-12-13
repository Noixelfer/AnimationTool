using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace AnimationTool
{
	public class UIPanel : BaseBehaviour
	{
		private List<BaseAnimation> animations;


		private void Start()
		{
			animations = GetComponentsInChildren<BaseAnimation>().ToList();
			animations.ForEach(anim => anim.OnPanelInView());
		}
	}
}
