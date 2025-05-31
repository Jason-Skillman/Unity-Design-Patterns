namespace FactoryPattern.AIBots
{
	using UnityEngine;

	public class Orc : Enemy
	{
		private float attack;

		public void Initialize(float attack)
		{
			this.attack = attack;
		}

		public override void Speak() => Debug.Log("Aaaaaaaa!");
	}
}
