using System;
using System.Collections;
using UnityEngine;

namespace AnimationTool
{
	public class BaseBehaviour : MonoBehaviour
	{
		private void Invoke(Action action, float delay)
		{
			StartCoroutine(DelayedAction(action, delay));
		}

		private IEnumerator DelayedAction(Action action, float delay)
		{
			yield return new WaitForSeconds(delay);
			action?.Invoke();
		}
	}
}