namespace FactoryPattern.AIBots
{
	using UnityEngine;

	public class Gobin : Enemy
	{
		private int gold;

		public void Initialize(int gold)
		{
			this.gold = gold;
		}
		
		public override void Speak() => Debug.Log("Money");
	}
}
